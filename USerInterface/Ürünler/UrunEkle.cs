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

namespace USerInterface.Ürünler
{
    public partial class UrunEkle : Form
    {
        BLLProductOperation productOperation;
        public UrunEkle()
        {
            InitializeComponent();
            productOperation = new BLLProductOperation();
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int ReturnValue = productOperation.UrunEkle(txt_ad.Text, random.Next(100, 5000).ToString(), txt_renk.Text, txt_stock.Text,
                                         txt_maliyet.Text, txt_fiyat.Text);
            if (ReturnValue > 0)
            {
                lbl_message.Text = "Ürün Başarıyla Eklendi";
            }
            else if (ReturnValue == -100)
            {
                lbl_message.Text = "Lütfen Bilgileri Eksiksiz Giriniz";
            }
            else
            {
                lbl_message.Text = "Ürün Eklenemedi";
            }


        }

    }
}
