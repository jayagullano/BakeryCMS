/**
 * @author Mervat Mustafa
 * @description This form used to enter the ingrdient to inventory
 * @since 2020-December
 */
using System;
 
using System.Windows.Forms;
using AuntRosieEntities;
using AuntRosieApplication.Classes;
namespace AuntRosieApplication.Inventory
{
    public partial class InventoryInForm : Form
    {
        public static String OpStatus = null;
        public bool SupplierFlag = false;
        public bool isNewIngrdent = false;
        public InventoryInForm()
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
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
       
            pnlMain.Enabled = false;
            ViewPanel(pnlNewType);
            txtxNewType.Focus();
        }

        #region helppr-functions
        private void ViewPanel(Panel pnl)
        {
            pnl.Top = (this.Height - pnl.Height) / 2;
            pnl.Left = (this.Width - pnl.Width) / 2;
            pnl.Visible = true;
        }
         private bool IsValidIngredent ()
        {
            bool isvalid = true;
            if (txtNewIngredintName.Text.Length < 3)
            {
                isvalid = false;
                errInventoryIn.SetError(txtNewIngredintName, "Ingredient Name could not be less than 3 letters");
            }
            if (cmbNewtype.Text.Length ==0)
            {
                isvalid = false;
                errInventoryIn.SetError(cmbNewtype, "Ingredient should has a type");

            }
            if (txtstoringNote.Text.Length == 0)
            {
                isvalid = false;
                errInventoryIn.SetError(txtstoringNote, "Sorting note could not be empty");

            }
            if (cmbUnit.SelectedItem == null)
            {
                errInventoryIn.SetError(cmbUnit, "Please check the qunity value, it should be numeric");
                isvalid = false;
            }

            return isvalid;
        }
         
        #endregion

        private void btnNewIngredintCancel_Click(object sender, EventArgs e)
        {
            pnlNewIngredint.Visible = false;
            pnlMain.Enabled = true;
        }

        private void btnNewIngredintClose_Click(object sender, EventArgs e)
        {
            pnlNewIngredint.Visible = false;
            pnlMain.Enabled = true;
            cmbName.Focus();
        }

        private void btnNewTypeClose_Click(object sender, EventArgs e)
        {
            pnlNewType.Visible = false;
            pnlMain.Enabled = true;
            cmbType.Focus();
        }

        private void btnAddIngredint_Click(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            cmbNewtype.Items.Clear();
            Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
                 (Classes.DBMethod.GetConnectionString()), cmbNewtype);
            ViewPanel(pnlNewIngredint);

        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Inventory.frmSupplier form = new Inventory.frmSupplier();
            form.thisOpStatus = "newOnly";
            form.ShowDialog();
            SupplierFlag = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InventoryInForm_Load(object sender, EventArgs e)
        {
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            pnlButton.Left = (this.Width - pnlButton.Width) / 2;
            pnlMain.Left = (this.Width - pnlMain.Width) / 2;
            pnlSubMain.Enabled = false;
            btnNew.Focus();
            DBMethod.relocation(pnlNewType, this);
            DBMethod.relocation(pnlNewIngredint, this);
           this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            cmbType.Items.Clear();
          Classes.DBMethod.FillCombBox( AuntRosieEntities.IngredientType.GetAllIngredintType
               (Classes.DBMethod.GetConnectionString()),cmbType);
            cmbNewtype.Items.Clear();
            Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
               (Classes.DBMethod.GetConnectionString()), cmbNewtype);
            cmbSupplier.Items.Clear();
            Classes.DBMethod.FillCombBox(AuntRosieEntities.Supplier.GetAllSuppliers
                (Classes.DBMethod.GetConnectionString()), cmbSupplier);

            Classes.DBMethod.FillPaymentmethodCombo(cmbPaymentMethod);

