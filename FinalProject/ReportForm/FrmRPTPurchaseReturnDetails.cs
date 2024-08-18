using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.ReportForm
{
    public partial class FrmRPTPurchaseReturnDetails : Form
    {
        public FrmRPTPurchaseReturnDetails()
        {
            InitializeComponent();
        }

        private void FrmRPTPurchaseReturnDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRPTPurchaseReturnDetails.RPTGetPurchaseReturnDetails' table. You can move, or remove it, as needed.
            this.rPTGetPurchaseReturnDetailsTableAdapter.Fill(this.dSRPTPurchaseReturnDetails.RPTGetPurchaseReturnDetails);

            this.reportViewer1.RefreshReport();
        }
    }
}
