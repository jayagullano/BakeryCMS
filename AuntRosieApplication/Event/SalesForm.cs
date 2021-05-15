/**
 * @author Mervat Mustafa
 * @description This form used to enter the customer sales
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
    public partial class frmSale : Form
    {
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;
        public long SaleID = -1;
        public frmSale()
        {
            InitializeComponent();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportDataSet.saleDet' table. You can move, or remove it, as needed.
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

            cmbCustomerName.Items.Clear();
            Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Customer.GetAllCustomer
                (Classes.DBMethod.GetConnectionString()), cmbCustomerName);

            cmbEventName.Items.Clear();
        FillCombBoxEvent(AuntRosieEntities.RosieEvent.GetAllEventByDate
                (Classes.DBMethod.GetConnectionString(), DateTime.Today.Date.ToShortDateString()), cmbEventName);
            Classes.DBMethod.FillPaymentmethodCombo(cmbPaymentMethod);

            //
            pnlMain.Enabled = true;
           
           
             

        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            ViewPanel(pnlNewcustomer);
            
            pnlMain.Enabled = false;
            pnlButton.Enabled = false;

        }

        #region helpper-functions
        private void ViewPanel(Panel pnl)
        {
            pnl.Top = (this.Height - pnl.Height) / 2;
            pnl.Left = (this.Width - pnl.Width) / 2;
            pnl.Visible = true;
        }
        #endregion

        private void btnNewTypeClose_Click(object sender, EventArgs e)
        {
            pnlNewcustomer.Visible = false;
            pnlMain.Enabled = true;
        }

        private void pnlNewcustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private bool GetValidationStatus()
        {
            bool isValid = true;
             
            if (txtFirstName.Text.Trim().Length < 3)
            {
                errSale.SetError(txtFirstName, "Customer Contact first name should be 3 letters at least");
                isValid = false;

            }
            if (txtLastName.Text.Trim().Length < 3)
            {
                errSale.SetError(txtLastName, "Customer Contact last name should be 3 letters at least");
                isValid = false;

            }

            if (!DBMethod.IsValidEmail(txtEmail.Text.Trim()))
            {
                errSale.SetError(txtEmail, "Entred Customer Email is not a valid email address");
                isValid = false;

            }
            if (txtPhone.Text.Trim().Length != 14)
            {
                errSale.SetError(txtPhone, "Entred Phone is not a valid phone number");
                isValid = false;

            }
            return isValid;
        }

        private void btnNewTypetClear_Click(object sender, EventArgs e)
        {
           bool  isValid = GetValidationStatus();
            if (isValid)
            {
                newCustomer();
                
                pnlNewcustomer.Visible = false;
                pnlMain.Enabled = true;
                pnlButton.Enabled = true;

            }
        }
        private void newCustomer()
        {


            AuntRosieEntities.Customer insertCustomer = new AuntRosieEntities.Customer();

            insertCustomer.FirstName = txtFirstName.Text.Trim();
            insertCustomer.LastName = txtLastName.Text.Trim();
            insertCustomer.Phone = txtPhone.Text.Trim();
            insertCustomer.Email = txtEmail.Text.Trim();



            try
            {

                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                insertCustomer.Create();
                cmbCustomerName.Items.Clear();
                Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Customer.GetAllCustomer
                    (Classes.DBMethod.GetConnectionString()), cmbCustomerName);

                cmbCustomerName.SelectedItem = cmbCustomerName.Items[cmbCustomerName.Items.Count - 1];

                MessageBox.Show("The new Customer has been inserted successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

                 MessageBox.Show(ex.Message);
                //MessageBox.Show("Sorry! An internal error has happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnNewTypeCancel_Click(object sender, EventArgs e)
        {
            pnlNewcustomer.Visible = false;
            pnlMain.Enabled = true;
            pnlButton.Enabled = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
             
             }

        private void btnNew_Click(object sender, EventArgs e)
        {
            pnlMain.Enabled = true;
           
             
            clearData();
            grbNew.Enabled = true;
            cmbEventName.Focus();
        }
        

        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbCustomerName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCustomerName.Items.Clear();
                Classes.DBMethod.FillCombBoxPerson(AuntRosieEntities.Customer.GetAllCustomerByLastName
                    (Classes.DBMethod.GetConnectionString(), cmbCustomerName.Text.Trim()), cmbCustomerName);
                if ( cmbCustomerName.Items.Count>0)
                {
                    cmbCustomerName.SelectedItem = cmbCustomerName.Items[0];
                }
               
            }
        }

        private void chkGuest_CheckedChanged(object sender, EventArgs e)
        {
            cmbCustomerName.SelectedItem = null;
            if (chkGuest.Checked)
            {
                cmbCustomerName.Enabled = false;
                btnAddCustomer.Enabled = false;


            }
            else
            {
                cmbCustomerName.Enabled = true;
                btnAddCustomer.Enabled = true;

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

        private void radToday_CheckedChanged(object sender, EventArgs e)
        {
            
            cmbEventName.Items.Clear();
            FillCombBoxEvent(AuntRosieEntities.RosieEvent.GetAllEventByDate
                    (Classes.DBMethod.GetConnectionString(), DateTime.Today.Date.ToShortDateString()), cmbEventName);

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

        private void cmbEventName_SelectedIndexChanged(object sender, EventArgs e)
        {
            DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
            RosieEntity.Connector = conn;
            RosieEvent rosieEvent = RosieEvent.Retrieve  ( long.Parse(DBMethod.GetSelectedItemID(cmbEventName)));
            EventLocation locEvent = EventLocation.Retrieve(rosieEvent.LocationId);
            lblEventLocation.Text += locEvent.Address.ToString();
            FillProduct(DBMethod.GetSelectedItemID(cmbEventName));


        }

        private void FillProduct (String eventID)

        {
           string sqlEventText = "SELECT  tblEventProduct.EventProductID, tblProduct.ProductName, tblProduct.ProductType " +
            "FROM tblEventProduct INNER JOIN " +
            "tblProduction ON tblEventProduct.ProductionID = tblProduction.ProductionID INNER JOIN " +
            "tblProductItem ON tblProduction.ProductItemID = tblProductItem.ProductItemID INNER JOIN " +
            "tblProductSize ON tblProductItem.SizeID = tblProductSize.SizeID INNER JOIN " +
            "tblProduct ON tblProductItem.ProductID = tblProduct.ProductID " +
            " WHERE        tblEventProduct.EventID = " + eventID + " and tblEventProduct.Quantity > tblEventProduct.soldQuantity";

            // Declare the connection
            SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand(sqlEventText, dbConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            // Declare a DataTable object that will hold the return value
            DataTable productTable = new DataTable();

            // Try to connect to the database, and use the adapter to fill the table
            try
            {
                dbConnection.Open();
                adapter.Fill(productTable);
                cmbProduct.Items.Clear();
                DBMethod.FillCombBoxPerson(productTable, cmbProduct);
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                dbConnection.Close();
            }

            // Return the populated DataTable
            
         


        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                EventProduct product = EventProduct.Retrieve(short.Parse(DBMethod.GetSelectedItemID(cmbProduct)));
                ndpQuanitity.Maximum = product.Quantity - product.SoldQuantity;
                //
                conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                Production production = Production.Retrieve(product.ProductionId);
                //
                conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                ProductItem productItem = ProductItem.Retrieve(production.ProductItemID);
                lblItemPrice.Text = productItem.Price.ToString("C");
                ndpQuanitity.Value = 1;
            }
            catch (Exception ex)
            { }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {    if ( cmbPaymentMethod.SelectedItem==null  )
                {
                    errSale.SetError(cmbPaymentMethod, "Payment method could not be empty");
                cmbPaymentMethod.Focus();
                }
                else
                {
                cmbPaymentMethod.Enabled=false;
                addSale();
                }
            
             
        }
        private void addSale()
        {
            if (grdSale.Rows.Count == 0)
            {

                Sale newSale = new Sale();
                newSale.PaymentMethod = DBMethod.GetSelectedItemID(cmbPaymentMethod);
                newSale.SaleDate = DateTime.Today;
                if (chkGuest.Checked)
                {
                    newSale.CustomerId = 0;
                }
                else
                {
                    newSale.CustomerId = long.Parse(DBMethod.GetSelectedItemID(cmbCustomerName));
                }
                DBConnector conn1 = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn1;
                newSale.Create();
                SaleID = Sale.RetrieveMax();
            }

            try
            {
                addNewSaleProduct();
            }
            catch (Exception ex)
            {
                for (int i = 0; i < grdSale.Rows.Count; i++)
                {
                    if (grdSale.Rows[i].Cells[0].Value.ToString() == DBMethod.GetSelectedItemID(cmbProduct))
                    {
                        DelSaleProduct(grdSale.Rows[i].Cells[0].Value.ToString(),
                            grdSale.Rows[i].Cells[3].Value.ToString());
                        addNewSaleProduct();

                    }


                }

            }

            fillSaleGrid();

        }

        private void addNewSaleProduct()
        {
            SaleProduct newSaleProduct = new SaleProduct();
            newSaleProduct.SaleId = SaleID;
            newSaleProduct.SaleQuantity = int.Parse(ndpQuanitity.Value.ToString());
            newSaleProduct.SalePrice = Double.Parse(lblItemPrice.Text.Substring(1));
            newSaleProduct.EventProductId = long.Parse(DBMethod.GetSelectedItemID(cmbProduct));
            DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
            RosieEntity.Connector = conn;
            newSaleProduct.Create();
            //
            EventProduct eventProduct = new EventProduct();
            conn = new DBConnector(Classes.DBMethod.GetConnectionString());
            RosieEntity.Connector = conn;
            eventProduct.Id = long.Parse(DBMethod.GetSelectedItemID(cmbProduct));
            eventProduct.UpdateQuantity(null, ndpQuanitity.Value.ToString());
        }
        private void fillSaleGrid ()
        {
            String sql = "SELECT        tblSale.SaleID, tblSaleProducts.SaleQuantity, tblSaleProducts.SalePrice, tblSaleProducts.SaleQuantity * tblSaleProducts.SalePrice AS itemCost, tblCustomer.CustomerFirstName, tblCustomer.CustomerLastName," +
                           " tblSale.SaleDateTime, tblSale.PaymentMethod, tblProductSize.SizeName, tblProduct.ProductName, tblSaleProducts.EventProductID " +
                           " FROM            tblSaleProducts INNER JOIN " +
                            " tblSale ON tblSaleProducts.SaleID = tblSale.SaleID INNER JOIN " +
                            " tblCustomer ON tblSale.CustomerID = tblCustomer.CustomerID INNER JOIN " +
                            " tblEventProduct ON tblSaleProducts.EventProductID = tblEventProduct.EventProductID INNER JOIN " +
                            " tblProduction ON tblEventProduct.ProductionID = tblProduction.ProductionID INNER JOIN " +
                            " tblProductItem ON tblProduction.ProductItemID = tblProductItem.ProductItemID INNER JOIN " +
                            " tblProductSize ON tblProductItem.SizeID = tblProductSize.SizeID INNER JOIN " +
                            " tblProduct ON tblProductItem.ProductID = tblProduct.ProductID " +
                            " WHERE(tblSale.SaleID = " + SaleID.ToString() + ")";

            string connectionString = DBMethod.GetConnectionString();

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql,connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "SaleDet");
            connection.Close();
           grdSale.DataSource = ds;
            grdSale.DataMember = "SaleDet";

           

           if (grdSale.Rows.Count>0)
            {
                btnClear.Enabled = true;
               btnSave.Enabled = true; 
                calcBill();
            }
           else
            {
                btnClear.Enabled = false;
                btnSave.Enabled = false;
            }
        }
        private void  calcBill()
        {
            int totItems = 0;
            double totPrice = 0;
            double tax = 0;
            double netPrice = 0;
            foreach (DataGridViewRow row in grdSale.Rows)
            {
                 
              totItems+=int.Parse(row.Cells[3].Value.ToString());
                totPrice += double.Parse(row.Cells[5].Value.ToString());


            }
            tax = totPrice * 0.13;
            netPrice = totPrice * 1.13;
            lblTotalNumberOfItem.Text = totItems.ToString();
           LblTotalPrice.Text = totPrice.ToString("c");
            lblTax.Text = tax.ToString("c");
            lblTotalVallue.Text = netPrice.ToString("c");
        }
        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDocument1;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            btnSave.Enabled = false;
            btnNextCustomer_Click(sender, e);
        }

        private void grdSale_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grdSale.Columns["Delete"].Index)
            {
                DelSaleProduct(grdSale.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    grdSale.Rows[e.RowIndex].Cells[3].Value.ToString());
                fillSaleGrid();

            }
        }

        private void DelSaleProduct(string eventProductId, string salQuantity)
        {
            SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand("Delete from tblSaleProducts where EventProductId=" + eventProductId +
                "  and SaleID=" + SaleID , dbConnection);
            
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
                MessageBox.Show( "del" +ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }

            ///
             dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
              command = new SqlCommand(" Update [tblEventProduct] set Quantity= Quantity+ " + salQuantity + "," +
                " soldQuantity= soldQuantity-" + salQuantity + " where EventProductID=" + eventProductId, dbConnection);
           
            adapter = new SqlDataAdapter(command);

            // Declare a DataTable object that will hold the return value


            // Try to connect to the database, and use the adapter to fill the table
            try
            {
                dbConnection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("update"+ex.Message);
            }
            finally
            {
                dbConnection.Close();
            }

            fillSaleGrid();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SqlConnection dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
            SqlCommand command = new SqlCommand("Delete from tblSaleProducts where  SaleID=" + SaleID, dbConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);

              
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
             
            dbConnection = new SqlConnection(DBMethod.GetConnectionString());

            // Create new SQL command
              command = new SqlCommand("Delete from tblSale where  SaleID=" + SaleID, dbConnection);

              adapter = new SqlDataAdapter(command);


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
            fillSaleGrid();
            clearData();
        }

        private void clearData()
        {


            cmbPaymentMethod.Enabled = true; 
            lblTotalNumberOfItem.Text = "";
            LblTotalPrice.Text = "";
            lblTax.Text = "";
            lblTotalVallue.Text = "";
            ndpQuanitity.Value = 1;
            FillProduct(DBMethod.GetSelectedItemID(cmbEventName));
            cmbProduct.SelectedItem = null;
            cmbCustomerName.SelectedItem = null;
            lblItemPrice.Text = "";
            cmbPaymentMethod.SelectedItem = null;
            SaleID = -1;
            fillSaleGrid();

        }

        private void btnNextCustomer_Click(object sender, EventArgs e)
        {   
            clearData();
            grbNew.Enabled = false;
            cmbCustomerName.Focus();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {


            string projTitle = "Aunt Rosie's Bill ";           
            e.Graphics.DrawString(projTitle, new System.Drawing.Font("Book Antiqua", 16, FontStyle.Bold), Brushes.Maroon, 350, 20);

            string curdhead;
            if (chkGuest.Checked)
            {
                curdhead = chkGuest.Text;
            }
            else
            {
                  curdhead = cmbCustomerName.SelectedItem.ToString();
            }
            curdhead = "Customer: "+ curdhead+ " - " + SaleID.ToString();
            e.Graphics.DrawString(curdhead, new System.Drawing.Font("Book Antiqua", 12, FontStyle.Bold), Brushes.Black, 20, 50);
           


            string currentDate ="Event:  " + cmbEventName.SelectedItem.ToString();;
            e.Graphics.DrawString(currentDate, new System.Drawing.Font("Book Antiqua", 10, FontStyle.Regular), Brushes.Black, 20, 80);
            string Tot5 = "Payment Method:   " + cmbPaymentMethod.SelectedItem.ToString();
            e.Graphics.DrawString(Tot5, new System.Drawing.Font("Book Antiqua", 10, FontStyle.Regular), Brushes.Black, 20,  100);

            string l1 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
           
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Gray, 10, 120);

            //ExpiryDate, tblIngredientInventory.Quantity, tblIngredientInventory.Unit
            string g1 = "Product Name ";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 40, 140);

            string g2 = "Size";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 190, 140);

            string g3 = "Quantity";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 340, 140);

            string g4 = "Sale Price";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 440, 140);
           
            string g5 = "Total Items Price";
            e.Graphics.DrawString(g5, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 540, 140);
            
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Gray, 10, 150);

            int height = 165;
            for (int l = numberOfItemsPrintedSoFar; l < grdSale.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= grdSale.Rows.Count)
                    {

                        height += grdSale.Rows[0].Height;
                        e.Graphics.DrawString(grdSale.Rows[l].Cells[1].FormattedValue.ToString(), grdSale.Font = new Font("Book Antiqua", 8), Brushes.Black,  40, height);
                        e.Graphics.DrawString(grdSale.Rows[l].Cells[2].FormattedValue.ToString(), grdSale.Font = new Font("Book Antiqua", 8), Brushes.Black,  190, height );
                        e.Graphics.DrawString(grdSale.Rows[l].Cells[3].FormattedValue.ToString(), grdSale.Font = new Font("Book Antiqua", 8), Brushes.Black,  340, height );
                        e.Graphics.DrawString(grdSale.Rows[l].Cells[4].FormattedValue.ToString(), grdSale.Font = new Font("Book Antiqua", 8), Brushes.Black,   440, height );
                        e.Graphics.DrawString(grdSale.Rows[l].Cells[5].FormattedValue.ToString(), grdSale.Font = new Font("Book Antiqua", 8), Brushes.Black,  540, height );
                       

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
           
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Gray, 10, height+20);
            string Tot1 = "Total Number Of Items: "   ;
            e.Graphics.DrawString(Tot1, new System.Drawing.Font("Book Antiqua", 10, FontStyle.Bold), Brushes.Navy, 70, height + 40);
            e.Graphics.DrawString(lblTotalNumberOfItem.Text, new System.Drawing.Font("Book Antiqua", 10, FontStyle.Regular), Brushes.Black, 250, height + 40);

            string Tot2 = "Total Items Prices: "  ;
            e.Graphics.DrawString(Tot2, new System.Drawing.Font("Book Antiqua", 10, FontStyle.Bold), Brushes.Navy, 70, height + 60);
            e.Graphics.DrawString(LblTotalPrice.Text, new System.Drawing.Font("Book Antiqua", 10, FontStyle.Regular), Brushes.Black, 250, height + 60);

            string Tot3 = "Tax: ";
            e.Graphics.DrawString(Tot3, new System.Drawing.Font("Book Antiqua", 10, FontStyle.Bold), Brushes.Navy, 70, height + 80);
            e.Graphics.DrawString( lblTax.Text, new System.Drawing.Font("Book Antiqua", 10, FontStyle.Regular), Brushes.Black, 250, height + 80);

            string Tot4 = "Total Bill Value: "  ;
            e.Graphics.DrawString(Tot4, new System.Drawing.Font("Book Antiqua", 10, FontStyle.Bold), Brushes.Navy, 70, height + 100);
            e.Graphics.DrawString(lblTotalVallue.Text, new System.Drawing.Font("Book Antiqua", 10, FontStyle.Regular), Brushes.Black, 250, height + 100);

            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Gray, 10, height + 120);


            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;
        }
    }
    }
