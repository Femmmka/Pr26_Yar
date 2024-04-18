using Pr26_Yar.Classes;
using System.Windows.Controls;


namespace Pr26_Yar.Pages.Clubs
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
            foreach (Models.Clubs Club in AllClub.Clubs)
                Parent.Children.Add(new Elements.Item(Club, this));
        }
        private void AddClub(object sender, System.Windows.RoutedEventArgs e) =>
            MainWindow.init.OpenPages(new Pages.Clubs.Add(this));
        
    }
}
