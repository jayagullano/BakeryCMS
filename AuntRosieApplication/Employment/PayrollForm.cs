/**
 * @author Mervat Mustafa
 * @description This form used to pay fro the partTimer employee
 * @since 2020-November
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuntRosieEntities;
using AuntRosieApplication.Classes;
 
using System.Data.OleDb;
using System.Data.SqlClient;
 

namespace AuntRosieApplication.Employment
{
    public partial class frmPayroll : Form
    {
        private string sqlText = null;
        private DateTime payDate = DateTime.Today.Date;
        public frmPayroll()
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
        private void frmPayroll_Load(object sender, EventArgs e)
        {
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            relocation(pnlMain);
            pnlMain.Top = pnlMain.Top + 20;
            relocation(pnlPaymentDate);
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
             
            Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Employee.GetAllEmployeesByType
                 (Classes.DBMethod.GetConnectionString(),"P"), cmbPartEmp);
            Classes.DBMethod.FillPaymentmethodCombo(cmbPaymentMethod);
             

        }
 
            

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            getDays();
        }
 
        private int getDays()
        {
            int days=0;

            DateTime start = Convert.ToDateTime(dtpFormDate.Value.Date);
            DateTime end = Convert.ToDateTime(dtpToDate.Value.Date);
            if (end > start)
            {
                TimeSpan difference = end.Subtract(start);


                days = (int)difference.TotalDays+1;
                lblDays.Text = days.ToString();
               
            }
            else
            {
                //MessageBox.Show("From Date should be bfore To Date ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblDays.Text = string.Empty;
            }
                
                
            return days; 



        }

        private void dtpFormDate_ValueChanged(object sender, EventArgs e)
        {
            getDays();
        }

        private void cmbPartEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPartEmp.SelectedItem != null) {  
            txtwage.Text = "";
            lblHour.Text = "";
            lblPartAmount.Text = "";

            if (lblDays.Text.Length > 0)
            {
                txtwage.Focus();
                SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

                // Create new SQL command
                SqlCommand command = new SqlCommand("SELECT  SUM(Hours) AS exp1 " +
    " FROM(SELECT        tblEmployeeHours.EmployeeID, tblEmployeeHours.EventID, tblEmployeeHours.Hours," +
    " tblEmployeeHours.IsPaid, tblEvent.EventID AS Expr1, tblEvent.EventName, tblEvent.LocationID, tblEvent.EventDate, " +
    " tblEvent.EventType FROM    tblEmployeeHours INNER JOIN   tblEvent ON tblEmployeeHours.EventID = tblEvent.EventID " +
    " WHERE(tblEvent.EventDate BETWEEN '" + dtpFormDate.Value.Date.ToShortDateString() + "' AND '" +
    dtpToDate.Value.Date.ToShortDateString() + "' )) AS derivedtbl_1" +
    " GROUP BY EmployeeID  HAVING(EmployeeID = " + DBMethod.GetSelectedItemID(cmbPartEmp) + ")", dbConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Declare a DataTable object that will hold the return value
                DataTable dt = new DataTable();

                // Try to connect to the database, and use the adapter to fill the table
                try
                {
                    dbConnection.Open();
                    adapter.Fill(dt);
                        btnAddPart.Enabled = true;
                    if (dt.Rows.Count == 0)
                        {
                            btnAddPart.Enabled = false;
                            lblHour.Text = "0.0";


                    }

                    if (dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {

                            lblHour.Text = String.Format("{0:0.0}", row[0].ToString());

                        }

                    }

                }
                catch (Exception ex)
                {
                   // MessageBox.Show(ex.Message);
                }
                finally
                {
                    dbConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("From Date should be before To Date ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            if( lblHour.Text.Trim()=="0")
                {
                    pnlPartAddPayroll.Enabled = false;
                }
            else
                {
                    pnlPartAddPayroll.Enabled = true;
                }
        }
        }

        private void txtwage_Leave(object sender, EventArgs e)
        {
            double wage;
            if (txtwage.Text.Trim().Length > 0)
            {
                if (double.TryParse(txtwage.Text, out wage))
                {
                    txtwage.Text = string.Format("{0:0.00}", wage);
                    double hours;
                    double.TryParse(lblHour.Text, out hours);
                    lblPartAmount.Text = string.Format("{0:0.00}", hours * wage);
                }
            }
       
        
      }

        private void FillPayGrid(string sql)
        {

            string connectionString = DBMethod.GetConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Payroll");
            connection.Close();
            grdPayroll.DataSource = ds;
            grdPayroll.DataMember = "Payroll";
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
            SqlCommand command = new SqlCommand("SELECT DISTINCT PaymentDate AS Expr1 FROM tblPayroll", dbConnection);

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
                    {    DateTime date= DateTime.Parse(row[0].ToString());
                        AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
                        itm.name =  date.Date.ToShortDateString();
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
                sqlText = " SELECT  tblEmployee.EmployeeFirstName, tblPayroll.PaymentDate, tblEmployee.EmployeeLastName, tblPayroll.Amount, tblPayroll.PaymentMethod, tblEmployee.EmployeeID, tblPayroll.FromDate, tblPayroll.ToDate"+
" FROM tblEmployee INNER JOIN " +
                         " tblPayroll ON tblEmployee.EmployeeID = tblPayroll.EmployeeID WHERE(tblPayroll.PaymentDate ='" + payDate.ToShortDateString()+ "')";
                FillPayGrid(sqlText);
            }
            lblPaymentDate.Text = payDate.ToShortDateString();
        }

        private void cmbPaymentDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            payDate = DateTime.Parse(cmbPaymentDate.SelectedItem.ToString());
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
          
                if (isValidPartPayroll())
                {
                   
                     
                         try
            { EmployeePay empPayt = new EmployeePay();
                        empPayt.EmployeeID = (long)Convert.ToDouble(DBMethod.GetSelectedItemID(cmbPartEmp));
                        empPayt.ThisPaymentMethod = DBMethod.GetSelectedItemID(cmbPaymentMethod);
                        empPayt.FromDate = dtpFormDate.Value;
                        empPayt.ToDate = dtpToDate.Value;
                        empPayt.Amount = Convert.ToDouble(lblPartAmount.Text.Trim());
                        empPayt.PaymentDate = DateTime.Today.Date;

                        DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                        RosieEntity.Connector = conn;
                        empPayt.Create();
                        FillPayGrid(sqlText);
                    updateHourIsPaid("1");
                    clearData();
                }
                catch (Exception ex)
            {
                        //MessageBox.Show(ex.Message);
                        MessageBox.Show("You can't add this payroll record, The Employee's payroll has been registered ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                 
            }
            
        }
        private void clearData()
        {
            cmbPartEmp.SelectedItem = null;
            lblPartAmount.Text = "";
            lblHour.Text = "";
            txtwage.Text = "";
        }
        private void updateHourIsPaid(String isPaid)
        {
            SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand("update tblEmployeeHours set isPaid = " + isPaid +
                " where EventID = (select EventId from tblEvent"+
                " where EventDate between '"+dtpFormDate.Value.Date.ToShortDateString()+
                "' and  '"+ dtpToDate.Value.Date.ToShortDateString()+"'); ", dbConnection);

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
               // MessageBox.Show("del->" + ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }
        }
        private bool isValidPartPayroll()
        {

            errPayroll.Clear();
            bool isValid = true;
            if (cmbPartEmp.Text == "")
            {
                errPayroll.SetError(cmbPartEmp, " Select The employee name");
                isValid = false;

            }
            if (lblDays.Text.Trim()!="")
            if ( int.Parse(lblDays.Text)<1)
            {
                errPayroll.SetError(dtpFormDate, " Select From Date value to detrmin the days");
                    errPayroll.SetError(dtpToDate, " Select  To Date value to detrmin the days");
                    isValid = false;
            }

            if (txtwage.Text.Trim() != "")
                if (double.Parse(txtwage.Text) < 0)
                {
                    errPayroll.SetError(txtwage, " Enter wage as the numeric value");
                    
                    isValid = false;
                }

            if (txtwage.Text.Trim() == "")
            {
                errPayroll.SetError(txtwage, " Enter wage as the numeric value");

                isValid = false;
            }

                if (lblDays.Text.Trim() == "")
            {    
                errPayroll.SetError(dtpFormDate, " Select From Date value to detrmin the days");
                errPayroll.SetError(dtpToDate, " Select  To Date value to detrmin the days");
                isValid = false;
            }

            if (cmbPaymentMethod.Text=="")
            {
                errPayroll.SetError(cmbPaymentMethod, " SelectThe payment method");
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

                DelPayroll(grdPayroll.Rows[e.RowIndex].Cells[0].Value.ToString());
                FillPayGrid(sqlText);
                 
            }
        }

        private  void DelPayroll(string id)
        {
            SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand(" Delete from tblPayroll where EmployeeId=" + id + 
                "and PaymentDate='" +payDate+ "'", dbConnection);

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

            updateHourIsPaid("0");

        }

        private void txtwage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlPaymentDate.Visible = true;
            pnlMain.Enabled = false;
        }
    }
}
