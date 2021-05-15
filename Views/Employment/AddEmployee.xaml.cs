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
    /// Interaction logic for AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Page
    {
        public AddEmployee()
        {
            InitializeComponent();

            lblEmploymentDate.Visibility = Visibility.Hidden;
            lblEmployeeSalary.Visibility = Visibility.Hidden;
            txtEmployeeDate.Visibility = Visibility.Hidden;
            txtSalary.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Controls if user selects part-time, does not show imput for salary 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbProducts.SelectedIndex == 0) //Full-Time
            {
                lblEmploymentDate.Visibility = Visibility.Visible;
                lblEmployeeSalary.Visibility = Visibility.Visible;
                txtEmployeeDate.Visibility = Visibility.Visible;
                txtSalary.Visibility = Visibility.Visible;

            } else if (cmbProducts.SelectedIndex == 1) //Part-Time
            {
                lblEmploymentDate.Visibility = Visibility.Hidden;
                lblEmployeeSalary.Visibility = Visibility.Hidden;
                txtEmployeeDate.Visibility = Visibility.Hidden;
                txtSalary.Visibility = Visibility.Hidden;
            }
        }

        private void AddEmployee_Click(object sender, RoutedEventArgs e)
        {
            ///
        }
    }
}
