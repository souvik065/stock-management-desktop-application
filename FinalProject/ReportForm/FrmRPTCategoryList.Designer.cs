namespace FinalProject.ReportForm
{
    partial class FrmRPTCategoryList
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
            this.rPTCategoryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRPTCategoryList = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTCategoryList();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPTCategoryListTableAdapter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTCategoryListTableAdapters.RPTCategoryListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rPTCategoryListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTCategoryList)).BeginInit();
            this.SuspendLayout();
            // 
            // rPTCategoryListBindingSource
            // 
            this.rPTCategoryListBindingSource.DataMember = "RPTCategoryList";
            this.rPTCategoryListBindingSource.DataSource = this.dSRPTCategoryList;
            // 
            // dSRPTCategoryList
            // 
            this.dSRPTCategoryList.DataSetName = "DSRPTCategoryList";
            this.dSRPTCategoryList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rPTCategoryListBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.RDLC.RPTCategoryList.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(798, 637);
            this.reportViewer1.TabIndex = 0;
            // 
            // rPTCategoryListTableAdapter
            // 
            this.rPTCategoryListTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRPTCategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 637);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRPTCategoryList";
            this.Text = "FrmRPTCategoryList";
            this.Load += new System.EventHandler(this.FrmRPTCategoryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPTCategoryListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTCategoryList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FinalProjectDataSets.RPTDataset.DSRPTCategoryList dSRPTCategoryList;
        private System.Windows.Forms.BindingSource rPTCategoryListBindingSource;
        private FinalProjectDataSets.RPTDataset.DSRPTCategoryListTableAdapters.RPTCategoryListTableAdapter rPTCategoryListTableAdapter;
    }
}