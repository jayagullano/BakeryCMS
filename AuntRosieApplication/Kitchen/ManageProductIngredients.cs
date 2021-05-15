/**
 * Author: Oghenefejiro Theodore Abohweyere
 * Purpose: View, update, delete and add ingredients as components of products
 * Date: 2020-12-16
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
    public partial class frmManageProductIngredients : Form
    {
        /// <summary>
        /// Binding source for the ingredient datagrid
        /// </summary>
        private BindingSource ingredientSource = new BindingSource();
        private BindingSource productItemSource = new BindingSource();

        /// <summary>
        /// ProductItem to select as soon as the form is loaded
        /// </summary>
        private ProductItem productItemToSelect = null;

        public frmManageProductIngredients(ProductItem productItemToSelect)
        {
            this.productItemToSelect = productItemToSelect;
            InitializeComponent();
        }

        public frmManageProductIngredients()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handle database connections and loading of data into the form to be viewed by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmManageProductIngredients_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;
            loadCmb();
            prepareDataGrid();
        }

        /// <summary>
        /// Prepare/setup data grid view
        /// </summary>
        private void prepareDataGrid()
        {
            addUpdateButtonColumn();
            addDeleteButtonColumn();
            dtgIngredients.DataSource = ingredientSource;
            dtgIngredients.AutoGenerateColumns = true;
        }

        /// <summary>
        /// Load data into the comboboxes
        /// </summary>
        private void loadCmb()
        {
            cmbProductName.DataSource = ProductItem.GetProductItems();
            if(productItemToSelect != null)
            {
                selectProductInForm(productItemToSelect);
            }
        }

        /// <summary>
        /// Select product item in the combobox in the form
        /// </summary>
        /// <param name="productItem"></param>
        private void selectProductInForm(ProductItem productItem)
        {
            if (productItem != null)
            {
                foreach (ProductItem productInCmb in cmbProductName.Items)
                {
                    if (productItem.Id == productInCmb.Id)
                    {
                        cmbProductName.SelectedItem = productInCmb;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Add column that contains update buttons to the
        /// production data grid view
        /// </summary>
        private void addUpdateButtonColumn()
        {
            DataGridViewButtonColumn updateBtnColumn = new DataGridViewButtonColumn();
            updateBtnColumn.HeaderText = "Update";
            updateBtnColumn.Name = "updateColumn";
            updateBtnColumn.Text = "Update";
            updateBtnColumn.UseColumnTextForButtonValue = true;
            dtgIngredients.Columns.Add(updateBtnColumn);
        }

        /// <summary>
        /// Add a delete button column to the code
        /// </summary>
        private void addDeleteButtonColumn()
        {
            DataGridViewButtonColumn deleteBtnColumn = new DataGridViewButtonColumn();
            deleteBtnColumn.HeaderText = "Delete";
            deleteBtnColumn.Name = "deleteColumn";
            deleteBtnColumn.Text = "Delete";
            deleteBtnColumn.UseColumnTextForButtonValue = true;
            dtgIngredients.Columns.Add(deleteBtnColumn);
        }

        /// <summary>
        /// Load ingredients of a product item into the datagrid
        /// </summary>
        /// <param name="productItem">Product item whose ingredients we want</param>
        private void loadDataGrid(ProductItem productItem)
        {
            ingredientSource.DataSource = ProductIngredient.GetIngredientsTable(productItem.Id);
        }

        /// <summary>
        /// Show ingredients of the new product item selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(cmbProductName.SelectedItem is null))
            {
                loadDataGrid(cmbProductName.SelectedItem as ProductItem);
            }
        }

        /// <summary>
        /// Handle update and delete button clicks
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtgIngredients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dtgIngredients.Columns["updateColumn"].Index)
            {
                UpdateRow(e);
            }
            else if(e.ColumnIndex == dtgIngredients.Columns["deleteColumn"].Index)
            {
                DeleteRow(e);
            }
        }

        /// <summary>
        /// Delete ingredient row
        /// </summary>
        /// <param name="e"></param>
        private void DeleteRow(DataGridViewCellEventArgs e)
        {
            try
            {
                //Delete ingredient
                long ingredientID = (long)dtgIngredients.Rows[e.RowIndex].Cells["IngredientID"].Value;
                ProductItem productItem = (cmbProductName.SelectedItem as ProductItem);

                ProductIngredient productIngredient = new ProductIngredient();
                productIngredient.IngredientId = ingredientID;
                productIngredient.ProductItemId = productItem.Id;
                productIngredient.Delete();
                dtgIngredients.Rows.Remove(dtgIngredients.Rows[e.RowIndex]);
            }
            catch
            {
                MessageBox.Show("Unable to delete ingredient");
            }
        }

        /// <summary>
        /// Update ingredient row
        /// </summary>
        /// <param name="e"></param>
        private void UpdateRow(DataGridViewCellEventArgs e)
        {
            try
            {
                //Move to update window
                long ingredientID = (long)dtgIngredients.Rows[e.RowIndex].Cells["IngredientID"].Value;
                this.Close();
                frmAddProductIngredients frm = new frmAddProductIngredients(cmbProductName.SelectedItem as ProductItem,
                    ingredientID);
                frm.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Unable to update ingredient");
            }
        }

        /// <summary>
        /// Go on to add a new ingredient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddIngredient_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddProductIngredients frm = new frmAddProductIngredients();
            frm.ShowDialog();
        }
    }
}
