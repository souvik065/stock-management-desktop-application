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
    public partial class FrmRPTProductReportByParameters : Form
    {
        public FrmRPTProductReportByParameters()
        {
            InitializeComponent();
        }

        private void FrmRPTProductReportByParameters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'listCategoryDetails._ListCategoryDetails' table. You can move, or remove it, as needed.
            this.listCategoryDetailsTableAdapter.Fill(this.listCategoryDetails._ListCategoryDetails);
            this.rPTGetProductBySubCategoryTableAdapter.Fill(this.dSRPTProductDetialByParameters.RPTGetProductBySubCategory, Convert.ToInt32(comboBoxSubCategory.SelectedValue),Convert.ToInt32(comboBoxCategory.SelectedValue));
            this.listSubCategoryDetailsTableAdapter.Fill(this.dSListSubCategoryDetails.ListSubCategoryDetails,Convert.ToInt32(comboBoxCategory.SelectedValue));
            this.reportViewer1.RefreshReport();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rPTGetProductBySubCategoryTableAdapter.Fill(this.dSRPTProductDetialByParameters.RPTGetProductBySubCategory, Convert.ToInt32(comboBoxSubCategory.SelectedValue), Convert.ToInt32(comboBoxCategory.SelectedValue));
            this.listSubCategoryDetailsTableAdapter.Fill(this.dSListSubCategoryDetails.ListSubCategoryDetails, Convert.ToInt32(comboBoxCategory.SelectedValue));
            this.reportViewer1.RefreshReport();
        }

        private void comboBoxSubCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rPTGetProductBySubCategoryTableAdapter.Fill(this.dSRPTProductDetialByParameters.RPTGetProductBySubCategory, Convert.ToInt32(comboBoxSubCategory.SelectedValue), Convert.ToInt32(comboBoxCategory.SelectedValue));
            this.reportViewer1.RefreshReport();
        }
    }
}
