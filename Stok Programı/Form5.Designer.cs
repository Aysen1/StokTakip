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
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_firmaadi = new System.Windows.Forms.Label();
            this.txt_adet = new System.Windows.Forms.TextBox();
            this.cmbx_firmaadi = new System.Windows.Forms.ComboBox();
            this.lbl_adet = new System.Windows.Forms.Label();
            this.lbl_urunkodu = new System.Windows.Forms.Label();
            this.txt_giristarihi = new System.Windows.Forms.TextBox();
            this.cmbx_urunadi = new System.Windows.Forms.ComboBox();
            this.lbl_giristarihi = new System.Windows.Forms.Label();
            this.pctrbx_resim = new System.Windows.Forms.PictureBox();
            this.grpbx_islem = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_resim)).BeginInit();
            this.grpbx_islem.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anasayfaToolStripMenuItem,
            this.ürünListesiToolStripMenuItem,
            this.stokRaporuToolStripMenuItem,
            this.yardımToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(524, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // anasayfaToolStripMenuItem
            // 
            this.anasayfaToolStripMenuItem.Name = "anasayfaToolStripMenuItem";
            this.anasayfaToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.anasayfaToolStripMenuItem.Text = "Anasayfa";
            this.anasayfaToolStripMenuItem.Click += new System.EventHandler(this.anasayfaToolStripMenuItem_Click);
            // 
            // ürünListesiToolStripMenuItem
            // 
            this.ürünListesiToolStripMenuItem.Name = "ürünListesiToolStripMenuItem";
            this.ürünListesiToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ürünListesiToolStripMenuItem.Text = "Ürün Listesi";
            // 
            // stokRaporuToolStripMenuItem
            // 
            this.stokRaporuToolStripMenuItem.Name = "stokRaporuToolStripMenuItem";
            this.stokRaporuToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.stokRaporuToolStripMenuItem.Text = "Stok Raporu";
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            this.yardımToolStripMenuItem.Click += new System.EventHandler(this.yardımToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 311);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_firmaadi, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_adet, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cmbx_firmaadi, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbl_adet, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_urunkodu, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_giristarihi, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cmbx_urunadi, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbl_giristarihi, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 292);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // lbl_firmaadi
            // 
            this.lbl_firmaadi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_firmaadi.AutoSize = true;
            this.lbl_firmaadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_firmaadi.Location = new System.Drawing.Point(34, 30);
            this.lbl_firmaadi.Name = "lbl_firmaadi";
            this.lbl_firmaadi.Size = new System.Drawing.Size(63, 13);
            this.lbl_firmaadi.TabIndex = 1;
            this.lbl_firmaadi.Text = "Firma Adi:";
            // 
            // txt_adet
            // 
            this.txt_adet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_adet.Location = new System.Drawing.Point(164, 245);
            this.txt_adet.Name = "txt_adet";
            this.txt_adet.Size = new System.Drawing.Size(121, 20);
            this.txt_adet.TabIndex = 12;
            // 
            // cmbx_firmaadi
            // 
            this.cmbx_firmaadi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbx_firmaadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbx_firmaadi.FormattingEnabled = true;
            this.cmbx_firmaadi.Location = new System.Drawing.Point(164, 26);
            this.cmbx_firmaadi.Name = "cmbx_firmaadi";
            this.cmbx_firmaadi.Size = new System.Drawing.Size(121, 21);
            this.cmbx_firmaadi.TabIndex = 6;
            // 
            // lbl_adet
            // 
            this.lbl_adet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_adet.AutoSize = true;
            this.lbl_adet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adet.Location = new System.Drawing.Point(29, 249);
            this.lbl_adet.Name = "lbl_adet";
            this.lbl_adet.Size = new System.Drawing.Size(68, 13);
            this.lbl_adet.TabIndex = 11;
            this.lbl_adet.Text = "Ürün Adet:";
            // 
            // lbl_urunkodu
            // 
            this.lbl_urunkodu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_urunkodu.AutoSize = true;
            this.lbl_urunkodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_urunkodu.Location = new System.Drawing.Point(26, 103);
            this.lbl_urunkodu.Name = "lbl_urunkodu";
            this.lbl_urunkodu.Size = new System.Drawing.Size(71, 13);
            this.lbl_urunkodu.TabIndex = 7;
            this.lbl_urunkodu.Text = "Ürün Kodu:";
            // 
            // txt_giristarihi
            // 
            this.txt_giristarihi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txt_giristarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_giristarihi.Location = new System.Drawing.Point(164, 172);
            this.txt_giristarihi.Name = "txt_giristarihi";
            this.txt_giristarihi.Size = new System.Drawing.Size(121, 20);
            this.txt_giristarihi.TabIndex = 10;
            // 
            // cmbx_urunadi
            // 
            this.cmbx_urunadi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cmbx_urunadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbx_urunadi.FormattingEnabled = true;
            this.cmbx_urunadi.Location = new System.Drawing.Point(164, 99);
            this.cmbx_urunadi.Name = "cmbx_urunadi";
            this.cmbx_urunadi.Size = new System.Drawing.Size(121, 21);
            this.cmbx_urunadi.TabIndex = 8;
            this.cmbx_urunadi.SelectedIndexChanged += new System.EventHandler(this.cmbx_urunadi_SelectedIndexChanged);
            // 
            // lbl_giristarihi
            // 
            this.lbl_giristarihi.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_giristarihi.AutoSize = true;
            this.lbl_giristarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_giristarihi.Location = new System.Drawing.Point(27, 176);
            this.lbl_giristarihi.Name = "lbl_giristarihi";
            this.lbl_giristarihi.Size = new System.Drawing.Size(70, 13);
            this.lbl_giristarihi.TabIndex = 9;
            this.lbl_giristarihi.Text = "ÇıkışTarihi:";
            // 
            // pctrbx_resim
            // 
            this.pctrbx_resim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pctrbx_resim.Location = new System.Drawing.Point(359, 108);
            this.pctrbx_resim.Name = "pctrbx_resim";
            this.pctrbx_resim.Size = new System.Drawing.Size(100, 100);
            this.pctrbx_resim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbx_resim.TabIndex = 2;
            this.pctrbx_resim.TabStop = false;
            // 
            // grpbx_islem
            // 
            this.grpbx_islem.Controls.Add(this.tableLayoutPanel4);
            this.grpbx_islem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpbx_islem.Location = new System.Drawing.Point(3, 326);
            this.grpbx_islem.Name = "grpbx_islem";
            this.grpbx_islem.Size = new System.Drawing.Size(518, 66);
            this.grpbx_islem.TabIndex = 2;
            this.grpbx_islem.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btn_temizle, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btn_kaydet, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(512, 47);
            this.tableLayoutPanel4.TabIndex = 5;
            // 
            // btn_temizle
            // 
            this.btn_temizle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_temizle.FlatAppearance.BorderSize = 0;
            this.btn_temizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_temizle.Location = new System.Drawing.Point(90, 3);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(75, 40);
            this.btn_temizle.TabIndex = 0;
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_kaydet.FlatAppearance.BorderSize = 0;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.Location = new System.Drawing.Point(346, 3);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(75, 40);
            this.btn_kaydet.TabIndex = 1;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(524, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.93734F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.grpbx_islem, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.78808F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.21192F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 395);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pctrbx_resim, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(518, 317);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // Form5
            // 
            this.AcceptButton = this.btn_kaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(524, 446);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(540, 485);
            this.Name = "Form5";
            this.Text = "ÜRETİM ÇIKIŞ";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_resim)).EndInit();
            this.grpbx_islem.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}