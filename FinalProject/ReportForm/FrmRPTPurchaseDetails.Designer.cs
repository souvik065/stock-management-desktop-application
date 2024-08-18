namespace FinalProject.ReportForm
{
    partial class FrmRPTPurchaseDetails
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
            this.dSRPTGetPurchaseDetails = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTGetPurchaseDetails();
            this.rPTGetPurchaseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTGetPurchaseDetailsTableAdapter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTGetPurchaseDetailsTableAdapters.RPTGetPurchaseDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTGetPurchaseDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTGetPurchaseDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetGetPurchaseDetails";
            reportDataSource1.Value = this.rPTGetPurchaseDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.RDLC.RPTGetPurchaseDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(976, 649);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSRPTGetPurchaseDetails
            // 
            this.dSRPTGetPurchaseDetails.DataSetName = "DSRPTGetPurchaseDetails";
            this.dSRPTGetPurchaseDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTGetPurchaseDetailsBindingSource
            // 
            this.rPTGetPurchaseDetailsBindingSource.DataMember = "RPTGetPurchaseDetails";
            this.rPTGetPurchaseDetailsBindingSource.DataSource = this.dSRPTGetPurchaseDetails;
            // 
            // rPTGetPurchaseDetailsTableAdapter
            // 
            this.rPTGetPurchaseDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRPTPurchaseDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 649);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRPTPurchaseDetails";
            this.Text = "FrmRPTPurchaseDetails";
            this.Load += new System.EventHandler(this.FrmRPTPurchaseDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTGetPurchaseDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTGetPurchaseDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FinalProjectDataSets.RPTDataset.DSRPTGetPurchaseDetails dSRPTGetPurchaseDetails;
        private System.Windows.Forms.BindingSource rPTGetPurchaseDetailsBindingSource;
        private FinalProjectDataSets.RPTDataset.DSRPTGetPurchaseDetailsTableAdapters.RPTGetPurchaseDetailsTableAdapter rPTGetPurchaseDetailsTableAdapter;
    }
}