namespace FinalProject.ReportForm
{
    partial class FrmRPTSalesDetails
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
            this.dSRPTSalesDetails = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTSalesDetails();
            this.rPTGetSaleDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTGetSaleDetailTableAdapter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTSalesDetailsTableAdapters.RPTGetSaleDetailTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTSalesDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTGetSaleDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetRPTSalesDetails";
            reportDataSource1.Value = this.rPTGetSaleDetailBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.RDLC.RPTSalesDetails.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(760, 584);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSRPTSalesDetails
            // 
            this.dSRPTSalesDetails.DataSetName = "DSRPTSalesDetails";
            this.dSRPTSalesDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTGetSaleDetailBindingSource
            // 
            this.rPTGetSaleDetailBindingSource.DataMember = "RPTGetSaleDetail";
            this.rPTGetSaleDetailBindingSource.DataSource = this.dSRPTSalesDetails;
            // 
            // rPTGetSaleDetailTableAdapter
            // 
            this.rPTGetSaleDetailTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRPTSalesDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 584);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRPTSalesDetails";
            this.Text = "FrmRPTSalesDetails";
            this.Load += new System.EventHandler(this.FrmRPTSalesDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTSalesDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTGetSaleDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FinalProjectDataSets.RPTDataset.DSRPTSalesDetails dSRPTSalesDetails;
        private System.Windows.Forms.BindingSource rPTGetSaleDetailBindingSource;
        private FinalProjectDataSets.RPTDataset.DSRPTSalesDetailsTableAdapters.RPTGetSaleDetailTableAdapter rPTGetSaleDetailTableAdapter;
    }
}