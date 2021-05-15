namespace AuntRosieApp.Kitchen
{
    partial class frmManageProduct
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddProductSize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnManageProductIngredients = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(896, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 64;
            this.toolTip1.SetToolTip(this.btnClose, "Close the screen");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(35, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(275, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Products";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Teal;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnNew.Location = new System.Drawing.Point(303, 237);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(145, 64);
            this.btnNew.TabIndex = 65;
            this.btnNew.Text = "Create Product";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Teal;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Location = new System.Drawing.Point(467, 237);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 64);
            this.btnEdit.TabIndex = 66;
            this.btnEdit.Text = "Manage Existing Products";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddProductSize
            // 
            this.btnAddProductSize.BackColor = System.Drawing.Color.Teal;
            this.btnAddProductSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProductSize.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddProductSize.Location = new System.Drawing.Point(303, 325);
            this.btnAddProductSize.Name = "btnAddProductSize";
            this.btnAddProductSize.Size = new System.Drawing.Size(145, 64);
            this.btnAddProductSize.TabIndex = 67;
            this.btnAddProductSize.Text = "Add Product Sizes";
            this.btnAddProductSize.UseVisualStyleBackColor = false;
            this.btnAddProductSize.Click += new System.EventHandler(this.btnAddProductSize_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(467, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 64);
            this.button1.TabIndex = 68;
            this.button1.Text = "Specify Product Nutrition";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnManageProductIngredients
            // 
            this.btnManageProductIngredients.BackColor = System.Drawing.Color.Teal;
            this.btnManageProductIngredients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageProductIngredients.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnManageProductIngredients.Location = new System.Drawing.Point(467, 404);
            this.btnManageProductIngredients.Name = "btnManageProductIngredients";
            this.btnManageProductIngredients.Size = new System.Drawing.Size(145, 64);
            this.btnManageProductIngredients.TabIndex = 69;
            this.btnManageProductIngredients.Text = "Manage Product Ingredients";
            this.btnManageProductIngredients.UseVisualStyleBackColor = false;
            this.btnManageProductIngredients.Click += new System.EventHandler(this.btnManageProductIngredients_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(303, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 64);
            this.button2.TabIndex = 70;
            this.button2.Text = "View Products";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(967, 739);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnManageProductIngredients);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddProductSize);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmManageProduct_FormClosed);
            this.Load += new System.EventHandler(this.frmManageProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddProductSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnManageProductIngredients;
        private System.Windows.Forms.Button button2;
    }
}