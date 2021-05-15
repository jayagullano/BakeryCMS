/**
 * Author: Oghenefejiro Theodore Abohweyere
 * Purpose: View production records
 * Date: 2020-12-17
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuntRosieEntities;

namespace AuntRosieApplication.Kitchen
{
    public partial class frmViewProduction : Form
    {
        public frmViewProduction()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        protected override void OnPaint(PaintEventArgs e) { }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        /// <summary>
        /// Connect to database, load background and load data into form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewProduction_Load(object sender, EventArgs e)
        {
             
            // TODO: This line of code loads data into the 'auntRosieDBDataSet.tblProduction' table. You can move, or remove it, as needed.
            //this.tblProductionTableAdapter.Fill(this.auntRosieDBDataSet.tblProduction);
            cmbType.DataSource = new string[]{ "Pie", "Pickle"};

            lblTitle.Left = (this.Width - lblTitle.Width) / 2;
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;

            loadDTG(Production.GetProductions());
            int colWidth = dtgProduction.Width / 4;
            foreach(DataGridViewColumn col in dtgProduction.Columns)
            {
                col.Width = colWidth;
            }
        }

        /// <summary>
        /// Load production records into datagrid
        /// </summary>
        /// <param name="productions"></param>
        private void loadDTG(List<Production> productions)
        {

            dtgProduction.DataSource = productions;
            /*foreach(Production production in productions)
            {
                dtgProduction.Rows.Add()
            }*/
        }

        /// <summary>
        /// Filter by producttype
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!chkAllProducts.Checked)
            {
                loadDTG(Production.GetProductions(cmbType.Text.ToLower()));
            }
        }

        /// <summary>
        /// Close form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Filter by datetime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            loadDTG(Production.GetProductions(dtpFrom.Value, dtpTo.Value));
        }

        /// <summary>
        /// Filter by datatime
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            loadDTG(Production.GetProductions(dtpFrom.Value, dtpTo.Value));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
