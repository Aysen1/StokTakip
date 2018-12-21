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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pctrbx_resim = new System.Windows.Forms.PictureBox();
            this.grpbx_islem = new System.Windows.Forms.GroupBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.lbl_firmaadi = new System.Windows.Forms.Label();
            this.cmbx_firmaadi = new System.Windows.Forms.ComboBox();
            this.cmbx_urunadi = new System.Windows.Forms.ComboBox();
            this.lbl_urunkodu = new System.Windows.Forms.Label();
            this.txt_giristarihi = new System.Windows.Forms.TextBox();
            this.lbl_giristarihi = new System.Windows.Forms.Label();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_resim)).BeginInit();
            this.grpbx_islem.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.ürünListesiToolStripMenuItem,
            this.stokRaporuToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 24);
            this.menuStrip1.TabIndex = 0;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_adet);
            this.groupBox1.Controls.Add(this.lbl_adet);
            this.groupBox1.Controls.Add(this.txt_giristarihi);
            this.groupBox1.Controls.Add(this.lbl_giristarihi);
            this.groupBox1.Controls.Add(this.cmbx_urunadi);
            this.groupBox1.Controls.Add(this.lbl_urunkodu);
            this.groupBox1.Controls.Add(this.cmbx_firmaadi);
            this.groupBox1.Controls.Add(this.lbl_firmaadi);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bilgiler";
            // 
            // pctrbx_resim
            // 
            this.pctrbx_resim.Location = new System.Drawing.Point(250, 108);
            this.pctrbx_resim.Name = "pctrbx_resim";
            this.pctrbx_resim.Size = new System.Drawing.Size(100, 100);
            this.pctrbx_resim.TabIndex = 2;
            this.pctrbx_resim.TabStop = false;
            // 
            // grpbx_islem
            // 
            this.grpbx_islem.Controls.Add(this.btn_kaydet);
            this.grpbx_islem.Controls.Add(this.btn_temizle);
            this.grpbx_islem.Location = new System.Drawing.Point(12, 289);
            this.grpbx_islem.Name = "grpbx_islem";
            this.grpbx_islem.Size = new System.Drawing.Size(346, 40);
            this.grpbx_islem.TabIndex = 2;
            this.grpbx_islem.TabStop = false;
            this.grpbx_islem.Text = "İşlem";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 332);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(358, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(60, 11);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_temizle.TabIndex = 0;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(211, 11);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 1;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // lbl_firmaadi
            // 
            this.lbl_firmaadi.AutoSize = true;
            this.lbl_firmaadi.Location = new System.Drawing.Point(7, 37);
            this.lbl_firmaadi.Name = "lbl_firmaadi";
            this.lbl_firmaadi.Size = new System.Drawing.Size(53, 13);
            this.lbl_firmaadi.TabIndex = 1;
            this.lbl_firmaadi.Text = "Firma Adi:";
            // 
            // cmbx_firmaadi
            // 
            this.cmbx_firmaadi.FormattingEnabled = true;
            this.cmbx_firmaadi.Location = new System.Drawing.Point(96, 29);
            this.cmbx_firmaadi.Name = "cmbx_firmaadi";
            this.cmbx_firmaadi.Size = new System.Drawing.Size(121, 21);
            this.cmbx_firmaadi.TabIndex = 6;
            // 
            // cmbx_urunadi
            // 
            this.cmbx_urunadi.FormattingEnabled = true;
            this.cmbx_urunadi.Location = new System.Drawing.Point(96, 84);
            this.cmbx_urunadi.Name = "cmbx_urunadi";
            this.cmbx_urunadi.Size = new System.Drawing.Size(121, 21);
            this.cmbx_urunadi.TabIndex = 8;
            this.cmbx_urunadi.SelectedIndexChanged += new System.EventHandler(this.cmbx_urunadi_SelectedIndexChanged);
            // 
            // lbl_urunkodu
            // 
            this.lbl_urunkodu.AutoSize = true;
            this.lbl_urunkodu.Location = new System.Drawing.Point(7, 92);
            this.lbl_urunkodu.Name = "lbl_urunkodu";
            this.lbl_urunkodu.Size = new System.Drawing.Size(61, 13);
            this.lbl_urunkodu.TabIndex = 7;
            this.lbl_urunkodu.Text = "Ürün Kodu:";
            // 
            // txt_giristarihi
            // 
            this.txt_giristarihi.Location = new System.Drawing.Point(96, 136);
            this.txt_giristarihi.Name = "txt_giristarihi";
            this.txt_giristarihi.Size = new System.Drawing.Size(121, 20);
            this.txt_giristarihi.TabIndex = 10;
            // 
            // lbl_giristarihi
            // 
            this.lbl_giristarihi.AutoSize = true;
            this.lbl_giristarihi.Location = new System.Drawing.Point(7, 143);
            this.lbl_giristarihi.Name = "lbl_giristarihi";
            this.lbl_giristarihi.Size = new System.Drawing.Size(59, 13);
            this.lbl_giristarihi.TabIndex = 9;
            this.lbl_giristarihi.Text = "Giriş Tarihi:";
            // 
            // txt_adet
            // 
            this.txt_adet.Location = new System.Drawing.Point(96, 192);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(121, 20);
            this.txt_adet.TabIndex = 12;
            // 
            // lbl_adet
            // 
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Location = new System.Drawing.Point(6, 199);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(58, 13);
            this.lbl_adet.TabIndex = 11;
            this.lbl_adet.Text = "Ürün Adet:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 354);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpbx_islem);
            this.Controls.Add(this.pctrbx_resim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "ÜRETİM ÇIKIŞ";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_resim)).EndInit();
            this.grpbx_islem.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pctrbx_resim;
        private System.Windows.Forms.GroupBox grpbx_islem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lbl_firmaadi;
        private System.Windows.Forms.ComboBox cmbx_firmaadi;
        private System.Windows.Forms.ComboBox cmbx_urunadi;
        private System.Windows.Forms.Label lbl_urunkodu;
        private System.Windows.Forms.TextBox txt_giristarihi;
        private System.Windows.Forms.Label lbl_giristarihi;
        private System.Windows.Forms.TextBox txt_adet;
        private System.Windows.Forms.Label lbl_adet;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}