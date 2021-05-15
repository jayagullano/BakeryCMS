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
    /// Interaction logic for Kitchen.xaml
    /// </summary>
    public partial class Kitchen : Page
    {
        public Kitchen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Member Variables Used To Check if Open
        /// </summary>
        private bool openAddProduct;
        private bool openProductManager;
        private bool openProduction;

        /// <summary>
        /// Navigates to addProduct Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void addProduct_Click (object sender, RoutedEventArgs e)
        {
            if (!openAddProduct)
            {
                btnAddProduct.Background = new SolidColorBrush(Colors.Red);
                HomeScreen.Content = new AddProduct();
                openAddProduct = true;

                btnProduction.IsEnabled = false;
                btnManageProducts.IsEnabled = false;
            } else
            {
                btnAddProduct.Background = new SolidColorBrush(Colors.White);
                HomeScreen.Content = "";
                openAddProduct = false;

                btnProduction.IsEnabled = true;
                btnManageProducts.IsEnabled = true;
            }
        }

        /// <summary>
        /// Navigates to ProductManager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OpenProductManager_Click(object sender, RoutedEventArgs e)
        {

            if (!openProductManager)
            {
                btnManageProducts.Background = new SolidColorBrush(Colors.Red);
                HomeScreen.Content = new ProductManager();
                openProductManager = true;

                btnProduction.IsEnabled = false;
                btnAddProduct.IsEnabled = false;
            }
            else
            {
                btnManageProducts.Background = new SolidColorBrush(Colors.White);
                HomeScreen.Content = "";
                openProductManager = false;

                btnProduction.IsEnabled = true;
                btnAddProduct.IsEnabled = true;
            }
        }

        /// <summary>
        /// Navigates to Production page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenProduction_Click(object sender, RoutedEventArgs e)
        {
            if (!openProduction)
            {
                btnProduction.Background = new SolidColorBrush(Colors.Red);
                HomeScreen.Content = new AddProduction();
                openProduction = true;

                btnAddProduct.IsEnabled = false;
                btnManageProducts.IsEnabled = false;
            } else
            {
                btnProduction.Background = new SolidColorBrush(Colors.White);
                HomeScreen.Content = "";
                openProduction = false;

                btnAddProduct.IsEnabled = true;
                btnManageProducts.IsEnabled = true;
            }
        }
    }


}
