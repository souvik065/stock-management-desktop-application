using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class FrmProdctMasterAndDetails : Form
    {
        Int32 productid = 0;
        public FrmProdctMasterAndDetails()
        {
            InitializeComponent();
        }

        
       

        public void GSTCAl()
        {
            if (Convert.ToDecimal(txtCGSTPercentage.Text) > Convert.ToDecimal(0.00) || Convert.ToDecimal(txtSGSTPercentage.Text) > Convert.ToDecimal(0.00))
            {
                IGSTPercentage.ReadOnly = true;
                IGSTAmount.ReadOnly = true;

                txtCGSTAmount.Text = Convert.ToString(Convert.ToDecimal(txtSalesRate.Text) * Convert.ToDecimal(txtCGSTPercentage.Text) / 100);
                txtSGSTAmount.Text = Convert.ToString(Convert.ToDecimal(txtSalesRate.Text) * Convert.ToDecimal(txtSGSTPercentage.Text) / 100);

            }
            else if (Convert.ToDecimal(IGSTPercentage.Text) > Convert.ToDecimal(0.00))
            {
                txtCGSTPercentage.ReadOnly = true;
                txtCGSTAmount.ReadOnly = true;
                txtSGSTPercentage.ReadOnly = true;
                txtSGSTAmount.ReadOnly = true;

                IGSTAmount.Text = Convert.ToString(Convert.ToDecimal(txtSalesRate.Text) * Convert.ToDecimal(IGSTPercentage.Text) / 100);


            }
        }



        public void Reset()
        {
            txtProductName.Clear();
            comboBoxCategoryName.SelectedIndex = 0;
            txtQTY.Text = "1";
            comboBoxUnit.SelectedIndex = 0;
            txtPurchaseRate.Clear();
            txtSalesRate.Clear();
            txtCGSTPercentage.Text = "0.00";
            txtCGSTAmount.Text = "0.00";
            txtSGSTPercentage.Text = "0.00";
            txtSGSTAmount.Text = "0.00";
            IGSTPercentage.Text = "0.00";
            IGSTAmount.Text = "0.00";
            txtBasicRate.Clear();
            txtMRP.Clear();

        }


        private void MasterInsert()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("InsertIntoProductMaster", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUCTNAME",txtProductName.Text).DbType = DbType.String;
           cmd.Parameters.AddWithValue("@SUBCATEGORYID", comboBoxSubCategoryName.SelectedValue).DbType = DbType.Int32;

            // cmd.ExecuteNonQuery();
           productid =Convert.ToInt32(cmd.ExecuteScalar());

            MessageBox.Show("Inserted Successfully");

            SQLQueryClass.con.Close();

            
        }

        // Insert, Update, Delete Methods
        private void ProductDetailInsert()
        {
            SQLQueryClass.con.Open();

            SqlCommand cmd = new SqlCommand("InsertIntoProductDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUCTID", productid).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@QTY", txtQTY.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@UNIT", comboBoxUnit.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@PURCHASERATE", txtPurchaseRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SALESRATE", txtSalesRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTPERCENTAGE", txtCGSTPercentage.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTAMOUNT", txtCGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTPERCENTAGE", txtSGSTPercentage.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTAMOUNT", txtSGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTPERCENTAGE", IGSTPercentage.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTAMOUNT", IGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@BASICRATE", txtBasicRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@MRP", txtMRP.Text).DbType = DbType.Decimal;
            
            

            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted Successfully");

            SQLQueryClass.con.Close();

            

        }
        /*

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Insert();
        }


        private void Update()
        {
            SQLQueryClass.con.Open();

            SqlCommand cmd = new SqlCommand("UpdateSubCategoryDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SUBCATEGORYID", txtSubCategory.Tag).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@CATEGORYID", comboBoxCategoryName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@SUBCATEGORYNAME", txtSubCategory.Text).DbType = DbType.String;

            cmd.ExecuteNonQuery();

            SQLQueryClass.con.Close();

           

        }

        private void Delete()
        {
            SQLQueryClass.con.Open();

            SqlCommand cmd = new SqlCommand("DeleteSubCategoryDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SUBCATEGORYID", txtSubCategory.Tag).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();

            SQLQueryClass.con.Close();

           
        }*/

        private void FillData()
        {

            txtProductName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxSubCategoryName.SelectedValue = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtQTY.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            comboBoxUnit.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtPurchaseRate.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtSalesRate.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtCGSTPercentage.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtCGSTAmount.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtSalesRate.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtSGSTAmount.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            IGSTPercentage.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            IGSTAmount.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtBasicRate.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txtMRP.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();

           
        }
         


        private void comboBoxCategoryName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listSubCategoryDetailsTableAdapter.Fill(this.listSubCategoryDetails._ListSubCategoryDetails,Convert.ToInt32(comboBoxCategoryName.SelectedValue));
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmProdctMasterAndDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSGetProductDetails.GetProductDetails' table. You can move, or remove it, as needed.
            

            // TODO: This line of code loads data into the 'listCategoryDetails._ListCategoryDetails' table. You can move, or remove it, as needed.
            this.listCategoryDetailsTableAdapter.Fill(this.listCategoryDetails._ListCategoryDetails);


            comboBoxUnit.Items.Add("--Select Unit--");
            comboBoxUnit.Items.Add("Kg");
            comboBoxUnit.Items.Add("g");
            comboBoxUnit.Items.Add("mg");
            comboBoxUnit.Items.Add("L");
            comboBoxUnit.Items.Add("ml");

            Reset();

            txtProductName.Focus();

        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            MasterInsert();
            ProductDetailInsert();
            Reset();

            
            
        }

       

        private void txtSGSTPercentage_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductDetailspanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSGSTAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCGSTAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCGSTPercentage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCGSTPercentage_KeyDown(object sender, KeyEventArgs e)
        {
            
            GSTCAl();
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }


        private void txtSGSTPercentage_KeyDown(object sender, KeyEventArgs e)
        {
            GSTCAl();
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IGSTPercentage_KeyDown(object sender, KeyEventArgs e)
        {
            GSTCAl();
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void comboBoxCategoryName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void comboBoxSubCategoryName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtQTY_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void comboBoxUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPurchaseRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtSalesRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtSGSTPercentage_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtCGSTPercentage_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void txtBasicRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtMRP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnInsert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnUpdate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnDelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
