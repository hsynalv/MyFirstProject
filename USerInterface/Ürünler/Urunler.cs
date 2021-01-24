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
using USerInterface.Ürünler;

namespace USerInterface
{
    public partial class Urunler : Form
    {
        BLLProductOperation productOperation;
        Product Temp;
        Form acıkForm;
        public Urunler()
        {
            InitializeComponent();
            productOperation = new BLLProductOperation();
            acıkForm = new Form();

        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Kontrol = Application.OpenForms["UrunEkle"];
            if (Kontrol == null)
            {
                UrunEkle ekle = new UrunEkle();
                ekle.MdiParent = MdiParent;
                ekle.StartPosition = FormStartPosition.CenterParent;
                ekle.Show();
            }
            else
            {
                acıkForm = Application.OpenForms["UrunEkle"];
                acıkForm.Focus();
            }

        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            List<Product> liste = productOperation.UrunListe();
            dataGridView1.DataSource = liste;
            lbl_count.Text = $"Ürün Sayısı: {liste.Count().ToString()}";
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            List<Product> liste = productOperation.UrunListe();
            dataGridView1.DataSource = liste;
            lbl_count.Text = $"Ürün Sayısı: {liste.Count().ToString()}";
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Kontrol = Application.OpenForms["UrunGuncelle"];
            if (Kontrol == null)
            {
                UrunGuncelle guncelleForm = new UrunGuncelle(Temp);
                guncelleForm.MdiParent = MdiParent;
                guncelleForm.StartPosition = FormStartPosition.CenterParent;
                guncelleForm.Show();
            }
            else
            {
                acıkForm = Application.OpenForms["UrunGuncelle"];
                acıkForm.Focus();
            } 
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Temp = productOperation.guncellenecekVEsilinecek(row);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Temp == null)
            {
                MessageBox.Show("Lütfen Bir Ürün seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Gerçekten Ürünü Silmek İstiyor musunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    productOperation.UrunSil(Temp.ProductID);
                }
            }
        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            List<Product> liste = productOperation.SearchProduct(txt_ara.Text);
            dataGridView1.DataSource = liste;
            lbl_count.Text = $"Ürün Sayısı: {liste.Count().ToString()}";
        }
    }
}
