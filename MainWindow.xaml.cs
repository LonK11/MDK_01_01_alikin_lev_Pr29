using System.Windows;
using System.Windows.Controls;

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
        private void Users(object sender, RoutedEventArgs e) =>
            OpenPages(new Pages.Users.Main());
    }
}