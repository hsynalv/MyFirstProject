using BusinessLogicLayer;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USerInterface.Müşteriler
{
    public partial class MusteriGuncelle : Form
    {
        Customer _customer;
        BLLCustomerOperation customerOperation;
        public MusteriGuncelle(Customer customer)
        {
            InitializeComponent();
            customerOperation = new BLLCustomerOperation();
            _customer = customer;
            txtDolur();
        }
        private void txtDolur()
        {
            try
            {
                txt_isim.Text = _customer.FirstName;
                txt_soyisim.Text = _customer.LastName;
                txt_email.Text = _customer.Email;
                txt_tel.Text = _customer.Telefon;
            }
            catch (Exception)
            {
                lbl_message.Text = "Lütfen Bir Müşteri seçiniz";
                Thread.Sleep(1000);
                this.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int returValue = customerOperation.MusteriGuncelle(_customer.CustomerID, txt_isim.Text, txt_soyisim.Text,txt_tel.Text,txt_email.Text);

            if (returValue > 0)
            {
                lbl_message.Text = "Güncelleme İşlemi Başarılı...";
                this.Close();

            }
            else if (returValue == -100)
            {
                lbl_message.Text = "Lütfen Bilgileri Eksiksiz Giriniz";
            }
            else
            {
                lbl_message.Text = "Güncelleme İşlemi Başarısız...";
            }
        }

        private void MusteriGuncelle_Load(object sender, EventArgs e)
        {

        }
    }
}
