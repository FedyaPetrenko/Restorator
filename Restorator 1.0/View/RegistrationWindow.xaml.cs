using System;
using System.Windows;

namespace Restorator.View
{
    /// <summary>
    /// Логика взаимодействия для RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            StartWindow startWindow = new StartWindow();
            startWindow.Visibility = Visibility.Visible;
        }
    }
}
