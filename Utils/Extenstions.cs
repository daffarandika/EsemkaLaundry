using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry.Utils
{
    public static class Extenstions
    {
        public static void Fill(this DataGridView dgv, string query)
        {
            DataTable dt = Helper.GetDataTable(query);
            dgv.DataSource = dt;
            dgv.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows= false;
            dgv.MultiSelect= false;
        }
        public static void Fill(this ComboBox cmb, string query, string valueMember, string displayMember)
        {
            DataTable dt = Helper.GetDataTable(query);
            cmb.DataSource= dt;
            cmb.ValueMember= valueMember;
            cmb.DisplayMember= displayMember;
            cmb.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb.SelectedIndex = -1;
        }
        public static void ShowTinyError(this Control c, string message = "Invalid Input")
        {
            ErrorProvider ep = new ErrorProvider();
            ep.SetError(c,message);
        }
    }
}
