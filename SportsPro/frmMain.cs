using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SportsPro
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }


        private void mnuCustomerInput_Click(object sender, EventArgs e)
        {
            frmCustomerInput ci = new frmCustomerInput();
            ci.ShowDialog();
        }

        private void customerMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomerMaintenance cm = new frmCustomerMaintenance();
            cm.ShowDialog();

        }
    }
}
