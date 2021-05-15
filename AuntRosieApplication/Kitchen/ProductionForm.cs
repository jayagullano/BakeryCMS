/**
 * Author: Oghenefejiro Theodore Abohweyere
 * Purpose: Create new production records
 * Date: 2020-12-17
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
using System.Data.SqlClient;
using AuntRosieEntities;

namespace AuntRosieApplication.Kitchen
{
    public partial class frmProduction : Form
    {
        private List<ProductItem> productItems = new List<ProductItem>();
        private List<RosieEvent> events = new List<RosieEvent>();

        private RosieEvent rosieEvent;

        public frmProduction(RosieEvent rosieEvent)
        {
            this.rosieEvent = rosieEvent;
            InitializeComponent();
            //this.DoubleBuffered = true;
        }

        public frmProduction()
        {
            InitializeComponent();
            //this.DoubleBuffered = true;
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

        /// <summary>
        /// Connect to database, load background image and load data into form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmProduction_Load(object sender, EventArgs e)
        {
             lblTitle.Left = (this.Width - lblTitle.Width) / 2;
             pnlButton.Left = (this.Width - pnlButton.Width) / 2;
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;
            displayEvent();
            loadCmbs();
            /*cmbEvent.DisplayMember = "ToString()";*/
        }

        /// <summary>
        /// Display event in form
        /// </summary>
        private void displayEvent()
        {
            if(rosieEvent != null)
            {
                txtEvent.Text = rosieEvent.ToString();
            }
        }

        #region helper-functions
        /// <summary>
        /// Load comboboxes
        /// </summary>
        private void loadCmbs()
        {
            productItems = ProductItem.GetProductItems();

            cmbProductName.DataSource = productItems;
            cmbProductName.DisplayMember = "Product.Name";

            loadEventCmb(DateTime.Now);
        }

        private void loadEventCmb(DateTime earliestDate)
        {
            /*cmbEvent.Items.Clear();
            cmbEvent.Text = "";
            foreach (RosieEvent ev in RosieEvent.GetEvents(earliestDate))
            {
                cmbEvent.Items.Add(ev);
            }
            if (cmbEvent.Items.Count > 0)
            {
                cmbEvent.SelectedIndex = 0;
            }*/
        }

        /// <summary>
        /// Validate form input
        /// </summary>
        /// <returns></returns>
        private bool validateForm()
        {
            return validateDates() & validateEvent() & validateQty();
        }

        /// <summary>
        /// Validate date inputs
        /// </summary>
        /// <returns></returns>
        private bool validateDates()
        {
            return validateProductionDateNTime() & validateExpiryDate();
        }

        /// <summary>
        /// Validate quantity input
        /// </summary>
        /// <returns></returns>
        private bool validateQty()
        {
            long quantity = 0;
            if(!long.TryParse(txtQuantity.Text, out quantity))
            {
                errorProvider1.SetError(txtQuantity, "Quantity must be a whole number");
                return false;
            }
            else if(quantity > short.MaxValue || quantity < 0)
            {
                errorProvider1.SetError(txtQuantity, $"Quantity must be between {0} and {short.MaxValue}");
                return false;
            }
            errorProvider1.SetError(txtQuantity, "");
            return true;
        }

        private bool validateProductionDateNTime()
        {
            /*if(dtpProductionDate.Value.Date < DateTime.Now.Date)
            {
                errorProvider1.SetError(dtpProductionDate, "Production date cannot be in the future");
                return false;
            }
            else if(dtpProductionTime.Value.TimeOfDay > DateTime.Now.TimeOfDay)
            {
                errorProvider1.SetError(dtpProductionTime, "Production time cannot be in the future");
                return false;
            }

            errorProvider1.SetError(dtpProductionTime, "");*/

            return true;
        }

        /// <summary>
        /// Validate expiry date
        /// </summary>
        /// <returns></returns>
        private bool validateExpiryDate()
        {
            if (dtpExpiry.Value < DateTime.Now)
            {
                errorProvider1.SetError(dtpExpiry, "Expiry date cannot be in the past");
                return false;
            }

            errorProvider1.SetError(dtpExpiry, "");

            return true;
        }

        private bool validateEvent()
        {
            /*if(cmbEvent.Text.Trim() == "")
            {
                errorProvider1.SetError(cmbEvent, "Please select an event");
                return false;
            }*/
            return true;
        }

        private void addProductionToEvent()
        {
            try
            {

            }
            catch(SqlException se)
            {
                if(se.Message.Contains("duplicate key"))
                {
                    //errorProvider1.SetError(cmbEvent, "");
                }
            }
        }

        #endregion

        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Clear and enable fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Clear fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Save production
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                ProductItem selectedProductItem = (cmbProductName.SelectedItem as ProductItem);
                int productItem = selectedProductItem.Id;
                DateTime date = dtpProductionDate.Value.Date + dtpProductionTime.Value.TimeOfDay;
                try
                {
                    Production prodToBeCreated = new Production();
                    prodToBeCreated.ProductItemID = productItem;
                    prodToBeCreated.ProductionDate = date;
                    prodToBeCreated.Quantity = Convert.ToInt16(txtQuantity.Text);
                    prodToBeCreated.ExpiryDate = dtpExpiry.Value.Date;
                    prodToBeCreated.Create();

                    new EventProduct(rosieEvent.Id, Production.GetLastID(), prodToBeCreated.Quantity, true);
                    MessageBox.Show("Successfully recorded production");
                }
                catch(SqlException se)
                {
                    if(se.Message.Contains("duplicate key"))
                    {
                        MessageBox.Show("Production already assigned to event");
                    }
                }
                catch
                {
                    MessageBox.Show("Something went wrong. We are fixing the issue");
                }
            }
        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void cmbEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblLoc.Text = $"Event Location: {(cmbEvent.SelectedItem as RosieEvent).EventLocation}";
        }

        /// <summary>
        /// Make expiry date automatically move in front of production date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpProductionDate_ValueChanged(object sender, EventArgs e)
        {
            
            loadEventCmb(dtpProductionDate.Value);
            if(dtpExpiry.Value < dtpProductionDate.Value)
            {
                dtpExpiry.Value = dtpProductionDate.Value.AddDays(2);
            }
        }

        /// <summary>
        /// Make sure that length of quantity input is always valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantity.Text.Length > 5)
            {
                txtQuantity.Text = txtQuantity.Text.Substring(0, 5);
                txtQuantity.SelectionStart = txtQuantity.Text.Length;
            }
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Navigate to step 3 of event organization
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Event.frmOrganizeEventStep3 frm = new Event.frmOrganizeEventStep3(rosieEvent);
            frm.ShowDialog();
            /*AuntRosieApp.frmHome.formStep3.RosieEvent = rosieEvent;
            AuntRosieApp.frmHome.formStep3.Show();*/
        }
    }
}
