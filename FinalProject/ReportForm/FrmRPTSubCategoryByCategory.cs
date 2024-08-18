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
    public partial class FrmRPTSubCategoryByCategory : Form
    {
        public FrmRPTSubCategoryByCategory()
        {
            InitializeComponent();
        }

        private void FrmRPTSubCategoryByCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'listCategoryDetails._ListCategoryDetails' table. You can move, or remove it, as needed.
            this.listCategoryDetailsTableAdapter.Fill(this.listCategoryDetails._ListCategoryDetails);
            this.rPTSubCategoryByParameterTableAdapter.Fill(this.dSRPTSubCategoryByCategory.RPTSubCategoryByParameter,Convert.ToInt32(comboBoxCategoryName.SelectedValue));
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
          
        }

        private void comboBoxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rPTSubCategoryByParameterTableAdapter.Fill(this.dSRPTSubCategoryByCategory.RPTSubCategoryByParameter, Convert.ToInt32(comboBoxCategoryName.SelectedValue));
            this.reportViewer1.RefreshReport();
        }
    }
}
