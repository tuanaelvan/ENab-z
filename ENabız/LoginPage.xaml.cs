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
using ENabız;

namespace ENabız
{
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
       
        private void OpenRadiologyPage(object sender, MouseButtonEventArgs e)
        {
            var window = new RadiologyPage(); // RadiologyPage bir Window
            window.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Örnek event
        }
    }
}

