using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLayer.Concrete
{
    public class DLLCustomerOperation
    {
        RepositoryBase<Customer, EFContext> Repo;
        Customer bulunan;

        public DLLCustomerOperation()
        {
            Repo = new RepositoryBase<Customer, EFContext>();
        }

        public List<Customer> MusteriListele()
        {
            return Repo.GetAll().ToList();
        }

        public int UrunEkle(Customer customer)
        {
            Repo.CUDOperation(customer, System.Data.Entity.EntityState.Added);
            return Repo.SaveChange();
        }

        public Customer guncellenecekVEsilinecek(int id)
        {
            bulunan = Repo.Find(id);
            return bulunan;
        }

        public int MusteriGuncelle(int id, Customer customer)
        {
            guncellenecekVEsilinecek(id);
            bulunan.FirstName = customer.FirstName;
            bulunan.LastName = customer.LastName;

            Repo.CUDOperation(bulunan, System.Data.Entity.EntityState.Modified);
            return Repo.SaveChange();
        }

        public int MusteriSil(int id)
        {
            Customer Temp = guncellenecekVEsilinecek(id);
            Repo.CUDOperation(Temp, System.Data.Entity.EntityState.Deleted);
            return Repo.SaveChange();
        }
    }
}
