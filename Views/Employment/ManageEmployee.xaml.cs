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
    /// Interaction logic for ManageEmployee.xaml
    /// </summary>
    public partial class ManageEmployee : Page
    {
        public ManageEmployee()
        {
            InitializeComponent();

            //Default Salary input is hidden
            lblEmployeeSalary.Visibility = Visibility.Hidden;
            txtSalary.Visibility = Visibility.Hidden;


            //Temporary Output, just for demonstration
            lstEmployeeList.Items.Add("Jackson Thomas");
            lstEmployeeList.Items.Add("Richmond Hill");
            lstEmployeeList.Items.Add("Glen Coco");
        }

        /// <summary>
        /// Controls if user selects part-time, does not show imput for salary 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbType.SelectedIndex == 0) //Full-Time
            {
                lblEmployeeSalary.Visibility = Visibility.Visible;
                txtSalary.Visibility = Visibility.Visible;

            }
            else if (cmbType.SelectedIndex == 1) //Part-Time
            {
                lblEmployeeSalary.Visibility = Visibility.Hidden;
                txtSalary.Visibility = Visibility.Hidden;
            }
        }

        /// <summary>
        /// Outputs the selected employee in the fields below 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstEmployeeList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            //Retrieves information from the database

            //Temporary Output
            if(lstEmployeeList.SelectedIndex == 0)
            {
                txtEmployeeName.Text = "Jackson Thomas";
                cmbType.SelectedIndex = 0;
                txtEmployeeRole.Text = "Cashier";
                txtEmployeeAddress.Text = "45 Clementine Square, M1H3J2";
                txtSalary.Text = "$50/Hr";
            } else
            {
                //
            }
            
        }

        private void SubmitChange_Click(object sender, RoutedEventArgs e)
        {
            ///
        }
    }
}
