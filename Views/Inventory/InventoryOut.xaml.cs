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

namespace AuntRosieUserInterface.Views.Inventory
{
    /// <summary>
    /// Interaction logic for Inventory_Out.xaml
    /// </summary>
    public partial class InventoryOut : Page
    {
        public InventoryOut()
        {
            InitializeComponent();

            //Temporary add

            lstIngredients.Items.Add("Potatoes");
            lstIngredients.Items.Add("Onions");
            lstIngredients.Items.Add("Flour");
            lstIngredients.Items.Add("Eggs");
            lstIngredients.Items.Add("Butter");
            lstIngredients.Items.Add("Ketchup");
        }

        /// <summary>
        /// Submits request and updates quantities in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TakeOut_Click(object sender, RoutedEventArgs e)
        {
            //
        }

        /// <summary>
        /// Adds values to cart for the user to see
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            string suffix = "";
            if (radPounds.IsChecked == true)
            {
                suffix = "LBS";
            } else if (radKilos.IsChecked == true)
            {
                suffix = "KG";
            } else if (radLitres.IsChecked == true)
            {
                suffix = "L";
            }
            lstCart.Items.Add(txtQuantity.Text + " " + suffix + " | " + lstIngredients.SelectedItem.ToString());
        }
    }
}
