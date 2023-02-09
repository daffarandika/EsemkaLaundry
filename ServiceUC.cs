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
    public partial class ServiceUC : UserControl
    {
        CRUDStateManager stateManager = new CRUDStateManager();
        Control[] inputFields;
        Control[] inputFieldsNoID;
        Control[] nonCrudBTn;
        Control[] crudBTn;
        public ServiceUC()
        {
            InitializeComponent();
            tbPrice.Maximum = int.MaxValue;
            FillDGV();
            inputFields = new Control[]
            {
                tbName, tbDuration, tbPrice, cmbCategory, cmbUnit, tbId
            };
            inputFieldsNoID = new Control[]
            {
                tbName, tbDuration, tbPrice, cmbCategory, cmbUnit
            };
            crudBTn = new Control[]
            {
                btnInsert, btnUpdate
            };
            nonCrudBTn = new Control[]
            {
                btnSave, btnCancel, btnDelete
            };
            cmbCategory.Fill("select * from category", "id", "name");
            cmbUnit.Fill("select * from unit", "id", "name");
            crudDestroy();
        }

        void reset()
        {
            Helper.Clear(inputFields);
            FillDGV();
        }

        private void FillDGV()
        {
            dgvService.Fill( "select service.id as 'Service ID', service.name as 'Service Name', category.name as 'Category', Unit.name as 'Unit', priceUnit as 'Price', estimationDuration as 'Estimated Duration' from service join category on idCategory = category.id join unit on idUnit = unit.id");
        }

        void crudSetup()
        {
            Helper.Disable(crudBTn);
            Helper.Enable(inputFields);
            Helper.Enable(nonCrudBTn);
        }
        void crudDestroy()
        {
            stateManager.SetState(CRUDStateManager.State.Default);
            Helper.Enable(crudBTn);
            Helper.Disable(inputFields);
            Helper.Disable(nonCrudBTn);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = tbSearch.Text;
            string baseQuery = "select service.id as 'Service ID', service.name as 'Service Name', category.name as 'Category', Unit.name as 'Unit', priceUnit as 'Price', estimationDuration as 'Estimated Duration' from service join category on idCategory = category.id join unit on idUnit = unit.id";
            DataTable dtService = Helper.GetDataTable(baseQuery + " where service.name like '%"+ searchQuery +"%' ");
            DataTable dtUnit = Helper.GetDataTable(baseQuery + " where unit.name like '%"+ searchQuery +"%' ");
            DataTable dtCategory = Helper.GetDataTable(baseQuery + " where category.name like '%"+ searchQuery +"%' ");
            DataTable dtPrice = Helper.GetDataTable(baseQuery + " where priceunit like '%"+ searchQuery +"%' ");

            if (dtService.Rows.Count > 0)
            {
                dgvService.DataSource = dtService;
            }

            if (dtUnit.Rows.Count > 0)
            {
                dgvService.DataSource = dtUnit;
            }

            if (dtCategory.Rows.Count > 0)
            {
                dgvService.DataSource = dtCategory;
            }

            if (dtPrice.Rows.Count > 0)
            {
                dgvService.DataSource = dtPrice;
            }
            
            if (dtService.Rows.Count + dtCategory.Rows.Count + dtUnit.Rows.Count + dtPrice.Rows.Count == 0)
            {
                dgvService.DataSource = null;
            }

            if (tbSearch.Text.Length == 0)
            {
                dtUnit.Rows.Clear();
                dtService.Rows.Clear();
                dtCategory.Rows.Clear();
                dtPrice.Rows.Clear();
            }
        }

        private void ServiceUC_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = tbId.Text;
            if (Helper.AskForConfirmation() != DialogResult.Yes) return;
            Helper.RunQuery("delete from service where id = '"+id+"'");
            reset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            stateManager.SetState(CRUDStateManager.State.Update);
            crudSetup();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            stateManager.SetState(CRUDStateManager.State.Insert);
            crudSetup();
        }

        private void dgvService_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvService.CurrentRow;
            tbDuration.Text = row.Cells["Estimated Duration"].Value.ToString();
            tbName.Text = row.Cells["Service Name"].Value.ToString();
            tbPrice.Value = Convert.ToInt32(row.Cells["Price"].Value);
            tbId.Text = row.Cells["Service ID"].Value.ToString();
            cmbCategory.Text = row.Cells["Category"].Value.ToString();
            cmbUnit.Text = row.Cells["Unit"].Value.ToString();
            btnDelete.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
            crudDestroy();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if ( Guard.FailsAgainstNull(inputFieldsNoID) ) return; 
            // iniipe
            string query = "";
            string id = tbId.Text;
            string name = tbName.Text;
            string idCategory = cmbCategory.SelectedValue.ToString();
            string idUnit = cmbUnit.SelectedValue.ToString();
            string priceunit = tbPrice.Value.ToString();
            string estimationduration = tbDuration.Text.ToString();
            
            switch (stateManager.state)
            {
                case CRUDStateManager.State.Insert:
                    query = "insert into service (name, idCategory, idUnit, priceUnit, estimationduration) values ('" + name + "', '" + idCategory + "', '" + idUnit + "', '" + priceunit + "', '" + estimationduration + "')";
                    break;

                case CRUDStateManager.State.Update:
                    query = "update service set name = '" + name + "', idCategory = '" + idCategory + "', idUnit = '" + idUnit + "', priceunit = '" + priceunit + "', estimationduration = '" + estimationduration + "' where id = '" + id + "'";
                    break;
            }
            Helper.RunQuery(query);
            reset();
            crudDestroy();
        }
    }
}
