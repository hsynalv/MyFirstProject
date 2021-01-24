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
using USerInterface.Müşteriler;

namespace USerInterface
{
    public partial class MainForm : Form
    {
        Kullanici _kullanici;
        Form acıkForm;
        public MainForm(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txt_kullanici.Text = _kullanici.AdSoyad;
            if (_kullanici.Sifre == "admin")
            {
                MessageBox.Show("Şifreniz Varsayılan Olduğu İçin Değiştiriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SifreDegistir form = new SifreDegistir(_kullanici);
                form.MdiParent = this;
                form.StartPosition = FormStartPosition.CenterParent;
                form.Show();
                this.Hide();
            }
            
        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["Urunler"];
            if (kontrol == null)
            {
                Urunler urunForm = new Urunler();
                urunForm.MdiParent = this;
                urunForm.StartPosition = FormStartPosition.CenterScreen;
                urunForm.Show();
            }
            else
            {
                acıkForm = Application.OpenForms["Urunler"];
                acıkForm.Focus();
            }
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["Musteriler"];
            if (kontrol == null)
            {
                Musteriler MusteriForm = new Musteriler();
                MusteriForm.MdiParent = this;
                MusteriForm.StartPosition = FormStartPosition.CenterScreen;
                MusteriForm.Show();
            }
            else
            {
                acıkForm = Application.OpenForms["Musteriler"];
                acıkForm.Focus();
            }
        }

        private void profilAyarlarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form kontrol = Application.OpenForms["SifreDegistir"];
            if (kontrol == null)
            {
                SifreDegistir form = new SifreDegistir(_kullanici);
                form.MdiParent = this;
                form.StartPosition = FormStartPosition.CenterParent;
                form.Show();
            }
            else
            {
                acıkForm = Application.OpenForms["SifreDegistir"];
                acıkForm.Focus();
            }
        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_kullanici.YetkiKontrol)
            {
                Form kontrol = Application.OpenForms["PersonelEkle"];
                if (kontrol == null)
                {
                    PersonelEkle form = new PersonelEkle();
                    form.MdiParent = this;
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.Show();
                }
                else
                {
                    acıkForm = Application.OpenForms["PersonelEkle"];
                    acıkForm.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bu Alana Erişmek İçin Yetkiniz Bulunmamaktadır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void personelGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_kullanici.YetkiKontrol)
            {
                Form kontrol = Application.OpenForms["Kullanicilar"];
                if (kontrol == null)
                {
                    Kullanicilar form = new Kullanicilar(_kullanici);
                    form.MdiParent = this;
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.Show();
                }
                else
                {
                    acıkForm = Application.OpenForms["Kullanicilar"];
                    acıkForm.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bu Alana Erişmek İçin Yetkiniz Bulunmamaktadır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
