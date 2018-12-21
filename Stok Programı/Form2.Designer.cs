namespace Stok_Programı
{
    partial class Form2
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
            this.stoklarıRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbx_ürün_bilg = new System.Windows.Forms.GroupBox();
            this.txt_miktar = new System.Windows.Forms.TextBox();
            this.txt_fiyat = new System.Windows.Forms.TextBox();
            this.txt_barkod = new System.Windows.Forms.TextBox();
            this.txt_urun_ismi = new System.Windows.Forms.TextBox();
            this.txt_urun_kod = new System.Windows.Forms.TextBox();
            this.lbl_miktar = new System.Windows.Forms.Label();
            this.lbl_fiyat = new System.Windows.Forms.Label();
            this.lbl_barkod = new System.Windows.Forms.Label();
            this.lbl_urun_ismi = new System.Windows.Forms.Label();
            this.lbl_urun_kod = new System.Windows.Forms.Label();
            this.grpbx_islemler = new System.Windows.Forms.GroupBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_yeni = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.grpbx_ürün_bilg.SuspendLayout();
            this.grpbx_islemler.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(341, 24);
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
            this.stoklarıRaporlaToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.stoklarıRaporlaToolStripMenuItem.Text = "Stok Raporu";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // grpbx_ürün_bilg
            // 
            this.grpbx_ürün_bilg.Controls.Add(this.txt_miktar);
            this.grpbx_ürün_bilg.Controls.Add(this.txt_fiyat);
            this.grpbx_ürün_bilg.Controls.Add(this.txt_barkod);
            this.grpbx_ürün_bilg.Controls.Add(this.txt_urun_ismi);
            this.grpbx_ürün_bilg.Controls.Add(this.txt_urun_kod);
            this.grpbx_ürün_bilg.Controls.Add(this.lbl_miktar);
            this.grpbx_ürün_bilg.Controls.Add(this.lbl_fiyat);
            this.grpbx_ürün_bilg.Controls.Add(this.lbl_barkod);
            this.grpbx_ürün_bilg.Controls.Add(this.lbl_urun_ismi);
            this.grpbx_ürün_bilg.Controls.Add(this.lbl_urun_kod);
            this.grpbx_ürün_bilg.Location = new System.Drawing.Point(12, 42);
            this.grpbx_ürün_bilg.Name = "grpbx_ürün_bilg";
            this.grpbx_ürün_bilg.Size = new System.Drawing.Size(207, 197);
            this.grpbx_ürün_bilg.TabIndex = 1;
            this.grpbx_ürün_bilg.TabStop = false;
            this.grpbx_ürün_bilg.Text = "Ürün Bilgileri";
            // 
            // txt_miktar
            // 
            this.txt_miktar.Location = new System.Drawing.Point(93, 152);
            this.txt_miktar.Name = "txt_miktar";
            this.txt_miktar.Size = new System.Drawing.Size(100, 20);
            this.txt_miktar.TabIndex = 9;
            // 
            // txt_fiyat
            // 
            this.txt_fiyat.Location = new System.Drawing.Point(93, 122);
            this.txt_fiyat.Name = "txt_fiyat";
            this.txt_fiyat.Size = new System.Drawing.Size(100, 20);
            this.txt_fiyat.TabIndex = 8;
            // 
            // txt_barkod
            // 
            this.txt_barkod.Location = new System.Drawing.Point(93, 88);
            this.txt_barkod.Name = "txt_barkod";
            this.txt_barkod.Size = new System.Drawing.Size(100, 20);
            this.txt_barkod.TabIndex = 7;
            // 
            // txt_urun_ismi
            // 
            this.txt_urun_ismi.Location = new System.Drawing.Point(93, 55);
            this.txt_urun_ismi.Name = "txt_urun_ismi";
            this.txt_urun_ismi.Size = new System.Drawing.Size(100, 20);
            this.txt_urun_ismi.TabIndex = 6;
            // 
            // txt_urun_kod
            // 
            this.txt_urun_kod.Location = new System.Drawing.Point(93, 23);
            this.txt_urun_kod.Name = "txt_urun_kod";
            this.txt_urun_kod.Size = new System.Drawing.Size(100, 20);
            this.txt_urun_kod.TabIndex = 5;
            // 
            // lbl_miktar
            // 
            this.lbl_miktar.AutoSize = true;
            this.lbl_miktar.Location = new System.Drawing.Point(6, 159);
            this.lbl_miktar.Name = "lbl_miktar";
            this.lbl_miktar.Size = new System.Drawing.Size(41, 13);
            this.lbl_miktar.TabIndex = 4;
            this.lbl_miktar.Text = "Miktarı:";
            // 
            // lbl_fiyat
            // 
            this.lbl_fiyat.AutoSize = true;
            this.lbl_fiyat.Location = new System.Drawing.Point(6, 129);
            this.lbl_fiyat.Name = "lbl_fiyat";
            this.lbl_fiyat.Size = new System.Drawing.Size(59, 13);
            this.lbl_fiyat.TabIndex = 3;
            this.lbl_fiyat.Text = "Birim Fiyatı:";
            // 
            // lbl_barkod
            // 
            this.lbl_barkod.AutoSize = true;
            this.lbl_barkod.Location = new System.Drawing.Point(6, 95);
            this.lbl_barkod.Name = "lbl_barkod";
            this.lbl_barkod.Size = new System.Drawing.Size(61, 13);
            this.lbl_barkod.TabIndex = 2;
            this.lbl_barkod.Text = "Barkod No:";
            // 
            // lbl_urun_ismi
            // 
            this.lbl_urun_ismi.AutoSize = true;
            this.lbl_urun_ismi.Location = new System.Drawing.Point(6, 62);
            this.lbl_urun_ismi.Name = "lbl_urun_ismi";
            this.lbl_urun_ismi.Size = new System.Drawing.Size(54, 13);
            this.lbl_urun_ismi.TabIndex = 1;
            this.lbl_urun_ismi.Text = "Ürün İsmi:";
            // 
            // lbl_urun_kod
            // 
            this.lbl_urun_kod.AutoSize = true;
            this.lbl_urun_kod.Location = new System.Drawing.Point(6, 30);
            this.lbl_urun_kod.Name = "lbl_urun_kod";
            this.lbl_urun_kod.Size = new System.Drawing.Size(61, 13);
            this.lbl_urun_kod.TabIndex = 0;
            this.lbl_urun_kod.Text = "Ürün Kodu:";
            // 
            // grpbx_islemler
            // 
            this.grpbx_islemler.Controls.Add(this.btn_cikis);
            this.grpbx_islemler.Controls.Add(this.btn_yeni);
            this.grpbx_islemler.Controls.Add(this.btn_sil);
            this.grpbx_islemler.Controls.Add(this.btn_kaydet);
            this.grpbx_islemler.Location = new System.Drawing.Point(240, 42);
            this.grpbx_islemler.Name = "grpbx_islemler";
            this.grpbx_islemler.Size = new System.Drawing.Size(94, 197);
            this.grpbx_islemler.TabIndex = 2;
            this.grpbx_islemler.TabStop = false;
            this.grpbx_islemler.Text = "İşlemler";
            // 
            // btn_cikis
            // 
            this.btn_cikis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cikis.Location = new System.Drawing.Point(13, 149);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(75, 23);
            this.btn_cikis.TabIndex = 3;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_yeni
            // 
            this.btn_yeni.Location = new System.Drawing.Point(13, 107);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(75, 23);
            this.btn_yeni.TabIndex = 2;
            this.btn_yeni.Text = "YENİ ÜRÜN";
            this.btn_yeni.UseVisualStyleBackColor = true;
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(13, 65);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_sil.TabIndex = 1;
            this.btn_sil.Text = "SATIŞ";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(13, 20);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 0;
            this.btn_kaydet.Text = "EKLE";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 243);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(341, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel1.Text = "timer";
            // 
            // Form2
            // 
            this.AcceptButton = this.btn_kaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cikis;
            this.ClientSize = new System.Drawing.Size(341, 265);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpbx_islemler);
            this.Controls.Add(this.grpbx_ürün_bilg);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Stok Takip";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpbx_ürün_bilg.ResumeLayout(false);
            this.grpbx_ürün_bilg.PerformLayout();
            this.grpbx_islemler.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stoklarıRaporlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpbx_ürün_bilg;
        private System.Windows.Forms.TextBox txt_miktar;
        private System.Windows.Forms.TextBox txt_fiyat;
        private System.Windows.Forms.TextBox txt_barkod;
        private System.Windows.Forms.TextBox txt_urun_ismi;
        private System.Windows.Forms.TextBox txt_urun_kod;
        private System.Windows.Forms.Label lbl_miktar;
        private System.Windows.Forms.Label lbl_fiyat;
        private System.Windows.Forms.Label lbl_barkod;
        private System.Windows.Forms.Label lbl_urun_ismi;
        private System.Windows.Forms.Label lbl_urun_kod;
        private System.Windows.Forms.GroupBox grpbx_islemler;
        private System.Windows.Forms.Button btn_yeni;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btn_cikis;
    }
}