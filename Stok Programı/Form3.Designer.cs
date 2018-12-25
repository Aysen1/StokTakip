namespace Stok_Programı
{
    partial class Form3
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
            this.grpbx_urunbilgileri = new System.Windows.Forms.GroupBox();
            this.txt_kayit_tarihi = new System.Windows.Forms.TextBox();
            this.txt_urun_kodu = new System.Windows.Forms.TextBox();
            this.cmbbx_firma_adi = new System.Windows.Forms.ComboBox();
            this.lbl_kayıt_tarihi = new System.Windows.Forms.Label();
            this.lbl_urun_kodu = new System.Windows.Forms.Label();
            this.lbl_FirmaAdi = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stoklarıRaporlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpbx_islemler = new System.Windows.Forms.GroupBox();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.grpbx_resim = new System.Windows.Forms.GroupBox();
            this.pctrbx_urunresim = new System.Windows.Forms.PictureBox();
            this.btn_resim_sil = new System.Windows.Forms.Button();
            this.btn_resim_yukle = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.grpbx_urunbilgileri.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grpbx_islemler.SuspendLayout();
            this.grpbx_resim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_urunresim)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbx_urunbilgileri
            // 
            this.grpbx_urunbilgileri.Controls.Add(this.tableLayoutPanel2);
            this.grpbx_urunbilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_urunbilgileri.Location = new System.Drawing.Point(3, 3);
            this.grpbx_urunbilgileri.Name = "grpbx_urunbilgileri";
            this.grpbx_urunbilgileri.Size = new System.Drawing.Size(271, 186);
            this.grpbx_urunbilgileri.TabIndex = 0;
            this.grpbx_urunbilgileri.TabStop = false;
            this.grpbx_urunbilgileri.Text = "Ürün Bilgileri";
            // 
            // txt_kayit_tarihi
            // 
            this.txt_kayit_tarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_kayit_tarihi.Location = new System.Drawing.Point(135, 128);
            this.txt_kayit_tarihi.Name = "txt_kayit_tarihi";
            this.txt_kayit_tarihi.Size = new System.Drawing.Size(127, 20);
            this.txt_kayit_tarihi.TabIndex = 5;
            // 
            // txt_urun_kodu
            // 
            this.txt_urun_kodu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_urun_kodu.Location = new System.Drawing.Point(135, 72);
            this.txt_urun_kodu.Name = "txt_urun_kodu";
            this.txt_urun_kodu.Size = new System.Drawing.Size(127, 20);
            this.txt_urun_kodu.TabIndex = 4;
            this.txt_urun_kodu.TextChanged += new System.EventHandler(this.txt_urun_kodu_TextChanged);
            // 
            // cmbbx_firma_adi
            // 
            this.cmbbx_firma_adi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbbx_firma_adi.FormattingEnabled = true;
            this.cmbbx_firma_adi.Location = new System.Drawing.Point(135, 17);
            this.cmbbx_firma_adi.Name = "cmbbx_firma_adi";
            this.cmbbx_firma_adi.Size = new System.Drawing.Size(127, 21);
            this.cmbbx_firma_adi.TabIndex = 3;
            // 
            // lbl_kayıt_tarihi
            // 
            this.lbl_kayıt_tarihi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_kayıt_tarihi.AutoSize = true;
            this.lbl_kayıt_tarihi.Location = new System.Drawing.Point(3, 132);
            this.lbl_kayıt_tarihi.Name = "lbl_kayıt_tarihi";
            this.lbl_kayıt_tarihi.Size = new System.Drawing.Size(126, 13);
            this.lbl_kayıt_tarihi.TabIndex = 2;
            this.lbl_kayıt_tarihi.Text = "Kayıt Tarihi:";
            // 
            // lbl_urun_kodu
            // 
            this.lbl_urun_kodu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_urun_kodu.AutoSize = true;
            this.lbl_urun_kodu.Location = new System.Drawing.Point(3, 76);
            this.lbl_urun_kodu.Name = "lbl_urun_kodu";
            this.lbl_urun_kodu.Size = new System.Drawing.Size(126, 13);
            this.lbl_urun_kodu.TabIndex = 1;
            this.lbl_urun_kodu.Text = "Ürün Kodu:";
            // 
            // lbl_FirmaAdi
            // 
            this.lbl_FirmaAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FirmaAdi.AutoSize = true;
            this.lbl_FirmaAdi.Location = new System.Drawing.Point(3, 21);
            this.lbl_FirmaAdi.Name = "lbl_FirmaAdi";
            this.lbl_FirmaAdi.Size = new System.Drawing.Size(126, 13);
            this.lbl_FirmaAdi.TabIndex = 0;
            this.lbl_FirmaAdi.Text = "Firma Adı:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anaToolStripMenuItem,
            this.ürünleriToolStripMenuItem,
            this.stoklarıRaporlaToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.cikisToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(560, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anaToolStripMenuItem
            // 
            this.anaToolStripMenuItem.Name = "anaToolStripMenuItem";
            this.anaToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.anaToolStripMenuItem.Text = "Anasayfa";
            this.anaToolStripMenuItem.Click += new System.EventHandler(this.anaToolStripMenuItem_Click);
            // 
            // ürünleriToolStripMenuItem
            // 
            this.ürünleriToolStripMenuItem.Name = "ürünleriToolStripMenuItem";
            this.ürünleriToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.ürünleriToolStripMenuItem.Text = "Ürün Listesi";
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
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // cikisToolStripMenuItem
            // 
            this.cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            this.cikisToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            // 
            // grpbx_islemler
            // 
            this.grpbx_islemler.Controls.Add(this.tableLayoutPanel1);
            this.grpbx_islemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_islemler.Location = new System.Drawing.Point(3, 201);
            this.grpbx_islemler.Name = "grpbx_islemler";
            this.grpbx_islemler.Size = new System.Drawing.Size(554, 60);
            this.grpbx_islemler.TabIndex = 2;
            this.grpbx_islemler.TabStop = false;
            this.grpbx_islemler.Text = "İşlemler";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_kaydet.Location = new System.Drawing.Point(373, 9);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 23);
            this.btn_kaydet.TabIndex = 1;
            this.btn_kaydet.Text = "KAYDET";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_temizle.Location = new System.Drawing.Point(99, 9);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 23);
            this.btn_temizle.TabIndex = 0;
            this.btn_temizle.Text = "TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // grpbx_resim
            // 
            this.grpbx_resim.Controls.Add(this.tableLayoutPanel3);
            this.grpbx_resim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_resim.Location = new System.Drawing.Point(280, 3);
            this.grpbx_resim.Name = "grpbx_resim";
            this.grpbx_resim.Size = new System.Drawing.Size(271, 186);
            this.grpbx_resim.TabIndex = 3;
            this.grpbx_resim.TabStop = false;
            this.grpbx_resim.Text = "Ürün Görseli";
            // 
            // pctrbx_urunresim
            // 
            this.pctrbx_urunresim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrbx_urunresim.BackColor = System.Drawing.SystemColors.Control;
            this.pctrbx_urunresim.Location = new System.Drawing.Point(82, 7);
            this.pctrbx_urunresim.Name = "pctrbx_urunresim";
            this.pctrbx_urunresim.Size = new System.Drawing.Size(100, 100);
            this.pctrbx_urunresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbx_urunresim.TabIndex = 4;
            this.pctrbx_urunresim.TabStop = false;
            // 
            // btn_resim_sil
            // 
            this.btn_resim_sil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_resim_sil.Location = new System.Drawing.Point(156, 11);
            this.btn_resim_sil.Name = "btn_resim_sil";
            this.btn_resim_sil.Size = new System.Drawing.Size(75, 23);
            this.btn_resim_sil.TabIndex = 3;
            this.btn_resim_sil.Text = "Resim Sil";
            this.btn_resim_sil.UseVisualStyleBackColor = true;
            this.btn_resim_sil.Click += new System.EventHandler(this.btn_resim_sil_Click);
            // 
            // btn_resim_yukle
            // 
            this.btn_resim_yukle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_resim_yukle.Location = new System.Drawing.Point(27, 11);
            this.btn_resim_yukle.Name = "btn_resim_yukle";
            this.btn_resim_yukle.Size = new System.Drawing.Size(75, 23);
            this.btn_resim_yukle.TabIndex = 2;
            this.btn_resim_yukle.Text = "Resim Yükle";
            this.btn_resim_yukle.UseVisualStyleBackColor = true;
            this.btn_resim_yukle.Click += new System.EventHandler(this.btn_resim_yukle_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 288);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(560, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 17);
            this.toolStripStatusLabel1.Text = "timer";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_temizle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_kaydet, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(548, 41);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txt_kayit_tarihi, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lbl_FirmaAdi, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_kayıt_tarihi, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.txt_urun_kodu, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbbx_firma_adi, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_urun_kodu, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(265, 167);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.pctrbx_urunresim, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.01408F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.98592F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(265, 167);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btn_resim_sil, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_resim_yukle, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 118);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(259, 46);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.grpbx_islemler, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(560, 264);
            this.tableLayoutPanel5.TabIndex = 5;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.grpbx_urunbilgileri, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.grpbx_resim, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(554, 192);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // Form3
            // 
            this.AcceptButton = this.btn_kaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 310);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(576, 349);
            this.Name = "Form3";
            this.Text = "ÜRÜN KAYIT FORMU";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.grpbx_urunbilgileri.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpbx_islemler.ResumeLayout(false);
            this.grpbx_resim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_urunresim)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbx_urunbilgileri;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stoklarıRaporlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpbx_islemler;
        private System.Windows.Forms.GroupBox grpbx_resim;
        private System.Windows.Forms.TextBox txt_kayit_tarihi;
        private System.Windows.Forms.TextBox txt_urun_kodu;
        private System.Windows.Forms.ComboBox cmbbx_firma_adi;
        private System.Windows.Forms.Label lbl_kayıt_tarihi;
        private System.Windows.Forms.Label lbl_urun_kodu;
        private System.Windows.Forms.Label lbl_FirmaAdi;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.PictureBox pctrbx_urunresim;
        private System.Windows.Forms.Button btn_resim_sil;
        private System.Windows.Forms.Button btn_resim_yukle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}