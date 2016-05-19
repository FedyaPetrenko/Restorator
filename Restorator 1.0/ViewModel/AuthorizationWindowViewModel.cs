using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;
using Restorator.Commands;
using Restorator.DataAcces;
using Restorator.Model;
using Restorator.Properties;
using Restorator.View;

namespace Restorator.ViewModel
{
    internal class AuthorizationWindowViewModel : ViewModelBase
    {
        private AuthorizationWindow _authorizationWindow;

        private string _login;
        private string _password;

        public string Login
        {
            get { return _login; }
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login));
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public ICommand OpenRegistrationWindowCommand { get; set; }
        public ICommand SignInCommand { get; set; }
        public ICommand SignOutCommand { get; set; }

        public AuthorizationWindowViewModel()
        {
            AuthorizationWindowInitializing();
            OpenRegistrationWindowCommand = new DelegateCommand(arg => OpenRegistrationWindow());
            SignInCommand = new DelegateCommand(arg => SignInClick());
            SignOutCommand = new DelegateCommand(arg => SignOut());
        }

        private void SignOut()
        {
            Settings.Default.Token = "";
            Settings.Default.Save();
            _authorizationWindow.Hide();
        }

        private void AuthorizationWindowInitializing()
        {
            var windows = Application.Current.Windows;
            foreach (var win in windows.OfType<AuthorizationWindow>())
            {
                _authorizationWindow = win;
                _authorizationWindow.Closed += (sender, e) =>
                {
                    _authorizationWindow.Close();
                };
            }
        }

        private void OpenRegistrationWindow()
        {
            var registrationWindow = new RegistrationWindow
            {
                DataContext = new RegistrationWindowViewModel()
            };
            registrationWindow.Show();
            _authorizationWindow.Close();
        }

        private void SignInClick()
        {
            ThreadStart threadStart = SaveTokenInSettings;
            _authorizationWindow.Dispatcher.BeginInvoke(DispatcherPriority.Normal, threadStart);
        }

        //private async void SaveTokenInSettings()
        //{
        //    using (var context = new RestoratorDb())
        //    {
        //        if (Login != null && Password != null)
        //        {
        //            var signEmployee = await context.Employees.FirstOrDefaultAsync(emp => emp.Login == Login);
        //            if (signEmployee.Token == GetMd5(Login + Password))
        //            {
        //                Settings.Default.Token = signEmployee.Token;
        //                Settings.Default.Save();
        //                _authorizationWindow.Hide();
        //                MessageBox.Show("Sign successful!");
        //            }
        //            else
        //                MessageBox.Show("Sign failed!");
        //        }
        //        else
        //            MessageBox.Show("Enter your login and password!");
        //    }
        //}

        private void SaveTokenInSettings()
        {
           
        }

        public static string GetMd5(string sourcePw)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(sourcePw);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            foreach (byte t in hash)
            {
                sb.Append(t.ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
