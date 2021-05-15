using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
 
namespace AuntRosieApp
{
    public partial class frmHome : Form
    {

         public static AuntRosieApplication.Event.frmOrganizeEvent   formStep1;
        public static AuntRosieApplication.Event.frmOrganizeEventStep2 formStep2;
        public static AuntRosieApplication.Event.frmOrganizeEventStep3 formStep3;
        public static AuntRosieApplication.Event.frmOrganizeEventStep4 formStep4;
        public frmHome()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.DoubleBuffered = true;
        }
        protected override void OnPaint(PaintEventArgs e) { }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        private void frmHome_Load(object sender, EventArgs e)
        {



            if (AuntRosieApplication.Classes.DBMethod.UserType != "Admin")
            {
                pnlExpensses.Enabled = false;
                tmnExpenses.Enabled = false;
                btnQueryAndreport.Enabled = false;
                tmnQueriesAndReports.Enabled = false;
                mnuPayroll.Enabled = false;
                btnOrgEvent.Enabled = false;
                tmnOrginizeEvent.Enabled = false;
                btnPayroll.Enabled = false;
                btnInventoryIn.Enabled = false;
                tmnInventoryIn.Enabled = false;
             }
            ShowMainMenu();
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.sweet;
            this.DoubleBuffered = false;
            relocation(pnlMain);
            relocation(pnlInventory);
            relocation(pnlKitchen);
            relocation(pnlEvent);
            relocation(pnlReportQuery);
            relocation(pnlEmp);
            relocation(pnlPayroll);
            relocation(pnlExpensses);




            pnlExit.Left=  this.Width- pnlExit.Width ;
            pnlExit.Top = 0 ;
            
            this.Visible = true;

        }
        #region Helpers-Functions

        private void ShowMainMenu()
        {
            HidePanels();
            pnlMain.Visible = true;
            btnInventory.Focus();
        }
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// <param name="Pnl"></param>
        private void relocation( Panel pnl)
        {
            //relocation the login pannel 
           pnl.Left = (this.Width - pnl.Width) / 2;
           pnl.Top = (this.Height - pnl.Height) / 2;
        }
        /// <summary>
        /// 
        /// </summary>
        private void HidePanels()
        {
            pnlInventory.Visible = false;
            pnlMain.Visible = false;
            pnlKitchen.Visible = false;
            pnlEvent.Visible = false;
            pnlEmp.Visible = false;
            pnlReportQuery.Visible = false;
            pnlPayroll.Visible = false;
            pnlExpensses.Visible = false;
           
        }
        private void BackToMain(Panel pnl)
        {
            pnl.Visible = false;
            pnlMain.Visible = true;
            btnInventory.Focus();
        }
        private void ShowPnlel(Panel pnl)
        {

             pnl.Visible = true;
            pnlMain.Visible = false;
        }
        ///
        private void btnInventory_Click(object sender, EventArgs e)
        {
            ShowPnlel(pnlInventory);
        }

        private  void ShowForm( Form  form)
        {
            HidePanels();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Left = (this.Width - form.Width) / 2;
            form.Top = (this.Height - form.Height) / 2;
            form.Show();
            form.Activate();
            form.Focus();            
            mnuMain.Visible = false;
            
            btnShowMain.Enabled = true;
        }
        private void ShowEventForm(Form form)
        {
            HidePanels();
            form.TopLevel = false;
            this.Controls.Add(form);
            form.Left = (this.Width - form.Width) / 2;
            form.Top = (this.Height - form.Height) / 2;
            form.Hide();
            
            
        }

        #endregion


        private void btnInventoryMain_Click(object sender, EventArgs e)
        {
            BackToMain(pnlInventory);
        }

        private void btnKitchenMain_Click(object sender, EventArgs e)
        {
            BackToMain(pnlKitchen);
        }

        private void btnEventMAin_Click(object sender, EventArgs e)
        {
            BackToMain(pnlEvent);
        }


        private void btnEmployment_Click(object sender, EventArgs e)
        {
            ShowPnlel(pnlEmp);
        }

        private void btnEvent_Click(object sender, EventArgs e)
        {
            ShowPnlel(pnlEvent);
        }

