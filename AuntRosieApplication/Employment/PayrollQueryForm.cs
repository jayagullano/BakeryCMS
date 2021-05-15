/**
 * @author Mervat Mustafa
 * @description This form used tor run some Queries about the epmployees payroll
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
    public partial class PayrollQueryForm : Form
    {

          
   


        private void PayrollMnueForm_Load(object sender, EventArgs e)
        {
 
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            cmbEmployeeName.Items.Clear();
            Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Employee.GetAllEmployeesByType
                 (Classes.DBMethod.GetConnectionString(), "F"), cmbEmployeeName);
 
        }

        public PayrollQueryForm()
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

        private void radFull_CheckedChanged(object sender, EventArgs e)
        {
            cmbEmployeeName.Items.Clear();
            Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Employee.GetAllEmployeesByType
                 (Classes.DBMethod.GetConnectionString(), "F"), cmbEmployeeName);

        }

        private void radPart_CheckedChanged(object sender, EventArgs e)
        {
            cmbEmployeeName.Items.Clear();
            Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Employee.GetAllEmployeesByType
                 (Classes.DBMethod.GetConnectionString(), "P"), cmbEmployeeName);

        }

        private void FillPayGridPart()
        {
            string sql = "  SELECT   tblPayroll.PaymentDate, tblPayroll.Amount, tblEmployee.EmployeeID, tblPayroll.FromDate, tblPayroll.ToDate," +
            "   CASE WHEN PaymentMethod = 'r' THEN 'Credit' ELSE CASE WHEN PaymentMethod = 'c' THEN 'Cash' ELSE CASE WHEN PaymentMethod = 'd' THEN 'Debit' END END END AS PaymentMethod"+
            " FROM tblEmployee INNER JOIN " +
                                     " tblPayroll ON tblEmployee.EmployeeID = tblPayroll.EmployeeID WHERE tblPayroll.EmployeeID = " + DBMethod.GetSelectedItemID(cmbEmployeeName); ;
             
            string connectionString = DBMethod.GetConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "PayrollPart");
            connection.Close();
            grdPayrollPart.DataSource = ds;
            grdPayrollPart.DataMember = "PayrollPart";
        }
        private void FillPayGridFull()
        {
            string sql = "SELECT        EmployeeID, PaymentDate, Month,  Amount, Year, " + 
                         " CASE WHEN tblFullTimePayroll.PaymentMethod = 'r' THEN 'Credit' ELSE CASE WHEN tblFullTimePayroll.PaymentMethod = 'c' THEN 'Cash' ELSE CASE WHEN tblFullTimePayroll.PaymentMethod = 'd' THEN 'debit' END END END," +
                           " CASE WHEN BiWeekNo = 1 THEN 'First 2 weeks' ELSE CASE WHEN BiWeekNo = 2 THEN 'Last 2 Weeks' END END" +

                          " AS BiWeekNo  FROM   tblFullTimePayroll  where EmployeeID = " + DBMethod.GetSelectedItemID(cmbEmployeeName);
            
            string connectionString = DBMethod.GetConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "PayrollFull");
            connection.Close();
            grdPayrollFull.DataSource = ds;
            grdPayrollFull.DataMember = "PayrollFull";
        }

        private void cmbEmployeeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (radPart.Checked)
            {
                grdPayrollPart.Visible = true;
                grdPayrollFull.Visible = false;
                FillPayGridPart();
            }
            else
            {
                grdPayrollPart.Visible = false;
                grdPayrollFull.Visible = true;
                FillPayGridFull();
            }
        }

        private void grdPayrollPart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
