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
    public partial class FrmPurchaseReturn : Form
    {
        int PurchaseReturnMasterID = 0;
        int PurchaseReturnDetailsID = 0;
        Boolean isExpire = false;
       
        public FrmPurchaseReturn()
        {
            InitializeComponent();
            

        }

     

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (comboBoxSupplierName.SelectedIndex > 0 && txtInvoiceNo.Text != null)
            {
                InsertIntoPurchaseReturnMaster();

            }
            if (PurchaseReturnMasterID > 0)
            {
                EnablePanelContent();
                comboBoxProductName.Focus();
            }
        }

        private void EnablePanelContent()
        {
            panelPurchaseDetail.Enabled = false;
            panelTotalAmounts.Enabled = false;
            if (comboBoxSupplierName.SelectedIndex > 0 && Convert.ToDecimal(txtInvoiceNo.Text) > 0)
            {
                panelPurchaseDetail.Enabled = true;
                panelTotalAmounts.Enabled = true;
                PurchaseMasterpanel.Enabled = false;
            }
            else if (comboBoxSupplierName.SelectedIndex == 0 && Convert.ToDecimal(txtInvoiceNo.Text) == 0)
            {
                panelPurchaseDetail.Enabled = false;
                panelTotalAmounts.Enabled = false;
                PurchaseMasterpanel.Enabled = true;
            }


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


            if (checkBoxYes.Checked == true)
            {
                dateTimePickerExpireDate.Enabled = true;
            }
            else if (checkBoxNo.Checked == true)
            {
                dateTimePickerExpireDate.Enabled = false;
            }


            if (checkBoxYes.Checked)
            {
                isExpire = true;
            }
            else if (checkBoxNo.Checked)
            {
                isExpire = false;
            }

        }

        private void ResetPurchasedetailReturnDefaultValue()
        {

            comboBoxProductName.SelectedIndex = 0;
            checkBoxYes.Checked = false;
            checkBoxNo.Checked = false;
            dateTimePickerExpireDate.Text = "";
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
            PurchaseReturnDetailsID = 0;

        }

        private void ResetTotalAmountDefaultValue()
        {
            txtGrossAmount.Text = "0";
            txtTotalDiscountAmount.Text = "0";
            txtTotalTaxableAmount.Text = "0";
            txtTotalCGSTAmount.Text = "0";
            txtTotalSGSTAmount.Text = "0";
            txtTotalIGSTAmount.Text = "0";
            txtNetAmount.Text = "0";
            txtTradeDiscAmt.Text = "0";
            txtCashDiscAmt.Text = "0";
            txtFreighCharges.Text = "0";
            txtLabourCharges.Text = "0";
            txtNetAmount.Text = "0";
            comboBoxPaymentMode.SelectedIndex = 0;
            txtRemark.Clear();
        }




        private void InsertIntoPurchaseReturnMaster()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("InsterIntoPurchaseReturnMaster", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PurchaseDate", dateTimePickerPurchaseDate.Text).DbType = DbType.Date;
            cmd.Parameters.AddWithValue("@SupplierID", comboBoxSupplierName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@InvoiceNo", txtInvoiceNo.Text).DbType = DbType.Int32;

            // cmd.ExecuteNonQuery();
            PurchaseReturnMasterID = Convert.ToInt32(cmd.ExecuteScalar());

            MessageBox.Show("Inserted into Purchase Return Master Successfully");

            SQLQueryClass.con.Close();


        }


        private void InsertIntoPurchaseReturnDetailTable()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("InsertIntoPurchaseReturnDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PurchaseReturnID", PurchaseReturnMasterID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@ProductID", comboBoxProductName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@IsExpire", isExpire).DbType = DbType.Boolean;
            cmd.Parameters.AddWithValue("@ExpireDate", dateTimePickerExpireDate.Text).DbType = DbType.Date;
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


            MessageBox.Show("Inserted Purchase Return Detail Successfully");

            SQLQueryClass.con.Close();

            this.getPurchaseReturnDetailsTableAdapter.Fill(this.dSGetPurchaseReturnDetail.GetPurchaseReturnDetails, PurchaseReturnMasterID);


        }


        private void UpdatePurchaseReturnDetails()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("UpdatePurchaseReturnDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PurchaseReturnDetailID", PurchaseReturnDetailsID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@PurchaseReturnID", PurchaseReturnMasterID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@ProductID", comboBoxProductName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@IsExpire", isExpire).DbType = DbType.Boolean;
            cmd.Parameters.AddWithValue("@ExpireDate", dateTimePickerExpireDate.Text).DbType = DbType.Date;
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


            MessageBox.Show("Purchase Detail Updated Successfully");

            SQLQueryClass.con.Close();

            this.getPurchaseReturnDetailsTableAdapter.Fill(this.dSGetPurchaseReturnDetail.GetPurchaseReturnDetails, PurchaseReturnMasterID);



        }


        private void UpdatePurchaseReturnMasterTable()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("UpdatePurchaseReturnMasterTable", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PurchaseReturnID", PurchaseReturnMasterID).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@TotalGrossAmount", txtGrossAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TotalDiscountAmount", txtTotalDiscountAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CGSTAmount", txtTotalCGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@SGSTAmount", txtTotalCGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@IGSTAmount", txtTotalIGSTAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TotalNetAmount", txtTotalNetAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@TradeDiscountAmount", txtTradeDiscAmt.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@CashDiscountAmount", txtCashDiscAmt.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@FreighCharges", txtFreighCharges.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@LabourCharges", txtLabourCharges.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@NetAmount", txtTotalNetAmount.Text).DbType = DbType.Decimal;
            cmd.Parameters.AddWithValue("@PaymentMode", comboBoxPaymentMode.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@Remark", txtRemark.Text).DbType = DbType.String;




            cmd.ExecuteNonQuery();


            MessageBox.Show("Total Amounts Updated to Purchase Master Successfully");

            SQLQueryClass.con.Close();

        }

        private void DeleteFromPurchaseReturnDetailTable()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("DeleteFromPurchaseReturnDetailTable", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PurchaseReturnDetailID", PurchaseReturnDetailsID).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();


            MessageBox.Show("PurchaseReturn Detail Entry Deleted Successfully");

            SQLQueryClass.con.Close();
            this.getPurchaseReturnDetailsTableAdapter.Fill(this.dSGetPurchaseReturnDetail.GetPurchaseReturnDetails, PurchaseReturnMasterID);

        }


        private void GetTotalAmount()
        {
            SqlCommand cmd = new SqlCommand("GetPurchaseReturnTotalAmount", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PurchaseReturnMasterID", PurchaseReturnMasterID);
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
                ResetPurchasedetailReturnDefaultValue();

            }


        }

        private void ResetPurchaseReturnMaster()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("ResetPurchaseReturnMaster", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PurchaseReturnMasterID", PurchaseReturnMasterID).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();


            MessageBox.Show("PurchaseReturn Master Reseted Successfully");

            SQLQueryClass.con.Close();
           

        }

        private void ResetPurchaseReturnDetails()
        {
            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("ResetPurchaseReturnDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PurchaseReturnMasterID", PurchaseReturnMasterID).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();


            MessageBox.Show("PurchaseReturn Details Reseted Successfully");

            SQLQueryClass.con.Close();
        }

        private void ResetForm()
        {
            PurchaseReturnDetailsID = 0;
            PurchaseReturnMasterID = 0;
            
            ResetTotalAmountDefaultValue();
            ResetPurchaseReturnDetails();
            ResetPurchaseReturnMaster();
            ResetPurchasedetailReturnDefaultValue();
            ResetTotalAmountDefaultValue();

            dateTimePickerPurchaseDate.Value = DateTime.Now;
            comboBoxSupplierName.SelectedValue = 0;
            txtInvoiceNo.Text = "0";
            EnablePanelContent();

            this.getPurchaseReturnDetailsTableAdapter.Fill(this.dSGetPurchaseReturnDetail.GetPurchaseReturnDetails,PurchaseReturnMasterID);
        }

        private void OtherCharges()
        {
            txtFinalNetAmount.Text = Convert.ToString((Convert.ToDecimal(txtTotalNetAmount.Text) - Convert.ToDecimal(txtTradeDiscAmt.Text) - Convert.ToDecimal(txtCashDiscAmt.Text))
                                + Convert.ToDecimal(txtFreighCharges.Text) + Convert.ToDecimal(txtLabourCharges.Text));
        }

        private void FillData()
        {
            PurchaseReturnDetailsID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            comboBoxProductName.SelectedValue = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            isExpire = Convert.ToBoolean(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            if (isExpire == true)
            {
                checkBoxYes.Checked = true;
                checkBoxNo.Checked = false;
            }
            else if (isExpire == false)
            {
                checkBoxNo.Checked = true;
                checkBoxYes.Checked = false;
            }


            dateTimePickerExpireDate.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtRate.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtQty.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtHSNCode.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtTotal.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txtDiscountPercentage.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txtDiscountAmount.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            txtTaxableAmount.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            txtCGSTPercentage.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            txtCGSTAmount.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            txtSGSTPercentage.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            txtSGSTAmount.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            txtIGSTPercentage.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            txtIGSTAmount.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            txtNetAmount.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();

        }

        private void ResetPurchaseReturnDetailDefaultValue()
        {

            comboBoxProductName.SelectedIndex = 0;
            checkBoxYes.Checked = false;
            checkBoxNo.Checked = false;
            dateTimePickerExpireDate.Text = "";
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
            PurchaseReturnDetailsID = 0;

        }


        private void SaveEvent()
        {
            UpdatePurchaseReturnMasterTable();
            PurchaseReturnDetailsID = 0;
            PurchaseReturnMasterID = 0;
            ResetTotalAmountDefaultValue();
            this.getPurchaseReturnDetailsTableAdapter.Fill(this.dSGetPurchaseReturnDetail.GetPurchaseReturnDetails, PurchaseReturnMasterID);
            comboBoxSupplierName.SelectedIndex = 0;
            txtInvoiceNo.Text = "0";
            dateTimePickerPurchaseDate.Text = "";
            EnablePanelContent();
        }

        private void FormClosingValidation()
        {

            SqlDataAdapter da;
            DataSet ds = new DataSet();

            SQLQueryClass.con.Open();
            SqlCommand cmd = new SqlCommand("GetPurchaseReturnDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PurchaseReturnId", PurchaseReturnMasterID);

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


            if (PurchaseReturnMasterID > 0)
            {
                DialogResult dia = MessageBox.Show("Are you sure you want to exit.", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    ResetPurchaseReturnMaster();
                    MessageBox.Show("PurchaseReturnMasterID Deleted");
                }

            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillData();
        }

        private void FrmPurchaseReturn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSListProductMasterDetails.ListProductMasterDetails' table. You can move, or remove it, as needed.
            this.listProductMasterDetailsTableAdapter.Fill(this.dSListProductMasterDetails.ListProductMasterDetails);
            // TODO: This line of code loads data into the 'dSListSupplierMasterDetails.ListSupplierDetails' table. You can move, or remove it, as needed.
            this.listSupplierDetailsTableAdapter.Fill(this.dSListSupplierMasterDetails.ListSupplierDetails);

            this.getPurchaseReturnDetailsTableAdapter.Fill(this.dSGetPurchaseReturnDetail.GetPurchaseReturnDetails,PurchaseReturnMasterID);

            ResetTotalAmountDefaultValue();

            EnablePanelContent();
        }

        private void checkBoxYes_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxNo.Checked = false;
            AllCalculation();
        }

        private void checkBoxNo_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxYes.Checked = false;
            AllCalculation();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (PurchaseReturnDetailsID != 0)
            {
                UpdatePurchaseReturnDetails();
                ResetPurchasedetailReturnDefaultValue();

            }
            else if(Convert.ToInt32(comboBoxProductName.SelectedValue) > 0)
            {
                InsertIntoPurchaseReturnDetailTable();
                ResetPurchasedetailReturnDefaultValue();
            }
            GetTotalAmount();
        }

        private void txtCGSTPercentage_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtRate_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtQty_Leave(object sender, EventArgs e)
        {
            AllCalculation();
        }

        private void txtDiscountPercentage_Leave(object sender, EventArgs e)
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
            ResetPurchasedetailReturnDefaultValue();

        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveEvent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (PurchaseReturnDetailsID > 0)
            {
                DeleteFromPurchaseReturnDetailTable();
                ResetPurchaseReturnDetailDefaultValue();

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void txtFreighCharges_Leave(object sender, EventArgs e)
        {
            OtherCharges();
        }

        private void txtLabourCharges_Leave(object sender, EventArgs e)
        {
            OtherCharges();
        }

        private void txtFinalNetAmount_Leave(object sender, EventArgs e)
        {
            OtherCharges();
        }

        private void txtTradeDiscAmt_Leave(object sender, EventArgs e)
        {
            OtherCharges();
        }

        private void txtCashDiscAmt_Leave(object sender, EventArgs e)
        {
            OtherCharges();
        }

        private void FrmPurchaseReturn_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingValidation();
           
              
            
        }
    }
}
