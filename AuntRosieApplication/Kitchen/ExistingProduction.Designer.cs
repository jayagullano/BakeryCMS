namespace AuntRosieApplication.Kitchen
{
    partial class frmExistingProduction
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dtgExistingProduction = new System.Windows.Forms.DataGridView();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgExistingProduction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(947, 12);
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
            this.lblTitle.Size = new System.Drawing.Size(311, 30);
            this.lblTitle.TabIndex = 29;
            this.lblTitle.Text = "Existing Production";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1017, 78);
            this.panel1.TabIndex = 143;
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
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Controls.Add(this.btnNext);
            this.pnlButton.Controls.Add(this.btnClear);
            this.pnlButton.Controls.Add(this.btnBack);
            this.pnlButton.Location = new System.Drawing.Point(333, 616);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(332, 69);
            this.pnlButton.TabIndex = 144;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::AuntRosieApplication.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(170, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(74, 58);
            this.btnSave.TabIndex = 153;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::AuntRosieApplication.Properties.Resources.arrow_right;
            this.btnNext.Location = new System.Drawing.Point(267, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(62, 62);
            this.btnNext.TabIndex = 151;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = global::AuntRosieApplication.Properties.Resources.eraser;
            this.btnClear.Location = new System.Drawing.Point(91, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(73, 58);
            this.btnClear.TabIndex = 152;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // dtgExistingProduction
            // 
            this.dtgExistingProduction.AllowUserToAddRows = false;
            this.dtgExistingProduction.AllowUserToDeleteRows = false;
            this.dtgExistingProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgExistingProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgExistingProduction.Location = new System.Drawing.Point(17, 168);
            this.dtgExistingProduction.Name = "dtgExistingProduction";
            this.dtgExistingProduction.Size = new System.Drawing.Size(988, 442);
            this.dtgExistingProduction.TabIndex = 145;
            this.dtgExistingProduction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgExistingProduction_CellClick);
            this.dtgExistingProduction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgExistingProduction_CellContentClick);
            // 
            // txtEvent
            // 
            this.txtEvent.Enabled = false;
            this.txtEvent.Location = new System.Drawing.Point(238, 113);
            this.txtEvent.Multiline = true;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(537, 49);
            this.txtEvent.TabIndex = 150;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(238, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 29);
            this.label1.TabIndex = 149;
            this.label1.Text = "Event";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmExistingProduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 697);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgExistingProduction);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmExistingProduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExistingProduction";
            this.Load += new System.EventHandler(this.ExistingProduction_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgExistingProduction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.DataGridView dtgExistingProduction;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}