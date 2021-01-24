using BusinessLogicLayer;
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
    public partial class PersonelEkle : Form
    {
        BLLKullaniciOperation kullaniciOperation;
        public PersonelEkle()
        {
            InitializeComponent();
            kullaniciOperation = new BLLKullaniciOperation();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            bool yetki = check_yetki.Checked;
            int returnValue = kullaniciOperation.PersonelEkle(txt_isim.Text, txt_soyisim.Text, yetki);

            if (returnValue > 0)
            {
                lbl_message.Text = "Personel Başarıyla Eklendi";
            }
            else if (returnValue == -100)
            {
                lbl_message.Text = "Lütfen Bilgileri Eksiksiz Giriniz";
            }
            else
            {
                lbl_message.Text = "Personel Eklenemedi";
            }
        }

        private void PersonelEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
