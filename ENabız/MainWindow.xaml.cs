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
            LoginFormBox.Visibility = Visibility.Collapsed; // Giriş ekranını gizle
            MainFrame.Visibility = Visibility.Visible; // Sayfa göster
           
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LoginFormBox.Visibility = Visibility.Collapsed;
            MainFrame.Visibility = Visibility.Visible;
           

        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}