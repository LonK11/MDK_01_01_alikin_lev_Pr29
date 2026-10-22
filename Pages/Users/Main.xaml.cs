using Kino_Alikin.Classes;
using System.Windows;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;

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
            ShowUsers(AllUsers.Users.ToList());
        }

        public void ShowUsers(List<Models.Users> Users)
        {
            Parent.Children.Clear();
            foreach (Models.Users User in Users)
                Parent.Children.Add(new Elements.Item(User, this));
        }
        private void SortUsers(object sender, SelectionChangedEventArgs e)
        {
            if (Parent == null || CmbSort == null) return;

            List<Models.Users> Sorted = CmbSort.SelectedIndex switch
            {
                1 => AllUsers.Users.OrderBy(U => U.FIO).ToList(),
                2 => AllUsers.Users.OrderBy(U => U.RentStart).ToList(),
                3 => AllUsers.Users.OrderBy(U => U.Duration).ToList(),
                _ => AllUsers.Users.ToList()
            };

            ShowUsers(Sorted);
        }

        private void AddUser(object sender, RoutedEventArgs e) =>
            MainWindow.init.OpenPages(new Pages.Users.Add(this));
    }
}
