using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restorator.Model
{
    [Table("Dishes")]
    public class Dish
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DishId { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        public string TypeOfMeals { get; set; }

        [Required]
        public int? Weight { get; set; }

        [Required]
        [MaxLength(100)]
        public string Composition { get; set; }

        public int Price { get; set; }

        private ICollection<Order> Orders { get; set; }

        private ICollection<Product> Products { get; set; }

        public Dish()
        {
            Orders = new List<Order>();
            Products = new List<Product>();
        }

        public Dish(string name, string typeOfMeals, int weight, string composition, int price)
        {
            Name = name;
            TypeOfMeals = typeOfMeals;
            Weight = weight;
            Composition = composition;
            Price = price;
            Orders = new List<Order>();
            Products = new List<Product>();
        }
    }
}
