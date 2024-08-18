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
    public partial class FrmSaleMaster : Form
    {
        int SalesMasterID = 0;
        int SalesDetailID = 0;
        public FrmSaleMaster()
        {
            InitializeComponent();
        }

        private void EnablePanelContent()
        {
            panelSalesDetail.Enabled = false;
            panelTotalAmounts.Enabled = false;
            if (Convert.ToDecimal(txtInvoiceNo.Text) > 0)
            {
                panelSalesDetail.Enabled = true;
                panelTotalAmounts.Enabled = true;
                SalesMasterpanel.Enabled = false;
            }
            else if (Convert.ToDecimal(txtInvoiceNo.Text) == 0)
            {
                panelSalesDetail.Enabled = false;
                panelTotalAmounts.Enabled = false;
                SalesMasterpanel.Enabled = true;
            }


        }

        private void InsertIntoSalesMaster()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("InsertIntoSalesMaster", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesDate", dateTimePickerSalesDate.Text).DbType = DbType.Date;
            cmd.Parameters.AddWithValue("@InvoiceNo", txtInvoiceNo.Text).DbType = DbType.Int32;

            // cmd.ExecuteNonQuery();
            SalesMasterID = Convert.ToInt32(cmd.ExecuteScalar());

            MessageBox.Show("Inserted into Sales Master Successfully");

            SQLQueryClass.con.Close();




        }


        private void InsertIntoSalesDetailTable()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("InsertIntoSalesDetail", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesID", SalesMasterID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@ProductID", comboBoxProductName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@Rate", txtRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@Qty", txtQty.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@HSNCode", txtHSNCode.Text).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@Total", txtTotal.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@DiscountPercentage", txtDiscountPercentage.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@DiscountAmount", txtDiscountAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TaxableAmount", txtTaxableAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTPercentage", txtCGSTPercentage.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTAmount", txtCGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTPercentage", txtSGSTPercentage.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTAmount", txtSGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTPercentage", txtIGSTPercentage.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTAmount", txtIGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@NetAmount", txtNetAmount.Text).DbType = DbType.Decimal;



            cmd.ExecuteNonQuery();


            MessageBox.Show("Inserted Sales Detail Successfully");

            SQLQueryClass.con.Close();

            this.getSalesDetailsTableAdapter.Fill(this.dSGetSalesDetail.GetSalesDetails, SalesMasterID);

        }

        private void UpdateSalesDetails()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("UpdateSalesDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesDetailID", SalesDetailID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@SalesID", SalesMasterID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@ProductID", comboBoxProductName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@Rate", txtRate.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@Qty", txtQty.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@HSNCode", txtHSNCode.Text).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@Total", txtTotal.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@DiscountPercentage", txtDiscountPercentage.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@DiscountAmount", txtDiscountAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TaxableAmount", txtTaxableAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTPercentage", txtCGSTPercentage.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTAmount", txtCGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTPercentage", txtSGSTPercentage.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTAmount", txtSGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTPercentage", txtIGSTPercentage.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTAmount", txtIGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@NetAmount", txtNetAmount.Text).DbType = DbType.Decimal;



            cmd.ExecuteNonQuery();


            MessageBox.Show("Sales Detail Updated Successfully");

            SQLQueryClass.con.Close();

            this.getSalesDetailsTableAdapter.Fill(this.dSGetSalesDetail.GetSalesDetails, SalesMasterID);
        }

        private void GetSalesMasterTotalAmount()
        {
            SqlCommand cmd = new SqlCommand("GetSalesMasterTotalAmount", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesMasterID", SalesMasterID);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtGrossAmount.Text = ds.Tables[0].Rows[0]["GrossAmount"].ToString();
                txtTotalDiscountAmount.Text = ds.Tables[0].Rows[0]["DiscountAmount"].ToString();
                txtTotalTaxableAmount.Text = ds.Tables[0].Rows[0]["TaxableAmount"].ToString();
                txtTotalCGSTAmount.Text = ds.Tables[0].Rows[0]["CGSTAmount"].ToString();
                txtTotalSGSTAmount.Text = ds.Tables[0].Rows[0]["SGSTAmount"].ToString();
                txtTotalIGSTAmount.Text = ds.Tables[0].Rows[0]["IGSTAmount"].ToString();
                txtTotalNetAmount.Text = ds.Tables[0].Rows[0]["TotalNetAmount"].ToString();
            }
            else
            {
                ResetSalesDetailDefaultValue();

            }


        }

        private void UpdateSalesMasterTable()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("UpdateSalesMasterTable", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SalesID", SalesMasterID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@TotalGrossAmount", txtGrossAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TotalDiscountAmount", txtTotalDiscountAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TotalTaxableAmount", txtTotalTaxableAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTAmount", txtTotalCGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTAmount", txtTotalSGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTAmount", txtTotalIGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TotalNetAmount", txtTotalNetAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@PaymentMode", comboBoxPaymentMode.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@Remark", txtRemark.Text).DbType = DbType.String;


            cmd.ExecuteNonQuery();


            MessageBox.Show("Sales Master Updated Successfully");

            SQLQueryClass.con.Close();
        }

        private void DeleteFromSalesDetailTable()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("DeleteFromSalesDetailTable", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesDetailID", SalesDetailID).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();


            MessageBox.Show("Sales Detail Entry Deleted Successfully");

            SQLQueryClass.con.Close();

            this.getSalesDetailsTableAdapter.Fill(this.dSGetSalesDetail.GetSalesDetails, SalesMasterID);

        }


        private void FillData()
        {
            SalesDetailID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            comboBoxProductName.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtRate.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtQty.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtHSNCode.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtTotal.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtDiscountPercentage.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtDiscountAmount.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtTaxableAmount.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtCGSTPercentage.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtCGSTAmount.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtSGSTPercentage.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtSGSTAmount.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txtIGSTPercentage.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            txtIGSTAmount.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            txtNetAmount.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();

        }

        private void AllCalculation()
        {
            txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtRate.Text) * Convert.ToDecimal(txtQty.Text));

            txtDiscountAmount.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) * Convert.ToDecimal(txtDiscountPercentage.Text) / 100);

            txtTaxableAmount.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtDiscountAmount.Text));

            if (Convert.ToDecimal(txtCGSTPercentage.Text) > 0 && Convert.ToDecimal(txtSGSTPercentage.Text) > 0)
            {
                txtIGSTPercentage.ReadOnly = true;
                txtIGSTAmount.ReadOnly = true;
                txtCGSTAmount.Text = Convert.ToString(Convert.ToDecimal(txtTaxableAmount.Text) * Convert.ToDecimal(txtCGSTPercentage.Text) / 100);
                txtSGSTAmount.Text = Convert.ToString(Convert.ToDecimal(txtTaxableAmount.Text) * Convert.ToDecimal(txtSGSTPercentage.Text) / 100);

                txtIGSTAmount.Text = "0";
                txtIGSTPercentage.Text = "0";



            }
            else if (Convert.ToDecimal(txtIGSTPercentage.Text) > 0)
            {
                txtCGSTPercentage.ReadOnly = true;
                txtCGSTAmount.ReadOnly = true;
                txtSGSTPercentage.ReadOnly = true;
                txtSGSTAmount.ReadOnly = true;

                txtIGSTAmount.Text = Convert.ToString(Convert.ToDecimal(txtTaxableAmount.Text) * Convert.ToDecimal(txtIGSTPercentage.Text) / 100);

                txtCGSTPercentage.Text = "0";
                txtCGSTAmount.Text = "0";
                txtSGSTPercentage.Text = "0";
                txtSGSTAmount.Text = "0";


            }

            txtNetAmount.Text = Convert.ToString(Convert.ToDecimal(txtTaxableAmount.Text) + Convert.ToDecimal(txtCGSTAmount.Text) + Convert.ToDecimal(txtSGSTAmount.Text) + Convert.ToDecimal(txtIGSTAmount.Text));

            if (Convert.ToDecimal(txtCGSTPercentage.Text) == 0 && Convert.ToDecimal(txtSGSTPercentage.Text) == 0)
            {
                txtIGSTPercentage.Enabled = true;
                txtIGSTAmount.Enabled = true;
            }
            else if (Convert.ToDecimal(txtIGSTPercentage.Text) == 0)
            {
                txtCGSTPercentage.Enabled = true;
                txtSGSTPercentage.Enabled = true;
            }
        }

        private void ResetSalesMasterTotalAmountDefaultValue()
        {
            txtGrossAmount.Text = "0";
            txtTotalDiscountAmount.Text = "0";
            txtTotalTaxableAmount.Text = "0";
            txtTotalCGSTAmount.Text = "0";
            txtTotalSGSTAmount.Text = "0";
            txtTotalIGSTAmount.Text = "0";
            txtNetAmount.Text = "0";
            txtNetAmount.Text = "0";
            txtMobileNo.Text = "";
            txtAddress.Clear();
            txtCustomerName.Clear();
        }


        private void ResetSalesDetailDefaultValue()
        {

            comboBoxProductName.SelectedIndex = 0;
            txtRate.Text = "0";
            txtQty.Text = "0";
            txtHSNCode.Text = "0";
            txtTotal.Text = "0";
            txtDiscountPercentage.Text = "0";
            txtDiscountAmount.Text = "0";
            txtTaxableAmount.Text = "0";
            txtCGSTPercentage.Text = "0";
            txtCGSTAmount.Text = "0";
            txtSGSTPercentage.Text = "0";
            txtSGSTAmount.Text = "0";
            txtIGSTPercentage.Text = "0";
            txtIGSTAmount.Text = "0";
            txtNetAmount.Text = "0";
            SalesDetailID = 0;

        }

        private void ResetForm()
        {
            SalesDetailID = 0;
            SalesMasterID = 0;
            ResetSalesDetailDefaultValue();
            ResetSalesMasterTotalAmountDefaultValue();
            ResetSalesDetail();
            ResetSalesMaster();
            
            dateTimePickerSalesDate.Value = DateTime.Now;

            txtInvoiceNo.Text = "0";
            EnablePanelContent();
        }

        private void ResetSalesMaster()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("ResetSalesMaster", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesMasterID", SalesMasterID).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();


            MessageBox.Show("Sales Master Reseted Successfully");

            SQLQueryClass.con.Close();
            this.getSalesDetailsTableAdapter.Fill(this.dSGetSalesDetail.GetSalesDetails, SalesMasterID);


        }

        private void ResetSalesDetail()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("ResetSalesDetail", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesMasterID", SalesMasterID).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();


            MessageBox.Show("Sales Details Reseted Successfully");

            SQLQueryClass.con.Close();
            this.getSalesDetailsTableAdapter.Fill(this.dSGetSalesDetail.GetSalesDetails, SalesMasterID);

        }

        private void SaveEvent()
        {
            UpdateSalesMasterTable();
            SalesDetailID = 0;
            SalesMasterID = 0;
            ResetSalesMasterTotalAmountDefaultValue();
            ResetSalesDetailDefaultValue();
            txtInvoiceNo.Text = "0";
            dateTimePickerSalesDate.Text = "";
            EnablePanelContent();
            this.getSalesDetailsTableAdapter.Fill(this.dSGetSalesDetail.GetSalesDetails, SalesMasterID);
        }



        private void FormClosingValidation()
        {

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("GetSalesDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesId", SalesMasterID);

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


            if (SalesMasterID > 0)
            {
                DialogResult dia = MessageBox.Show("Are you sure you want to exit.", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    ResetSalesMaster();
                    MessageBox.Show("SalesMasterID Deleted");
                }

            }
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtInvoiceNo.Text) > 0)
            {
                InsertIntoSalesMaster();

            }
            else { MessageBox.Show("Please Fill All The Details"); }

            if (SalesMasterID > 0)
            {
                EnablePanelContent();
                comboBoxProductName.Focus();
            }
        }

        private void FrmSaleMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSListProductMasterDetails.ListProductMasterDetails' table. You can move, or remove it, as needed.
            this.listProductMasterDetailsTableAdapter.Fill(this.dSListProductMasterDetails.ListProductMasterDetails);

            this.getSalesDetailsTableAdapter.Fill(this.dSGetSalesDetail.GetSalesDetails,SalesMasterID);

            EnablePanelContent();
        }

        private void txtTotalSGSTAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SalesDetailID != 0)
            {
                UpdateSalesDetails();
                ResetSalesDetailDefaultValue();

            }
            else if(Convert.ToInt32(comboBoxProductName.SelectedValue) > 0)
            {
                InsertIntoSalesDetailTable();
                ResetSalesDetailDefaultValue();
            }
            GetSalesMasterTotalAmount();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetSalesDetailDefaultValue();
        }

        private void txtRate_Leave(object sender, EventArgs e)
        {
            AllCalculation();

        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtTotal_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtDiscountPercentage_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtCGSTPercentage_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtSGSTPercentage_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtIGSTPercentage_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtNetAmount_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }


        private void LoadProductRate()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("GetRateOfTheProduct", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ProductID", comboBoxProductName.SelectedValue).DbType = DbType.Int32;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            SQLQueryClass.con.Close();

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtRate.Text = ds.Tables[0].Rows[0]["SALESRATE"].ToString();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteFromSalesDetailTable();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxProductName_Leave(object sender, EventArgs e)
        {
            LoadProductRate();
        }

        private void FrmSaleMaster_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
