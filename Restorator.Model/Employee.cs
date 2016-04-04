using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restorator.Model
{
    [Table("Employees")]
    public class Employee
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid EmployeeId { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string SecondName { get; set; }

        [Required]
        [MaxLength(30)]
        public string ThirdName { get; set; }

        [Required]
        //[RegularExpression("([0-9][0-9][0-9])-[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]")]
        public string PhoneNumber { get; set; }

        //[RegularExpression(@"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$")]
        public string Email { get; set; }

        [Required]
        [MaxLength(150)]
        public string HomeAddress { get; set; }

        [Required]
        public long IdentificationCode { get; set; }

       
        //public string CardNumber { get; set; }

        [Required]
        public int Salary { get; set; }

        [Required]
        [MaxLength(30)]
        public string Login { get; set; }

        [Required]
        [MaxLength(30)]
        public string Password { get;set; }

        //private ICollection<Order> Orders { get; set; }

        public Employee()
        {
            //Orders = new List<Order>();
        }

        public Employee(string login, string password)
        {
            Login = login;
            Password = password;
            //Orders = new List<Order>();
        }

        public Employee(string firstName, string secondName, string thirdName, string phoneNumber, string email,
            string homeAddress, long identificationCode, int salary,/* string cardNumber,*/ string login,
            string password)
        {
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            PhoneNumber = phoneNumber;
            Email = email;
            HomeAddress = homeAddress;
            IdentificationCode = identificationCode;
            //CardNumber = cardNumber;
            Salary = salary;
            Login = login;
            Password = password;
            //Orders = new List<Order>();
        }
    }
}
