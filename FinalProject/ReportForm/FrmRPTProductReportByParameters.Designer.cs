namespace FinalProject.ReportForm
{
    partial class FrmRPTProductReportByParameters
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rPTGetProductBySubCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRPTProductDetialByParameters = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTProductDetialByParameters();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SalesMasterpanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.listCategoryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listCategoryDetails = new FinalProject.FinalProjectDataSets.ListCategoryDetails();
            this.comboBoxSubCategory = new System.Windows.Forms.ComboBox();
            this.listSubCategoryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSListSubCategoryDetails = new FinalProject.FinalProjectDataSets.DSListSubCategoryDetails();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.listCategoryDetailsTableAdapter = new FinalProject.FinalProjectDataSets.ListCategoryDetailsTableAdapters.ListCategoryDetailsTableAdapter();
            this.listSubCategoryDetailsTableAdapter = new FinalProject.FinalProjectDataSets.DSListSubCategoryDetailsTableAdapters.ListSubCategoryDetailsTableAdapter();
            this.rPTGetProductBySubCategoryTableAdapter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTProductDetialByParametersTableAdapters.RPTGetProductBySubCategoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rPTGetProductBySubCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTProductDetialByParameters)).BeginInit();
            this.Headerpanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SalesMasterpanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSubCategoryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSListSubCategoryDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // rPTGetProductBySubCategoryBindingSource
            // 
            this.rPTGetProductBySubCategoryBindingSource.DataMember = "RPTGetProductBySubCategory";
            this.rPTGetProductBySubCategoryBindingSource.DataSource = this.dSRPTProductDetialByParameters;
            // 
            // dSRPTProductDetialByParameters
            // 
            this.dSRPTProductDetialByParameters.DataSetName = "DSRPTProductDetialByParameters";
            this.dSRPTProductDetialByParameters.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 5);
            this.panel1.TabIndex = 3;
            // 
            // Headerpanel
            // 
            this.Headerpanel.BackColor = System.Drawing.Color.White;
            this.Headerpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Headerpanel.Controls.Add(this.tableLayoutPanel1);
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.Location = new System.Drawing.Point(0, 5);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(1904, 64);
            this.Headerpanel.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 722F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1902, 50);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(750, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Report";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1904, 5);
            this.panel3.TabIndex = 5;
            // 
            // SalesMasterpanel
            // 
            this.SalesMasterpanel.BackColor = System.Drawing.Color.White;
            this.SalesMasterpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalesMasterpanel.Controls.Add(this.tableLayoutPanel2);
            this.SalesMasterpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SalesMasterpanel.Location = new System.Drawing.Point(0, 74);
            this.SalesMasterpanel.Name = "SalesMasterpanel";
            this.SalesMasterpanel.Size = new System.Drawing.Size(1904, 60);
            this.SalesMasterpanel.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 12;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 296F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 328F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxCategory, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSubCategory, 5, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1902, 49);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(136, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Category :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(588, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sub-Category :";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxCategory.DataSource = this.listCategoryDetailsBindingSource;
            this.comboBoxCategory.DisplayMember = "CATEGORYNAME";
            this.comboBoxCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategory.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(255, 9);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(284, 30);
            this.comboBoxCategory.TabIndex = 8;
            this.comboBoxCategory.ValueMember = "CATEGORYID";
            this.comboBoxCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategory_SelectedIndexChanged);
            // 
            // listCategoryDetailsBindingSource
            // 
            this.listCategoryDetailsBindingSource.DataMember = "ListCategoryDetails";
            this.listCategoryDetailsBindingSource.DataSource = this.listCategoryDetails;
            // 
            // listCategoryDetails
            // 
            this.listCategoryDetails.DataSetName = "ListCategoryDetails";
            this.listCategoryDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxSubCategory
            // 
            this.comboBoxSubCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSubCategory.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxSubCategory.DataSource = this.listSubCategoryDetailsBindingSource;
            this.comboBoxSubCategory.DisplayMember = "SUBCATEGORYNAME";
            this.comboBoxSubCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubCategory.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubCategory.FormattingEnabled = true;
            this.comboBoxSubCategory.Location = new System.Drawing.Point(754, 9);
            this.comboBoxSubCategory.Name = "comboBoxSubCategory";
            this.comboBoxSubCategory.Size = new System.Drawing.Size(305, 30);
            this.comboBoxSubCategory.TabIndex = 8;
            this.comboBoxSubCategory.ValueMember = "SUBCATEGORYID";
            this.comboBoxSubCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxSubCategory_SelectedIndexChanged);
            // 
            // listSubCategoryDetailsBindingSource
            // 
            this.listSubCategoryDetailsBindingSource.DataMember = "ListSubCategoryDetails";
            this.listSubCategoryDetailsBindingSource.DataSource = this.dSListSubCategoryDetails;
            // 
            // dSListSubCategoryDetails
            // 
            this.dSListSubCategoryDetails.DataSetName = "DSListSubCategoryDetails";
            this.dSListSubCategoryDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1904, 5);
            this.panel2.TabIndex = 7;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DSRPTProductDetailByParameter";
            reportDataSource3.Value = this.rPTGetProductBySubCategoryBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.RDLC.RPTProductReportByParameter.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 139);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1904, 842);
            this.reportViewer1.TabIndex = 8;
            // 
            // listCategoryDetailsTableAdapter
            // 
            this.listCategoryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // listSubCategoryDetailsTableAdapter
            // 
            this.listSubCategoryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // rPTGetProductBySubCategoryTableAdapter
            // 
            this.rPTGetProductBySubCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRPTProductReportByParameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 981);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.SalesMasterpanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Headerpanel);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRPTProductReportByParameters";
            this.Text = "FrmRPTProductReportByParameters";
            this.Load += new System.EventHandler(this.FrmRPTProductReportByParameters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPTGetProductBySubCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTProductDetialByParameters)).EndInit();
            this.Headerpanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.SalesMasterpanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSubCategoryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSListSubCategoryDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel SalesMasterpanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxSubCategory;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private FinalProjectDataSets.ListCategoryDetails listCategoryDetails;
        private System.Windows.Forms.BindingSource listCategoryDetailsBindingSource;
        private FinalProjectDataSets.ListCategoryDetailsTableAdapters.ListCategoryDetailsTableAdapter listCategoryDetailsTableAdapter;
        private System.Windows.Forms.BindingSource listSubCategoryDetailsBindingSource;
        private FinalProjectDataSets.DSListSubCategoryDetails dSListSubCategoryDetails;
        private FinalProjectDataSets.DSListSubCategoryDetailsTableAdapters.ListSubCategoryDetailsTableAdapter listSubCategoryDetailsTableAdapter;
        private System.Windows.Forms.BindingSource rPTGetProductBySubCategoryBindingSource;
        private FinalProjectDataSets.RPTDataset.DSRPTProductDetialByParameters dSRPTProductDetialByParameters;
        private FinalProjectDataSets.RPTDataset.DSRPTProductDetialByParametersTableAdapters.RPTGetProductBySubCategoryTableAdapter rPTGetProductBySubCategoryTableAdapter;
    }
}