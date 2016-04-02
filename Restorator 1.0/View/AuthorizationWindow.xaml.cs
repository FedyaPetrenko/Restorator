using System;
using System.Windows;

namespace Restorator.View
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //    StartWindow startWindow = new StartWindow
            //    {
            //        GoToAuthorization = {IsEnabled = true},
            //        GoToStorageButton = {IsEnabled = true}
            //    };
            Visibility = Visibility.Hidden;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            new StartWindow {Visibility = Visibility.Visible};
        }
    }
}
