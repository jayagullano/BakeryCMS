namespace AuntRosieApplication.Event
{
    partial class frmSale
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblItemPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ndpQuanitity = new System.Windows.Forms.NumericUpDown();
            this.lblTotalVallue = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.LblTotalPrice = new System.Windows.Forms.Label();
            this.lblTotalNumberOfItem = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grdSale = new System.Windows.Forms.DataGridView();
            this.EventProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.saleDetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSet = new AuntRosieApplication.ReportDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkGuest = new System.Windows.Forms.CheckBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.grbNew = new System.Windows.Forms.GroupBox();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radToday = new System.Windows.Forms.RadioButton();
            this.radLastMonth = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEventLocation = new System.Windows.Forms.Label();
            this.cmbEventName = new System.Windows.Forms.ComboBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnNextCustomer = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnNewTypeCancel = new System.Windows.Forms.Button();
            this.btnNewTypetClear = new System.Windows.Forms.Button();
            this.pnlNewcustomer = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.errSale = new System.Windows.Forms.ErrorProvider(this.components);
            this.saleDetTableAdapter = new AuntRosieApplication.ReportDataSetTableAdapters.saleDetTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.pnlMain.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndpQuanitity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbNew.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlNewcustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSale)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(35, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 30);
            this.lblTitle.TabIndex = 123;
            this.lblTitle.Text = "Sales";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.groupBox2);
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.grbNew);
            this.pnlMain.Enabled = false;
            this.pnlMain.Location = new System.Drawing.Point(40, 75);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(694, 544);
            this.pnlMain.TabIndex = 139;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lblItemPrice);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ndpQuanitity);
            this.groupBox2.Controls.Add(this.lblTotalVallue);
            this.groupBox2.Controls.Add(this.lblTax);
            this.groupBox2.Controls.Add(this.LblTotalPrice);
            this.groupBox2.Controls.Add(this.lblTotalNumberOfItem);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.grdSale);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAddToCart);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbProduct);
            this.groupBox2.Location = new System.Drawing.Point(17, 224);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(662, 308);
            this.groupBox2.TabIndex = 139;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lblItemPrice
            // 
            this.lblItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblItemPrice.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblItemPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblItemPrice.Location = new System.Drawing.Point(354, 49);
            this.lblItemPrice.Name = "lblItemPrice";
            this.lblItemPrice.Size = new System.Drawing.Size(99, 22);
            this.lblItemPrice.TabIndex = 143;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(249, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 142;
            this.label3.Text = "Unit Price";
            // 
            // ndpQuanitity
            // 
            this.ndpQuanitity.BackColor = System.Drawing.SystemColors.Info;
            this.ndpQuanitity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndpQuanitity.ForeColor = System.Drawing.Color.Sienna;
            this.ndpQuanitity.Location = new System.Drawing.Point(155, 45);
            this.ndpQuanitity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ndpQuanitity.Name = "ndpQuanitity";
            this.ndpQuanitity.Size = new System.Drawing.Size(88, 26);
            this.ndpQuanitity.TabIndex = 10;
            this.ndpQuanitity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTotalVallue
            // 
            this.lblTotalVallue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalVallue.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblTotalVallue.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTotalVallue.Location = new System.Drawing.Point(497, 271);
            this.lblTotalVallue.Name = "lblTotalVallue";
            this.lblTotalVallue.Size = new System.Drawing.Size(99, 22);
            this.lblTotalVallue.TabIndex = 135;
            // 
            // lblTax
            // 
            this.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTax.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblTax.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTax.Location = new System.Drawing.Point(497, 231);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(99, 22);
            this.lblTax.TabIndex = 134;
            // 
            // LblTotalPrice
            // 
            this.LblTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotalPrice.Font = new System.Drawing.Font("Arial", 14.25F);
            this.LblTotalPrice.ForeColor = System.Drawing.Color.OrangeRed;
            this.LblTotalPrice.Location = new System.Drawing.Point(229, 269);
            this.LblTotalPrice.Name = "LblTotalPrice";
            this.LblTotalPrice.Size = new System.Drawing.Size(109, 22);
            this.LblTotalPrice.TabIndex = 133;
            // 
            // lblTotalNumberOfItem
            // 
            this.lblTotalNumberOfItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalNumberOfItem.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblTotalNumberOfItem.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTotalNumberOfItem.Location = new System.Drawing.Point(229, 231);
            this.lblTotalNumberOfItem.Name = "lblTotalNumberOfItem";
            this.lblTotalNumberOfItem.Size = new System.Drawing.Size(109, 22);
            this.lblTotalNumberOfItem.TabIndex = 132;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Sienna;
            this.label15.Location = new System.Drawing.Point(350, 270);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(146, 22);
            this.label15.TabIndex = 131;
            this.label15.Text = "Total Bill Value";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Sienna;
            this.label14.Location = new System.Drawing.Point(452, 232);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 22);
            this.label14.TabIndex = 130;
            this.label14.Text = "Tax";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Sienna;
            this.label13.Location = new System.Drawing.Point(92, 269);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 22);
            this.label13.TabIndex = 129;
            this.label13.Text = "Total Prices";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Sienna;
            this.label12.Location = new System.Drawing.Point(0, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(212, 22);
            this.label12.TabIndex = 128;
            this.label12.Text = "Total Number of Items";
            // 
            // grdSale
            // 
            this.grdSale.AllowUserToAddRows = false;
            this.grdSale.AutoGenerateColumns = false;
            this.grdSale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdSale.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventProductID,
            this.productNameDataGridViewTextBoxColumn,
            this.sizeNameDataGridViewTextBoxColumn,
            this.saleQuantityDataGridViewTextBoxColumn,
            this.salePriceDataGridViewTextBoxColumn,
            this.itemCostDataGridViewTextBoxColumn,
            this.Delete});
            this.grdSale.DataSource = this.saleDetBindingSource;
            this.grdSale.Location = new System.Drawing.Point(0, 77);
            this.grdSale.Name = "grdSale";
            this.grdSale.Size = new System.Drawing.Size(656, 142);
            this.grdSale.TabIndex = 12;
            this.grdSale.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdSale_CellContentClick);
            // 
            // EventProductID
            // 
            this.EventProductID.DataPropertyName = "EventProductID";
            this.EventProductID.HeaderText = "EventProductID";
            this.EventProductID.Name = "EventProductID";
            this.EventProductID.Visible = false;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // sizeNameDataGridViewTextBoxColumn
            // 
            this.sizeNameDataGridViewTextBoxColumn.DataPropertyName = "SizeName";
            this.sizeNameDataGridViewTextBoxColumn.HeaderText = "SizeName";
            this.sizeNameDataGridViewTextBoxColumn.Name = "sizeNameDataGridViewTextBoxColumn";
            // 
            // saleQuantityDataGridViewTextBoxColumn
            // 
            this.saleQuantityDataGridViewTextBoxColumn.DataPropertyName = "SaleQuantity";
            this.saleQuantityDataGridViewTextBoxColumn.HeaderText = "SaleQuantity";
            this.saleQuantityDataGridViewTextBoxColumn.Name = "saleQuantityDataGridViewTextBoxColumn";
            // 
            // salePriceDataGridViewTextBoxColumn
            // 
            this.salePriceDataGridViewTextBoxColumn.DataPropertyName = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.HeaderText = "SalePrice";
            this.salePriceDataGridViewTextBoxColumn.Name = "salePriceDataGridViewTextBoxColumn";
            // 
            // itemCostDataGridViewTextBoxColumn
            // 
            this.itemCostDataGridViewTextBoxColumn.DataPropertyName = "itemCost";
            this.itemCostDataGridViewTextBoxColumn.HeaderText = "Total Items Price";
            this.itemCostDataGridViewTextBoxColumn.Name = "itemCostDataGridViewTextBoxColumn";
            this.itemCostDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemCostDataGridViewTextBoxColumn.Width = 120;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 50F;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // saleDetBindingSource
            // 
            this.saleDetBindingSource.DataMember = "saleDet";
            this.saleDetBindingSource.DataSource = this.reportDataSetBindingSource;
            // 
            // reportDataSetBindingSource
            // 
            this.reportDataSetBindingSource.DataSource = this.reportDataSet;
            this.reportDataSetBindingSource.Position = 0;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(45, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 22);
            this.label6.TabIndex = 125;
            this.label6.Text = "Quantity";
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Image = global::AuntRosieApplication.Properties.Resources.add_shopping_cart;
            this.btnAddToCart.Location = new System.Drawing.Point(555, 11);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(61, 49);
            this.btnAddToCart.TabIndex = 11;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(6, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 22);
            this.label5.TabIndex = 122;
            this.label5.Text = "Product Item";
            // 
            // cmbProduct
            // 
            this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProduct.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(156, 11);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(393, 31);
            this.cmbProduct.TabIndex = 9;
            this.cmbProduct.SelectedIndexChanged += new System.EventHandler(this.cmbProduct_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbPaymentMethod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chkGuest);
            this.groupBox1.Controls.Add(this.btnAddCustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbCustomerName);
            this.groupBox1.Location = new System.Drawing.Point(17, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 109);
            this.groupBox1.TabIndex = 138;
            this.groupBox1.TabStop = false;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.SystemColors.Info;
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(186, 65);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(345, 31);
            this.cmbPaymentMethod.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 22);
            this.label2.TabIndex = 147;
            this.label2.Tag = "";
            this.label2.Text = "Payment Method";
            // 
            // chkGuest
            // 
            this.chkGuest.AutoSize = true;
            this.chkGuest.Checked = true;
            this.chkGuest.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGuest.Location = new System.Drawing.Point(186, 5);
            this.chkGuest.Name = "chkGuest";
            this.chkGuest.Size = new System.Drawing.Size(72, 24);
            this.chkGuest.TabIndex = 5;
            this.chkGuest.Text = "Guest";
            this.chkGuest.UseVisualStyleBackColor = true;
            this.chkGuest.CheckedChanged += new System.EventHandler(this.chkGuest_CheckedChanged);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCustomer.Enabled = false;
            this.btnAddCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCustomer.Image = global::AuntRosieApplication.Properties.Resources.plus__2_;
            this.btnAddCustomer.Location = new System.Drawing.Point(537, 30);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(41, 31);
            this.btnAddCustomer.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnAddCustomer, "Add new customer");
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 22);
            this.label1.TabIndex = 122;
            this.label1.Text = "Customer Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.BackColor = System.Drawing.SystemColors.Info;
            this.cmbCustomerName.Enabled = false;
            this.cmbCustomerName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(186, 30);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(345, 31);
            this.cmbCustomerName.Sorted = true;
            this.cmbCustomerName.TabIndex = 6;
            this.toolTip1.SetToolTip(this.cmbCustomerName, "Choose Customer or enter  first or last name to filter the names ");
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerName_SelectedIndexChanged);
            this.cmbCustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbCustomerName_KeyDown);
            // 
            // grbNew
            // 
            this.grbNew.BackColor = System.Drawing.Color.Transparent;
            this.grbNew.Controls.Add(this.radAll);
            this.grbNew.Controls.Add(this.radToday);
            this.grbNew.Controls.Add(this.radLastMonth);
            this.grbNew.Controls.Add(this.label7);
            this.grbNew.Controls.Add(this.lblEventLocation);
            this.grbNew.Controls.Add(this.cmbEventName);
            this.grbNew.Location = new System.Drawing.Point(17, 3);
            this.grbNew.Name = "grbNew";
            this.grbNew.Size = new System.Drawing.Size(662, 117);
            this.grbNew.TabIndex = 137;
            this.grbNew.TabStop = false;
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAll.Location = new System.Drawing.Point(424, 12);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(44, 24);
            this.radAll.TabIndex = 3;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.CheckedChanged += new System.EventHandler(this.radAll_CheckedChanged);
            // 
            // radToday
            // 
            this.radToday.AutoSize = true;
            this.radToday.Checked = true;
            this.radToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radToday.Location = new System.Drawing.Point(141, 12);
            this.radToday.Name = "radToday";
            this.radToday.Size = new System.Drawing.Size(106, 24);
            this.radToday.TabIndex = 1;
            this.radToday.TabStop = true;
            this.radToday.Text = "Tody Event";
            this.radToday.UseVisualStyleBackColor = true;
            this.radToday.CheckedChanged += new System.EventHandler(this.radToday_CheckedChanged);
            // 
            // radLastMonth
            // 
            this.radLastMonth.AutoSize = true;
            this.radLastMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLastMonth.Location = new System.Drawing.Point(275, 12);
            this.radLastMonth.Name = "radLastMonth";
            this.radLastMonth.Size = new System.Drawing.Size(107, 24);
            this.radLastMonth.TabIndex = 2;
            this.radLastMonth.Text = "Last Month";
            this.radLastMonth.UseVisualStyleBackColor = true;
            this.radLastMonth.CheckedChanged += new System.EventHandler(this.radLastMonth_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(6, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 22);
            this.label7.TabIndex = 122;
            this.label7.Text = "Event Name";
            // 
            // lblEventLocation
            // 
            this.lblEventLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEventLocation.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblEventLocation.ForeColor = System.Drawing.Color.Sienna;
            this.lblEventLocation.Location = new System.Drawing.Point(10, 73);
            this.lblEventLocation.Name = "lblEventLocation";
            this.lblEventLocation.Size = new System.Drawing.Size(646, 30);
            this.lblEventLocation.TabIndex = 114;
            this.lblEventLocation.Text = "Event Location:   ";
            // 
            // cmbEventName
            // 
            this.cmbEventName.BackColor = System.Drawing.SystemColors.Info;
            this.cmbEventName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEventName.FormattingEnabled = true;
            this.cmbEventName.Location = new System.Drawing.Point(156, 39);
            this.cmbEventName.Name = "cmbEventName";
            this.cmbEventName.Size = new System.Drawing.Size(500, 31);
            this.cmbEventName.TabIndex = 4;
            this.cmbEventName.SelectedIndexChanged += new System.EventHandler(this.cmbEventName_SelectedIndexChanged);
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlButton.Controls.Add(this.btnNextCustomer);
            this.pnlButton.Controls.Add(this.btnClear);
            this.pnlButton.Controls.Add(this.btnNew);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Location = new System.Drawing.Point(239, 631);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(268, 60);
            this.pnlButton.TabIndex = 140;
            // 
            // btnNextCustomer
            // 
            this.btnNextCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnNextCustomer.Enabled = false;
            this.btnNextCustomer.FlatAppearance.BorderSize = 0;
            this.btnNextCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextCustomer.Image = global::AuntRosieApplication.Properties.Resources.more_than;
            this.btnNextCustomer.Location = new System.Drawing.Point(72, 3);
            this.btnNextCustomer.Name = "btnNextCustomer";
            this.btnNextCustomer.Size = new System.Drawing.Size(64, 54);
            this.btnNextCustomer.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnNextCustomer, "Next Customer");
            this.btnNextCustomer.UseVisualStyleBackColor = false;
            this.btnNextCustomer.Click += new System.EventHandler(this.btnNextCustomer_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Enabled = false;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::AuntRosieApplication.Properties.Resources.delete_sign;
            this.btnClear.Location = new System.Drawing.Point(131, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 54);
            this.btnClear.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnClear, "Cancel Sale Operation");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = global::AuntRosieApplication.Properties.Resources.plus_2_math;
            this.btnNew.Location = new System.Drawing.Point(4, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(64, 54);
            this.btnNew.TabIndex = 9;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip1.SetToolTip(this.btnNew, "New Sale");
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::AuntRosieApplication.Properties.Resources.print;
            this.btnSave.Location = new System.Drawing.Point(201, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 54);
            this.btnSave.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnSave, "Print Bill");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNewTypeCancel
            // 
            this.btnNewTypeCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTypeCancel.FlatAppearance.BorderSize = 0;
            this.btnNewTypeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTypeCancel.Image = global::AuntRosieApplication.Properties.Resources.file_delete;
            this.btnNewTypeCancel.Location = new System.Drawing.Point(250, 206);
            this.btnNewTypeCancel.Name = "btnNewTypeCancel";
            this.btnNewTypeCancel.Size = new System.Drawing.Size(63, 55);
            this.btnNewTypeCancel.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnNewTypeCancel, "Cancel");
            this.btnNewTypeCancel.UseVisualStyleBackColor = false;
            this.btnNewTypeCancel.Click += new System.EventHandler(this.btnNewTypeCancel_Click);
            // 
            // btnNewTypetClear
            // 
            this.btnNewTypetClear.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTypetClear.FlatAppearance.BorderSize = 0;
            this.btnNewTypetClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTypetClear.Image = global::AuntRosieApplication.Properties.Resources.save;
            this.btnNewTypetClear.Location = new System.Drawing.Point(181, 206);
            this.btnNewTypetClear.Name = "btnNewTypetClear";
            this.btnNewTypetClear.Size = new System.Drawing.Size(63, 55);
            this.btnNewTypetClear.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btnNewTypetClear, "Save");
            this.btnNewTypetClear.UseVisualStyleBackColor = false;
            this.btnNewTypetClear.Click += new System.EventHandler(this.btnNewTypetClear_Click);
            // 
            // pnlNewcustomer
            // 
            this.pnlNewcustomer.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnlNewcustomer.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            this.pnlNewcustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNewcustomer.Controls.Add(this.txtPhone);
            this.pnlNewcustomer.Controls.Add(this.label8);
            this.pnlNewcustomer.Controls.Add(this.txtEmail);
            this.pnlNewcustomer.Controls.Add(this.txtFirstName);
            this.pnlNewcustomer.Controls.Add(this.label9);
            this.pnlNewcustomer.Controls.Add(this.label10);
            this.pnlNewcustomer.Controls.Add(this.label11);
            this.pnlNewcustomer.Controls.Add(this.txtLastName);
            this.pnlNewcustomer.Controls.Add(this.label4);
            this.pnlNewcustomer.Controls.Add(this.btnNewTypeCancel);
            this.pnlNewcustomer.Controls.Add(this.btnNewTypetClear);
            this.pnlNewcustomer.ForeColor = System.Drawing.Color.Sienna;
            this.pnlNewcustomer.Location = new System.Drawing.Point(740, 249);
            this.pnlNewcustomer.Name = "pnlNewcustomer";
            this.pnlNewcustomer.Size = new System.Drawing.Size(479, 282);
            this.pnlNewcustomer.TabIndex = 21;
            this.pnlNewcustomer.Visible = false;
            this.pnlNewcustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNewcustomer_Paint);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Info;
            this.txtPhone.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(201, 141);
            this.txtPhone.Mask = "(999)-000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(216, 29);
            this.txtPhone.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Sienna;
            this.label8.Location = new System.Drawing.Point(100, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 23);
            this.label8.TabIndex = 65;
            this.label8.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtEmail.Location = new System.Drawing.Point(201, 176);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 29);
            this.txtEmail.TabIndex = 61;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Info;
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtFirstName.Location = new System.Drawing.Point(201, 71);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(216, 29);
            this.txtFirstName.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Sienna;
            this.label9.Location = new System.Drawing.Point(92, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 23);
            this.label9.TabIndex = 64;
            this.label9.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Sienna;
            this.label10.Location = new System.Drawing.Point(64, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 23);
            this.label10.TabIndex = 62;
            this.label10.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Sienna;
            this.label11.Location = new System.Drawing.Point(61, 112);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 23);
            this.label11.TabIndex = 63;
            this.label11.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Info;
            this.txtLastName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtLastName.Location = new System.Drawing.Point(201, 106);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(216, 29);
            this.txtLastName.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label4.ForeColor = System.Drawing.Color.Goldenrod;
            this.label4.Location = new System.Drawing.Point(138, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 22);
            this.label4.TabIndex = 57;
            this.label4.Text = "Add New Customer";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(641, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // errSale
            // 
            this.errSale.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errSale.ContainerControl = this;
            // 
            // saleDetTableAdapter
            // 
            this.saleDetTableAdapter.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // frmSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(766, 752);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlNewcustomer);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Sienna;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesForm";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.pnlMain.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ndpQuanitity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdSale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saleDetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbNew.ResumeLayout(false);
            this.grbNew.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlNewcustomer.ResumeLayout(false);
            this.pnlNewcustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errSale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNewTypeCancel;
        private System.Windows.Forms.Button btnNewTypetClear;
        private System.Windows.Forms.Panel pnlNewcustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCustomerName;
        private System.Windows.Forms.GroupBox grbNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEventLocation;
        private System.Windows.Forms.ComboBox cmbEventName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ErrorProvider errSale;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTotalVallue;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label LblTotalPrice;
        private System.Windows.Forms.Label lblTotalNumberOfItem;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView grdSale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.CheckBox chkGuest;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton radToday;
        private System.Windows.Forms.RadioButton radLastMonth;
        private System.Windows.Forms.NumericUpDown ndpQuanitity;
        private System.Windows.Forms.Label lblItemPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnNextCustomer;
        private System.Windows.Forms.BindingSource reportDataSetBindingSource;
        private ReportDataSet reportDataSet;
        private System.Windows.Forms.BindingSource saleDetBindingSource;
        private ReportDataSetTableAdapters.saleDetTableAdapter saleDetTableAdapter;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label label2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}