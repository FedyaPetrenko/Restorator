using System.Windows;
using Restorator_1._0.View;

namespace Restorator_1._0
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
            AuthorizationWindow authorization = new AuthorizationWindow();
            authorization.Show();
        }

        private void GoToStorageButton_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
            DepotWindow depot = new DepotWindow();
            depot.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
            MenuWindow menu = new MenuWindow();
            menu.Show();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            Application app = Application.Current;
            app.Shutdown();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.Show();
        }
    }
}
