using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restorator_1._0.Model
{
    public class Guest
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid GuestId { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string SecondName { get; set; }

        [MaxLength(30)]
        public string ThirdName { get; set; }

        [Required]
        [RegularExpression("([0-9][0-9][0-9])-[0-9][0-9][0-9]-[0-9][0-9]-[0-9][0-9]")]
        public string PhoneNumber { get; set; }

        [RegularExpression(@"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$")]
        public string Email { get; set; }

        public int? PercentageDiscounts { get; set; }

        [Required]
        [MaxLength(10)]
        public long CardNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string Password { get; set; }

        private ICollection<Order> Orders { get; set; }

        public Guest()
        {
            Orders = new List<Order>();
        }

        public Guest(long cardNumber, string password)
        {
            CardNumber = cardNumber;
            Password = password;
            Orders = new List<Order>();
        }

        public Guest(string firstName, string secondName, string thirdName, string phoneNumber, string email,
            long cardNumber, string password)
        {
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            PhoneNumber = phoneNumber;
            Email = email;
            CardNumber = cardNumber;
            Password = password;
            Orders = new List<Order>();
        }
    }
}
