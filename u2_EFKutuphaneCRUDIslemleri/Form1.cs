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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ogrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogr = new OgrenciEkle();
            ogr.ShowDialog();
        }

        private void kitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KitapEkle ktp = new KitapEkle();
            ktp.ShowDialog();
        }

        private void yazarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YazarEkle yzr = new YazarEkle();
            yzr.ShowDialog();
        }

        private void turlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurEkle tur = new TurEkle();
            tur.ShowDialog();
        }

        private void islemlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IslemEkle islm = new IslemEkle();
            islm.ShowDialog();
        }
    }
}
