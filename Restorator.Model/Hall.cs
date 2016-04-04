using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restorator.Model
{
    [Table("Halls")]
    public class Hall
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid HallId { get; set; }

        public ICollection<Order> Orders { get; set; } 

        public ICollection<Table> Tables { get; set; } 

        public Hall()
        {
            Orders = new List<Order>();
            Tables = new List<Table>();
        }
    }
}
