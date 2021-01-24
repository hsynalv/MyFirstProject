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
    public partial class Kullanicilar : Form
    {
        BLLKullaniciOperation kullaniciOperation;
        Kullanici Temp;
        Kullanici _kullanici;
        Form acıkForm;
        public Kullanicilar(Kullanici kullanici)
        {
            InitializeComponent();
            kullaniciOperation = new BLLKullaniciOperation();
            _kullanici = kullanici;
        }

        private void Kullanicilar_Load(object sender, EventArgs e)
        {
            dgvYenile();
        }

        private void dgv_kullanicilar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = Convert.ToInt32(dgv_kullanicilar.CurrentRow.Cells[0].Value);
            Temp = kullaniciOperation.guncellenecekVEsilinecek(row);
        }

        private void adminYetkisiVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Temp.YetkiKontrol)
            {
                MessageBox.Show("Personelin Zaten Admin Yetkisi Var", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               DialogResult result = MessageBox.Show("Gerçekten Admin Yetkisi Vermek İstiyor musunuz?", "Soru",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    kullaniciOperation.PersonelGuncelle(Temp.ID, true);
                }
            }
        }

        private void adminYetkisiniAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Temp == null)
            {
                MessageBox.Show("Lütfen Personel Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (!Temp.YetkiKontrol)
                {
                    MessageBox.Show("Personelin Zaten Admin Yetkisi Yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Temp.ID != 1)
                    { 
                        DialogResult result = MessageBox.Show("Gerçekten Admin Yetkisi Almak İstiyor musunuz?", "Soru",
                                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            kullaniciOperation.PersonelGuncelle(Temp.ID, false);
                        }
                    }
                    
                    else
                    {
                        MessageBox.Show("Yönetici Yetkisi Dokunulmazdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }
           
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Temp == null)
            {
                MessageBox.Show("Lütfen Personel Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Temp.ID != 1)
                {
                    if (_kullanici.ID == Temp.ID)
                    {
                        MessageBox.Show("Kendi Kendini Silemezsin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult result = MessageBox.Show("Gerçekten Personeli Silmek İstiyor musunuz?", "Soru",
                                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            kullaniciOperation.PersonelSil(Temp.ID);
                        }
                    }
                    
                }
                else 
                {
                    MessageBox.Show("Yönetici  Dokunulmazdır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                
                
            }
            
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_kullanicilar.DataSource = null;
            dgvYenile();
        }

        private void dgvYenile()
        {
            //dgv_kullanicilar.Columns["Sifre"].Visible = false;
            dgv_kullanicilar.DataSource = kullaniciOperation.KullaniciListe();
        }
    }
}
