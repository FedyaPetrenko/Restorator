﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restorator.Model
{
    [Table("Orders")]
    public class Order
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid OrderId { get; set; }

        [Required]
        public Guid HallId { get; set; }

        [Required]
        public Guid EmployeeId { get; set; }

        [Required]
        public Guid GuestId { get; set; }

        [ForeignKey("HallId")]
        public Hall Hall { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; }

        [ForeignKey("GuestId")]
        public Guest Guest { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public IDictionary<Dish,byte> Dishes { get; set; }

        public Order()
        {
            Dishes = new Dictionary<Dish,byte>();
        }

        public Order(Guid hallId, Guid employeeId, Guid guestId, DateTime date )
        {
            HallId = hallId;
            EmployeeId = employeeId;
            GuestId = guestId;
            Date = DateTime.Now;
            Dishes = new Dictionary<Dish, byte>();
        }
    }
}
