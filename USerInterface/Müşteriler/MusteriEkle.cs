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

namespace USerInterface.Müşteriler
{
    public partial class MusteriEkle : Form
    {
        BLLCustomerOperation customerOperation;
        Random random = new Random();
        public MusteriEkle()
        {
            InitializeComponent();
            customerOperation = new BLLCustomerOperation();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int returnValue = customerOperation.MusteriEkle(random.Next(100, 1000).ToString(), txt_isim.Text,
                txt_soyisim.Text, txt_tel.Text, txt_email.Text, DateTime.Now);


            if (returnValue > 0)
            {
                lbl_message.Text = "Müştereri Ekleme İşlemi Başarılı";
            this.Close();
            }
            else if (returnValue == -100)
            {
                lbl_message.Text = "Lütfen Bilgileri Eksiksiz Giriniz";
            }
            else
            {
                lbl_message.Text = "Müştereri Ekleme İşlemi Başarısız";

            }   
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
