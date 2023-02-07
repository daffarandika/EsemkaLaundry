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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar= true;
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string password = Helper.Hash(tbPassword.Text);
            string name = tbName.Text;
            Vars.dtEmployee = Helper.GetDataTable("select * from employee where name = '" + name + "' and password = '" + password + "'");
            if (Vars.dtEmployee.Rows.Count < 1)
            {
                Helper.ShowInfoDialog("Invalid", "Please Try Again, Your Data is not Valid!");
                return;
            }
            Hide();
            MainF mainF = new MainF();
            mainF.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbName.ResetText();
            tbPassword.ResetText();
        }
    }
}
