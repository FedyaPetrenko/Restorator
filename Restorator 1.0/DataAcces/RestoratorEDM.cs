using System.Data.Entity;
using Restorator.Model;
using Restorator_1._0.Model;

namespace Restorator_1._0.DataAcces
{
    public class RestoratorEdm : DbContext
    {
        public RestoratorEdm()
            : base("name=RestoratorEdm")
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Guest> Guests { get; set; } 
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<Product> Products { get; set; }  
        public virtual DbSet<Hall> Halls { get; set; }
        public virtual DbSet<Table> Tables { get; set; }  
    }
}