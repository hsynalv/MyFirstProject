using BusinessLogicLayer;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USerInterface.KullaniciAyar
{
    public partial class SifreDegistir : Form
    {
        BLLKullaniciOperation kullaniciOperation;
        Kullanici _kullanici;
        public SifreDegistir(Kullanici kullanici)
        {
            InitializeComponent();
            kullaniciOperation = new BLLKullaniciOperation();
            _kullanici = kullanici;
            txt_eski.UseSystemPasswordChar = true;
            txt_yeni.UseSystemPasswordChar = true;
            txt_yeni2.UseSystemPasswordChar = true;
            label2.Text = _kullanici.AdSoyad;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_eski.UseSystemPasswordChar = false;
            txt_yeni.UseSystemPasswordChar = false;
            txt_yeni2.UseSystemPasswordChar = false;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            int returnValue = 0;
            if (_kullanici.Sifre == txt_eski.Text )
            {
                if (txt_yeni.Text == txt_yeni2.Text)
                {
                    returnValue = kullaniciOperation.SifreDegistir(_kullanici.ID, txt_yeni.Text,txt_kullanici.Text);
                    this.Close();
                }
                else if(returnValue == -100)
                {
                    label2.Text = "Yeni Şifre Alanları Boş Bırakılamaz";
                }
                else
                {
                    label2.Text = "Girilen Şifreler Birbiriyle Aynı Olmalıdır!!!";
                }
            }
            else
            {
                label2.Text = "Eski Şifre Yanlış!!!";
            }
        }

        private void SifreDegistir_Load(object sender, EventArgs e)
        {
            
        }
    }
}
