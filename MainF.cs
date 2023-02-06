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
    public partial class MainF : Form
    {
        public MainF()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += updateTime;
            timer.Start();
            lblHello.Text = $"Hello, {Vars.dtEmployee.Rows[0]["name"]}";
        }

        private void updateTime(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("yyyy MMMM dd HH:mm:ss");
        }

        private void MainF_Load(object sender, EventArgs e)
        {

        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new EmployeeUC());
        }

        private void btnPrepaid_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new PrepaidUC());
        }

        private void btnTransaction_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new TransactionUC());
        }

        private void btnPackage_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new PackageUC());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ServiceUC());
        }

        private void btnViewTransaction_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(new ViewTransactionUC());
        }
    }
}
