using Kino_Alikin.Classes;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Kino_Alikin.Pages.Users
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public UserContext AllUsers = new UserContext();

        public Main()
        {
            InitializeComponent();
            foreach (Models.Users User in AllUsers.Users)
                Parent.Children.Add(new Elements.Item(User, this));
        }

        private void AddUser(object sender, RoutedEventArgs e) =>
            MainWindow.init.OpenPages(new Pages.Users.Add(this));
    }
}
