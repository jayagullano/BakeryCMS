/**
 * @author Mervat Mustafa
 * @description This form used to run some queries about  stock inventory and to rid out
 * the expierd items
 * @since 2020-December
 */
using System;
 
using System.Data;
using System.Drawing;
 
using System.Windows.Forms;
using AuntRosieApplication.Classes;
 
using System.Data.SqlClient;
using AuntRosieEntities;

namespace AuntRosieApplication.Inventory
{
    public partial class frmInventoryStock : Form
    {
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;
        private string expierdWhere = String.Empty;

        public string SelectSQLCmmand = "SELECT        tblSupplier.SupplierName, tblIngredientType.TypeName, tblIngredient.IngredientName, tblIngredientInventory.PurchaseDate, tblIngredientInventory.ExpiryDate, tblIngredientInventory.Quantity, tblIngredient.Unit, "+
                       "  tblIngredientInventory.Cost "+
                       " FROM            tblSupplier INNER JOIN "+
                       "  tblIngredientInventory ON tblSupplier.SupplierID = tblIngredientInventory.SupplierID INNER JOIN "+
                      "   tblIngredient ON tblIngredientInventory.IngredientID = tblIngredient.IngredientID INNER JOIN "+
                       "  tblIngredientType ON tblIngredient.IngredientTypeID = tblIngredientType.IngredientTypeID  "+
                        "WHERE         (tblIngredientInventory.Quantity > 0) ";
        public string OrderSQLCmmand = "  ORDER BY tblIngredientInventory.ExpiryDate ";

        public static String reportSql = null;
        public string ReportSql
        {
            get
            {
                return reportSql;
            }
            set
            {
                if (reportSql != value)
                    reportSql = value;
            }
        }


        public frmInventoryStock()
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


        private void frmInventoryStock_Load(object sender, EventArgs e)
        {
             

            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

            lblTitle.Left = (this.Width - lblTitle.Width) / 2;

            cmbType.Items.Clear();
            Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
                 (Classes.DBMethod.GetConnectionString()), cmbType);
            ReportSql = SelectSQLCmmand + OrderSQLCmmand;
            FillGridStock(ReportSql);

            this.Visible = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbName.Items.Clear();
            Classes.DBMethod.FillCombBox(AuntRosieEntities.Ingredient.GetAllIngredintsByType
              (Classes.DBMethod.GetConnectionString(), DBMethod.GetSelectedItemID(cmbType)), cmbName);
           

            chkAllIngrdient.Checked = false;
            string wherSQLCmmand = " and  tblIngredient.IngredientTypeID= " + DBMethod.GetSelectedItemID(cmbType) + " ";
            ReportSql = SelectSQLCmmand + wherSQLCmmand + OrderSQLCmmand;
            FillGridStock(ReportSql);

