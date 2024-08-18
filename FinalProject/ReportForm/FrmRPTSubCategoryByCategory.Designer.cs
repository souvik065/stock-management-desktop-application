namespace FinalProject.ReportForm
{
    partial class FrmRPTSubCategoryByCategory
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PurchaseMasterpanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCategoryName = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listCategoryDetails = new FinalProject.FinalProjectDataSets.ListCategoryDetails();
            this.listCategoryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listCategoryDetailsTableAdapter = new FinalProject.FinalProjectDataSets.ListCategoryDetailsTableAdapters.ListCategoryDetailsTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dSRPTSubCategoryByCategory = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTSubCategoryByCategory();
            this.rPTSubCategoryByParameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTSubCategoryByParameterTableAdapter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTSubCategoryByCategoryTableAdapters.RPTSubCategoryByParameterTableAdapter();
            this.rPTSubCategoryByParameterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Headerpanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.PurchaseMasterpanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTSubCategoryByCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTSubCategoryByParameterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTSubCategoryByParameterBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 5);
            this.panel1.TabIndex = 11;
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
            this.Headerpanel.TabIndex = 12;
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
            this.label3.Location = new System.Drawing.Point(616, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(537, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category Report By Paramteter";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1904, 5);
            this.panel3.TabIndex = 13;
            // 
            // PurchaseMasterpanel
            // 
            this.PurchaseMasterpanel.BackColor = System.Drawing.Color.White;
            this.PurchaseMasterpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PurchaseMasterpanel.Controls.Add(this.tableLayoutPanel2);
            this.PurchaseMasterpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PurchaseMasterpanel.Location = new System.Drawing.Point(0, 74);
            this.PurchaseMasterpanel.Name = "PurchaseMasterpanel";
            this.PurchaseMasterpanel.Size = new System.Drawing.Size(1904, 60);
            this.PurchaseMasterpanel.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 12;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 445F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 166F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxCategoryName, 2, 0);
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
            this.label5.Location = new System.Drawing.Point(134, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Category :";
            // 
            // comboBoxCategoryName
            // 
            this.comboBoxCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxCategoryName.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxCategoryName.DataSource = this.listCategoryDetailsBindingSource;
            this.comboBoxCategoryName.DisplayMember = "CATEGORYNAME";
            this.comboBoxCategoryName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxCategoryName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCategoryName.FormattingEnabled = true;
            this.comboBoxCategoryName.Location = new System.Drawing.Point(257, 9);
            this.comboBoxCategoryName.Name = "comboBoxCategoryName";
            this.comboBoxCategoryName.Size = new System.Drawing.Size(428, 30);
            this.comboBoxCategoryName.TabIndex = 1;
            this.comboBoxCategoryName.ValueMember = "CATEGORYID";
            this.comboBoxCategoryName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoryName_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1904, 5);
            this.panel2.TabIndex = 15;
            // 
            // listCategoryDetails
            // 
            this.listCategoryDetails.DataSetName = "ListCategoryDetails";
            this.listCategoryDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listCategoryDetailsBindingSource
            // 
            this.listCategoryDetailsBindingSource.DataMember = "ListCategoryDetails";
            this.listCategoryDetailsBindingSource.DataSource = this.listCategoryDetails;
            // 
            // listCategoryDetailsTableAdapter
            // 
            this.listCategoryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DSRPTSubCategoryByCategory";
            reportDataSource2.Value = this.rPTSubCategoryByParameterBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.RDLC.RPTSubCatgeoryByCategory.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 139);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1904, 842);
            this.reportViewer1.TabIndex = 16;
            // 
            // dSRPTSubCategoryByCategory
            // 
            this.dSRPTSubCategoryByCategory.DataSetName = "DSRPTSubCategoryByCategory";
            this.dSRPTSubCategoryByCategory.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTSubCategoryByParameterBindingSource
            // 
            this.rPTSubCategoryByParameterBindingSource.DataMember = "RPTSubCategoryByParameter";
            this.rPTSubCategoryByParameterBindingSource.DataSource = this.dSRPTSubCategoryByCategory;
            // 
            // rPTSubCategoryByParameterTableAdapter
            // 
            this.rPTSubCategoryByParameterTableAdapter.ClearBeforeFill = true;
            // 
            // rPTSubCategoryByParameterBindingSource1
            // 
            this.rPTSubCategoryByParameterBindingSource1.DataMember = "RPTSubCategoryByParameter";
            this.rPTSubCategoryByParameterBindingSource1.DataSource = this.dSRPTSubCategoryByCategory;
            // 
            // FrmRPTSubCategoryByCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 981);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.PurchaseMasterpanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Headerpanel);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRPTSubCategoryByCategory";
            this.Text = "FrmRPTSubCategoryByCategory";
            this.Load += new System.EventHandler(this.FrmRPTSubCategoryByCategory_Load);
            this.Headerpanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.PurchaseMasterpanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTSubCategoryByCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTSubCategoryByParameterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTSubCategoryByParameterBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PurchaseMasterpanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCategoryName;
        private System.Windows.Forms.Panel panel2;
        private FinalProjectDataSets.ListCategoryDetails listCategoryDetails;
        private System.Windows.Forms.BindingSource listCategoryDetailsBindingSource;
        private FinalProjectDataSets.ListCategoryDetailsTableAdapters.ListCategoryDetailsTableAdapter listCategoryDetailsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource rPTSubCategoryByParameterBindingSource1;
        private FinalProjectDataSets.RPTDataset.DSRPTSubCategoryByCategory dSRPTSubCategoryByCategory;
        private System.Windows.Forms.BindingSource rPTSubCategoryByParameterBindingSource;
        private FinalProjectDataSets.RPTDataset.DSRPTSubCategoryByCategoryTableAdapters.RPTSubCategoryByParameterTableAdapter rPTSubCategoryByParameterTableAdapter;

    }
}