namespace AuntRosieApplication.Expenses
{
    partial class frmExpensesManage
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
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFormDate = new System.Windows.Forms.DateTimePicker();
            this.grbNew = new System.Windows.Forms.GroupBox();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.radToday = new System.Windows.Forms.RadioButton();
            this.radLastMonth = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEventLocation = new System.Windows.Forms.Label();
            this.cmbEventName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVal = new System.Windows.Forms.TextBox();
            this.grdExpenses = new System.Windows.Forms.DataGridView();
            this.expenseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tblMiscellaneousExpenseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSet = new AuntRosieApplication.ReportDataSet();
            this.btnAddFull = new System.Windows.Forms.Button();
            this.chkIsEvent = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbExpensesType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tblMiscellaneousExpenseTableAdapter = new AuntRosieApplication.ReportDataSetTableAdapters.tblMiscellaneousExpenseTableAdapter();
            this.tblMiscellaneousExpenseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblMiscellaneousExpenseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.errExpense = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grbNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMiscellaneousExpenseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMiscellaneousExpenseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMiscellaneousExpenseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errExpense)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.SystemColors.Info;
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(306, 118);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(281, 31);
            this.cmbPaymentMethod.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(123, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 24);
            this.label6.TabIndex = 128;
            this.label6.Tag = "";
            this.label6.Text = "Payment Method";
            // 
            // dtpFormDate
            // 
            this.dtpFormDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFormDate.Location = new System.Drawing.Point(306, 86);
            this.dtpFormDate.Name = "dtpFormDate";
            this.dtpFormDate.Size = new System.Drawing.Size(281, 26);
            this.dtpFormDate.TabIndex = 0;
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
            this.grbNew.Enabled = false;
            this.grbNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grbNew.ForeColor = System.Drawing.Color.Sienna;
            this.grbNew.Location = new System.Drawing.Point(75, 240);
            this.grbNew.Name = "grbNew";
            this.grbNew.Size = new System.Drawing.Size(662, 117);
            this.grbNew.TabIndex = 5;
            this.grbNew.TabStop = false;
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radAll.Location = new System.Drawing.Point(424, 12);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(44, 24);
            this.radAll.TabIndex = 8;
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
            this.radToday.TabIndex = 6;
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
            this.radLastMonth.TabIndex = 7;
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
            this.lblEventLocation.Size = new System.Drawing.Size(604, 30);
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
            this.cmbEventName.Size = new System.Drawing.Size(458, 31);
            this.cmbEventName.TabIndex = 9;
            this.cmbEventName.SelectedIndexChanged += new System.EventHandler(this.cmbEventName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(237, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 140;
            this.label2.Text = "Value";
            // 
            // txtVal
            // 
            this.txtVal.BackColor = System.Drawing.SystemColors.Info;
            this.txtVal.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtVal.Location = new System.Drawing.Point(306, 194);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(224, 29);
            this.txtVal.TabIndex = 3;
            this.txtVal.MouseLeave += new System.EventHandler(this.txtVal_MouseLeave);
            // 
            // grdExpenses
            // 
            this.grdExpenses.AllowUserToAddRows = false;
            this.grdExpenses.AutoGenerateColumns = false;
            this.grdExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expenseIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.expenseTypeDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn2,
            this.Delete});
            this.grdExpenses.DataSource = this.tblMiscellaneousExpenseBindingSource2;
            this.grdExpenses.Location = new System.Drawing.Point(25, 443);
            this.grdExpenses.Name = "grdExpenses";
            this.grdExpenses.Size = new System.Drawing.Size(765, 203);
            this.grdExpenses.TabIndex = 12;
            this.grdExpenses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdExpenses_CellContentClick);
            // 
            // expenseIDDataGridViewTextBoxColumn
            // 
            this.expenseIDDataGridViewTextBoxColumn.DataPropertyName = "ExpenseID";
            this.expenseIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.expenseIDDataGridViewTextBoxColumn.Name = "expenseIDDataGridViewTextBoxColumn";
            this.expenseIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.expenseIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ExpensePayDate";
            this.dataGridViewTextBoxColumn1.HeaderText = "Pay Date";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ExpenseValue";
            this.dataGridViewTextBoxColumn3.HeaderText = "Value";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "Payment Method";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            this.paymentMethodDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentMethodDataGridViewTextBoxColumn.Width = 120;
            // 
            // expenseTypeDataGridViewTextBoxColumn
            // 
            this.expenseTypeDataGridViewTextBoxColumn.DataPropertyName = "ExpenseType";
            this.expenseTypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.expenseTypeDataGridViewTextBoxColumn.Name = "expenseTypeDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ExpenseNote";
            this.dataGridViewTextBoxColumn2.HeaderText = "Note";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // tblMiscellaneousExpenseBindingSource2
            // 
            this.tblMiscellaneousExpenseBindingSource2.DataMember = "tblMiscellaneousExpense";
            this.tblMiscellaneousExpenseBindingSource2.DataSource = this.reportDataSet;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddFull
            // 
            this.btnAddFull.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFull.FlatAppearance.BorderSize = 0;
            this.btnAddFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFull.Image = global::AuntRosieApplication.Properties.Resources.low_importance;
            this.btnAddFull.Location = new System.Drawing.Point(654, 360);
            this.btnAddFull.Name = "btnAddFull";
            this.btnAddFull.Size = new System.Drawing.Size(31, 35);
            this.btnAddFull.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnAddFull, "Add Expenses");
            this.btnAddFull.UseVisualStyleBackColor = false;
            this.btnAddFull.Click += new System.EventHandler(this.btnAddFull_Click);
            // 
            // chkIsEvent
            // 
            this.chkIsEvent.AutoSize = true;
            this.chkIsEvent.BackColor = System.Drawing.Color.Transparent;
            this.chkIsEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkIsEvent.ForeColor = System.Drawing.Color.Sienna;
            this.chkIsEvent.Location = new System.Drawing.Point(85, 222);
            this.chkIsEvent.Name = "chkIsEvent";
            this.chkIsEvent.Size = new System.Drawing.Size(157, 24);
            this.chkIsEvent.TabIndex = 4;
            this.chkIsEvent.Text = "Event Expenses";
            this.chkIsEvent.UseVisualStyleBackColor = false;
            this.chkIsEvent.CheckedChanged += new System.EventHandler(this.chkIsEvent_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(104, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 23);
            this.label1.TabIndex = 146;
            this.label1.Text = "Note";
            // 
            // txtNote
            // 
            this.txtNote.BackColor = System.Drawing.SystemColors.Info;
            this.txtNote.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtNote.Location = new System.Drawing.Point(190, 361);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(458, 76);
            this.txtNote.TabIndex = 10;
            this.txtNote.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(237, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 147;
            this.label3.Text = "Date";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label20.Location = new System.Drawing.Point(47, 40);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(506, 30);
            this.label20.TabIndex = 148;
            this.label20.Text = "Manage Miscellaneous Expenses";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(697, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 13;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbExpensesType
            // 
            this.cmbExpensesType.BackColor = System.Drawing.SystemColors.Info;
            this.cmbExpensesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpensesType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpensesType.FormattingEnabled = true;
            this.cmbExpensesType.Location = new System.Drawing.Point(306, 155);
            this.cmbExpensesType.Name = "cmbExpensesType";
            this.cmbExpensesType.Size = new System.Drawing.Size(281, 31);
            this.cmbExpensesType.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Sienna;
            this.label4.Location = new System.Drawing.Point(162, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 23);
            this.label4.TabIndex = 151;
            this.label4.Text = "Expenses Type";
            // 
            // tblMiscellaneousExpenseTableAdapter
            // 
            this.tblMiscellaneousExpenseTableAdapter.ClearBeforeFill = true;
            // 
            // tblMiscellaneousExpenseBindingSource
            // 
            this.tblMiscellaneousExpenseBindingSource.DataMember = "tblMiscellaneousExpense";
            // 
            // tblMiscellaneousExpenseBindingSource1
            // 
            this.tblMiscellaneousExpenseBindingSource1.DataMember = "tblMiscellaneousExpense";
            this.tblMiscellaneousExpenseBindingSource1.DataSource = this.reportDataSet;
            // 
            // errExpense
            // 
            this.errExpense.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errExpense.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(536, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 22);
            this.label5.TabIndex = 152;
            this.label5.Text = "CAD";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::AuntRosieApplication.Properties.Resources.delete_sign1;
            this.btnClear.Location = new System.Drawing.Point(654, 396);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(31, 35);
            this.btnClear.TabIndex = 153;
            this.toolTip1.SetToolTip(this.btnClear, "Clear Expenses");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmExpensesManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 652);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbExpensesType);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.chkIsEvent);
            this.Controls.Add(this.btnAddFull);
            this.Controls.Add(this.grdExpenses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtVal);
            this.Controls.Add(this.grbNew);
            this.Controls.Add(this.cmbPaymentMethod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFormDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExpensesManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MnageExpensesForm";
            this.Load += new System.EventHandler(this.frnManageExpenses_Load);
            this.grbNew.ResumeLayout(false);
            this.grbNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdExpenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMiscellaneousExpenseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMiscellaneousExpenseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblMiscellaneousExpenseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errExpense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFormDate;
        private System.Windows.Forms.GroupBox grbNew;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.RadioButton radToday;
        private System.Windows.Forms.RadioButton radLastMonth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEventLocation;
        private System.Windows.Forms.ComboBox cmbEventName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.DataGridView grdExpenses;
        private System.Windows.Forms.Button btnAddFull;
        private System.Windows.Forms.CheckBox chkIsEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbExpensesType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseType1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensePayDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblMiscellaneousExpenseBindingSource2;
        private ReportDataSet reportDataSet;
        private ReportDataSetTableAdapters.tblMiscellaneousExpenseTableAdapter tblMiscellaneousExpenseTableAdapter;
        private System.Windows.Forms.BindingSource tblMiscellaneousExpenseBindingSource;
        private System.Windows.Forms.BindingSource tblMiscellaneousExpenseBindingSource1;
        private System.Windows.Forms.ErrorProvider errExpense;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}