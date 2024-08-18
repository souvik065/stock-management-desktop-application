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
    public partial class FrmSubCategory : Form
    {
        public FrmSubCategory()
        {
            InitializeComponent();
        }

        private void Insert()
        {
            SQLQueryClass.con.Open();

            SqlCommand cmd = new SqlCommand("InsertSubCategoryDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CATEGORYID", comboBoxCategoryName.SelectedValue).DbType = DbType.Int32;
            cmd.Parameters.AddWithValue("@SUBCATEGORYNAME", txtSubCategory.Text).DbType = DbType.String;
            cmd.ExecuteNonQuery();

            SQLQueryClass.con.Close();

            this.getSubCategoryDetailsTableAdapter.Fill(this.subCategoryDetails.GetSubCategoryDetails);
        }

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

            this.getSubCategoryDetailsTableAdapter.Fill(this.subCategoryDetails.GetSubCategoryDetails);

        }

        private void Delete()
        {
            SQLQueryClass.con.Open();

            SqlCommand cmd = new SqlCommand("DeleteSubCategoryDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@SUBCATEGORYID", txtSubCategory.Tag).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();

            SQLQueryClass.con.Close();

            this.getSubCategoryDetailsTableAdapter.Fill(this.subCategoryDetails.GetSubCategoryDetails);
         
        }

        private void FillData()
        {
            txtSubCategory.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxCategoryName.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSubCategory.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmSubCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'listCategoryDetails._ListCategoryDetails' table. You can move, or remove it, as needed.
            this.listCategoryDetailsTableAdapter.Fill(this.listCategoryDetails._ListCategoryDetails);
            // TODO: This line of code loads data into the 'listCategoryDetails._ListCategoryDetails' table. You can move, or remove it, as needed.
            this.listCategoryDetailsTableAdapter.Fill(this.listCategoryDetails._ListCategoryDetails);
            // TODO: This line of code loads data into the 'subCategoryDetails.GetSubCategoryDetails' table. You can move, or remove it, as needed.
            this.getSubCategoryDetailsTableAdapter.Fill(this.subCategoryDetails.GetSubCategoryDetails);

        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            Insert();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FillData();
        }
    }
}
