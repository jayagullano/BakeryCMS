namespace AuntRosieApplication.Inventory
{
    partial class frmInventoryStock
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
            this.label15 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdStock = new System.Windows.Forms.DataGridView();
            this.supplierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ingredientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expiryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockQueryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auntRosieDBDataSet = new AuntRosieApplication.AuntRosieDBDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.chkAllTypies = new System.Windows.Forms.CheckBox();
            this.chkAllIngrdient = new System.Windows.Forms.CheckBox();
            this.chkExpierd = new System.Windows.Forms.CheckBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.stockQueryTableAdapter = new AuntRosieApplication.AuntRosieDBDataSetTableAdapters.StockQueryTableAdapter();
            this.lblQuantityType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockQueryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Sienna;
            this.label15.Location = new System.Drawing.Point(220, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 22);
            this.label15.TabIndex = 104;
            this.label15.Text = "Ingredient Type";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(381, 118);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(235, 31);
            this.cmbType.TabIndex = 1;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // cmbName
            // 
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.Enabled = false;
            this.cmbName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(381, 189);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(235, 31);
            this.cmbName.TabIndex = 3;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(214, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 22);
            this.label1.TabIndex = 107;
            this.label1.Text = "Ingredient Name";
            // 
            // grdStock
            // 
            this.grdStock.AllowUserToAddRows = false;
            this.grdStock.AllowUserToDeleteRows = false;
            this.grdStock.AllowUserToOrderColumns = true;
            this.grdStock.AutoGenerateColumns = false;
            this.grdStock.BackgroundColor = System.Drawing.SystemColors.Info;
            this.grdStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierNameDataGridViewTextBoxColumn,
            this.typeNameDataGridViewTextBoxColumn,
            this.ingredientNameDataGridViewTextBoxColumn,
            this.purchaseDateDataGridViewTextBoxColumn,
            this.expiryDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn});
            this.grdStock.DataSource = this.stockQueryBindingSource;
            this.grdStock.Location = new System.Drawing.Point(56, 289);
            this.grdStock.Name = "grdStock";
            this.grdStock.ReadOnly = true;
            this.grdStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdStock.Size = new System.Drawing.Size(848, 294);
            this.grdStock.TabIndex = 6;
            this.grdStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // supplierNameDataGridViewTextBoxColumn
            // 
            this.supplierNameDataGridViewTextBoxColumn.DataPropertyName = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.HeaderText = "SupplierName";
            this.supplierNameDataGridViewTextBoxColumn.Name = "supplierNameDataGridViewTextBoxColumn";
            this.supplierNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeNameDataGridViewTextBoxColumn
            // 
            this.typeNameDataGridViewTextBoxColumn.DataPropertyName = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.HeaderText = "TypeName";
            this.typeNameDataGridViewTextBoxColumn.Name = "typeNameDataGridViewTextBoxColumn";
            this.typeNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ingredientNameDataGridViewTextBoxColumn
            // 
            this.ingredientNameDataGridViewTextBoxColumn.DataPropertyName = "IngredientName";
            this.ingredientNameDataGridViewTextBoxColumn.HeaderText = "IngredientName";
            this.ingredientNameDataGridViewTextBoxColumn.Name = "ingredientNameDataGridViewTextBoxColumn";
            this.ingredientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            this.purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.HeaderText = "PurchaseDate";
            this.purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            this.purchaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expiryDateDataGridViewTextBoxColumn
            // 
            this.expiryDateDataGridViewTextBoxColumn.DataPropertyName = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.HeaderText = "ExpiryDate";
            this.expiryDateDataGridViewTextBoxColumn.Name = "expiryDateDataGridViewTextBoxColumn";
            this.expiryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            this.unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockQueryBindingSource
            // 
            this.stockQueryBindingSource.DataMember = "StockQuery";
            this.stockQueryBindingSource.DataSource = this.auntRosieDBDataSet;
            // 
            // auntRosieDBDataSet
            // 
            this.auntRosieDBDataSet.DataSetName = "AuntRosieDBDataSet";
            this.auntRosieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnDestroy);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(731, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(135, 58);
            this.panel1.TabIndex = 3;
            // 
            // btnDestroy
            // 
            this.btnDestroy.BackColor = System.Drawing.Color.Transparent;
            this.btnDestroy.Enabled = false;
            this.btnDestroy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDestroy.Image = global::AuntRosieApplication.Properties.Resources.full_trash;
            this.btnDestroy.Location = new System.Drawing.Point(3, 3);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(63, 55);
            this.btnDestroy.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnDestroy, "Send to trash");
            this.btnDestroy.UseVisualStyleBackColor = false;
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AuntRosieApplication.Properties.Resources.print;
            this.button1.Location = new System.Drawing.Point(72, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 55);
            this.button1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.button1, "Print");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(51, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(258, 30);
            this.lblTitle.TabIndex = 110;
            this.lblTitle.Text = "Inventory Stock";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(824, 24);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 141;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // chkAllTypies
            // 
            this.chkAllTypies.AutoSize = true;
            this.chkAllTypies.BackColor = System.Drawing.Color.Transparent;
            this.chkAllTypies.Checked = true;
            this.chkAllTypies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllTypies.Font = new System.Drawing.Font("Arial", 14.25F);
            this.chkAllTypies.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkAllTypies.Location = new System.Drawing.Point(383, 91);
            this.chkAllTypies.Name = "chkAllTypies";
            this.chkAllTypies.Size = new System.Drawing.Size(107, 26);
            this.chkAllTypies.TabIndex = 0;
            this.chkAllTypies.Text = "All Types";
            this.chkAllTypies.UseVisualStyleBackColor = false;
            this.chkAllTypies.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkAllIngrdient
            // 
            this.chkAllIngrdient.AutoSize = true;
            this.chkAllIngrdient.BackColor = System.Drawing.Color.Transparent;
            this.chkAllIngrdient.Checked = true;
            this.chkAllIngrdient.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllIngrdient.Enabled = false;
            this.chkAllIngrdient.Font = new System.Drawing.Font("Arial", 14.25F);
            this.chkAllIngrdient.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkAllIngrdient.Location = new System.Drawing.Point(382, 162);
            this.chkAllIngrdient.Name = "chkAllIngrdient";
            this.chkAllIngrdient.Size = new System.Drawing.Size(150, 26);
            this.chkAllIngrdient.TabIndex = 2;
            this.chkAllIngrdient.Text = "All Ingredients";
            this.chkAllIngrdient.UseVisualStyleBackColor = false;
            this.chkAllIngrdient.CheckedChanged += new System.EventHandler(this.chkAllIngrdient_CheckedChanged);
            // 
            // chkExpierd
            // 
            this.chkExpierd.AutoSize = true;
            this.chkExpierd.BackColor = System.Drawing.Color.Transparent;
            this.chkExpierd.Font = new System.Drawing.Font("Arial", 14.25F);
            this.chkExpierd.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.chkExpierd.Location = new System.Drawing.Point(383, 226);
            this.chkExpierd.Name = "chkExpierd";
            this.chkExpierd.Size = new System.Drawing.Size(194, 26);
            this.chkExpierd.TabIndex = 4;
            this.chkExpierd.Text = "Expired Ingredients";
            this.chkExpierd.UseVisualStyleBackColor = false;
            this.chkExpierd.CheckedChanged += new System.EventHandler(this.chkExpierd_CheckedChanged);
            // 
            // LblQuantity
            // 
            this.LblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.LblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.ForeColor = System.Drawing.Color.Sienna;
            this.LblQuantity.Location = new System.Drawing.Point(622, 189);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(115, 31);
            this.LblQuantity.TabIndex = 145;
            // 
            // stockQueryTableAdapter
            // 
            this.stockQueryTableAdapter.ClearBeforeFill = true;
            // 
            // lblQuantityType
            // 
            this.lblQuantityType.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantityType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuantityType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityType.ForeColor = System.Drawing.Color.Sienna;
            this.lblQuantityType.Location = new System.Drawing.Point(622, 120);
            this.lblQuantityType.Name = "lblQuantityType";
            this.lblQuantityType.Size = new System.Drawing.Size(115, 31);
            this.lblQuantityType.TabIndex = 147;
            // 
            // frmInventoryStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 626);
            this.Controls.Add(this.lblQuantityType);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.chkExpierd);
            this.Controls.Add(this.chkAllIngrdient);
            this.Controls.Add(this.chkAllTypies);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grdStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label15);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInventoryStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryStockForm";
            this.Load += new System.EventHandler(this.frmInventoryStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockQueryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdStock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.CheckBox chkAllTypies;
        private System.Windows.Forms.CheckBox chkAllIngrdient;
        private System.Windows.Forms.CheckBox chkExpierd;
        private AuntRosieDBDataSet auntRosieDBDataSet;
        private System.Windows.Forms.BindingSource stockQueryBindingSource;
        private AuntRosieDBDataSetTableAdapters.StockQueryTableAdapter stockQueryTableAdapter;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label lblQuantityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ingredientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expiryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
    }
}