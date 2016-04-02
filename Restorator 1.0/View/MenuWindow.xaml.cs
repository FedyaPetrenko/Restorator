using System.Windows;

namespace Restorator.View
{
    /// <summary>
    /// Логика взаимодействия для WelcomeWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            StartWindow startWindow = new StartWindow();
            startWindow.Visibility = Visibility.Visible;
        }
    }
}
