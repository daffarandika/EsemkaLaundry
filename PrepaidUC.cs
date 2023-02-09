using Laundry.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class PrepaidUC : UserControl
    {
        DataTable dtCustomer;
        Control[] inputField;
        Control[] inputFieldNoID;
        public PrepaidUC()
        {
            InitializeComponent();
            dgvPrepaid.Fill("select prepaidpackage.id as 'Prepaid Package ID', customer.name as 'Customer', (category.name + ' ' + convert(nvarchar(5),totalUnit) + ' ' + unit.name) as 'Package Name' from prepaidpackage join package on idPackage = package.id join customer on idCustomer = customer.id join service on idService = service.id join category on idCategory = category.id join unit on idUnit = unit.id");
            cmbPackage.Fill("select package.id, (category.name + ' ' + convert(nvarchar(5),totalUnit) + ' ' + unit.name) as 'name' from package join service on idService = service.id join category on idCategory = category.id join unit on idUnit = unit.id where package.id not in (select idPackage from prepaidpackage)", "id", "name");
            inputField = new Control[]
            {
                tbPrice, tbPhone, cmbPackage, tbID
            };
            inputFieldNoID = new Control[]
            {
                tbPrice, tbPhone, cmbPackage
            };
            tbID.Text = "";
            tbPrice.Maximum = long.MaxValue;
        }

        private void PrepaidUC_Load(object sender, EventArgs e)
        {

        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new CustomerF().ShowDialog();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Guard.FailsAgainstNull(inputField)) return;

            string idCustomer = dtCustomer.Rows[0]["id"].ToString();
            string idPackage = tbID.Text;
            string price = tbPrice.Text;
            string startDateTime = DateTime.Now.ToString();
            string query = "insert into prepaidpackage (idCustomer, idPackage, price, startDateTime) values ('" + idCustomer + "', '" + idPackage + "', '" + price + "', '" + startDateTime + "')";
            Helper.RunQuery(query);
            reset();
        }

        private void cmbPackage_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbID.Text = cmbPackage.SelectedValue.ToString();
            string id = tbID.Text;
            tbPrice.Value = Convert.ToInt32(Helper.GetDataTable("select price from package where id  = '" + id + "'").Rows[0]["price"]);
            tbPhone.Text = Helper.GetDataTable("select phonenumber from customer where id in (select idCustomer from prepaidpackage where id = '"+id+"')").Rows[0]["phonenumber"].ToString();
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            if (tbID.Text.Length == 0)
            {
                return;
            }
            string id = tbID.Text;
            if (Helper.GetDataTable("select * from package where id = '" + id + "'").Rows.Count == 0)
            {
                Helper.ShowError(message: "Package not found");
                Helper.Clear(inputField);
                return;
            }
        }
        void reset()
        {
            lblName.Text = "[Name]";
            lblAddress.Text = "[Address]";
            Helper.Clear(inputField);
            dgvPrepaid.Fill("select prepaidpackage.id as 'Prepaid Package ID', customer.name as 'Customer', (category.name + ' ' + convert(nvarchar(5),totalUnit) + ' ' + unit.name) as 'Package Name' from prepaidpackage join package on idPackage = package.id join customer on idCustomer = customer.id join service on idService = service.id join category on idCategory = category.id join unit on idUnit = unit.id"); ;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = tbSearch.Text;
            DataTable dtNames = Helper.GetDataTable("select prepaidpackage.id, customer.name as 'Customer', (category.name + ' ' + convert(nvarchar(5),totalUnit) + ' ' + unit.name) as 'Package Name'  from prepaidpackage join package on idPackage = package.id join customer on idCustomer = customer.id join service on idService = service.id join category on idCategory = category.id join unit on idUnit = unit.id where (category.name + ' ' +convert(nvarchar(5),totalUnit) + ' ' + unit.name) like '%"+searchQuery+"%'");
            DataTable dtCustomer = Helper.GetDataTable("select prepaidpackage.id, customer.name as 'Customer', (category.name + ' ' + convert(nvarchar(5),totalUnit) + ' ' + unit.name) as 'Package Name'  from prepaidpackage join package on idPackage = package.id join customer on idCustomer = customer.id join service on idService = service.id join category on idCategory = category.id join unit on idUnit = unit.id where customer.name like '%" + searchQuery + "%'");

            if (dtNames.Rows.Count > 0)
            {
                dgvPrepaid.DataSource = dtNames;
            }

            if (dtCustomer.Rows.Count > 0)
            {
                dgvPrepaid.DataSource = dtCustomer;
            }
            
            if (dtNames.Rows.Count + dtCustomer.Rows.Count == 0)
            {
                dgvPrepaid.DataSource = null;
            }

            if (tbSearch.Text.Length == 0)
            {
                dtNames.Rows.Clear();
                dtCustomer.Rows.Clear();
            }
        }
    }
}
