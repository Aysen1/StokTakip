namespace Stok_Programı
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stoklarıRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.lbl_hatali_giris = new System.Windows.Forms.Label();
            this.btn_giris = new System.Windows.Forms.Button();
            this.txt_kullanici_sifre = new System.Windows.Forms.TextBox();
            this.txt_kullanici_isim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.ürünListesiToolStripMenuItem,
            this.stoklarıRaporlaToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(320, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            // 
            // ürünListesiToolStripMenuItem
            // 
            this.ürünListesiToolStripMenuItem.Name = "ürünListesiToolStripMenuItem";
            this.ürünListesiToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.ürünListesiToolStripMenuItem.Text = "Ürün Listesi";
            // 
            // stoklarıRaporlaToolStripMenuItem
            // 
            this.stoklarıRaporlaToolStripMenuItem.Name = "stoklarıRaporlaToolStripMenuItem";
            this.stoklarıRaporlaToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.stoklarıRaporlaToolStripMenuItem.Text = "Stokları Raporla";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_kapat);
            this.groupBox1.Controls.Add(this.lbl_hatali_giris);
            this.groupBox1.Controls.Add(this.btn_giris);
            this.groupBox1.Controls.Add(this.txt_kullanici_sifre);
            this.groupBox1.Controls.Add(this.txt_kullanici_isim);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 180);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // btn_kapat
            // 
            this.btn_kapat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_kapat.Location = new System.Drawing.Point(155, 126);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(50, 27);
            this.btn_kapat.TabIndex = 6;
            this.btn_kapat.Text = "Kapat";
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // lbl_hatali_giris
            // 
            this.lbl_hatali_giris.AutoSize = true;
            this.lbl_hatali_giris.Location = new System.Drawing.Point(19, 164);
            this.lbl_hatali_giris.Name = "lbl_hatali_giris";
            this.lbl_hatali_giris.Size = new System.Drawing.Size(0, 13);
            this.lbl_hatali_giris.TabIndex = 5;
            // 
            // btn_giris
            // 
            this.btn_giris.Location = new System.Drawing.Point(105, 126);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(50, 27);
            this.btn_giris.TabIndex = 4;
            this.btn_giris.Text = "Giriş";
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_kullanici_sifre
            // 
            this.txt_kullanici_sifre.Location = new System.Drawing.Point(105, 81);
            this.txt_kullanici_sifre.Name = "txt_kullanici_sifre";
            this.txt_kullanici_sifre.Size = new System.Drawing.Size(100, 20);
            this.txt_kullanici_sifre.TabIndex = 3;
            // 
            // txt_kullanici_isim
            // 
            this.txt_kullanici_isim.Location = new System.Drawing.Point(105, 36);
            this.txt_kullanici_isim.Name = "txt_kullanici_isim";
            this.txt_kullanici_isim.Size = new System.Drawing.Size(100, 20);
            this.txt_kullanici_isim.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı İsmi: ";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_kapat;
            this.ClientSize = new System.Drawing.Size(320, 268);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Giris";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stoklarıRaporlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.TextBox txt_kullanici_sifre;
        private System.Windows.Forms.TextBox txt_kullanici_isim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_hatali_giris;
        private System.Windows.Forms.Button btn_kapat;
    }
}

