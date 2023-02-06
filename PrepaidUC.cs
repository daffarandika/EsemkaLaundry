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
    public partial class PrepaidUC : UserControl
    {
        public PrepaidUC()
        {
            InitializeComponent();
            dgvPrepaid.Fill("select prepaidpackage.id as 'Prepaid Package ID', customer.name as 'Customer', (category.name + ' ' + convert(nvarchar(5),totalUnit) + ' ' + unit.name) as 'Package Name' from prepaidpackage join package on idPackage = package.id join customer on idCustomer = customer.id join service on idService = service.id join category on idCategory = category.id join unit on idUnit = unit.id");
        }

        private void PrepaidUC_Load(object sender, EventArgs e)
        {

        }
    }
}
