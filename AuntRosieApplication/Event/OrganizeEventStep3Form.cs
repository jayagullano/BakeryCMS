/**
 * Author: Oghenefejiro Theodore Abohweyere
 * Purpose: Add production to event
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

namespace AuntRosieApplication.Event
{
    public partial class frmOrganizeEventStep3 : Form
    {
        BindingSource bindingSource = new BindingSource();
        private RosieEvent rosieEvent;

        public frmOrganizeEventStep3(RosieEvent rosieEvent)
        {
            this.rosieEvent = rosieEvent;
            InitializeComponent();
            //this.DoubleBuffered = true;
        }

        public frmOrganizeEventStep3()
        {
            InitializeComponent();
            //this.DoubleBuffered = true;
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

        public RosieEvent RosieEvent
        {
            get => rosieEvent;
            set
            {
                if (value != null)
                {
                    rosieEvent = value;
                    loadEvent(value);
                }
            }
        }

        /// <summary>
        /// Load event into form
        /// </summary>
        /// <param name="ev"></param>
        private void loadEvent(RosieEvent ev)
        {
            if (ev != null)
            {
                txtEvent.Text = ev.ToString();
            }
        }


        private void txtEventName_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Navigate to previous step
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
           this.Hide();
            AuntRosieApp.frmHome.formStep2.RosieEvent = rosieEvent;
            AuntRosieApp.frmHome.formStep2.Show();
        }

        /// <summary>
        /// Move onto the final step
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuntRosieApp.frmHome.formStep4.RosieEvent = rosieEvent;
            AuntRosieApp.frmHome.formStep4.Show();
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

        /// <summary>
        /// Load data into datagrid
        /// </summary>
        private void loadDataGrid()
        {
            bindingSource.DataSource = EventProduct.GetProductionsTable(rosieEvent.Id);
        }

        /// <summary>
        /// Display event as text in form
        /// </summary>
        private void displayEvent()
        {
            if (rosieEvent != null)
            {
                txtEvent.Text = rosieEvent.ToString();
            }
        }

        /// <summary>
        /// Setup initial configuration of data grid
        /// </summary>
        private void prepareGrid()
        {
            dtgProduction.DataSource = bindingSource;
            dtgProduction.AutoGenerateColumns = true;
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.HeaderText = "Delete";
            column.Name = "dataGridDeleteButton";
            column.Text = "Delete";
            column.UseColumnTextForButtonValue = true;
            dtgProduction.Columns.Add(column);
            int count = dtgProduction.Columns.Count;
            if (count >= 2)
            {
                DataGridViewColumn temp = dtgProduction.Columns[0];
                dtgProduction.Columns.Insert(0, dtgProduction.Columns[count - 1]);
                dtgProduction.Columns.Insert(count - 1, temp);
            }
        }

        /// <summary>
        /// Connect to the database and load data into form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOrganizeEventStep3_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;
            displayEvent();
            prepareGrid();
            loadDataGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Navigate to either a screen to pick existing productions or a screen to 
        /// create new production records for this event. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if(rbNew.Checked)
            {
                this.Close();
                Kitchen.frmProduction frm = new Kitchen.frmProduction(rosieEvent);
                frm.ShowDialog();
            }
            else
            {
                this.Close();
                Kitchen.frmExistingProduction frm = new Kitchen.frmExistingProduction(RosieEvent);
                frm.ShowDialog();
            }
        }

        /// <summary>
        /// Handle radiobutton behaviour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbNew_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNew.Checked)
            {
                rbExisting.Checked = false;
            }
        }

        /// <summary>
        /// Handle radiobutton behaviour
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbExisting_CheckedChanged(object sender, EventArgs e)
        {
            if(rbExisting.Checked)
            {
                rbNew.Checked = false;
            }
        }

        /// <summary>
        /// Handle delete button clicks in data grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgProduction_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgProduction.Columns["dataGridDeleteButton"].Index)
            {
                try
                {
                    DataGridViewRow selectedRow = dtgProduction.Rows[e.RowIndex];
                    long productionID = (long)(selectedRow.Cells["ProductionID"].Value);
                    EventProduct.DeleteEventProduct(rosieEvent.Id, productionID);
                    dtgProduction.Rows.Remove(selectedRow);
                }
                catch
                {
                    MessageBox.Show("Failed to delete production record");
                }
            }
        }
    }
}
