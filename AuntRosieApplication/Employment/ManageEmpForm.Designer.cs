namespace AuntRosieApplication.Employment
{
    partial class frmManageEmp
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
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpBasic = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblPostalCode = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.grpAdd = new System.Windows.Forms.GroupBox();
            this.txtPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.cmbProvinces = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.grPInfo = new System.Windows.Forms.GroupBox();
            this.pnlFullTimeData = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsalary = new System.Windows.Forms.TextBox();
            this.dtpEmploymentDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.radFullTime = new System.Windows.Forms.RadioButton();
            this.radPartTime = new System.Windows.Forms.RadioButton();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlEmployeeName = new System.Windows.Forms.Panel();
            this.erPEmployeeForm = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpBasic.SuspendLayout();
            this.grpAdd.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.grPInfo.SuspendLayout();
            this.pnlFullTimeData.SuspendLayout();
            this.pnlEmployeeName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erPEmployeeForm)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbName
            // 
            this.cmbName.BackColor = System.Drawing.SystemColors.Info;
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(175, 8);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(350, 31);
            this.cmbName.TabIndex = 61;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Sienna;
            this.label8.Location = new System.Drawing.Point(84, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 23);
            this.label8.TabIndex = 48;
            this.label8.Text = "Email";
            // 
            // grpBasic
            // 
            this.grpBasic.BackColor = System.Drawing.Color.Transparent;
            this.grpBasic.Controls.Add(this.txtPhone);
            this.grpBasic.Controls.Add(this.label8);
            this.grpBasic.Controls.Add(this.txtEmail);
            this.grpBasic.Controls.Add(this.txtFirstName);
            this.grpBasic.Controls.Add(this.label9);
            this.grpBasic.Controls.Add(this.label10);
            this.grpBasic.Controls.Add(this.label11);
            this.grpBasic.Controls.Add(this.txtLastName);
            this.grpBasic.Enabled = false;
            this.grpBasic.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBasic.ForeColor = System.Drawing.Color.Goldenrod;
            this.grpBasic.Location = new System.Drawing.Point(33, 117);
            this.grpBasic.Name = "grpBasic";
            this.grpBasic.Size = new System.Drawing.Size(651, 167);
            this.grpBasic.TabIndex = 0;
            this.grpBasic.TabStop = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Info;
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(185, 98);
            this.txtPhone.Mask = "(999)-000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(353, 29);
            this.txtPhone.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtEmail.Location = new System.Drawing.Point(185, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(353, 29);
            this.txtEmail.TabIndex = 4;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Info;
            this.txtFirstName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtFirstName.Location = new System.Drawing.Point(185, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(353, 29);
            this.txtFirstName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Sienna;
            this.label9.Location = new System.Drawing.Point(76, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 23);
            this.label9.TabIndex = 46;
            this.label9.Text = "Phone";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Sienna;
            this.label10.Location = new System.Drawing.Point(48, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 23);
            this.label10.TabIndex = 42;
            this.label10.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Sienna;
            this.label11.Location = new System.Drawing.Point(45, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 23);
            this.label11.TabIndex = 43;
            this.label11.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Info;
            this.txtLastName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtLastName.Location = new System.Drawing.Point(185, 63);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(353, 29);
            this.txtLastName.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(28, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Employees";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Sienna;
            this.lblName.Location = new System.Drawing.Point(11, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 23);
            this.lblName.TabIndex = 57;
            this.lblName.Text = "Employee Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(45, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 46;
            this.label3.Text = "Street";
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.SystemColors.Info;
            this.txtStreet.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtStreet.Location = new System.Drawing.Point(105, 93);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(175, 29);
            this.txtStreet.TabIndex = 8;
            this.txtStreet.TextChanged += new System.EventHandler(this.txtStreet_TextChanged);
            // 
            // lblPostalCode
            // 
            this.lblPostalCode.AutoSize = true;
            this.lblPostalCode.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCode.ForeColor = System.Drawing.Color.Sienna;
            this.lblPostalCode.Location = new System.Drawing.Point(6, 134);
            this.lblPostalCode.Name = "lblPostalCode";
            this.lblPostalCode.Size = new System.Drawing.Size(101, 23);
            this.lblPostalCode.TabIndex = 48;
            this.lblPostalCode.Text = "Postal Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(22, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 42;
            this.label6.Text = "Province";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(60, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 23);
            this.label5.TabIndex = 43;
            this.label5.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Info;
            this.txtCity.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtCity.Location = new System.Drawing.Point(105, 58);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(175, 29);
            this.txtCity.TabIndex = 7;
            // 
            // grpAdd
            // 
            this.grpAdd.BackColor = System.Drawing.Color.Transparent;
            this.grpAdd.Controls.Add(this.txtPostalCode);
            this.grpAdd.Controls.Add(this.cmbProvinces);
            this.grpAdd.Controls.Add(this.lblPostalCode);
            this.grpAdd.Controls.Add(this.label3);
            this.grpAdd.Controls.Add(this.label6);
            this.grpAdd.Controls.Add(this.txtStreet);
            this.grpAdd.Controls.Add(this.label5);
            this.grpAdd.Controls.Add(this.txtCity);
            this.grpAdd.Enabled = false;
            this.grpAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdd.ForeColor = System.Drawing.Color.Goldenrod;
            this.grpAdd.Location = new System.Drawing.Point(33, 285);
            this.grpAdd.Name = "grpAdd";
            this.grpAdd.Size = new System.Drawing.Size(301, 197);
            this.grpAdd.TabIndex = 5;
            this.grpAdd.TabStop = false;
            this.grpAdd.Text = "Address";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.BackColor = System.Drawing.SystemColors.Info;
            this.txtPostalCode.Enabled = false;
            this.txtPostalCode.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.Location = new System.Drawing.Point(105, 134);
            this.txtPostalCode.Mask = "L0L0L0";
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(175, 29);
            this.txtPostalCode.TabIndex = 9;
            // 
            // cmbProvinces
            // 
            this.cmbProvinces.BackColor = System.Drawing.SystemColors.Info;
            this.cmbProvinces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProvinces.Enabled = false;
            this.cmbProvinces.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProvinces.FormattingEnabled = true;
            this.cmbProvinces.ItemHeight = 23;
            this.cmbProvinces.Location = new System.Drawing.Point(105, 17);
            this.cmbProvinces.Name = "cmbProvinces";
            this.cmbProvinces.Size = new System.Drawing.Size(175, 31);
            this.cmbProvinces.TabIndex = 6;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(646, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 63;
            this.toolTip1.SetToolTip(this.btnClose, "Close");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnClancel.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnClancel, "Clear");
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
            this.btnNew.TabIndex = 17;
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
            this.btnEdit.TabIndex = 18;
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
            this.btnSave.TabIndex = 21;
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
            this.btnDelete.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlButton.Controls.Add(this.btnClancel);
            this.pnlButton.Controls.Add(this.btnNew);
            this.pnlButton.Controls.Add(this.btnEdit);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Controls.Add(this.btnDelete);
            this.pnlButton.Location = new System.Drawing.Point(146, 497);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(425, 66);
            this.pnlButton.TabIndex = 16;
            // 
            // grPInfo
            // 
            this.grPInfo.BackColor = System.Drawing.Color.Transparent;
            this.grPInfo.Controls.Add(this.pnlFullTimeData);
            this.grPInfo.Controls.Add(this.radFullTime);
            this.grPInfo.Controls.Add(this.radPartTime);
            this.grPInfo.Controls.Add(this.cmbRole);
            this.grPInfo.Controls.Add(this.label12);
            this.grPInfo.Enabled = false;
            this.grPInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grPInfo.ForeColor = System.Drawing.Color.Goldenrod;
            this.grPInfo.Location = new System.Drawing.Point(341, 285);
            this.grPInfo.Name = "grPInfo";
            this.grPInfo.Size = new System.Drawing.Size(339, 197);
            this.grPInfo.TabIndex = 10;
            this.grPInfo.TabStop = false;
            this.grPInfo.Text = "Emploment Information";
            // 
            // pnlFullTimeData
            // 
            this.pnlFullTimeData.Controls.Add(this.label7);
            this.pnlFullTimeData.Controls.Add(this.label1);
            this.pnlFullTimeData.Controls.Add(this.txtsalary);
            this.pnlFullTimeData.Controls.Add(this.dtpEmploymentDate);
            this.pnlFullTimeData.Controls.Add(this.label2);
            this.pnlFullTimeData.Location = new System.Drawing.Point(9, 91);
            this.pnlFullTimeData.Name = "pnlFullTimeData";
            this.pnlFullTimeData.Size = new System.Drawing.Size(324, 100);
            this.pnlFullTimeData.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(242, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 23);
            this.label7.TabIndex = 71;
            this.label7.Text = "CAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 69;
            this.label1.Text = "Salary";
            // 
            // txtsalary
            // 
            this.txtsalary.BackColor = System.Drawing.SystemColors.Info;
            this.txtsalary.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtsalary.Location = new System.Drawing.Point(89, 9);
            this.txtsalary.Name = "txtsalary";
            this.txtsalary.Size = new System.Drawing.Size(148, 29);
            this.txtsalary.TabIndex = 14;
            this.txtsalary.MouseLeave += new System.EventHandler(this.txtsalary_MouseLeave);
            // 
            // dtpEmploymentDate
            // 
            this.dtpEmploymentDate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEmploymentDate.Location = new System.Drawing.Point(19, 66);
            this.dtpEmploymentDate.Name = "dtpEmploymentDate";
            this.dtpEmploymentDate.Size = new System.Drawing.Size(292, 26);
            this.dtpEmploymentDate.TabIndex = 15;
            this.dtpEmploymentDate.ValueChanged += new System.EventHandler(this.dtpEmploymentDate_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "Employment Date";
            // 
            // radFullTime
            // 
            this.radFullTime.AutoSize = true;
            this.radFullTime.Checked = true;
            this.radFullTime.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radFullTime.ForeColor = System.Drawing.Color.Sienna;
            this.radFullTime.Location = new System.Drawing.Point(52, 23);
            this.radFullTime.Name = "radFullTime";
            this.radFullTime.Size = new System.Drawing.Size(97, 27);
            this.radFullTime.TabIndex = 11;
            this.radFullTime.TabStop = true;
            this.radFullTime.Text = "Full Time";
            this.radFullTime.UseVisualStyleBackColor = true;
            this.radFullTime.CheckedChanged += new System.EventHandler(this.radFullTime_CheckedChanged);
            // 
            // radPartTime
            // 
            this.radPartTime.AutoSize = true;
            this.radPartTime.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPartTime.ForeColor = System.Drawing.Color.Sienna;
            this.radPartTime.Location = new System.Drawing.Point(171, 23);
            this.radPartTime.Name = "radPartTime";
            this.radPartTime.Size = new System.Drawing.Size(99, 27);
            this.radPartTime.TabIndex = 12;
            this.radPartTime.Text = "Part Time";
            this.radPartTime.UseVisualStyleBackColor = true;
            this.radPartTime.CheckedChanged += new System.EventHandler(this.radPartTime_CheckedChanged);
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.SystemColors.Info;
            this.cmbRole.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Kitchen assistants",
            "Helper"});
            this.cmbRole.Location = new System.Drawing.Point(98, 58);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(222, 31);
            this.cmbRole.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Sienna;
            this.label12.Location = new System.Drawing.Point(48, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 23);
            this.label12.TabIndex = 43;
            this.label12.Text = "Role";
            // 
            // pnlEmployeeName
            // 
            this.pnlEmployeeName.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmployeeName.Controls.Add(this.lblName);
            this.pnlEmployeeName.Controls.Add(this.cmbName);
            this.pnlEmployeeName.Location = new System.Drawing.Point(33, 65);
            this.pnlEmployeeName.Name = "pnlEmployeeName";
            this.pnlEmployeeName.Size = new System.Drawing.Size(651, 46);
            this.pnlEmployeeName.TabIndex = 64;
            this.pnlEmployeeName.Visible = false;
            // 
            // erPEmployeeForm
            // 
            this.erPEmployeeForm.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erPEmployeeForm.ContainerControl = this;
            // 
            // frmManageEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(721, 588);
            this.Controls.Add(this.pnlEmployeeName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grPInfo);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.grpBasic);
            this.Controls.Add(this.grpAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Sienna;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageEmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageEmpForm";
            this.Load += new System.EventHandler(this.frmManagEmp_Load);
            this.grpBasic.ResumeLayout(false);
            this.grpBasic.PerformLayout();
            this.grpAdd.ResumeLayout(false);
            this.grpAdd.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.grPInfo.ResumeLayout(false);
            this.grPInfo.PerformLayout();
            this.pnlFullTimeData.ResumeLayout(false);
            this.pnlFullTimeData.PerformLayout();
            this.pnlEmployeeName.ResumeLayout(false);
            this.pnlEmployeeName.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erPEmployeeForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grpBasic;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblPostalCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.GroupBox grpAdd;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnClancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox grPInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radFullTime;
        private System.Windows.Forms.RadioButton radPartTime;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlEmployeeName;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.ComboBox cmbProvinces;
        private System.Windows.Forms.MaskedTextBox txtPostalCode;
        private System.Windows.Forms.ErrorProvider erPEmployeeForm;
        private System.Windows.Forms.Panel pnlFullTimeData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsalary;
        private System.Windows.Forms.DateTimePicker dtpEmploymentDate;
        private System.Windows.Forms.Label label2;
    }
}