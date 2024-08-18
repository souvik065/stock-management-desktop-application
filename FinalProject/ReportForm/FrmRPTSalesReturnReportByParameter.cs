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
    public partial class FrmRPTSalesReturnReportByParameter : Form
    {
        public FrmRPTSalesReturnReportByParameter()
        {
            InitializeComponent();
        }

        private void FrmRPTSalesReturnReportByParameter_Load(object sender, EventArgs e)
        {
            this.rPTSalesReturnReportByParameterTableAdapter.Fill(this.dSRPTSalesReturnReportByParameter.RPTSalesReturnReportByParameter,Convert.ToInt32(txtInvoiceNo.Text),Convert.ToDateTime(dateTimePickerStartDate.Text),Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer1.RefreshReport();
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            this.rPTSalesReturnReportByParameterTableAdapter.Fill(this.dSRPTSalesReturnReportByParameter.RPTSalesReturnReportByParameter, Convert.ToInt32(txtInvoiceNo.Text), Convert.ToDateTime(dateTimePickerStartDate.Text), Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer1.RefreshReport();
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            this.rPTSalesReturnReportByParameterTableAdapter.Fill(this.dSRPTSalesReturnReportByParameter.RPTSalesReturnReportByParameter, Convert.ToInt32(txtInvoiceNo.Text), Convert.ToDateTime(dateTimePickerStartDate.Text), Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer1.RefreshReport();
        }

        private void txtInvoiceNo_Leave(object sender, EventArgs e)
        {
            this.rPTSalesReturnReportByParameterTableAdapter.Fill(this.dSRPTSalesReturnReportByParameter.RPTSalesReturnReportByParameter, Convert.ToInt32(txtInvoiceNo.Text), Convert.ToDateTime(dateTimePickerStartDate.Text), Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer1.RefreshReport();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
