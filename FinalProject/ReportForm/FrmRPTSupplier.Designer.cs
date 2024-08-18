namespace FinalProject.ReportForm
{
    partial class FrmRPTSupplier
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
            this.dSRPTSupplierList = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTSupplierList();
            this.rPTSupplierMasterListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTSupplierMasterListTableAdapter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTSupplierListTableAdapters.RPTSupplierMasterListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTSupplierList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTSupplierMasterListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rPTSupplierMasterListBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.RDLC.RPTSupplierList.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(916, 639);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSRPTSupplierList
            // 
            this.dSRPTSupplierList.DataSetName = "DSRPTSupplierList";
            this.dSRPTSupplierList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTSupplierMasterListBindingSource
            // 
            this.rPTSupplierMasterListBindingSource.DataMember = "RPTSupplierMasterList";
            this.rPTSupplierMasterListBindingSource.DataSource = this.dSRPTSupplierList;
            // 
            // rPTSupplierMasterListTableAdapter
            // 
            this.rPTSupplierMasterListTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRPTSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 639);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRPTSupplier";
            this.Text = "FrmRPTSupplier";
            this.Load += new System.EventHandler(this.FrmRPTSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTSupplierList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTSupplierMasterListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FinalProjectDataSets.RPTDataset.DSRPTSupplierList dSRPTSupplierList;
        private System.Windows.Forms.BindingSource rPTSupplierMasterListBindingSource;
        private FinalProjectDataSets.RPTDataset.DSRPTSupplierListTableAdapters.RPTSupplierMasterListTableAdapter rPTSupplierMasterListTableAdapter;
    }
}