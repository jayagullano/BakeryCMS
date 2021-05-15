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
    /// Interaction logic for AddProduction.xaml
    /// </summary>
    public partial class AddProduction : Page
    {
        public AddProduction()
        {
            InitializeComponent();

            //Load the Product Box
            loadProductBox();
        }

        /// <summary>
        /// Used to generate products from products database
        /// </summary>
        private void loadProductBox()
        {
            cmbProducts.Items.Insert(0, "Steak and Kidney");
            cmbProducts.Items.Insert(1, "Pickles");
            cmbProducts.Items.Insert(2, "Horse Radish");
        }

        private void CreateProduction_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
