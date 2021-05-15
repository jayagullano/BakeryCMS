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
    /// Interaction logic for Inventory_In.xaml
    /// </summary>
    public partial class InventoryIn : Page
    {
        public InventoryIn()
        {
            InitializeComponent();

            //Hide the create supplier screen on page load
            sp_CreateSupplier.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Pushes information once validated to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submitInventory_Click(object sender, RoutedEventArgs e)
        {
            ///
        }

        /// <summary>
        /// Opens window for user input of new supplier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSupplier_Click(object sender, RoutedEventArgs e)
        {

            //Disable Add Supplier Button until user submits request
            btnAddSupplier.IsEnabled = false;
            
            //Enable the Create supplier screen
            sp_CreateSupplier.Visibility = Visibility.Visible;

        }

        /// <summary>
        /// Adds the supplier information to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitCustomer_Click(object sender, RoutedEventArgs e)
        {
            //Temporary Output for example
            cmbSupplier.Items.Add(txtSupplierName.Text);

            //Enable the add supplier button and hide the create supplier screen
            btnAddSupplier.IsEnabled = true;
            sp_CreateSupplier.Visibility = Visibility.Hidden;

            //Clear textboxes
            txtSupplierName.Text = "";
            txtPhoneNumber.Text = "";
            txtContactFirstName.Text = "";
            txtContactLastName.Text = "";
            txtAddress.Text = "";
        }

        /// <summary>
        /// Closes the creation window for supplier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseSupplierCreate_Click(object sender, RoutedEventArgs e)
        {
            btnAddSupplier.IsEnabled = true;
            sp_CreateSupplier.Visibility = Visibility.Hidden;
        }
    }
}
