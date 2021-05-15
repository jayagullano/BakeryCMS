namespace AuntRosieApplication.Inventory
{
    partial class frmIngredients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngredients));
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlNewType = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.btnNewTypeCancel = new System.Windows.Forms.Button();
            this.btnNewTypetSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtxNewType = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnClancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddType = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtstoringNote = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNewIngredintName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.errMeesage = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.pnlNewType.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMeesage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.lblTitle.Location = new System.Drawing.Point(100, 42);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 30);
            this.lblTitle.TabIndex = 111;
            this.lblTitle.Text = "Manage Ingredients";
            // 
            // pnlNewType
            // 
            this.pnlNewType.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlNewType.BackgroundImage")));
            this.pnlNewType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNewType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNewType.Controls.Add(this.label12);
            this.pnlNewType.Controls.Add(this.btnNewTypeCancel);
            this.pnlNewType.Controls.Add(this.btnNewTypetSave);
            this.pnlNewType.Controls.Add(this.label11);
            this.pnlNewType.Controls.Add(this.txtxNewType);
            this.pnlNewType.Location = new System.Drawing.Point(496, 344);
            this.pnlNewType.Name = "pnlNewType";
            this.pnlNewType.Size = new System.Drawing.Size(379, 245);
            this.pnlNewType.TabIndex = 113;
            this.pnlNewType.Visible = false;
            this.pnlNewType.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNewType_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Goldenrod;
            this.label12.Location = new System.Drawing.Point(67, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(241, 22);
            this.label12.TabIndex = 102;
            this.label12.Tag = "";
            this.label12.Text = "Add New Ingredient Type";
            // 
            // btnNewTypeCancel
            // 
            this.btnNewTypeCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTypeCancel.FlatAppearance.BorderSize = 0;
            this.btnNewTypeCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTypeCancel.Image = global::AuntRosieApplication.Properties.Resources.file_delete;
            this.btnNewTypeCancel.Location = new System.Drawing.Point(183, 140);
            this.btnNewTypeCancel.Name = "btnNewTypeCancel";
            this.btnNewTypeCancel.Size = new System.Drawing.Size(63, 55);
            this.btnNewTypeCancel.TabIndex = 25;
            this.btnNewTypeCancel.UseVisualStyleBackColor = false;
            this.btnNewTypeCancel.Click += new System.EventHandler(this.btnNewTypeCancel_Click);
            // 
            // btnNewTypetSave
            // 
            this.btnNewTypetSave.BackColor = System.Drawing.Color.Transparent;
            this.btnNewTypetSave.Enabled = false;
            this.btnNewTypetSave.FlatAppearance.BorderSize = 0;
            this.btnNewTypetSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTypetSave.Image = global::AuntRosieApplication.Properties.Resources.save;
            this.btnNewTypetSave.Location = new System.Drawing.Point(119, 140);
            this.btnNewTypetSave.Name = "btnNewTypetSave";
            this.btnNewTypetSave.Size = new System.Drawing.Size(63, 55);
            this.btnNewTypetSave.TabIndex = 24;
            this.btnNewTypetSave.UseVisualStyleBackColor = false;
            this.btnNewTypetSave.Click += new System.EventHandler(this.btnNewTypetSave_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Sienna;
            this.label11.Location = new System.Drawing.Point(43, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 22);
            this.label11.TabIndex = 103;
            this.label11.Text = "Type";
            // 
            // txtxNewType
            // 
            this.txtxNewType.BackColor = System.Drawing.SystemColors.Info;
            this.txtxNewType.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtxNewType.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtxNewType.Location = new System.Drawing.Point(105, 98);
            this.txtxNewType.Name = "txtxNewType";
            this.txtxNewType.Size = new System.Drawing.Size(208, 29);
            this.txtxNewType.TabIndex = 23;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::AuntRosieApplication.Properties.Resources.close_sign;
            this.btnClose.Location = new System.Drawing.Point(463, 22);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 50);
            this.btnClose.TabIndex = 11;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Controls.Add(this.label8);
            this.pnlMain.Controls.Add(this.cmbUnit);
            this.pnlMain.Controls.Add(this.cmbName);
            this.pnlMain.Controls.Add(this.pnlButton);
            this.pnlMain.Controls.Add(this.btnAddType);
            this.pnlMain.Controls.Add(this.label16);
            this.pnlMain.Controls.Add(this.cmbType);
            this.pnlMain.Controls.Add(this.txtstoringNote);
            this.pnlMain.Controls.Add(this.label15);
            this.pnlMain.Controls.Add(this.txtNewIngredintName);
            this.pnlMain.Controls.Add(this.label14);
            this.pnlMain.Location = new System.Drawing.Point(26, 97);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(464, 379);
            this.pnlMain.TabIndex = 0;
            // 
            // cmbName
            // 
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(162, 54);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(210, 31);
            this.cmbName.TabIndex = 3;
            this.toolTip1.SetToolTip(this.cmbName, "Choose the Ingrdeient name");
            this.cmbName.Visible = false;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbName_SelectedIndexChanged);
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.Color.Transparent;
            this.pnlButton.Controls.Add(this.btnClancel);
            this.pnlButton.Controls.Add(this.btnNew);
            this.pnlButton.Controls.Add(this.btnEdit);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Controls.Add(this.btnDelete);
            this.pnlButton.Location = new System.Drawing.Point(21, 296);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(425, 66);
            this.pnlButton.TabIndex = 6;
            // 
            // btnClancel
            // 
            this.btnClancel.BackColor = System.Drawing.Color.Transparent;
            this.btnClancel.Enabled = false;
            this.btnClancel.FlatAppearance.BorderSize = 0;
            this.btnClancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClancel.Image = global::AuntRosieApplication.Properties.Resources.eraser;
            this.btnClancel.Location = new System.Drawing.Point(250, 1);
            this.btnClancel.Name = "btnClancel";
            this.btnClancel.Size = new System.Drawing.Size(79, 61);
            this.btnClancel.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnClancel, "Cancel");
            this.btnClancel.UseVisualStyleBackColor = false;
            this.btnClancel.Click += new System.EventHandler(this.btnClancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Transparent;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Image = global::AuntRosieApplication.Properties.Resources.plus_2_math;
            this.btnNew.Location = new System.Drawing.Point(3, 1);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(79, 61);
            this.btnNew.TabIndex = 6;
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolTip1.SetToolTip(this.btnNew, "New");
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::AuntRosieApplication.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(88, 1);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(79, 61);
            this.btnEdit.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Enabled = false;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::AuntRosieApplication.Properties.Resources.save;
            this.btnSave.Location = new System.Drawing.Point(335, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 61);
            this.btnSave.TabIndex = 10;
            this.toolTip1.SetToolTip(this.btnSave, "Save");
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::AuntRosieApplication.Properties.Resources.delete_sign;
            this.btnDelete.Location = new System.Drawing.Point(166, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(79, 61);
            this.btnDelete.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddType
            // 
            this.btnAddType.BackColor = System.Drawing.Color.Transparent;
            this.btnAddType.FlatAppearance.BorderSize = 0;
            this.btnAddType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddType.Image = global::AuntRosieApplication.Properties.Resources.plus__2_;
            this.btnAddType.Location = new System.Drawing.Point(376, 17);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(40, 31);
            this.btnAddType.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnAddType, "Add new type");
            this.btnAddType.UseVisualStyleBackColor = false;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Sienna;
            this.label16.Location = new System.Drawing.Point(20, 175);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(136, 22);
            this.label16.TabIndex = 120;
            this.label16.Text = "Storing Notes";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(160, 17);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(210, 31);
            this.cmbType.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbType, "Choose the ingredient typr");
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // txtstoringNote
            // 
            this.txtstoringNote.BackColor = System.Drawing.SystemColors.Info;
            this.txtstoringNote.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtstoringNote.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtstoringNote.Location = new System.Drawing.Point(162, 158);
            this.txtstoringNote.Multiline = true;
            this.txtstoringNote.Name = "txtstoringNote";
            this.txtstoringNote.Size = new System.Drawing.Size(210, 134);
            this.txtstoringNote.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtstoringNote, "Enter storing note ");
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Sienna;
            this.label15.Location = new System.Drawing.Point(93, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 22);
            this.label15.TabIndex = 118;
            this.label15.Text = "Type";
            // 
            // txtNewIngredintName
            // 
            this.txtNewIngredintName.BackColor = System.Drawing.SystemColors.Info;
            this.txtNewIngredintName.Font = new System.Drawing.Font("Arial", 14.25F);
            this.txtNewIngredintName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNewIngredintName.Location = new System.Drawing.Point(162, 86);
            this.txtNewIngredintName.Name = "txtNewIngredintName";
            this.txtNewIngredintName.Size = new System.Drawing.Size(210, 29);
            this.txtNewIngredintName.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtNewIngredintName, "Enter Ingrdient Name");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Sienna;
            this.label14.Location = new System.Drawing.Point(87, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 22);
            this.label14.TabIndex = 119;
            this.label14.Text = "Name";
            // 
            // errMeesage
            // 
            this.errMeesage.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errMeesage.ContainerControl = this;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Sienna;
            this.label8.Location = new System.Drawing.Point(93, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 22);
            this.label8.TabIndex = 122;
            this.label8.Text = "Unit";
            // 
            // cmbUnit
            // 
            this.cmbUnit.AutoCompleteCustomSource.AddRange(new string[] {
            "Pies",
            "Preserves"});
            this.cmbUnit.BackColor = System.Drawing.SystemColors.Info;
            this.cmbUnit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUnit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Items.AddRange(new object[] {
            "Kg",
            "g",
            "ml",
            "L",
            "lb",
            "oz",
            "item"});
            this.cmbUnit.Location = new System.Drawing.Point(162, 121);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(112, 31);
            this.cmbUnit.TabIndex = 121;
            // 
            // frmIngredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(534, 488);
            this.Controls.Add(this.pnlNewType);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIngredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ingredients";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.frmIngredients_Load);
            this.pnlNewType.ResumeLayout(false);
            this.pnlNewType.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errMeesage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlNewType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnNewTypeCancel;
        private System.Windows.Forms.Button btnNewTypetSave;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtxNewType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnClancel;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddType;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.TextBox txtstoringNote;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNewIngredintName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errMeesage;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbUnit;
    }
}