using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry.Utils
{
    internal class Guard
    {
        public static bool FailAgainstNull(Control[] controls)
        {
            bool res = false;
            foreach (Control control in controls) {
                if (control is TextBox)
                {
                    if (control.Text.Length < 1)
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
            Helper.ShowError(message: "Inputs cannot be empty");
            return res;
        }
    }
}
