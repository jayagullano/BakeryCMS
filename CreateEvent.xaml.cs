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
    /// Interaction logic for CreateEvent.xaml
    /// </summary>
    public partial class CreateEvent : Page
    {
        public CreateEvent()
        {
            InitializeComponent();

            //Disable Create Screens
            sp_CreateLocation.Visibility = Visibility.Hidden;
            sp_CreateHelper.Visibility = Visibility.Hidden;

            //Temporary Output
            cmbLocations.Items.Add("North Bay Market");
            cmbLocations.Items.Add("HillCrest Farm");
            cmbLocations.Items.Add("South SIde Farm");

            cmbHelpers.Items.Add("Christy Margaret");
            cmbHelpers.Items.Add("John Alimony");
        }

        /// <summary>
        /// Submits new location to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitNewLocation_Click(object sender, RoutedEventArgs e)
        {
            //
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewLocation_Click(object sender, RoutedEventArgs e)
        {
            //Shows the creation screen.
            sp_CreateLocation.Visibility = Visibility.Visible;

            btnNewLocation.IsEnabled = false;
        }

        /// <summary>
        /// Creates new location and adds it to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateNewLocation_Click(object sender, RoutedEventArgs e)
        {

            //Temporary Output
            cmbLocations.Items.Add(txtLocationName.Text);

            //Reset values
            btnNewLocation.IsEnabled = true;
            txtLocationName.Text = "";
            txtProvince.Text = "";
            txtCity.Text = "";
            txtStreet.Text = "";


            //Hides the creation screen
            sp_CreateLocation.Visibility = Visibility.Hidden;
        }


        /// <summary>
        /// Adds information to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateEvent_Click(object sender, RoutedEventArgs e)
        {
            //
        }

        /// <summary>
        /// Opens the new helper creation screen.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenNewHelper_Click(object sender, RoutedEventArgs e)
        {
            sp_CreateHelper.Visibility = Visibility.Visible;
            btnNewHelper.IsEnabled = false;
        }

        /// <summary>
        /// Creates a new helper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitNewHelper_Click(object sender, RoutedEventArgs e)
        {
            lstHelpersList.Items.Add(cmbHelpers.SelectedItem.ToString() + " | " + txtRole.Text);
        }

        /// <summary>
        /// Creates a new helper using the screen prompt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateNewHelper_Click(object sender, RoutedEventArgs e)
        {
            cmbHelpers.Items.Add(txtHelperName.Text);

            btnNewHelper.IsEnabled = true;

            sp_CreateHelper.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Closes the creation window and resets the values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseLocationCreate_Click(object sender, RoutedEventArgs e)
        {
            sp_CreateLocation.Visibility = Visibility.Hidden;

            btnNewLocation.IsEnabled = true;
            txtLocationName.Text = "Location Name";
            txtProvince.Text = "Province";
            txtCity.Text = "City";
            txtStreet.Text = "Street Name";
        }

        /// <summary>
        /// Closes the creation window for helper and resets the values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseHelperCreate_Click(object sender, RoutedEventArgs e)
        {
            btnNewHelper.IsEnabled = true;
            sp_CreateHelper.Visibility = Visibility.Hidden;

            //Reset values
            txtHelperName.Text = "Helper Name";
            txtHelperPhone.Text = "Phone Number";
            txtHelperAddress.Text = "Address";
        }

        /// <summary>
        /// Removes a selected helper
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveHelper_Click(object sender, RoutedEventArgs e)
        {
            if(lstHelpersList.SelectedIndex >= 0)
            {
                lstHelpersList.Items.RemoveAt(lstHelpersList.SelectedIndex);
            }
            
        }
    }
}
