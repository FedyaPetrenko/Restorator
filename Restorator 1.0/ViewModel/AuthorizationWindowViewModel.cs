using System.Windows.Input;
using Restorator_1._0.View;

namespace Restorator.ViewModel
{
    class AuthorizationWindowViewModel : ViewModelBase
    {
        public static bool Status;

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

        //private RegistrationWindow _registrationWindow;
        public ICommand OpenRegistrationWindowCommand { get; set; }
        public ICommand SignInCommand { get; set; }

        //public AuthorizationWindowViewModel()
        //{
        //    OpenRegistrationWindowCommand = new DelegateCommand(arg => OpenRegistrationWindow());
        //    SignInCommand = new DelegateCommand(arg => SignIn());
        //}

        //private void OpenRegistrationWindow()
        //{
        //    _registrationWindow = new RegistrationWindow()
        //    {
        //        DataContext = new RegistrationWindowViewModel()
        //    };
        //    _registrationWindow.Show();
        //}

        //private void SignIn()
        //{
        //    RestoratorEdm context = new RestoratorEdm();
        //    Status = context.
        //        //connection.Authorization(Login, Password);
        //    if (Status)
        //    {
        //        MessageBox.Show("Sign successful!");

        //        new StartWindow
        //        {
        //            DataContext = new StartWindowViewModel(),
        //            Visibility = Visibility.Visible,
        //            GoToStorageButton = { IsEnabled = true },
        //            GoToMenu = { IsEnabled = true }
        //        };
        //    }
        //    else
        //    {
        //        MessageBox.Show("Sign failed!");
        //    }
        //}

    }
}
