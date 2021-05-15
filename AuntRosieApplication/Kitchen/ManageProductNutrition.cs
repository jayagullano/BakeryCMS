/**
 * Author: Oghenefejiro Theodore Abohweyere
 * Purpose: Manage product nutrition
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
    public partial class frmManageProductNutrition : Form
    {
        private Dictionary<string, char> valueTypes = new Dictionary<string, char>()
        {
            { "Weight (g)", 'W' },
            {"Percentage (%)", 'P'},
            {"Other", 'O'}
        };

        private ProductNutrition currentSelection = null;
        public frmManageProductNutrition()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Connect to the database and load data into form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManageProductNutrition_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = global::AuntRosieApplication.Properties.Resources.background2;
            String DatabasePath = System.IO.Directory.GetCurrentDirectory();
            int x = DatabasePath.IndexOf("bin");
            DatabasePath = DatabasePath.Substring(0, x - 1);
            String conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DatabasePath +
              @"\AuntRosieDB.mdf;Integrated Security=True;Connect Timeout=30";
            DBConnector conn = new DBConnector(conStr);
            RosieEntity.Connector = conn;
            loadCmbs();
        }

        /// <summary>
        /// Load combobox/dropdown data
        /// </summary>
        private void loadCmbs()
        {
            //Load products combobox
            cmbProduct.DataSource = ProductItem.GetProductItems();

            cmbNutrType.DataSource = Nutrition.GetNutritions();
            cmbNutrType.DisplayMember = "Name";

            cmbValType.DataSource = valueTypes.Keys.ToList<string>();
        }

        /// <summary>
        /// Validate form input
        /// </summary>
        /// <returns></returns>
        private bool validate()
        {
            double value = -1;
            if(!double.TryParse(txtValue.Text, out value))
            {
                errorProvider1.SetError(txtValue, "Value must be a number");
                return false;
            }

            if(value < 0 || value > 9999.99)
            {
                errorProvider1.SetError(txtValue, "Value must be between 0 and 9999.99");
                return false;
            }

            errorProvider1.SetError(txtValue, "");

            return true;
        }

        /// <summary>
        /// Load nutrition data for current selection of product and nutrition type
        /// </summary>
        private void loadExistingData()
        {
            if (cmbNutrType.SelectedItem != null && cmbProduct.SelectedItem != null)
            {
                short nutritionID = (cmbNutrType.SelectedItem as Nutrition).Id;
                int prodItemID = (cmbProduct.SelectedItem as ProductItem).Id;
                currentSelection = ProductNutrition.Retrieve(nutritionID, prodItemID);

                if(currentSelection is null)
                {
                    txtValue.Text = "";
                }
                else
                {
                    txtValue.Text = currentSelection.Value.ToString();
                    cmbValType.SelectedItem = valueTypes.First<KeyValuePair<string, char>>(
                        (elem) => { return elem.Value == currentSelection.ValueType; }
                        ).Key;
                }
            }
        }

        /// <summary>
        /// Load nutrition data for current selection of product and nutrition type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadExistingData();
        }

        /// <summary>
        /// Load nutrition data for current selection of product and nutrition type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbNutrType_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadExistingData();
        }

        /// <summary>
        /// Move onto the final step of saving
        /// changes in the form to the DB
        /// </summary>
        private void proceedToSave()
        {
            bool newCreated = true;
            try
            {
                newCreated = saveChanges();
            }
            catch (SqlException se)
            {
                currentSelection = newCreated ? null : currentSelection;
                if(se.Message.Contains("duplicate key"))
                {
                    MessageBox.Show("Product already has a value for this nutrition type");
                }
            }
            catch
            {
                currentSelection = newCreated ? null : currentSelection;
                MessageBox.Show("Something went wrong");
            }
        }

        /// <summary>
        /// Saves changes to DB
        /// </summary>
        /// <returns>true if a new record was created; else false</returns>
        private bool saveChanges()
        {
            currentSelection = currentSelection is null ? new ProductNutrition() : currentSelection;
            bool newCreated = currentSelection.Value < 0; ;
            currentSelection.NutritionId = (cmbNutrType.SelectedItem as Nutrition).Id;
            currentSelection.ProductItemId = (cmbProduct.SelectedItem as ProductItem).Id;
            currentSelection.Value = double.Parse(txtValue.Text);
            currentSelection.ValueType = valueTypes[cmbValType.SelectedItem as string];

            if (newCreated)
            {
                //The current product-nutrition combination does not exist in the database
                //Create new combination of product-nutrition
                currentSelection.Create();
                MessageBox.Show("Sucessfully added nutrition");
            }
            else
            {
                //The current product-nutrition combination exists in the database
                //Update product-nutrition values for the current selection
                currentSelection.Update();
                MessageBox.Show("Sucessfully updated nutrition");
            }

            return newCreated;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                proceedToSave();
            }
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            if(txtValue.Text.Length > 7)
            {
                txtValue.Text = txtValue.Text.Substring(0, txtValue.Text.Length-1);
            }
        }
    }
}
