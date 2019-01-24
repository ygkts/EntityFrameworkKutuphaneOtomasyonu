using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace u2_EFKutuphaneCRUDIslemleri
{
    public partial class YazarEkle : Form
    {
        public YazarEkle()
        {
            InitializeComponent();
        }
        KutuphaneEntities1 db;
        void Doldur()
        {
            db = new KutuphaneEntities1();
            List<YazarTablo> list = db.YazarTabloes.ToList();
            dataGridView1.Rows.Clear();
            int k = 0;
            foreach (var a in list)    // datagridview1 e 2 adet sütunu yazdırma
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[k].Cells[0].Value = a.yazarno;
                dataGridView1.Rows[k].Cells[1].Value = a.yazarad;
                dataGridView1.Rows[k].Cells[2].Value = a.yazarsoyad;
                k++;
            }
        }
        private void YazarEkle_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                YazarTablo tablo = new YazarTablo();
                tablo.yazarno = Convert.ToInt32(txtNum.Text);
                tablo.yazarad = txtAd.Text;
                tablo.yazarsoyad = txtSoyad.Text;
                db.YazarTabloes.Add(tablo);
                db.SaveChanges();
                Doldur();
                MessageBox.Show("Değer Eklendi..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"HATA");
            }
            
        }

        private void buttonDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                int guncel = Convert.ToInt32(txtNum.Text);
                var guncellenecekDeger = db.YazarTabloes.Where(w => w.yazarno == guncel).FirstOrDefault();
                guncellenecekDeger.yazarad = txtAd.Text;
                guncellenecekDeger.yazarsoyad = txtSoyad.Text;
                db.SaveChanges();
                Doldur();
                MessageBox.Show("Değer Güncellendi..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA");
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                int sil = Convert.ToInt32(txtNum.Text);
                var silinecekDeger = db.YazarTabloes.Where(w => w.yazarno == sil).FirstOrDefault();
                db.YazarTabloes.Remove(silinecekDeger);
                db.SaveChanges();
                Doldur();
                MessageBox.Show("Değer Silindi..");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA");
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var islem = db.YazarTabloes.Where(x => x.yazarno == secilenID).FirstOrDefault();
                txtNum.Text = islem.yazarno.ToString();
                txtAd.Text = islem.yazarad.ToString();
                txtSoyad.Text = islem.yazarsoyad.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA");
            }
        }
    }
}
