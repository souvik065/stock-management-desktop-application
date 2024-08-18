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
    public partial class FrmRPTSalesReportByParameter : Form
    {
        public FrmRPTSalesReportByParameter()
        {
            InitializeComponent();
        }

        private void FrmRPTSalesReportByParameter_Load(object sender, EventArgs e)
        {

            this.rPTSalesReportByParameterTableAdapter.Fill(this.dSRPTSalesReportByParameter.RPTSalesReportByParameter,Convert.ToInt32(txtInvoiceNo.Text),Convert.ToDateTime(dateTimePickerStartDate.Text),Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer2.RefreshReport();
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            this.rPTSalesReportByParameterTableAdapter.Fill(this.dSRPTSalesReportByParameter.RPTSalesReportByParameter, Convert.ToInt32(txtInvoiceNo.Text), Convert.ToDateTime(dateTimePickerStartDate.Text), Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer2.RefreshReport();
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            this.rPTSalesReportByParameterTableAdapter.Fill(this.dSRPTSalesReportByParameter.RPTSalesReportByParameter, Convert.ToInt32(txtInvoiceNo.Text), Convert.ToDateTime(dateTimePickerStartDate.Text), Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer2.RefreshReport();
        }

        private void txtInvoiceNo_Leave(object sender, EventArgs e)
        {
            this.rPTSalesReportByParameterTableAdapter.Fill(this.dSRPTSalesReportByParameter.RPTSalesReportByParameter, Convert.ToInt32(txtInvoiceNo.Text), Convert.ToDateTime(dateTimePickerStartDate.Text), Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer2.RefreshReport();
        }
    }
}
