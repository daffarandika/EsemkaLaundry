using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laundry.Utils
{
    internal class Vars
    {
        public static string connectionString = "Data Source=DESKTOP-GHNE639;Initial Catalog=EsemkaLaundryDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public static DataTable dtEmployee
            = Helper.GetDataTable("select * from employee where id = 40");
    }
}
