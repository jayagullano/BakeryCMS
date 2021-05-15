/**
 * @author Mervat Mustafa
 * @description This form used to  enter the expenses
 * @since 2020-December
 */

using System;
 
using System.Data;
 
using System.Windows.Forms;
using AuntRosieApplication.Classes;
 
using System.Data.SqlClient;
using AuntRosieEntities;

namespace AuntRosieApplication.Expenses
{
    
    public partial class frmExpensesManage : Form
    {public long ExpenseID;
        public frmExpensesManage()
        {
            InitializeComponent();
        }

        private void frnManageExpenses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportDataSet.tblMiscellaneousExpense' table. You can move, or remove it, as needed.
            //this.tblMiscellaneousExpenseTableAdapter.Fill(this.reportDataSet.tblMiscellaneousExpense);
            cmbEventName.Items.Clear();
            FillCombBoxEvent(AuntRosieEntities.RosieEvent.GetAllEventByDate
                    (Classes.DBMethod.GetConnectionString(), DateTime.Today.Date.ToShortDateString()), cmbEventName);
            Classes.DBMethod.FillPaymentmethodCombo(cmbPaymentMethod);
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

       
            Classes.DBMethod.FillExpensesType(cmbExpensesType);
            fillExpenseGrid();
        }
        private void FillCombBoxEvent(DataTable dt, ComboBox cmb)
        {


            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
                    itm.name = row[1].ToString() + "--ON " + DateTime.Parse(row[2].ToString()).ToLongDateString();
                    itm.id = row[0].ToString();
                    cmb.Items.Add((Object)itm);
                }
            }

        }

        private void radLastMonth_CheckedChanged(object sender, EventArgs e)
        {
            cmbEventName.Items.Clear();
            FillCombBoxEvent(AuntRosieEntities.RosieEvent.GetAllEventByDate
                (Classes.DBMethod.GetConnectionString(), (DateTime.Today.Date.AddMonths(-1)).ToShortDateString()), cmbEventName);

        }

        private void radAll_CheckedChanged(object sender, EventArgs e)
        {
            cmbEventName.Items.Clear();
            FillCombBoxEvent(AuntRosieEntities.RosieEvent.GetAllEvent
                (Classes.DBMethod.GetConnectionString()), cmbEventName);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddFull_Click(object sender, EventArgs e)
        {
            if (isValidExpense())
            {
               
                    AuntRosieEntities.Expense newExpenses = new AuntRosieEntities.Expense();
                    newExpenses.PaymentDate = DateTime.Parse(dtpFormDate.Value.Date.ToShortDateString());
                    newExpenses.PayValue = double.Parse(txtVal.Text.Trim().ToString());
                    newExpenses.ThisPaymentMethod = DBMethod.GetSelectedItemID(cmbPaymentMethod);
                    newExpenses.PayType = DBMethod.GetSelectedItemID(cmbExpensesType);
                    newExpenses.Note = txtNote.Text.Trim().ToString();
                    DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                    RosieEntity.Connector = conn;
                   try
                {  newExpenses.Create();
                    ExpenseID = Expense.RetrieveMax();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
                if (chkIsEvent.Checked)
                {
                    AuntRosieEntities.EventExpense newEventExpenses = new AuntRosieEntities.EventExpense();
                    newEventExpenses.ExpensID = ExpenseID;
                    newEventExpenses.EventID = long.Parse(DBMethod.GetSelectedItemID(cmbEventName));

                    conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                    RosieEntity.Connector = conn;
                    newEventExpenses.Create();

                }
                clearData();
                fillExpenseGrid();
            }
        }
        private void clearData()
        {

            cmbPaymentMethod.SelectedItem = null;
            cmbEventName.SelectedItem = null;
            cmbExpensesType.SelectedItem = null;
            txtNote.Text = "";
            txtVal.Text = "";
        }
        private void fillExpenseGrid()
        {
            String sql = "SELECT        ExpenseID, ExpensePayDate, ExpenseValue, ExpenseNote, " +
                         " CASE WHEN PaymentMethod = 'r' THEN 'Credit' ELSE CASE WHEN PaymentMethod = 'c' THEN 'Cash' ELSE CASE WHEN PaymentMethod = 'd' THEN 'Debit' END END END AS PaymentMethod, "+ 
                         " CASE WHEN ExpenseType = 'T' THEN 'Tansportation' ELSE CASE WHEN ExpenseType = 'U' THEN 'Utility Bill' ELSE CASE WHEN ExpenseType = 'M' THEN 'Maintenance Fee' ELSE CASE WHEN ExpenseType = 'O' THEN 'Maintenance Fee' "+
                          " END END END END AS ExpenseType "+
" FROM tblMiscellaneousExpense" +
" WHERE(ExpensePayDate = '" + dtpFormDate.Value.Date.ToShortDateString() + "')";

            string connectionString = DBMethod.GetConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "ExpensDet");
            connection.Close();
            grdExpenses.DataSource = ds;
           grdExpenses.DataMember = "ExpensDet";



            
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
            }
           

        }

        private void chkIsEvent_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsEvent.Checked)
            {
                grbNew.Enabled = true;
            }
            else
            {
                grbNew.Enabled = false;
            }
        }
        private bool isValidExpense()
        {

            errExpense.Clear();
            bool isValid = true;
            if (dtpFormDate.Value.Date > DateTime.Today.Date)
            {
                errExpense.SetError(dtpFormDate, "Please check the Payment date, the date could not be after today date");
                isValid = false;

            }
            if (txtVal.Text.Trim() != "")
                if (double.Parse(txtVal.Text) < 0)
                {
                    errExpense.SetError(txtVal, " Enter Expense's value as the numeric value");

                    isValid = false;
                }

            if (txtVal.Text.Trim() == "")
            {
                errExpense.SetError(txtVal, " Enter Expense's value as the numeric value");

                isValid = false;
            }
            if (txtNote.Text.Trim() == "")
            {
                txtNote.Text = "No-Note";

                
            }


            if (cmbPaymentMethod.Text == "")
            {
                errExpense.SetError(cmbPaymentMethod, " Select The payment method");
                isValid = false;

            }
            if (chkIsEvent.Checked)
            {
                if (cmbEventName.SelectedItem==null)
                {
                    errExpense.SetError(cmbEventName, " Select The Event");
                    isValid = false;

                }

            }

            return isValid;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtVal_MouseLeave(object sender, EventArgs e)
        {
            double Val;
            if (txtVal.Text.Trim().Length > 0)
            {
                if (double.TryParse(txtVal.Text, out Val))
                {
                    txtVal.Text = string.Format("{0:0.00}", Val);
                     


                }
            }
        }

        private void grdExpenses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdExpenses.Columns["Delete"].Index)
            {
                DelExpenses(grdExpenses.Rows[e.RowIndex].Cells[0].Value.ToString());
                fillExpenseGrid();

            }
        }

        private void DelExpenses(string expId)
        {
            SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand("Delete from [tblMiscellaneousExpense] where "+
                "   ExpenseID=" + expId, dbConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Declare a DataTable object that will hold the return value


            // Try to connect to the database, and use the adapter to fill the table
            try
            {
                dbConnection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("del" + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }

            

            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void radToday_CheckedChanged(object sender, EventArgs e)
        {
            FillCombBoxEvent(AuntRosieEntities.RosieEvent.GetAllEventByDate
                   (Classes.DBMethod.GetConnectionString(), DateTime.Today.Date.ToShortDateString()), cmbEventName);


        }
    }
} 
