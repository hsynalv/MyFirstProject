using Entity;
using Entity.FluentApi;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLayer.Concrete
{
    public class EFContext:DbContext
    {
        public EFContext():
            base("My_Project")
        {
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new ProductMap());
            modelBuilder.Configurations.Add(new CustomerMap());
        }

    }
}
