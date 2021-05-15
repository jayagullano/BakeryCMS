namespace AuntRosieApplication.Event
{
    partial class EstimateEventProfitForm
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
            this.grbNew = new System.Windows.Forms.GroupBox();
            this.cmbEventName = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEventLocation = new System.Windows.Forms.Label();
            this.pnlEstmait = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txtExpenses = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNewTypetSave = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtxHourWages = new System.Windows.Forms.TextBox();
            this.lblEventProfit = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblExpense = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblTitleHour = new System.Windows.Forms.Label();
            this.lblIngrdeintCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.err1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grbNew.SuspendLayout();
            this.pnlEstmait.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbNew
            // 
            this.grbNew.BackColor = System.Drawing.Color.Transparent;
            this.grbNew.Controls.Add(this.cmbEventName);
            this.grbNew.Controls.Add(this.btnCalc);
            this.grbNew.Controls.Add(this.label7);
            this.grbNew.Controls.Add(this.lblEventLocation);
            this.grbNew.Location = new System.Drawing.Point(58, 63);
            this.grbNew.Name = "grbNew";
            this.grbNew.Size = new System.Drawing.Size(662, 127);
            this.grbNew.TabIndex = 139;
            this.grbNew.TabStop = false;
            // 
            // cmbEventName
            // 
            this.cmbEventName.BackColor = System.Drawing.SystemColors.Info;
            this.cmbEventName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEventName.FormattingEnabled = true;
            this.cmbEventName.Items.AddRange(new object[] {
            "444"});
            this.cmbEventName.Location = new System.Drawing.Point(129, 35);
            this.cmbEventName.Name = "cmbEventName";
            this.cmbEventName.Size = new System.Drawing.Size(480, 31);
            this.cmbEventName.TabIndex = 124;
            this.cmbEventName.SelectedIndexChanged += new System.EventHandler(this.cmbEventName_SelectedIndexChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Transparent;
            this.btnCalc.Enabled = false;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Image = global::AuntRosieApplication.Properties.Resources.apple_calculator;
            this.btnCalc.Location = new System.Drawing.Point(615, 39);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(41, 64);
            this.btnCalc.TabIndex = 123;
            this.toolTip1.SetToolTip(this.btnCalc, "Click to view Results");
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click_1);
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
            this.lblEventLocation.Size = new System.Drawing.Size(602, 30);
            this.lblEventLocation.TabIndex = 114;
            this.lblEventLocation.Text = "Event Location:   ";
            // 
            // pnlEstmait
            // 
            this.pnlEstmait.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            this.pnlEstmait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEstmait.Controls.Add(this.label14);
            this.pnlEstmait.Controls.Add(this.txtExpenses);
            this.pnlEstmait.Controls.Add(this.label12);
            this.pnlEstmait.Controls.Add(this.btnNewTypetSave);
            this.pnlEstmait.Controls.Add(this.label13);
            this.pnlEstmait.Controls.Add(this.txtxHourWages);
            this.pnlEstmait.Location = new System.Drawing.Point(552, 287);
            this.pnlEstmait.Name = "pnlEstmait";
            this.pnlEstmait.Size = new System.Drawing.Size(475, 245);
            this.pnlEstmait.TabIndex = 159;
            this.pnlEstmait.Visible = false;
            this.pnlEstmait.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEstmait_Paint);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Sienna;
            this.label14.Location = new System.Drawing.Point(25, 111);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(241, 22);
            this.label14.TabIndex = 105;
            this.label14.Text = "Miscellaneous Expenses";
            // 
            // txtExpenses
            // 
            this.txtExpenses.BackColor = System.Drawing.SystemColors.Info;
            this.txtExpenses.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtExpenses.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtExpenses.Location = new System.Drawing.Point(272, 108);
            this.txtExpenses.Name = "txtExpenses";
            this.txtExpenses.Size = new System.Drawing.Size(131, 29);
            this.txtExpenses.TabIndex = 104;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Goldenrod;
            this.label12.Location = new System.Drawing.Point(46, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(268, 22);
            this.label12.TabIndex = 102;
            this.label12.Tag = "";
            this.label12.Text = "Please Enter Estimating for:";
            // 
            // btnNewTypetSave
            // 
            this.btnNewTypetSave.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTypetSave.FlatAppearance.BorderSize = 0;
            this.btnNewTypetSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTypetSave.Image = global::AuntRosieApplication.Properties.Resources.check_mark_button_emoji;
            this.btnNewTypetSave.Location = new System.Drawing.Point(203, 164);
            this.btnNewTypetSave.Name = "btnNewTypetSave";
            this.btnNewTypetSave.Size = new System.Drawing.Size(63, 55);
            this.btnNewTypetSave.TabIndex = 24;
            this.btnNewTypetSave.UseVisualStyleBackColor = false;
            this.btnNewTypetSave.Click += new System.EventHandler(this.btnNewTypetSave_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Sienna;
            this.label13.Location = new System.Drawing.Point(25, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 22);
            this.label13.TabIndex = 103;
            this.label13.Text = "Hour Wages";
            // 
            // txtxHourWages
            // 
            this.txtxHourWages.BackColor = System.Drawing.SystemColors.Info;
            this.txtxHourWages.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtxHourWages.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtxHourWages.Location = new System.Drawing.Point(272, 73);
            this.txtxHourWages.Name = "txtxHourWages";
            this.txtxHourWages.Size = new System.Drawing.Size(131, 29);
            this.txtxHourWages.TabIndex = 23;
            // 
            // lblEventProfit
            // 
            this.lblEventProfit.BackColor = System.Drawing.Color.Transparent;
            this.lblEventProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEventProfit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblEventProfit.ForeColor = System.Drawing.Color.Sienna;
            this.lblEventProfit.Location = new System.Drawing.Point(301, 377);
            this.lblEventProfit.Name = "lblEventProfit";
            this.lblEventProfit.Size = new System.Drawing.Size(194, 29);
            this.lblEventProfit.TabIndex = 158;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Sienna;
            this.label11.Location = new System.Drawing.Point(54, 377);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(181, 22);
            this.label11.TabIndex = 157;
            this.label11.Text = "Event Profit Result";
            // 
            // lblRevenue
            // 
            this.lblRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lblRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRevenue.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.ForeColor = System.Drawing.Color.Sienna;
            this.lblRevenue.Location = new System.Drawing.Point(301, 331);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(194, 29);
            this.lblRevenue.TabIndex = 156;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Sienna;
            this.label9.Location = new System.Drawing.Point(54, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 22);
            this.label9.TabIndex = 155;
            this.label9.Text = "Sales Revenue";
            // 
            // lblExpense
            // 
            this.lblExpense.BackColor = System.Drawing.Color.Transparent;
            this.lblExpense.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblExpense.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblExpense.ForeColor = System.Drawing.Color.Sienna;
            this.lblExpense.Location = new System.Drawing.Point(301, 287);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(194, 29);
            this.lblExpense.TabIndex = 154;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(54, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 22);
            this.label6.TabIndex = 153;
            this.label6.Text = "Miscellaneous Expenses";
            // 
            // lblHour
            // 
            this.lblHour.BackColor = System.Drawing.Color.Transparent;
            this.lblHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHour.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHour.ForeColor = System.Drawing.Color.Sienna;
            this.lblHour.Location = new System.Drawing.Point(301, 249);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(194, 29);
            this.lblHour.TabIndex = 152;
            // 
            // lblTitleHour
            // 
            this.lblTitleHour.AutoSize = true;
            this.lblTitleHour.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleHour.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTitleHour.ForeColor = System.Drawing.Color.Sienna;
            this.lblTitleHour.Location = new System.Drawing.Point(54, 249);
            this.lblTitleHour.Name = "lblTitleHour";
            this.lblTitleHour.Size = new System.Drawing.Size(141, 22);
            this.lblTitleHour.TabIndex = 151;
            this.lblTitleHour.Text = "Workers\' Cost";
            // 
            // lblIngrdeintCost
            // 
            this.lblIngrdeintCost.BackColor = System.Drawing.Color.Transparent;
            this.lblIngrdeintCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIngrdeintCost.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblIngrdeintCost.ForeColor = System.Drawing.Color.Sienna;
            this.lblIngrdeintCost.Location = new System.Drawing.Point(301, 205);
            this.lblIngrdeintCost.Name = "lblIngrdeintCost";
            this.lblIngrdeintCost.Size = new System.Drawing.Size(194, 29);
            this.lblIngrdeintCost.TabIndex = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(54, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 22);
            this.label1.TabIndex = 149;
            this.label1.Text = "Ingredient Cost";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(664, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 161;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(63, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(349, 30);
            this.lblTitle.TabIndex = 160;
            this.lblTitle.Text = "Estimate Event Profit";
            // 
            // err1
            // 
            this.err1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err1.ContainerControl = this;
            // 
            // EstimateEventProfitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(748, 507);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlEstmait);
            this.Controls.Add(this.lblEventProfit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblExpense);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.lblTitleHour);
            this.Controls.Add(this.lblIngrdeintCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EstimateEventProfitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbNew.ResumeLayout(false);
            this.grbNew.PerformLayout();
            this.pnlEstmait.ResumeLayout(false);
            this.pnlEstmait.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNew;
        private System.Windows.Forms.ComboBox cmbEventName;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblEventLocation;
        private System.Windows.Forms.Panel pnlEstmait;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtExpenses;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNewTypetSave;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtxHourWages;
        private System.Windows.Forms.Label lblEventProfit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblTitleHour;
        private System.Windows.Forms.Label lblIngrdeintCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ErrorProvider err1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}