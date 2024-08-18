using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace FinalProject
{
    public partial class FrmLogin : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int RigthRect,
            int nBottomRect

        );

        public FrmLogin()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void CheckLogin()
        {
            SqlCommand cmd = new SqlCommand("MacthingUserDetails", SQLQueryClass.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@USERNAME", txtUsername.Text).DbType = DbType.String;
            cmd.Parameters.AddWithValue("@PASSWORD", txtPassword.Text).DbType = DbType.String;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                MDIParent1 MDI1 = new MDIParent1();
                MDI1.ShowDialog();
                this.WindowState = FormWindowState.Minimized;
                this.Close();
            }
            else
            {
                MessageBox.Show("Username and Password is invalid");
            }
        }


        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'listFInancialYear.ListFinancialYear' table. You can move, or remove it, as needed.
            this.listFinancialYearTableAdapter.Fill(this.listFInancialYear.ListFinancialYear);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void comboBoxFinancialYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckLogin();  
        }
    }
}
