namespace Restorator_1._0.Model
{
    internal class Guest
    {
        private long _cardNumber;
        private string _password;

        private string _firstName;
        private string _secondName;
        private string _thirdName;

        private string _phoneNumber;
        private string _email;


        public long CardNumber
        {
            get { return _cardNumber; }
            set { _cardNumber = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string SecondName
        {
            get { return _secondName; }
            set { _secondName = value; }
        }

        public string ThirdName
        {
            get { return _thirdName; }
            set { _thirdName = value; }
        }

        public string PhoneNumber
        {
            get {return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public Guest()
        {
        }

        public Guest(long cardNumber, string password)
        {
            CardNumber = cardNumber;
            Password = password;
        }

        public Guest(string firstName, string secondName, string thirdName, string phoneNumber, string email,long cardNumber, string password)
        {
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            PhoneNumber = phoneNumber;
            Email = email;
            CardNumber = cardNumber;
            Password = password;
        }
    }
}
