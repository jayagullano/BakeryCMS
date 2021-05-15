/**
 * @author Mervat Mustafa
 * @description This form used to manage the suppliers data
 * @since 2020-December
 */
using System;
 
using System.Windows.Forms;
using AuntRosieEntities;
using AuntRosieApplication.Classes;
namespace AuntRosieApplication.Inventory
{

    
    public partial class frmSupplier : Form
    {
        public   static String OpStatus = null;
        public static String ExOpStatus = null;
        public string thisOpStatus
        {
            get
            {
                return ExOpStatus;
            }
            set
            {
                if (ExOpStatus != value)
                    ExOpStatus = value;
            }
        }
        public frmSupplier()
        { this.DoubleBuffered = true;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SuppliersForm_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            pnlButton.Left = (this.Width - pnlButton.Width) / 2;
            Classes.DBMethod.FillProvinces(cmbProvinces);
            if (ExOpStatus == "newOnly")
            {
                btnNew_Click(sender, e);
            }
            else
            {
                Classes.DBMethod.FillCombBox(AuntRosieEntities.Supplier.GetAllSuppliers
                   (Classes.DBMethod.GetConnectionString()), cmbSupplierName);
                btnNew.Focus();
            }
            this.Visible = true;
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
            cmbSupplierName.Visible = false;
            txtName.Visible = true;
            clearTextBox();
            txtName.Focus();
           

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool isValid = false;
            bool OpIsSaved = true;
            errNmae.Clear();
            if (OpStatus== "new")
            {
                isValid = GetValidationStatus();
                if (isValid)
                {
                    newSupplier();
                    

                }
                else
                {
                    OpIsSaved = false;
                }
            }
            else 
            if (OpStatus == "edit")
            {

                isValid = GetValidationStatus();
                if (isValid)
                {
                   editSupplier();
                    cmbSupplierName.Items.Clear();
                    Classes.DBMethod.FillCombBox(AuntRosieEntities.Supplier.GetAllSuppliers
                                       (Classes.DBMethod.GetConnectionString()), cmbSupplierName);
                }
                else
                {
                    OpIsSaved = false;
                }


            }
            else
            if (OpStatus == "delete")
            {
                deleteSupplier();
                cmbSupplierName.Items.Clear();
                Classes.DBMethod.FillCombBox(AuntRosieEntities.Supplier.GetAllSuppliers
                   (Classes.DBMethod.GetConnectionString()), cmbSupplierName);

                OpIsSaved = true;
               


            }

            if (OpIsSaved)
            { if (ExOpStatus=="newOnly")
                {

                    this.Close();
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
                cmbSupplierName.Visible = false;
                cmbSupplierName.Items.Clear();
                Classes.DBMethod.FillCombBox(AuntRosieEntities.Supplier.GetAllSuppliers
             (Classes.DBMethod.GetConnectionString()), cmbSupplierName);
               
            }
             

        }

        #region Helper_Functions 

         private void clearTextBox()
        {
            txtName.Text = String.Empty;
            txtSupplierFirstName.Text = String.Empty;
            txtSupplierLastName.Text = String.Empty;
            txtPhone.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtPostalCode.Text = String.Empty;
            txtStreet.Text = String.Empty;
            cmbProvinces.Text = "";
            
            txtCity.Text = String.Empty;
        }
        private void newSupplier()
            {

            
                AuntRosieEntities.Supplier insertSupplier = new AuntRosieEntities.Supplier();
                insertSupplier.Name = txtName.Text.Trim();
                insertSupplier.ContactFirstName = txtSupplierFirstName.Text.Trim();
                insertSupplier.ContactLasttName = txtSupplierLastName.Text.Trim();
                insertSupplier.Phone = txtPhone.Text.Trim();
                insertSupplier.Email = txtEmail.Text.Trim();
                insertSupplier.City = txtCity.Text.Trim();
            AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
            Object obj = cmbProvinces.Items[cmbProvinces.SelectedIndex];
            itm = (AuntRosieApplication.Classes.ListItem)obj;
            insertSupplier.Province = itm.id;
                insertSupplier.Street = txtStreet.Text.Trim();
                insertSupplier.PostalCode = txtPostalCode.Text.Trim();
                      
            try {
                  
               DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                insertSupplier.Create();
                
               MessageBox.Show("The new supplier has been inserted successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
                   
            }
            catch (Exception ex){

                //MessageBox.Show(ex.Message);
               MessageBox.Show("Sorry! An internal error has happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
            }

                       
                
             
        }


        private void editSupplier()
        {


            AuntRosieEntities.Supplier updateSupplier = new AuntRosieEntities.Supplier();

            updateSupplier.Name = cmbSupplierName.Text;
            updateSupplier.ContactFirstName = txtSupplierFirstName.Text.Trim();
            updateSupplier.ContactLasttName = txtSupplierLastName.Text.Trim();
            updateSupplier.Phone = txtPhone.Text.Trim();
            updateSupplier.Email = txtEmail.Text.Trim();
            updateSupplier.City = txtCity.Text.Trim();
            AuntRosieApplication.Classes.ListItem itm = new AuntRosieApplication.Classes.ListItem();
            Object obj = cmbProvinces.Items[cmbProvinces.SelectedIndex];
            itm = (AuntRosieApplication.Classes.ListItem)obj;
            updateSupplier.Province = itm.id;
            updateSupplier.Street = txtStreet.Text.Trim();
            updateSupplier.PostalCode = txtPostalCode.Text.Trim();
            AuntRosieApplication.Classes.ListItem itm2 = new AuntRosieApplication.Classes.ListItem();
            object obj2=cmbSupplierName.Items[cmbSupplierName.SelectedIndex];
            itm2 = (AuntRosieApplication.Classes.ListItem)obj2;
            updateSupplier.Id = (long)Convert.ToDouble(itm2.id);

            try
            {

                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                updateSupplier.Update();

                MessageBox.Show("The supplier has been updated successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message);
                  MessageBox.Show("Sorry! An internal error has happened", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void deleteSupplier()
        {
             Supplier deleteSupplier= new Supplier ();
            AuntRosieApplication.Classes.ListItem itm2 = new AuntRosieApplication.Classes.ListItem();
            object obj2 = cmbSupplierName.Items[cmbSupplierName.SelectedIndex];
            itm2 = (AuntRosieApplication.Classes.ListItem)obj2;
           deleteSupplier.Id = (long)Convert.ToDouble(itm2.id);

            try
            {

                DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
                RosieEntity.Connector = conn;
                deleteSupplier.Delete();

                MessageBox.Show("The supplier has been deleted successfully", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
                  MessageBox.Show("This supplier could not be deleted ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
            private void TextBoxEnabled()
        {

            txtName.Enabled = true;
            txtSupplierFirstName.Enabled = true;
            txtSupplierLastName.Enabled = true;
            txtPhone.Enabled = true;
            txtEmail.Enabled = true;
            txtPostalCode.Enabled = true;
            txtStreet.Enabled = true;
            cmbProvinces.Enabled = true;
            txtCity.Enabled = true;
            

        }

       
        private void TextBoxDisEnabled()
        {

            txtName.Enabled = false;
            txtSupplierFirstName.Enabled = false;
            txtSupplierLastName.Enabled = false;
            txtPhone.Enabled = false;
            txtEmail.Enabled = false;
            txtPostalCode.Enabled = false;
            txtStreet.Enabled = false;
            cmbProvinces.Enabled = false;
            txtCity.Enabled = false;
            

        }

        private bool GetValidationStatus()
        {
            bool isValid = true;
            if (txtName.Text.Trim().Length<3)
            {
                errNmae.SetError(txtName, "Supplier name should be 3 letters at least");
                isValid = false;

            }
            if (txtSupplierFirstName.Text.Trim().Length < 3)
            {
                errFname.SetError(txtSupplierFirstName, "Supplier Contact first name should be 3 letters at least");
                isValid = false;

            }
            if (txtSupplierLastName.Text.Trim().Length <3)
            {
                errLname.SetError(txtSupplierLastName, "Supplier Contact last name should be 3 letters at least");
                isValid = false;

            }

            if ( ! DBMethod.IsValidEmail( txtEmail.Text.Trim()))
            {
                errNmae.SetError(txtEmail, "Entred Supplier Email is not a valid email address");
                isValid = false;

            }
            if (txtPhone.Text.Trim().Length !=14)
            {
                errPhone.SetError(txtPhone, "Entred Phone is not a valid phone number");
                isValid = false;

            }
            if (txtCity.Text.Trim().Length < 3)
            {
                errLname.SetError(txtCity, " City should be 3 letters at least");
                isValid = false;

            }
            if (cmbProvinces.Text.Trim().Length ==0)
            {
                errProvince.SetError(cmbProvinces, " Province could not be empty");
                isValid = false;

            }
            if (txtPostalCode.Text.Trim().Length !=6)
            {
                errPostal.SetError(txtPostalCode, "Entred Postalcode is not a valid postalcode");
                isValid = false;

            }


            return isValid;
        }
        #endregion

        private void cmbSupplierName_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            DBConnector conn = new DBConnector(Classes.DBMethod.GetConnectionString());
            RosieEntity.Connector = conn;
            Supplier supplier = Supplier.Retrieve(DBMethod.GetSelectedItemID(cmbSupplierName));

            txtName.Text = supplier.Name;
            txtSupplierFirstName.Text = supplier.ContactFirstName;
            txtSupplierLastName.Text=supplier.ContactLasttName ;
            txtPhone.Text = supplier.Phone;
            txtEmail.Text=supplier.Email;
            txtCity.Text = supplier.City;
            AuntRosieApplication.Classes.ListItem itm2 = new AuntRosieApplication.Classes.ListItem();
            itm2.id = supplier.Province;
            itm2.name = Classes.DBMethod.GetProvinceName(itm2.id);
            cmbProvinces.SelectedItem = itm2;
            cmbProvinces.Text = Classes.DBMethod.GetProvinceName(itm2.id);
            txtStreet.Text = supplier.Street;
             txtPostalCode.Text=supplier.PostalCode ;

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
            cmbSupplierName.Visible = true;
           
            cmbSupplierName.Focus();
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
            if (ExOpStatus == "newOnly")
            {
                this.Close();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

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
            cmbSupplierName.Visible = true;
            cmbSupplierName.Focus();
        }

        private void cmbProvinces_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPostalCode_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
