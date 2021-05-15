namespace AuntRosieApplication.Expenses
{
    partial class frmCostExpenseQueries
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
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpFormDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.grdCost = new System.Windows.Forms.DataGridView();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expCpstQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSet = new AuntRosieApplication.ReportDataSet();
            this.chkAlltime = new System.Windows.Forms.CheckBox();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.expCpstQueryTableAdapter = new AuntRosieApplication.ReportDataSetTableAdapters.ExpCpstQueryTableAdapter();
            this.pnlType = new System.Windows.Forms.Panel();
            this.cmbExpensesType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkExpenType = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkPay = new System.Windows.Forms.CheckBox();
            this.pnlPay = new System.Windows.Forms.Panel();
            this.lblITotAmount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expCpstQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            this.pnlDate.SuspendLayout();
            this.pnlType.SuspendLayout();
            this.pnlPay.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 24);
            this.label9.TabIndex = 107;
            this.label9.Tag = "";
            this.label9.Text = "From Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 24);
            this.label10.TabIndex = 108;
            this.label10.Tag = "";
            this.label10.Text = "To Date";
            // 
            // dtpFormDate
            // 
            this.dtpFormDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFormDate.Location = new System.Drawing.Point(187, 3);
            this.dtpFormDate.Name = "dtpFormDate";
            this.dtpFormDate.Size = new System.Drawing.Size(330, 26);
            this.dtpFormDate.TabIndex = 3;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToDate.Location = new System.Drawing.Point(187, 35);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(330, 26);
            this.dtpToDate.TabIndex = 4;
            // 
            // grdCost
            // 
            this.grdCost.AllowUserToAddRows = false;
            this.grdCost.AllowUserToDeleteRows = false;
            this.grdCost.AutoGenerateColumns = false;
            this.grdCost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCost.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.grdCost.DataSource = this.expCpstQueryBindingSource;
            this.grdCost.Location = new System.Drawing.Point(51, 340);
            this.grdCost.Name = "grdCost";
            this.grdCost.ReadOnly = true;
            this.grdCost.Size = new System.Drawing.Size(616, 309);
            this.grdCost.TabIndex = 109;
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            this.paymentMethodDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentMethodDataGridViewTextBoxColumn.Width = 130;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            this.typeDataGridViewTextBoxColumn.Width = 200;
            // 
            // expCpstQueryBindingSource
            // 
            this.expCpstQueryBindingSource.DataMember = "ExpCpstQuery";
            this.expCpstQueryBindingSource.DataSource = this.reportDataSet;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chkAlltime
            // 
            this.chkAlltime.AutoSize = true;
            this.chkAlltime.BackColor = System.Drawing.Color.Transparent;
            this.chkAlltime.Checked = true;
            this.chkAlltime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlltime.Location = new System.Drawing.Point(51, 72);
            this.chkAlltime.Name = "chkAlltime";
            this.chkAlltime.Size = new System.Drawing.Size(149, 19);
            this.chkAlltime.TabIndex = 1;
            this.chkAlltime.Text = "Not Specific Period";
            this.chkAlltime.UseVisualStyleBackColor = false;
            this.chkAlltime.CheckedChanged += new System.EventHandler(this.chkAlltime_CheckedChanged);
            // 
            // pnlDate
            // 
            this.pnlDate.BackColor = System.Drawing.Color.Transparent;
            this.pnlDate.Controls.Add(this.dtpFormDate);
            this.pnlDate.Controls.Add(this.dtpToDate);
            this.pnlDate.Controls.Add(this.label10);
            this.pnlDate.Controls.Add(this.label9);
            this.pnlDate.Enabled = false;
            this.pnlDate.Location = new System.Drawing.Point(51, 91);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(546, 65);
            this.pnlDate.TabIndex = 2;
            // 
            // expCpstQueryTableAdapter
            // 
            this.expCpstQueryTableAdapter.ClearBeforeFill = true;
            // 
            // pnlType
            // 
            this.pnlType.BackColor = System.Drawing.Color.Transparent;
            this.pnlType.Controls.Add(this.cmbExpensesType);
            this.pnlType.Controls.Add(this.label1);
            this.pnlType.Enabled = false;
            this.pnlType.Location = new System.Drawing.Point(51, 179);
            this.pnlType.Name = "pnlType";
            this.pnlType.Size = new System.Drawing.Size(546, 47);
            this.pnlType.TabIndex = 6;
            // 
            // cmbExpensesType
            // 
            this.cmbExpensesType.BackColor = System.Drawing.SystemColors.Info;
            this.cmbExpensesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExpensesType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExpensesType.FormattingEnabled = true;
            this.cmbExpensesType.Items.AddRange(new object[] {
            "Full Timer Payroll",
            "Part Timer Payroll",
            "Miscellaneous Expense",
            "Inventory-in Stock"});
            this.cmbExpensesType.Location = new System.Drawing.Point(187, 6);
            this.cmbExpensesType.Name = "cmbExpensesType";
            this.cmbExpensesType.Size = new System.Drawing.Size(344, 31);
            this.cmbExpensesType.TabIndex = 7;
            this.cmbExpensesType.SelectedIndexChanged += new System.EventHandler(this.cmbExpensesType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 123;
            this.label1.Text = "Cost Type";
            // 
            // chkExpenType
            // 
            this.chkExpenType.AutoSize = true;
            this.chkExpenType.BackColor = System.Drawing.Color.Transparent;
            this.chkExpenType.Checked = true;
            this.chkExpenType.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExpenType.Location = new System.Drawing.Point(54, 158);
            this.chkExpenType.Name = "chkExpenType";
            this.chkExpenType.Size = new System.Drawing.Size(137, 19);
            this.chkExpenType.TabIndex = 5;
            this.chkExpenType.Text = "Not Specific Type";
            this.chkExpenType.UseVisualStyleBackColor = false;
            this.chkExpenType.CheckedChanged += new System.EventHandler(this.chkExpenType_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label20.Location = new System.Drawing.Point(46, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(414, 30);
            this.label20.TabIndex = 150;
            this.label20.Text = "Cost and Expenses Queries";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(644, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 149;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPart.FlatAppearance.BorderSize = 0;
            this.btnAddPart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPart.Image = global::AuntRosieApplication.Properties.Resources.search;
            this.btnAddPart.Location = new System.Drawing.Point(605, 288);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(62, 49);
            this.btnAddPart.TabIndex = 151;
            this.toolTip1.SetToolTip(this.btnAddPart, "Click to view results");
            this.btnAddPart.UseVisualStyleBackColor = false;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.BackColor = System.Drawing.SystemColors.Info;
            this.cmbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethod.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(184, 5);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(345, 31);
            this.cmbPaymentMethod.TabIndex = 10;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 22);
            this.label2.TabIndex = 153;
            this.label2.Tag = "";
            this.label2.Text = "Payment Method";
            // 
            // chkPay
            // 
            this.chkPay.AutoSize = true;
            this.chkPay.BackColor = System.Drawing.Color.Transparent;
            this.chkPay.Checked = true;
            this.chkPay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPay.Location = new System.Drawing.Point(54, 230);
            this.chkPay.Name = "chkPay";
            this.chkPay.Size = new System.Drawing.Size(155, 19);
            this.chkPay.TabIndex = 8;
            this.chkPay.Text = "Not Specific Method";
            this.chkPay.UseVisualStyleBackColor = false;
            this.chkPay.CheckedChanged += new System.EventHandler(this.chkPay_CheckedChanged);
            // 
            // pnlPay
            // 
            this.pnlPay.BackColor = System.Drawing.Color.Transparent;
            this.pnlPay.Controls.Add(this.label2);
            this.pnlPay.Controls.Add(this.cmbPaymentMethod);
            this.pnlPay.Enabled = false;
            this.pnlPay.Location = new System.Drawing.Point(53, 253);
            this.pnlPay.Name = "pnlPay";
            this.pnlPay.Size = new System.Drawing.Size(546, 47);
            this.pnlPay.TabIndex = 9;
            // 
            // lblITotAmount
            // 
            this.lblITotAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblITotAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblITotAmount.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblITotAmount.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblITotAmount.Location = new System.Drawing.Point(238, 303);
            this.lblITotAmount.Name = "lblITotAmount";
            this.lblITotAmount.Size = new System.Drawing.Size(361, 34);
            this.lblITotAmount.TabIndex = 156;
            this.lblITotAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(99, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 155;
            this.label3.Text = "Total Amount";
            // 
            // frmCostExpenseQueries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(733, 701);
            this.Controls.Add(this.lblITotAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlPay);
            this.Controls.Add(this.chkPay);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkExpenType);
            this.Controls.Add(this.pnlType);
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.chkAlltime);
            this.Controls.Add(this.grdCost);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Sienna;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCostExpenseQueries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CostExpenseQueriesForm";
            this.Load += new System.EventHandler(this.frmCostExpenseQueries_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expCpstQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.pnlType.ResumeLayout(false);
            this.pnlType.PerformLayout();
            this.pnlPay.ResumeLayout(false);
            this.pnlPay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpFormDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.DataGridView grdCost;
        private System.Windows.Forms.BindingSource expCpstQueryBindingSource;
        private ReportDataSet reportDataSet;
        private ReportDataSetTableAdapters.ExpCpstQueryTableAdapter expCpstQueryTableAdapter;
        private System.Windows.Forms.CheckBox chkAlltime;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Panel pnlType;
        private System.Windows.Forms.CheckBox chkExpenType;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbExpensesType;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkPay;
        private System.Windows.Forms.Panel pnlPay;
        private System.Windows.Forms.Label lblITotAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}