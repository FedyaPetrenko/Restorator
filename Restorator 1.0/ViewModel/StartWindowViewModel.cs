﻿using System.Windows;
using System.Windows.Input;
using Restorator.Commands;
using Restorator.View;

namespace Restorator.ViewModel
{
    class StartWindowViewModel : ViewModelBase
    {
        private static DepotWindow _depotWindow;
        private static AuthorizationWindow _authorizationWindow;
        private static MenuWindow _menuWindow;
       
        public ICommand OpenDepotWindowCommand { get; set; }
        public ICommand OpenAuthorizationWindowCommand { get; set; }
        public ICommand OpenMenuWindowCommand { get; set; }
        public ICommand OpenAboutWindowCommand { get; set; }

        public StartWindowViewModel()
        {
            OpenDepotWindowCommand = new DelegateCommand(arg => OpenDepotWindow());
            OpenAuthorizationWindowCommand = new DelegateCommand(arg => OpenAuthorizationWindow());
            OpenMenuWindowCommand = new DelegateCommand(arg => OpenMenuWindow());
            OpenAboutWindowCommand = new DelegateCommand(arg => OpenAboutWindow());
        }

        private void OpenAboutWindow()
        {
            AboutWindow aboutWindow = new AboutWindow()
            {
                DataContext = new AboutWindowViewModel()
            };
           aboutWindow.Show();
           Application.Current.MainWindow.Hide();
        }

        private void OpenDepotWindow()
        {
            _depotWindow = new DepotWindow()
            {
                DataContext = new DepotWindowViewModel()
            };
            _depotWindow.Show();
           Application.Current.MainWindow.Hide();
            
        }

        private void OpenAuthorizationWindow()
        {
            _authorizationWindow = new AuthorizationWindow
            {
                DataContext = new AuthorizationWindowViewModel()
            };
            _authorizationWindow.Show();
        }

        private void OpenMenuWindow()
        {
            _menuWindow = new MenuWindow()
            {
                DataContext = new MenuWindowViewModel()
            };
            _menuWindow.Show();
        }
    }
}
