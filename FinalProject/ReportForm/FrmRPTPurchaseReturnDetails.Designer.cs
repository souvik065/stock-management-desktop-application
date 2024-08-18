namespace FinalProject.ReportForm
{
    partial class FrmRPTPurchaseReturnDetails
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
            this.dSRPTPurchaseReturnDetails = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTPurchaseReturnDetails();
            this.rPTGetPurchaseReturnDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTGetPurchaseReturnDetailsTableAdapter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTPurchaseReturnDetailsTableAdapters.RPTGetPurchaseReturnDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTPurchaseReturnDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTGetPurchaseReturnDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetRPTPurchaseReturnDetails";
            reportDataSource1.Value = this.rPTGetPurchaseReturnDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.RDLC.RPTPurchaseReturnDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(813, 594);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSRPTPurchaseReturnDetails
            // 
            this.dSRPTPurchaseReturnDetails.DataSetName = "DSRPTPurchaseReturnDetails";
            this.dSRPTPurchaseReturnDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTGetPurchaseReturnDetailsBindingSource
            // 
            this.rPTGetPurchaseReturnDetailsBindingSource.DataMember = "RPTGetPurchaseReturnDetails";
            this.rPTGetPurchaseReturnDetailsBindingSource.DataSource = this.dSRPTPurchaseReturnDetails;
            // 
            // rPTGetPurchaseReturnDetailsTableAdapter
            // 
            this.rPTGetPurchaseReturnDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRPTPurchaseReturnDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 594);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRPTPurchaseReturnDetails";
            this.Text = "FrmRPTPurchaseReturnDetails";
            this.Load += new System.EventHandler(this.FrmRPTPurchaseReturnDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTPurchaseReturnDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTGetPurchaseReturnDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FinalProjectDataSets.RPTDataset.DSRPTPurchaseReturnDetails dSRPTPurchaseReturnDetails;
        private System.Windows.Forms.BindingSource rPTGetPurchaseReturnDetailsBindingSource;
        private FinalProjectDataSets.RPTDataset.DSRPTPurchaseReturnDetailsTableAdapters.RPTGetPurchaseReturnDetailsTableAdapter rPTGetPurchaseReturnDetailsTableAdapter;
    }
}