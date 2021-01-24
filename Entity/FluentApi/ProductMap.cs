using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.FluentApi
{
    public class ProductMap: EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            this.ToTable("Products");

            this.HasKey(I => I.ProductID);

            this.Property(I => I.ProductID).HasColumnName("ID").HasColumnOrder(0);
            this.Property(I => I.Name).HasColumnName("Name").HasColumnOrder(1).HasMaxLength(50);
            this.Property(I => I.ProductNumber).HasColumnName("ProductNumber").HasColumnOrder(2).HasMaxLength(20);
            this.Property(I => I.Color).HasColumnName("Color").HasColumnOrder(3).HasMaxLength(10);
        }
    }
}
