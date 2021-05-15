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

namespace AuntRosieUserInterface.Views.Event
{
    /// <summary>
    /// Interaction logic for Sales.xaml
    /// </summary>
    public partial class Sales : Page
    {

        //Member Variables
        private bool isCreateOpen;

        public Sales()
        {
            InitializeComponent();

            //Loads the customer window hidden
            sp_CreateCustomer.Visibility = Visibility.Hidden;


            //Temporary Output
            cmbCustomer.Items.Add("Guest Checkout");
            cmbCustomer.Items.Add("Jim Carey");
            cmbCustomer.Items.Add("Greyson Chance");
            cmbCustomer.Items.Add("Tyler Miller");
            cmbCustomer.Items.Add("Steven Martin");
            cmbCustomer.Items.Add("Bill Nye");

            cmbProducts.Items.Add("Steak and Kidney Pie");

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateCustomer_Click(object sender, RoutedEventArgs e)
        {
            if (!isCreateOpen)
            {
                btnCreate.IsEnabled = false;
                isCreateOpen = true;
                sp_CreateCustomer.Visibility = Visibility.Visible;
            } else
            {
                btnCreate.IsEnabled = true;
                isCreateOpen = false;
                sp_CreateCustomer.Visibility = Visibility.Hidden;
            }
        }

        /// <summary>
        /// Adds each component with a quantity to the list for display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToCart_Click(object sender, RoutedEventArgs e)
        {
            lstCart.Items.Add(cmbProducts.SelectedItem.ToString() + " | x" + txtQuantity.Text);
            cmbProducts.Focus();
            txtQuantity.Text = "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckOut_Click(object sender, RoutedEventArgs e)
        {
            ///
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitCustomer_Click(object sender, RoutedEventArgs e)
        {
            string newCustomer = txtCustomerName.Text;

            cmbCustomer.Items.Add(newCustomer);
            sp_CreateCustomer.Visibility = Visibility.Hidden;

            btnCreate.IsEnabled = true;
            txtCustomerName.Text = "";
            txtPhoneNumber.Text = "";
        }

        /// <summary>
        /// Closes the screen if the user changes their mind
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseCustomerCreate_Click(object sender, RoutedEventArgs e)
        {
            //Hide the screen and clear the values
            sp_CreateCustomer.Visibility = Visibility.Hidden;
            btnCreate.IsEnabled = true;
            txtCustomerName.Text = "";
            txtPhoneNumber.Text = "";
            isCreateOpen = false;
        }

        /// <summary>
        /// Removes unwanted item from cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveItem_Click(object sender, RoutedEventArgs e)
        {

            if(lstCart.SelectedIndex >= 0)
            {
                lstCart.Items.RemoveAt(lstCart.SelectedIndex);
            }
        }


    }
}
