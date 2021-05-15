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

using AuntRosieUserInterface.Views.Inventory;
using AuntRosieUserInterface.Views.Kitchen;
using AuntRosieUserInterface.Views.Event;
using AuntRosieUserInterface.Views.Expenses;
using AuntRosieUserInterface.Views.Reports;
using AuntRosieUserInterface.Views.Query;
using AuntRosieUserInterface.Views.Employment;


namespace AuntRosieUserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Prompt for login screen
            Login getLogin = new Login();
            getLogin.ShowDialog();

            if (!getLogin.isAdmin && !getLogin.isEmployee)
            {
                Close();
            } 
            else if (!getLogin.isAdmin && getLogin.isEmployee)
            {
                adminView(); //Disables other employment views
            }

            lblTime.Content = DateTime.Now;
        }

        //Member Variables
        static bool inventoryOpen;
        static bool kitchenOpen;
        static bool eventOpen;
        static bool expensesOpen;
        static bool reportsOpen;
        static bool queriesOpen;
        static bool employmentOpen;

        private void ListViewItem_MouseEnter(object sender, MouseEventArgs e)
        {
            // Set tooltip visibility

            if (PieButton.IsChecked == true)
            {
                tt_Inventory.Visibility = Visibility.Collapsed;
                tt_Kitchen.Visibility = Visibility.Collapsed;
                tt_Event.Visibility = Visibility.Collapsed;
                tt_Expenses.Visibility = Visibility.Collapsed;
                tt_Reports.Visibility = Visibility.Collapsed;
                tt_Query.Visibility = Visibility.Collapsed;
                tt_Employment.Visibility = Visibility.Collapsed;
                tt_SignOut.Visibility = Visibility.Collapsed;
            }
            else
            {
                tt_Inventory.Visibility = Visibility.Visible;
                tt_Kitchen.Visibility = Visibility.Visible;
                tt_Event.Visibility = Visibility.Visible;
                tt_Expenses.Visibility = Visibility.Visible;
                tt_Reports.Visibility = Visibility.Visible;
                tt_Query.Visibility = Visibility.Visible;
                tt_Employment.Visibility = Visibility.Visible;
                tt_SignOut.Visibility = Visibility.Visible;
            }
        }

        private void adminView()
        {
            btnQuery.IsEnabled = false;
            btnReports.IsEnabled = false;
            btnExpenses.IsEnabled = false;
            btnEmployment.IsEnabled = false;

            lvExpenses.Content = "";
            lvReports.Content = "";
            lvQuery.Content = "";
            lvEmployment.Content = "";

        }

        private void pieButtonUnchecked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 1;
        }

        private void pieButtonChecked(object sender, RoutedEventArgs e)
        {
            img_bg.Opacity = 0.3;
        }

        private void MainGridActionButton(object sender, MouseButtonEventArgs e)
        {
            PieButton.IsChecked = false;
        }
        
        /// <summary>
        /// Signs out of the current page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignOut_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Opens the Inventory Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenInventory_Click(object sender, RoutedEventArgs e)
        {
            if (!inventoryOpen) //Inventory view is NOT open
            {
                HomeScreen.Content = new InventoryPage();
                inventoryOpen = true;

                btnKitchen.IsEnabled = false;
                btnEvents.IsEnabled = false;
                btnExpenses.IsEnabled = false;
                btnReports.IsEnabled = false;
                btnQuery.IsEnabled = false;
                btnEmployment.IsEnabled = false;
            } else
            {
                HomeScreen.Content = "";
                inventoryOpen = false;

                btnKitchen.IsEnabled = true;
                btnEvents.IsEnabled = true;
                btnExpenses.IsEnabled = true;
                btnReports.IsEnabled = true;
                btnQuery.IsEnabled = true;
                btnEmployment.IsEnabled = true;
            }
        }

        /// <summary>
        /// Opens the Kitchen Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenKitchen_Click(object sender, RoutedEventArgs e)
        {
            if (!kitchenOpen) //Kitchen view is NOT open
            {
                HomeScreen.Content = new Kitchen(); //Show Page
                kitchenOpen = true;

                btnInventory.IsEnabled = false;
                btnEvents.IsEnabled = false;
                btnExpenses.IsEnabled = false;
                btnReports.IsEnabled = false;
                btnQuery.IsEnabled = false;
                btnEmployment.IsEnabled = false;
            }
            else
            {
                HomeScreen.Content = "";
                kitchenOpen = false;

                btnInventory.IsEnabled = true;
                btnEvents.IsEnabled = true;
                btnExpenses.IsEnabled = true;
                btnReports.IsEnabled = true;
                btnQuery.IsEnabled = true;
                btnEmployment.IsEnabled = true;
            }
        }

        /// <summary>
        /// Opens the Event Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenEvent_Click(object sender, RoutedEventArgs e)
        {
            if (!eventOpen) //Event view is NOT open
            {
                HomeScreen.Content = new Event(); //Show Page
                eventOpen = true;

                btnInventory.IsEnabled = false;
                btnKitchen.IsEnabled = false;
                btnExpenses.IsEnabled = false;
                btnReports.IsEnabled = false;
                btnQuery.IsEnabled = false;
                btnEmployment.IsEnabled = false;
            }
            else
            {
                HomeScreen.Content = "";
                eventOpen = false;

                btnInventory.IsEnabled = true;
                btnKitchen.IsEnabled = true;
                btnExpenses.IsEnabled = true;
                btnReports.IsEnabled = true;
                btnQuery.IsEnabled = true;
                btnEmployment.IsEnabled = true;
            }
        }

        /// <summary>
        /// Opens the Expenses Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenExpenses_Click(object sender, RoutedEventArgs e)
        {
            if (!expensesOpen) //Inventory view is NOT open
            {
                HomeScreen.Content = new Expenses(); //Show Page
                expensesOpen = true;

                btnInventory.IsEnabled = false;
                btnKitchen.IsEnabled = false;
                btnEvents.IsEnabled = false;
                btnReports.IsEnabled = false;
                btnQuery.IsEnabled = false;
                btnEmployment.IsEnabled = false;
            }
            else
            {
                HomeScreen.Content = "";
                expensesOpen = false;

                btnInventory.IsEnabled = true;
                btnKitchen.IsEnabled = true;
                btnEvents.IsEnabled = true;
                btnReports.IsEnabled = true;
                btnQuery.IsEnabled = true;
                btnEmployment.IsEnabled = true;
            }
        }

        /// <summary>
        /// Opens the Reports Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenReports_Click(object sender, RoutedEventArgs e)
        {
            if (!reportsOpen) //Inventory view is NOT open
            {
                HomeScreen.Content = new Reports(); //Show Page
                reportsOpen = true;

                btnInventory.IsEnabled = false;
                btnKitchen.IsEnabled = false;
                btnEvents.IsEnabled = false;
                btnExpenses.IsEnabled = false;
                btnQuery.IsEnabled = false;
                btnEmployment.IsEnabled = false;
            }
            else
            {
                HomeScreen.Content = "";
                reportsOpen = false;

                btnInventory.IsEnabled = true;
                btnKitchen.IsEnabled = true;
                btnEvents.IsEnabled = true;
                btnExpenses.IsEnabled = true;
                btnQuery.IsEnabled = true;
                btnEmployment.IsEnabled = true;
            }
        }

        /// <summary>
        /// Opens the Query Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenQuery_Click(object sender, RoutedEventArgs e)
        {
            if (!queriesOpen) //Inventory view is NOT open
            {
                HomeScreen.Content = new Query(); //Show Page
                queriesOpen = true;

                btnInventory.IsEnabled = false;
                btnKitchen.IsEnabled = false;
                btnEvents.IsEnabled = false;
                btnExpenses.IsEnabled = false;
                btnReports.IsEnabled = false;
                btnEmployment.IsEnabled = false;
            }
            else
            {
                HomeScreen.Content = "";
                queriesOpen = false;

                btnInventory.IsEnabled = true;
                btnKitchen.IsEnabled = true;
                btnEvents.IsEnabled = true;
                btnExpenses.IsEnabled = true;
                btnReports.IsEnabled = true;
                btnEmployment.IsEnabled = true;
            }
        }

        /// <summary>
        /// Opens the Employment Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenEmployment_Click(object sender, RoutedEventArgs e)
        {
            if (!employmentOpen) //Inventory view is NOT open
            {
                HomeScreen.Content = new Employment(); //Show Page
                employmentOpen = true;

                btnInventory.IsEnabled = false;
                btnKitchen.IsEnabled = false;
                btnEvents.IsEnabled = false;
                btnExpenses.IsEnabled = false;
                btnReports.IsEnabled = false;
                btnQuery.IsEnabled = false;
            }
            else
            {
                HomeScreen.Content = "";
                employmentOpen = false;

                btnInventory.IsEnabled = true;
                btnKitchen.IsEnabled = true;
                btnEvents.IsEnabled = true;
                btnExpenses.IsEnabled = true;
                btnReports.IsEnabled = true;
                btnQuery.IsEnabled = true;
            }
        }
    }
}