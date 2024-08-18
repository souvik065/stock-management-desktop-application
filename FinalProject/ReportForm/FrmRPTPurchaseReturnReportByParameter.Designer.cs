namespace FinalProject.ReportForm
{
    partial class FrmRPTPurchaseReturnReportByParameter
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
            this.rPTPurchaseReturnReportByParameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSRPTPurchaseReturnReportByParameter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTPurchaseReturnReportByParameter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSupplierName = new System.Windows.Forms.ComboBox();
            this.getSupplierMasterDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSGetSupplierDetails = new FinalProject.FinalProjectDataSets.DSGetSupplierDetails();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.StartDateEndDatePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SupplierAndInvoicePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.rPTPurchaseReturnReportByParameterTableAdapter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTPurchaseReturnReportByParameterTableAdapters.RPTPurchaseReturnReportByParameterTableAdapter();
            this.getSupplierMasterDetailsTableAdapter = new FinalProject.FinalProjectDataSets.DSGetSupplierDetailsTableAdapters.GetSupplierMasterDetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.rPTPurchaseReturnReportByParameterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTPurchaseReturnReportByParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSupplierMasterDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGetSupplierDetails)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.StartDateEndDatePanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SupplierAndInvoicePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Headerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rPTPurchaseReturnReportByParameterBindingSource
            // 
            this.rPTPurchaseReturnReportByParameterBindingSource.DataMember = "RPTPurchaseReturnReportByParameter";
            this.rPTPurchaseReturnReportByParameterBindingSource.DataSource = this.dSRPTPurchaseReturnReportByParameter;
            // 
            // dSRPTPurchaseReturnReportByParameter
            // 
            this.dSRPTPurchaseReturnReportByParameter.DataSetName = "DSRPTPurchaseReturnReportByParameter";
            this.dSRPTPurchaseReturnReportByParameter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1904, 5);
            this.panel2.TabIndex = 14;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(281, 14);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(257, 20);
            this.dateTimePickerStartDate.TabIndex = 0;
            this.dateTimePickerStartDate.ValueChanged += new System.EventHandler(this.dateTimePickerStartDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(152, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Start Date :";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(867, 14);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(278, 20);
            this.dateTimePickerEndDate.TabIndex = 0;
            this.dateTimePickerEndDate.ValueChanged += new System.EventHandler(this.dateTimePickerEndDate_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(733, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "End Date :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(107, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Supplier Name :";
            // 
            // comboBoxSupplierName
            // 
            this.comboBoxSupplierName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSupplierName.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxSupplierName.DataSource = this.getSupplierMasterDetailsBindingSource;
            this.comboBoxSupplierName.DisplayMember = "SUPPLIERNAME";
            this.comboBoxSupplierName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSupplierName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSupplierName.FormattingEnabled = true;
            this.comboBoxSupplierName.Location = new System.Drawing.Point(281, 9);
            this.comboBoxSupplierName.Name = "comboBoxSupplierName";
            this.comboBoxSupplierName.Size = new System.Drawing.Size(365, 30);
            this.comboBoxSupplierName.TabIndex = 1;
            this.comboBoxSupplierName.ValueMember = "SUPPLIERID";
            this.comboBoxSupplierName.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupplierName_SelectedIndexChanged);
            // 
            // getSupplierMasterDetailsBindingSource
            // 
            this.getSupplierMasterDetailsBindingSource.DataMember = "GetSupplierMasterDetails";
            this.getSupplierMasterDetailsBindingSource.DataSource = this.dSGetSupplierDetails;
            // 
            // dSGetSupplierDetails
            // 
            this.dSGetSupplierDetails.DataSetName = "DSGetSupplierDetails";
            this.dSGetSupplierDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 12;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerStartDate, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.dateTimePickerEndDate, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1902, 49);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // StartDateEndDatePanel
            // 
            this.StartDateEndDatePanel.BackColor = System.Drawing.Color.White;
            this.StartDateEndDatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartDateEndDatePanel.Controls.Add(this.tableLayoutPanel3);
            this.StartDateEndDatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartDateEndDatePanel.Location = new System.Drawing.Point(0, 134);
            this.StartDateEndDatePanel.Name = "StartDateEndDatePanel";
            this.StartDateEndDatePanel.Size = new System.Drawing.Size(1904, 60);
            this.StartDateEndDatePanel.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(723, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Invoice No :";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtInvoiceNo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtInvoiceNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInvoiceNo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(857, 13);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(161, 22);
            this.txtInvoiceNo.TabIndex = 2;
            this.txtInvoiceNo.Text = "0";
            this.txtInvoiceNo.Leave += new System.EventHandler(this.txtInvoiceNo_Leave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 12;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 391F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSupplierName, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtInvoiceNo, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1902, 49);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // SupplierAndInvoicePanel
            // 
            this.SupplierAndInvoicePanel.BackColor = System.Drawing.Color.White;
            this.SupplierAndInvoicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SupplierAndInvoicePanel.Controls.Add(this.tableLayoutPanel2);
            this.SupplierAndInvoicePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SupplierAndInvoicePanel.Location = new System.Drawing.Point(0, 74);
            this.SupplierAndInvoicePanel.Name = "SupplierAndInvoicePanel";
            this.SupplierAndInvoicePanel.Size = new System.Drawing.Size(1904, 60);
            this.SupplierAndInvoicePanel.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1904, 5);
            this.panel3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(678, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(413, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purchase Return Report";
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
            // Headerpanel
            // 
            this.Headerpanel.BackColor = System.Drawing.Color.White;
            this.Headerpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Headerpanel.Controls.Add(this.tableLayoutPanel1);
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.Location = new System.Drawing.Point(0, 5);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(1904, 64);
            this.Headerpanel.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 5);
            this.panel1.TabIndex = 9;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSRPTPurchaseReturnReportByParameter";
            reportDataSource1.Value = this.rPTPurchaseReturnReportByParameterBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "FinalProject.RDLC.RPTPurchaseReturnReportByParameter.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 199);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(1904, 782);
            this.reportViewer2.TabIndex = 16;
            // 
            // rPTPurchaseReturnReportByParameterTableAdapter
            // 
            this.rPTPurchaseReturnReportByParameterTableAdapter.ClearBeforeFill = true;
            // 
            // getSupplierMasterDetailsTableAdapter
            // 
            this.getSupplierMasterDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRPTPurchaseReturnReportByParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 981);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.StartDateEndDatePanel);
            this.Controls.Add(this.SupplierAndInvoicePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Headerpanel);
            this.Controls.Add(this.panel1);
            this.Name = "FrmRPTPurchaseReturnReportByParameter";
            this.Text = "FrmRPTPurchaseReturnReportByParameter";
            this.Load += new System.EventHandler(this.FrmRPTPurchaseReturnReportByParameter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rPTPurchaseReturnReportByParameterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTPurchaseReturnReportByParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getSupplierMasterDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGetSupplierDetails)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.StartDateEndDatePanel.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.SupplierAndInvoicePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Headerpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSupplierName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel StartDateEndDatePanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel SupplierAndInvoicePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource rPTPurchaseReturnReportByParameterBindingSource;
        private FinalProjectDataSets.RPTDataset.DSRPTPurchaseReturnReportByParameter dSRPTPurchaseReturnReportByParameter;
        private FinalProjectDataSets.RPTDataset.DSRPTPurchaseReturnReportByParameterTableAdapters.RPTPurchaseReturnReportByParameterTableAdapter rPTPurchaseReturnReportByParameterTableAdapter;
        private FinalProjectDataSets.DSGetSupplierDetails dSGetSupplierDetails;
        private System.Windows.Forms.BindingSource getSupplierMasterDetailsBindingSource;
        private FinalProjectDataSets.DSGetSupplierDetailsTableAdapters.GetSupplierMasterDetailsTableAdapter getSupplierMasterDetailsTableAdapter;
    }
}