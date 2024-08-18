namespace FinalProject.ReportForm
{
    partial class FrmRPTProductDetails
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
            this.dSRPTProductDetails = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTProductDetails();
            this.rPTProductDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTProductDetailsTableAdapter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTProductDetailsTableAdapters.RPTProductDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTProductDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTProductDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetDSRPTProductDetails";
            reportDataSource1.Value = this.rPTProductDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.RDLC.RPTProductDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(652, 515);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSRPTProductDetails
            // 
            this.dSRPTProductDetails.DataSetName = "DSRPTProductDetails";
            this.dSRPTProductDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTProductDetailsBindingSource
            // 
            this.rPTProductDetailsBindingSource.DataMember = "RPTProductDetails";
            this.rPTProductDetailsBindingSource.DataSource = this.dSRPTProductDetails;
            // 
            // rPTProductDetailsTableAdapter
            // 
            this.rPTProductDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRPTProductDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 515);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRPTProductDetails";
            this.Text = "FrmRPTProductDetails";
            this.Load += new System.EventHandler(this.FrmRPTProductDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTProductDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTProductDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FinalProjectDataSets.RPTDataset.DSRPTProductDetails dSRPTProductDetails;
        private System.Windows.Forms.BindingSource rPTProductDetailsBindingSource;
        private FinalProjectDataSets.RPTDataset.DSRPTProductDetailsTableAdapters.RPTProductDetailsTableAdapter rPTProductDetailsTableAdapter;
    }
}