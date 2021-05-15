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
using System.Windows.Shapes;
using MaterialDesignThemes;
using MaterialDesignColors;

namespace AuntRosieUserInterface
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();

            txtName.Focus();
        }

        //Incorrect login
        public bool isAdmin;
        public bool isEmployee;

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (txtName.Text == "admin")
            {
                isAdmin = true;
                Close();
            }
            else if (txtName.Text == "employee")
            {
                isEmployee = true;
                Close();
            }
            else
            {
                isAdmin = false;
                isEmployee = false;
                Close();
            }
        }

    }
}
