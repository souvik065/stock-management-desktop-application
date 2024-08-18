using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class FrmProductMasterAndDetails : Form
    {

       
        Int32 productID = 0;
        Int32 productDetailID = 0;
        
        public FrmProductMasterAndDetails()
        {
            InitializeComponent();
        }

        private void EnablePanelContents()
        {

            tableLayoutProductDetailPanel.Enabled = false;
            tableLayoutProductDetailPanel2.Enabled = false;
            txtBasicRate.Enabled = false;
            txtMRP.Enabled = false;
            dataGridView1.Enabled = false;

            if (txtProductName.Text != null && comboBoxSubCategory.SelectedValue != null)
            {
                tableLayoutProductDetailPanel.Enabled = Enabled;
                tableLayoutProductDetailPanel2.Enabled = Enabled;
                txtBasicRate.Enabled = Enabled;
                txtMRP.Enabled = Enabled;
                dataGridView1.Enabled = Enabled;

                tableLayoutProductMasterPanel.Enabled = false;

            }

        }

       
        public void Reset()
        {
           
            txtQTY.Text = "1";
            comboBoxUnit.SelectedIndex = 1;
            txtPurchaseRate.Text = "0";
            txtSalesRate.Text = "0";
            txtCGSTRate.Text = "0";
            txtCGSTAmount.Text = "0";
            txtSGSTRate.Text = "0";
            txtSGSTAmount.Text = "0";
            txtIGSTRate.Text = "0";
            txtIGSTAmount.Text = "0";
            txtBasicRate.Text = "0";
            txtMRP.Text = "0";
            productDetailID = 0;

        }

        public void SaveEvent()
        {
            DialogResult dialogResult =  MessageBox.Show("Alert", "Do you want to save the Details.", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (productID != 0 && dialogResult == DialogResult.Yes)
            {
                
                productID = 0;
                Reset();
                tableLayoutProductMasterPanel.Enabled = Enabled;
                tableLayoutProductDetailPanel.Enabled = false;
                tableLayoutProductDetailPanel2.Enabled = false;
                txtBasicRate.Enabled = false;
                txtMRP.Enabled = false;
                txtProductName.Clear();
                comboBoxCategory.SelectedIndex = 0;
                comboBoxSubCategory.SelectedIndex = 0;
                txtProductName.Focus();
                MessageBox.Show("Details Saved Successfully");

                this.getProductDetailsTableAdapter.Fill(this.dSGetProductDetails.GetProductDetails, productID);

            }
        }

        public void ResetForm()
        {
            if (productID != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Alert", "Do you want to Reste the Form. All the data will be deleted.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (productID != 0 && dialogResult == DialogResult.Yes)
                {
                    DeleteIntoProductMaster();
                    ResetProductDetails();
                    productID = 0;
                    Reset();
                    tableLayoutProductMasterPanel.Enabled = Enabled;
                    tableLayoutProductDetailPanel.Enabled = false;
                    tableLayoutProductDetailPanel2.Enabled = false;
                    txtBasicRate.Enabled = false;
                    txtMRP.Enabled = false;
                    txtProductName.Clear();
                    comboBoxCategory.SelectedIndex = 0;
                    comboBoxSubCategory.SelectedIndex = 0;
                    txtProductName.Focus();
                    MessageBox.Show("Form Reset Successfully");
                    this.getProductDetailsTableAdapter.Fill(this.dSGetProductDetails.GetProductDetails, productID);
                }
            }
            else {
                MessageBox.Show("Nothing To Reset");
            }
        }

        public void ResetProductDetails()
        {
            if (productID > 0)
            {
                SQLQueryClass.con.Open();
                SqlCommand cmd = new SqlCommand("ResetProductDetail", SQLQueryClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PRODUCTID", productID).DbType = DbType.Int32;


                // cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Detail Deleted Successfully");

                SQLQueryClass.con.Close();
            }
            this.getProductDetailsTableAdapter.Fill(this.dSGetProductDetails.GetProductDetails, productID);
        }

        public void InsertIntoProductMaster()
        {
            
                SQLQueryClass.con.Open();
                SqlCommand cmd = new SqlCommand("InsertIntoProductMaster", SQLQueryClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PRODUCTNAME", txtProductName.Text).DbType = DbType.String;
                cmd.Parameters.AddWithValue("@SUBCATEGORYID", comboBoxSubCategory.SelectedValue).DbType = DbType.Int32;

                // cmd.ExecuteNonQuery();
                productID = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("Inserted into Product Master Successfully");

                SQLQueryClass.con.Close();   
            
        }

        private void InsertProductDetail()
        {
            SQLQueryClass.con.Open();

            SqlCommand cmd = new SqlCommand("InsertIntoProductDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUCTID", productID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@QTY", txtQTY.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@UNIT", comboBoxUnit.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@PURCHASERATE", txtPurchaseRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SALESRATE", txtSalesRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTPERCENTAGE", txtCGSTRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTAMOUNT", txtCGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTPERCENTAGE", txtSGSTRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTAMOUNT", txtSGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTPERCENTAGE", txtIGSTRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTAMOUNT", txtIGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@BASICRATE", txtBasicRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@MRP", txtMRP.Text).DbType = DbType.Decimal;



            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Detail Inserted Successfully");

            SQLQueryClass.con.Close();

            this.getProductDetailsTableAdapter.Fill(this.dSGetProductDetails.GetProductDetails,productID);
        }

        public void UpdateProductDetails()
        {
            SQLQueryClass.con.Open();

            SqlCommand cmd = new SqlCommand("UpdateProductDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUCTDETAILID", productDetailID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@PRODUCTID", productID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@QTY", txtQTY.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@UNIT", comboBoxUnit.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@PURCHASERATE", txtPurchaseRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SALESRATE", txtSalesRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTPERCENTAGE", txtCGSTRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTAMOUNT", txtCGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTPERCENTAGE", txtSGSTRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTAMOUNT", txtSGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTPERCENTAGE", txtIGSTRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTAMOUNT", txtIGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@BASICRATE", txtBasicRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@MRP", txtMRP.Text).DbType = DbType.Decimal;



            cmd.ExecuteNonQuery();
            MessageBox.Show("Product Detail Updated Successfully");

            SQLQueryClass.con.Close();

            this.getProductDetailsTableAdapter.Fill(this.dSGetProductDetails.GetProductDetails,productID);
            //txtQTY.Tag = null;

            

        }


        public void DeleteProductDetail()
        {
            if (productDetailID > 0)
            {
                SQLQueryClass.con.Open();
                SqlCommand cmd = new SqlCommand("DeletePrductDetail", SQLQueryClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PRODUCTDETAILID", productDetailID).DbType = DbType.Int32;


                // cmd.ExecuteNonQuery();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Detail Deleted Successfully");

                SQLQueryClass.con.Close();
            }
            else {
                MessageBox.Show("No Records to Delete");
            }

            this.getProductDetailsTableAdapter.Fill(this.dSGetProductDetails.GetProductDetails, productID);
        }

        public void DeleteIntoProductMaster()
        {
            if (productID > 0)
            {
                SQLQueryClass.con.Open();
                SqlCommand cmd = new SqlCommand("DeleteIntoProductMaster", SQLQueryClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PRODUCTID", productID).DbType = DbType.Int32;


                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted From Product Master Successfully");

                SQLQueryClass.con.Close();
            }
            this.getProductDetailsTableAdapter.Fill(this.dSGetProductDetails.GetProductDetails, productID); 
        }


        public void GrideViewDelete()
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {

                dataGridView1.Rows.RemoveAt(item.Index);
            }
        }


        public void FillData()
        {
           productDetailID =Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            productID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            txtQTY.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxUnit.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPurchaseRate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtSalesRate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtCGSTRate.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtCGSTAmount.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtSGSTRate.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtSGSTAmount.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtIGSTRate.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtIGSTAmount.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtBasicRate.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtMRP.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
        }
      


        
        public void GSTCAl()
        {
            if (Convert.ToDecimal(txtCGSTRate.Text) > Convert.ToDecimal(0.00) || Convert.ToDecimal(txtSGSTRate.Text) > Convert.ToDecimal(0.00))
            {
                txtIGSTRate.ReadOnly = true;
                txtIGSTAmount.ReadOnly = true;

                txtCGSTAmount.Text = Convert.ToString(Convert.ToDecimal(txtSalesRate.Text) * Convert.ToDecimal(txtCGSTRate.Text) / 100);
                txtSGSTAmount.Text = Convert.ToString(Convert.ToDecimal(txtSalesRate.Text) * Convert.ToDecimal(txtSGSTRate.Text) / 100);

                txtBasicRate.Text = Convert.ToString((Convert.ToDecimal(txtSalesRate.Text) * Convert.ToDecimal(txtQTY.Text)) + Convert.ToDecimal(txtCGSTAmount.Text) + Convert.ToDecimal(txtSGSTAmount.Text));

            }
            else if (Convert.ToDecimal(txtIGSTRate.Text) > Convert.ToDecimal(0.00))
            {
                txtCGSTRate.ReadOnly = true;
                txtCGSTAmount.ReadOnly = true;
                txtSGSTRate.ReadOnly = true;
                txtSGSTAmount.ReadOnly = true;

                txtIGSTAmount.Text = Convert.ToString(Convert.ToDecimal(txtSalesRate.Text) * Convert.ToDecimal(txtIGSTRate.Text) / 100);

                txtBasicRate.Text = Convert.ToString((Convert.ToDecimal(txtSalesRate.Text) * Convert.ToDecimal(txtQTY.Text)) + Convert.ToDecimal(txtIGSTAmount.Text));
            }

            
        }


        private void FormClosingValidation()
        {

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("GetProductDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUCTID", productID);

            SQLQueryClass.con.Close();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                DialogResult dia = MessageBox.Show("Do you want to save.", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    SaveEvent();
                    MessageBox.Show("Saving...");
                }
                else if (dia == DialogResult.No)
                {
                    ResetForm();
                    MessageBox.Show("Reseting Form...");
                }
            }


            if (productID > 0)
            {
                DialogResult dia = MessageBox.Show("Are you sure you want to exit.", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    DeleteIntoProductMaster();
                    
                    MessageBox.Show("ProductID Deleted");
                }

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmProductMasterAndDetails_Load(object sender, EventArgs e)
        {
   

        }

       

        private void FrmProductMasterAndDetails_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSGetProductDetails.GetProductDetails' table. You can move, or remove it, as needed.
            this.getProductDetailsTableAdapter.Fill(this.dSGetProductDetails.GetProductDetails,productID);
            // TODO: This line of code loads data into the 'listCategoryDetails._ListCategoryDetails' table. You can move, or remove it, as needed.
            this.listCategoryDetailsTableAdapter.Fill(this.listCategoryDetails._ListCategoryDetails);

            EnablePanelContents();
            txtProductName.Focus();

             comboBoxUnit.SelectedIndex = 0;


            

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listSubCategoryDetailsTableAdapter.Fill(this.dSListSubCategoryDetails.ListSubCategoryDetails,Convert.ToInt32(comboBoxCategory.SelectedValue));
        }
        

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            if (productID == 0)
            {
                InsertIntoProductMaster();
            }
            if (tableLayoutProductMasterPanel.Enabled == false  && productDetailID == 0)
            {
               
                InsertProductDetail();  
            }
            else if(tableLayoutProductMasterPanel.Enabled == false)
            {
                UpdateProductDetails();

            }


            
            Reset();
            EnablePanelContents();
            txtQTY.Focus();






        }


        private void txtSGSTRate_KeyDown_1(object sender, KeyEventArgs e)
        {
            GSTCAl();
        }

        private void txtIGSTRate_KeyDown(object sender, KeyEventArgs e)
        {
            GSTCAl();
        }

        private void txtCGSTRate_KeyDown(object sender, KeyEventArgs e)
        {
            GSTCAl();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            SaveEvent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProductDetail();
            Reset();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillData();

        }

        private void txtSGSTAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();

        }

        private void txtCGSTRate_Leave(object sender, EventArgs e)
        {
            GSTCAl();
        }

        private void txtSGSTRate_Leave(object sender, EventArgs e)
        {
            GSTCAl();
        }

        private void txtIGSTRate_Leave(object sender, EventArgs e)
        {
            GSTCAl();
        }

        private void txtSalesRate_Leave(object sender, EventArgs e)
        {
            GSTCAl();
        }

        private void txtQTY_Leave(object sender, EventArgs e)
        {
            GSTCAl();
        }

        private void txtBasicRate_Leave(object sender, EventArgs e)
        {
            
        }

        private void FrmProductMasterAndDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingValidation();
        }
    }
    }

