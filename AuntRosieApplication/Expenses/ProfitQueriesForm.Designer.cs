namespace AuntRosieApplication.Expenses
{
    partial class ProfitQueriesForm
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
            this.label20 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.dtpFormDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.chkAlltime = new System.Windows.Forms.CheckBox();
            this.lblITotRevenue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblITotExpenses = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblITotProfit = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.pnlDate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label20.Location = new System.Drawing.Point(62, 27);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(230, 30);
            this.label20.TabIndex = 154;
            this.label20.Text = "Profit Queries";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(598, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 153;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlDate
            // 
            this.pnlDate.BackColor = System.Drawing.Color.Transparent;
            this.pnlDate.Controls.Add(this.dtpFormDate);
            this.pnlDate.Controls.Add(this.dtpToDate);
            this.pnlDate.Controls.Add(this.label10);
            this.pnlDate.Controls.Add(this.label9);
            this.pnlDate.Enabled = false;
            this.pnlDate.Location = new System.Drawing.Point(67, 89);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(532, 65);
            this.pnlDate.TabIndex = 152;
            // 
            // dtpFormDate
            // 
            this.dtpFormDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFormDate.Location = new System.Drawing.Point(187, 5);
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
            // chkAlltime
            // 
            this.chkAlltime.AutoSize = true;
            this.chkAlltime.BackColor = System.Drawing.Color.Transparent;
            this.chkAlltime.Checked = true;
            this.chkAlltime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAlltime.Location = new System.Drawing.Point(67, 70);
            this.chkAlltime.Name = "chkAlltime";
            this.chkAlltime.Size = new System.Drawing.Size(117, 17);
            this.chkAlltime.TabIndex = 151;
            this.chkAlltime.Text = "Not Specific Period";
            this.chkAlltime.UseVisualStyleBackColor = false;
            this.chkAlltime.CheckedChanged += new System.EventHandler(this.chkAlltime_CheckedChanged);
            // 
            // lblITotRevenue
            // 
            this.lblITotRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lblITotRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblITotRevenue.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblITotRevenue.ForeColor = System.Drawing.Color.Green;
            this.lblITotRevenue.Location = new System.Drawing.Point(223, 162);
            this.lblITotRevenue.Name = "lblITotRevenue";
            this.lblITotRevenue.Size = new System.Drawing.Size(361, 34);
            this.lblITotRevenue.TabIndex = 158;
            this.lblITotRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(64, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 157;
            this.label3.Text = "Total Revenue";
            // 
            // lblITotExpenses
            // 
            this.lblITotExpenses.BackColor = System.Drawing.Color.Transparent;
            this.lblITotExpenses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblITotExpenses.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblITotExpenses.ForeColor = System.Drawing.Color.Red;
            this.lblITotExpenses.Location = new System.Drawing.Point(223, 226);
            this.lblITotExpenses.Name = "lblITotExpenses";
            this.lblITotExpenses.Size = new System.Drawing.Size(361, 34);
            this.lblITotExpenses.TabIndex = 160;
            this.lblITotExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(64, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 159;
            this.label2.Text = "Total Expenses";
            // 
            // lblITotProfit
            // 
            this.lblITotProfit.BackColor = System.Drawing.Color.Transparent;
            this.lblITotProfit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblITotProfit.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblITotProfit.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblITotProfit.Location = new System.Drawing.Point(223, 284);
            this.lblITotProfit.Name = "lblITotProfit";
            this.lblITotProfit.Size = new System.Drawing.Size(361, 34);
            this.lblITotProfit.TabIndex = 162;
            this.lblITotProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(75, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 161;
            this.label5.Text = "Total Profit";
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Transparent;
            this.btnCalc.FlatAppearance.BorderSize = 0;
            this.btnCalc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalc.Image = global::AuntRosieApplication.Properties.Resources.apple_calculator;
            this.btnCalc.Location = new System.Drawing.Point(605, 89);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(41, 64);
            this.btnCalc.TabIndex = 124;
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // ProfitQueriesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 393);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblITotProfit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblITotExpenses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblITotRevenue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pnlDate);
            this.Controls.Add(this.chkAlltime);
            this.ForeColor = System.Drawing.Color.Sienna;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfitQueriesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfitQueriesForm";
            this.Load += new System.EventHandler(this.ProfitQueriesForm_Load);
            this.pnlDate.ResumeLayout(false);
            this.pnlDate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.DateTimePicker dtpFormDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkAlltime;
        private System.Windows.Forms.Label lblITotRevenue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblITotExpenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblITotProfit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalc;
    }
}