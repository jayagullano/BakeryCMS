namespace AuntRosieApplication.Event
{
    partial class frmOrganizeEvent
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
            this.radNew = new System.Windows.Forms.RadioButton();
            this.grbNew = new System.Windows.Forms.GroupBox();
            this.cmbTypes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.cmbLocations = new System.Windows.Forms.ComboBox();
            this.dtpFormDate = new System.Windows.Forms.DateTimePicker();
            this.lblName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grbExists = new System.Windows.Forms.GroupBox();
            this.dgEvents = new System.Windows.Forms.DataGridView();
            this.radExisting = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNewTypeCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pnlNewLoc = new System.Windows.Forms.Panel();
            this.lblLocMsg = new System.Windows.Forms.Label();
            this.btnNewTypeClose = new System.Windows.Forms.Button();
            this.txtnewLocName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPostalCode = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtProvince = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.btnNewTypetClear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbNew.SuspendLayout();
            this.grbExists.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).BeginInit();
            this.pnlNewLoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // radNew
            // 
            this.radNew.AutoSize = true;
            this.radNew.Checked = true;
            this.radNew.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNew.ForeColor = System.Drawing.Color.Sienna;
            this.radNew.Location = new System.Drawing.Point(0, 3);
            this.radNew.Name = "radNew";
            this.radNew.Size = new System.Drawing.Size(91, 24);
            this.radNew.TabIndex = 1;
            this.radNew.TabStop = true;
            this.radNew.Text = "New Event";
            this.radNew.UseVisualStyleBackColor = true;
            this.radNew.CheckedChanged += new System.EventHandler(this.radNew_CheckedChanged);
            // 
            // grbNew
            // 
            this.grbNew.BackColor = System.Drawing.Color.Transparent;
            this.grbNew.Controls.Add(this.cmbTypes);
            this.grbNew.Controls.Add(this.label2);
            this.grbNew.Controls.Add(this.txtEventName);
            this.grbNew.Controls.Add(this.label7);
            this.grbNew.Controls.Add(this.btnAddLocation);
            this.grbNew.Controls.Add(this.radNew);
            this.grbNew.Controls.Add(this.cmbLocations);
            this.grbNew.Controls.Add(this.dtpFormDate);
            this.grbNew.Controls.Add(this.lblName);
            this.grbNew.Controls.Add(this.label9);
            this.grbNew.Location = new System.Drawing.Point(40, 90);
            this.grbNew.Name = "grbNew";
            this.grbNew.Size = new System.Drawing.Size(809, 242);
            this.grbNew.TabIndex = 2;
            this.grbNew.TabStop = false;
            // 
            // cmbTypes
            // 
            this.cmbTypes.BackColor = System.Drawing.SystemColors.Info;
            this.cmbTypes.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTypes.FormattingEnabled = true;
            this.cmbTypes.Location = new System.Drawing.Point(161, 174);
            this.cmbTypes.Name = "cmbTypes";
            this.cmbTypes.Size = new System.Drawing.Size(586, 31);
            this.cmbTypes.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(50, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 123;
            this.label2.Tag = "";
            this.label2.Text = "Event Type";
            // 
            // txtEventName
            // 
            this.txtEventName.BackColor = System.Drawing.SystemColors.Info;
            this.txtEventName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtEventName.Location = new System.Drawing.Point(161, 75);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(586, 29);
            this.txtEventName.TabIndex = 121;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(40, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 22);
            this.label7.TabIndex = 122;
            this.label7.Text = "Event Name";
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.BackColor = System.Drawing.Color.Transparent;
            this.btnAddLocation.FlatAppearance.BorderSize = 0;
            this.btnAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLocation.Image = global::AuntRosieApplication.Properties.Resources.plus__2_;
            this.btnAddLocation.Location = new System.Drawing.Point(751, 116);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(41, 42);
            this.btnAddLocation.TabIndex = 113;
            this.toolTip1.SetToolTip(this.btnAddLocation, "Add new Location");
            this.btnAddLocation.UseVisualStyleBackColor = false;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // cmbLocations
            // 
            this.cmbLocations.BackColor = System.Drawing.SystemColors.Info;
            this.cmbLocations.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocations.FormattingEnabled = true;
            this.cmbLocations.Location = new System.Drawing.Point(161, 120);
            this.cmbLocations.Name = "cmbLocations";
            this.cmbLocations.Size = new System.Drawing.Size(586, 31);
            this.cmbLocations.TabIndex = 108;
            // 
            // dtpFormDate
            // 
            this.dtpFormDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFormDate.Location = new System.Drawing.Point(161, 30);
            this.dtpFormDate.Name = "dtpFormDate";
            this.dtpFormDate.Size = new System.Drawing.Size(586, 26);
            this.dtpFormDate.TabIndex = 109;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblName.ForeColor = System.Drawing.Color.Sienna;
            this.lblName.Location = new System.Drawing.Point(20, 124);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(135, 22);
            this.lblName.TabIndex = 107;
            this.lblName.Tag = "";
            this.lblName.Text = "Event Location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.Sienna;
            this.label9.Location = new System.Drawing.Point(50, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 22);
            this.label9.TabIndex = 111;
            this.label9.Tag = "";
            this.label9.Text = "Event Date";
            // 
            // grbExists
            // 
            this.grbExists.BackColor = System.Drawing.Color.Transparent;
            this.grbExists.Controls.Add(this.dgEvents);
            this.grbExists.Controls.Add(this.radExisting);
            this.grbExists.Location = new System.Drawing.Point(40, 338);
            this.grbExists.Name = "grbExists";
            this.grbExists.Size = new System.Drawing.Size(809, 260);
            this.grbExists.TabIndex = 3;
            this.grbExists.TabStop = false;
            // 
            // dgEvents
            // 
            this.dgEvents.AllowUserToAddRows = false;
            this.dgEvents.AllowUserToDeleteRows = false;
            this.dgEvents.AllowUserToOrderColumns = true;
            this.dgEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEvents.Location = new System.Drawing.Point(54, 55);
            this.dgEvents.MultiSelect = false;
            this.dgEvents.Name = "dgEvents";
            this.dgEvents.ReadOnly = true;
            this.dgEvents.Size = new System.Drawing.Size(731, 188);
            this.dgEvents.TabIndex = 2;
            this.dgEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEvents_CellContentClick);
            this.dgEvents.SelectionChanged += new System.EventHandler(this.dgEvents_SelectionChanged);
            // 
            // radExisting
            // 
            this.radExisting.AutoSize = true;
            this.radExisting.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radExisting.ForeColor = System.Drawing.Color.Sienna;
            this.radExisting.Location = new System.Drawing.Point(0, 0);
            this.radExisting.Name = "radExisting";
            this.radExisting.Size = new System.Drawing.Size(116, 24);
            this.radExisting.TabIndex = 1;
            this.radExisting.TabStop = true;
            this.radExisting.Text = "Existing Event";
            this.radExisting.UseVisualStyleBackColor = true;
            this.radExisting.CheckedChanged += new System.EventHandler(this.radExisting_CheckedChanged);
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
            this.label4.Text = "Organize Event- Step1";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(791, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 52);
            this.btnClose.TabIndex = 137;
            this.toolTip1.SetToolTip(this.btnClose, "Close the screen");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNewTypeCancel
            // 
            this.btnNewTypeCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTypeCancel.FlatAppearance.BorderSize = 0;
            this.btnNewTypeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTypeCancel.Image = global::AuntRosieApplication.Properties.Resources.file_delete;
            this.btnNewTypeCancel.Location = new System.Drawing.Point(211, 222);
            this.btnNewTypeCancel.Name = "btnNewTypeCancel";
            this.btnNewTypeCancel.Size = new System.Drawing.Size(63, 55);
            this.btnNewTypeCancel.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnNewTypeCancel, "Cancel");
            this.btnNewTypeCancel.UseVisualStyleBackColor = false;
            this.btnNewTypeCancel.Click += new System.EventHandler(this.btnNewTypeCancel_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::AuntRosieApplication.Properties.Resources.arrow_right;
            this.btnNext.Location = new System.Drawing.Point(396, 604);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 59);
            this.btnNext.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnNext, "Next");
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar1.Location = new System.Drawing.Point(40, 669);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(809, 23);
            this.progressBar1.TabIndex = 136;
            this.progressBar1.Value = 25;
            // 
            // pnlNewLoc
            // 
            this.pnlNewLoc.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            this.pnlNewLoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNewLoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewLoc.Controls.Add(this.lblLocMsg);
            this.pnlNewLoc.Controls.Add(this.btnNewTypeClose);
            this.pnlNewLoc.Controls.Add(this.txtnewLocName);
            this.pnlNewLoc.Controls.Add(this.label12);
            this.pnlNewLoc.Controls.Add(this.label1);
            this.pnlNewLoc.Controls.Add(this.txtPostalCode);
            this.pnlNewLoc.Controls.Add(this.textBox6);
            this.pnlNewLoc.Controls.Add(this.txtProvince);
            this.pnlNewLoc.Controls.Add(this.label3);
            this.pnlNewLoc.Controls.Add(this.label6);
            this.pnlNewLoc.Controls.Add(this.txtStreet);
            this.pnlNewLoc.Controls.Add(this.label5);
            this.pnlNewLoc.Controls.Add(this.txtCity);
            this.pnlNewLoc.Controls.Add(this.btnNewTypeCancel);
            this.pnlNewLoc.Controls.Add(this.btnNewTypetClear);
            this.pnlNewLoc.Location = new System.Drawing.Point(23, 165);
            this.pnlNewLoc.Name = "pnlNewLoc";
            this.pnlNewLoc.Size = new System.Drawing.Size(423, 334);
            this.pnlNewLoc.TabIndex = 114;
            this.pnlNewLoc.Visible = false;
            // 
            // lblLocMsg
            // 
            this.lblLocMsg.Location = new System.Drawing.Point(16, 297);
            this.lblLocMsg.Name = "lblLocMsg";
            this.lblLocMsg.Size = new System.Drawing.Size(392, 23);
            this.lblLocMsg.TabIndex = 121;
            this.lblLocMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewTypeClose
            // 
            this.btnNewTypeClose.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTypeClose.FlatAppearance.BorderSize = 0;
            this.btnNewTypeClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTypeClose.Image = global::AuntRosieApplication.Properties.Resources.macos_close;
            this.btnNewTypeClose.Location = new System.Drawing.Point(2, 1);
            this.btnNewTypeClose.Name = "btnNewTypeClose";
            this.btnNewTypeClose.Size = new System.Drawing.Size(36, 38);
            this.btnNewTypeClose.TabIndex = 17;
            this.btnNewTypeClose.UseVisualStyleBackColor = false;
            this.btnNewTypeClose.Click += new System.EventHandler(this.btnNewTypeClose_Click);
            // 
            // txtnewLocName
            // 
            this.txtnewLocName.BackColor = System.Drawing.SystemColors.Info;
            this.txtnewLocName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtnewLocName.Location = new System.Drawing.Point(168, 41);
            this.txtnewLocName.Name = "txtnewLocName";
            this.txtnewLocName.Size = new System.Drawing.Size(168, 29);
            this.txtnewLocName.TabIndex = 119;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label12.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label12.Location = new System.Drawing.Point(132, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 22);
            this.label12.TabIndex = 102;
            this.label12.Tag = "";
            this.label12.Text = "Add NewLocation";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.Sienna;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 22);
            this.label1.TabIndex = 120;
            this.label1.Text = "Location Name";
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.AutoSize = true;
            this.txtPostalCode.BackColor = System.Drawing.Color.Transparent;
            this.txtPostalCode.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtPostalCode.ForeColor = System.Drawing.Color.Sienna;
            this.txtPostalCode.Location = new System.Drawing.Point(34, 197);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(115, 22);
            this.txtPostalCode.TabIndex = 118;
            this.txtPostalCode.Text = "Postal Code";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Info;
            this.textBox6.Font = new System.Drawing.Font("Arial", 14.25F);
            this.textBox6.Location = new System.Drawing.Point(168, 190);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(168, 29);
            this.textBox6.TabIndex = 114;
            // 
            // txtProvince
            // 
            this.txtProvince.BackColor = System.Drawing.SystemColors.Info;
            this.txtProvince.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtProvince.Location = new System.Drawing.Point(168, 80);
            this.txtProvince.Name = "txtProvince";
            this.txtProvince.Size = new System.Drawing.Size(168, 29);
            this.txtProvince.TabIndex = 111;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(84, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 117;
            this.label3.Text = "Street";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(65, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 115;
            this.label6.Text = "Province";
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.SystemColors.Info;
            this.txtStreet.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtStreet.Location = new System.Drawing.Point(168, 155);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(168, 29);
            this.txtStreet.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label5.ForeColor = System.Drawing.Color.Sienna;
            this.label5.Location = new System.Drawing.Point(107, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 22);
            this.label5.TabIndex = 116;
            this.label5.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Info;
            this.txtCity.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtCity.Location = new System.Drawing.Point(168, 120);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(168, 29);
            this.txtCity.TabIndex = 112;
            // 
            // btnNewTypetClear
            // 
            this.btnNewTypetClear.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTypetClear.FlatAppearance.BorderSize = 0;
            this.btnNewTypetClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTypetClear.Image = global::AuntRosieApplication.Properties.Resources.save;
            this.btnNewTypetClear.Location = new System.Drawing.Point(136, 225);
            this.btnNewTypetClear.Name = "btnNewTypetClear";
            this.btnNewTypetClear.Size = new System.Drawing.Size(63, 55);
            this.btnNewTypetClear.TabIndex = 15;
            this.btnNewTypetClear.UseVisualStyleBackColor = false;
            this.btnNewTypetClear.Click += new System.EventHandler(this.btnNewTypetClear_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmOrganizeEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 712);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pnlNewLoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grbExists);
            this.Controls.Add(this.grbNew);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrganizeEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrganizeEventForm";
            this.Load += new System.EventHandler(this.frmOrganizeEvent_Load);
            this.grbNew.ResumeLayout(false);
            this.grbNew.PerformLayout();
            this.grbExists.ResumeLayout(false);
            this.grbExists.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).EndInit();
            this.pnlNewLoc.ResumeLayout(false);
            this.pnlNewLoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radNew;
        private System.Windows.Forms.GroupBox grbNew;
        private System.Windows.Forms.GroupBox grbExists;
        private System.Windows.Forms.DataGridView dgEvents;
        private System.Windows.Forms.RadioButton radExisting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.ComboBox cmbLocations;
        private System.Windows.Forms.DateTimePicker dtpFormDate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlNewLoc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNewTypeCancel;
        private System.Windows.Forms.Button btnNewTypetClear;
        private System.Windows.Forms.TextBox txtnewLocName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtPostalCode;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox txtProvince;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnNewTypeClose;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblLocMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTypes;
    }
}