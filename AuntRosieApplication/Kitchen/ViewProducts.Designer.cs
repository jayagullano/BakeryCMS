namespace AuntRosieApplication.Kitchen
{
    partial class frmViewProducts
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
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtgProductList = new System.Windows.Forms.DataGridView();
            this.auntRosieDBDataSet = new AuntRosieApplication.AuntRosieDBDataSet();
            this.auntRosieDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblProductTableAdapter = new AuntRosieApplication.AuntRosieDBDataSetTableAdapters.tblProductTableAdapter();
            this.pnlButton.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlButton.Controls.Add(this.btnBack);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Controls.Add(this.btnClear);
            this.pnlButton.Location = new System.Drawing.Point(383, 627);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(246, 69);
            this.pnlButton.TabIndex = 159;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::AuntRosieApplication.Properties.Resources.arrow_left;
            this.btnBack.Location = new System.Drawing.Point(3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 57);
            this.btnBack.TabIndex = 149;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::AuntRosieApplication.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(169, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 58);
            this.btnSave.TabIndex = 24;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::AuntRosieApplication.Properties.Resources.eraser;
            this.btnClear.Location = new System.Drawing.Point(90, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 58);
            this.btnClear.TabIndex = 15;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 78);
            this.panel1.TabIndex = 158;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(953, 11);
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
            this.lblTitle.Size = new System.Drawing.Size(200, 30);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Product List";
            // 
            // dtgProductList
            // 
            this.dtgProductList.AllowUserToAddRows = false;
            this.dtgProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductList.Location = new System.Drawing.Point(12, 205);
            this.dtgProductList.Name = "dtgProductList";
            this.dtgProductList.Size = new System.Drawing.Size(1001, 405);
            this.dtgProductList.TabIndex = 160;
            this.dtgProductList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductList_CellContentClick);
            // 
            // auntRosieDBDataSet
            // 
            this.auntRosieDBDataSet.DataSetName = "AuntRosieDBDataSet";
            this.auntRosieDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auntRosieDBDataSetBindingSource
            // 
            this.auntRosieDBDataSetBindingSource.DataSource = this.auntRosieDBDataSet;
            this.auntRosieDBDataSetBindingSource.Position = 0;
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.auntRosieDBDataSetBindingSource;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // frmViewProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 707);
            this.Controls.Add(this.dtgProductList);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewProducts";
            this.Load += new System.EventHandler(this.ViewProducts_Load);
            this.pnlButton.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dtgProductList;
        private System.Windows.Forms.BindingSource auntRosieDBDataSetBindingSource;
        private AuntRosieDBDataSet auntRosieDBDataSet;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private AuntRosieDBDataSetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
    }
}