using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLayer.Concrete
{
    public class DLLProductOperation
    {
        RepositoryBase<Product, EFContext> Repo;
        Product bulunan;

        public DLLProductOperation()
        {
            Repo = new RepositoryBase<Product, EFContext>();
        }

        public int UrunEkle(Product product)
        {
            Repo.CUDOperation(product, System.Data.Entity.EntityState.Added);
            return Repo.SaveChange();
        }

        public List<Product> UrunListe()
        {
            return Repo.GetAll().ToList();
        }

        public Product guncellenecekVEsilinecek(int id)
        {
            bulunan = Repo.Find(id);
            return bulunan;
        }

        public int UrunGuncelle(int id,Product product)
        {
            guncellenecekVEsilinecek(id);
            bulunan.Name = product.Name;
            bulunan.ListPrice = product.ListPrice;
            bulunan.Color = product.Color;
            bulunan.ProductNumber = product.ProductNumber;
            bulunan.SafetyStockLevel = product.SafetyStockLevel;
            bulunan.StandartCost = product.StandartCost;

            Repo.CUDOperation(bulunan, System.Data.Entity.EntityState.Modified);
            return Repo.SaveChange();
        }

        public int UrunSil(int id)
        {
            Product Temp = guncellenecekVEsilinecek(id);
            Repo.CUDOperation(Temp, System.Data.Entity.EntityState.Deleted);
            return Repo.SaveChange();
        }

        public List<Product> SearchProduct(string key)
        {
            return Repo.Where(I => I.Name.Contains(key)).ToList();
        }


    }
}
