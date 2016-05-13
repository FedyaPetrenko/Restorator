using System.Data.Entity;
using Restorator.Model;

namespace Restorator.DataAcces
{
    public class RestoratorDb : DbContext
    {
        public RestoratorDb()
            : base("RestoratorDb")
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