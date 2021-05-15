namespace AuntRosieApplication.Inventory
{
    partial class InventoryInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryInForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnNewTypeCancel = new System.Windows.Forms.Button();
            this.btnNewTypetSave = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.cmbNewtype = new System.Windows.Forms.ComboBox();
            this.btnNewIngredintCancel = new System.Windows.Forms.Button();
            this.btnNewIngredintSave = new System.Windows.Forms.Button();
            this.txtNewIngredintName = new System.Windows.Forms.TextBox();
            this.btnAddIngredint = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSubMain = new System.Windows.Forms.Panel();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.errInventoryIn = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlNewType = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtxNewType = new System.Windows.Forms.TextBox();
            this.pnlNewIngredint = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtstoringNote = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.auntRosieDBDataSet1 = new AuntRosieApplication.AuntRosieDBDataSet();
            this.pnlMain.SuspendLayout();
            this.pnlSubMain.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errInventoryIn)).BeginInit();
            this.pnlNewType.SuspendLayout();
            this.pnlNewIngredint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(41, 35);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(198, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inventory-In";
            // 
            // btnNewTypeCancel
            // 
            this.btnNewTypeCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTypeCancel.FlatAppearance.BorderSize = 0;
            this.btnNewTypeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTypeCancel.Image = global::AuntRosieApplication.Properties.Resources.eraser;
            this.btnNewTypeCancel.Location = new System.Drawing.Point(183, 140);
            this.btnNewTypeCancel.Name = "btnNewTypeCancel";
            this.btnNewTypeCancel.Size = new System.Drawing.Size(63, 55);
            this.btnNewTypeCancel.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnNewTypeCancel, "close without save");
            this.btnNewTypeCancel.UseVisualStyleBackColor = false;
            this.btnNewTypeCancel.Click += new System.EventHandler(this.btnNewTypeCancel_Click);
            // 
            // btnNewTypetSave
            // 
            this.btnNewTypetSave.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTypetSave.FlatAppearance.BorderSize = 0;
            this.btnNewTypetSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTypetSave.Image = global::AuntRosieApplication.Properties.Resources.save;
            this.btnNewTypetSave.Location = new System.Drawing.Point(119, 140);
            this.btnNewTypetSave.Name = "btnNewTypetSave";
            this.btnNewTypetSave.Size = new System.Drawing.Size(63, 55);
            this.btnNewTypetSave.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnNewTypetSave, "Save and close");
            this.btnNewTypetSave.UseVisualStyleBackColor = false;
            this.btnNewTypetSave.Click += new System.EventHandler(this.btnNewTypetSave_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.BackColor = System.Drawing.Color.Transparent;
            this.btnAddType.BackgroundImage = global::AuntRosieApplication.Properties.Resources.plus__2_;
            this.btnAddType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddType.FlatAppearance.BorderSize = 0;
            this.btnAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddType.Location = new System.Drawing.Point(348, 96);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(35, 31);
            this.btnAddType.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnAddType, "Add new  Ingredient Type");
            this.btnAddType.UseVisualStyleBackColor = false;
            this.btnAddType.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbNewtype
            // 
            this.cmbNewtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewtype.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNewtype.FormattingEnabled = true;
            this.cmbNewtype.Location = new System.Drawing.Point(132, 96);
            this.cmbNewtype.Name = "cmbNewtype";
            this.cmbNewtype.Size = new System.Drawing.Size(210, 31);
            this.cmbNewtype.TabIndex = 18;
            this.toolTip1.SetToolTip(this.cmbNewtype, "Choose the ingredient type");
            // 
            // btnNewIngredintCancel
            // 
            this.btnNewIngredintCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnNewIngredintCancel.FlatAppearance.BorderSize = 0;
            this.btnNewIngredintCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewIngredintCancel.Image = global::AuntRosieApplication.Properties.Resources.eraser;
            this.btnNewIngredintCancel.Location = new System.Drawing.Point(231, 258);
            this.btnNewIngredintCancel.Name = "btnNewIngredintCancel";
            this.btnNewIngredintCancel.Size = new System.Drawing.Size(63, 55);
            this.btnNewIngredintCancel.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnNewIngredintCancel, "Close without save");
            this.btnNewIngredintCancel.UseVisualStyleBackColor = false;
            this.btnNewIngredintCancel.Click += new System.EventHandler(this.btnNewIngredintCancel_Click);
            // 
            // btnNewIngredintSave
            // 
            this.btnNewIngredintSave.BackColor = System.Drawing.Color.Transparent;
            this.btnNewIngredintSave.FlatAppearance.BorderSize = 0;
            this.btnNewIngredintSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewIngredintSave.Image = global::AuntRosieApplication.Properties.Resources.save;
            this.btnNewIngredintSave.Location = new System.Drawing.Point(163, 258);
            this.btnNewIngredintSave.Name = "btnNewIngredintSave";
            this.btnNewIngredintSave.Size = new System.Drawing.Size(63, 55);
            this.btnNewIngredintSave.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnNewIngredintSave, "Save and close");
            this.btnNewIngredintSave.UseVisualStyleBackColor = false;
            this.btnNewIngredintSave.Click += new System.EventHandler(this.btnNewIngredintSave_Click);
            // 
            // txtNewIngredintName
            // 
            this.txtNewIngredintName.BackColor = System.Drawing.SystemColors.Info;
            this.txtNewIngredintName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtNewIngredintName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNewIngredintName.Location = new System.Drawing.Point(132, 64);
            this.txtNewIngredintName.Name = "txtNewIngredintName";
            this.txtNewIngredintName.Size = new System.Drawing.Size(210, 29);
            this.txtNewIngredintName.TabIndex = 17;
            this.toolTip1.SetToolTip(this.txtNewIngredintName, "Enter Ingredient name");
            // 
            // btnAddIngredint
            // 
            this.btnAddIngredint.BackColor = System.Drawing.Color.Transparent;
            this.btnAddIngredint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddIngredint.BackgroundImage")));
            this.btnAddIngredint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddIngredint.FlatAppearance.BorderSize = 0;
            this.btnAddIngredint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIngredint.Location = new System.Drawing.Point(437, 64);
            this.btnAddIngredint.Name = "btnAddIngredint";
            this.btnAddIngredint.Size = new System.Drawing.Size(34, 31);
            this.btnAddIngredint.TabIndex = 103;
            this.toolTip1.SetToolTip(this.btnAddIngredint, "Add new  Ingredient");
            this.btnAddIngredint.UseVisualStyleBackColor = false;
            this.btnAddIngredint.Click += new System.EventHandler(this.btnAddIngredint_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.BackColor = System.Drawing.Color.Transparent;
            this.btnAddSupplier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddSupplier.BackgroundImage")));
            this.btnAddSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddSupplier.FlatAppearance.BorderSize = 0;
            this.btnAddSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSupplier.Location = new System.Drawing.Point(437, 107);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(34, 31);
            this.btnAddSupplier.TabIndex = 105;
            this.toolTip1.SetToolTip(this.btnAddSupplier, "Add new Supplier");
            this.btnAddSupplier.UseVisualStyleBackColor = false;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::AuntRosieApplication.Properties.Resources.eraser;
            this.btnCancel.Location = new System.Drawing.Point(91, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 62);
            this.btnCancel.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnCancel, "Clear");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = global::AuntRosieApplication.Properties.Resources.plus_2_math;
            this.btnNew.Location = new System.Drawing.Point(3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(77, 62);
            this.btnNew.TabIndex = 0;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip1.SetToolTip(this.btnNew, "New");
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::AuntRosieApplication.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(170, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(77, 62);
            this.btnSave.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(541, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnClose, "Close the screen");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.pnlSubMain);
            this.pnlMain.Controls.Add(this.pnlButton);
            this.pnlMain.Location = new System.Drawing.Point(46, 68);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(531, 461);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pnlSubMain
            // 
            this.pnlSubMain.Controls.Add(this.lblUnit);
            this.pnlSubMain.Controls.Add(this.txtQuantity);
            this.pnlSubMain.Controls.Add(this.txtCost);
            this.pnlSubMain.Controls.Add(this.dtpExpiryDate);
            this.pnlSubMain.Controls.Add(this.dtpPurchaseDate);
            this.pnlSubMain.Controls.Add(this.label10);
            this.pnlSubMain.Controls.Add(this.label9);
            this.pnlSubMain.Controls.Add(this.cmbPaymentMethod);
            this.pnlSubMain.Controls.Add(this.label6);
            this.pnlSubMain.Controls.Add(this.label3);
            this.pnlSubMain.Controls.Add(this.label5);
            this.pnlSubMain.Controls.Add(this.label7);
            this.pnlSubMain.Controls.Add(this.btnAddIngredint);
            this.pnlSubMain.Controls.Add(this.btnAddSupplier);
            this.pnlSubMain.Controls.Add(this.cmbSupplier);
            this.pnlSubMain.Controls.Add(this.label2);
            this.pnlSubMain.Controls.Add(this.cmbType);
            this.pnlSubMain.Controls.Add(this.label1);
            this.pnlSubMain.Controls.Add(this.cmbName);
            this.pnlSubMain.Controls.Add(this.lblName);
            this.pnlSubMain.Location = new System.Drawing.Point(0, 3);
            this.pnlSubMain.Name = "pnlSubMain";
            this.pnlSubMain.Size = new System.Drawing.Size(528, 358);
            this.pnlSubMain.TabIndex = 100;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUnit.ForeColor = System.Drawing.Color.Sienna;
            this.lblUnit.Location = new System.Drawing.Point(413, 156);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(25, 22);
            this.lblUnit.TabIndex = 122;
            this.lblUnit.Text = "...";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.Info;
            this.txtQuantity.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtQuantity.Location = new System.Drawing.Point(183, 153);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(224, 29);
            this.txtQuantity.TabIndex = 4;
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.SystemColors.Info;
            this.txtCost.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtCost.Location = new System.Drawing.Point(183, 188);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(224, 29);
            this.txtCost.TabIndex = 6;
            this.txtCost.TextChanged += new System.EventHandler(this.txtCost_TextChanged);
            this.txtCost.Leave += new System.EventHandler(this.txtCost_Leave);
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiryDate.Location = new System.Drawing.Point(183, 307);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(281, 26);
            this.dtpExpiryDate.TabIndex = 8;
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPurchaseDate.Location = new System.Drawing.Point(183, 266);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(281, 26);
            this.dtpPurchaseDate.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Sienna;
            this.label10.Location = new System.Drawing.Point(44, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 22);
            this.label10.TabIndex = 121;
            this.label10.Tag = "";
            this.label10.Text = "Expiry Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Sienna;
            this.label9.Location = new System.Drawing.Point(22, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 22);
            this.label9.TabIndex = 120;
            this.label9.Tag = "";
            this.label9.Text = "Purchase Date";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.SystemColors.Info;
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(183, 223);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(281, 31);
            this.cmbPaymentMethod.TabIndex = 109;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(3, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 22);
            this.label6.TabIndex = 119;
            this.label6.Tag = "";
            this.label6.Text = "Payment Method";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(413, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 22);
            this.label3.TabIndex = 118;
            this.label3.Text = "CAD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(92, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 22);
            this.label5.TabIndex = 117;
            this.label5.Text = "Cost";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(73, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 22);
            this.label7.TabIndex = 112;
            this.label7.Text = "Quantity";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.BackColor = System.Drawing.SystemColors.Info;
            this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupplier.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(183, 107);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(235, 31);
            this.cmbSupplier.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(16, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 22);
            this.label2.TabIndex = 116;
            this.label2.Tag = "";
            this.label2.Text = "Supplier Name";
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.SystemColors.Info;
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(183, 18);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(235, 31);
            this.cmbType.TabIndex = 1;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 22);
            this.label1.TabIndex = 115;
            this.label1.Text = "Ingredient Type";
            // 
            // cmbName
            // 
            this.cmbName.BackColor = System.Drawing.SystemColors.Info;
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(183, 62);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(235, 31);
            this.cmbName.TabIndex = 2;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.Sienna;
            this.lblName.Location = new System.Drawing.Point(7, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(161, 22);
            this.lblName.TabIndex = 114;
            this.lblName.Text = "Ingredient Name";
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnNew);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Location = new System.Drawing.Point(166, 367);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(251, 67);
            this.pnlButton.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Sienna;
            this.label8.Location = new System.Drawing.Point(63, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 22);
            this.label8.TabIndex = 113;
            this.label8.Text = "Unit";
            // 
            // cmbUnit
            // 
            this.cmbUnit.AutoCompleteCustomSource.AddRange(new string[] {
            "Pies",
            "Preserves"});
            this.cmbUnit.BackColor = System.Drawing.SystemColors.Info;
            this.cmbUnit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "Kg",
            "g",
            "ml",
            "L",
            "lb",
            "oz",
            "item"});
            this.cmbUnit.Location = new System.Drawing.Point(132, 133);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(112, 31);
            this.cmbUnit.TabIndex = 5;
            // 
            // errInventoryIn
            // 
            this.errInventoryIn.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errInventoryIn.ContainerControl = this;
            // 
            // pnlNewType
            // 
            this.pnlNewType.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            this.pnlNewType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNewType.Controls.Add(this.label12);
            this.pnlNewType.Controls.Add(this.btnNewTypeCancel);
            this.pnlNewType.Controls.Add(this.btnNewTypetSave);
            this.pnlNewType.Controls.Add(this.label11);
            this.pnlNewType.Controls.Add(this.txtxNewType);
            this.pnlNewType.Location = new System.Drawing.Point(583, 80);
            this.pnlNewType.Name = "pnlNewType";
            this.pnlNewType.Size = new System.Drawing.Size(379, 245);
            this.pnlNewType.TabIndex = 22;
            this.pnlNewType.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Goldenrod;
            this.label12.Location = new System.Drawing.Point(67, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(241, 22);
            this.label12.TabIndex = 102;
            this.label12.Tag = "";
            this.label12.Text = "Add New Ingredient Type";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Sienna;
            this.label11.Location = new System.Drawing.Point(43, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 22);
            this.label11.TabIndex = 103;
            this.label11.Text = "Type";
            // 
            // txtxNewType
            // 
            this.txtxNewType.BackColor = System.Drawing.SystemColors.Info;
            this.txtxNewType.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtxNewType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtxNewType.Location = new System.Drawing.Point(105, 98);
            this.txtxNewType.Name = "txtxNewType";
            this.txtxNewType.Size = new System.Drawing.Size(208, 29);
            this.txtxNewType.TabIndex = 23;
            this.txtxNewType.TextChanged += new System.EventHandler(this.txtxNewType_TextChanged);
            // 
            // pnlNewIngredint
            // 
            this.pnlNewIngredint.BackColor = System.Drawing.Color.LemonChiffon;
            this.pnlNewIngredint.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            this.pnlNewIngredint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNewIngredint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewIngredint.Controls.Add(this.btnAddType);
            this.pnlNewIngredint.Controls.Add(this.label13);
            this.pnlNewIngredint.Controls.Add(this.label16);
            this.pnlNewIngredint.Controls.Add(this.txtstoringNote);
            this.pnlNewIngredint.Controls.Add(this.cmbNewtype);
            this.pnlNewIngredint.Controls.Add(this.label15);
            this.pnlNewIngredint.Controls.Add(this.btnNewIngredintCancel);
            this.pnlNewIngredint.Controls.Add(this.btnNewIngredintSave);
            this.pnlNewIngredint.Controls.Add(this.label14);
            this.pnlNewIngredint.Controls.Add(this.txtNewIngredintName);
            this.pnlNewIngredint.Controls.Add(this.label8);
            this.pnlNewIngredint.Controls.Add(this.cmbUnit);
            this.pnlNewIngredint.Location = new System.Drawing.Point(583, 360);
            this.pnlNewIngredint.Name = "pnlNewIngredint";
            this.pnlNewIngredint.Size = new System.Drawing.Size(465, 337);
            this.pnlNewIngredint.TabIndex = 16;
            this.pnlNewIngredint.Visible = false;
            this.pnlNewIngredint.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNewIngredint_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Goldenrod;
            this.label13.Location = new System.Drawing.Point(117, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(195, 22);
            this.label13.TabIndex = 102;
            this.label13.Tag = "";
            this.label13.Text = "Add New Ingredient ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Sienna;
            this.label16.Location = new System.Drawing.Point(65, 177);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 22);
            this.label16.TabIndex = 105;
            this.label16.Text = "Storing Notes";
            // 
            // txtstoringNote
            // 
            this.txtstoringNote.BackColor = System.Drawing.SystemColors.Info;
            this.txtstoringNote.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtstoringNote.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtstoringNote.Location = new System.Drawing.Point(133, 202);
            this.txtstoringNote.Multiline = true;
            this.txtstoringNote.Name = "txtstoringNote";
            this.txtstoringNote.Size = new System.Drawing.Size(234, 50);
            this.txtstoringNote.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Sienna;
            this.label15.Location = new System.Drawing.Point(63, 105);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 22);
            this.label15.TabIndex = 102;
            this.label15.Text = "Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Sienna;
            this.label14.Location = new System.Drawing.Point(63, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 22);
            this.label14.TabIndex = 103;
            this.label14.Text = "Name";
            // 
            // auntRosieDBDataSet1
            // 
            this.auntRosieDBDataSet1.DataSetName = "AuntRosieDBDataSet";
            this.auntRosieDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InventoryInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 569);
            this.Controls.Add(this.pnlNewType);
            this.Controls.Add(this.pnlNewIngredint);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryInForm";
            this.Activated += new System.EventHandler(this.InventoryInForm_Activated);
            this.Load += new System.EventHandler(this.InventoryInForm_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlSubMain.ResumeLayout(false);
            this.pnlSubMain.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errInventoryIn)).EndInit();
            this.pnlNewType.ResumeLayout(false);
            this.pnlNewType.PerformLayout();
            this.pnlNewIngredint.ResumeLayout(false);
            this.pnlNewIngredint.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlNewType;
        private System.Windows.Forms.Button btnNewTypeCancel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNewTypetSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtxNewType;
        private System.Windows.Forms.Panel pnlNewIngredint;
        private System.Windows.Forms.Button btnNewIngredintCancel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnNewIngredintSave;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNewIngredintName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtstoringNote;
        private System.Windows.Forms.ComboBox cmbNewtype;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Panel pnlSubMain;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddIngredint;
        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ErrorProvider errInventoryIn;
        private AuntRosieDBDataSet auntRosieDBDataSet1;
        private System.Windows.Forms.Label lblUnit;
    }
}