        private void btnExpenses_Click(object sender, EventArgs e)
        {
            ShowPnlel(pnlExpensses);
        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            ShowPnlel(pnlKitchen);
        }

        private void btnQueryAndreport_Click(object sender, EventArgs e)
        {
            ShowForm(new AuntRosieApplication.Reports.frmReports());
        }

        private void btnReportMain_Click(object sender, EventArgs e)
        {
            BackToMain(pnlReportQuery);
        }

        private void btnEmpMAin_Click(object sender, EventArgs e)
        {
            BackToMain(pnlEmp);
        }
 

        private void btnKitchenProduct_Click(object sender, EventArgs e)
        {
            AuntRosieApp.Kitchen.frmManageProduct form = new AuntRosieApp.Kitchen.frmManageProduct();
            ShowForm(form);
            

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowMain_Click(object sender, EventArgs e)
        {
           
            if(this.Controls.Count==10)
            {
                ShowMainMenu();
                mnuMain.Visible = true;
                btnShowMain.Enabled = false;
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.Controls.Count.ToString());
        }

        private void frmHome_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void inventoryToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            
            HidePanels();
            pnlInventory.Show();

        }

        private void employmentToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            HidePanels();
            pnlEmp.Show();
        }

        private void eventToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            HidePanels();
            pnlEvent.Show();
        }

        private void kitchenToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            HidePanels();
            pnlKitchen.Show();
        }

        private void queriesAndReportsToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            HidePanels();
            pnlReportQuery.Show();
        }
 

        private void tmnInventoryIn_MouseLeave(object sender, EventArgs e)
        {
            btnInventoryMain.Focus();
        }

        private void tmnManageEmployee_MouseEnter(object sender, EventArgs e)
        {
            btnManagEmp.Focus();
        }

        private void tmnManageEmployee_MouseLeave(object sender, EventArgs e)
        {
            btnEmpMAin.Focus();
        }

        private void mnuPayroll_MouseEnter(object sender, EventArgs e)
        {
            btnPayroll.Focus();
        }

        private void tmnInventoryIn_MouseEnter(object sender, EventArgs e)
        {
            btnInventoryIn.Focus();
        }

        private void tmnManageProduct_MouseEnter(object sender, EventArgs e)
        {
            btnSuppliers.Focus();
        }

        private void tmnOrginizeEvent_MouseEnter(object sender, EventArgs e)
        {
            btnOrgEvent.Focus();
        }

        private void tmnOrginizeEvent_MouseLeave(object sender, EventArgs e)
        {
            btnEventMAin.Focus();
        }

        private void tmnSales_MouseEnter(object sender, EventArgs e)
        {
            btnSale.Focus();
        }

        private void tmnProducation_MouseEnter(object sender, EventArgs e)
        {
            btnProduction.Focus();
        }

        private void tmnProducation_MouseLeave(object sender, EventArgs e)
        {
            btnKitchenMain.Focus();
        }

        private void tmnManage_MouseEnter(object sender, EventArgs e)
        {
            btnKitchenProduct.Focus();
        }

        private void tmnQueries_MouseEnter(object sender, EventArgs e)
        {
            btnQuery.Focus();
        }

        private void tmnQueries_MouseLeave(object sender, EventArgs e)
        {
            btnReportMain.Focus();
        }

        private void tmnReports_MouseEnter(object sender, EventArgs e)
        {
            btnReport.Focus();
        }

        private void pnlKitchen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            //AuntRosieApplication.Kitchen.frmProduction form = new AuntRosieApplication.Kitchen.frmProduction();
            AuntRosieApplication.Kitchen.frmProduction form = new AuntRosieApplication.Kitchen.frmProduction();
            ShowForm(form);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            AuntRosieApplication.Inventory.frmSupplier form = new AuntRosieApplication.Inventory.frmSupplier();
            ShowForm(form);
        }

        private void tmnManageProduct_Click(object sender, EventArgs e)
        {
            AuntRosieApplication.Inventory.frmSupplier form = new AuntRosieApplication.Inventory.frmSupplier();
            ShowForm(form);
        }

        private void btnInventoryIn_Click(object sender, EventArgs e)
        {
            AuntRosieApplication.Inventory.InventoryInForm form = new AuntRosieApplication.Inventory.InventoryInForm();
            ShowForm(form);
        }

        private void btnPayroll_Click(object sender, EventArgs e)
        {
            HidePanels();
            pnlPayroll.Visible = true;
        }

        private void btnManagEmp_Click(object sender, EventArgs e)
        {
            AuntRosieApplication.Employment.frmManageEmp form  = new AuntRosieApplication.Employment.frmManageEmp();
            ShowForm(form);
        }

        private void tmnEvent_Click(object sender, EventArgs e)
        {

        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            AuntRosieApplication.Event.frmSale form = new AuntRosieApplication.Event.frmSale();
            ShowForm(form);
        }

        private void btnOrgEvent_Click(object sender, EventArgs e)
        {
             formStep1= new AuntRosieApplication.Event.frmOrganizeEvent();
           formStep2= new AuntRosieApplication.Event.frmOrganizeEventStep2();
         formStep3= new AuntRosieApplication.Event.frmOrganizeEventStep3();
         formStep4= new AuntRosieApplication.Event.frmOrganizeEventStep4() ;
            ShowEventForm(formStep4);
            ShowEventForm(formStep3);
            ShowEventForm(formStep2);
            ShowEventForm(formStep1);

            formStep1.Show();
            formStep1.Activate();
            formStep1.Focus();
        }

        private void btnManageIngerdint_Click(object sender, EventArgs e)
        {
         
            ShowForm(new AuntRosieApplication.Inventory.frmIngredients());
        }

        private void ingredintsToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            btnManageIngerdint.Focus();
        }

        private void btnInventoryContents_Click(object sender, EventArgs e)
        {
           
            ShowForm(new AuntRosieApplication.Inventory.frmInventoryStock());

        }

        private void tmnInventoryStock_MouseEnter(object sender, EventArgs e)
        {
            btnInventoryContents.Focus();
        }

        private void btnViewProduction_Click(object sender, EventArgs e)
        {
            AuntRosieApplication.Kitchen.frmViewProduction form = new AuntRosieApplication.Kitchen.frmViewProduction();
            ShowForm(form);
        }

        private void viewProductionsToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            btnViewProduction.Focus();
        }

        private void viewProductionsToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            btnKitchenMain.Focus();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            ShowForm(new AuntRosieApplication.Reports.frmReports());
        }

        private void tmnQueriesAndReports_Click(object sender, EventArgs e)
        {
            ShowForm(new AuntRosieApplication.Reports.frmReports());
        }

        private void tmnOrginizeEvent_Click(object sender, EventArgs e)
        {

        }

        private void btnPayRolMain_Click(object sender, EventArgs e)
        {
            BackToMain(pnlPayroll);

        }

        private void pnlInventory_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnParttimer_Click(object sender, EventArgs e)
        {
            ShowForm(new AuntRosieApplication.Employment.frmPayroll());
        }

        private void btnFulltimer_Click(object sender, EventArgs e)
        {
            ShowForm(new AuntRosieApplication.Employment.PayRollFull());
        }

        private void btnQeury_Click(object sender, EventArgs e)
        {
            ShowForm(new AuntRosieApplication.Employment.PayrollQueryForm());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BackToMain(pnlExpensses);
        }

        private void btnMiscellaneousExpenses_Click(object sender, EventArgs e)
        {
            ShowForm(new AuntRosieApplication.Expenses.frmExpensesManage());
        }

        private void btnCostQyuery_Click(object sender, EventArgs e)
        {

            ShowForm(new AuntRosieApplication.Expenses.frmCostExpenseQueries());
        }

        private void tmnExpenses_Click(object sender, EventArgs e)
        {

        }

        private void btnEstmite_Click(object sender, EventArgs e)
        {
            ShowForm(new AuntRosieApplication.Event.EstimateEventProfitForm());
        }

        private void btnProfitQuery_Click(object sender, EventArgs e)
        {
                }

        private void btnProfitQuery_Click_1(object sender, EventArgs e)
        {
       ShowForm(new AuntRosieApplication.Expenses.ProfitQueriesForm());
   
        }

        private void tmnExpenses_MouseEnter(object sender, EventArgs e)
        {
            HidePanels();
            pnlExpensses.Show();
        }
    }
}
