namespace Stok_Programı
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.grpbx_bilgi = new System.Windows.Forms.GroupBox();
            this.txt_islem = new System.Windows.Forms.TextBox();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.txt_giristarihi = new System.Windows.Forms.TextBox();
            this.cmbx_urunadi = new System.Windows.Forms.ComboBox();
            this.cmbx_firmaadi = new System.Windows.Forms.ComboBox();
            this.lbl_islem = new System.Windows.Forms.Label();
            this.lbl_urunadet = new System.Windows.Forms.Label();
            this.lbl_giristarihi = new System.Windows.Forms.Label();
            this.lbl_urunkodu = new System.Windows.Forms.Label();
            this.lbl_firmaadi = new System.Windows.Forms.Label();
            this.grpbx_islem = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_resim = new System.Windows.Forms.Button();
            this.grpbx_bilgi.SuspendLayout();
            this.grpbx_islem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbx_bilgi
            // 
            this.grpbx_bilgi.Controls.Add(this.txt_islem);
            this.grpbx_bilgi.Controls.Add(this.txt_adet);
            this.grpbx_bilgi.Controls.Add(this.txt_giristarihi);
            this.grpbx_bilgi.Controls.Add(this.cmbx_urunadi);
            this.grpbx_bilgi.Controls.Add(this.cmbx_firmaadi);
            this.grpbx_bilgi.Controls.Add(this.lbl_islem);
            this.grpbx_bilgi.Controls.Add(this.lbl_urunadet);
            this.grpbx_bilgi.Controls.Add(this.lbl_giristarihi);
            this.grpbx_bilgi.Controls.Add(this.lbl_urunkodu);
            this.grpbx_bilgi.Controls.Add(this.lbl_firmaadi);
            this.grpbx_bilgi.Location = new System.Drawing.Point(12, 27);
            this.grpbx_bilgi.Name = "grpbx_bilgi";
            this.grpbx_bilgi.Size = new System.Drawing.Size(227, 254);
            this.grpbx_bilgi.TabIndex = 0;
            this.grpbx_bilgi.TabStop = false;
            this.grpbx_bilgi.Text = "Bilgiler";
            // 
            // txt_islem
            // 
            this.txt_islem.Location = new System.Drawing.Point(87, 204);
            this.txt_islem.Name = "txt_islem";
            this.txt_islem.Size = new System.Drawing.Size(121, 20);
            this.txt_islem.TabIndex = 9;
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(87, 156);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(121, 20);
            this.txt_adet.TabIndex = 8;
            // 
            // txt_giristarihi
            // 
            this.txt_giristarihi.Location = new System.Drawing.Point(87, 113);
            this.txt_giristarihi.Name = "txt_giristarihi";
            this.txt_giristarihi.Size = new System.Drawing.Size(121, 20);
            this.txt_giristarihi.TabIndex = 7;
            // 
            // cmbx_urunadi
            // 
            this.cmbx_urunadi.FormattingEnabled = true;
            this.cmbx_urunadi.Location = new System.Drawing.Point(87, 69);
            this.cmbx_urunadi.Name = "cmbx_urunadi";
            this.cmbx_urunadi.Size = new System.Drawing.Size(121, 21);
            this.cmbx_urunadi.TabIndex = 6;
            this.cmbx_urunadi.SelectedIndexChanged += new System.EventHandler(this.cmbx_urunadi_SelectedIndexChanged);
            // 
            // cmbx_firmaadi
            // 
            this.cmbx_firmaadi.FormattingEnabled = true;
            this.cmbx_firmaadi.Location = new System.Drawing.Point(87, 27);
            this.cmbx_firmaadi.Name = "cmbx_firmaadi";
            this.cmbx_firmaadi.Size = new System.Drawing.Size(121, 21);
            this.cmbx_firmaadi.TabIndex = 5;
            // 
            // lbl_islem
            // 
            this.lbl_islem.AutoSize = true;
            this.lbl_islem.Location = new System.Drawing.Point(7, 207);
            this.lbl_islem.Name = "lbl_islem";
            this.lbl_islem.Size = new System.Drawing.Size(34, 13);
            this.lbl_islem.TabIndex = 4;
            this.lbl_islem.Text = "İşlem:";
            // 
            // lbl_urunadet
            // 
            this.lbl_urunadet.AutoSize = true;
            this.lbl_urunadet.Location = new System.Drawing.Point(7, 163);
            this.lbl_urunadet.Name = "lbl_urunadet";
            this.lbl_urunadet.Size = new System.Drawing.Size(58, 13);
            this.lbl_urunadet.TabIndex = 3;
            this.lbl_urunadet.Text = "Ürün Adet:";
            // 
            // lbl_giristarihi
            // 
            this.lbl_giristarihi.AutoSize = true;
            this.lbl_giristarihi.Location = new System.Drawing.Point(7, 120);
            this.lbl_giristarihi.Name = "lbl_giristarihi";
            this.lbl_giristarihi.Size = new System.Drawing.Size(59, 13);
            this.lbl_giristarihi.TabIndex = 2;
            this.lbl_giristarihi.Text = "Giriş Tarihi:";
            // 
            // lbl_urunkodu
            // 
            this.lbl_urunkodu.AutoSize = true;
            this.lbl_urunkodu.Location = new System.Drawing.Point(7, 77);
            this.lbl_urunkodu.Name = "lbl_urunkodu";
            this.lbl_urunkodu.Size = new System.Drawing.Size(61, 13);
            this.lbl_urunkodu.TabIndex = 1;
            this.lbl_urunkodu.Text = "Ürün Kodu:";
            // 
            // lbl_firmaadi
            // 
            this.lbl_firmaadi.AutoSize = true;
            this.lbl_firmaadi.Location = new System.Drawing.Point(7, 35);
            this.lbl_firmaadi.Name = "lbl_firmaadi";
            this.lbl_firmaadi.Size = new System.Drawing.Size(53, 13);
            this.lbl_firmaadi.TabIndex = 0;
            this.lbl_firmaadi.Text = "Firma Adı:";
            // 
            // grpbx_islem
            // 
            this.grpbx_islem.Controls.Add(this.btn_resim);
            this.grpbx_islem.Controls.Add(this.btn_kaydet);
            this.grpbx_islem.Controls.Add(this.btn_temizle);
            this.grpbx_islem.Location = new System.Drawing.Point(12, 287);
            this.grpbx_islem.Name = "grpbx_islem";
            this.grpbx_islem.Size = new System.Drawing.Size(335, 55);
            this.grpbx_islem.TabIndex = 1;
            this.grpbx_islem.TabStop = false;
            this.grpbx_islem.Text = "İşlemler";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(133, 19);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 1;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(47, 19);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_temizle.TabIndex = 0;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(249, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(86, 73);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.ürünListesiToolStripMenuItem,
            this.stokRaporuToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // ürünListesiToolStripMenuItem
            // 
            this.ürünListesiToolStripMenuItem.Name = "ürünListesiToolStripMenuItem";
            this.ürünListesiToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.ürünListesiToolStripMenuItem.Text = "Ürün Listesi";
            // 
            // stokRaporuToolStripMenuItem
            // 
            this.stokRaporuToolStripMenuItem.Name = "stokRaporuToolStripMenuItem";
            this.stokRaporuToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.stokRaporuToolStripMenuItem.Text = "Stok Raporu";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 345);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(350, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel1.Text = "timer";
            // 
            // btn_resim
            // 
            this.btn_resim.Location = new System.Drawing.Point(226, 19);
            this.btn_resim.Name = "btn_resim";
            this.btn_resim.Size = new System.Drawing.Size(97, 23);
            this.btn_resim.TabIndex = 2;
            this.btn_resim.Text = "Resmi Göster";
            this.btn_resim.UseVisualStyleBackColor = true;
            this.btn_resim.Click += new System.EventHandler(this.btn_resim_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 367);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpbx_islem);
            this.Controls.Add(this.grpbx_bilgi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "ÜRETİM GİRİŞ";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.grpbx_bilgi.ResumeLayout(false);
            this.grpbx_bilgi.PerformLayout();
            this.grpbx_islem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx_bilgi;
        private System.Windows.Forms.GroupBox grpbx_islem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbx_urunadi;
        private System.Windows.Forms.ComboBox cmbx_firmaadi;
        private System.Windows.Forms.Label lbl_islem;
        private System.Windows.Forms.Label lbl_urunadet;
        private System.Windows.Forms.Label lbl_giristarihi;
        private System.Windows.Forms.Label lbl_urunkodu;
        private System.Windows.Forms.Label lbl_firmaadi;
        private System.Windows.Forms.TextBox txt_islem;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.TextBox txt_giristarihi;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.Button btn_resim;
    }
}