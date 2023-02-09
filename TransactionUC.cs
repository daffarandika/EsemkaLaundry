using Laundry.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class TransactionUC : UserControl
    {
        DataTable dtTransaction = new DataTable();
        DataTable dtService = new DataTable();
        DataTable dtCustomer = new DataTable();
        List<string> serviceIds = new List<string>();
        Control[] inputField;
        int totalHours = 0;
        public TransactionUC()
        {
            InitializeComponent();
            cmbService.Fill("select * from service", "id", "name");
            for (int i = 0; i < dgvTransaction.Rows.Count; i++)
            {
                var btnCol = (DataGridViewButtonCell)dgvTransaction.Rows[i].Cells["action"];
                btnCol.Value = "Add";
            }
            inputField = new Control[]
            {
                tbPhone, tbPrice, tbTotal, cmbService
            };
            dgvTransaction.AllowUserToAddRows= false;
            tbTotal.Maximum = int.MaxValue;
        }

        void AddRow(string service, string prepaidpackage, string priceperunit, string totalunit, string subtotal)
        {
            dgvTransaction.Rows.Add(service, prepaidpackage, priceperunit, totalunit, subtotal);
            for (int i = 0; i < dgvTransaction.Rows.Count; i++)
            {
                var btnCol = (DataGridViewButtonCell)dgvTransaction.Rows[i].Cells["action"];
                btnCol.Value = "Remove";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerF c = new CustomerF();
            c.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = tbPhone.Text;
            DataTable dt = Helper.GetDataTable("select * from customer where phonenumber like '%" + searchQuery + "%'");
            if (dt.Rows.Count > 0)
            {
                lblName.Text = dt.Rows[0]["name"].ToString();
                lblAddress.Text = dt.Rows[0]["Address"].ToString();
            } else
            {
                lblName.Text = "[Name]";
                lblAddress.Text = "[Address]";
            }
            dtCustomer = dt;
            if (tbPhone.Text.Length < 1)
            {
                lblName.Text = "[Name]";
                lblAddress.Text = "[Address]";
            }
        }

        private void TransactionUC_Load(object sender, EventArgs e)
        {

        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cmbService.SelectedValue.ToString(); 
            DataTable dtService = Helper.GetDataTable("select category.name as 'category', priceunit, service.name as 'service' from service join unit on idUnit = unit.id join category on idCategory = category.id where service.id = '"+id+"'");
            tbPrice.Text = dtService.Rows[0]["priceunit"].ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new Control[] { cmbService, tbPrice, tbTotal }).ClearTinyError();
            if (Guard.FailsAgainstNull(new Control[] {cmbService, tbPrice, tbTotal})) return;

            string id = cmbService.SelectedValue.ToString(); 
            dtService = Helper.GetDataTable("select category.name as 'category', priceunit, service.name as 'service', estimationduration from service join unit on idUnit = unit.id join category on idCategory = category.id where service.id = '"+id+"'");
            string category = dtService.Rows[0]["category"].ToString();
            string priceunit = dtService.Rows[0]["priceunit"].ToString();
            string prepaidpacakge = (cbPrepaid.Checked) ? dtService.Rows[0]["service"].ToString() : "";
            string totalunit = tbTotal.Value.ToString();
            string subtotal = (!cbPrepaid.Checked) ? (Math.Round(Convert.ToDecimal(totalunit) * Convert.ToDecimal(priceunit))).ToString() : "0";
            if (dtService.Rows.Count > 0)
            {
                AddRow(category, prepaidpacakge, priceunit, totalunit, subtotal);
            }
            updateTotalPrice();
            updateTotalTime();
            serviceIds.Add(cmbService.SelectedValue.ToString());
        }

        private void updateTotalTime()
        {
            foreach (DataRow row in dtService.Rows)
            {
                totalHours += Convert.ToInt32(row["estimationDuration"]);
            }
            int days = (totalHours / 24);
            int hours = (totalHours% 24);
            lblTime.Text = days.ToString() + " Days " + hours.ToString() + " Hours ";
        }

        private void updateTotalPrice()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvTransaction.Rows)
            {
                total += Convert.ToDecimal(row.Cells["subtotal"].Value);
            }
            lblTotal.Text = total.ToString();
        }

        private void dgvTransaction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                dgvTransaction.Rows.RemoveAt(e.RowIndex); 
                serviceIds.RemoveAt(e.RowIndex);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            inputField.ClearTinyError();
            if (Guard.FailsAgainstNull(inputField))
            {
                return;
            }
            try { 
                string time = lblTime.Text;
                int daysTextIndex = 0;
                int endOfDaysIndex = 0; // end of days index
                int startOfHoursIndex = 0; // start of hours index
                for (int i = 0; i < time.Length; i++)
                {
                    if (time[i] == 'D')
                    {
                        daysTextIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < time.Length; i++)
                {
                    if (time[i] == 's')
                    {
                        endOfDaysIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < time.Length; i++)
                {
                    if (time[i] == 'H')
                    {
                        startOfHoursIndex = i;
                        break;
                    }
                }
                int days = Convert.ToInt32(time.Remove(daysTextIndex));
                int hours = Convert.ToInt32(time.Substring(endOfDaysIndex + 1, (startOfHoursIndex - 1) - (endOfDaysIndex + 1)));
                string completeestimationdatetime = (DateTime.Now.Add(new TimeSpan(days, hours, 0, 0)).ToString());
                string idcustomer = dtCustomer.Rows[0]["id"].ToString();
                string idemployee = Vars.dtEmployee.Rows[0]["id"].ToString();
                string transactiondatetime = DateTime.Now.ToString();
                string queryHeaderdeposit = "insert into headerdeposit (idcustomer, idemployee, transactiondatetime, completeestimationdatetime) values ('"+idcustomer+"', '"+idemployee+"', '"+transactiondatetime+"', '"+completeestimationdatetime+"')";
                Helper.RunQuery(queryHeaderdeposit);
                string iddeposit = Helper.GetDataTable("select max(id) as id from headerdeposit").Rows[0]["id"].ToString();
                for (int i = 0; i < dgvTransaction.Rows.Count; i++)
                {
                    string idservice = serviceIds[i];
                    string totalunit = dgvTransaction.Rows[i].Cells["totalUnit"].Value.ToString();
                    string price = dgvTransaction.Rows[i].Cells["priceperunit"].Value.ToString();
                    string queryPackage = "insert into package (idservice, totalunit, price) values ('" + idservice + "', '" + totalunit + "', '" + price + "')";
                    Helper.RunQuery(queryPackage);
                }
                string idpackage = Helper.GetDataTable("select max(id) as id from package").Rows[0]["id"].ToString();
                for (int i = 0; i < dgvTransaction.Rows.Count; i++)
                { 
                    string idservice = serviceIds[i];
                    string totalunit = dgvTransaction.Rows[i].Cells["totalUnit"].Value.ToString();
                    string price = dgvTransaction.Rows[i].Cells["priceperunit"].Value.ToString();
                    string idprepaidpackage = "";
                    if (dgvTransaction.Rows[i].Cells["prepaidpackage"].Value.ToString().Length >= 0)
                    {
                        string startDateTime = DateTime.Now.ToString();
                        string queryPrepaidpackage = "insert into prepaidpackage (idcustomer, idpackage, price, startDateTime) values ('" + idcustomer + "', '" + idpackage + "', '" + price + "', '" + startDateTime + "')";
                        Helper.RunQuery(queryPrepaidpackage);
                        idprepaidpackage = Helper.GetDataTable("select max(id) as id from prepaidpackage").Rows[0]["id"].ToString();
                        Helper.RunQuery("insert into detaildeposit (iddeposit, idservice, idprepaidpackage, priceunit, totalunit) values ('" + iddeposit + "', '" + idservice + "', '" + idprepaidpackage + "', '" + price + "', '" + totalunit + "')"); 
                    }
                    string priceunit = price;
                    string queryDetailDeposit = "insert into detaildeposit (iddeposit, idservice, priceunit, totalunit) values ('" + iddeposit + "', '" + idservice + "', '" + priceunit + "', '" + totalunit + "')";
                    Helper.RunQuery(queryDetailDeposit);
                }
                reset();
                Helper.ShowInfoDialog(message: "Successfully added the transaction");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
            }
        }

        void reset()
        {
            try
            {
                dgvTransaction.DataSource = null;
                tbPhone.Text = string.Empty;
                tbPrice.Text = string.Empty;
                tbTotal.Value = 0;
                cmbService.SelectedIndex = -1;
            } catch (Exception ex)
            {

            }
        }
    }
}
