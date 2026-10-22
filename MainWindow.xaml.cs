using System.Configuration;
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

namespace Kino_Alikin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MainWindow init;
        public MainWindow()
        {
            InitializeComponent();
            init = this;
        }
        public void OpenPages(Page pages)
        {
            frame.Navigate(pages);
        }
        private void Clubs(object sender, RoutedEventArgs e) =>
            OpenPages(new Pages.Clubs.Main());
        private void User(object sender, RoutedEventArgs e) =>
            OpenPages(new Pages.Users.Main());
    }
}