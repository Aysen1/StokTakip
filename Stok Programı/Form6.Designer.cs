namespace Stok_Programı
{
    partial class Form6
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
            this.btn_urun = new System.Windows.Forms.Button();
            this.btn_firma = new System.Windows.Forms.Button();
            this.btn_giris = new System.Windows.Forms.Button();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.anasayfaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stokRaporuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_stok = new System.Windows.Forms.Button();
            this.btn_ayarlar = new System.Windows.Forms.Button();
            this.pctrbx_logo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_urun
            // 
            this.btn_urun.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_urun.FlatAppearance.BorderSize = 0;
            this.btn_urun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_urun.Location = new System.Drawing.Point(3, 8);
            this.btn_urun.Name = "btn_urun";
            this.btn_urun.Size = new System.Drawing.Size(147, 84);
            this.btn_urun.TabIndex = 0;
            this.btn_urun.UseVisualStyleBackColor = true;
            this.btn_urun.Click += new System.EventHandler(this.btn_urun_Click);
            // 
            // btn_firma
            // 
            this.btn_firma.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_firma.FlatAppearance.BorderSize = 0;
            this.btn_firma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_firma.Location = new System.Drawing.Point(3, 109);
            this.btn_firma.Name = "btn_firma";
            this.btn_firma.Size = new System.Drawing.Size(147, 84);
            this.btn_firma.TabIndex = 1;
            this.btn_firma.UseVisualStyleBackColor = true;
            this.btn_firma.Click += new System.EventHandler(this.btn_firma_Click);
            // 
            // btn_giris
            // 
            this.btn_giris.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_giris.FlatAppearance.BorderSize = 0;
            this.btn_giris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_giris.Location = new System.Drawing.Point(159, 8);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(147, 84);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // btn_cikis
            // 
            this.btn_cikis.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_cikis.FlatAppearance.BorderSize = 0;
            this.btn_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cikis.Location = new System.Drawing.Point(315, 8);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(147, 84);
            this.btn_cikis.TabIndex = 3;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(506, 24);
            this.menuStrip1.TabIndex = 4;
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 297);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(506, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel1.Text = "timer";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 155F));
            this.tableLayoutPanel1.Controls.Add(this.btn_urun, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_cikis, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_firma, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_giris, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_stok, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_ayarlar, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(24, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(464, 202);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // btn_stok
            // 
            this.btn_stok.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_stok.FlatAppearance.BorderSize = 0;
            this.btn_stok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stok.Location = new System.Drawing.Point(159, 109);
            this.btn_stok.Name = "btn_stok";
            this.btn_stok.Size = new System.Drawing.Size(147, 84);
            this.btn_stok.TabIndex = 5;
            this.btn_stok.UseVisualStyleBackColor = true;
            // 
            // btn_ayarlar
            // 
            this.btn_ayarlar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_ayarlar.FlatAppearance.BorderSize = 0;
            this.btn_ayarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ayarlar.Location = new System.Drawing.Point(315, 109);
            this.btn_ayarlar.Name = "btn_ayarlar";
            this.btn_ayarlar.Size = new System.Drawing.Size(147, 84);
            this.btn_ayarlar.TabIndex = 4;
            this.btn_ayarlar.UseVisualStyleBackColor = true;
            // 
            // pctrbx_logo
            // 
            this.pctrbx_logo.Location = new System.Drawing.Point(24, 27);
            this.pctrbx_logo.Name = "pctrbx_logo";
            this.pctrbx_logo.Size = new System.Drawing.Size(248, 40);
            this.pctrbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrbx_logo.TabIndex = 7;
            this.pctrbx_logo.TabStop = false;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 319);
            this.Controls.Add(this.pctrbx_logo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(522, 358);
            this.Name = "Form6";
            this.Text = "ANA İŞLEM PANELİ";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_urun;
        private System.Windows.Forms.Button btn_firma;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem anasayfaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stokRaporuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_ayarlar;
        private System.Windows.Forms.Button btn_stok;
        private System.Windows.Forms.PictureBox pctrbx_logo;
    }
}