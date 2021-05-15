/**
 * Author: Oghenefejiro Theodore Abohweyere
 * Purpose: Update product
 * Date: 2020-12-17
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AuntRosieEntities;

namespace AuntRosieApplication.Kitchen
{
    public partial class frmUpdateProduct : Form
    {
        short lastSelectedId = -1;

        public frmUpdateProduct()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validate form input
        /// </summary>
        /// <returns></returns>
        private bool validate()
        {
            return validateName() & validateSize();
        }

        /// <summary>
        /// Validate name
        /// </summary>
        /// <returns></returns>
        private bool validateName()
        {
            if (txtName.Text.Length < 1)
            {
                errorProvider1.SetError(txtName, "Name cannot be blank");
                return false;
            }

            errorProvider1.SetError(txtName, "");
            return true;
        }

        /// <summary>
        /// Validate size
        /// </summary>
        /// <returns></returns>
        private bool validateSize()
        {
            if (txtName.Text.Length < 1)
            {
                errorProvider1.SetError(txtSize, "Serving Size cannot be blank");
                return false;
            }

            errorProvider1.SetError(txtSize, "");
            return true;
        }

        /// <summary>
        /// Save product updates
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                try
                {
                    Product product = cmbName.SelectedItem as Product;
                    string previousProduct = product.ToString();
                    product.Name = txtName.Text;
                    product.ServingSize = txtSize.Text;
                    product.Type = cmbType.Text;

                    product.Update();
                    MessageBox.Show($"Succesfully updated\n{previousProduct}\nto\n{product}");
                    loadExistingProducts(lastSelectedId);
                }
                catch (SqlException se)
                {
                    if (se.Message.Contains("duplicate key"))
                    {
                        errorProvider1.SetError(txtName, "A product with this name already exists");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong");
                }
            }
        }

        /// <summary>
        /// Make sure that the serving size entered is valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSize_TextChanged(object sender, EventArgs e)
        {
            if (txtSize.Text.Length > 20)
            {
                txtSize.Text = txtSize.Text.Substring(0, txtSize.Text.Length - 1);
                errorProvider1.SetError(txtSize, "Name cannot be greater than 20");
            }
            else
            {
                errorProvider1.SetError(txtSize, "");
            }
        }

        /// <summary>
        /// Load existing products from the database into
        /// the form
        /// </summary>
        /// <param name="previousProduct"></param>
        private void loadExistingProducts(short previousProduct = -1)
        {
            cmbName.Items.Clear();
            bool selectedSomething = false;
            foreach (Product product in Product.GetProducts())
            {
                cmbName.Items.Add(product);
                if (product.Id == previousProduct)
                {
                    cmbName.SelectedItem = product;
                    selectedSomething = true;
                }
            }

            if(!selectedSomething && (cmbName.Items.Count > 0))
            {
                cmbName.SelectedItem = cmbName.Items[0];
            }
            cmbName.DisplayMember = "Name";
        }

        /// <summary>
        /// Load product for modification
        /// </summary>
        /// <param name="product"></param>
        private void loadProduct(Product product)
        {
            
            txtName.Text = product.Name;
            cmbType.SelectedItem = product.Type;
            txtSize.Text = product.ServingSize;
            lastSelectedId = product.Id;
        }

        /// <summary>
        /// Connect to the database and load comboboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;

            //Connect to the database
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;

            //load comboboxes
            cmbType.DataSource = new string[] { "pie", "preserve" };
            loadExistingProducts();
        }

        /// <summary>
        /// Make sure that product name is valid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 100)
            {
                txtName.Text = txtName.Text.Substring(0, txtName.Text.Length - 1);
                errorProvider1.SetError(txtName, "Name cannot be greater than 100");
            }
            else
            {
                errorProvider1.SetError(txtName, "");
            }
        }

        /// <summary>
        /// Revert changes on the current product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (cmbName.SelectedItem != null)
            {
                loadProduct(cmbName.SelectedItem as Product);
            }
        }

        /// <summary>
        /// Load selected product into form for modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbName.SelectedItem != null)
            {
                loadProduct(cmbName.SelectedItem as Product);
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

        /// <summary>
        /// Delete product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = cmbName.SelectedItem as Product;

                product.Delete();

                cmbName.Items.Remove(product);
                cmbName.SelectedIndex = 0;
            }
            catch(ArgumentOutOfRangeException aore)
            {
                
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
