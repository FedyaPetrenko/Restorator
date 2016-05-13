using System;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Restorator.Commands;
using Restorator.View;

namespace Restorator.ViewModel
{
    class AboutWindowViewModel : ViewModelBase
    {
        private AboutWindow _aboutWindow;

        public ICommand CloseAboutWindowCommand { get; set; }

        public AboutWindowViewModel()
        {
            AboutWindowOnLoaded();
            CloseAboutWindowCommand = new DelegateCommand(arg => CloseAboutWindow());
        }

        private void CloseAboutWindow()
        {
            _aboutWindow.Hide();
            WindowCollection windows = Application.Current.Windows;
            foreach (var startWindow in windows.OfType<StartWindow>())
            {
                startWindow.Show();
            }
        }

        private void AboutWindowOnLoaded()
        {
            WindowCollection windows = Application.Current.Windows;
            foreach (var win in windows.OfType<AboutWindow>())
            {
                _aboutWindow = win;
                _aboutWindow.Closed += AboutWindowOnClosed;
            }
        }

        private void AboutWindowOnClosed(object sender, EventArgs eventArgs)
        {
            CloseAboutWindow();
        }
    }
}
