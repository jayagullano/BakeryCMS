/**
 * @author Mervat Mustafa
 * @description This form used to  run help the user to estmiate the event profit
 * @since 2020-December
 */
using System;
 
using System.Data;
using System.Drawing;
 
using System.Windows.Forms;
using AuntRosieApplication.Classes;
 
using System.Data.SqlClient;
using AuntRosieEntities;

namespace AuntRosieApplication.Event
{
    public partial class EstimateEventProfitForm : Form
    {
        public double HoursWages;
        public EstimateEventProfitForm()
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Classes.DBMethod.relocation(pnlEstmait, this);
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

            cmbEventName.Items.Clear();
            FillCombBoxEvent(AuntRosieEntities.RosieEvent.GetAllEventAfterDate
                   (Classes.DBMethod.GetConnectionString(), DateTime.Today.Date.ToShortDateString()), cmbEventName);
        }

        private void FillCombBoxEvent(DataTable dt, ComboBox cmb)
        {


            if (dt != null)
            {
                //MessageBox.Show(dt.Rows.Count.ToString());
                foreach (DataRow row in dt.Rows)
                {
                    AuntRosieApplication.Classes.ListItem itm;
                    itm = new AuntRosieApplication.Classes.ListItem();
                    itm.name = row[1].ToString() + "--ON " + DateTime.Parse(row[2].ToString()).ToLongDateString();
                    itm.id = row[0].ToString();

                    cmb.Items.Add(itm);
                    //MessageBox.Show(cmb.Items.Count.ToString());
                }
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FillHours()
        {
            SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT  SUM(Hours) AS exp1 " +
" FROM(SELECT        tblEmployeeHours.EmployeeID, tblEmployeeHours.EventID, tblEmployeeHours.Hours," +
" tblEmployeeHours.IsPaid, tblEvent.EventID AS Expr1, tblEvent.EventName, tblEvent.LocationID, tblEvent.EventDate, " +
" tblEvent.EventType FROM    tblEmployeeHours INNER JOIN   tblEvent ON tblEmployeeHours.EventID = tblEvent.EventID " +
" WHERE(tblEvent.EventID =" + DBMethod.GetSelectedItemID(cmbEventName) + ")) AS derivedtbl_1" +
" GROUP BY EventID  HAVING(EventID = " + DBMethod.GetSelectedItemID(cmbEventName) + ")", dbConnection);

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

                    lblHour.Text = "0.0";


                }

                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {

                        lblHour.Text = (double.Parse(row[0].ToString()) * HoursWages).ToString("C");

                    }

                }


            }
            catch (Exception ex)
            {

            }
        }

        private void calcSales()
        {
            SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT SUM(tblEventProduct.Quantity* tblProductItem.Price) AS SalesPrice, tblEventProduct.EventID" +
   " FROM            tblEventProduct INNER JOIN " +
                           "  tblProduction ON tblEventProduct.ProductionID = tblProduction.ProductionID INNER JOIN " +
                      "   tblProductItem ON tblProduction.ProductItemID = tblProductItem.ProductItemID " +
" GROUP BY tblEventProduct.EventID " +
" HAVING(tblEventProduct.EventID = " + DBMethod.GetSelectedItemID(cmbEventName) + ")", dbConnection);

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

                    lblRevenue.Text = "$0.00";
                    lblIngrdeintCost.Text = "$0.00";


                }

                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {

                        lblRevenue.Text = double.Parse(row[0].ToString()).ToString("C");
                        lblIngrdeintCost.Text = (double.Parse(row[0].ToString()) * 0.28).ToString("C");

                    }

                }


            }
            catch (Exception ex)
            {

            }
        }

        private void txtxHour_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNewTypetSave_Click(object sender, EventArgs e)
        {
            HoursWages = double.Parse(txtxHourWages.Text);
            lblExpense.Text = Double.Parse(txtxHourWages.Text).ToString("C");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

        }

        

        private void cmbEventName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbEventName.SelectedItem != null)
            {
                pnlEstmait.Visible = true;
            }
        }

        private void btnCalc_Click_1(object sender, EventArgs e)
        {
            FillHours();

            calcSales();
       
            double profit = double.Parse(lblRevenue.Text.Substring(1)) -
                ((double.Parse(lblIngrdeintCost.Text.Substring(1))) +
                (double.Parse(lblHour.Text.Substring(1))) +
                (double.Parse(lblExpense.Text.Substring(1))));
            lblEventProfit.Text = profit.ToString("C");
            if (profit > 0)
            {
                lblEventProfit.ForeColor = Color.Green;
                lblEventProfit.Text += "-->Profit";

            }
            else if (profit == 0)
            {
                lblEventProfit.ForeColor = Color.Orange;
                lblEventProfit.Text += "-->Neutral";
            }
            else
            {
                lblEventProfit.ForeColor = Color.Red;
                lblEventProfit.Text += "-->Lose";
            }
        }

        private void cmbEventName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEventName.SelectedItem != null)
            {
                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                RosieEvent rosieEvent = RosieEvent.Retrieve(long.Parse(DBMethod.GetSelectedItemID(cmbEventName)));
                EventLocation locEvent = EventLocation.Retrieve(rosieEvent.LocationId);
                lblEventLocation.Text += locEvent.Address.ToString();
                
                pnlEstmait.Visible = true;
            }
        }

        private void pnlEstmait_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNewTypetSave_Click_1(object sender, EventArgs e)
        {
            if (IsValidEntry())
            {
                HoursWages = double.Parse(txtxHourWages.Text);
                lblExpense.Text = Double.Parse(txtExpenses.Text).ToString("C");
                pnlEstmait.Visible = false;
                btnCalc.Enabled = true;
                btnCalc.Focus();
            }
        }

        private bool IsValidEntry()
        {
            bool isValid = true;
            if (txtxHourWages.Text.Trim() != "")
                if (double.Parse(txtxHourWages.Text) < 0)
                {
                    err1.SetError(txtxHourWages, " Enter wage as the numeric value");

                    isValid = false;
                }

            if (txtxHourWages.Text.Trim() == "")
            {
                err1.SetError(txtxHourWages, " Enter wage as the numeric value");

                isValid = false;
            }


            if (txtExpenses.Text.Trim() != "")
                if (double.Parse(txtExpenses.Text) < 0)
                {
                    err1.SetError(txtExpenses, " Enter wage as the numeric value");

                    isValid = false;
                }

            if (txtExpenses.Text.Trim() == "")
            {
                err1.SetError(txtExpenses, " Enter wage as the numeric value");

                isValid = false;
            }
            return isValid;
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
