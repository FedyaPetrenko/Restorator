using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restorator_1._0.Model
{
    public class Product
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }

        public string Name { get; set; }
        public string BarCode { get; set; }

        public string Description { get; set; }

        public int? Price { get; set; }

        public Product()
        {
        }

        //public Product(int idDish, string barcode, string name, string description, int price)
        //{
        //    Id_Dish = idDish;
        //    BarCode = barcode;
        //    Name = name;
        //    Description = description;
        //    Price = price;
        //}

        //    public Product(int? idProduct, int? idDish, string barcode, string name, string description, int? price)
        //    {
        //        IdProduct = idProduct;
        //        Id_Dish = idDish;
        //        BarCode = barcode;
        //        Name = name;
        //        Description = description;
        //        Price = price;
        //    }

        //    public Product(int idProduct, string barcode, string name, string description, int price)
        //    {
        //        IdProduct = idProduct;
        //        Id_Dish = Id_Dish;
        //        BarCode = barcode;
        //        Name = name;
        //        Description = description;
        //        Price = price;
        //    }

        //    public Product(int? idDish, string barCode, string name, string description, int? price)
        //    {
        //        this.IdDish = idDish;
        //        BarCode = barCode;
        //        Name = name;
        //        Description = description;
        //        Price = price;
        //    }
        //}
    }
}