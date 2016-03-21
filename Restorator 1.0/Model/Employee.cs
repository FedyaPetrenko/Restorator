using System.ComponentModel.DataAnnotations;

namespace Restorator_1._0.Model
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string SecondName { get; set; }

        public string ThirdName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string HomeAddress { get; set; }

        public string IdentificationCode { get; set; }

        public string CardNumber { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public int? Salary { get; set; }

        public Employee(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public Employee(string firstName, string secondName, string thirdName, string phoneNumber, string email, 
            string placeOfResidence, string identificationCode, int? salary, string cardNumber,  string login, string password)
        {
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            PhoneNumber = phoneNumber;
            Email = email;
            HomeAddress = placeOfResidence;
            IdentificationCode = identificationCode;
            CardNumber = cardNumber;
            Salary = salary;
            Login = login;
            Password = password;
        }
    }
}
