using System.Text;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // RegisterPage zaten Window olduğu için direkt açabiliriz
            var registerPageWindow = new RegisterPage();
            registerPageWindow.Show(); // ya da ShowDialog() modally açmak istersen
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // LoginPage zaten Window olduğu için direkt açabiliriz
            var loginPageWindow = new LoginPage();
            loginPageWindow.Show(); // ya da ShowDialog() modally açmak istersen
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
           
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
           
        }


        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}