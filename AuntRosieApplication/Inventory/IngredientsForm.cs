/**
 * @author Mervat Mustafa
 * @description This form used to manage the ingredient data

 * @since 2020-December
 */
 
using System;
 
using System.Windows.Forms;
using AuntRosieEntities;
using AuntRosieApplication.Classes;
namespace AuntRosieApplication.Inventory
{

    public partial class frmIngredients : Form
    {
        public static String OpStatus = null;
        public frmIngredients()
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

        private void frmIngredients_Load(object sender, EventArgs e)
        {
            
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
             TextBoxDisEnabled();
            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            pnlButton.Left = (this.Width - pnlButton.Width) / 2;
            this.Visible = true;
            cmbType.Items.Clear();
            Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
                 (Classes.DBMethod.GetConnectionString()), cmbType);
           
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNewTypetSave_Click(object sender, EventArgs e)
        {
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

            }

            else
            {
                errMeesage.SetError(txtxNewType, "Ingredient Type Name could not contain less than 3 character");
                txtxNewType.Focus();
            }
        }

        private void pnlNewType_Paint(object sender, PaintEventArgs e)
        {

        }

        private void newIngredient()
        {
            Ingredient newIngredient = new Ingredient();
            if (IsValidIngredent())
            {
                try
                {
                    newIngredient.Name = txtNewIngredintName.Text.Trim();
                    newIngredient.IngredientTypeId = (short)Convert.ToDouble(DBMethod.GetSelectedItemID(cmbType));
                    newIngredient.StoringNote = txtstoringNote.Text;
                    newIngredient.Unit = cmbUnit.Text.Trim();
                    DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                    RosieEntity.Connector = conn;
                    newIngredient.Create();

                    pnlMain.Enabled = true;


                
                   MessageBox.Show("New ingredient has been inserted successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                catch (Exception ex)
                {

                    // MessageBox.Show(ex.Message);
                    MessageBox.Show("Sorry! An internal error has happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }





            }

        }
        private bool IsValidIngredent()
        {
            bool isvalid = true;
            if (txtNewIngredintName.Text.Length < 3)
            {
                isvalid = false;
                errMeesage.SetError(txtNewIngredintName, "Ingredient Name could not be less than 3 letters");
            }
            if (cmbType.Text.Length == 0)
            {
                isvalid = false;
                errMeesage.SetError(cmbType, "Ingredient should has a type");

            }
            if (txtstoringNote.Text.Length == 0)
            {
                isvalid = false;
                errMeesage.SetError(txtstoringNote, "Sorting note could not be empty");

            }
            if (cmbUnit.SelectedItem == null)
            {
                errMeesage.SetError(cmbUnit, "Please check the qunity value, it should be numeric");
                isvalid = false;
            }
            return isvalid;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbName.Items.Clear();
            Classes.DBMethod.FillCombBox(AuntRosieEntities.Ingredient.GetAllIngredintsByType
              (Classes.DBMethod.GetConnectionString(), DBMethod.GetSelectedItemID(cmbType)), cmbName);
            cmbName.Enabled = true;
            cmbName.Focus();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            
             
            if (OpStatus == "new")
            {
                 
                    newIngredient();
                   
                 
            }
            else
            if (OpStatus == "edit")
            {

                 
                    editIngredient();
                    

            }
            else
            if (OpStatus == "delete")
            {
                deleteIngredient();
                 


            }

            TextBoxDisEnabled();
            btnClancel.Enabled = false;
            btnSave.Enabled = false;
            btnNew.Focus();
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnNew.Focus();
            clearTextBox();
            cmbName.Visible = false;
            cmbName.Items.Clear();
           


        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            OpStatus = "new";
            TextBoxEnabled();
            btnClancel.Enabled = true;
            btnSave.Enabled = true;
            btnSave.Focus();
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            cmbName.Visible = false;
           txtNewIngredintName.Visible = true;
            clearTextBox();
            txtNewIngredintName.Focus();
            btnAddType.Visible = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            OpStatus = "edit";
            TextBoxEnabled();
            btnClancel.Enabled = true;
            btnSave.Enabled = true;
            btnSave.Focus();
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnAddType.Visible = false;
            cmbName.Visible = true;

            cmbType.Focus();
            cmbName.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OpStatus = "delete";
            TextBoxDisEnabled();
            btnClancel.Enabled = true;
            btnSave.Enabled = true;
            btnSave.Focus();
            btnNew.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            cmbName.Visible = true;
            btnAddType.Visible = false;
            cmbName.Focus();
        }

        private void TextBoxDisEnabled()
        {
            cmbName.Enabled = false;
            cmbType.Enabled = false;
            txtNewIngredintName.Enabled = false;
            txtstoringNote.Enabled = false;
            btnAddType.Enabled = false;
        }
        private void TextBoxEnabled()
        {
            cmbName.Enabled = true;
            cmbType.Enabled = true;
            txtNewIngredintName.Enabled = true;
            txtstoringNote.Enabled = true;
            btnAddType.Enabled = true;

        }
        private void clearTextBox()
        {

            cmbName.Text = string.Empty;
           
            txtNewIngredintName.Text = string.Empty;
            txtstoringNote.Text = string.Empty;
            cmbType.Items.Clear();
            Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
                 (Classes.DBMethod.GetConnectionString()), cmbType);



        }

        private void btnAddType_Click(object sender, EventArgs e)
        {
            pnlNewType.Top = (this.Height - pnlNewType.Height) / 2;
            pnlNewType.Left = (this.Width - pnlNewType.Width) / 2;
            pnlNewType.Visible = true;
        }
        public void editIngredient()
        {

            AuntRosieEntities.Ingredient updateIngredient = new AuntRosieEntities.Ingredient();

            updateIngredient.Name = txtNewIngredintName.Text;
            updateIngredient.StoringNote = txtstoringNote.Text;
            updateIngredient.Unit = cmbUnit.Text.Trim();
             
       
            AuntRosieApplication.Classes.ListItem itm2 = new AuntRosieApplication.Classes.ListItem();
            object obj2 = cmbName.Items[cmbName.SelectedIndex];
            itm2 = (AuntRosieApplication.Classes.ListItem)obj2;
            updateIngredient.Id = (long)Convert.ToDouble(itm2.id);

            try
            {

                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                updateIngredient.Update();

                MessageBox.Show("The Ingredient has been updated successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

                  MessageBox.Show(ex.Message);
               // MessageBox.Show("Sorry! An internal error has happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public void deleteIngredient()
        {
            Ingredient deleteIngredient = new Ingredient();
            AuntRosieApplication.Classes.ListItem itm2 = new AuntRosieApplication.Classes.ListItem();
            object obj2 = cmbName.Items[cmbName.SelectedIndex];
            itm2 = (AuntRosieApplication.Classes.ListItem)obj2;
            deleteIngredient.Id = (long)Convert.ToDouble(itm2.id);

            try
            {

                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                deleteIngredient.Delete();

                MessageBox.Show("The Ingredient has been deleted successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                 MessageBox.Show("This ingredients could not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnNewTypeCancel_Click(object sender, EventArgs e)
        {
            pnlNewType.Visible = false;
            pnlMain.Enabled = true;
            cmbType.Items.Clear();
            Classes.DBMethod.FillCombBox(AuntRosieEntities.IngredientType.GetAllIngredintType
                 (Classes.DBMethod.GetConnectionString()), cmbType);
       
                  cmbType.SelectedItem = cmbType.Items[cmbType.Items.Count - 1];
        }

        private void btnClancel_Click(object sender, EventArgs e)
        {
            TextBoxDisEnabled();
            btnClancel.Enabled = false;
            btnSave.Enabled = false;
            btnNew.Focus();
            btnNew.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnNew.Focus();
            clearTextBox();
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                
                Ingredient ingredent = Ingredient.Retrieve((long)Convert.ToDouble(DBMethod.GetSelectedItemID(cmbName)));

                txtNewIngredintName.Text = ingredent.Name;
                txtstoringNote.Text = ingredent.StoringNote;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             
           
        }
    }
}
