namespace AuntRosieApplication.Event
{
    partial class frmOrganizeEventStep2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddLocation = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbEmpName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.grbNew = new System.Windows.Forms.GroupBox();
            this.dtgEmployeeHours = new System.Windows.Forms.DataGridView();
            this.auntRosieDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auntRosieDBDataSet = new AuntRosieApplication.AuntRosieDBDataSet();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtEvent = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tblEmployeeHoursBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmployeeHoursTableAdapter = new AuntRosieApplication.AuntRosieDBDataSetTableAdapters.tblEmployeeHoursTableAdapter();
            this.grbNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployeeHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeHoursBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Sienna;
            this.label2.Location = new System.Drawing.Point(36, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(525, 29);
            this.label2.TabIndex = 114;
            this.label2.Text = "Event";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.label4.Text = "Organize Event- Step2";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(506, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 52);
            this.btnClose.TabIndex = 138;
            this.toolTip1.SetToolTip(this.btnClose, "Close the screen");
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::AuntRosieApplication.Properties.Resources.arrow_left;
            this.button1.Location = new System.Drawing.Point(213, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 62);
            this.button1.TabIndex = 120;
            this.toolTip1.SetToolTip(this.button1, "Back");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Image = global::AuntRosieApplication.Properties.Resources.arrow_right;
            this.btnNext.Location = new System.Drawing.Point(281, 490);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(62, 62);
            this.btnNext.TabIndex = 117;
            this.toolTip1.SetToolTip(this.btnNext, "Next");
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddLocation
            // 
            this.btnAddLocation.BackColor = System.Drawing.Color.Transparent;
            this.btnAddLocation.FlatAppearance.BorderSize = 0;
            this.btnAddLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLocation.Image = global::AuntRosieApplication.Properties.Resources.low_importance;
            this.btnAddLocation.Location = new System.Drawing.Point(448, 74);
            this.btnAddLocation.Name = "btnAddLocation";
            this.btnAddLocation.Size = new System.Drawing.Size(41, 42);
            this.btnAddLocation.TabIndex = 113;
            this.toolTip1.SetToolTip(this.btnAddLocation, "Add new Location");
            this.btnAddLocation.UseVisualStyleBackColor = false;
            this.btnAddLocation.Click += new System.EventHandler(this.btnAddLocation_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.lblName.ForeColor = System.Drawing.Color.Sienna;
            this.lblName.Location = new System.Drawing.Point(2, 33);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(151, 22);
            this.lblName.TabIndex = 107;
            this.lblName.Tag = "";
            this.lblName.Text = "Employee Name";
            // 
            // cmbEmpName
            // 
            this.cmbEmpName.BackColor = System.Drawing.SystemColors.Info;
            this.cmbEmpName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmpName.FormattingEnabled = true;
            this.cmbEmpName.Location = new System.Drawing.Point(159, 33);
            this.cmbEmpName.MaxLength = 10;
            this.cmbEmpName.Name = "cmbEmpName";
            this.cmbEmpName.Size = new System.Drawing.Size(281, 31);
            this.cmbEmpName.TabIndex = 108;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14.25F);
            this.label7.ForeColor = System.Drawing.Color.Sienna;
            this.label7.Location = new System.Drawing.Point(93, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 22);
            this.label7.TabIndex = 122;
            this.label7.Text = "Hours";
            // 
            // txtHours
            // 
            this.txtHours.BackColor = System.Drawing.SystemColors.Info;
            this.txtHours.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtHours.Location = new System.Drawing.Point(161, 75);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(281, 29);
            this.txtHours.TabIndex = 121;
            // 
            // grbNew
            // 
            this.grbNew.BackColor = System.Drawing.Color.Transparent;
            this.grbNew.Controls.Add(this.dtgEmployeeHours);
            this.grbNew.Controls.Add(this.txtHours);
            this.grbNew.Controls.Add(this.label7);
            this.grbNew.Controls.Add(this.btnAddLocation);
            this.grbNew.Controls.Add(this.cmbEmpName);
            this.grbNew.Controls.Add(this.lblName);
            this.grbNew.ForeColor = System.Drawing.Color.Sienna;
            this.grbNew.Location = new System.Drawing.Point(29, 142);
            this.grbNew.Name = "grbNew";
            this.grbNew.Size = new System.Drawing.Size(531, 342);
            this.grbNew.TabIndex = 115;
            this.grbNew.TabStop = false;
            this.grbNew.Enter += new System.EventHandler(this.grbNew_Enter);
            // 
            // dtgEmployeeHours
            // 
            this.dtgEmployeeHours.AllowUserToAddRows = false;
            this.dtgEmployeeHours.AutoGenerateColumns = false;
            this.dtgEmployeeHours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgEmployeeHours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmployeeHours.DataSource = this.auntRosieDBDataSetBindingSource;
            this.dtgEmployeeHours.Location = new System.Drawing.Point(6, 122);
            this.dtgEmployeeHours.MultiSelect = false;
            this.dtgEmployeeHours.Name = "dtgEmployeeHours";
            this.dtgEmployeeHours.Size = new System.Drawing.Size(519, 202);
            this.dtgEmployeeHours.TabIndex = 123;
            this.dtgEmployeeHours.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmployeeHours_CellClick);
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 568);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(532, 23);
            this.progressBar1.TabIndex = 136;
            this.progressBar1.Value = 50;
            // 
            // txtEvent
            // 
            this.txtEvent.BackColor = System.Drawing.SystemColors.Info;
            this.txtEvent.Enabled = false;
            this.txtEvent.Location = new System.Drawing.Point(30, 87);
            this.txtEvent.Multiline = true;
            this.txtEvent.Name = "txtEvent";
            this.txtEvent.Size = new System.Drawing.Size(531, 49);
            this.txtEvent.TabIndex = 139;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tblEmployeeHoursBindingSource
            // 
            this.tblEmployeeHoursBindingSource.DataMember = "tblEmployeeHours";
            this.tblEmployeeHoursBindingSource.DataSource = this.auntRosieDBDataSetBindingSource;
            // 
            // tblEmployeeHoursTableAdapter
            // 
            this.tblEmployeeHoursTableAdapter.ClearBeforeFill = true;
            // 
            // frmOrganizeEventStep2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 603);
            this.Controls.Add(this.txtEvent);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.grbNew);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrganizeEventStep2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrganizeEventStep2Form";
            this.Load += new System.EventHandler(this.frmOrganizeEventStep2_Load);
            this.grbNew.ResumeLayout(false);
            this.grbNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployeeHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auntRosieDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployeeHoursBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbEmpName;
        private System.Windows.Forms.Button btnAddLocation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.GroupBox grbNew;
        private System.Windows.Forms.DataGridView dtgEmployeeHours;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtEvent;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.BindingSource auntRosieDBDataSetBindingSource;
        private AuntRosieDBDataSet auntRosieDBDataSet;
        private System.Windows.Forms.BindingSource tblEmployeeHoursBindingSource;
        private AuntRosieDBDataSetTableAdapters.tblEmployeeHoursTableAdapter tblEmployeeHoursTableAdapter;
    }
}