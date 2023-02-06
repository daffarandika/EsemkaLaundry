using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry.Utils
{
    internal class Guard
    {
        public static bool FailsAgainstNull(Control[] controls)
        {
            bool res = false;
            foreach (Control control in controls) {
                if (control is TextBox)
                {
                    if (control.Text.Length == 0)
                    {
                        res = true;
                        control.ShowTinyError();
                    }
                }
                if (control is ComboBox)
                {
                    if ((control as ComboBox).SelectedIndex== -1)
                    {
                        res = true;
                        control.ShowTinyError();
                    }
                }
            }
            if (res) Helper.ShowError(message: "Inputs cannot be empty");
            return res;
        }
        public static bool FailsAgainstInvalidEmail(Control[] controls)
        {
            bool res = false;
            Regex regex = new Regex(@"@");
            foreach (Control control in controls)
            {
                if (!regex.IsMatch(control.Text))
                {
                    control.ShowTinyError("Invalid Email Address");
                    res = true;
                }
            }
            return res;
        }

        public static bool FailsAgainstInvalidPhoneNumber(Control[] controls)
        {
            bool res = false;
            Regex regex = new Regex(@"^\+[0-9]");
            foreach (Control control in controls)
            {
                if (!regex.IsMatch(control.Text))
                {
                    control.ShowTinyError("Invalid Phone Number");
                    res = true;
                }
            }
            return res;
        }

        public static bool FailsAgainstInvalidPassword(Control[] controls)
        {
            bool res = false;
            Regex regex = new Regex(@"^.*(?=[^A-Z]*[A-Z])(?=[^a-z]*[a-z])(?=[^0-9]*[0-9])(?=[^!@#$?]*[!@#$?])");
            foreach (Control control in controls)
            {
                if (!regex.IsMatch(control.Text))
                {
                    control.ShowTinyError("Password must have atleast one Uppercase Letter, one Lowercase Letter, one Number and one Symbol.");
                    res = true;
                }
            }
            return res;
        }
    }
}
