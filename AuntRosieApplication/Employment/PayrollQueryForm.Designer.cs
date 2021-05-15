namespace AuntRosieApplication.Employment
{
    partial class PayrollQueryForm
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEmployeeName = new System.Windows.Forms.ComboBox();
            this.radPart = new System.Windows.Forms.RadioButton();
            this.radFull = new System.Windows.Forms.RadioButton();
            this.grdPayrollPart = new System.Windows.Forms.DataGridView();
            this.paymentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPayrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSet = new AuntRosieApplication.ReportDataSet();
            this.grdPayrollFull = new System.Windows.Forms.DataGridView();
            this.paymentDateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentMethodDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.biWeekNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFullTimePayrollBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSet1 = new AuntRosieApplication.ReportDataSet();
            this.auntRosieDBDataSet = new AuntRosieApplication.AuntRosieDBDataSet();
            this.payrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollTableAdapter = new AuntRosieApplication.AuntRosieDBDataSetTableAdapters.payrollTableAdapter();
            this.tblFullTimePayrollTableAdapter = new AuntRosieApplication.ReportDataSetTableAdapters.tblFullTimePayrollTableAdapter();
            this.tblFullTimePayrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPayrollTableAdapter = new AuntRosieApplication.ReportDataSetTableAdapters.tblPayrollTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayrollPart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayrollFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFullTimePayrollBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFullTimePayrollBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(64, 22);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(411, 30);
            this.lblTitle.TabIndex = 117;
            this.lblTitle.Text = "Employee Payroll Queries";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(630, 22);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(48, 52);
            this.btnClose.TabIndex = 118;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 24);
            this.label1.TabIndex = 122;
            this.label1.Text = "Employee Name";
            // 
            // cmbEmployeeName
            // 
            this.cmbEmployeeName.BackColor = System.Drawing.SystemColors.Info;
            this.cmbEmployeeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployeeName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployeeName.FormattingEnabled = true;
            this.cmbEmployeeName.Location = new System.Drawing.Point(220, 122);
            this.cmbEmployeeName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEmployeeName.Name = "cmbEmployeeName";
            this.cmbEmployeeName.Size = new System.Drawing.Size(320, 31);
            this.cmbEmployeeName.TabIndex = 3;
            this.cmbEmployeeName.SelectedIndexChanged += new System.EventHandler(this.cmbEmployeeName_SelectedIndexChanged);
            // 
            // radPart
            // 
            this.radPart.AutoSize = true;
            this.radPart.BackColor = System.Drawing.Color.Transparent;
            this.radPart.Location = new System.Drawing.Point(324, 82);
            this.radPart.Margin = new System.Windows.Forms.Padding(4);
            this.radPart.Name = "radPart";
            this.radPart.Size = new System.Drawing.Size(88, 20);
            this.radPart.TabIndex = 2;
            this.radPart.Text = "Part Timer";
            this.radPart.UseVisualStyleBackColor = false;
            this.radPart.CheckedChanged += new System.EventHandler(this.radPart_CheckedChanged);
            // 
            // radFull
            // 
            this.radFull.AutoSize = true;
            this.radFull.BackColor = System.Drawing.Color.Transparent;
            this.radFull.Checked = true;
            this.radFull.Location = new System.Drawing.Point(220, 82);
            this.radFull.Margin = new System.Windows.Forms.Padding(4);
            this.radFull.Name = "radFull";
            this.radFull.Size = new System.Drawing.Size(85, 20);
            this.radFull.TabIndex = 1;
            this.radFull.TabStop = true;
            this.radFull.Text = "Full Timer";
            this.radFull.UseVisualStyleBackColor = false;
            this.radFull.CheckedChanged += new System.EventHandler(this.radFull_CheckedChanged);
            // 
            // grdPayrollPart
            // 
            this.grdPayrollPart.AllowUserToAddRows = false;
            this.grdPayrollPart.AllowUserToDeleteRows = false;
            this.grdPayrollPart.AutoGenerateColumns = false;
            this.grdPayrollPart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPayrollPart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentDateDataGridViewTextBoxColumn,
            this.paymentMethodDataGridViewTextBoxColumn,
            this.fromDateDataGridViewTextBoxColumn,
            this.toDateDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.grdPayrollPart.DataSource = this.tblPayrollBindingSource;
            this.grdPayrollPart.Location = new System.Drawing.Point(38, 181);
            this.grdPayrollPart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdPayrollPart.Name = "grdPayrollPart";
            this.grdPayrollPart.ReadOnly = true;
            this.grdPayrollPart.Size = new System.Drawing.Size(608, 237);
            this.grdPayrollPart.TabIndex = 126;
            this.grdPayrollPart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPayrollPart_CellContentClick);
            // 
            // paymentDateDataGridViewTextBoxColumn
            // 
            this.paymentDateDataGridViewTextBoxColumn.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.HeaderText = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn.Name = "paymentDateDataGridViewTextBoxColumn";
            this.paymentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paymentMethodDataGridViewTextBoxColumn
            // 
            this.paymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn.Name = "paymentMethodDataGridViewTextBoxColumn";
            this.paymentMethodDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentMethodDataGridViewTextBoxColumn.Width = 120;
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
            // tblPayrollBindingSource
            // 
            this.tblPayrollBindingSource.DataMember = "tblPayroll";
            this.tblPayrollBindingSource.DataSource = this.reportDataSet;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // grdPayrollFull
            // 
            this.grdPayrollFull.AllowUserToAddRows = false;
            this.grdPayrollFull.AllowUserToDeleteRows = false;
            this.grdPayrollFull.AutoGenerateColumns = false;
            this.grdPayrollFull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPayrollFull.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.paymentDateDataGridViewTextBoxColumn1,
            this.paymentMethodDataGridViewTextBoxColumn1,
            this.yearDataGridViewTextBoxColumn,
            this.monthDataGridViewTextBoxColumn,
            this.biWeekNoDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn1});
            this.grdPayrollFull.DataSource = this.tblFullTimePayrollBindingSource1;
            this.grdPayrollFull.Location = new System.Drawing.Point(38, 181);
            this.grdPayrollFull.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdPayrollFull.Name = "grdPayrollFull";
            this.grdPayrollFull.ReadOnly = true;
            this.grdPayrollFull.Size = new System.Drawing.Size(609, 237);
            this.grdPayrollFull.TabIndex = 4;
            // 
            // paymentDateDataGridViewTextBoxColumn1
            // 
            this.paymentDateDataGridViewTextBoxColumn1.DataPropertyName = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn1.HeaderText = "PaymentDate";
            this.paymentDateDataGridViewTextBoxColumn1.Name = "paymentDateDataGridViewTextBoxColumn1";
            this.paymentDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // paymentMethodDataGridViewTextBoxColumn1
            // 
            this.paymentMethodDataGridViewTextBoxColumn1.DataPropertyName = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn1.HeaderText = "PaymentMethod";
            this.paymentMethodDataGridViewTextBoxColumn1.Name = "paymentMethodDataGridViewTextBoxColumn1";
            this.paymentMethodDataGridViewTextBoxColumn1.ReadOnly = true;
            this.paymentMethodDataGridViewTextBoxColumn1.Width = 120;
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "Year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "Year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            this.yearDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearDataGridViewTextBoxColumn.Width = 50;
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.ReadOnly = true;
            this.monthDataGridViewTextBoxColumn.Width = 50;
            // 
            // biWeekNoDataGridViewTextBoxColumn
            // 
            this.biWeekNoDataGridViewTextBoxColumn.DataPropertyName = "BiWeekNo";
            this.biWeekNoDataGridViewTextBoxColumn.HeaderText = "BiWeekNo";
            this.biWeekNoDataGridViewTextBoxColumn.Name = "biWeekNoDataGridViewTextBoxColumn";
            this.biWeekNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            this.amountDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tblFullTimePayrollBindingSource1
            // 
            this.tblFullTimePayrollBindingSource1.DataMember = "tblFullTimePayroll";
            this.tblFullTimePayrollBindingSource1.DataSource = this.reportDataSet1;
            // 
            // reportDataSet1
            // 
            this.reportDataSet1.DataSetName = "ReportDataSet";
            this.reportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auntRosieDBDataSet
            // 
            this.auntRosieDBDataSet.DataSetName = "AuntRosieDBDataSet";
            this.auntRosieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payrollBindingSource
            // 
            this.payrollBindingSource.DataMember = "payroll";
            this.payrollBindingSource.DataSource = this.auntRosieDBDataSet;
            // 
            // payrollTableAdapter
            // 
            this.payrollTableAdapter.ClearBeforeFill = true;
            // 
            // tblFullTimePayrollTableAdapter
            // 
            this.tblFullTimePayrollTableAdapter.ClearBeforeFill = true;
            // 
            // tblFullTimePayrollBindingSource
            // 
            this.tblFullTimePayrollBindingSource.DataMember = "tblFullTimePayroll";
            this.tblFullTimePayrollBindingSource.DataSource = this.reportDataSet;
            // 
            // tblPayrollTableAdapter
            // 
            this.tblPayrollTableAdapter.ClearBeforeFill = true;
            // 
            // PayrollQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(686, 462);
            this.Controls.Add(this.grdPayrollFull);
            this.Controls.Add(this.radFull);
            this.Controls.Add(this.radPart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmployeeName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grdPayrollPart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Sienna;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PayrollQueryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PayrollMnueForm";
            this.Load += new System.EventHandler(this.PayrollMnueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdPayrollPart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPayrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPayrollFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFullTimePayrollBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFullTimePayrollBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEmployeeName;
        private System.Windows.Forms.RadioButton radPart;
        private System.Windows.Forms.RadioButton radFull;
        private System.Windows.Forms.DataGridView grdPayrollPart;
        private System.Windows.Forms.DataGridView grdPayrollFull;
        private AuntRosieDBDataSet auntRosieDBDataSet;
        private System.Windows.Forms.BindingSource payrollBindingSource;
        private AuntRosieDBDataSetTableAdapters.payrollTableAdapter payrollTableAdapter;
        private System.Windows.Forms.BindingSource tblPayrollBindingSource;
        private ReportDataSet reportDataSet;
        private System.Windows.Forms.BindingSource tblFullTimePayrollBindingSource;
        private ReportDataSetTableAdapters.tblPayrollTableAdapter tblPayrollTableAdapter;
        private ReportDataSetTableAdapters.tblFullTimePayrollTableAdapter tblFullTimePayrollTableAdapter;
        private ReportDataSet reportDataSet1;
        private System.Windows.Forms.BindingSource tblFullTimePayrollBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentDateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentMethodDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn biWeekNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
    }
}