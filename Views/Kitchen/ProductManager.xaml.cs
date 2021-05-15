using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AuntRosieUserInterface.Views.Kitchen
{

    /// <summary>
    /// Interaction logic for ProductManager.xaml
    /// </summary>
    public partial class ProductManager : Page
    {
        public ProductManager()
        {
            InitializeComponent();

            //Temporary Output
            cmbProducts.Items.Add("Kidney Pie");

            lstIngredients.Items.Add("Potatoes");
            lstIngredients.Items.Add("Onions");
            lstIngredients.Items.Add("Flour");
            lstIngredients.Items.Add("Eggs");
            lstIngredients.Items.Add("Butter");
            lstIngredients.Items.Add("Ketchup");
        }



        /// <summary>
        /// After validation, sets change into the database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommitChange_Click(object sender, RoutedEventArgs e)
        {
            //Submits change to database
        }

        /// <summary>
        /// When a product is selected, output to the values entered
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            //Temporary Output, meant to be retrieved from database
            if(cmbProducts.SelectedIndex == 0)
            {
                txtServingSize.Text = "1";
                radKilos.IsChecked = true;

                cmbProductType.SelectedIndex = 0;
                txtNutrition.Text = "100 Calories - 8 G of Sugar";
                txtPrice.Text = "$4.99";

                lstIngredients.SelectedIndex = 1;
            }
            
        }
    }
}
