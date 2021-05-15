/**
 * Author: Oghenefejiro Theodore Abohweyere
 * Purpose: View products
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
    public partial class frmViewProducts : Form
    {
        BindingSource productSource = new BindingSource();
        public frmViewProducts()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Connect to database and load data into form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewProducts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'auntRosieDBDataSet.tblProduct' table. You can move, or remove it, as needed.
            //this.tblProductTableAdapter.Fill(this.auntRosieDBDataSet.tblProduct);
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;
            dtgProductList.DataSource = productSource;
            loadDataInitial();
        }

        /// <summary>
        /// Load initial data into comboboxes
        /// </summary>
        private void loadDataInitial()
        {
            addDeleteButtonToGrid();
            productSource.DataSource = Product.GetProducts();
        }

        /// <summary>
        /// Add delete button to data grid
        /// </summary>

        private void addDeleteButtonToGrid()
        {
            DataGridViewButtonColumn column = new DataGridViewButtonColumn();
            column.HeaderText = "Delete";
            column.Name = "DeleteButton";
            column.Text = "Delete";
            column.UseColumnTextForButtonValue = true;
            dtgProductList.AutoGenerateColumns = true;
            dtgProductList.Columns.Add(column);
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
        /// Handle delete button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dtgProductList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgProductList.Columns["DeleteButton"].Index)
            {
                try
                {
                    DataGridViewRow clickedRow = dtgProductList.Rows[e.RowIndex];
                    (clickedRow.DataBoundItem as Product).Delete();

                    dtgProductList.Rows.Remove(clickedRow);
                }
                catch
                {

                }
            }
        }
    }
}
