namespace FinalProject
{
    partial class FrmProdctMasterAndDetails
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
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSubCategoryName = new System.Windows.Forms.ComboBox();
            this.listSubCategoryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listSubCategoryDetails = new FinalProject.FinalProjectDataSets.ListSubCategoryDetails();
            this.comboBoxCategoryName = new System.Windows.Forms.ComboBox();
            this.listCategoryDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listCategoryDetails = new FinalProject.FinalProjectDataSets.ListCategoryDetails();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtMRP = new System.Windows.Forms.TextBox();
            this.IGSTAmount = new System.Windows.Forms.TextBox();
            this.txtBasicRate = new System.Windows.Forms.TextBox();
            this.IGSTPercentage = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSGSTAmount = new System.Windows.Forms.TextBox();
            this.txtCGSTAmount = new System.Windows.Forms.TextBox();
            this.txtSGSTPercentage = new System.Windows.Forms.TextBox();
            this.txtCGSTPercentage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSalesRate = new System.Windows.Forms.TextBox();
            this.txtQTY = new System.Windows.Forms.TextBox();
            this.txtPurchaseRate = new System.Windows.Forms.TextBox();
            this.comboBoxUnit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listCategoryDetailsTableAdapter = new FinalProject.FinalProjectDataSets.ListCategoryDetailsTableAdapters.ListCategoryDetailsTableAdapter();
            this.listSubCategoryDetailsTableAdapter = new FinalProject.FinalProjectDataSets.ListSubCategoryDetailsTableAdapters.ListSubCategoryDetailsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dSGetProductDetails = new FinalProject.FinalProjectDataSets.DSGetProductDetails();
            this.dSGetProductDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getProductDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.getProductDetailsTableAdapter = new FinalProject.FinalProjectDataSets.DSGetProductDetailsTableAdapters.GetProductDetailsTableAdapter();
            this.pRODUCTDETAILIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRODUCTIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qTYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNITDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pURCHASERATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sALESRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGSTPERCENTAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGSTAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGSTPERCENTAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sGSTAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGSTPERCENTAGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iGSTAMOUNTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bASICRATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mRPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listSubCategoryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSubCategoryDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetails)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGetProductDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGetProductDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(1106, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Sub-Category Name :";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(580, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category Name :";
            // 
            // comboBoxSubCategoryName
            // 
            this.comboBoxSubCategoryName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSubCategoryName.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxSubCategoryName.DataSource = this.listSubCategoryDetailsBindingSource;
            this.comboBoxSubCategoryName.DisplayMember = "SUBCATEGORYNAME";
            this.comboBoxSubCategoryName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubCategoryName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSubCategoryName.FormattingEnabled = true;
            this.comboBoxSubCategoryName.Location = new System.Drawing.Point(1333, 10);
            this.comboBoxSubCategoryName.Name = "comboBoxSubCategoryName";
            this.comboBoxSubCategoryName.Size = new System.Drawing.Size(383, 30);
            this.comboBoxSubCategoryName.TabIndex = 2;
            this.comboBoxSubCategoryName.ValueMember = "SUBCATEGORYID";
            this.comboBoxSubCategoryName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxSubCategoryName_KeyDown);
            // 
            // listSubCategoryDetailsBindingSource
            // 
            this.listSubCategoryDetailsBindingSource.DataMember = "ListSubCategoryDetails";
            this.listSubCategoryDetailsBindingSource.DataSource = this.listSubCategoryDetails;
            // 
            // listSubCategoryDetails
            // 
            this.listSubCategoryDetails.DataSetName = "ListSubCategoryDetails";
            this.listSubCategoryDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.comboBoxCategoryName.Location = new System.Drawing.Point(755, 10);
            this.comboBoxCategoryName.Name = "comboBoxCategoryName";
            this.comboBoxCategoryName.Size = new System.Drawing.Size(340, 30);
            this.comboBoxCategoryName.TabIndex = 1;
            this.comboBoxCategoryName.ValueMember = "CATEGORYID";
            this.comboBoxCategoryName.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategoryName_SelectedIndexChanged);
            this.comboBoxCategoryName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxCategoryName_KeyDown);
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
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(168, 14);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(404, 22);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            this.txtProductName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtProductName_KeyDown);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnInsert.FlatAppearance.BorderSize = 0;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(75, 15);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(125, 35);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click_1);
            this.btnInsert.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnInsert_KeyDown);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(220, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 35);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnUpdate_KeyDown);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(365, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 35);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnDelete_KeyDown);
            // 
            // txtMRP
            // 
            this.txtMRP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMRP.BackColor = System.Drawing.Color.Gainsboro;
            this.txtMRP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMRP.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMRP.Location = new System.Drawing.Point(755, 10);
            this.txtMRP.Name = "txtMRP";
            this.txtMRP.Size = new System.Drawing.Size(133, 22);
            this.txtMRP.TabIndex = 1;
            this.txtMRP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMRP_KeyDown);
            // 
            // IGSTAmount
            // 
            this.IGSTAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IGSTAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.IGSTAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IGSTAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IGSTAmount.Location = new System.Drawing.Point(1408, 12);
            this.IGSTAmount.Name = "IGSTAmount";
            this.IGSTAmount.Size = new System.Drawing.Size(107, 22);
            this.IGSTAmount.TabIndex = 1;
            // 
            // txtBasicRate
            // 
            this.txtBasicRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBasicRate.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBasicRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBasicRate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasicRate.Location = new System.Drawing.Point(160, 10);
            this.txtBasicRate.Name = "txtBasicRate";
            this.txtBasicRate.Size = new System.Drawing.Size(112, 22);
            this.txtBasicRate.TabIndex = 0;
            this.txtBasicRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBasicRate_KeyDown);
            // 
            // IGSTPercentage
            // 
            this.IGSTPercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IGSTPercentage.BackColor = System.Drawing.Color.Gainsboro;
            this.IGSTPercentage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IGSTPercentage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IGSTPercentage.Location = new System.Drawing.Point(1332, 12);
            this.IGSTPercentage.Name = "IGSTPercentage";
            this.IGSTPercentage.Size = new System.Drawing.Size(56, 22);
            this.IGSTPercentage.TabIndex = 2;
            this.IGSTPercentage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.IGSTPercentage_KeyDown);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label13.Location = new System.Drawing.Point(678, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 22);
            this.label13.TabIndex = 0;
            this.label13.Text = "MRP :";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label15.Location = new System.Drawing.Point(19, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 22);
            this.label15.TabIndex = 0;
            this.label15.Text = "Basic Rate :";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label16.Location = new System.Drawing.Point(1223, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(90, 22);
            this.label16.TabIndex = 0;
            this.label16.Text = "IGST % :";
            // 
            // txtSGSTAmount
            // 
            this.txtSGSTAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSGSTAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSGSTAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSGSTAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGSTAmount.Location = new System.Drawing.Point(831, 12);
            this.txtSGSTAmount.Name = "txtSGSTAmount";
            this.txtSGSTAmount.Size = new System.Drawing.Size(107, 22);
            this.txtSGSTAmount.TabIndex = 3;
            this.txtSGSTAmount.TextChanged += new System.EventHandler(this.txtSGSTAmount_TextChanged);
            // 
            // txtCGSTAmount
            // 
            this.txtCGSTAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCGSTAmount.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCGSTAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCGSTAmount.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGSTAmount.Location = new System.Drawing.Point(208, 12);
            this.txtCGSTAmount.Name = "txtCGSTAmount";
            this.txtCGSTAmount.Size = new System.Drawing.Size(125, 22);
            this.txtCGSTAmount.TabIndex = 6;
            this.txtCGSTAmount.TextChanged += new System.EventHandler(this.txtCGSTAmount_TextChanged);
            // 
            // txtSGSTPercentage
            // 
            this.txtSGSTPercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSGSTPercentage.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSGSTPercentage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSGSTPercentage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGSTPercentage.Location = new System.Drawing.Point(761, 12);
            this.txtSGSTPercentage.Name = "txtSGSTPercentage";
            this.txtSGSTPercentage.Size = new System.Drawing.Size(49, 22);
            this.txtSGSTPercentage.TabIndex = 1;
            this.txtSGSTPercentage.TextChanged += new System.EventHandler(this.txtSGSTPercentage_TextChanged_1);
            this.txtSGSTPercentage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSGSTPercentage_KeyDown);
            // 
            // txtCGSTPercentage
            // 
            this.txtCGSTPercentage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCGSTPercentage.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCGSTPercentage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCGSTPercentage.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGSTPercentage.Location = new System.Drawing.Point(125, 12);
            this.txtCGSTPercentage.Name = "txtCGSTPercentage";
            this.txtCGSTPercentage.Size = new System.Drawing.Size(67, 22);
            this.txtCGSTPercentage.TabIndex = 0;
            this.txtCGSTPercentage.TextChanged += new System.EventHandler(this.txtCGSTPercentage_TextChanged_1);
            this.txtCGSTPercentage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCGSTPercentage_KeyDown);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(649, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "SGST % :";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label12.Location = new System.Drawing.Point(9, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 22);
            this.label12.TabIndex = 0;
            this.label12.Text = "CGST % :";
            // 
            // txtSalesRate
            // 
            this.txtSalesRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSalesRate.BackColor = System.Drawing.Color.Gainsboro;
            this.txtSalesRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalesRate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalesRate.Location = new System.Drawing.Point(1335, 12);
            this.txtSalesRate.Name = "txtSalesRate";
            this.txtSalesRate.Size = new System.Drawing.Size(159, 22);
            this.txtSalesRate.TabIndex = 3;
            this.txtSalesRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSalesRate_KeyDown);
            // 
            // txtQTY
            // 
            this.txtQTY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQTY.BackColor = System.Drawing.Color.Gainsboro;
            this.txtQTY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQTY.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQTY.Location = new System.Drawing.Point(100, 12);
            this.txtQTY.Name = "txtQTY";
            this.txtQTY.Size = new System.Drawing.Size(93, 22);
            this.txtQTY.TabIndex = 0;
            this.txtQTY.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQTY_KeyDown);
            // 
            // txtPurchaseRate
            // 
            this.txtPurchaseRate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPurchaseRate.BackColor = System.Drawing.Color.Gainsboro;
            this.txtPurchaseRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPurchaseRate.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseRate.Location = new System.Drawing.Point(761, 12);
            this.txtPurchaseRate.Name = "txtPurchaseRate";
            this.txtPurchaseRate.Size = new System.Drawing.Size(207, 22);
            this.txtPurchaseRate.TabIndex = 2;
            this.txtPurchaseRate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPurchaseRate_KeyDown);
            // 
            // comboBoxUnit
            // 
            this.comboBoxUnit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxUnit.BackColor = System.Drawing.Color.Gainsboro;
            this.comboBoxUnit.DisplayMember = "CATEGORYNAME";
            this.comboBoxUnit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxUnit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUnit.FormattingEnabled = true;
            this.comboBoxUnit.Location = new System.Drawing.Point(279, 8);
            this.comboBoxUnit.Name = "comboBoxUnit";
            this.comboBoxUnit.Size = new System.Drawing.Size(135, 30);
            this.comboBoxUnit.TabIndex = 1;
            this.comboBoxUnit.ValueMember = "CATEGORYID";
            this.comboBoxUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxUnit_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(15, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "QTY :";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(205, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Unit :";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(591, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Purchase Rate :";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(1194, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sales Rate :";
            // 
            // listCategoryDetailsTableAdapter
            // 
            this.listCategoryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // listSubCategoryDetailsTableAdapter
            // 
            this.listSubCategoryDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(726, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Master";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product Name :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 583F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1731, 51);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.540034F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.73651F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.10789F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.38614F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.54969F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.67973F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtProductName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxSubCategoryName, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxCategoryName, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 51);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1731, 51);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 11;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 163F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 226F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 212F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 194F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 219F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtQTY, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtSalesRate, 9, 0);
            this.tableLayoutPanel3.Controls.Add(this.comboBoxUnit, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtPurchaseRate, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.label8, 8, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 102);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1731, 47);
            this.tableLayoutPanel3.TabIndex = 14;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 12;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.27602F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.72398F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 302F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 268F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtCGSTPercentage, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtCGSTAmount, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.IGSTPercentage, 9, 0);
            this.tableLayoutPanel4.Controls.Add(this.label16, 8, 0);
            this.tableLayoutPanel4.Controls.Add(this.IGSTAmount, 10, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtSGSTPercentage, 5, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtSGSTAmount, 6, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 149);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1731, 46);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 7;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.11765F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 390F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 836F));
            this.tableLayoutPanel5.Controls.Add(this.label15, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtBasicRate, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label13, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.txtMRP, 5, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 195);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1731, 43);
            this.tableLayoutPanel5.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 238);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1731, 63);
            this.panel1.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRODUCTDETAILIDDataGridViewTextBoxColumn,
            this.pRODUCTIDDataGridViewTextBoxColumn,
            this.qTYDataGridViewTextBoxColumn,
            this.uNITDataGridViewTextBoxColumn,
            this.pURCHASERATEDataGridViewTextBoxColumn,
            this.sALESRATEDataGridViewTextBoxColumn,
            this.cGSTPERCENTAGEDataGridViewTextBoxColumn,
            this.cGSTAMOUNTDataGridViewTextBoxColumn,
            this.sGSTPERCENTAGEDataGridViewTextBoxColumn,
            this.sGSTAMOUNTDataGridViewTextBoxColumn,
            this.iGSTPERCENTAGEDataGridViewTextBoxColumn,
            this.iGSTAMOUNTDataGridViewTextBoxColumn,
            this.bASICRATEDataGridViewTextBoxColumn,
            this.mRPDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.getProductDetailsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 301);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1731, 480);
            this.dataGridView1.TabIndex = 18;
            // 
            // dSGetProductDetails
            // 
            this.dSGetProductDetails.DataSetName = "DSGetProductDetails";
            this.dSGetProductDetails.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dSGetProductDetailsBindingSource
            // 
            this.dSGetProductDetailsBindingSource.DataSource = this.dSGetProductDetails;
            this.dSGetProductDetailsBindingSource.Position = 0;
            // 
            // getProductDetailsBindingSource
            // 
            this.getProductDetailsBindingSource.DataMember = "GetProductDetails";
            this.getProductDetailsBindingSource.DataSource = this.dSGetProductDetails;
            // 
            // getProductDetailsTableAdapter
            // 
            this.getProductDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // pRODUCTDETAILIDDataGridViewTextBoxColumn
            // 
            this.pRODUCTDETAILIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCTDETAILID";
            this.pRODUCTDETAILIDDataGridViewTextBoxColumn.HeaderText = "PRODUCTDETAILID";
            this.pRODUCTDETAILIDDataGridViewTextBoxColumn.Name = "pRODUCTDETAILIDDataGridViewTextBoxColumn";
            this.pRODUCTDETAILIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pRODUCTIDDataGridViewTextBoxColumn
            // 
            this.pRODUCTIDDataGridViewTextBoxColumn.DataPropertyName = "PRODUCTID";
            this.pRODUCTIDDataGridViewTextBoxColumn.HeaderText = "PRODUCTID";
            this.pRODUCTIDDataGridViewTextBoxColumn.Name = "pRODUCTIDDataGridViewTextBoxColumn";
            this.pRODUCTIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qTYDataGridViewTextBoxColumn
            // 
            this.qTYDataGridViewTextBoxColumn.DataPropertyName = "QTY";
            this.qTYDataGridViewTextBoxColumn.HeaderText = "QTY";
            this.qTYDataGridViewTextBoxColumn.Name = "qTYDataGridViewTextBoxColumn";
            this.qTYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uNITDataGridViewTextBoxColumn
            // 
            this.uNITDataGridViewTextBoxColumn.DataPropertyName = "UNIT";
            this.uNITDataGridViewTextBoxColumn.HeaderText = "UNIT";
            this.uNITDataGridViewTextBoxColumn.Name = "uNITDataGridViewTextBoxColumn";
            this.uNITDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pURCHASERATEDataGridViewTextBoxColumn
            // 
            this.pURCHASERATEDataGridViewTextBoxColumn.DataPropertyName = "PURCHASERATE";
            this.pURCHASERATEDataGridViewTextBoxColumn.HeaderText = "PURCHASERATE";
            this.pURCHASERATEDataGridViewTextBoxColumn.Name = "pURCHASERATEDataGridViewTextBoxColumn";
            this.pURCHASERATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sALESRATEDataGridViewTextBoxColumn
            // 
            this.sALESRATEDataGridViewTextBoxColumn.DataPropertyName = "SALESRATE";
            this.sALESRATEDataGridViewTextBoxColumn.HeaderText = "SALESRATE";
            this.sALESRATEDataGridViewTextBoxColumn.Name = "sALESRATEDataGridViewTextBoxColumn";
            this.sALESRATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cGSTPERCENTAGEDataGridViewTextBoxColumn
            // 
            this.cGSTPERCENTAGEDataGridViewTextBoxColumn.DataPropertyName = "CGSTPERCENTAGE";
            this.cGSTPERCENTAGEDataGridViewTextBoxColumn.HeaderText = "CGSTPERCENTAGE";
            this.cGSTPERCENTAGEDataGridViewTextBoxColumn.Name = "cGSTPERCENTAGEDataGridViewTextBoxColumn";
            this.cGSTPERCENTAGEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cGSTAMOUNTDataGridViewTextBoxColumn
            // 
            this.cGSTAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "CGSTAMOUNT";
            this.cGSTAMOUNTDataGridViewTextBoxColumn.HeaderText = "CGSTAMOUNT";
            this.cGSTAMOUNTDataGridViewTextBoxColumn.Name = "cGSTAMOUNTDataGridViewTextBoxColumn";
            this.cGSTAMOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sGSTPERCENTAGEDataGridViewTextBoxColumn
            // 
            this.sGSTPERCENTAGEDataGridViewTextBoxColumn.DataPropertyName = "SGSTPERCENTAGE";
            this.sGSTPERCENTAGEDataGridViewTextBoxColumn.HeaderText = "SGSTPERCENTAGE";
            this.sGSTPERCENTAGEDataGridViewTextBoxColumn.Name = "sGSTPERCENTAGEDataGridViewTextBoxColumn";
            this.sGSTPERCENTAGEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sGSTAMOUNTDataGridViewTextBoxColumn
            // 
            this.sGSTAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "SGSTAMOUNT";
            this.sGSTAMOUNTDataGridViewTextBoxColumn.HeaderText = "SGSTAMOUNT";
            this.sGSTAMOUNTDataGridViewTextBoxColumn.Name = "sGSTAMOUNTDataGridViewTextBoxColumn";
            this.sGSTAMOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iGSTPERCENTAGEDataGridViewTextBoxColumn
            // 
            this.iGSTPERCENTAGEDataGridViewTextBoxColumn.DataPropertyName = "IGSTPERCENTAGE";
            this.iGSTPERCENTAGEDataGridViewTextBoxColumn.HeaderText = "IGSTPERCENTAGE";
            this.iGSTPERCENTAGEDataGridViewTextBoxColumn.Name = "iGSTPERCENTAGEDataGridViewTextBoxColumn";
            this.iGSTPERCENTAGEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iGSTAMOUNTDataGridViewTextBoxColumn
            // 
            this.iGSTAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "IGSTAMOUNT";
            this.iGSTAMOUNTDataGridViewTextBoxColumn.HeaderText = "IGSTAMOUNT";
            this.iGSTAMOUNTDataGridViewTextBoxColumn.Name = "iGSTAMOUNTDataGridViewTextBoxColumn";
            this.iGSTAMOUNTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bASICRATEDataGridViewTextBoxColumn
            // 
            this.bASICRATEDataGridViewTextBoxColumn.DataPropertyName = "BASICRATE";
            this.bASICRATEDataGridViewTextBoxColumn.HeaderText = "BASICRATE";
            this.bASICRATEDataGridViewTextBoxColumn.Name = "bASICRATEDataGridViewTextBoxColumn";
            this.bASICRATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mRPDataGridViewTextBoxColumn
            // 
            this.mRPDataGridViewTextBoxColumn.DataPropertyName = "MRP";
            this.mRPDataGridViewTextBoxColumn.HeaderText = "MRP";
            this.mRPDataGridViewTextBoxColumn.Name = "mRPDataGridViewTextBoxColumn";
            this.mRPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FrmProdctMasterAndDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1731, 781);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmProdctMasterAndDetails";
            this.Text = "FrmProdctMasterAndDetails";
            this.Load += new System.EventHandler(this.FrmProdctMasterAndDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listSubCategoryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listSubCategoryDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listCategoryDetails)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGetProductDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGetProductDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getProductDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox comboBoxCategoryName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtMRP;
        private System.Windows.Forms.TextBox IGSTAmount;
        private System.Windows.Forms.TextBox txtBasicRate;
        private System.Windows.Forms.TextBox IGSTPercentage;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtSGSTAmount;
        private System.Windows.Forms.TextBox txtCGSTAmount;
        private System.Windows.Forms.TextBox txtSGSTPercentage;
        private System.Windows.Forms.TextBox txtCGSTPercentage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSalesRate;
        private System.Windows.Forms.TextBox txtQTY;
        private System.Windows.Forms.TextBox txtPurchaseRate;
        private System.Windows.Forms.ComboBox comboBoxUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxSubCategoryName;
        private FinalProjectDataSets.ListCategoryDetails listCategoryDetails;
        private System.Windows.Forms.BindingSource listCategoryDetailsBindingSource;
        private FinalProjectDataSets.ListCategoryDetailsTableAdapters.ListCategoryDetailsTableAdapter listCategoryDetailsTableAdapter;
        private System.Windows.Forms.BindingSource listSubCategoryDetailsBindingSource;
        private FinalProjectDataSets.ListSubCategoryDetails listSubCategoryDetails;
        private FinalProjectDataSets.ListSubCategoryDetailsTableAdapters.ListSubCategoryDetailsTableAdapter listSubCategoryDetailsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dSGetProductDetailsBindingSource;
        private FinalProjectDataSets.DSGetProductDetails dSGetProductDetails;
        private System.Windows.Forms.BindingSource getProductDetailsBindingSource;
        private FinalProjectDataSets.DSGetProductDetailsTableAdapters.GetProductDetailsTableAdapter getProductDetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTDETAILIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRODUCTIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qTYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNITDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pURCHASERATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sALESRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGSTPERCENTAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGSTAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGSTPERCENTAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sGSTAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGSTPERCENTAGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iGSTAMOUNTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bASICRATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mRPDataGridViewTextBoxColumn;
    }
}