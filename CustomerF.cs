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
    public partial class CustomerF : Form
    {
        public CustomerF()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            (new Control[] { tbName, tbAddress, tbPhoneNumber }).ClearTinyError();
            if (Guard.FailsAgainstNull(new Control[] { tbName, tbAddress, tbPhoneNumber }))
            {
                return;
            }
            if (Guard.FailsAgainstInvalidPhoneNumber(new Control[] {tbPhoneNumber}))
            {
                Helper.ShowError(message: "Invalid Phone Number");
                return;
            }
            string name = tbName.Text;
            string address = tbAddress.Text;
            string phoneNumber = tbPhoneNumber.Text;
            Helper.RunQuery("insert into customer (name, address, phoneNumber) values ('" + name + "', '" + address + "', '" + phoneNumber + "')");
            Helper.Clear(new Control[] { tbName, tbAddress, tbPhoneNumber });
            Helper.ShowInfoDialog(message: "A new customer has been addedd");
        }
    }
}
