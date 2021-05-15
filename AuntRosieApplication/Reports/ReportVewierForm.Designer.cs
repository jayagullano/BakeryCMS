namespace AuntRosieApplication
{
    partial class ReportVewierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportVewierForm));
            this.crvReports = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvReports
            // 
            this.crvReports.ActiveViewIndex = -1;
            this.crvReports.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.crvReports.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvReports.Location = new System.Drawing.Point(0, 0);
            this.crvReports.Name = "crvReports";
            this.crvReports.Size = new System.Drawing.Size(1036, 743);
            this.crvReports.TabIndex = 0;
            this.crvReports.Load += new System.EventHandler(this.crvReports_Load);
            // 
            // ReportVewierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 743);
            this.Controls.Add(this.crvReports);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReportVewierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aunt Roise\'s Report Vewier";
            this.Load += new System.EventHandler(this.ReportVewierForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvReports;
    }
}