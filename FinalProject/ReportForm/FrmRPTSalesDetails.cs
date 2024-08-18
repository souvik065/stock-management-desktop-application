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
    public partial class FrmRPTSalesDetails : Form
    {
        public FrmRPTSalesDetails()
        {
            InitializeComponent();
        }

        private void FrmRPTSalesDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRPTSalesDetails.RPTGetSaleDetail' table. You can move, or remove it, as needed.
            this.rPTGetSaleDetailTableAdapter.Fill(this.dSRPTSalesDetails.RPTGetSaleDetail);

            this.reportViewer1.RefreshReport();
        }
    }
}
