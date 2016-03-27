using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Restorator_1._0.Model;

namespace Restorator.Model
{
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

        public ICollection<Dish> Dishes { get; set; }

        public Product()
        {
            Dishes = new List<Dish>();
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