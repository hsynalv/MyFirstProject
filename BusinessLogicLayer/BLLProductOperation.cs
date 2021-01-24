using DatabaseLogicLayer.Concrete;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLLProductOperation
    {
        DLLProductOperation productOperation;

        public BLLProductOperation()
        {
            productOperation = new DLLProductOperation();
        }

        public int  UrunEkle(string name,string productnumber,string color,string stocklevel,
            string standartCost,string listPrice)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(productnumber) && !string.IsNullOrEmpty(color) && 
                !string.IsNullOrEmpty(stocklevel) && !string.IsNullOrEmpty(standartCost) && !string.IsNullOrEmpty(listPrice))
            {
                return productOperation.UrunEkle(new Product()
                {
                    Color = color,
                    ListPrice = decimal.Parse(listPrice),
                    Name = name,
                    ProductNumber = productnumber,
                    SafetyStockLevel = int.Parse(stocklevel),
                    StandartCost = decimal.Parse(standartCost)
                });
            }
            else
            {
                return -100;
            }
        }

        public List<Product> UrunListe()
        {
            return productOperation.UrunListe();
        }

        public Product guncellenecekVEsilinecek(int id)
        {
            return productOperation.guncellenecekVEsilinecek(id);
        }

        public int UrunGuncelle(int id ,string name, string productnumber, string color, string stocklevel,
            string standartCost, string listPrice)
        {
            if (!string.IsNullOrEmpty(name)&&!string.IsNullOrEmpty(productnumber)&&!string.IsNullOrEmpty(color)&&
                !string.IsNullOrEmpty(stocklevel)&&!string.IsNullOrEmpty(standartCost)&&!string.IsNullOrEmpty(listPrice))
            {
                return productOperation.UrunGuncelle(id, new Product()
                {
                    Color = color,
                    ListPrice = decimal.Parse(listPrice),
                    Name = name,
                    ProductNumber = productnumber,
                    SafetyStockLevel = int.Parse(stocklevel),
                    StandartCost = decimal.Parse(standartCost)
                });
            }
            else
            {
                return -100;

            }

        }

        public int UrunSil(int id)
        {
            return productOperation.UrunSil(id);
        }

        public List<Product> SearchProduct(string key)
        {
            return productOperation.SearchProduct(key);
        }
    }
}
