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
    public partial class FrmRPTSubCategoryList : Form
    {
        public FrmRPTSubCategoryList()
        {
            InitializeComponent();
        }

        private void FrmRPTSubCategoryList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSRPTSubCategoryList.RPTGetSubCategoryList' table. You can move, or remove it, as needed.
            this.rPTGetSubCategoryListTableAdapter.Fill(this.dSRPTSubCategoryList.RPTGetSubCategoryList);

            this.reportViewer1.RefreshReport();
        }
    }
}
