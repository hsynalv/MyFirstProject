using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Customer
    {
        [DisplayName("ID")]
        public int CustomerID { get; set; }
        [DisplayName("Müşteri Kodu")]
        public string CustomerCode { get; set; }
        [DisplayName("İsim")]
        public string FirstName {get; set; }
        [DisplayName("Soyisim")]
        public string LastName { get; set; }
        [DisplayName("Telefon")]
        public string Telefon { get; set; }
        [DisplayName("E-Mail")]
        public string Email { get; set; }
        [DisplayName("Kayıt Tarihi")]
        public DateTime CreateDate { get; set; }
    }
}
