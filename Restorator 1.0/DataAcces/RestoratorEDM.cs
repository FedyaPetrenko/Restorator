using System.Data.Entity;
using Restorator.Model;

namespace Restorator.DataAcces
{
    public class RestoratorEdm : DbContext
    {
        public RestoratorEdm()
            : base("name=RestoratorEdm")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<RestoratorEdm>());
        }

        public  DbSet<Employee> Employees { get; set; }
        public  DbSet<Guest> Guests { get; set; } 
        public  DbSet<Order> Orders { get; set; }
        public  DbSet<Dish> Dishes { get; set; }
        public  DbSet<Product> Products { get; set; }  
        public  DbSet<Hall> Halls { get; set; }
        public  DbSet<Table> Tables { get; set; }  
    }
}