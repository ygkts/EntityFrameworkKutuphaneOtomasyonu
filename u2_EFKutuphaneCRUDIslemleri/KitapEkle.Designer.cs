namespace u2_EFKutuphaneCRUDIslemleri
{
    partial class KitapEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonDegistir = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.txtISBNNo = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSayfaSayi = new System.Windows.Forms.TextBox();
            this.txtTurNo = new System.Windows.Forms.TextBox();
            this.txtYazarNo = new System.Windows.Forms.TextBox();
            this.txtPuan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(344, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(697, 428);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numara";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "ISBN NO";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kitap AD";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Yazar No";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tür NO";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Sayfa Sayısı";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Puan";
            this.Column7.Name = "Column7";
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSil.Location = new System.Drawing.Point(236, 435);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(93, 34);
            this.buttonSil.TabIndex = 10;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonDegistir
            // 
            this.buttonDegistir.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonDegistir.Location = new System.Drawing.Point(126, 435);
            this.buttonDegistir.Name = "buttonDegistir";
            this.buttonDegistir.Size = new System.Drawing.Size(93, 34);
            this.buttonDegistir.TabIndex = 11;
            this.buttonDegistir.Text = "DEĞİŞTİR";
            this.buttonDegistir.UseVisualStyleBackColor = false;
            this.buttonDegistir.Click += new System.EventHandler(this.buttonDegistir_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.Color.MistyRose;
            this.buttonKaydet.Location = new System.Drawing.Point(15, 435);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(93, 34);
            this.buttonKaydet.TabIndex = 12;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(135, 159);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(154, 22);
            this.txtKitapAd.TabIndex = 7;
            // 
            // txtISBNNo
            // 
            this.txtISBNNo.Location = new System.Drawing.Point(135, 101);
            this.txtISBNNo.Name = "txtISBNNo";
            this.txtISBNNo.Size = new System.Drawing.Size(154, 22);
            this.txtISBNNo.TabIndex = 8;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(135, 41);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(154, 22);
            this.txtNum.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kitap Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ISBN No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numara :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sayfa Sayısı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tür No :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Yazar No :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Puan :";
            // 
            // txtSayfaSayi
            // 
            this.txtSayfaSayi.Location = new System.Drawing.Point(135, 338);
            this.txtSayfaSayi.Name = "txtSayfaSayi";
            this.txtSayfaSayi.Size = new System.Drawing.Size(154, 22);
            this.txtSayfaSayi.TabIndex = 18;
            // 
            // txtTurNo
            // 
            this.txtTurNo.Location = new System.Drawing.Point(135, 280);
            this.txtTurNo.Name = "txtTurNo";
            this.txtTurNo.Size = new System.Drawing.Size(154, 22);
            this.txtTurNo.TabIndex = 19;
            // 
            // txtYazarNo
            // 
            this.txtYazarNo.Location = new System.Drawing.Point(135, 220);
            this.txtYazarNo.Name = "txtYazarNo";
            this.txtYazarNo.Size = new System.Drawing.Size(154, 22);
            this.txtYazarNo.TabIndex = 20;
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(135, 385);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(154, 22);
            this.txtPuan.TabIndex = 18;
            // 
            // KitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 497);
            this.Controls.Add(this.txtPuan);
            this.Controls.Add(this.txtSayfaSayi);
            this.Controls.Add(this.txtTurNo);
            this.Controls.Add(this.txtYazarNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonDegistir);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.txtISBNNo);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KitapEkle";
            this.Text = "KitapEkle";
            this.Load += new System.EventHandler(this.KitapEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonDegistir;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.TextBox txtISBNNo;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSayfaSayi;
        private System.Windows.Forms.TextBox txtTurNo;
        private System.Windows.Forms.TextBox txtYazarNo;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}