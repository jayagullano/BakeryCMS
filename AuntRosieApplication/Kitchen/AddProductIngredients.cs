/**
 * Author: Oghenefejiro Theodore Abohweyere
 * Purpose: Add new product ingredient into the database
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
    public partial class frmAddProductIngredients : Form
    {
        /// <summary>
        /// Default product item
        /// </summary>
        ProductItem productItem = null;
        long ingredient = -1;

        /// <summary>
        /// Load form
        /// </summary>
        /// <param name="productItem"></param>
        public frmAddProductIngredients(ProductItem productItem)
        {
            this.productItem = productItem;
            InitializeComponent();
        }

        /// <summary>
        /// Load form
        /// </summary>
        public frmAddProductIngredients()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Load form with default productItem and ingredient ID
        /// </summary>
        /// <param name="productItem"></param>
        /// <param name="ingredientID"></param>
        public frmAddProductIngredients(ProductItem productItem, long ingredientID)
        {
            this.productItem = productItem;
            this.ingredient = ingredientID;
            InitializeComponent();
        }

        /// <summary>
        /// Select default product and ingredient in form
        /// </summary>
        /// <param name="productItem"></param>
        /// <param name="ingredientID"></param>
        private void selectInForm(ProductItem productItem, long ingredientID)
        {
            selectProductInForm(productItem);
            selectIngredientInForm(ingredientID);
        }

        /// <summary>
        /// Select default product in form
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
        /// Select default ingredient in form
        /// </summary>
        /// <param name="ingredientID"></param>
        private void selectIngredientInForm(long ingredientID)
        {
            if (ingredient != -1)
            {
                foreach (Ingredient ingredient in cmbIngredients.Items)
                {
                    if (ingredientID == ingredient.Id)
                    {
                        cmbIngredients.SelectedItem = ingredient;
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// Select unit in form
        /// </summary>
        /// <param name="unit"></param>
        private void selectUnitInForm(string unit)
        {
            if(unit != null)
            {
                cmbUnits.SelectedItem = unit;
            }
        }

        /// <summary>
        /// Load selected product and ingredient combination
        /// into form
        /// </summary>
        private void loadIntoForm()
        {
            if (cmbIngredients.SelectedItem != null && cmbProductName.SelectedItem != null)
            {
                ProductIngredient productIngredient = ProductIngredient.Retrieve(
                    (cmbProductName.SelectedItem as ProductItem).Id,
                    (cmbIngredients.SelectedItem as Ingredient).Id);

                if (productIngredient != null)
                {
                    txtQuantity.Text = productIngredient.Quantity.ToString();
                    selectUnitInForm(productIngredient.Unit);
                }
            }
        }

        /// <summary>
        /// Validate form input
        /// </summary>
        /// <returns></returns>
        private bool validate()
        {
            return validateProducts() & validateQuantity();
        }

        /// <summary>
        /// Validate quantity input
        /// </summary>
        /// <returns></returns>
        private bool validateQuantity()
        {
            double quantity = 0;
            if(!double.TryParse(txtQuantity.Text, out quantity))
            {
                errorProvider1.SetError(txtQuantity, "Quantity must be a number");
                return false;
            }

            if(quantity<0)
            {
                errorProvider1.SetError(txtQuantity, "Quantity must be a positive number");
                return false;
            }

            errorProvider1.SetError(txtQuantity, "");

            return true;
        }

        /// <summary>
        /// Validate product input
        /// </summary>
        /// <returns></returns>
        private bool validateProducts()
        {
            if(cmbProductName.SelectedItem == null)
            {
                errorProvider1.SetError(cmbProductName, "A product has to be selected");
                return false;
            }

            errorProvider1.SetError(cmbProductName, "");
            return true;
        }

        /// <summary>
        /// Save Product Ingredients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if(validate())
            {
                try
                {
                    long ingredientId = (cmbIngredients.SelectedItem as Ingredient).Id;
                    int productItemID = (cmbProductName.SelectedItem as ProductItem).Id;

                    ProductIngredient subject = ProductIngredient.Retrieve(productItemID, ingredientId);
                    
                    

                    if (subject is null)
                    {
                        //Create new ingredient-product record
                        subject = new ProductIngredient();
                        subject.IngredientId = ingredientId;
                        subject.ProductItemId = productItemID;
                        subject.Quantity = double.Parse(txtQuantity.Text);
                        subject.Unit = cmbUnits.SelectedItem as string;
                        subject.Create();
                        MessageBox.Show("Product ingredient added");
                    }
                    else
                    {
                        subject.Quantity = double.Parse(txtQuantity.Text);
                        subject.Unit = cmbUnits.SelectedItem as string;
                        subject.Update();
                        MessageBox.Show("Product ingredient updated");
                    }
                }
                catch
                {
                    MessageBox.Show("Failed to add or update");
                }
            }
        }

        /// <summary>
        /// Connect to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddProductIngredients_Load(object sender, EventArgs e)
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
            selectInForm(productItem, ingredient);
        }

        /// <summary>
        /// Load comboboxes into form
        /// </summary>
        private void loadCmb()
        {
            cmbProductName.DataSource = ProductItem.GetProductItems();
            loadIngredientCmbs();
            cmbUnits.SelectedIndex = 0;
        }

        /// <summary>
        /// Load ingredient comboboxes
        /// </summary>
        private void loadIngredientCmbs()
        {
            List<Ingredient> lstIngredients = new List<Ingredient>();
            DataTable ingredients = Ingredient.GetAllIngredints(RosieEntity.Connector.Connection.ConnectionString);
            
            foreach(DataRow row in ingredients.Rows)
            {
                Ingredient ingredient = new Ingredient();
                ingredient.Id = row.Field<long>("IngredientID");
                ingredient.Name = row.Field<string>("IngredientName");
                lstIngredients.Add(ingredient);
            }
            cmbIngredients.DataSource = lstIngredients;
            cmbIngredients.DisplayMember = "Name";
        }

        private void cmbIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadIntoForm();
        }

        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadIntoForm();
        }

        /// <summary>
        /// Go back to product ingredient screen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmManageProductIngredients frm = new frmManageProductIngredients(cmbProductName.SelectedItem as ProductItem);
            frm.ShowDialog();
        }
    }
}
