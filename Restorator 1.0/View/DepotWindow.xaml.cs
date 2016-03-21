using System.Windows;

namespace Restorator_1._0.View
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class DepotWindow : Window
    {
        public DepotWindow()
        {
            InitializeComponent();
        }

        private void Window_Closed(object sender, System.EventArgs e)
        {
            Visibility = Visibility.Hidden;
            StartWindow startWindow = new StartWindow {Visibility = Visibility.Visible};
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Visibility = Visibility.Hidden;
            AddProductWindow addProductWindow = new AddProductWindow();
            addProductWindow.Show();
        }
    }
}
