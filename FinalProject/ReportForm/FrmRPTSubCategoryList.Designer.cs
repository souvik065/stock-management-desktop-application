namespace FinalProject.ReportForm
{
    partial class FrmRPTSubCategoryList
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
            this.dSRPTSubCategoryList = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTSubCategoryList();
            this.rPTGetSubCategoryListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTGetSubCategoryListTableAdapter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTSubCategoryListTableAdapters.RPTGetSubCategoryListTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTSubCategoryList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTGetSubCategoryListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.rPTGetSubCategoryListBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.RDLC.RPTSubCategoryList.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(745, 567);
            this.reportViewer1.TabIndex = 0;
            // 
            // dSRPTSubCategoryList
            // 
            this.dSRPTSubCategoryList.DataSetName = "DSRPTSubCategoryList";
            this.dSRPTSubCategoryList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTGetSubCategoryListBindingSource
            // 
            this.rPTGetSubCategoryListBindingSource.DataMember = "RPTGetSubCategoryList";
            this.rPTGetSubCategoryListBindingSource.DataSource = this.dSRPTSubCategoryList;
            // 
            // rPTGetSubCategoryListTableAdapter
            // 
            this.rPTGetSubCategoryListTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRPTSubCategoryList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 567);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRPTSubCategoryList";
            this.Text = "FrmRPTSubCategoryList";
            this.Load += new System.EventHandler(this.FrmRPTSubCategoryList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTSubCategoryList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTGetSubCategoryListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FinalProjectDataSets.RPTDataset.DSRPTSubCategoryList dSRPTSubCategoryList;
        private System.Windows.Forms.BindingSource rPTGetSubCategoryListBindingSource;
        private FinalProjectDataSets.RPTDataset.DSRPTSubCategoryListTableAdapters.RPTGetSubCategoryListTableAdapter rPTGetSubCategoryListTableAdapter;
    }
}