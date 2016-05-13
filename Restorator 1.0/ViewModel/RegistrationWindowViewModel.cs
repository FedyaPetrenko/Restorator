using System.Linq;
using System.Windows;
using System.Windows.Input;
using Restorator.Commands;
using Restorator.DataAcces;
using Restorator.Model;
using Restorator.View;

namespace Restorator.ViewModel
{
    class RegistrationWindowViewModel : ViewModelBase
    {
        private RegistrationWindow _registrationWindow;
        
        private string _firstName;
        private string _secondName;
        private string _thirdName;
        private string _phoneNumber;
        private string _email;
        private string _homeAddress;
        private long? _identificationCode;
        private string _cardNumber;
        private int? _salary;
        private string _login;
        private string _password;

        public Employee Employee { get; set; }

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string SecondName
        {
            get { return _secondName; }
            set
            {
                _secondName = value;
                OnPropertyChanged(nameof(SecondName));
            }
        }

        public string ThirdName
        {
            get { return _thirdName; }
            set
            {
                _thirdName = value;
                OnPropertyChanged(nameof(ThirdName));
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public string HomeAddress
        {
            get { return _homeAddress; }
            set
            {
                _homeAddress = value;
                OnPropertyChanged(nameof(HomeAddress));
            }
        }

        public long? IdentificationCode
        {
            get { return _identificationCode; }
            set
            {
                _identificationCode = value;
                OnPropertyChanged(nameof(IdentificationCode));
            }
        }

        public string CardNumber
        {
            get { return _cardNumber; }
            set
            {
                _cardNumber = value;
                OnPropertyChanged(nameof(CardNumber));
            }
        }

        public int? Salary
        {
            get { return _salary; }
            set
            {
                _salary = value;
                OnPropertyChanged(nameof(Salary));
            }
        }

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

        public RegistrationWindowViewModel()
        {
            RegistrationWindowInitializing();
            SaveEmployeeCommand = new DelegateCommand(arg => SaveEmployee());
            ClearTextCommand = new DelegateCommand(arg => ClearText());
        }

        public ICommand SaveEmployeeCommand { get; set; }
        public ICommand ClearTextCommand { get; set; }

        private void RegistrationWindowInitializing()
        {
            var windows = Application.Current.Windows;
            foreach (var win in windows.OfType<RegistrationWindow>())
            {
                _registrationWindow = win;
                _registrationWindow.Closed += (sender, e) => { _registrationWindow.Close(); };
            }
        }

        private async void SaveEmployee()
        {
            if (CheckFieldsForNull())
            {
                Employee = new Employee(FirstName, SecondName, ThirdName, PhoneNumber, Email, HomeAddress,
                    IdentificationCode, Salary, CardNumber, Login, Password,
                    AuthorizationWindowViewModel.GetMd5(Login + Password));
                using (RestoratorDb context = new RestoratorDb())
                {
                    context.Employees.Add(Employee);
                    await context.SaveChangesAsync();
                }
                MessageBox.Show("Reristration successful!");
                _registrationWindow.Hide();
            }
            else
                MessageBox.Show("Enter information in all fields!");
        }

        private bool CheckFieldsForNull()
        {
            return FirstName != null && SecondName != null && ThirdName != null && PhoneNumber != null && Email != null &&
                   HomeAddress != null && IdentificationCode != null && Salary != null && CardNumber != null && Login != null && Password != null;
        }

        private void ClearText()
        {
            FirstName = null;
            SecondName = null;
            ThirdName = null;
            PhoneNumber = null;
            Email = null;
            HomeAddress = null;
            IdentificationCode = null;
            Salary = null;
            CardNumber = null;
            Login = null;
            Password = null;
        }

    }
}
