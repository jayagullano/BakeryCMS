namespace AuntRosieApplication.Kitchen
{
    partial class frmViewProduction
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.chkAllProducts = new System.Windows.Forms.CheckBox();
            this.chkAllTypes = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.dtgProduction = new System.Windows.Forms.DataGridView();
            this.tblProductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auntRosieDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auntRosieDBDataSet = new AuntRosieApplication.AuntRosieDBDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.tblProductionTableAdapter = new AuntRosieApplication.AuntRosieDBDataSetTableAdapters.tblProductionTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 78);
            this.panel1.TabIndex = 141;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(769, 11);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 52);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(12, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 30);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Production History";
            // 
            // chkAllProducts
            // 
            this.chkAllProducts.AutoSize = true;
            this.chkAllProducts.BackColor = System.Drawing.Color.Transparent;
            this.chkAllProducts.Checked = true;
            this.chkAllProducts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllProducts.Enabled = false;
            this.chkAllProducts.Font = new System.Drawing.Font("Arial", 14.25F);
            this.chkAllProducts.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkAllProducts.Location = new System.Drawing.Point(580, 86);
            this.chkAllProducts.Name = "chkAllProducts";
            this.chkAllProducts.Size = new System.Drawing.Size(131, 26);
            this.chkAllProducts.TabIndex = 150;
            this.chkAllProducts.Text = "All Products";
            this.chkAllProducts.UseVisualStyleBackColor = false;
            // 
            // chkAllTypes
            // 
            this.chkAllTypes.AutoSize = true;
            this.chkAllTypes.BackColor = System.Drawing.Color.Transparent;
            this.chkAllTypes.Checked = true;
            this.chkAllTypes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllTypes.Font = new System.Drawing.Font("Arial", 14.25F);
            this.chkAllTypes.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkAllTypes.Location = new System.Drawing.Point(215, 96);
            this.chkAllTypes.Name = "chkAllTypes";
            this.chkAllTypes.Size = new System.Drawing.Size(107, 26);
            this.chkAllTypes.TabIndex = 149;
            this.chkAllTypes.Text = "All Types";
            this.chkAllTypes.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(628, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 67);
            this.panel2.TabIndex = 146;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AuntRosieApplication.Properties.Resources.print;
            this.button1.Location = new System.Drawing.Point(29, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 55);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(456, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 148;
            this.label1.Text = "Product";
            // 
            // cmbName
            // 
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.Enabled = false;
            this.cmbName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(579, 123);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(235, 31);
            this.cmbName.TabIndex = 145;
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(215, 128);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(235, 31);
            this.cmbType.TabIndex = 144;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Sienna;
            this.label15.Location = new System.Drawing.Point(52, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(135, 22);
            this.label15.TabIndex = 147;
            this.label15.Text = "Product Type";
            // 
            // dtgProduction
            // 
            this.dtgProduction.AllowUserToOrderColumns = true;
            this.dtgProduction.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.dtgProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduction.Location = new System.Drawing.Point(23, 288);
            this.dtgProduction.Name = "dtgProduction";
            this.dtgProduction.Size = new System.Drawing.Size(753, 327);
            this.dtgProduction.TabIndex = 151;
            // 
            // tblProductionBindingSource
            // 
            this.tblProductionBindingSource.DataMember = "tblProduction";
            this.tblProductionBindingSource.DataSource = this.auntRosieDBDataSetBindingSource;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(52, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 22);
            this.label2.TabIndex = 152;
            this.label2.Text = "From (production date)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(77, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 22);
            this.label3.TabIndex = 153;
            this.label3.Text = "To (production date)";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Location = new System.Drawing.Point(282, 179);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 29);
            this.dtpFrom.TabIndex = 154;
            this.dtpFrom.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpTo
            // 
            this.dtpTo.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Location = new System.Drawing.Point(282, 227);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 29);
            this.dtpTo.TabIndex = 155;
            this.dtpTo.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // tblProductionTableAdapter
            // 
            this.tblProductionTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 633);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgProduction);
            this.Controls.Add(this.chkAllProducts);
            this.Controls.Add(this.chkAllTypes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewProduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProduction";
            this.Load += new System.EventHandler(this.ViewProduction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox chkAllProducts;
        private System.Windows.Forms.CheckBox chkAllTypes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dtgProduction;
        private System.Windows.Forms.BindingSource auntRosieDBDataSetBindingSource;
        private AuntRosieDBDataSet auntRosieDBDataSet;
        private System.Windows.Forms.BindingSource tblProductionBindingSource;
        private AuntRosieDBDataSetTableAdapters.tblProductionTableAdapter tblProductionTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
    }
}