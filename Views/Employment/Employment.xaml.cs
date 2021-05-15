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

namespace AuntRosieUserInterface.Views.Employment
{
    /// <summary>
    /// Interaction logic for Employment.xaml
    /// </summary>
    public partial class Employment : Page
    {

        /// <summary>
        /// Member Variables
        /// </summary>
        private bool openAddEmployee;
        private bool openPayroll;
        private bool openManage;

        public Employment()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Opens the Add Employee Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (!openAddEmployee)
            {
                HomeScreen.Content = new AddEmployee();
                openAddEmployee = true;

                btnPayroll.IsEnabled = false;
                btnManage.IsEnabled = false;
            } else
            {
                HomeScreen.Content = "";
                openAddEmployee = false;

                btnPayroll.IsEnabled = true;
                btnManage.IsEnabled = true;
            }
        }

        /// <summary>
        /// Opens Payroll
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenPayroll_Click(object sender, RoutedEventArgs e)
        {
            if (!openPayroll)
            {
                HomeScreen.Content = new Payroll();
                openPayroll = true;

                btnAddEmployee.IsEnabled = false;
                btnManage.IsEnabled = false;
            } else
            {
                HomeScreen.Content = "";
                openPayroll = false;

                btnAddEmployee.IsEnabled = true;
                btnManage.IsEnabled = true;
            }
        }

        /// <summary>
        /// Opens Employee Manager
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenManageEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (!openManage)
            {
                HomeScreen.Content = new ManageEmployee();
                openManage = true;

                btnAddEmployee.IsEnabled = false;
                btnPayroll.IsEnabled = false;
            } else
            {
                HomeScreen.Content = "";
                openManage = false;


                btnAddEmployee.IsEnabled = true;
                btnPayroll.IsEnabled = true;
            }
        }
    }

    
}
