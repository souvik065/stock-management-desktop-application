using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FinalProject
{
    public partial class SalesReturnMaster : Form
    {
        int SalesReturnMasterID = 0;
        int SalesReturnDetailID = 0;
        public SalesReturnMaster()
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

        private void InsertIntoSalesReturnMaster()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("InsertIntoSalesReturnMaster", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesReturnDate", dateTimePickerSalesDate.Text).DbType = DbType.Date;
            cmd.Parameters.AddWithValue("@InvoiceNo", txtInvoiceNo.Text).DbType = DbType.Int32;

            // cmd.ExecuteNonQuery();
            SalesReturnMasterID = Convert.ToInt32(cmd.ExecuteScalar());

            MessageBox.Show("Inserted into Sales Return Master Successfully");

            SQLQueryClass.con.Close();




        }


        private void InsertIntoSalesDetailTable()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("InsertIntoSalesReturnDetail", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesReturnID", SalesReturnMasterID).DbType = DbType.Int32;
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


            MessageBox.Show("Inserted Sales Return Detail Successfully");

            SQLQueryClass.con.Close();

            this.getSalesReturnDetailsTableAdapter.Fill(this.dSGetSalesReturndetails.GetSalesReturnDetails, SalesReturnMasterID);

        }

        private void UpdateSalesDetails()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("UpdateSalesReturnDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesReturnDetailID", SalesReturnDetailID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@SalesReturnID", SalesReturnMasterID).DbType = DbType.Int32;
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


            MessageBox.Show("SalesReturn Detail Updated Successfully");

            SQLQueryClass.con.Close();
            SalesReturnDetailID = 0;

            this.getSalesReturnDetailsTableAdapter.Fill(this.dSGetSalesReturndetails.GetSalesReturnDetails, SalesReturnMasterID);


        }

        private void GetSalesReturnMasterTotalAmount()
        {
            SqlCommand cmd = new SqlCommand("GetSalesReturnMasterTotalAmount", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesReturnMasterID", SalesReturnMasterID);
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
                ResetSalesReturnDetailDefaultValue();



            }


        }

        private void UpdateSalesReturnMasterTable()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("UpdateSalesReturnMasterTable", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SalesReturnID", SalesReturnMasterID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@TotalGrossAmount", txtGrossAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TotalDiscountAmount", txtTotalDiscountAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TotalTaxableAmount", txtTotalTaxableAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTAmount", txtTotalCGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTAmount", txtSGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTAmount", txtIGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TotalNetAmount", txtTotalNetAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@MobileNo", txtMobileNo.Text).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@CustomerName", txtCustomerName.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@Address", txtAddress.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@PaymentMode", comboBoxPaymentMode.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@Remark", txtRemark.Text).DbType = DbType.String;


            cmd.ExecuteNonQuery();


            MessageBox.Show("SalesReturn Master Updated Successfully");

            SQLQueryClass.con.Close();
            this.getSalesReturnDetailsTableAdapter.Fill(this.dSGetSalesReturndetails.GetSalesReturnDetails, SalesReturnMasterID);

        }

        private void DeleteFromSalesReturnDetailTable()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("DeleteFromSalesReturnDetailTable", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesReturnDetailID", SalesReturnDetailID).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();


            MessageBox.Show("SalesReturn Detail Entry Deleted Successfully");

            SQLQueryClass.con.Close();

            this.getSalesReturnDetailsTableAdapter.Fill(this.dSGetSalesReturndetails.GetSalesReturnDetails, SalesReturnMasterID);


        }


        private void FillData()
        {
            SalesReturnDetailID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

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

        private void ResetSalesReturnMasterTotalAmountDefaultValue()
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
            txtRemark.Clear();
            comboBoxPaymentMode.SelectedIndex = 0;

        }


        private void ResetSalesReturnDetailDefaultValue()
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
            SalesReturnDetailID = 0;

        }

        private void ResetForm()
        {
            SalesReturnDetailID = 0;
            SalesReturnMasterID = 0;
            ResetSalesReturnDetailDefaultValue();
            ResetSalesReturnMasterTotalAmountDefaultValue();
            ResetSalesReturnDetail();
            ResetSalesMaster();

            dateTimePickerSalesDate.Value = DateTime.Now;

            txtInvoiceNo.Text = "0";
            EnablePanelContent();

            this.getSalesReturnDetailsTableAdapter.Fill(this.dSGetSalesReturndetails.GetSalesReturnDetails, SalesReturnMasterID);
        }

        private void ResetSalesMaster()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("ResetSalesReturnMaster", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesMasterID", SalesReturnMasterID).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();


            MessageBox.Show("SalesReturn Master Reseted Successfully");

            SQLQueryClass.con.Close();
          


        }

        private void ResetSalesReturnDetail()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("ResetSalesReturnDetail", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesReturnMasterID", SalesReturnMasterID).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();


            MessageBox.Show("SalesReturn Details Reseted Successfully");

            SQLQueryClass.con.Close();     

        }

        private void FormClosingValidation()
        {

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("GetSalesReturnDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SalesReturnId", SalesReturnMasterID);

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


            if (SalesReturnMasterID > 0)
            {
                DialogResult dia = MessageBox.Show("Are you sure you want to exit.", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    ResetSalesMaster();
                    MessageBox.Show("SalesReturnMasterID Deleted");
                }

            }
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


        private void SaveEvent()
        {
            UpdateSalesReturnMasterTable();
            SalesReturnDetailID = 0;
            SalesReturnMasterID = 0;
            ResetSalesReturnMasterTotalAmountDefaultValue();
            ResetSalesReturnDetailDefaultValue();
            txtInvoiceNo.Text = "0";
            dateTimePickerSalesDate.Text = "";
            EnablePanelContent();
            this.getSalesReturnDetailsTableAdapter.Fill(this.dSGetSalesReturndetails.GetSalesReturnDetails, SalesReturnMasterID);
        }



        private void SalesReturnMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSListProductMasterDetails.ListProductMasterDetails' table. You can move, or remove it, as needed.
            this.listProductMasterDetailsTableAdapter.Fill(this.dSListProductMasterDetails.ListProductMasterDetails);

            this.getSalesReturnDetailsTableAdapter.Fill(this.dSGetSalesReturndetails.GetSalesReturnDetails,SalesReturnMasterID);

            EnablePanelContent();
            comboBoxPaymentMode.SelectedIndex = 0;  

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txtInvoiceNo.Text) > 0)
            {
                InsertIntoSalesReturnMaster();

            }
            else { MessageBox.Show("Please Fill All The Details"); }

            if (SalesReturnMasterID > 0)
            {
                EnablePanelContent();
                comboBoxProductName.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SalesReturnDetailID != 0)
            {
                UpdateSalesDetails();
                ResetSalesReturnDetailDefaultValue();

            }
            else if(Convert.ToInt32(comboBoxProductName.SelectedValue) > 0)
            {
                InsertIntoSalesDetailTable();
                ResetSalesReturnDetailDefaultValue();
            }
            GetSalesReturnMasterTotalAmount();
        }

        private void txtQty_Leave(object sender, EventArgs e)
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetSalesReturnDetailDefaultValue();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteFromSalesReturnDetailTable();
            ResetSalesReturnDetailDefaultValue();
            ResetSalesReturnMasterTotalAmountDefaultValue();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void comboBoxProductName_Leave(object sender, EventArgs e)
        {
            LoadProductRate();
            AllCalculation();
        }

        private void txtRate_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void SalesReturnMaster_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingValidation();
        }
    }
}
