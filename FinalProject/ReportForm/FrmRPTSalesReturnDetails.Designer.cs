namespace FinalProject.ReportForm
{
    partial class FrmRPTSalesReturnDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSRPTSalesReturnDetails = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTSalesReturnDetails();
            this.rPTGetSaleReturnDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTGetSaleReturnDetailTableAdapter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTSalesReturnDetailsTableAdapters.RPTGetSaleReturnDetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTSalesReturnDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTGetSaleReturnDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetSalesReturnDetails";
            reportDataSource1.Value = this.rPTGetSaleReturnDetailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.RDLC.RPTSalesReturnDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(844, 596);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSRPTSalesReturnDetails
            // 
            this.dSRPTSalesReturnDetails.DataSetName = "DSRPTSalesReturnDetails";
            this.dSRPTSalesReturnDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTGetSaleReturnDetailBindingSource
            // 
            this.rPTGetSaleReturnDetailBindingSource.DataMember = "RPTGetSaleReturnDetail";
            this.rPTGetSaleReturnDetailBindingSource.DataSource = this.dSRPTSalesReturnDetails;
            // 
            // rPTGetSaleReturnDetailTableAdapter
            // 
            this.rPTGetSaleReturnDetailTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRPTSalesReturnDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 596);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRPTSalesReturnDetails";
            this.Text = "FrmRPTSalesReturnDetails";
            this.Load += new System.EventHandler(this.FrmRPTSalesReturnDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTSalesReturnDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTGetSaleReturnDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FinalProjectDataSets.RPTDataset.DSRPTSalesReturnDetails dSRPTSalesReturnDetails;
        private System.Windows.Forms.BindingSource rPTGetSaleReturnDetailBindingSource;
        private FinalProjectDataSets.RPTDataset.DSRPTSalesReturnDetailsTableAdapters.RPTGetSaleReturnDetailTableAdapter rPTGetSaleReturnDetailTableAdapter;
    }
}