using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restorator_1._0.Model
{
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderId { get; set; }

        [Required]
        public Guid EmployeeId { get; set; }

        [Required]
        public Guid GuestId { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [ForeignKey("GuestId")]
        public Guest Guest { get; set; }

        private DateTime Date { get; set; }

        private IDictionary<Dish, byte> Dishes { get; set; }

        public Order()
        {
            Date = DateTime.Now;
            Dishes = new Dictionary<Dish, byte>();
        }
    }
}
