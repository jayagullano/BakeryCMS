/**
 * Author: Oghenefejiro Theodore Abohweyere
 * Purpose: Allow the user confirm that they like their changes
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
    public partial class frmOrganizeEventStep4 : Form
    {
        private RosieEvent rosieEvent;
        /// <summary>
        /// Updateable datasource for employee hours data grid
        /// </summary>
        private BindingSource employeeHoursSource = new BindingSource();

        /// <summary>
        /// Updateable datasource for production data grid
        /// </summary>
        private BindingSource productionSource = new BindingSource();

        public frmOrganizeEventStep4(RosieEvent rosieEvent)
        {
            this.rosieEvent = rosieEvent;
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        public frmOrganizeEventStep4()
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

        /// <summary>
        /// Provides access to form across the entire project
        /// </summary>
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
        /// Navigate to the previous step
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AuntRosieApp.frmHome.formStep3.RosieEvent = rosieEvent;
            AuntRosieApp.frmHome.formStep3.Show();
        }

        /// <summary>
        /// Close all the global forms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinish_Click(object sender, EventArgs e)
        {
            AuntRosieApp.frmHome.formStep1.Close();
            AuntRosieApp.frmHome.formStep2.Close();
            AuntRosieApp.frmHome.formStep3.Close();
            AuntRosieApp.frmHome.formStep4.Close();
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
        /// Display event in form as text
        /// </summary>
        private void displayEvent()
        {
            if (rosieEvent != null)
            {
                txtEvent.Text = rosieEvent.ToString();
            }
        }

        /// <summary>
        /// Setup initial configuration of datagrids
        /// </summary>
        private void prepareDataGrids()
        {
            dtgProduction.DataSource = productionSource;
            dtgProduction.AutoGenerateColumns = true;
            prepareEmployeeGrid();
        }

        /// <summary>
        /// Load employee hours data grid
        /// </summary>
        private void loadEmployeeHours()
        {
            DataTable employeeTable = EmployeeHours.GetEmployeeHoursUpdateable(rosieEvent.Id);
            employeeHoursSource.DataSource = employeeTable;
        }

        /// <summary>
        /// Load production data grid
        /// </summary>
        private void loadProductionGrid()
        {
            productionSource.DataSource = EventProduct.GetProductionsTable(rosieEvent.Id);
        }

        /// <summary>
        /// Load production and employee hours records
        /// </summary>
        private void loadDataGrids()
        {
            loadEmployeeHours();
            loadProductionGrid();
        }

        /// <summary>
        /// Setup employee data grid
        /// </summary>
        private void prepareEmployeeGrid()
        {
            dtgEmployeeHours.AutoGenerateColumns = true;
            dtgEmployeeHours.DataSource = employeeHoursSource;
           /* DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.HeaderText = "Delete";
            column.Name = "dataGridDeleteButton";
            column.Text = "Delete";
            column.UseColumnTextForButtonValue = true;
            dtgEmployeeHours.Columns.Add(column);
            int count = dtgEmployeeHours.Columns.Count;
            if (count >= 2)
            {
                DataGridViewColumn temp = dtgEmployeeHours.Columns[0];
                dtgEmployeeHours.Columns.Insert(0, dtgEmployeeHours.Columns[count - 1]);
                dtgEmployeeHours.Columns.Insert(count - 1, temp);
            }*/
        }

        /// <summary>
        /// Connect to the database and load data into form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmOrganizeEventStep4_Load(object sender, EventArgs e)
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
            prepareDataGrids();
            loadDataGrids();
        }
    }
}
