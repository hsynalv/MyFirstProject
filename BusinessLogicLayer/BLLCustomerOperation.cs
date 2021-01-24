using DatabaseLogicLayer.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLLCustomerOperation
    {
        DLLCustomerOperation customerOperation;
        public BLLCustomerOperation()
        {
            customerOperation = new DLLCustomerOperation();
        }

        public List<Customer> MusteriListele()
        {
            return customerOperation.MusteriListele();
        }

        public int MusteriEkle(string customerCode, string FirstName, string LastName,string telefon, string email, DateTime createDate)
        {
            if (!string.IsNullOrEmpty(customerCode) && !string.IsNullOrEmpty(FirstName) && !string.IsNullOrEmpty(LastName)
                && !string.IsNullOrEmpty(telefon) && !string.IsNullOrEmpty(email))
            {
                return customerOperation.UrunEkle(new Customer()
                {
                    CustomerCode = customerCode,
                    FirstName = FirstName,
                    LastName = LastName,
                    Telefon = telefon,
                    Email = email,
                    CreateDate = createDate
                });
            }
            else
            {
                return -100;
            }
        }

        public Customer guncellenecekVEsilinecek(int id)
        {
            return customerOperation.guncellenecekVEsilinecek(id);
        }

        public int MusteriSil(int id)
        {
            return customerOperation.MusteriSil(id);
        }

        public int MusteriGuncelle(int id,string FirstNme,string LastName,string telefon, string email)
        {
            if (!string.IsNullOrEmpty(FirstNme) && !string.IsNullOrEmpty(LastName) && !string.IsNullOrEmpty(telefon) && !string.IsNullOrEmpty(email) && id != 0)
            {
                return customerOperation.MusteriGuncelle(id, new Customer()
                {
                    LastName = LastName,
                    FirstName = FirstNme,
                    Email = email,
                    Telefon = telefon
                });
            }
            else
            {
                return -100;
            }
        }
    }
}
