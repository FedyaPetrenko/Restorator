using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restorator.Model
{
    [Table("Guests")]
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
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public int? PercentageDiscounts { get; set; }

        [Required]
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

        public Guest(string firstName, string secondName, string thirdName, string phoneNumber, string email, int? percentageDiscount,
            long cardNumber, string password)
        {
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            PhoneNumber = phoneNumber;
            Email = email;
            PercentageDiscounts = percentageDiscount;
            CardNumber = cardNumber;
            Password = password;
            Orders = new List<Order>();
        }
    }
}
