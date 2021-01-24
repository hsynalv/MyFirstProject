using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Kullanici
    {
        [DisplayName("ID")]
        public int ID { get; set; }
        [DisplayName("Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [DisplayName("Sifre")]
        public string Sifre { get; set; }
        [DisplayName("İsim Soyisim")]
        public string AdSoyad { get; set; }
        [DisplayName("Admin Yetkisi")]
        public bool YetkiKontrol { get; set; }
    }
}
