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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }



        private void Insert()
        {
            SQLQueryClass.con.Open();

            SqlCommand cmd = new SqlCommand("InsertCategoryDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CATEGORYNAME", txtCategory.Text).DbType = DbType.String;
            cmd.ExecuteNonQuery();

            SQLQueryClass.con.Close();

            this.getCategoryDetailsTableAdapter.Fill(this.categoryDetails.GetCategoryDetails);
        }

        

        private void Update()
        {
            SQLQueryClass.con.Open();

            SqlCommand cmd = new SqlCommand("UpdateCategoryDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CATEGORYNAME", txtCategory.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@CATEGORYID", txtCategory.Tag).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();

            SQLQueryClass.con.Close();

            this.getCategoryDetailsTableAdapter.Fill(this.categoryDetails.GetCategoryDetails);
           

        }

        private void Delete()
        {
            SQLQueryClass.con.Open();

            SqlCommand cmd = new SqlCommand("DeleteCategoryDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@CATEGORYID", txtCategory.Tag).DbType = DbType.Int32;

            cmd.ExecuteNonQuery();

            SQLQueryClass.con.Close();

            this.getCategoryDetailsTableAdapter.Fill(this.categoryDetails.GetCategoryDetails);

        }

        private void FillData()
        {
            txtCategory.Tag = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtCategory.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void FrmCategory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'categoryDetails.GetCategoryDetails' table. You can move, or remove it, as needed.
            this.getCategoryDetailsTableAdapter.Fill(this.categoryDetails.GetCategoryDetails);


            //datagriedview design
            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
         
        }

       

        private void button1_Click_1(object sender, EventArgs e)
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

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            FillData();
        }
    }
}
