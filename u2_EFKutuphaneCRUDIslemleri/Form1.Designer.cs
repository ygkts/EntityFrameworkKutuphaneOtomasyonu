namespace u2_EFKutuphaneCRUDIslemleri
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ogrencilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kitaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yazarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.türlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ıslemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ogrencilerToolStripMenuItem,
            this.kitaplarToolStripMenuItem,
            this.yazarlarToolStripMenuItem,
            this.türlerToolStripMenuItem,
            this.ıslemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ogrencilerToolStripMenuItem
            // 
            this.ogrencilerToolStripMenuItem.Name = "ogrencilerToolStripMenuItem";
            this.ogrencilerToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.ogrencilerToolStripMenuItem.Text = "Ogrenciler";
            this.ogrencilerToolStripMenuItem.Click += new System.EventHandler(this.ogrencilerToolStripMenuItem_Click);
            // 
            // kitaplarToolStripMenuItem
            // 
            this.kitaplarToolStripMenuItem.Name = "kitaplarToolStripMenuItem";
            this.kitaplarToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.kitaplarToolStripMenuItem.Text = "Kitaplar";
            this.kitaplarToolStripMenuItem.Click += new System.EventHandler(this.kitaplarToolStripMenuItem_Click);
            // 
            // yazarlarToolStripMenuItem
            // 
            this.yazarlarToolStripMenuItem.Name = "yazarlarToolStripMenuItem";
            this.yazarlarToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.yazarlarToolStripMenuItem.Text = "Yazarlar";
            this.yazarlarToolStripMenuItem.Click += new System.EventHandler(this.yazarlarToolStripMenuItem_Click);
            // 
            // türlerToolStripMenuItem
            // 
            this.türlerToolStripMenuItem.Name = "türlerToolStripMenuItem";
            this.türlerToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.türlerToolStripMenuItem.Text = "Turler";
            this.türlerToolStripMenuItem.Click += new System.EventHandler(this.turlerToolStripMenuItem_Click);
            // 
            // ıslemlerToolStripMenuItem
            // 
            this.ıslemlerToolStripMenuItem.Name = "ıslemlerToolStripMenuItem";
            this.ıslemlerToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.ıslemlerToolStripMenuItem.Text = "Islemler";
            this.ıslemlerToolStripMenuItem.Click += new System.EventHandler(this.islemlerToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 452);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "KÜTÜPHANE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ogrencilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kitaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yazarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem türlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ıslemlerToolStripMenuItem;
    }
}

