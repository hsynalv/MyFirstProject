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
    public partial class YöneticiTanımlama : Form
    {
        public YöneticiTanımlama()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
           
           int ReturnValue = BLLKullaniciOperation.YoneticiTanımlama(txt_isim.Text, txt_soyisim.Text, txt_kullaniciAdi.Text, txt_sifre.Text);
            if (ReturnValue > 0)
            {
                lbl_message.Text = "Yönetici Ekleme İşlemi Başarılı";
                this.Close();
            }
            else if (ReturnValue == -100)
            {
                lbl_message.Text = "Lütfen Bilgileri Eksiksiz Giriniz.";
            }
            else
            {
                lbl_message.Text = "Yönetici Ekleme İşlemi Başarısız";
            }

            
        }

        private void YöneticiTanımlama_Load(object sender, EventArgs e)
        {
            lbl_message.Text = "Sisteme Yönetici Tanımlamalısınız.";
        }
    }
}
