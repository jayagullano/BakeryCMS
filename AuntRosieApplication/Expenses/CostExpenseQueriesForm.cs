/**
 * @author Mervat Mustafa
 * @description This form used to run some queries about the expenses and cost
 * @since 2020-December
 */

using System;
 
using System.Data;
 
using System.Windows.Forms;
using AuntRosieApplication.Classes;
 
using System.Data.SqlClient;
 

namespace AuntRosieApplication.Expenses
{
    public partial class frmCostExpenseQueries : Form
    {
        public string sqltext;
        public string sqlWhereTime ;
        public string sqlWhereType;
        public string sqlWherePayMethod;
        public string sqlOrder;
            
        public frmCostExpenseQueries()
        {this.DoubleBuffered = true;
            InitializeComponent();
            
            
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

        private void frmCostExpenseQueries_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

            sqltext = "SELECT        PaymentDate, Amount, CASE WHEN PaymentMethod = 'r' THEN 'Credit' ELSE CASE WHEN PaymentMethod = 'c' THEN 'Cash' ELSE CASE WHEN PaymentMethod = 'd' THEN 'Debit' END END END AS PaymentMethod,  Type" +
                          " FROM(SELECT PaymentDate, Amount, PaymentMethod, 'Full Timer Payroll' AS Type" +
                          " FROM tblFullTimePayroll" +
                          " UNION ALL" +
                          " SELECT PaymentDate, Amount, PaymentMethod, 'Part Timer Payroll' AS Type" +
                          " FROM tblPayroll" +
                         "  UNION ALL" +
                         "  SELECT ExpensePayDate, ExpenseValue, PaymentMethod, 'Miscellaneous Expense' AS Type" +
                          " FROM tblMiscellaneousExpense" +
                          " UNION ALL" +
                          " SELECT PurchaseDate, Cost, PaymentMethod, 'Inventory-in Stock' AS Type" +
                          " FROM tblIngredientInventory) AS derivedtbl_1";
            
            
              sqlOrder = "ORDER BY PaymentDate";
            fillGrid();
            Classes.DBMethod.FillPaymentmethodCombo(cmbPaymentMethod);

        }

        private void fillGrid()
        {

            string sql="";
            if (chkAlltime.Checked)
            {
                if (chkExpenType.Checked)

                {
                    sql = sqltext + " " + sqlOrder;
                    if (!chkPay.Checked)

                        sql = sqltext + " where " + sqlWherePayMethod + " " + sqlOrder;
                }
                else

                {
                    sql = sqltext + " where" + sqlWhereType + " " + sqlOrder;
                   if (!chkPay.Checked)

                        sql = sqltext + " where " + sqlWhereType + " and " + sqlWherePayMethod + " " + sqlOrder;
                 }

            }
            else
            { if (chkExpenType.Checked)
                {
                    sql = sqltext + " where" + sqlWhereTime + " " + sqlOrder;
                    if (!chkPay.Checked)
                        sql = sqltext + " where" + sqlWhereTime + " and " + sqlWherePayMethod+ " " + sqlOrder;
                }
                else
                { sql = sqltext + " where" + sqlWhereType + " and  " + sqlWhereTime + " " + sqlOrder; 
                if (!chkPay.Checked)
                        sql = sqltext + " where" + sqlWhereType + " and  " + sqlWhereTime + "  and " + sqlWherePayMethod+ " "  + sqlOrder;
                }

            }

           
            string connectionString = DBMethod.GetConnectionString();
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "ExpenCost");
            connection.Close();
            grdCost.DataSource = ds;
           grdCost.DataMember = "ExpenCost";
            if (grdCost.Rows.Count == 0)
                MessageBox.Show("No reults are founded", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            calcTotal();
        }

        private void calcTotal()
        {


            double tot = 0;
            for(int i=0;i<grdCost.Rows.Count;i++)
            {
                tot += double.Parse(grdCost.Rows[i].Cells[1].Value.ToString());

            }
            lblITotAmount.Text = tot.ToString("C");
        }
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            sqlWhereTime = "(PaymentDate BETWEEN '" + dtpFormDate.Value.Date.ToShortDateString() + "' AND '" + dtpToDate.Value.Date.ToShortDateString() + "') ";

            fillGrid();
        }

        private void cmbExpensesType_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlWhereType = "(Type='" + cmbExpensesType.SelectedItem.ToString() + "')";
        }
        
        private void chkAlltime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlltime.Checked)
                pnlDate.Enabled = false;
            else
                pnlDate.Enabled = true;

        }

        private void chkExpenType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExpenType.Checked)
                pnlType.Enabled = false;
            else
                pnlType.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlWherePayMethod = "(PaymentMethod='" + DBMethod.GetSelectedItemID(cmbPaymentMethod) + "')";

        }

        private void chkPay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPay.Checked)
                pnlPay.Enabled = false;
            else
                pnlPay.Enabled = true;
        }
    }
}
