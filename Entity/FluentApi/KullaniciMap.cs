using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.FluentApi
{
    public class KullaniciMap : EntityTypeConfiguration<Kullanici>
    {

        public KullaniciMap()
        {
            this.ToTable("Kullanici");

            this.HasKey(I => I.ID);

            this.Property(I => I.ID).HasColumnName("ID").HasColumnOrder(0);
            this.Property(I => I.KullaniciAdi).HasColumnName("KullaniciAdi").HasColumnOrder(1).HasMaxLength(50);
            this.Property(I => I.Sifre).HasColumnName("Sifre").HasColumnOrder(2).HasMaxLength(50);
            this.Property(I => I.AdSoyad).HasColumnName("AdSoyad").HasColumnOrder(3).HasMaxLength(75);
        }
    }
}
