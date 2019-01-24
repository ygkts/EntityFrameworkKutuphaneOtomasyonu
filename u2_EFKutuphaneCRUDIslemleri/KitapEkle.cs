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
    public partial class KitapEkle : Form
    {
        public KitapEkle()
        {
            InitializeComponent();
        }
        KutuphaneEntities1 db;
        void Doldur()
        {
            db = new KutuphaneEntities1();
            List<kitapTablo> list = db.kitapTabloes.ToList();
            dataGridView1.Rows.Clear();
            int k = 0;
            foreach (var a in list)    // datagridview1 e 2 adet sütunu yazdırma
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[k].Cells[0].Value = a.kitapno;
                dataGridView1.Rows[k].Cells[1].Value = a.isbnno;
                dataGridView1.Rows[k].Cells[2].Value = a.kitapadi;
                dataGridView1.Rows[k].Cells[3].Value = a.yazarno;
                dataGridView1.Rows[k].Cells[4].Value = a.turno;
                dataGridView1.Rows[k].Cells[5].Value = a.sayfasayisi;
                dataGridView1.Rows[k].Cells[6].Value = a.puan;
                k++;
            }
        }
        private void KitapEkle_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                kitapTablo kitap = new kitapTablo();
                kitap.kitapno = Convert.ToInt32(txtNum.Text);
                kitap.isbnno = Convert.ToInt32(txtISBNNo.Text);
                kitap.kitapadi = txtKitapAd.Text;
                kitap.yazarno = Convert.ToInt32(txtYazarNo.Text);
                kitap.turno = Convert.ToInt32(txtTurNo.Text);
                kitap.sayfasayisi = Convert.ToInt32(txtSayfaSayi.Text);
                kitap.puan = Convert.ToInt32(txtPuan.Text);
                db.kitapTabloes.Add(kitap);
                db.SaveChanges();
                Doldur();
                MessageBox.Show("Kitap Eklendi..");
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.ToString(),"HATA");
            }
           
        }

        private void buttonDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                int guncelle = Convert.ToInt32(txtNum.Text);
                var guncellenecekDeger = db.kitapTabloes.Where(w => w.kitapno == guncelle).FirstOrDefault();
                guncellenecekDeger.isbnno = Convert.ToInt32(txtISBNNo.Text);
                guncellenecekDeger.kitapadi = txtKitapAd.Text;
                guncellenecekDeger.yazarno = Convert.ToInt32(txtYazarNo.Text);
                guncellenecekDeger.turno = Convert.ToInt32(txtTurNo.Text);
                guncellenecekDeger.sayfasayisi = Convert.ToInt32(txtSayfaSayi.Text);
                guncellenecekDeger.puan = Convert.ToInt32(txtPuan.Text);
                db.SaveChanges();
                Doldur();
                MessageBox.Show("Kitap Güncellendi..");
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
                int silinecek = Convert.ToInt32(txtNum.Text);
                var silinecekDeger = db.kitapTabloes.Where(w => w.kitapno == silinecek).FirstOrDefault();
                db.kitapTabloes.Remove(silinecekDeger);
                db.SaveChanges();
                Doldur();
                MessageBox.Show("Kitap Silindi..");

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
                var islem = db.kitapTabloes.Where(x => x.kitapno == secilenID).FirstOrDefault();
                txtNum.Text = islem.kitapno.ToString();
                txtISBNNo.Text = islem.isbnno.ToString();
                txtKitapAd.Text = islem.kitapadi.ToString();
                txtYazarNo.Text = islem.yazarno.ToString();
                txtTurNo.Text = islem.turno.ToString();
                txtSayfaSayi.Text = islem.sayfasayisi.ToString();
                txtPuan.Text = islem.puan.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA");
            }
        }
    }
}
