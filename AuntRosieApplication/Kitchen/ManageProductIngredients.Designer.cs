namespace AuntRosieApplication.Kitchen
{
    partial class frmManageProductIngredients
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.dtgIngredients = new System.Windows.Forms.DataGridView();
            this.btnAddIngredient = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngredients)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 78);
            this.panel1.TabIndex = 144;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(909, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 52);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(12, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(442, 30);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Manage Product Ingredients";
            // 
            // cmbProductName
            // 
            this.cmbProductName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(220, 126);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(613, 31);
            this.cmbProductName.TabIndex = 146;
            this.cmbProductName.SelectedIndexChanged += new System.EventHandler(this.cmbProductName_SelectedIndexChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblProductName.ForeColor = System.Drawing.Color.Sienna;
            this.lblProductName.Location = new System.Drawing.Point(138, 130);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(76, 22);
            this.lblProductName.TabIndex = 145;
            this.lblProductName.Text = "Product";
            // 
            // dtgIngredients
            // 
            this.dtgIngredients.AllowUserToAddRows = false;
            this.dtgIngredients.AllowUserToDeleteRows = false;
            this.dtgIngredients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgIngredients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgIngredients.Location = new System.Drawing.Point(12, 170);
            this.dtgIngredients.Name = "dtgIngredients";
            this.dtgIngredients.Size = new System.Drawing.Size(955, 512);
            this.dtgIngredients.TabIndex = 147;
            this.dtgIngredients.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgIngredients_CellContentClick);
            // 
            // btnAddIngredient
            // 
            this.btnAddIngredient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddIngredient.FlatAppearance.BorderSize = 0;
            this.btnAddIngredient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddIngredient.Image = global::AuntRosieApplication.Properties.Resources.plus__2_;
            this.btnAddIngredient.Location = new System.Drawing.Point(856, 122);
            this.btnAddIngredient.Name = "btnAddIngredient";
            this.btnAddIngredient.Size = new System.Drawing.Size(41, 42);
            this.btnAddIngredient.TabIndex = 148;
            this.btnAddIngredient.UseVisualStyleBackColor = false;
            this.btnAddIngredient.Click += new System.EventHandler(this.btnAddIngredient_Click);
            // 
            // frmManageProductIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 694);
            this.Controls.Add(this.btnAddIngredient);
            this.Controls.Add(this.dtgIngredients);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageProductIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProductIngredients";
            this.Load += new System.EventHandler(this.frmManageProductIngredients_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgIngredients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.DataGridView dtgIngredients;
        private System.Windows.Forms.Button btnAddIngredient;
    }
}