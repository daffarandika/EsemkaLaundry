using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry.Utils
{
    internal class Helper
    {
        public static SqlConnection GetConnection() => new SqlConnection(Vars.connectionString);
        public static DataTable GetDataTable(string query)
        {
            DataTable dt = new DataTable();
            using (var conn = Helper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                return dt;
            }
        }
        
        public static string Hash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] res = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(input));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in res)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public static bool QueryHasRows(string query)
        {
            using (var conn = Helper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                SqlDataReader sdr = cmd.ExecuteReader();
                sdr.Read();
                return sdr.HasRows;
            }
        }
        public static void ShowInfoDialog(string title = "Information", string message = ".")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Clear(Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Text = string.Empty;
                if (control is ComboBox)
                {
                    try
                    {
                        ((ComboBox)control).SelectedIndex = -1;
                    } catch
                    {

                    }
                }
            }
        }
        public static void Enable(Control[] controls)
        {
            foreach (Control c in controls)
            {
                c.Enabled = true;
            }
        }
        public static void Disable(Control[] controls)
        {
            foreach (Control c in controls)
            {
                c.Enabled = false;
            }
        }
        public static void ShowError(string title = "Error", string message = "Input is invalid")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static DialogResult AskForConfirmation(string title = "Confirmation", string message = "Are you sure ?")
        {
            return MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public static void RunQuery(string query)
        {
            using (var conn = Helper.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
            }
        }
    }
}
