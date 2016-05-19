using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Restorator.Commands;
using Restorator.Properties;
using Restorator.View;

namespace Restorator.ViewModel
{
    internal class StartWindowViewModel : ViewModelBase
    {
        private StartWindow _startWindow;
        
        public ICommand OpenDepotWindowCommand { get; set; }
        public ICommand OpenAuthorizationWindowCommand { get; set; }
        public ICommand OpenMenuWindowCommand { get; set; }
        public ICommand OpenAboutWindowCommand { get; set; }

        public StartWindowViewModel()
        {
            StartWindowInitializing();
            OpenDepotWindowCommand = new DelegateCommand(arg => OpenDepotWindow());
            OpenAuthorizationWindowCommand = new DelegateCommand(arg => OpenAuthorizationWindow());
            OpenMenuWindowCommand = new DelegateCommand(arg => OpenMenuWindow());
            OpenAboutWindowCommand = new DelegateCommand(arg => OpenAboutWindow());
        }

        private void StartWindowInitializing()
        {
            var windows = Application.Current.Windows;
            foreach (var win in windows.OfType<StartWindow>())
            {
                _startWindow = win;
                _startWindow.Activated += StartWindowOnActivated;
                _startWindow.Closing += (sender, e) => 
                {
                    Settings.Default.Token = "";
                    Settings.Default.Save();
                    Application.Current.Shutdown();
                };
            }
        }

        private void StartWindowOnActivated(object sender, EventArgs e)
        {
            //if (Settings.Default.Token == "")
            //{
            //    _startWindow.MenuButton.IsEnabled = false;
            //    _startWindow.StorageButton.IsEnabled = false;
            //}
            //else
            //{
            //    _startWindow.MenuButton.IsEnabled = true;
            //    _startWindow.StorageButton.IsEnabled = true;
            //}
        }

        private void OpenAboutWindow()
        {
            var aboutWindow = new AboutWindow
            {
                DataContext = new AboutWindowViewModel()
            };
            aboutWindow.Show();
            Application.Current.MainWindow.Hide();
        }

        private void OpenDepotWindow()
        {
            var depotWindow = new DepotWindow
            {
                DataContext = new DepotWindowViewModel()
            };
            depotWindow.Show();
            Application.Current.MainWindow.Hide();
        }

        private void OpenAuthorizationWindow()
        {
            var authorizationWindow = new AuthorizationWindow
            {
                DataContext = new AuthorizationWindowViewModel()
            };
            authorizationWindow.Show();
        }

        private void OpenMenuWindow()
        {
            var menuWindow = new MenuWindow
            {
                DataContext = new MenuWindowViewModel()
            };
            menuWindow.Show();
        }
    }
}
