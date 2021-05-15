namespace AuntRosieApplication.Inventory
{
    partial class frmSupplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.cmbProvinces = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSupplierFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSupplierLastName = new System.Windows.Forms.TextBox();
            this.cmbSupplierName = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.errNmae = new System.Windows.Forms.ErrorProvider(this.components);
            this.errFname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errLname = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errProvince = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.errStreet = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPostal = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNmae)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvince)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPostal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(34, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(157, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Suppliers";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Sienna;
            this.lblName.Location = new System.Drawing.Point(94, 111);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(145, 22);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Supplier Name";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(132, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 46;
            this.label3.Text = "Street";
            // 
            // txtStreet
            // 
            this.txtStreet.Enabled = false;
            this.txtStreet.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.Location = new System.Drawing.Point(216, 94);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(275, 29);
            this.txtStreet.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Enabled = false;
            this.txtCity.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(216, 59);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(275, 29);
            this.txtCity.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(155, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 22);
            this.label5.TabIndex = 43;
            this.label5.Text = "City";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(113, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 42;
            this.label6.Text = "Province";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtPostalCode);
            this.groupBox1.Controls.Add(this.cmbProvinces);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtStreet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCity);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox1.Location = new System.Drawing.Point(32, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 173);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Address";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Enabled = false;
            this.txtPostalCode.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.Location = new System.Drawing.Point(216, 136);
            this.txtPostalCode.Mask = "L0L0L0";
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(275, 29);
            this.txtPostalCode.TabIndex = 10;
            this.txtPostalCode.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPostalCode_MaskInputRejected);
            // 
            // cmbProvinces
            // 
            this.cmbProvinces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvinces.Enabled = false;
            this.cmbProvinces.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvinces.FormattingEnabled = true;
            this.cmbProvinces.ItemHeight = 23;
            this.cmbProvinces.Location = new System.Drawing.Point(216, 26);
            this.cmbProvinces.Name = "cmbProvinces";
            this.cmbProvinces.Size = new System.Drawing.Size(275, 31);
            this.cmbProvinces.TabIndex = 7;
            this.cmbProvinces.SelectedIndexChanged += new System.EventHandler(this.cmbProvinces_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(80, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 47;
            this.label1.Text = "Postal Code";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtSupplierFirstName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSupplierLastName);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Goldenrod;
            this.groupBox2.Location = new System.Drawing.Point(32, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(558, 173);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Information";
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(216, 94);
            this.txtPhone.Mask = "(999)-000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(275, 29);
            this.txtPhone.TabIndex = 4;
            this.txtPhone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPhone_MaskInputRejected);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Sienna;
            this.label8.Location = new System.Drawing.Point(140, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 22);
            this.label8.TabIndex = 48;
            this.label8.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(216, 129);
            this.txtEmail.MaxLength = 255;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 29);
            this.txtEmail.TabIndex = 5;
            // 
            // txtSupplierFirstName
            // 
            this.txtSupplierFirstName.Enabled = false;
            this.txtSupplierFirstName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierFirstName.Location = new System.Drawing.Point(216, 19);
            this.txtSupplierFirstName.MaxLength = 50;
            this.txtSupplierFirstName.Name = "txtSupplierFirstName";
            this.txtSupplierFirstName.Size = new System.Drawing.Size(275, 29);
            this.txtSupplierFirstName.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Sienna;
            this.label9.Location = new System.Drawing.Point(132, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 22);
            this.label9.TabIndex = 46;
            this.label9.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Sienna;
            this.label10.Location = new System.Drawing.Point(98, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 22);
            this.label10.TabIndex = 42;
            this.label10.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Sienna;
            this.label11.Location = new System.Drawing.Point(96, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 22);
            this.label11.TabIndex = 43;
            this.label11.Text = "Last Name";
            // 
            // txtSupplierLastName
            // 
            this.txtSupplierLastName.Enabled = false;
            this.txtSupplierLastName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierLastName.Location = new System.Drawing.Point(216, 59);
            this.txtSupplierLastName.MaxLength = 50;
            this.txtSupplierLastName.Name = "txtSupplierLastName";
            this.txtSupplierLastName.Size = new System.Drawing.Size(275, 29);
            this.txtSupplierLastName.TabIndex = 3;
            // 
            // cmbSupplierName
            // 
            this.cmbSupplierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplierName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplierName.FormattingEnabled = true;
            this.cmbSupplierName.Location = new System.Drawing.Point(248, 74);
            this.cmbSupplierName.Name = "cmbSupplierName";
            this.cmbSupplierName.Size = new System.Drawing.Size(275, 31);
            this.cmbSupplierName.TabIndex = 0;
            this.toolTip1.SetToolTip(this.cmbSupplierName, "Choose the supplier name");
            this.cmbSupplierName.Visible = false;
            this.cmbSupplierName.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierName_SelectedIndexChanged);
            // 
            // btnClancel
            // 
            this.btnClancel.BackColor = System.Drawing.Color.Transparent;
            this.btnClancel.Enabled = false;
            this.btnClancel.FlatAppearance.BorderSize = 0;
            this.btnClancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClancel.Image = global::AuntRosieApplication.Properties.Resources.eraser;
            this.btnClancel.Location = new System.Drawing.Point(250, 1);
            this.btnClancel.Name = "btnClancel";
            this.btnClancel.Size = new System.Drawing.Size(79, 61);
            this.btnClancel.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnClancel, "Cancel");
            this.btnClancel.UseVisualStyleBackColor = false;
            this.btnClancel.Click += new System.EventHandler(this.btnClancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = global::AuntRosieApplication.Properties.Resources.plus_2_math;
            this.btnNew.Location = new System.Drawing.Point(3, 1);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(79, 61);
            this.btnNew.TabIndex = 11;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip1.SetToolTip(this.btnNew, "New");
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::AuntRosieApplication.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(88, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 61);
            this.btnEdit.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::AuntRosieApplication.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(335, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 61);
            this.btnSave.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::AuntRosieApplication.Properties.Resources.delete_sign;
            this.btnDelete.Location = new System.Drawing.Point(166, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 61);
            this.btnDelete.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(537, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnClose, "Close the screen");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlButton.Controls.Add(this.btnClancel);
            this.pnlButton.Controls.Add(this.btnNew);
            this.pnlButton.Controls.Add(this.btnEdit);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Controls.Add(this.btnDelete);
            this.pnlButton.Location = new System.Drawing.Point(98, 495);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(425, 66);
            this.pnlButton.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(248, 111);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(275, 29);
            this.txtName.TabIndex = 1;
            // 
            // errNmae
            // 
            this.errNmae.ContainerControl = this;
            // 
            // errFname
            // 
            this.errFname.ContainerControl = this;
            // 
            // errLname
            // 
            this.errLname.ContainerControl = this;
            // 
            // errPhone
            // 
            this.errPhone.ContainerControl = this;
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            // 
            // errProvince
            // 
            this.errProvince.ContainerControl = this;
            // 
            // errCity
            // 
            this.errCity.ContainerControl = this;
            // 
            // errStreet
            // 
            this.errStreet.ContainerControl = this;
            // 
            // errPostal
            // 
            this.errPostal.ContainerControl = this;
            // 
            // frmSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(636, 583);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbSupplierName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuppliersForm";
            this.Load += new System.EventHandler(this.SuppliersForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errNmae)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvince)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPostal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSupplierFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSupplierLastName;
        private System.Windows.Forms.ComboBox cmbSupplierName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnClancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ErrorProvider errNmae;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbProvinces;
        private System.Windows.Forms.ErrorProvider errFname;
        private System.Windows.Forms.ErrorProvider errLname;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.ErrorProvider errPhone;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errProvince;
        private System.Windows.Forms.ErrorProvider errCity;
        private System.Windows.Forms.ErrorProvider errStreet;
        private System.Windows.Forms.ErrorProvider errPostal;
        private System.Windows.Forms.MaskedTextBox txtPostalCode;
    }
}