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
    public partial class EmployeeUC : UserControl
    {
        CRUDStateManager stateManager = new CRUDStateManager();
        Control[] inputFields;
        Control[] inputFieldsNoID;
        Control[] nonCrudBTn;
        Control[] crudBTn;
        public EmployeeUC()
        {
            InitializeComponent();
            inputFields = new Control[]
            {
                tbAddress, tbCPassword, tbEmail, tbId, tbName, tbPhone, tbSalary, cmbJob, dtpDOB, tbPassword
            };
            inputFieldsNoID = new Control[]
            {
                tbAddress, tbCPassword, tbEmail, tbName, tbPhone, tbSalary, cmbJob, dtpDOB, tbPassword
            };
            nonCrudBTn = new Control[]
            {
                btnCancel, btnSave
            };
            crudBTn = new Control[]
            {
                btnInsert, btnUpdate
            };
            FillDGV();
            FillCMB();
            crudDestroy();
            tbSalary.Maximum = int.MaxValue;
            btnDelete.Enabled= false;
        }

        private void FillCMB()
        {
            cmbJob.Fill("select * from job", "id", "name");
        }

        private void FillDGV()
        {
            dgvEmp.Fill("select * from employee");
        }

        private void EmployeeUC_Load(object sender, EventArgs e)
        {

        }

        void reset()
        {
            Helper.Clear(inputFields);
            FillDGV();
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
            reset();
            FillDGV();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = tbSearch.Text;
            DataTable dtNames = Helper.GetDataTable("select * from employee where name like '%" + searchQuery + "%'");
            DataTable dtEmails = Helper.GetDataTable("select * from employee where email like '%" + searchQuery + "%'");
            DataTable dtPhones = Helper.GetDataTable("select * from employee where phonenumber like '%" + searchQuery + "%'");

            if (dtNames.Rows.Count > 0)
            {
                dgvEmp.DataSource = dtNames;
            }

            if (dtEmails.Rows.Count > 0)
            {
                dgvEmp.DataSource = dtEmails;
            }

            if (dtPhones.Rows.Count > 0)
            {
                dgvEmp.DataSource = dtPhones;
            }
            
            if (dtEmails.Rows.Count + dtPhones.Rows.Count + dtNames.Rows.Count == 0)
            {
                dgvEmp.DataSource = null;
            }

            if (tbSearch.Text.Length == 0)
            {
                dtEmails.Rows.Clear();
                dtNames.Rows.Clear();
                dtPhones.Rows.Clear();
            }
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            stateManager.SetState(CRUDStateManager.State.Insert);
            crudSetup();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            stateManager.SetState(CRUDStateManager.State.Update);
            crudSetup();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            stateManager.SetState(CRUDStateManager.State.Delete);
            string id = tbId.Text;
            if (Helper.AskForConfirmation() != DialogResult.Yes)
            {
                Helper.RunQuery("delete from employee where id = '" + id + "'");
            }
            reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            inputFields.ClearTinyError();
            if (
                Guard.FailsAgainstNull(inputFieldsNoID) ||
                Guard.FailsAgainstInvalidEmail(new Control[] { tbEmail }) ||
                Guard.FailsAgainstInvalidPhoneNumber(new Control[] { tbPhone }) ||
                Guard.FailsAgainstInvalidPassword(new Control[] { tbPassword })
            ) return;

            string id = tbId.Text;
            string query = "";
            string name = tbName.Text;
            string email = tbEmail.Text;
            string password = Helper.Hash(tbPassword.Text);
            string address = tbAddress.Text;
            string cPassword = Helper.Hash(tbCPassword.Text);
            string dateofbirth = dtpDOB.Value.ToString("yyyy-MM-dd");
            string idJob = cmbJob.SelectedValue.ToString();
            string salary = tbSalary.Text;
            string phonenumber = tbPhone.Text;

            
            switch (stateManager.state)
            {
                case CRUDStateManager.State.Insert:
                    if (password != cPassword)
                    {
                        Helper.ShowError(message: "Password and password confirmation does not match");
                        return;
                    }
                    query = "insert into employee (name, email, password, address, dateofbirth, idJob, salary, phonenumber) values ('" + name + "', '" + email + "', '" + password + "', '" + address + "', '" + dateofbirth + "', '" + idJob + "', '" + salary + "', '" + phonenumber + "')";
                    reset();
                    crudDestroy();
                    break;

                case CRUDStateManager.State.Update:
                    if (password != cPassword)
                    {
                        Helper.ShowError(message: "Password and password confirmation does not match");
                        return;
                    }
                    query = "update employee set name = '"+name+"', email = '"+email+"', password = '"+password+"', address = '"+address+"' ,dateofbirth = '"+dateofbirth+"', idjob = '"+idJob+"', salary = '"+salary+"', phonenumber = '"+phonenumber+"' where id = '"+id+"'";
                    break;
            }
            Helper.RunQuery(query);
            crudDestroy();
        }

        private void dgvEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            DataGridViewRow row = dgvEmp.CurrentRow;
            tbName.Text = row.Cells["name"].Value.ToString();
            tbEmail.Text = row.Cells["email"].Value.ToString();
            tbPhone.Text = row.Cells["phoneNumber"].Value.ToString();
            tbAddress.Text = row.Cells["address"].Value.ToString();
            tbPassword.Text = row.Cells["password"].Value.ToString();
            tbSalary.Text = row.Cells["salary"].Value.ToString();
            tbId.Text = row.Cells["id"].Value.ToString();
            dtpDOB.Value = (DateTime)row.Cells["dateofbirth"].Value;
            cmbJob.SelectedValue = row.Cells["idjob"].Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            reset();
            crudDestroy();
        }
    }
}
