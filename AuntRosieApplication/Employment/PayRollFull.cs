/**
 * @author Mervat Mustafa
 * @description This form used to pay fro the FullTimer employee
 * @since 2020-December
 */
using System;
 
using System.Data;
 
using System.Windows.Forms;
using AuntRosieEntities;
using AuntRosieApplication.Classes;
 
using System.Data.SqlClient;


namespace AuntRosieApplication.Employment
{
    public partial class PayRollFull : Form
    {



        private string sqlText = null;
        private DateTime payDate = DateTime.Today.Date;
        public PayRollFull()
        {
            this.DoubleBuffered = true;
            InitializeComponent();

        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        protected override void OnPaint(PaintEventArgs e) { }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void relocation(Panel pnl)
        {
            //relocation the login pannel 
            pnl.Left = (this.Width - pnl.Width) / 2;
            pnl.Top = (this.Height - pnl.Height) / 2;
        }
        private void PayRollFull_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportDataSet.tblFullTimePayroll' table. You can move, or remove it, as needed.
            
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            relocation(pnlMain);
            pnlMain.Top = pnlMain.Top + 20;
            relocation(pnlPaymentDate);
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Employee.GetAllEmployeesByType
                     (Classes.DBMethod.GetConnectionString(), "F"), cmbfullEmp);
            Classes.DBMethod.FillMonthes(cmbMonth);
            Classes.DBMethod.FillPaymentmethodCombo(cmbPaymentMethod);
            cmbYear.Items.Add(DateTime.Today.Date.Year-1);
            cmbYear.Items.Add(DateTime.Today.Date.Year);
            cmbYear.Items.Add(DateTime.Today.Date.Year +1);
            cmbYear.SelectedItem = cmbYear.Items[1];

        }


