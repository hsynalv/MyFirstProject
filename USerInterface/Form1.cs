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
using USerInterface.KullaniciAyar;

namespace USerInterface
{
    public partial class Form1 : Form
    {
        BLLKullaniciOperation kullaniciOperation;       
        public Form1()
        {
            InitializeComponent();
            kullaniciOperation = new BLLKullaniciOperation();
            txt_sifre.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int bulunan = kullaniciOperation.CountControl();
            if (bulunan == 0)
            {
                YöneticiTanımlama tanimla = new YöneticiTanımlama();
                tanimla.Show();
            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            Kullanici Temp = kullaniciOperation.UserSearch(txt_kullaniciadi.Text, txt_sifre.Text);
            if (Temp == null)
            {
                MessageBox.Show("Kullanıcı Adı veya Şire Yanlış...","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MainForm form = new MainForm(Temp);
                form.Show();
            }
        }
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_sifre.UseSystemPasswordChar = false;
        }
    }
}
