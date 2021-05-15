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
    /// Interaction logic for Event.xaml
    /// </summary>
    public partial class Event : Page
    {
        public Event()
        {
            InitializeComponent();

            //Display Events on Startup
            HomeScreen.Content = new ShowEvents();
        }

        //Member Variables
        private bool openCreateEvent;
        private bool openSales;

        private void OpenSales_Click(object sender, RoutedEventArgs e)
        {
            if (!openSales)
            {
                btnSales.Background = new SolidColorBrush(Colors.Red);

                HomeScreen.Content = new Sales();
                openSales = true;

                btnCreateEvent.IsEnabled = false;
            } else
            {
                btnSales.Background = new SolidColorBrush(Colors.White);
                HomeScreen.Content = new ShowEvents();

                openSales = false;
                btnCreateEvent.IsEnabled = true;
            }
        }

        /// <summary>
        /// Opens the create event page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenCreateEvent_Click(object sender, RoutedEventArgs e)
        {
            if (!openCreateEvent)
            {
                btnCreateEvent.Background = new SolidColorBrush(Colors.Red);
                //Opens the Create Event page
                HomeScreen.Content = new CreateEvent();

                openCreateEvent = true;

                btnSales.IsEnabled = false;
            }
            else
            {
                btnCreateEvent.Background = new SolidColorBrush(Colors.White);
                HomeScreen.Content = new ShowEvents();
                openCreateEvent = false;
                btnSales.IsEnabled = true;
            }
        }
    }
}
