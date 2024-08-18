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
    public partial class FrmRPTPurchaseReturnReportByParameter : Form
    {
        public FrmRPTPurchaseReturnReportByParameter()
        {
            InitializeComponent();
        }

        private void FrmRPTPurchaseReturnReportByParameter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSGetSupplierDetails.GetSupplierMasterDetails' table. You can move, or remove it, as needed.
            this.getSupplierMasterDetailsTableAdapter.Fill(this.dSGetSupplierDetails.GetSupplierMasterDetails);
            this.rPTPurchaseReturnReportByParameterTableAdapter.Fill(this.dSRPTPurchaseReturnReportByParameter.RPTPurchaseReturnReportByParameter,Convert.ToInt32(comboBoxSupplierName.SelectedValue),Convert.ToInt32(txtInvoiceNo.Text),Convert.ToDateTime(dateTimePickerStartDate.Text),Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer2.RefreshReport();
        }

        private void comboBoxSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rPTPurchaseReturnReportByParameterTableAdapter.Fill(this.dSRPTPurchaseReturnReportByParameter.RPTPurchaseReturnReportByParameter, Convert.ToInt32(comboBoxSupplierName.SelectedValue), Convert.ToInt32(txtInvoiceNo.Text), Convert.ToDateTime(dateTimePickerStartDate.Text), Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer2.RefreshReport();
        }

        private void txtInvoiceNo_Leave(object sender, EventArgs e)
        {
            this.rPTPurchaseReturnReportByParameterTableAdapter.Fill(this.dSRPTPurchaseReturnReportByParameter.RPTPurchaseReturnReportByParameter, Convert.ToInt32(comboBoxSupplierName.SelectedValue), Convert.ToInt32(txtInvoiceNo.Text), Convert.ToDateTime(dateTimePickerStartDate.Text), Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer2.RefreshReport();
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            this.rPTPurchaseReturnReportByParameterTableAdapter.Fill(this.dSRPTPurchaseReturnReportByParameter.RPTPurchaseReturnReportByParameter, Convert.ToInt32(comboBoxSupplierName.SelectedValue), Convert.ToInt32(txtInvoiceNo.Text), Convert.ToDateTime(dateTimePickerStartDate.Text), Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer2.RefreshReport();
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            this.rPTPurchaseReturnReportByParameterTableAdapter.Fill(this.dSRPTPurchaseReturnReportByParameter.RPTPurchaseReturnReportByParameter, Convert.ToInt32(comboBoxSupplierName.SelectedValue), Convert.ToInt32(txtInvoiceNo.Text), Convert.ToDateTime(dateTimePickerStartDate.Text), Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer2.RefreshReport();
        }
    }
}
