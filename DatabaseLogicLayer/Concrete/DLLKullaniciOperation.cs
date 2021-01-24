using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository;

namespace DatabaseLogicLayer.Concrete
{
    public class DLLKullaniciOperation
    {
        RepositoryBase<Kullanici, EFContext> Repo;

        public DLLKullaniciOperation()
        {
            Repo = new RepositoryBase<Kullanici, EFContext>();
        }

        public int CountControl()
        {
            return Repo.CountControl();
        }


        public int YoneticiTanımlama(Kullanici kullanici)
        {
            Repo.CUDOperation(kullanici, System.Data.Entity.EntityState.Added);
            return Repo.SaveChange();
        }

        public Kullanici UserSearch(string kullaniciadi, string sifre)
        {
            Kullanici LoginKullanici = Repo.SingleSearch(I => I.KullaniciAdi == kullaniciadi && I.Sifre == sifre);
            return LoginKullanici;
        }

        public int SifreDegistir(int id, string sifre,string kullaniciadi)
        {
            Kullanici Temp = Repo.Find(id);
            Temp.Sifre = sifre;
            Temp.KullaniciAdi = kullaniciadi;
            return Repo.SaveChange();
        }

        public int PersonelEkle(Kullanici kullanici)
        {
            Repo.CUDOperation(kullanici, System.Data.Entity.EntityState.Added);
            return Repo.SaveChange();
        }

        public List<Kullanici> KullaniciListe()
        {
            List<Kullanici> PersonelListe = Repo.GetAll().ToList();
            return PersonelListe;
        }

        public Kullanici guncellenecekVEsilinecek(int id)
        {
            return Repo.Find(id);
        }

        public int PersonelGuncelle(int id, bool yetki)
        {
            Kullanici Temp = guncellenecekVEsilinecek(id);
            Temp.YetkiKontrol = yetki;
            Repo.CUDOperation(Temp, System.Data.Entity.EntityState.Modified);
            return Repo.SaveChange();
        }

        public int PersonelSil(int id)
        {
            Repo.CUDOperation(guncellenecekVEsilinecek(id), System.Data.Entity.EntityState.Deleted);
            return Repo.SaveChange();
        }

       
    }
}