        private void FillPayGrid(string sql)
        {

            string connectionString = DBMethod.GetConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "FullPayroll");
            connection.Close();
            grdPayroll.DataSource = ds;
            grdPayroll.DataMember = "FullPayroll";
        }

        private void radNew_CheckedChanged(object sender, EventArgs e)
        {
            payDate = DateTime.Today.Date;
            cmbPaymentDate.Items.Clear();
        }

        private void radExists_CheckedChanged(object sender, EventArgs e)
        {
            GetPaymentDate();
        }

        private void GetPaymentDate()
        {
            SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT DISTINCT PaymentDate AS Expr1 FROM  [tblFullTimePayroll]", dbConnection);

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
                    MessageBox.Show("No previous payroll are registered", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    radNew.Checked = true;
                    radExists.Checked = false;
                }
                else
                {
                    cmbPaymentDate.Enabled = true;
                    cmbPaymentDate.Focus();
                }
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        DateTime date = DateTime.Parse(row[0].ToString());
                        AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
                        itm.name = date.Date.ToShortDateString();
                        itm.id = date.Date.ToShortDateString();
                        cmbPaymentDate.Items.Add((Object)itm);

                    }
                }


            }
            catch (Exception ex)
            {

            }
            finally
            {
                dbConnection.Close();
            }


        }



        private bool isValidFullPayroll()
        {

             

            errPayroll.Clear();
            bool isValid = true;
            if (cmbfullEmp.Text == "")
            {
                errPayroll.SetError(cmbfullEmp, " Select The employee name");

                isValid = false;
            }

            if (cmbMonth.SelectedItem == null)
            {
                errPayroll.SetError(cmbMonth, " Month could not be empty");

                isValid = false;
            }



            if (cmbPaymentMethod.Text == "")
            {
                errPayroll.SetError(cmbPaymentMethod, " SelectThe payment method");
                isValid = false;

            }
            if (cmbYear.Text == "")
            {
                errPayroll.SetError(cmbYear, " SelectThe the Year , it could not be empty");
                isValid = false;

            }

            return isValid;
        }

        private void pnlPaymentDate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grdPayroll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdPayroll.Columns["Delete"].Index)
            {
                DelPayroll(grdPayroll.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    grdPayroll.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    grdPayroll.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    grdPayroll.Rows[e.RowIndex].Cells[5].Value.ToString()) ;
                FillPayGrid(sqlText);

            }
        }

        private void DelPayroll(string id, string year, string month, string biweek)
        {
            SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            if (biweek == "First 2 weeks")
                biweek = "1";
            else
                biweek="2";
            // Create new SQL command
            SqlCommand command = new SqlCommand(" Delete from [tblFullTimePayroll] where EmployeeId=" + id +
                " and Month=" + month + " and Year="+ year +" and BiweekNo=" + biweek, dbConnection);
            
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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }



        }

        private void cmbfullEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbfullEmp.SelectedItem != null)
            {



                try
                {

                    DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                    RosieEntity.Connector = conn;
                    Employee employee = Employee.Retrieve(DBMethod.GetSelectedItemID(cmbfullEmp));

                    double sal = employee.Salary;
                    lblEmploymentDate.Text = employee.EmploymentDate.ToShortDateString();
                    btnAddFull.Enabled = true;
                     if(isValidFullPayroll())
                    if ( employee.EmploymentDate.Year == int.Parse(cmbYear.SelectedItem.ToString()))
                    {
                        if (employee.EmploymentDate.Month > int.Parse(DBMethod.GetSelectedItemID(cmbMonth)))
                        {
                            MessageBox.Show("The employee has no payroll , The employment date is after this month",
                                "Month Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnAddFull.Enabled = false;




                        }
                         

                           
                         
                    }
                    else if (employee.EmploymentDate.Year > int.Parse(cmbYear.SelectedItem.ToString()))
                    {
                        MessageBox.Show("The employee has no payroll , The employment date is after this month",
                           "Year Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnAddFull.Enabled = false;

                    }
                    double amount = (sal / 26);
                    lblFullAmount.Text = String.Format("{0:0.0}", amount.ToString("N"));




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
         
        private void pnlMain_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
             
                if (radExists.Checked && cmbPaymentDate.Text == "")
                {
                    errPayroll.SetError(cmbPaymentDate, "Choose pauroll date");
                }
                else
                {
                    pnlMain.Enabled = true;
                    pnlPaymentDate.Visible = false;
                    sqlText = "SELECT   tblFullTimePayroll.EmployeeID, tblFullTimePayroll.PaymentDate, tblFullTimePayroll.Month , tblFullTimePayroll.Year, tblFullTimePayroll.Amount, tblFullTimePayroll.PaymentMethod, "+
                        "  tblEmployee.EmployeeFirstName , tblEmployee.EmployeeLastName ," +
                        " CASE WHEN tblFullTimePayroll.BiWeekNo = 1 THEN 'First 2 weeks' ELSE CASE WHEN tblFullTimePayroll.BiWeekNo = 2 THEN 'Last 2 Weeks' END END AS BiWeekNo" +
 " FROM tblFullTimePayroll INNER JOIN " +
                     "    tblEmployee ON tblFullTimePayroll.EmployeeID = tblEmployee.EmployeeID "+
" WHERE(tblFullTimePayroll.PaymentDate = '" + payDate.ToShortDateString() + "')";
                    FillPayGrid(sqlText);
                }
                lblPaymentDate.Text = payDate.ToShortDateString();
            }

        private void btnAddFull_Click(object sender, EventArgs e)
        {
            if (isValidFullPayroll())
            {
                try
                {
                    EmployeeFullPay empPayt = new EmployeeFullPay();
                    empPayt.EmployeeID = (long)Convert.ToDouble(DBMethod.GetSelectedItemID(cmbfullEmp));
                    empPayt.ThisPaymentMethod = DBMethod.GetSelectedItemID(cmbPaymentMethod);
                    empPayt.MonthNo =  int.Parse(DBMethod.GetSelectedItemID(cmbMonth)) ;
                    if (radFirst.Checked)
                    empPayt.BiWeekNo = 1;
                    else
                    empPayt.BiWeekNo = 1;
                    empPayt.YearNo = int.Parse(cmbYear.SelectedItem.ToString());
                    empPayt.Amount = Convert.ToDouble(lblFullAmount.Text.Trim());
                    empPayt.PaymentDate = DateTime.Today.Date;

                    DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                    RosieEntity.Connector = conn;
                    empPayt.Create();

                    FillPayGrid(sqlText);
                    clearData();
                }
                catch (Exception ex)
                {
                      //MessageBox.Show(ex.Message);
                     MessageBox.Show("The Employee's has been pied for the selected  Bi-week" , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearData()
        {
            cmbfullEmp.SelectedItem = null;
            cmbMonth.SelectedItem = null;
            cmbYear.SelectedItem = null;
            lblEmploymentDate.Text = "";
            lblFullAmount.Text = "";
            cmbPaymentMethod.SelectedItem = null;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void cmbPaymentDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            payDate = DateTime.Parse(cmbPaymentDate.SelectedItem.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlPaymentDate.Visible = true;
            pnlMain.Enabled = false;
        }
    }
}
