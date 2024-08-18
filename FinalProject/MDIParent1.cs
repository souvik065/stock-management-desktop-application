using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProject.ReportForm;


namespace FinalProject
{
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;
        
        public MDIParent1()
        {
            InitializeComponent();
         
       

        }


        //MDI Parent UI Design
        public void CustomizeDesign()
        {
            MastersSubPanel.Visible = false;
            
        }


        public void HideSubMenu()
        {
            if (MastersSubPanel.Visible == true)
                MastersSubPanel.Visible = false;

            if (Reportpanel.Visible == true)
                Reportpanel.Visible = false;
        }

        public void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }

            
        }

        private Form activeForm = null;
        private void OpenChildForm(Form childFrom)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childFrom;
            childFrom.TopLevel = false;
            childFrom.FormBorderStyle = FormBorderStyle.None;
            childFrom.Dock = DockStyle.Fill;
            Bodypanel.Controls.Add(childFrom);
            Bodypanel.Tag = childFrom;
            childFrom.BringToFront();
            childFrom.Show();
        }

        //-------------------------------------------------------------------------------------------------------------------------------





        //Other Default Features in MDI
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

       //---------------------------------------------------------------------------------------------------------------

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmCategory());
            HideSubMenu();

            
        }

        private void btnSubCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSubCategory());
            HideSubMenu();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmProductMasterAndDetails());
            HideSubMenu();
        }

        

        private void btnMaster_Click(object sender, EventArgs e)
        {
            ShowSubMenu(MastersSubPanel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSupplierMaster());
            HideSubMenu();

        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            HideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPurchaseMaster_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PurchaseMaterialMaster());
            HideSubMenu();
        }

        private void btnPurchasereturn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmPurchaseReturn());
            HideSubMenu();
        }

        private void btnSalesMaster_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmSaleMaster());
            HideSubMenu();
        }

        private void btnSalesReturn_Click(object sender, EventArgs e)
        {
           OpenChildForm( new SalesReturnMaster());
            HideSubMenu();
        }

        private void btnCategoryRPT_Click(object sender, EventArgs e)
        {
            
          OpenChildForm(new FrmRPTCategoryList());
           HideSubMenu();
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        

        private void btnCategoryRPT_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRPTCategoryList());
            HideSubMenu();
        }

        private void btnSubCategoryRPT_Click(object sender, EventArgs e)
        {
           OpenChildForm(new FrmRPTSubCategoryList());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ShowSubMenu(Reportpanel);
        }

        private void btnSupplierRPT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRPTSupplier());
            HideSubMenu();

        }

        private void btnProductDetailsRPT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRPTProductDetails());
            HideSubMenu();
        }

        private void btnPurchaseRPT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRPTPurchaseDetails());
            HideSubMenu();
        }

        private void btnPurchaseReturnRPT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRPTPurchaseReturnDetails());
            HideSubMenu();

        
        }

        private void btnSalesRPT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRPTSalesDetails());
            HideSubMenu();
        }

        private void btnSaleReturnRPT_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRPTSalesReturnDetails());
            HideSubMenu();
        }

        private void btnSubCategoryByCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRPTSubCategoryByCategory());
            HideSubMenu();
        }

        private void btnProductReportByParameters_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRPTProductReportByParameters());
            HideSubMenu();
        }

        private void btnPurchaseRPTByParamater_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRPTPurchaseReportByParamters());
            HideSubMenu();
        }

        private void btnPurchaseReturnRPTByParameter_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRPTPurchaseReturnReportByParameter());
            HideSubMenu();
        }

        private void btnSalesRPTByParameter_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRPTSalesReportByParameter());
            HideSubMenu();
        }

        private void btnSaleReturnByParameter_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmRPTSalesReturnReportByParameter());
            HideSubMenu();
        }
    }
}
