namespace u2_EFKutuphaneCRUDIslemleri
{
    partial class IslemEkle
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
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonDegistir = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.txtKitapNo = new System.Windows.Forms.TextBox();
            this.txtOgrNo = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerVeris = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerAlis = new System.Windows.Forms.DateTimePicker();
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
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(364, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(605, 324);
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
            this.Column2.HeaderText = "Öğrenci No";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kitap No";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Alış Tarihi";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Veriş Tarihi";
            this.Column5.Name = "Column5";
            // 
            // buttonSil
            // 
            this.buttonSil.BackColor = System.Drawing.Color.PaleTurquoise;
            this.buttonSil.Location = new System.Drawing.Point(224, 324);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(98, 34);
            this.buttonSil.TabIndex = 10;
            this.buttonSil.Text = "SİL";
            this.buttonSil.UseVisualStyleBackColor = false;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonDegistir
            // 
            this.buttonDegistir.BackColor = System.Drawing.Color.LemonChiffon;
            this.buttonDegistir.Location = new System.Drawing.Point(120, 324);
            this.buttonDegistir.Name = "buttonDegistir";
            this.buttonDegistir.Size = new System.Drawing.Size(98, 34);
            this.buttonDegistir.TabIndex = 11;
            this.buttonDegistir.Text = "DEĞİŞTİR";
            this.buttonDegistir.UseVisualStyleBackColor = false;
            this.buttonDegistir.Click += new System.EventHandler(this.buttonDegistir_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.BackColor = System.Drawing.Color.MistyRose;
            this.buttonKaydet.Location = new System.Drawing.Point(17, 324);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(98, 34);
            this.buttonKaydet.TabIndex = 12;
            this.buttonKaydet.Text = "KAYDET";
            this.buttonKaydet.UseVisualStyleBackColor = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // txtKitapNo
            // 
            this.txtKitapNo.Location = new System.Drawing.Point(123, 152);
            this.txtKitapNo.Name = "txtKitapNo";
            this.txtKitapNo.Size = new System.Drawing.Size(199, 22);
            this.txtKitapNo.TabIndex = 7;
            // 
            // txtOgrNo
            // 
            this.txtOgrNo.Location = new System.Drawing.Point(123, 94);
            this.txtOgrNo.Name = "txtOgrNo";
            this.txtOgrNo.Size = new System.Drawing.Size(199, 22);
            this.txtOgrNo.TabIndex = 8;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(123, 34);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(199, 22);
            this.txtNum.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kitap No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ogrenci No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Numara :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Veriş Tarihi :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Alış Tarihi :";
            // 
            // dateTimePickerVeris
            // 
            this.dateTimePickerVeris.Location = new System.Drawing.Point(123, 281);
            this.dateTimePickerVeris.Name = "dateTimePickerVeris";
            this.dateTimePickerVeris.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerVeris.TabIndex = 16;
            // 
            // dateTimePickerAlis
            // 
            this.dateTimePickerAlis.Location = new System.Drawing.Point(123, 218);
            this.dateTimePickerAlis.Name = "dateTimePickerAlis";
            this.dateTimePickerAlis.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerAlis.TabIndex = 17;
            // 
            // IslemEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 415);
            this.Controls.Add(this.dateTimePickerAlis);
            this.Controls.Add(this.dateTimePickerVeris);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonDegistir);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.txtKitapNo);
            this.Controls.Add(this.txtOgrNo);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IslemEkle";
            this.Text = "IslemEkle";
            this.Load += new System.EventHandler(this.IslemEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonDegistir;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.TextBox txtKitapNo;
        private System.Windows.Forms.TextBox txtOgrNo;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerVeris;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}