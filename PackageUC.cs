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
    public partial class PackageUC : UserControl
    {
        Control[] inputFields;
        Control[] inputFieldsNoId;
        Control[] crudButtons;
        Control[] nonCrudButtons;
        CRUDStateManager stateManager = new CRUDStateManager();
        public PackageUC()
        {
            InitializeComponent();
            dgvPackage.Fill("select package.id, service.name, totalUnit, price from package join service on idService = service.id");
            inputFields = new Control[] 
            {
                tbId, cmbService, tbPrice, tbTotalUnit, tbSearch
            };
            inputFieldsNoId = new Control[] 
            {
                cmbService, tbPrice, tbTotalUnit
            };
            crudButtons = new Control[]
            {
                btnInsert, btnUpdate, btnDelete
            };
            nonCrudButtons = new Control[]
            {
                btnSave, btnCancel
            };
            crudDestroy();
            tbPrice.Maximum = long.MaxValue;
            cmbService.Fill("select * from service", "id", "name");
            btnDelete.Enabled = false;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tbSearch.Text;
            DataTable dtName = Helper.GetDataTable("select package.id, service.name, totalUnit, price from package join service on idService = service.id where service.name like '%"+search+"%'");
            DataTable dtTotal = Helper.GetDataTable("select package.id, service.name, totalUnit, price from package join service on idService = service.id where totalunit like '%"+search+"%'");
            DataTable dtPrice = Helper.GetDataTable("select package.id, service.name, totalUnit, price from package join service on idService = service.id where price like '%"+search+"%'");

            if (dtName.Rows.Count > 0) dgvPackage.DataSource = dtName;
            if (dtTotal.Rows.Count > 0) dgvPackage.DataSource = dtTotal;
            if (dtPrice.Rows.Count > 0) dgvPackage.DataSource = dtPrice;

            if (dtName.Rows.Count + dtTotal.Rows.Count + dtPrice.Rows.Count == 0)
            {
                dgvPackage.DataSource = null;
            }

            if (tbSearch.Text.Length == 0)
            {
                dtName.Rows.Clear();
                dtTotal.Clear();
                dtPrice.Clear();
                dgvPackage.Fill("select package.id, service.name, totalUnit, price from package join service on idService = service.id");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query="";
            string id = tbId.Text;
            string idservice = cmbService.SelectedValue.ToString();
            string totalunit = tbTotalUnit.Value.ToString();
            string price = tbPrice.Value.ToString();
            switch (stateManager.state)
            {
                case CRUDStateManager.State.Insert:
                    query = "insert into package (idservice, totalunit, price) values ('" + idservice + "', '" + totalunit + "', '" + price + "')";
                    break;
                default:
                    query = "update package set idservice = '" + idservice + "', totalunit = '" + totalunit + "', price = '" + price + "' where id = '" + id + "'";
                    break;
            }
            Helper.RunQuery(query);
            crudDestroy();
            dgvPackage.Fill("select package.id, service.name, totalUnit, price from package join service on idService = service.id");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            crudDestroy();
        }

        private void PackageUC_Load(object sender, EventArgs e)
        {

        }
        
        void crudSetup()
        {
            Helper.Enable(nonCrudButtons);
            Helper.Disable(crudButtons);
        }

        void crudDestroy()
        {
            Helper.Disable(nonCrudButtons);
            Helper.Enable(crudButtons);
            Helper.Disable(inputFields);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            crudSetup();
            string id = tbId.Text;
            if (Helper.AskForConfirmation() != DialogResult.Yes) return;
            Helper.RunQuery("delete from package where id = '" + id + "'");
            dgvPackage.Fill("select package.id, service.name, totalUnit, price from package join service on idService = service.id");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            crudSetup();
            stateManager.SetState(CRUDStateManager.State.Update);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            crudSetup();
            stateManager.SetState(CRUDStateManager.State.Insert);
        }

        private void dgvPackage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvPackage.Rows[e.RowIndex];
            tbId.Text = row.Cells["id"].Value.ToString();
            cmbService.Text = row.Cells["name"].Value.ToString();
            tbTotalUnit.Text = row.Cells["totalunit"].Value.ToString();
            tbPrice.Text = row.Cells["price"].Value.ToString();
            btnDelete.Enabled = true;
        }

        void reset()
        {

        }
    }
}