            chkAllTypies.Checked = false;
            cmbName.Enabled = true;
            chkAllIngrdient.Enabled = true;
            chkAllIngrdient.Checked = true;
            GetQuantityType();
            LblQuantity.Text = "";


        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string wherSQLCmmand = " and  tblIngredientInventory.IngredientID= " + DBMethod.GetSelectedItemID(cmbName) + " ";
                ReportSql = SelectSQLCmmand + wherSQLCmmand + OrderSQLCmmand;
                FillGridStock(ReportSql);
                chkAllIngrdient.Checked = false;
                GetQuantity();
            }
            catch (Exception ex)
            {


            }

        }
        private void FillGridStock( string sql)
        {
            
            string connectionString = DBMethod.GetConnectionString();
            
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Stock_query");
            connection.Close();
            grdStock.DataSource = ds;
            grdStock.DataMember = "Stock_query";
        }
 
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string subTitle = "";
            string quString = "";
            if (chkExpierd.Checked)
            {
                subTitle = "Expired Items-";
            }
            else
            {
                subTitle = "Existing Items-";
            }

            if (chkAllTypies.Checked)
            {
                subTitle += " " + "- All";

            }
            else
            {
                subTitle += " " + cmbType.Text;

                if (chkAllIngrdient.Checked)
                {

                    subTitle += " "  + " -All";
                    quString = lblQuantityType.Text;


                }
                else
                {
                    subTitle +=  " (" + cmbName.Text+ ")";
                    quString = LblQuantity.Text;
                }
            }

            string projTitle = "Aunt Rosie's Inventory Stock";
            e.Graphics.DrawString(projTitle, new System.Drawing.Font("Book Antiqua", 14, FontStyle.Bold), Brushes.Black, 300, 20);

            string curdhead =  subTitle;
            e.Graphics.DrawString(curdhead, new System.Drawing.Font("Book Antiqua", 12, FontStyle.Bold), Brushes.Black, 20, 50);

            

            string currentDate = DateTime.Today.Date.ToShortDateString();
            e.Graphics.DrawString(currentDate, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Italic), Brushes.Black, 750 , 50);
            if (quString != "")
            {
                quString = "Total Quantity: " + quString;
                e.Graphics.DrawString(quString, new System.Drawing.Font("Book Antiqua", 10, FontStyle.Regular), Brushes.Black, 20, 75);
            }
            string l1 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 0, 100);

            //ExpiryDate, tblIngredientInventory.Quantity, tblIngredientInventory.Unit
            string g1 = "SupplierName ";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 20, 140);

            string g2 = "TypeName";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 120, 140);

            string g3 = "IngredientName";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 220, 140);

            string g4 = "PurchaseDate";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 320, 140);

            string g5 = "ExpiryDate";
            e.Graphics.DrawString(g5, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 420, 140);

            string g6 = "Quantity";
            e.Graphics.DrawString(g6, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 520, 140);
            string g7 ="Unit";
            e.Graphics.DrawString(g7, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 620, 140);

            string l2 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 0, 160);

            int height = 165;
            for (int l = numberOfItemsPrintedSoFar; l < grdStock.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= grdStock.Rows.Count)
                    {

                        height += grdStock.Rows[0].Height;
                        e.Graphics.DrawString(grdStock.Rows[l].Cells[0].FormattedValue.ToString(), grdStock.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(20, height, grdStock.Columns[0].Width, grdStock.Rows[0].Height));
                        e.Graphics.DrawString(grdStock.Rows[l].Cells[1].FormattedValue.ToString(), grdStock.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(120, height, grdStock.Columns[0].Width, grdStock.Rows[0].Height));
                        e.Graphics.DrawString(grdStock.Rows[l].Cells[2].FormattedValue.ToString(), grdStock.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(220, height, grdStock.Columns[0].Width, grdStock.Rows[0].Height));
                        e.Graphics.DrawString(grdStock.Rows[l].Cells[3].FormattedValue.ToString(), grdStock.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(320, height, grdStock.Columns[0].Width, grdStock.Rows[0].Height));
                        e.Graphics.DrawString(grdStock.Rows[l].Cells[4].FormattedValue.ToString(), grdStock.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(420, height, grdStock.Columns[0].Width, grdStock.Rows[0].Height));
                        e.Graphics.DrawString(grdStock.Rows[l].Cells[5].FormattedValue.ToString(), grdStock.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(520, height, grdStock.Columns[0].Width, grdStock.Rows[0].Height));
                        e.Graphics.DrawString(grdStock.Rows[l].Cells[6].FormattedValue.ToString(), grdStock.Font = new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(620, height, grdStock.Columns[0].Width, grdStock.Rows[0].Height));


                    }
                    else
                    {
                        e.HasMorePages = false;
                    }

                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;

                }


            }

            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DBMethod.Reptype = "All-Stock";
            (new ReportVewierForm()).ShowDialog();


            //System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            //PrintDialog1.AllowSomePages = true;
            //PrintDialog1.ShowHelp = true;
            //PrintDialog1.Document = printDocument1;
            //DialogResult result = PrintDialog1.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    printDocument1.Print();
            //}
        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            string updateSQLText = "Update [tblIngredientInventory]  Set tblIngredientInventory.Quantity=0 " +
                "where  (tblIngredientInventory.Quantity > 0)  " + expierdWhere;
            
            if (InventoryIngredient.RidOutExpierd(DBMethod.GetConnectionString(), updateSQLText))
            {
                MessageBox.Show("Selected expired items have been rid out", "Confirmation"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
                chkExpierd_CheckedChanged(sender, e);

            }
            else
            {
                MessageBox.Show("Sorry! An internal error has happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllTypies.Checked)
            {
                cmbType.Items.Clear();
                Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
                     (Classes.DBMethod.GetConnectionString()), cmbType);
                
                cmbName.Items.Clear();
                cmbName.Enabled = false;
                chkAllIngrdient.Enabled = false;
                ReportSql = SelectSQLCmmand + OrderSQLCmmand;
                FillGridStock(ReportSql);
                chkExpierd.Checked = false;
                lblQuantityType.Text = "";
                LblQuantity.Text = "";
            }
        }
        private void GetQuantity()
        {
            SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT  SUM(Quantity) AS Expr1, Unit, tblIngredientInventory.IngredientID  FROM  " +
                " ( tblIngredientInventory  INNER JOIN " +
                       "  tblIngredient ON tblIngredient.IngredientID = tblIngredientInventory.IngredientID ) " +
                       " GROUP BY Unit, tblIngredientInventory.IngredientID  HAVING (tblIngredientInventory.IngredientID = " + DBMethod.GetSelectedItemID(cmbName)  + ") ", dbConnection);
           
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
                        LblQuantity.Text = "0.00";

                    }

                    if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                      
                        LblQuantity.Text = row[0].ToString() + "  " +row[1].ToString() ;
                        
                    }
                   
                } 
                  
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


        private void GetQuantityType()
        {
            SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand("SELECT    SUM(tblIngredientInventory.Quantity) AS Expr1, tblIngredient.Unit, tblIngredientType.IngredientTypeID"+
                 "  FROM            tblIngredientInventory INNER JOIN "+
                " tblIngredient ON tblIngredientInventory.IngredientID = tblIngredient.IngredientID INNER JOIN " +
                        " tblIngredientType ON tblIngredient.IngredientTypeID = tblIngredientType.IngredientTypeID "+
                             "GROUP BY tblIngredient.Unit, tblIngredientType.IngredientTypeID" +
                 " HAVING(tblIngredientType.IngredientTypeID = " + DBMethod.GetSelectedItemID(cmbType) + ") ", dbConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
           
            // Declare a DataTable object that will hold the return value
            DataTable dt = new DataTable();

            // Try to connect to the database, and use the adapter to fill the table
            try
            {
                dbConnection.Open();
                adapter.Fill(dt);
               
               if (dt.Rows.Count==0)
                {
                    lblQuantityType.Text = "0.00";

                }
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {

                        lblQuantityType.Text = row[0].ToString() + "  " + row[1].ToString();

                    }
                }
                 
                
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
        private void chkExpierd_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExpierd.Checked)
            {
                string whereExpirySQLSelect= " and  tblIngredientInventory.ExpiryDate < '" + DateTime.Today.Date.ToShortDateString() + "' ";
                if (chkAllTypies.Checked)
                {
                    // MessageBox.Show(SelectSQLCmmand + whereExpirySQLSelect + OrderSQLCmmand);
                    ReportSql = SelectSQLCmmand + whereExpirySQLSelect + OrderSQLCmmand;
                    FillGridStock(ReportSql);
                    expierdWhere = whereExpirySQLSelect;

                }
                else
                {
                    if(chkAllIngrdient.Checked)
                    {
                        string wherSQLCmmand = " and  tblIngredientInventory.IngredientID= " + DBMethod.GetSelectedItemID(cmbType) + " ";
                        ReportSql = SelectSQLCmmand + wherSQLCmmand + whereExpirySQLSelect + OrderSQLCmmand;
                        FillGridStock(ReportSql);
                        expierdWhere = wherSQLCmmand + whereExpirySQLSelect;
                        GetQuantity();

                    }
                    else
                    {
                        string wherSQLCmmand = " and  tblIngredient.IngredientTypeID= " + DBMethod.GetSelectedItemID(cmbName) + " ";
                        FillGridStock(SelectSQLCmmand + wherSQLCmmand+  whereExpirySQLSelect+ OrderSQLCmmand);
                        expierdWhere = wherSQLCmmand + whereExpirySQLSelect;
                        GetQuantityType();

                    }
                }
                 
                if ( grdStock.Rows.Count==0)
                {
                    MessageBox.Show("No Expired items in the inventory", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnDestroy.Enabled = false;
                }
                else
                {
                    btnDestroy.Enabled = true;
                    btnDestroy.Focus();
                }

            }
            else
            {

                if (chkAllTypies.Checked)
                {
                    // MessageBox.Show(SelectSQLCmmand + whereExpirySQLSelect + OrderSQLCmmand);
                    ReportSql = SelectSQLCmmand + OrderSQLCmmand;
                    FillGridStock(ReportSql);

                }
                else
                {
                    if (chkAllIngrdient.Checked)
                    {
                        string wherSQLCmmand = " and  tblIngredientInventory.IngredientID= " + DBMethod.GetSelectedItemID(cmbName) + " ";
                        ReportSql = SelectSQLCmmand + wherSQLCmmand + OrderSQLCmmand;
                        FillGridStock(ReportSql);
                        GetQuantity();
                    }
                    else
                    {
                        string wherSQLCmmand = " and  tblIngredient.IngredientTypeID= " + DBMethod.GetSelectedItemID(cmbType) + " ";
                        ReportSql = SelectSQLCmmand + wherSQLCmmand + OrderSQLCmmand;
                        FillGridStock(ReportSql);
                        GetQuantityType();
                    }                  
                }

            }
        }

        private void chkAllIngrdient_CheckedChanged(object sender, EventArgs e)
        {

            if (chkAllIngrdient.Checked)
            {

                cmbName.Items.Clear();
                Classes.DBMethod.FillCombBox(AuntRosieEntities.Ingredient.GetAllIngredintsByType
                  (Classes.DBMethod.GetConnectionString(), DBMethod.GetSelectedItemID(cmbType)), cmbName);            
                string wherSQLCmmand = " and  tblIngredient.IngredientTypeID= " + DBMethod.GetSelectedItemID(cmbType) + " ";
                ReportSql = SelectSQLCmmand + wherSQLCmmand + OrderSQLCmmand;
                FillGridStock(ReportSql);        
                cmbName.Enabled = true;
                chkAllIngrdient.Enabled = true;            
                GetQuantityType();
                LblQuantity.Text = "";
            }
        }
    }
}
