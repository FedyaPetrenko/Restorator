using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            WindowCollection windowCollection = Application.Current.Windows;
            foreach (var window in windowCollection)
            {
                var checkedAboutWindow = window as AboutWindow;
                var checkedStartWindow = window as StartWindow;

                checkedAboutWindow?.Hide();
                checkedStartWindow?.Show();
            }
            
        }

        private void AboutWindowOnLoaded()
        {
            WindowCollection windows = Application.Current.Windows;
            foreach (var win in windows.OfType<AboutWindow>())
            {
                _aboutWindow = win;
                _aboutWindow.Closed += DepotOnClosed;
            }

        }

        private void DepotOnClosed(object sender, EventArgs eventArgs)
        {
            _aboutWindow.Hide();
            WindowCollection windows = Application.Current.Windows;
            foreach (var startWindow in windows.OfType<StartWindow>())
            {
                startWindow.Show();
            }
        }
    }
}
