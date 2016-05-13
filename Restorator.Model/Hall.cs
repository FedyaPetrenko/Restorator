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

        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();

        public virtual ICollection<Table> Tables { get; set; } = new List<Table>();

        public Hall()
        {
        }
    }
}
