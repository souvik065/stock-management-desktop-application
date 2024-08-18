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
    public partial class FrmRPTPurchaseReportByParamters : Form
    {
        public FrmRPTPurchaseReportByParamters()
        {
            InitializeComponent();
        }

        private void FrmRPTPurchaseReportByParamters_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSListSupplierMasterDetails.ListSupplierDetails' table. You can move, or remove it, as needed.
            this.listSupplierDetailsTableAdapter.Fill(this.dSListSupplierMasterDetails.ListSupplierDetails);
            this.rPTPurchaseReportByParameterTableAdapter.Fill(this.dSRPTPurchaseReportByParameter.RPTPurchaseReportByParameter,Convert.ToInt32(comboBoxSupplierName.SelectedValue),Convert.ToInt32(txtInvoiceNo.Text),Convert.ToDateTime(dateTimePickerStartDate.Text),Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer1.RefreshReport();
        }

        private void comboBoxSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rPTPurchaseReportByParameterTableAdapter.Fill(this.dSRPTPurchaseReportByParameter.RPTPurchaseReportByParameter, Convert.ToInt32(comboBoxSupplierName.SelectedValue), Convert.ToInt32(txtInvoiceNo.Text), Convert.ToDateTime(dateTimePickerStartDate.Text), Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer1.RefreshReport();
        }

        private void txtInvoiceNo_TextChanged(object sender, EventArgs e)
        {
            this.rPTPurchaseReportByParameterTableAdapter.Fill(this.dSRPTPurchaseReportByParameter.RPTPurchaseReportByParameter, Convert.ToInt32(comboBoxSupplierName.SelectedValue), Convert.ToInt32(txtInvoiceNo.Text), Convert.ToDateTime(dateTimePickerStartDate.Text), Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer1.RefreshReport();
        }

        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            this.rPTPurchaseReportByParameterTableAdapter.Fill(this.dSRPTPurchaseReportByParameter.RPTPurchaseReportByParameter, Convert.ToInt32(comboBoxSupplierName.SelectedValue), Convert.ToInt32(txtInvoiceNo.Text), Convert.ToDateTime(dateTimePickerStartDate.Text), Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer1.RefreshReport();
        }

        private void dateTimePickerEndDate_ValueChanged(object sender, EventArgs e)
        {
            this.rPTPurchaseReportByParameterTableAdapter.Fill(this.dSRPTPurchaseReportByParameter.RPTPurchaseReportByParameter, Convert.ToInt32(comboBoxSupplierName.SelectedValue), Convert.ToInt32(txtInvoiceNo.Text), Convert.ToDateTime(dateTimePickerStartDate.Text), Convert.ToDateTime(dateTimePickerEndDate.Text));
            this.reportViewer1.RefreshReport();
        }
    }
}
