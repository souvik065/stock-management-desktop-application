namespace FinalProject.ReportForm
{
    partial class FrmRPTGeneralReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.StartDateEndDatePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Headerpanel = new System.Windows.Forms.Panel();
            this.dSRPTPurchaseReportByParameter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTPurchaseReportByParameter();
            this.rPTPurchaseReportByParameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTPurchaseReportByParameterTableAdapter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTPurchaseReportByParameterTableAdapters.RPTPurchaseReportByParameterTableAdapter();
            this.dSRPTPurchaseReturnReportByParameter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTPurchaseReturnReportByParameter();
            this.rPTPurchaseReturnReportByParameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rPTPurchaseReturnReportByParameterTableAdapter = new FinalProject.FinalProjectDataSets.RPTDataset.DSRPTPurchaseReturnReportByParameterTableAdapters.RPTPurchaseReturnReportByParameterTableAdapter();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.StartDateEndDatePanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTPurchaseReportByParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTPurchaseReportByParameterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTPurchaseReturnReportByParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTPurchaseReturnReportByParameterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DSPurchaseReportByParameter";
            reportDataSource3.Value = this.rPTPurchaseReportByParameterBindingSource;
            reportDataSource4.Name = "DSPurchaseReturnReportByParameter";
            reportDataSource4.Value = this.rPTPurchaseReturnReportByParameterBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FinalProject.RDLC.RPTGeneralReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 139);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1904, 842);
            this.reportViewer1.TabIndex = 36;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(277, 14);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(257, 20);
            this.dateTimePickerStartDate.TabIndex = 0;
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
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(728, 14);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(278, 20);
            this.dateTimePickerEndDate.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(612, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "End Date :";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 12;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 276F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 293F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1904, 5);
            this.panel2.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1904, 5);
            this.panel4.TabIndex = 28;
            // 
            // StartDateEndDatePanel
            // 
            this.StartDateEndDatePanel.BackColor = System.Drawing.Color.White;
            this.StartDateEndDatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StartDateEndDatePanel.Controls.Add(this.tableLayoutPanel3);
            this.StartDateEndDatePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.StartDateEndDatePanel.Location = new System.Drawing.Point(0, 74);
            this.StartDateEndDatePanel.Name = "StartDateEndDatePanel";
            this.StartDateEndDatePanel.Size = new System.Drawing.Size(1904, 60);
            this.StartDateEndDatePanel.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 5);
            this.panel1.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(751, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(267, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "General Report";
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1904, 5);
            this.panel3.TabIndex = 33;
            // 
            // Headerpanel
            // 
            this.Headerpanel.BackColor = System.Drawing.Color.White;
            this.Headerpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Headerpanel.Controls.Add(this.tableLayoutPanel1);
            this.Headerpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Headerpanel.Location = new System.Drawing.Point(0, 0);
            this.Headerpanel.Name = "Headerpanel";
            this.Headerpanel.Size = new System.Drawing.Size(1904, 64);
            this.Headerpanel.TabIndex = 32;
            // 
            // dSRPTPurchaseReportByParameter
            // 
            this.dSRPTPurchaseReportByParameter.DataSetName = "DSRPTPurchaseReportByParameter";
            this.dSRPTPurchaseReportByParameter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTPurchaseReportByParameterBindingSource
            // 
            this.rPTPurchaseReportByParameterBindingSource.DataMember = "RPTPurchaseReportByParameter";
            this.rPTPurchaseReportByParameterBindingSource.DataSource = this.dSRPTPurchaseReportByParameter;
            // 
            // rPTPurchaseReportByParameterTableAdapter
            // 
            this.rPTPurchaseReportByParameterTableAdapter.ClearBeforeFill = true;
            // 
            // dSRPTPurchaseReturnReportByParameter
            // 
            this.dSRPTPurchaseReturnReportByParameter.DataSetName = "DSRPTPurchaseReturnReportByParameter";
            this.dSRPTPurchaseReturnReportByParameter.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rPTPurchaseReturnReportByParameterBindingSource
            // 
            this.rPTPurchaseReturnReportByParameterBindingSource.DataMember = "RPTPurchaseReturnReportByParameter";
            this.rPTPurchaseReturnReportByParameterBindingSource.DataSource = this.dSRPTPurchaseReturnReportByParameter;
            // 
            // rPTPurchaseReturnReportByParameterTableAdapter
            // 
            this.rPTPurchaseReturnReportByParameterTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRPTGeneralReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 981);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.StartDateEndDatePanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Headerpanel);
            this.Name = "FrmRPTGeneralReport";
            this.Text = "FrmRPTGeneralReport";
            this.Load += new System.EventHandler(this.FrmRPTGeneralReport_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.StartDateEndDatePanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Headerpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTPurchaseReportByParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTPurchaseReportByParameterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSRPTPurchaseReturnReportByParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rPTPurchaseReturnReportByParameterBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel StartDateEndDatePanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel Headerpanel;
        private System.Windows.Forms.BindingSource rPTPurchaseReportByParameterBindingSource;
        private FinalProjectDataSets.RPTDataset.DSRPTPurchaseReportByParameter dSRPTPurchaseReportByParameter;
        private System.Windows.Forms.BindingSource rPTPurchaseReturnReportByParameterBindingSource;
        private FinalProjectDataSets.RPTDataset.DSRPTPurchaseReturnReportByParameter dSRPTPurchaseReturnReportByParameter;
        private FinalProjectDataSets.RPTDataset.DSRPTPurchaseReportByParameterTableAdapters.RPTPurchaseReportByParameterTableAdapter rPTPurchaseReportByParameterTableAdapter;
        private FinalProjectDataSets.RPTDataset.DSRPTPurchaseReturnReportByParameterTableAdapters.RPTPurchaseReturnReportByParameterTableAdapter rPTPurchaseReturnReportByParameterTableAdapter;
    }
}