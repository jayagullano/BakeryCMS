namespace AuntRosieApplication.Event
{
    partial class frmOrganizeEventStep3
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
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.grbNew = new System.Windows.Forms.GroupBox();
            this.rbExisting = new System.Windows.Forms.RadioButton();
            this.rbNew = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgProduction = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grbNew.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduction)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label4.Location = new System.Drawing.Point(35, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(349, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Organize Event- Step3";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(735, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 139;
            this.toolTip1.SetToolTip(this.btnClose, "Close the screen");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::AuntRosieApplication.Properties.Resources.arrow_left;
            this.btnBack.Location = new System.Drawing.Point(300, 575);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(64, 57);
            this.btnBack.TabIndex = 125;
            this.toolTip1.SetToolTip(this.btnBack, "Back");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::AuntRosieApplication.Properties.Resources.arrow_right;
            this.btnNext.Location = new System.Drawing.Point(370, 575);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(64, 57);
            this.btnNext.TabIndex = 122;
            this.toolTip1.SetToolTip(this.btnNext, "Next");
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.FlatAppearance.BorderSize = 0;
            this.btnAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLocation.Image = global::AuntRosieApplication.Properties.Resources.low_importance;
            this.btnAddLocation.Location = new System.Drawing.Point(478, 124);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(50, 39);
            this.btnAddLocation.TabIndex = 113;
            this.toolTip1.SetToolTip(this.btnAddLocation, "Add new Location");
            this.btnAddLocation.UseVisualStyleBackColor = true;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // grbNew
            // 
            this.grbNew.BackColor = System.Drawing.Color.Transparent;
            this.grbNew.Controls.Add(this.rbExisting);
            this.grbNew.Controls.Add(this.rbNew);
            this.grbNew.Controls.Add(this.label1);
            this.grbNew.Controls.Add(this.panel1);
            this.grbNew.Controls.Add(this.btnAddLocation);
            this.grbNew.ForeColor = System.Drawing.Color.Sienna;
            this.grbNew.Location = new System.Drawing.Point(128, 170);
            this.grbNew.Name = "grbNew";
            this.grbNew.Size = new System.Drawing.Size(534, 399);
            this.grbNew.TabIndex = 121;
            this.grbNew.TabStop = false;
            // 
            // rbExisting
            // 
            this.rbExisting.AutoSize = true;
            this.rbExisting.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.rbExisting.Location = new System.Drawing.Point(50, 103);
            this.rbExisting.Name = "rbExisting";
            this.rbExisting.Size = new System.Drawing.Size(159, 27);
            this.rbExisting.TabIndex = 129;
            this.rbExisting.Text = "Existing Production";
            this.rbExisting.UseVisualStyleBackColor = true;
            this.rbExisting.CheckedChanged += new System.EventHandler(this.rbExisting_CheckedChanged);
            // 
            // rbNew
            // 
            this.rbNew.AutoSize = true;
            this.rbNew.Checked = true;
            this.rbNew.Font = new System.Drawing.Font("Arial Narrow", 14.25F);
            this.rbNew.Location = new System.Drawing.Point(50, 61);
            this.rbNew.Name = "rbNew";
            this.rbNew.Size = new System.Drawing.Size(137, 27);
            this.rbNew.TabIndex = 128;
            this.rbNew.TabStop = true;
            this.rbNew.Text = "New Production";
            this.rbNew.UseVisualStyleBackColor = true;
            this.rbNew.CheckedChanged += new System.EventHandler(this.rbNew_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(10, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 26);
            this.label1.TabIndex = 127;
            this.label1.Text = "Schedule Event Production";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dtgProduction);
            this.panel1.Location = new System.Drawing.Point(6, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 220);
            this.panel1.TabIndex = 126;
            // 
            // dtgProduction
            // 
            this.dtgProduction.AllowUserToAddRows = false;
            this.dtgProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProduction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduction.Location = new System.Drawing.Point(3, 3);
            this.dtgProduction.Name = "dtgProduction";
            this.dtgProduction.ReadOnly = true;
            this.dtgProduction.Size = new System.Drawing.Size(516, 214);
            this.dtgProduction.TabIndex = 0;
            this.dtgProduction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduction_CellClick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(134, 643);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(500, 23);
            this.progressBar1.TabIndex = 135;
            this.progressBar1.Value = 75;
            // 
            // txtEvent
            // 
            this.txtEvent.Enabled = false;
            this.txtEvent.Location = new System.Drawing.Point(125, 87);
            this.txtEvent.Multiline = true;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(537, 49);
            this.txtEvent.TabIndex = 141;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(125, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(537, 29);
            this.label5.TabIndex = 140;
            this.label5.Text = "Event";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmOrganizeEventStep3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 763);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grbNew);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Sienna;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrganizeEventStep3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventOrganizeStep3Form";
            this.Load += new System.EventHandler(this.frmOrganizeEventStep3_Load);
            this.grbNew.ResumeLayout(false);
            this.grbNew.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.GroupBox grbNew;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgProduction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbExisting;
        private System.Windows.Forms.RadioButton rbNew;
    }
}