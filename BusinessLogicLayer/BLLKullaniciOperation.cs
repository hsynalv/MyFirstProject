using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabaseLogicLayer.Concrete;
using Entity;

namespace BusinessLogicLayer
{
    public class BLLKullaniciOperation
    {
        static DLLKullaniciOperation kullaniciOperation;
        public BLLKullaniciOperation()
        {
            kullaniciOperation = new DLLKullaniciOperation();
        }

        public Kullanici UserSearch(string kullaniciadi,string sifre) 
        {
            if (!string.IsNullOrEmpty(kullaniciadi)&&!string.IsNullOrEmpty(sifre))
            {
                return kullaniciOperation.UserSearch(kullaniciadi, sifre);
            }
            else
            {
                return null;
            }
        }

        public int CountControl()
        {
            return kullaniciOperation.CountControl();
        }

        public static int YoneticiTanımlama(string isim,string soyisim,string kullaniciadi,string sifre)
        {
            if (!string.IsNullOrEmpty(isim) && !string.IsNullOrEmpty(soyisim) 
                    && !string.IsNullOrEmpty(kullaniciadi) && !string.IsNullOrEmpty(sifre))
            {
                return kullaniciOperation.YoneticiTanımlama(new Kullanici()
                {
                    AdSoyad = isim + " " + soyisim,
                    KullaniciAdi = kullaniciadi,
                    Sifre = sifre,
                    YetkiKontrol = true
                });
            }
            else
            {
                return -100;
            }
            
        }

        public int SifreDegistir(int id, string sifre,string kullaniciAdi)
        {
            if (!string.IsNullOrEmpty(sifre) && !string.IsNullOrEmpty(kullaniciAdi))
            {
                return kullaniciOperation.SifreDegistir(id,sifre,kullaniciAdi);
            }
            else
            {
                return -100;
            }
        }

        public int PersonelEkle(string isim,string soyisim,bool yetki)
        {
            if (!string.IsNullOrEmpty(isim) && !string.IsNullOrEmpty(soyisim))
            {
                return kullaniciOperation.PersonelEkle(new Kullanici()
                {
                    AdSoyad = isim + " " + soyisim,
                    KullaniciAdi = isim,
                    Sifre = "admin",
                    YetkiKontrol = yetki
                });
            }
            else
            {
                return -100;
            }
            
        }

        public List<Kullanici> KullaniciListe()
        {
            return kullaniciOperation.KullaniciListe();
        }

        public Kullanici guncellenecekVEsilinecek(int id)
        {
            return kullaniciOperation.guncellenecekVEsilinecek(id);
        }

        public int PersonelGuncelle(int id, bool yetki)
        {
            return kullaniciOperation.PersonelGuncelle(id, yetki);
        }

        public int PersonelSil(int id)
        {
            return kullaniciOperation.PersonelSil(id);
        }
    }
}
