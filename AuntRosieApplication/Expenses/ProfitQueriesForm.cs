/**
 * @author Mervat Mustafa
 * @description This form used to calculate to profit 
 * @since 2020-December
 */
using System;
 
using System.Data;
using System.Drawing;
 
using System.Windows.Forms;
using AuntRosieApplication.Classes;
 
using System.Data.SqlClient;
 

namespace AuntRosieApplication.Expenses
{
    public partial class ProfitQueriesForm : Form
    {
        public ProfitQueriesForm()
        {
            this.DoubleBuffered = true;
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


        private void ProfitQueriesForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

        }
        private void calcExp()
        {

            string sql = "SELECT        SUM(Amount) AS Expr1 FROM  (SELECT        PaymentDate, Amount  FROM            tblFullTimePayroll " +
                          " UNION ALL  SELECT PaymentDate, Amount FROM tblPayroll " +
                          " UNION ALL SELECT ExpensePayDate, ExpenseValue FROM tblMiscellaneousExpense " +
                          " UNION ALL  SELECT PurchaseDate, Cost FROM tblIngredientInventory) AS derivedtbl_1 ";
 
            if (!chkAlltime.Checked)
                sql += "  WHERE(PaymentDate BETWEEN'" + dtpFormDate.Value.Date.ToShortDateString() + "' AND '" + dtpToDate.Value.Date.ToShortDateString() + "')";
            SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand(sql, dbConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Declare a DataTable object that will hold the return value
            DataTable dt = new DataTable();

            // Try to connect to the database, and use the adapter to fill the table
            try
            {
                dbConnection.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {

                    lblITotExpenses.Text = "$0.00";
                    


                }

                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {

                        lblITotExpenses.Text = double.Parse(row[0].ToString()).ToString("C");
                        

                    }

                }


            }
            catch (Exception ex)
            {

            }
        }
         private void calcRevenue()
        {
            SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
            string sql = "SELECT        SUM(tblEventProduct.soldQuantity * tblProductItem.Price) AS SalesPrice "+
" FROM tblEventProduct INNER JOIN "+
                         " tblProduction ON tblEventProduct.ProductionID = tblProduction.ProductionID INNER JOIN "+
                        " tblProductItem ON tblProduction.ProductItemID = tblProductItem.ProductItemID INNER JOIN "+
                        " tblEvent ON tblEventProduct.EventID = tblEvent.EventID";
            if (!chkAlltime.Checked)
                sql = sql + " WHERE(tblEvent.EventDate BETWEEN'" + dtpFormDate.Value.Date.ToShortDateString() + "' AND '" + dtpToDate.Value.Date.ToShortDateString() + "')";
            SqlCommand command = new SqlCommand(sql, dbConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Declare a DataTable object that will hold the return value
            DataTable dt = new DataTable();

            // Try to connect to the database, and use the adapter to fill the table
            try
            {
                dbConnection.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {

                    lblITotRevenue.Text = "$0.00";
                    

                }

                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {

                      lblITotRevenue.Text = double.Parse(row[0].ToString()).ToString("C");
                         

                    }

                }


            }
            catch (Exception ex)
            {

            }


        }
        private void chkAlltime_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAlltime.Checked)
                pnlDate.Enabled = false;
            else
                pnlDate.Enabled = true;
            lblITotExpenses.Text = "";
            lblITotProfit.Text = "";
            lblITotRevenue.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {


            calcRevenue();
            calcExp();
            double profit = double.Parse(lblITotRevenue.Text.Substring(1)) -
                 (double.Parse(lblITotExpenses.Text.Substring(1))) ;
            
            lblITotProfit.Text = profit.ToString("C");
            if (profit > 0)
            {
                lblITotProfit.ForeColor = Color.Green;
                lblITotProfit.Text += "-->Profit";

            }
            else if (profit == 0)
            {
                lblITotProfit.ForeColor = Color.Orange;
                lblITotProfit.Text += "-->Neutral";
            }
            else
            {
                lblITotProfit.ForeColor = Color.Red;
                lblITotProfit.Text += "-->Lose";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
