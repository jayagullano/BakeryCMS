namespace AuntRosieApplication.Employment
{
    partial class PayRollFull
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayRollFull));
            this.lblFullAmount = new System.Windows.Forms.Label();
            this.cmbfullEmp = new System.Windows.Forms.ComboBox();
            this.btnAddFull = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grdPayroll = new System.Windows.Forms.DataGridView();
            this.employeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biWeekNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblFullTimePayrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSet = new AuntRosieApplication.ReportDataSet();
            this.pnlPaymentDate = new System.Windows.Forms.Panel();
            this.cmbPaymentDate = new System.Windows.Forms.ComboBox();
            this.btnOkay = new System.Windows.Forms.Button();
            this.radExists = new System.Windows.Forms.RadioButton();
            this.radNew = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.errPayroll = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radFirst = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblEmploymentDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tblFullTimePayrollTableAdapter = new AuntRosieApplication.ReportDataSetTableAdapters.tblFullTimePayrollTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFullTimePayrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            this.pnlPaymentDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPayroll)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFullAmount
            // 
            this.lblFullAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFullAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullAmount.Location = new System.Drawing.Point(168, 45);
            this.lblFullAmount.Name = "lblFullAmount";
            this.lblFullAmount.Size = new System.Drawing.Size(108, 30);
            this.lblFullAmount.TabIndex = 113;
            this.lblFullAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbfullEmp
            // 
            this.cmbfullEmp.BackColor = System.Drawing.SystemColors.Info;
            this.cmbfullEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfullEmp.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbfullEmp.FormattingEnabled = true;
            this.cmbfullEmp.Location = new System.Drawing.Point(251, 177);
            this.cmbfullEmp.Name = "cmbfullEmp";
            this.cmbfullEmp.Size = new System.Drawing.Size(331, 31);
            this.cmbfullEmp.TabIndex = 6;
            this.cmbfullEmp.SelectedIndexChanged += new System.EventHandler(this.cmbfullEmp_SelectedIndexChanged);
            // 
            // btnAddFull
            // 
            this.btnAddFull.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFull.FlatAppearance.BorderSize = 0;
            this.btnAddFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFull.Image = global::AuntRosieApplication.Properties.Resources.low_importance;
            this.btnAddFull.Location = new System.Drawing.Point(464, 51);
            this.btnAddFull.Name = "btnAddFull";
            this.btnAddFull.Size = new System.Drawing.Size(31, 35);
            this.btnAddFull.TabIndex = 8;
            this.btnAddFull.UseVisualStyleBackColor = false;
            this.btnAddFull.Click += new System.EventHandler(this.btnAddFull_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(101, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 22);
            this.label13.TabIndex = 123;
            this.label13.Tag = "";
            this.label13.Text = "Payment Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(170, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 22);
            this.label9.TabIndex = 103;
            this.label9.Tag = "";
            this.label9.Text = "Month";
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.SystemColors.Info;
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(251, 140);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(331, 31);
            this.cmbPaymentMethod.TabIndex = 5;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbfullEmp_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(78, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 22);
            this.label6.TabIndex = 122;
            this.label6.Tag = "";
            this.label6.Text = "Payment Method";
            // 
            // grdPayroll
            // 
            this.grdPayroll.AllowUserToAddRows = false;
            this.grdPayroll.AllowUserToDeleteRows = false;
            this.grdPayroll.AutoGenerateColumns = false;
            this.grdPayroll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPayroll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.yearDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.biWeekNoDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.Delete});
            this.grdPayroll.DataSource = this.tblFullTimePayrollBindingSource;
            this.grdPayroll.Location = new System.Drawing.Point(3, 316);
            this.grdPayroll.Name = "grdPayroll";
            this.grdPayroll.ReadOnly = true;
            this.grdPayroll.Size = new System.Drawing.Size(665, 150);
            this.grdPayroll.TabIndex = 9;
            this.grdPayroll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPayroll_CellContentClick);
            // 
            // employeeIDDataGridViewTextBoxColumn
            // 
            this.employeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID";
            this.employeeIDDataGridViewTextBoxColumn.Name = "employeeIDDataGridViewTextBoxColumn";
            this.employeeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "EmployeeFirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "First Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "EmployeeLastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Month";
            this.dataGridViewTextBoxColumn1.HeaderText = "Month";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // biWeekNoDataGridViewTextBoxColumn
            // 
            this.biWeekNoDataGridViewTextBoxColumn.DataPropertyName = "BiWeekNo";
            this.biWeekNoDataGridViewTextBoxColumn.HeaderText = "BiWeekNo";
            this.biWeekNoDataGridViewTextBoxColumn.Name = "biWeekNoDataGridViewTextBoxColumn";
            this.biWeekNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.biWeekNoDataGridViewTextBoxColumn.Width = 70;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Delete.DefaultCellStyle = dataGridViewCellStyle3;
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
            // tblFullTimePayrollBindingSource
            // 
            this.tblFullTimePayrollBindingSource.DataMember = "tblFullTimePayroll";
            this.tblFullTimePayrollBindingSource.DataSource = this.reportDataSet;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.pnlPaymentDate.Location = new System.Drawing.Point(230, 52);
            this.pnlPaymentDate.Name = "pnlPaymentDate";
            this.pnlPaymentDate.Size = new System.Drawing.Size(359, 237);
            this.pnlPaymentDate.TabIndex = 128;
            // 
            // cmbPaymentDate
            // 
            this.cmbPaymentDate.BackColor = System.Drawing.SystemColors.Info;
            this.cmbPaymentDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentDate.Enabled = false;
            this.cmbPaymentDate.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentDate.FormattingEnabled = true;
            this.cmbPaymentDate.Location = new System.Drawing.Point(65, 122);
            this.cmbPaymentDate.Name = "cmbPaymentDate";
            this.cmbPaymentDate.Size = new System.Drawing.Size(236, 31);
            this.cmbPaymentDate.TabIndex = 13;
            this.cmbPaymentDate.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentDate_SelectedIndexChanged);
            // 
            // btnOkay
            // 
            this.btnOkay.BackColor = System.Drawing.Color.Transparent;
            this.btnOkay.FlatAppearance.BorderSize = 0;
            this.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkay.Image = global::AuntRosieApplication.Properties.Resources.login_rounded_right;
            this.btnOkay.Location = new System.Drawing.Point(155, 159);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(79, 61);
            this.btnOkay.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnOkay, "Next");
            this.btnOkay.UseVisualStyleBackColor = false;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // radExists
            // 
            this.radExists.AutoSize = true;
            this.radExists.BackColor = System.Drawing.Color.Transparent;
            this.radExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radExists.Location = new System.Drawing.Point(73, 59);
            this.radExists.Name = "radExists";
            this.radExists.Size = new System.Drawing.Size(178, 28);
            this.radExists.TabIndex = 12;
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
            this.radNew.Location = new System.Drawing.Point(73, 25);
            this.radNew.Name = "radNew";
            this.radNew.Size = new System.Drawing.Size(161, 28);
            this.radNew.TabIndex = 11;
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
            this.label14.Location = new System.Drawing.Point(70, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(107, 18);
            this.label14.TabIndex = 125;
            this.label14.Tag = "";
            this.label14.Text = "Payment Date";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(715, 19);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 10;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPaymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentDate.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblPaymentDate.Location = new System.Drawing.Point(247, 20);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(335, 30);
            this.lblPaymentDate.TabIndex = 124;
            this.lblPaymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblPaymentDate, "MM/DD/YYYY");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 108;
            this.label1.Text = "Payment Amount";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(292, 30);
            this.lblTitle.TabIndex = 125;
            this.lblTitle.Text = "Payroll- Full Time";
            // 
            // errPayroll
            // 
            this.errPayroll.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errPayroll.ContainerControl = this;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.cmbYear);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.cmbMonth);
            this.pnlMain.Controls.Add(this.radioButton2);
            this.pnlMain.Controls.Add(this.radFirst);
            this.pnlMain.Controls.Add(this.grdPayroll);
            this.pnlMain.Controls.Add(this.lblPaymentDate);
            this.pnlMain.Controls.Add(this.cmbfullEmp);
            this.pnlMain.Controls.Add(this.label13);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.cmbPaymentMethod);
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Enabled = false;
            this.pnlMain.Location = new System.Drawing.Point(51, 82);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(682, 521);
            this.pnlMain.TabIndex = 127;
            this.toolTip1.SetToolTip(this.pnlMain, "ClearData");
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint_1);
            // 
            // cmbYear
            // 
            this.cmbYear.BackColor = System.Drawing.SystemColors.Info;
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(456, 65);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(126, 31);
            this.cmbYear.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(379, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 130;
            this.label3.Tag = "";
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(97, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 129;
            this.label2.Tag = "";
            this.label2.Text = "Eployee Name";
            // 
            // cmbMonth
            // 
            this.cmbMonth.BackColor = System.Drawing.SystemColors.Info;
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Location = new System.Drawing.Point(247, 61);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(126, 31);
            this.cmbMonth.TabIndex = 1;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(398, 104);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(146, 24);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Second Bi-Week";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radFirst
            // 
            this.radFirst.AutoSize = true;
            this.radFirst.Checked = true;
            this.radFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFirst.Location = new System.Drawing.Point(251, 104);
            this.radFirst.Name = "radFirst";
            this.radFirst.Size = new System.Drawing.Size(122, 24);
            this.radFirst.TabIndex = 3;
            this.radFirst.TabStop = true;
            this.radFirst.Text = "First Bi-Week";
            this.radFirst.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.lblEmploymentDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.lblFullAmount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnAddFull);
            this.panel1.Location = new System.Drawing.Point(82, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 89);
            this.panel1.TabIndex = 109;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::AuntRosieApplication.Properties.Resources.delete_sign1;
            this.btnClear.Location = new System.Drawing.Point(464, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(31, 35);
            this.btnClear.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnClear, "Clear Expenses");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblEmploymentDate
            // 
            this.lblEmploymentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEmploymentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmploymentDate.Location = new System.Drawing.Point(167, 10);
            this.lblEmploymentDate.Name = "lblEmploymentDate";
            this.lblEmploymentDate.Size = new System.Drawing.Size(288, 30);
            this.lblEmploymentDate.TabIndex = 118;
            this.lblEmploymentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 20);
            this.label4.TabIndex = 117;
            this.label4.Text = "Employment Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Sienna;
            this.label12.Location = new System.Drawing.Point(281, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 23);
            this.label12.TabIndex = 116;
            this.label12.Text = "CAD";
            // 
            // tblFullTimePayrollTableAdapter
            // 
            this.tblFullTimePayrollTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AuntRosieApplication.Properties.Resources.help;
            this.button1.Location = new System.Drawing.Point(673, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 41);
            this.button1.TabIndex = 129;
            this.toolTip1.SetToolTip(this.button1, "To pick another payroll");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PayRollFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(789, 633);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlPaymentDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlMain);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "PayRollFull";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayRollFull";
            this.Load += new System.EventHandler(this.PayRollFull_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPayroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFullTimePayrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            this.pnlPaymentDate.ResumeLayout(false);
            this.pnlPaymentDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errPayroll)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFullAmount;
        private System.Windows.Forms.ComboBox cmbfullEmp;
        private System.Windows.Forms.Button btnAddFull;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView grdPayroll;
        private System.Windows.Forms.Panel pnlPaymentDate;
        private System.Windows.Forms.ComboBox cmbPaymentDate;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton radExists;
        private System.Windows.Forms.RadioButton radNew;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPaymentDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider errPayroll;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radFirst;
        private System.Windows.Forms.Label lblEmploymentDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource tblFullTimePayrollBindingSource;
        private ReportDataSet reportDataSet;
        private ReportDataSetTableAdapters.tblFullTimePayrollTableAdapter tblFullTimePayrollTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn biWeekNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
    }
}