            this.Visible = true;
        }

        private void btnNewIngredintClose_Click_1(object sender, EventArgs e)
        {
            pnlNewType.Visible = false;
            pnlMain.Enabled = true;
        }

        private void btnNewTypetClear_Click(object sender, EventArgs e)
        {

        }

        private void btnNewTypeCancel_Click(object sender, EventArgs e)
        {
            pnlNewType.Visible = false;
            pnlNewIngredint.Visible = true;
        }

        private void txtxNewType_TextChanged(object sender, EventArgs e)
        {
            if (txtxNewType.Text.Length>=3)
            {
                btnNewTypetSave.Enabled = true;
            }
            else
            {
                btnNewTypetSave.Enabled = false;
            }
        }

        private void btnNewTypetSave_Click(object sender, EventArgs e)
        {
            pnlNewIngredint.Visible = true;
            IngredientType newType = new IngredientType();
            if (txtxNewType.Text.Length >= 3)
            {
                newType.Name = txtxNewType.Text;
                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;

                newType.Create();
                pnlNewType.Visible = false;
                pnlMain.Enabled = true; 

                cmbType.Items.Clear();
                Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
                     (Classes.DBMethod.GetConnectionString()), cmbType);
                cmbType.SelectedItem = cmbType.Items[cmbType.Items.Count - 1];
                
                 


                cmbNewtype.Items.Clear();
                Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
                     (Classes.DBMethod.GetConnectionString()), cmbNewtype);
                cmbNewtype.SelectedItem = cmbNewtype.Items[cmbNewtype.Items.Count - 1];

            }

            else
            {
                errInventoryIn.SetError(txtxNewType, "Ingredient Type Name could not contain less than 3 character");
                txtxNewType.Focus();
            }
        }

 

        private void InventoryInForm_Activated(object sender, EventArgs e)
        {   if (SupplierFlag)
            {
        
            cmbSupplier.Items.Clear();
                cmbSupplier.Items.Clear();
            Classes.DBMethod.FillCombBox(AuntRosieEntities.Supplier.GetAllSuppliers
                (Classes.DBMethod.GetConnectionString()), cmbSupplier);

                cmbSupplier.SelectedItem = cmbSupplier.Items[cmbSupplier.Items.Count - 1];

            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            OpStatus = "new";
            pnlSubMain.Enabled = true; ;
            btnCancel.Enabled = true;
            btnSave.Enabled = true;
            cmbType.Focus();
            btnNew.Enabled = false;
             
           
             
            
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbName.Items.Clear();
            Classes.DBMethod.FillCombBox(AuntRosieEntities.Ingredient.GetAllIngredintsByType
              (Classes.DBMethod.GetConnectionString(), DBMethod.GetSelectedItemID(cmbType)), cmbName);
        }

        private void btnNewIngredintSave_Click(object sender, EventArgs e)
        {
            Ingredient newIngredient = new Ingredient();
            if (IsValidIngredent())
            {
                newIngredient.Name = txtNewIngredintName.Text.Trim();
                newIngredient.Unit = cmbUnit.Text.Trim();
                newIngredient.IngredientTypeId = (short) Convert.ToDouble(DBMethod.GetSelectedItemID(cmbNewtype)) ;
                newIngredient.StoringNote = txtstoringNote.Text;
                newIngredient.Unit = cmbUnit.Text.Trim();
                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                newIngredient.Create();
                pnlNewIngredint.Visible = false;
                pnlMain.Enabled = true;

                cmbType.Items.Clear();
                Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
                    (Classes.DBMethod.GetConnectionString()), cmbType);

                AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
                Object obj = cmbType.Items[cmbNewtype.SelectedIndex];
                itm = (Classes.ListItem)obj;

                cmbType.SelectedItem = itm;
              
                   cmbName.SelectedItem = cmbName.Items[cmbName.Items.Count - 1];


            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlNewIngredint.Visible = false;
            ViewPanel( pnlNewType);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

           if (isValidEntery())
            {
                try
                {
                    InventoryIngredient InsertInventoryIngredient = new InventoryIngredient();
                    InsertInventoryIngredient.IngredientID = (long)Convert.ToDouble(DBMethod.GetSelectedItemID(cmbName));
                    InsertInventoryIngredient.SupplierId = (long)Convert.ToDouble(DBMethod.GetSelectedItemID(cmbSupplier));
                    InsertInventoryIngredient.ThisPaymentMethod = DBMethod.GetSelectedItemID(cmbPaymentMethod);
                    InsertInventoryIngredient.PurchaseDate = dtpPurchaseDate.Value;
                    InsertInventoryIngredient.ExpiryDate = dtpExpiryDate.Value;
                    InsertInventoryIngredient.Quantity = Convert.ToDouble(txtQuantity.Text.Trim());
                    InsertInventoryIngredient.Cost = Convert.ToDouble(txtCost.Text.Trim());
                    InsertInventoryIngredient.UnitPrice = Convert.ToDouble(txtCost.Text.Trim()) / Convert.ToDouble(txtQuantity.Text.Trim());
                     DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                    RosieEntity.Connector = conn;
                    InsertInventoryIngredient.Create();
                    clearData();
                    MessageBox.Show("The ingredient quantity has successfully stocked into the inventory", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                  MessageBox.Show("Sorry! An internal error has happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
             
        }
         private bool isValidEntery()
        {
            bool isValid = true;
            if (cmbName.SelectedItem==null)
            {
                errInventoryIn.SetError(cmbName, "Choose the ingredent name ");
                isValid = false;

            }
            if (cmbType.SelectedItem == null)
            {
                errInventoryIn.SetError(cmbType, "Choose the ingredent Type ");
                isValid = false;

            }
            if (cmbSupplier.SelectedItem == null)
            {
                errInventoryIn.SetError(cmbSupplier, "Choose the  supplier ");
                isValid = false;

            }
            if (cmbPaymentMethod.SelectedItem == null)
            {
               errInventoryIn.SetError(cmbPaymentMethod, "Choose the  supplier ");
                isValid = false;

            }
            if  (dtpPurchaseDate.Value.Date > DateTime.Today.Date)
            {
                MessageBox.Show(dtpPurchaseDate.Value + "'" + DateTime.Today);
                errInventoryIn.SetError(dtpPurchaseDate, "Please check the purchase date, the date could not be after today");
                isValid = false;

            }
            if (dtpExpiryDate.Value.Date < DateTime.Today.Date)
            {
                errInventoryIn.SetError(dtpExpiryDate, "Please check the expiry date, the date could not be before today");
                isValid = false;

            }
            double x;
            if (!double.TryParse(txtCost.Text, out x)) {
                errInventoryIn.SetError(txtCost, "Please check the cost value, , it should be numeric");
                isValid = false; }
            if (!double.TryParse(txtQuantity.Text, out x))
            {
                errInventoryIn.SetError(txtQuantity, "Please check the qunity value, it should be numeric");
                isValid = false;
            }

           
            return isValid;
        }
        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearData();



        }

        private void txtCost_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCost_Leave(object sender, EventArgs e)
        {
            double cost;
            if (txtCost.Text.Trim().Length > 0)
            {
                if (double.TryParse(txtCost.Text, out cost))
                {
                    txtCost.Text = string.Format("{0:0.00}", cost);
                }
            }

        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            double qun;
            if (txtQuantity.Text.Trim().Length > 0)
            {
                if (double.TryParse(txtQuantity.Text, out qun))
                {
                    txtQuantity.Text = string.Format("{0:0.00}", qun);
                }
            }

        }
         private void clearData()
        {
            btnNew.Enabled = true;
            btnNew.Focus();
            pnlSubMain.Enabled = false;
            cmbName.SelectedItem = null;
            cmbType.SelectedItem = null;
            cmbSupplier.SelectedItem = null;
            txtQuantity.Text = string.Empty;
            txtCost.Text = string.Empty;
            cmbPaymentMethod.SelectedItem = null;
            dtpPurchaseDate.Value = DateTime.Today;
            dtpExpiryDate.Value = DateTime.Today;
            btnCancel.Enabled = false;
            btnSave.Enabled = false;



        }
        private void pnlNewIngredint_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbName.SelectedItem != null)
            {
                try
                {
                    DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                    RosieEntity.Connector = conn;

                    Ingredient ingredent = Ingredient.Retrieve((long)Convert.ToDouble(DBMethod.GetSelectedItemID(cmbName)));

                    lblUnit.Text = ingredent.Unit;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }
    }
}
