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
    public partial class UrunGuncelle : Form
    {
        Product product;
        BLLProductOperation productOperation;
        public UrunGuncelle(Product _product)
        {
            InitializeComponent();
            productOperation = new BLLProductOperation();
            product = _product;
            txtDoldur();
        }

        private void txtDoldur()
        {
            try
            {
                txt_ad.Text = product.Name;
                txt_fiyat.Text = product.ListPrice.ToString();
                txt_maliyet.Text = product.StandartCost.ToString();
                txt_no.Text = product.ProductNumber;
                txt_renk.Text = product.Color;
                txt_stock.Text = product.SafetyStockLevel.ToString();
            }
            catch (Exception ex)
            {

                lbl_message.Text = "Lütfen Ürün Seçiniz";
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int returnValue = productOperation.UrunGuncelle(product.ProductID, txt_ad.Text, txt_no.Text, txt_renk.Text, 
                             txt_stock.Text, txt_maliyet.Text, txt_fiyat.Text);

            if (returnValue > 0)
            {
                lbl_message.Text = "Güncelleme İşlemi Başarılı...";
                this.Close();
                
            }
            else if (returnValue == -100)
            {
                lbl_message.Text = "Lütfen Bilgileri Eksiksiz Giriniz";
            }
            else
            {
                lbl_message.Text = "Güncelleme İşlemi Başarısız...";
            }
        }
    }
}
