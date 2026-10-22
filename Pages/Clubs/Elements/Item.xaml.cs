using System.Windows.Controls;

namespace Kino_Alikin.Pages.Clubs.Elements
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        Main Main;
        Models.Clubs Club;

        public Item(Models.Clubs Club, Main Main)
        {
            InitializeComponent();

            this.Name.Text = Club.Name;
            this.Address.Text = Club.Address;
            this.WorkTime.Text = Club.WorkTime;
            this.Main = Main;
            this.Club = Club;
        }

        private void EditClub(object sender, System.Windows.RoutedEventArgs e) =>
            MainWindow.init.OpenPages(new Pages.Clubs.Add(this.Main, this.Club));

        private void DeleteClub(object sender, System.Windows.RoutedEventArgs e)
        {
            Main.AllClub.Clubs.Remove(Club);
            Main.AllClub.SaveChanges();
            Main.Parent.Children.Remove(this);
        }
    }
}
