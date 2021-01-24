using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Product
    {
        [DisplayName("ID")]
        public int ProductID { get; set; }
        [DisplayName("Ürün Adı")]
        public string Name { get; set; }
        [DisplayName("Ürün Numarası")]
        public string ProductNumber { get; set; }
        [DisplayName("Renk")]
        public string Color { get; set; }
        [DisplayName("Stock")]
        public int SafetyStockLevel { get; set; }
        [DisplayName("Maliyet")]
        public decimal StandartCost { get; set; }
        [DisplayName("Fiyat")]
        public decimal ListPrice { get; set; }

        
    }
}
