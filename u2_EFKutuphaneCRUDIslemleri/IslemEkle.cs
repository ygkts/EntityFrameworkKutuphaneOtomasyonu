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
    public partial class IslemEkle : Form
    {
        public IslemEkle()
        {
            InitializeComponent();
        }
        KutuphaneEntities1 db;
        void Doldur()
        {
            db = new KutuphaneEntities1();
            List<IslemTablo> list = db.IslemTabloes.ToList();
            dataGridView1.Rows.Clear();
            int k = 0;
            foreach (var a in list)    // datagridview1 e sütunu yazdırma
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[k].Cells[0].Value = a.islemno;
                dataGridView1.Rows[k].Cells[1].Value = a.ogrno;
                dataGridView1.Rows[k].Cells[2].Value = a.kitapno;
                dataGridView1.Rows[k].Cells[3].Value = a.atarih;
                dataGridView1.Rows[k].Cells[4].Value = a.vtarih;
                k++;
            }
        }
        private void IslemEkle_Load(object sender, EventArgs e)
        {
            Doldur();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                IslemTablo islem = new IslemTablo();
                islem.islemno = Convert.ToInt32(txtNum.Text);
                islem.ogrno = Convert.ToInt32(txtOgrNo.Text);
                islem.kitapno = Convert.ToInt32(txtKitapNo.Text);
                islem.vtarih = dateTimePickerVeris.Value;
                islem.atarih = dateTimePickerAlis.Value;
                db.IslemTabloes.Add(islem);
                db.SaveChanges();
                Doldur();
                MessageBox.Show("Değer Eklendi...");
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
                int guncelle = Convert.ToInt32(txtNum.Text);
                var guncellenecekDeger = db.IslemTabloes.Where(w => w.islemno == guncelle).FirstOrDefault();    // linq ifadesi kullandık. linq kodu kullanıdığımız için var türünde değşken olmalı
                guncellenecekDeger.ogrno = Convert.ToInt32(txtOgrNo.Text);
                guncellenecekDeger.kitapno = Convert.ToInt32(txtKitapNo.Text);
                guncellenecekDeger.vtarih = Convert.ToDateTime(dateTimePickerVeris.Value);
                guncellenecekDeger.atarih = Convert.ToDateTime(dateTimePickerAlis.Value);
                db.SaveChanges();
                Doldur();
                MessageBox.Show("Değer Güncellendi...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"HATA");
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            try
            {
                int silinecek = Convert.ToInt32(txtNum.Text);
                var silinecekDeger = db.IslemTabloes.Where(w => w.islemno == silinecek).FirstOrDefault();
                db.IslemTabloes.Remove(silinecekDeger);
                db.SaveChanges();
                Doldur();
                MessageBox.Show("Değer Silindi...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"HATA");
            }
        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {             
                int secilenID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var islem = db.IslemTabloes.Where(x => x.islemno == secilenID).FirstOrDefault();
                txtNum.Text = islem.islemno.ToString();
                txtOgrNo.Text = islem.ogrno.ToString();
                txtKitapNo.Text = islem.kitapno.ToString();
                dateTimePickerAlis.Value = islem.atarih.Value;
                dateTimePickerVeris.Value = islem.vtarih.Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "HATA");
            }
        }
    }
}
