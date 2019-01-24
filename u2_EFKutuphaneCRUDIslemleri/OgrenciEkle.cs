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
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }
        KutuphaneEntities1 db;
        void Doldur()
        {
            db = new KutuphaneEntities1();
            List<OgrenciTablo> list = db.OgrenciTabloes.ToList();
            dataGridView1.Rows.Clear();
            int k = 0;
            foreach (var a in list)    // datagridview1 e 2 adet sütunu yazdırma
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[k].Cells[0].Value = a.ogrno;
                dataGridView1.Rows[k].Cells[1].Value = a.ograd;
                dataGridView1.Rows[k].Cells[2].Value = a.ogrsoyad;
                dataGridView1.Rows[k].Cells[3].Value = a.cinsiyet;
                dataGridView1.Rows[k].Cells[4].Value = a.dtarih;
                dataGridView1.Rows[k].Cells[5].Value = a.sinif;
                k++;
            }
        }
        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                OgrenciTablo ogr = new OgrenciTablo();
                ogr.ogrno = Convert.ToInt32(txtNum.Text);
                ogr.ograd = txtAd.Text;
                ogr.ogrsoyad = txtSoyad.Text;
                ogr.cinsiyet = txtCinsiyet.Text;
                ogr.dtarih = dateTimePicker1.Value;
                ogr.sinif = txtSinif.Text;
                db.OgrenciTabloes.Add(ogr);
                db.SaveChanges();
                Doldur();
                MessageBox.Show("Deger Eklendi...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA");
            }
        }

        private void buttonDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                int guncel = Convert.ToInt32(txtNum.Text);
                var guncellenecekDeger = db.OgrenciTabloes.Where(w => w.ogrno == guncel).FirstOrDefault();
                guncellenecekDeger.ograd = txtAd.Text;
                guncellenecekDeger.ogrsoyad = txtSoyad.Text;
                guncellenecekDeger.cinsiyet = txtCinsiyet.Text;
                guncellenecekDeger.dtarih = dateTimePicker1.Value;
                guncellenecekDeger.sinif = txtSinif.Text;
                db.SaveChanges();
                Doldur();
                MessageBox.Show("Deger Güncellendi...");
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
                var silincekDeger = db.OgrenciTabloes.Where(w => w.ogrno == silinecek).FirstOrDefault();
                db.OgrenciTabloes.Remove(silincekDeger);
                db.SaveChanges();
                Doldur();
                MessageBox.Show("Deger Silindi...");
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
                var islem = db.OgrenciTabloes.Where(x => x.ogrno == secilenID).FirstOrDefault();

                txtNum.Text = islem.ogrno.ToString();
                txtAd.Text = islem.ograd.ToString();
                txtSoyad.Text = islem.ogrsoyad.ToString();
                txtCinsiyet.Text = islem.cinsiyet.ToString();
                dateTimePicker1.Value = islem.dtarih.Value;
                txtSinif.Text = islem.sinif.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA");
            }
        }
    }
}
