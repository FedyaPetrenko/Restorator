using System.Data.Entity;
using System.Windows;
using System.Windows.Input;
using Restorator.Commands;
using Restorator.DataAcces;
using Restorator.Model;

namespace Restorator.ViewModel
{
    class RegistrationWindowViewModel : ViewModelBase
    {
        public Employee Employee { get; set; }

        private string _cardNumber;
        private string _login;
        private string _password;

        private string _firstName;
        private string _secondName;
        private string _thirdName;

        private string _phoneNumber;
        private string _email;
        private string _placeOfResidence;
        private string _identificationCode;
        private int? _salary;

        public string CardNumber
        {
            get { return _cardNumber; }
            set
            {
                _cardNumber = value;
                OnPropertyChanged(nameof(CardNumber));
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
            get { return _placeOfResidence; }
            set
            {
                _placeOfResidence = value;
                OnPropertyChanged(nameof(HomeAddress));
            }
        }

        public string IdentificationCode
        {
            get { return _identificationCode; }
            set
            {
                _identificationCode = value;
                OnPropertyChanged(nameof(IdentificationCode));
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


        public RegistrationWindowViewModel()
        {
            SaveEmployeeCommand = new DelegateCommand(arg => SaveEmployee());
            ClearTextCommand = new DelegateCommand(arg => ClearText());
        }

        public ICommand SaveEmployeeCommand { get; set; }
        public ICommand ClearTextCommand { get; set; }

        private void SaveEmployee()
        {
            RestoratorEdm context = new RestoratorEdm();
            context.Employees.Add(new Employee(FirstName, SecondName, ThirdName, PhoneNumber, Email, HomeAddress,
                IdentificationCode, Salary, CardNumber, Login, Password));
           context.SaveChangesAsync();
           MessageBox.Show("Reristration successful!");

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
            Salary = 0;
            CardNumber = null;
            Login = null;
            Password = null;
        }

    }
}
