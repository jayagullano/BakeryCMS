namespace AuntRosieApplication.Employment
{
    partial class frmPayroll
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayroll));
            this.lblTitle = new System.Windows.Forms.Label();
            this.errPayroll = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnOkay = new System.Windows.Forms.Button();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.payrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auntRosieDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auntRosieDBDataSet = new AuntRosieApplication.AuntRosieDBDataSet();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.grdPayroll = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFormDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.cmbPartEmp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.pnlPartAddPayroll = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPartAmount = new System.Windows.Forms.Label();
            this.txtwage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlPaymentDate = new System.Windows.Forms.Panel();
            this.cmbPaymentDate = new System.Windows.Forms.ComboBox();
            this.radExists = new System.Windows.Forms.RadioButton();
            this.radNew = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.payrollTableAdapter = new AuntRosieApplication.AuntRosieDBDataSetTableAdapters.payrollTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errPayroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayroll)).BeginInit();
            this.pnlPartAddPayroll.SuspendLayout();
            this.pnlPaymentDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(56, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Payroll-Part Time";
            // 
            // errPayroll
            // 
            this.errPayroll.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errPayroll.ContainerControl = this;
            // 
            // btnOkay
            // 
            this.btnOkay.BackColor = System.Drawing.Color.Transparent;
            this.btnOkay.FlatAppearance.BorderSize = 0;
            this.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkay.Image = global::AuntRosieApplication.Properties.Resources.login_rounded_right;
            this.btnOkay.Location = new System.Drawing.Point(121, 160);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(79, 61);
            this.btnOkay.TabIndex = 129;
            this.toolTip1.SetToolTip(this.btnOkay, "Next");
            this.btnOkay.UseVisualStyleBackColor = false;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPaymentDate.Location = new System.Drawing.Point(285, 8);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(281, 30);
            this.lblPaymentDate.TabIndex = 124;
            this.lblPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblPaymentDate, "MM/DD/YYYY");
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::AuntRosieApplication.Properties.Resources.delete_sign1;
            this.btnClear.Location = new System.Drawing.Point(484, 41);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(31, 35);
            this.btnClear.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnClear, "Clear Data");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // payrollBindingSource
            // 
            this.payrollBindingSource.DataMember = "payroll";
            this.payrollBindingSource.DataSource = this.auntRosieDBDataSetBindingSource;
            // 
            // auntRosieDBDataSetBindingSource
            // 
            this.auntRosieDBDataSetBindingSource.DataSource = this.auntRosieDBDataSet;
            this.auntRosieDBDataSetBindingSource.Position = 0;
            // 
            // auntRosieDBDataSet
            // 
            this.auntRosieDBDataSet.DataSetName = "AuntRosieDBDataSet";
            this.auntRosieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Controls.Add(this.grdPayroll);
            this.pnlMain.Controls.Add(this.lblPaymentDate);
            this.pnlMain.Controls.Add(this.label13);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.cmbPaymentMethod);
            this.pnlMain.Controls.Add(this.label10);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.dtpFormDate);
            this.pnlMain.Controls.Add(this.dtpToDate);
            this.pnlMain.Controls.Add(this.cmbPartEmp);
            this.pnlMain.Controls.Add(this.label7);
            this.pnlMain.Controls.Add(this.lblDays);
            this.pnlMain.Controls.Add(this.pnlPartAddPayroll);
            this.pnlMain.Enabled = false;
            this.pnlMain.Location = new System.Drawing.Point(61, 68);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(716, 579);
            this.pnlMain.TabIndex = 123;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 116;
            this.label1.Text = "Employee Name";
            // 
            // grdPayroll
            // 
            this.grdPayroll.AllowUserToAddRows = false;
            this.grdPayroll.AllowUserToDeleteRows = false;
            this.grdPayroll.AutoGenerateColumns = false;
            this.grdPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.employeeFirstNameDataGridViewTextBoxColumn,
            this.employeeLastNameDataGridViewTextBoxColumn,
            this.fromDateDataGridViewTextBoxColumn,
            this.toDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.Delete});
            this.grdPayroll.DataSource = this.payrollBindingSource;
            this.grdPayroll.Location = new System.Drawing.Point(17, 359);
            this.grdPayroll.Name = "grdPayroll";
            this.grdPayroll.ReadOnly = true;
            this.grdPayroll.Size = new System.Drawing.Size(684, 190);
            this.grdPayroll.TabIndex = 8;
            this.grdPayroll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPayroll_CellContentClick);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.employeeIDDataGridViewTextBoxColumn.Width = 89;
            // 
            // employeeFirstNameDataGridViewTextBoxColumn
            // 
            this.employeeFirstNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeFirstName";
            this.employeeFirstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.employeeFirstNameDataGridViewTextBoxColumn.Name = "employeeFirstNameDataGridViewTextBoxColumn";
            this.employeeFirstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeLastNameDataGridViewTextBoxColumn
            // 
            this.employeeLastNameDataGridViewTextBoxColumn.DataPropertyName = "EmployeeLastName";
            this.employeeLastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.employeeLastNameDataGridViewTextBoxColumn.Name = "employeeLastNameDataGridViewTextBoxColumn";
            this.employeeLastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fromDateDataGridViewTextBoxColumn
            // 
            this.fromDateDataGridViewTextBoxColumn.DataPropertyName = "FromDate";
            this.fromDateDataGridViewTextBoxColumn.HeaderText = "FromDate";
            this.fromDateDataGridViewTextBoxColumn.Name = "fromDateDataGridViewTextBoxColumn";
            this.fromDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toDateDataGridViewTextBoxColumn
            // 
            this.toDateDataGridViewTextBoxColumn.DataPropertyName = "ToDate";
            this.toDateDataGridViewTextBoxColumn.HeaderText = "ToDate";
            this.toDateDataGridViewTextBoxColumn.Name = "toDateDataGridViewTextBoxColumn";
            this.toDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(114, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 24);
            this.label13.TabIndex = 123;
            this.label13.Tag = "";
            this.label13.Text = "Payment Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(144, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 24);
            this.label9.TabIndex = 103;
            this.label9.Tag = "";
            this.label9.Text = "From Date";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.SystemColors.Info;
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(285, 161);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(330, 31);
            this.cmbPaymentMethod.TabIndex = 3;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPartEmp_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(169, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 24);
            this.label10.TabIndex = 104;
            this.label10.Tag = "";
            this.label10.Text = "To Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(84, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 24);
            this.label6.TabIndex = 122;
            this.label6.Tag = "";
            this.label6.Text = "Payment Method";
            // 
            // dtpFormDate
            // 
            this.dtpFormDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFormDate.Location = new System.Drawing.Point(285, 41);
            this.dtpFormDate.Name = "dtpFormDate";
            this.dtpFormDate.Size = new System.Drawing.Size(281, 26);
            this.dtpFormDate.TabIndex = 1;
            this.dtpFormDate.ValueChanged += new System.EventHandler(this.dtpFormDate_ValueChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Location = new System.Drawing.Point(285, 81);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(281, 26);
            this.dtpToDate.TabIndex = 2;
            this.dtpToDate.ValueChanged += new System.EventHandler(this.dtpToDate_ValueChanged);
            // 
            // cmbPartEmp
            // 
            this.cmbPartEmp.BackColor = System.Drawing.SystemColors.Info;
            this.cmbPartEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPartEmp.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPartEmp.FormattingEnabled = true;
            this.cmbPartEmp.Location = new System.Drawing.Point(284, 204);
            this.cmbPartEmp.Name = "cmbPartEmp";
            this.cmbPartEmp.Size = new System.Drawing.Size(330, 31);
            this.cmbPartEmp.TabIndex = 4;
            this.cmbPartEmp.SelectedIndexChanged += new System.EventHandler(this.cmbPartEmp_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 24);
            this.label7.TabIndex = 119;
            this.label7.Tag = "";
            this.label7.Text = "Days";
            // 
            // lblDays
            // 
            this.lblDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDays.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDays.Location = new System.Drawing.Point(285, 119);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(108, 30);
            this.lblDays.TabIndex = 118;
            this.lblDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlPartAddPayroll
            // 
            this.pnlPartAddPayroll.BackColor = System.Drawing.Color.Transparent;
            this.pnlPartAddPayroll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPartAddPayroll.Controls.Add(this.btnClear);
            this.pnlPartAddPayroll.Controls.Add(this.label11);
            this.pnlPartAddPayroll.Controls.Add(this.label8);
            this.pnlPartAddPayroll.Controls.Add(this.lblPartAmount);
            this.pnlPartAddPayroll.Controls.Add(this.txtwage);
            this.pnlPartAddPayroll.Controls.Add(this.label3);
            this.pnlPartAddPayroll.Controls.Add(this.lblHour);
            this.pnlPartAddPayroll.Controls.Add(this.label4);
            this.pnlPartAddPayroll.Controls.Add(this.label5);
            this.pnlPartAddPayroll.Controls.Add(this.btnAddPart);
            this.pnlPartAddPayroll.Location = new System.Drawing.Point(87, 241);
            this.pnlPartAddPayroll.Name = "pnlPartAddPayroll";
            this.pnlPartAddPayroll.Size = new System.Drawing.Size(528, 112);
            this.pnlPartAddPayroll.TabIndex = 110;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Sienna;
            this.label11.Location = new System.Drawing.Point(310, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 23);
            this.label11.TabIndex = 115;
            this.label11.Text = "CAD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Sienna;
            this.label8.Location = new System.Drawing.Point(310, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 23);
            this.label8.TabIndex = 113;
            this.label8.Text = "CAD";
            // 
            // lblPartAmount
            // 
            this.lblPartAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPartAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartAmount.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPartAmount.Location = new System.Drawing.Point(196, 74);
            this.lblPartAmount.Name = "lblPartAmount";
            this.lblPartAmount.Size = new System.Drawing.Size(108, 30);
            this.lblPartAmount.TabIndex = 114;
            this.lblPartAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtwage
            // 
            this.txtwage.BackColor = System.Drawing.SystemColors.Info;
            this.txtwage.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtwage.Location = new System.Drawing.Point(196, 4);
            this.txtwage.Name = "txtwage";
            this.txtwage.Size = new System.Drawing.Size(108, 29);
            this.txtwage.TabIndex = 5;
            this.txtwage.TextChanged += new System.EventHandler(this.txtwage_TextChanged);
            this.txtwage.Leave += new System.EventHandler(this.txtwage_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 109;
            this.label3.Text = "Payment Amount";
            // 
            // lblHour
            // 
            this.lblHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblHour.Location = new System.Drawing.Point(196, 41);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(108, 30);
            this.lblHour.TabIndex = 112;
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 111;
            this.label4.Text = "Total worked hours";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 110;
            this.label5.Text = "Hour\'s wage";
            // 
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPart.FlatAppearance.BorderSize = 0;
            this.btnAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPart.Image = global::AuntRosieApplication.Properties.Resources.low_importance;
            this.btnAddPart.Location = new System.Drawing.Point(484, 78);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(31, 29);
            this.btnAddPart.TabIndex = 7;
            this.btnAddPart.UseVisualStyleBackColor = false;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(727, 15);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlPaymentDate
            // 
            this.pnlPaymentDate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPaymentDate.BackgroundImage")));
            this.pnlPaymentDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPaymentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPaymentDate.Controls.Add(this.cmbPaymentDate);
            this.pnlPaymentDate.Controls.Add(this.btnOkay);
            this.pnlPaymentDate.Controls.Add(this.radExists);
            this.pnlPaymentDate.Controls.Add(this.radNew);
            this.pnlPaymentDate.Controls.Add(this.label14);
            this.pnlPaymentDate.Location = new System.Drawing.Point(156, 66);
            this.pnlPaymentDate.Name = "pnlPaymentDate";
            this.pnlPaymentDate.Size = new System.Drawing.Size(356, 237);
            this.pnlPaymentDate.TabIndex = 124;
            this.pnlPaymentDate.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlPaymentDate_Paint);
            // 
            // cmbPaymentDate
            // 
            this.cmbPaymentDate.BackColor = System.Drawing.SystemColors.Info;
            this.cmbPaymentDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentDate.Enabled = false;
            this.cmbPaymentDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentDate.FormattingEnabled = true;
            this.cmbPaymentDate.Location = new System.Drawing.Point(39, 123);
            this.cmbPaymentDate.Name = "cmbPaymentDate";
            this.cmbPaymentDate.Size = new System.Drawing.Size(272, 31);
            this.cmbPaymentDate.TabIndex = 130;
            this.cmbPaymentDate.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentDate_SelectedIndexChanged);
            // 
            // radExists
            // 
            this.radExists.AutoSize = true;
            this.radExists.BackColor = System.Drawing.Color.Transparent;
            this.radExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radExists.Location = new System.Drawing.Point(39, 60);
            this.radExists.Name = "radExists";
            this.radExists.Size = new System.Drawing.Size(178, 28);
            this.radExists.TabIndex = 127;
            this.radExists.Text = "Previous Payroll";
            this.radExists.UseVisualStyleBackColor = false;
            this.radExists.CheckedChanged += new System.EventHandler(this.radExists_CheckedChanged);
            // 
            // radNew
            // 
            this.radNew.AutoSize = true;
            this.radNew.BackColor = System.Drawing.Color.Transparent;
            this.radNew.Checked = true;
            this.radNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNew.Location = new System.Drawing.Point(39, 26);
            this.radNew.Name = "radNew";
            this.radNew.Size = new System.Drawing.Size(161, 28);
            this.radNew.TabIndex = 126;
            this.radNew.TabStop = true;
            this.radNew.Text = "Today Payroll ";
            this.radNew.UseVisualStyleBackColor = false;
            this.radNew.CheckedChanged += new System.EventHandler(this.radNew_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(36, 102);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 18);
            this.label14.TabIndex = 125;
            this.label14.Tag = "";
            this.label14.Text = "Payment Date";
            // 
            // payrollTableAdapter
            // 
            this.payrollTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AuntRosieApplication.Properties.Resources.help;
            this.button1.Location = new System.Drawing.Point(683, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 125;
            this.toolTip1.SetToolTip(this.button1, "To pick another payroll");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(816, 698);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlPaymentDate);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClose);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayrollForm";
            this.Load += new System.EventHandler(this.frmPayroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errPayroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayroll)).EndInit();
            this.pnlPartAddPayroll.ResumeLayout(false);
            this.pnlPartAddPayroll.PerformLayout();
            this.pnlPaymentDate.ResumeLayout(false);
            this.pnlPaymentDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errPayroll;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.BindingSource payrollBindingSource;
        private System.Windows.Forms.BindingSource auntRosieDBDataSetBindingSource;
        private AuntRosieDBDataSet auntRosieDBDataSet;
        private AuntRosieDBDataSetTableAdapters.payrollTableAdapter payrollTableAdapter;
        private System.Windows.Forms.Panel pnlPaymentDate;
        private System.Windows.Forms.RadioButton radExists;
        private System.Windows.Forms.RadioButton radNew;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFormDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Panel pnlPartAddPayroll;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPartAmount;
        private System.Windows.Forms.TextBox txtwage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPartEmp;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.ComboBox cmbPaymentDate;
        private System.Windows.Forms.DataGridView grdPayroll;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
    }
}