using Kino_Alikin.Classes;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;

namespace Kino_Alikin.Pages.Clubs
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public ClubsContext AllClub = new ClubsContext();

        public Main()
        {
            InitializeComponent();
            ShowClubs(AllClub.Clubs.ToList());
        }

        public void ShowClubs(List<Models.Clubs> Clubs)
        {
            Parent.Children.Clear();
            foreach (Models.Clubs Club in Clubs)
                Parent.Children.Add(new Elements.Item(Club, this));
        }
        private void SortClubs(object sender, SelectionChangedEventArgs e)
        {
            if (Parent == null || CmbSort == null) return;

            List<Models.Clubs> Sorted = CmbSort.SelectedIndex switch
            {
                1 => AllClub.Clubs.OrderBy(C => C.Name).ToList(),
                2 => AllClub.Clubs.OrderBy(C => C.Address).ToList(),
                3 => AllClub.Clubs.OrderBy(C => C.WorkTime).ToList(),
                _ => AllClub.Clubs.ToList()
            };

            ShowClubs(Sorted);
        }

        private void AddClub(object sender, System.Windows.RoutedEventArgs e) =>
            MainWindow.init.OpenPages(new Pages.Clubs.Add(this));
    }
}
