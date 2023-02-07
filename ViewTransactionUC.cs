using Laundry.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class ViewTransactionUC : UserControl
    {
        public ViewTransactionUC()
        {
            InitializeComponent();
            dgvHeader.Fill("select headerdeposit.id, customer.id as 'Customer ID', customer.name as 'Customer Name', employee.name as 'Employee Name', transactionDatetime, completeEstimationDatetime from headerdeposit join customer on customer.id = idcustomer join employee on employee.id = idEmployee");
            fillDetailDGV();
        }

        private void fillDetailDGV()
        {
            dgvDetail.Rows.Clear();
            using (var conn = Helper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select detaildeposit.id as 'id', service.name as 'Service Name', idPrepaidPackage as 'Prepaid Package ID', detaildeposit.priceUnit as 'Price per Unit', totalUnit, completeddatetime  from detaildeposit join service on service.id = idService", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvDetail.Rows.Add(reader["id"], reader["Service Name"], reader["Prepaid Package ID"], reader["Price per Unit"], reader["totalUnit"], reader["completeddatetime"]);
                }
            }
            foreach (DataGridViewRow row in dgvDetail.Rows) {
                if (row.Cells["completetime"].Value.ToString().Length == 0)
                    row.Cells["action"].Value = "Complete";
                else
                    row.Cells["action"] = new DataGridViewTextBoxCell();
            }
        }

        private void ViewTransactionUC_Load(object sender, EventArgs e)
        {

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = tbSearch.Text;
            DataTable dtCustomer = Helper.GetDataTable("select headerdeposit.id, customer.id as 'Customer ID', customer.name as 'Customer Name', employee.name as 'Employee Name', transactionDatetime, completeEstimationDatetime from headerdeposit join customer on customer.id = idcustomer join employee on employee.id = idEmployee where customer.name like '%"+searchQuery+"%'");
            DataTable dtEmployee = Helper.GetDataTable("select headerdeposit.id, customer.id as 'Customer ID', customer.name as 'Customer Name', employee.name as 'Employee Name', transactionDatetime, completeEstimationDatetime from headerdeposit join customer on customer.id = idcustomer join employee on employee.id = idEmployee where employee.name like '%"+searchQuery+"%'");
            DataTable dtDate = Helper.GetDataTable("select headerdeposit.id, customer.id as 'Customer ID', customer.name as 'Customer Name', employee.name as 'Employee Name', transactionDatetime, completeEstimationDatetime from headerdeposit join customer on customer.id = idcustomer join employee on employee.id = idEmployee where transactiondatetime like '%"+searchQuery+"%'");

            if (dtCustomer.Rows.Count > 0) dgvHeader.DataSource = dtCustomer;
            if (dtEmployee.Rows.Count > 0) dgvHeader.DataSource = dtEmployee;
            if (dtDate.Rows.Count > 0) dgvHeader.DataSource = dtDate;

            if (dtCustomer.Rows.Count + dtEmployee.Rows.Count + dtDate.Rows.Count == 0)
            {
                dgvHeader.DataSource = null;
            }

            if (tbSearch.Text.Length == 0)
            {
                dtCustomer.Rows.Clear();
                dtEmployee.Rows.Clear();
                dtDate.Rows.Clear();
            }
        }

        private void dgvDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                string id = dgvDetail.CurrentRow.Cells["detailid"].Value.ToString();
                string completeddatetime = DateTime.Now.ToString();
                Helper.RunQuery("update detaildeposit set completeddatetime = '" + completeddatetime + "' where id = '" + id + "'");
                fillDetailDGV();
            }
        }
    }
}
