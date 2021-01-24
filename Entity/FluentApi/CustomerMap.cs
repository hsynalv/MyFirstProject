using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.FluentApi
{
    public class CustomerMap: EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            this.ToTable("Customers");

            this.HasKey(I => I.CustomerID);

            this.Property(I => I.CustomerID).HasColumnName("ID").HasColumnOrder(0);
            this.Property(I => I.CustomerCode).HasColumnName("CustomerCode").HasColumnOrder(1).HasMaxLength(20);
            this.Property(I => I.FirstName).HasColumnName("FirstName").HasColumnOrder(2).HasMaxLength(50);
            this.Property(I => I.LastName).HasColumnName("LastName").HasColumnOrder(3).HasMaxLength(50);
            this.Property(I => I.Telefon).HasColumnName("Telefon NO").HasColumnOrder(4).HasMaxLength(12);
            this.Property(I => I.Email).HasColumnName("EmailAdres").HasColumnOrder(5).HasMaxLength(50);
        }

    }
}
