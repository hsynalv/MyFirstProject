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

namespace USerInterface.Müşteriler
{
    public partial class Musteriler : Form
    {
        Form acıkForm;
        BLLCustomerOperation customerOperation;
        Customer Temp;
        public Musteriler()
        {
            InitializeComponent();
            customerOperation = new BLLCustomerOperation();
            acıkForm = new Form();
        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            dgv_musteriler.DataSource = customerOperation.MusteriListele();
        }

        private void yenileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_musteriler.DataSource = null;
            dgv_musteriler.DataSource = customerOperation.MusteriListele();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Kontrol = Application.OpenForms["MusteriEkle"];
            if (Kontrol == null)
            {
                MusteriEkle ekle = new MusteriEkle();
                ekle.MdiParent = MdiParent;
                ekle.StartPosition = FormStartPosition.CenterParent;
                ekle.Show();
            }
            else
            {
                acıkForm = Application.OpenForms["MusteriEkle"];
                acıkForm.Focus();
            }
        }

        private void dgv_musteriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = Convert.ToInt32(dgv_musteriler.CurrentRow.Cells[0].Value);
            Temp = customerOperation.guncellenecekVEsilinecek(row);
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Temp == null)
            {
                MessageBox.Show("Lütfen Bir Müşteri seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Gerçekten Müşteriyi Silmek İstiyor musunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    customerOperation.MusteriSil(Temp.CustomerID);
                }
            }
            
        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Kontrol = Application.OpenForms["MusteriGuncelle"];
            if (Kontrol == null)
            {
                MusteriGuncelle guncelleForm = new MusteriGuncelle(Temp);
                guncelleForm.MdiParent = MdiParent;
                guncelleForm.StartPosition = FormStartPosition.CenterParent;
                guncelleForm.Show();
            }
            else
            {
                acıkForm = Application.OpenForms["MusteriGuncelle"];
                acıkForm.Focus();
            }
        }
    }
}
