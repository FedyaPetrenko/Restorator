using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restorator.Model
{
    [Table("Products")]
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [Required]
        public int? Price { get; set; }

        [Required]
        public int? Count { get; set; }

        public virtual ICollection<Dish> Dishes { get; set; } = new List<Dish>();

        public Product()
        {
        }

        public Product(string name, string description, int? price, int? count)
        {
            Name = name;
            Description = description;
            Price = price;
            Count = count;
        }
    }
}