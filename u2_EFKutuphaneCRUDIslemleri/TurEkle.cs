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
    public partial class TurEkle : Form
    {
        public TurEkle()
        {
            InitializeComponent();
        }
        KutuphaneEntities1 db;
        void Doldur()
        {
            db = new KutuphaneEntities1();
            List<TurTablo> list = db.TurTabloes.ToList();
            dataGridView1.Rows.Clear();
            int k = 0;
            foreach (var a in list)    // datagridview1 e 2 adet sütunu yazdırma
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[k].Cells[0].Value = a.turno;
                dataGridView1.Rows[k].Cells[1].Value = a.turad;
                k++;
            }
        }
        private void TurEkle_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                TurTablo tur = new TurTablo();
                tur.turno = Convert.ToInt32(txtNum.Text);
                tur.turad = txtAd.Text;
                db.TurTabloes.Add(tur);
                db.SaveChanges();
                Doldur();
                MessageBox.Show("Değer EKlendi...");
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
                var guncellenecekDeger = db.TurTabloes.Where(w => w.turno == guncel).FirstOrDefault();
                guncellenecekDeger.turad = txtAd.Text;
                db.SaveChanges();
                Doldur();
                MessageBox.Show("Değer EKlendi...");
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
                var silinecekDeger = db.TurTabloes.Where(w => w.turno == sil).FirstOrDefault();
                db.TurTabloes.Remove(silinecekDeger);
                db.SaveChanges();
                Doldur();
                MessageBox.Show("Değer EKlendi...");
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
                var islem = db.TurTabloes.Where(x => x.turno == secilenID).FirstOrDefault();
                txtNum.Text = islem.turno.ToString();
                txtAd.Text = islem.turad.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA");
            }
        }
    }
}
