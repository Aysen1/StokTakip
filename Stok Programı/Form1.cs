using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Drawing.Printing;
using System.IO;
using System.Management;

namespace Stok_Programı
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        string resimpath;
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand( "select * from KullaniciBilgileri where convert(Varchar, KullaniciAdi)='"+ txt_kullanici_isim.Text +"' and convert(Varchar, KullaniciSifre)='"+ txt_kullanici_sifre.Text +"'");
            komut.Connection = baglanti;
            SqlDataReader data = komut.ExecuteReader();
            menuStrip1.Visible = true;
            if (data.Read())
            {
                /*Form6 form6 = new Form6();
                form6.Show();
                this.Hide();*/
                panel1.Visible = false;
                panel2.Anchor = AnchorStyles.Top - Left;
                panel2.Visible = true;
                pctr_logo.Image = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\logo.jpeg");

                excelDokümanıToolStripMenuItem.Visible = false;
                dilTercihiToolStripMenuItem.Visible = false;

                if (Properties.Settings.Default.dil == "İngilizce")
                {
                    Localization.Culture = new CultureInfo("en-US");
                    this.Text = Localization.form6;
                    btn_giriss.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\urungirisK.fw.png");
                    btn_cikis.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\uruncikisK.fw.png");
                    btn_urun.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\ukayitK.fw.png");
                    btn_firma.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\firmaK.fw.png");
                    btn_stok.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\stokK.fw.png");
                    btn_araclar.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\araclarK.fw.png");
                    btn_ayarlar.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\ayarlarK.fw.png");
                    anasayfaToolStripMenuItem.Text = Localization.lbl_anasayfa;
                    yardımToolStripMenuItem.Text = Localization.lbl_yardim;
                    çıkışToolStripMenuItem.Text = Localization.lbl_cikis;
                }
                else if (Properties.Settings.Default.dil == "Türkçe")
                {
                    Localization.Culture = new CultureInfo("");
                    this.Text = Localization.form6;
                    btn_giriss.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\urungiris.fw.png");
                    btn_cikis.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\uruncikis.fw.png");
                    btn_urun.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\ukayit.fw.png");
                    btn_firma.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\firma.fw.png");
                    btn_stok.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\stok.fw.png");
                    btn_araclar.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\araclar.fw.png");
                    btn_ayarlar.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\ayarlar.fw.png");
                }
                timer1.Start();
                lbl_destek.Text = DateTime.Now.ToString();      
                lbl_versiyon.Visible = false;
                lbl_nfm.Visible = false;

            }
            else
                MessageBox.Show( "Girilen Bilgiler Hatalıdır!Tekrar Deneyiniz.");
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            baglanti = new SqlConnection("Data Source=NFM-1\\MSSQLSERVER01; Integrated Security=TRUE; Initial Catalog=StokTakip");
            lbl_versiyon.Text = Application.ProductVersion;
            lbl_nfm.Text = "NFM AJANS SAN. VE TIC. LTD. STI";
            lbl_destek.Text = "Destek Hattı: 0 (236) 231 40 10";
            btn_0.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\b0.fw.png");
            btn_1.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\b1.fw.png");
            btn_2.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\b2.fw.png");
            btn_3.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\b3.fw.png");
            btn_4.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\b4.fw.png");
            btn_5.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\b5.fw.png");
            btn_6.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\b6.fw.png");
            btn_7.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\b7.fw.png");
            btn_8.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\b8.fw.png");
            btn_9.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\b9.fw.png");
            btn_simge.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\simge.fw.png");
            btn_tamekran.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\tamekran.fw.png");
            btn_cikiss.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\cikis.fw.png");
            pctrbx_logo.Image = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\logo.jpeg");

            GraphicsPath gp1 = new GraphicsPath();
            gp1.AddEllipse(0, 0, btn_simge.Width - 1, btn_simge.Height - 1);
            Region rg1 = new Region(gp1);
            btn_simge.Region = rg1; 

            GraphicsPath gp2 = new GraphicsPath();
            gp2.AddEllipse(0, 0, btn_tamekran.Width - 1, btn_tamekran.Height - 1);
            Region rg2 = new Region(gp2);
            btn_tamekran.Region = rg2;

            GraphicsPath gp3 = new GraphicsPath();
            gp3.AddEllipse(0, 0, btn_cikiss.Width - 1, btn_cikiss.Height - 1);
            Region rg3 = new Region(gp3);
            btn_cikiss.Region = rg3;

            if (Properties.Settings.Default.dil == "İngilizce")
            {
                Localization.Culture = new CultureInfo("en-US");
                btn_giris.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\bgirisK.fw.png");
                btn_kapat.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\biptalK.fw.png");
                btn_sil.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\bsilK.fw.png");
                lbl_versiyon.Text = "Version " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
            else if (Properties.Settings.Default.dil == "Türkçe")
            {
                Localization.Culture = new CultureInfo("");
                btn_sil.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\bsil.fw.png");
                btn_giris.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\bgiris.fw.png");
                btn_kapat.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\biptal.fw.png");
                lbl_versiyon.Text = "Versiyon " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
            metin();
           // this.BackColor=Properties.Settings.Default.tema;
            //tableLayoutPanel4.BackColor = Properties.Settings.Default.tema;
            this.BackColor = Color.White;
            tableLayoutPanel4.BackColor = Color.White;
            panel1.Location = new Point(this.ClientSize.Width / 2 - panel1.ClientSize.Width / 2, this.ClientSize.Height / 2 - panel1.ClientSize.Height / 2);
            panel1.Anchor = AnchorStyles.None;

            //System.Diagnostics.Process.Start("osk.exe");
        }
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nfmajans.com/iletisim.html");
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            txt_kullanici_sifre.Text = txt_kullanici_sifre.Text + "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            txt_kullanici_sifre.Text = txt_kullanici_sifre.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            txt_kullanici_sifre.Text = txt_kullanici_sifre.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            txt_kullanici_sifre.Text = txt_kullanici_sifre.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            txt_kullanici_sifre.Text = txt_kullanici_sifre.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_kullanici_sifre.Text = txt_kullanici_sifre.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            txt_kullanici_sifre.Text = txt_kullanici_sifre.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            txt_kullanici_sifre.Text = txt_kullanici_sifre.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            txt_kullanici_sifre.Text = txt_kullanici_sifre.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            txt_kullanici_sifre.Text = txt_kullanici_sifre.Text + "9";
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            txt_kullanici_sifre.Text = "";
        }

        private void btn_simge_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_tamekran_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_cikiss_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void metin()
        {
            lbl_kullanici_adi.Text = Localization.lbl_kullanici_adi;
            this.Text = Localization.form1;
            lbl_kullanicigiris.Text = Localization.lbl_kullanicigiris;
            lbl_sifre.Text = Localization.lbl_sifre;
            lbl_destek.Text = Localization.lbl_destek;
        }
        private GraphicsPath RoundedRectangle(RectangleF rect, float xradius, float yradius,bool round_ul, bool round_ur, bool round_lr, bool round_ll)
        {
            PointF point1, point2;
            GraphicsPath path = new GraphicsPath();
            if (round_ul)
            {
                RectangleF corner = new RectangleF(rect.X, rect.Y, 2 * xradius, 2 * yradius);
                path.AddArc(corner, 180, 90);
                point1 = new PointF(rect.X, rect.Y);
            }
            else
                point1 = new PointF(rect.X, rect.Y);

            if (round_ur)
                point2 = new PointF(rect.Right - xradius, rect.Y);
            else
                point2 = new PointF(rect.Right,rect.Y);
            path.AddLine(point1, point2);

            if (round_ur)
            {
                RectangleF corner = new RectangleF(rect.Right - 2 * xradius, rect.Y, 2 * xradius, 2 * yradius);
                path.AddArc(corner, 270, 90);
                point1 = new PointF(rect.Right, rect.Y + yradius);
            }
            else
                point1 = new PointF(rect.Right,rect.Y);
            if (round_lr)
                point2 = new PointF(rect.Right, rect.Bottom - yradius);
            else
                point2 = new PointF(rect.Right, rect.Bottom);
            path.AddLine(point1, point2);

            if (round_lr)
            {
                RectangleF corner = new RectangleF(rect.Right - 2 * xradius, rect.Bottom - 2 * yradius, 2 * xradius, 2 * yradius);
                path.AddArc(corner, 0, 90);
                point1 = new PointF(rect.Right - xradius, rect.Bottom);
            }
            else
                point1 = new PointF(rect.Right, rect.Bottom);

            if (round_ll)
                point2 = new PointF(rect.X + xradius, rect.Bottom);
            else
                point2 = new PointF(rect.X,rect.Bottom);
            path.AddLine(point1, point2);

            if (round_ll)
            {
                RectangleF corner = new RectangleF(rect.X, rect.Bottom - 2 * yradius, 2 * xradius, 2 * yradius);
                path.AddArc(corner, 90, 90);
                point1 = new PointF(rect.X, rect.Bottom - yradius);
            }
            else
                point1 = new PointF(rect.X,rect.Bottom);

            if (round_ul)
                point2 = new PointF(rect.X, rect.Y + yradius);
            else
                point2 = new PointF(rect.X, rect.Y);
            path.AddLine(point1,point2);

            path.CloseFigure();
            return path;
        }

        private void btn_urun_Click(object sender, EventArgs e)
        {
            panel3.Location = new Point(this.ClientSize.Width/2-panel3.ClientSize.Width/2,this.ClientSize.Height/2-panel3.ClientSize.Height/2);
            panel3.Anchor = AnchorStyles.None;
            panel3.Visible = true;
            panel2.Visible = false;

            txt_urun_kodu.Focus();
            excelDokümanıToolStripMenuItem.Visible = false;
            dilTercihiToolStripMenuItem.Visible = false;
            firma_listele();
            if (Properties.Settings.Default.dil == "İngilizce")
            {
                Localization.Culture = new CultureInfo("en-US");
                btn_temizle.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\temizleK.fw.png");
                btn_kaydet.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\kaydetK.fw.png");
                btn_resim_yukle.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\yukleK.fw.png");
                btn_resim_sil.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\sillK.fw.png");
            }
            else if (Properties.Settings.Default.dil == "Türkçe")
            {
                Localization.Culture = new CultureInfo("");
                btn_temizle.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\temizle.fw.png");
                btn_kaydet.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\kaydet.fw.png");
                btn_resim_yukle.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\yukle.fw.png");
                btn_resim_sil.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\sill.fw.png");
            }
            pctrbx_urunresim.Image = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\barkod.png");
            metin3();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_destek.Text = DateTime.Now.ToString();
            timer1.Start();
            if (panel5.Visible == true)
                txt_cikis5.Text = DateTime.Now.ToString();
            else if (panel4.Visible == true)
                txt_giristarihi.Text = DateTime.Now.ToString();
            else if (panel3.Visible == true)
                txt_kayit_tarihi.Text = DateTime.Now.ToString();
            else if (panel6.Visible == true)
                txt_kayit4.Text = DateTime.Now.ToString();
        }
        private void metin3()
        {
            this.Text = Localization.form3;
            lbl_FirmaAdi.Text = Localization.lbl_firmaadi;
            lbl_urun_kodu.Text = Localization.lbl_urunkodu;
            lbl_kayıt_tarihi.Text = Localization.lbl_kayit;
        }

        private void btn_giriss_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel4.Location = new Point(this.ClientSize.Width/2-panel4.ClientSize.Width/2,this.ClientSize.Height/2-panel4.ClientSize.Height/2);
            panel4.Anchor = AnchorStyles.None;
            panel4.Visible = true;

            dilTercihiToolStripMenuItem.Visible = false;
            excelDokümanıToolStripMenuItem.Visible = true;
            cmbx_urunadi.Focus();
            firma_listele7();

            if (Properties.Settings.Default.dil == "İngilizce")
            {
                Localization.Culture = new CultureInfo("en-US");
                btn_temizle2.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\temizleK.fw.png");
                btn_kaydet2.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\kaydetK.fw.png");
            }
            else if (Properties.Settings.Default.dil == "Türkçe")
            {
                Localization.Culture = new CultureInfo("");
                btn_temizle2.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\temizle.fw.png");
                btn_kaydet2.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\kaydet.fw.png");
            }
            metin7();
            pctrbx_resim.Image = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\barkod.png");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
                txt_kullanici_isim.Focus();
        }
        private void metin7()
        {
            this.Text = Localization.form7;
            anasayfaToolStripMenuItem.Text = Localization.lbl_anasayfa;
            excelDokümanıToolStripMenuItem.Text = Localization.excel_dokumani;
            yardımToolStripMenuItem.Text = Localization.lbl_yardim;
            çıkışToolStripMenuItem.Text = Localization.lbl_cikis;
            lbl_firma.Text = Localization.lbl_firmaadi;
            lbl_urunkodu.Text = Localization.lbl_urunkodu;
            lbl_giristarihi.Text = Localization.giris;
            lbl_adet.Text = Localization.adet;
            lbl_islemm.Text = Localization.islem;
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel5.Location = new Point(this.ClientSize.Width/2 - panel5.ClientSize.Width/2, this.ClientSize.Height/2-panel5.ClientSize.Height/2);
            panel5.Anchor = AnchorStyles.None;
            panel5.Visible = true;

            excelDokümanıToolStripMenuItem.Visible = true;
            dilTercihiToolStripMenuItem.Visible = false;

            cmbx_urunkodu5.Focus();

            firma_listele5();
            urun_listele5();
           

            if (Properties.Settings.Default.dil == "İngilizce")
            {
                Localization.Culture = new CultureInfo("en-US");
                btn_temizle5.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\temizleK.fw.png");
                btn_kaydet5.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\kaydetK.fw.png");
            }
            else if (Properties.Settings.Default.dil == "Türkçe")
            {
                Localization.Culture = new CultureInfo("");
                btn_temizle5.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\temizle.fw.png");
                btn_kaydet5.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\kaydet.fw.png");
            }
            metin5();
            pctrbx_resim5.Image = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\barkod.png");

        }
        private void metin5()
        {
            this.Text = Localization.form5;
            anasayfaToolStripMenuItem.Text = Localization.lbl_anasayfa;
            excelDokümanıToolStripMenuItem.Text = Localization.excel_dokumani;
            yardımToolStripMenuItem.Text = Localization.lbl_yardim;
            çıkışToolStripMenuItem.Text = Localization.lbl_cikis;
            lbl_firma5.Text = Localization.lbl_firmaadi;
            lbl_urunkodu5.Text = Localization.lbl_urunkodu;
            lbl_cikis5.Text = Localization.cikis; ;
            lbl_adet5.Text = Localization.adet;
        }

        private void btn_firma_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel6.Location = new Point(this.ClientSize.Width / 2 - panel6.ClientSize.Width / 2, this.ClientSize.Height / 2 - panel6.ClientSize.Height / 2);
            panel6.Anchor = AnchorStyles.None;
            panel6.Visible = true;


            dilTercihiToolStripMenuItem.Visible = false;
            excelDokümanıToolStripMenuItem.Visible = true;
            txt_firmaadi.Focus();
            il_listele();
            if (Properties.Settings.Default.dil == "İngilizce")
            {
                Localization.Culture = new CultureInfo("en-US");
                btn_temizle4.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\temizleK.fw.png");
                btn_kaydet4.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\kaydetK.fw.png");
            }
            else if (Properties.Settings.Default.dil == "Türkçe")
            {
                Localization.Culture = new CultureInfo("");
                btn_temizle4.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\temizle.fw.png");
                btn_kaydet4.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\kaydet.fw.png");
            }
            metin4();
        }
        private void metin4()
        {
            this.Text = Localization.form4;
            anasayfaToolStripMenuItem.Text = Localization.lbl_anasayfa;
            excelDokümanıToolStripMenuItem.Text = Localization.excel_dokumani;
            yardımToolStripMenuItem.Text = Localization.lbl_yardim;
            çıkışToolStripMenuItem.Text = Localization.lbl_cikis;
            lbl_firma4.Text = Localization.lbl_firmaadi;
            lbl_sorumlu.Text = Localization.sorumlu;
            lbl_telno.Text = Localization.telefon;
            lbl_vergidaire.Text = Localization.vergi;
            lbl_vergino.Text = Localization.vergi_no;
            lbl_mersis.Text = Localization.mersis;
            lbl_il.Text = Localization.il;
            lbl_ilce.Text = Localization.ilce;
            lbl_adres.Text = Localization.adres;
            lbl_kayit_tarihi.Text = Localization.lbl_kayit;
        }

        private void btn_stok_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from UrunKayit", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            string data = null;

            Microsoft.Office.Interop.Excel.Application xl = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = default(Microsoft.Office.Interop.Excel.Workbook);
            wb = xl.Workbooks.Add(@"C:\\Users\\NFM-1PC\\Documents\\Urun Kayit.xls");
            Microsoft.Office.Interop.Excel.Worksheet ws = default(Microsoft.Office.Interop.Excel.Worksheet);
            ws = wb.Worksheets.get_Item(1);

            for (int i = 2; i <= ds.Tables[0].Rows.Count + 1; i++)
            {
                for (int j = 2; j <= ds.Tables[0].Columns.Count + 1; j++)
                {
                    data = ds.Tables[0].Rows[i - 2].ItemArray[j - 2].ToString();
                    ws.Cells[i, j - 1] = data;
                    ws.Cells[i, j - 1].ColumnWidth = 20;
                }
            }
            baglanti.Close();
            xl.Visible = true;
        }

        private void btn_araclar_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel7.Location = new Point(this.ClientSize.Width / 2 - panel7.ClientSize.Width / 2, this.ClientSize.Height / 2 - panel7.ClientSize.Height / 2);
            panel7.Anchor = AnchorStyles.None;
            panel7.Visible = true;

            foreach (String yazici in PrinterSettings.InstalledPrinters)
            {
                cmbx_yazici.Items.Add(yazici);
            }
            PrintDocument pd = new PrintDocument();
            string defaultPrinter = pd.PrinterSettings.PrinterName;
            cmbx_yazici.Text = defaultPrinter;

            if (Properties.Settings.Default.dil == "İngilizce")
                Localization.Culture = new CultureInfo("en-US");
            else if (Properties.Settings.Default.dil == "Türkçe")
                Localization.Culture = new CultureInfo("");
            metin8();
        }
        private void metin8()
        {
            this.Text = Localization.form8;
            lbl_yazici.Text = Localization.yazici;
            btn_bilgi_fisi.Text = Localization.bilgifisi;
            btn_yazici_ekle.Text = Localization.y_ekle;
            anasayfaToolStripMenuItem.Text = Localization.lbl_anasayfa;
            yardımToolStripMenuItem.Text = Localization.lbl_yardim;
            çıkışToolStripMenuItem.Text = Localization.lbl_cikis;
        }
        private void btn_ayarlar_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel8.Location = new Point(this.ClientSize.Width / 2 - panel8.ClientSize.Width / 2, this.ClientSize.Height / 2 - panel8.ClientSize.Height / 2);
            panel8.Anchor = AnchorStyles.None;
            panel8.Visible = true;

            dilTercihiToolStripMenuItem.Visible = true;
            excelDokümanıToolStripMenuItem.Visible = false;

            if (Properties.Settings.Default.dil == "İngilizce")
                Localization.Culture = new CultureInfo("en-US");
            else if (Properties.Settings.Default.dil == "Türkçe")
                Localization.Culture = new CultureInfo("");
            metin9();
        }
        public void metin9()
        {
            this.Text = Localization.ayarlar;
            anasayfaToolStripMenuItem.Text = Localization.lbl_anasayfa;
            dilTercihiToolStripMenuItem.Text = Localization.dil;
            türkçeToolStripMenuItem.Text = Localization.türkçe;
            ingilizceToolStripMenuItem.Text = Localization.ingilizce;
            yardımToolStripMenuItem.Text = Localization.lbl_yardim;
            çıkışToolStripMenuItem.Text = Localization.lbl_cikis;
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yardımToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nfmajans.com/iletisim.html");
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            pctrbx_logo.Image = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\logo.jpeg");
            dilTercihiToolStripMenuItem.Visible = false;
            excelDokümanıToolStripMenuItem.Visible = false;
            if (Properties.Settings.Default.dil == "İngilizce")
            {
                Localization.Culture = new CultureInfo("en-US");
                btn_giriss.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\urungirisK.fw.png");
                btn_cikis.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\uruncikisK.fw.png");
                btn_urun.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\ukayitK.fw.png");
                btn_firma.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\firmaK.fw.png");
                btn_stok.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\stokK.fw.png");
                btn_araclar.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\araclarK.fw.png");
                btn_ayarlar.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\ayarlarK.fw.png");
                this.Text = Localization.form6;
            }
            else if (Properties.Settings.Default.dil == "Türkçe")
            {
                Localization.Culture = new CultureInfo("");
                btn_giriss.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\urungiris.fw.png");
                btn_cikis.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\uruncikis.fw.png");
                btn_urun.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\ukayit.fw.png");
                btn_firma.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\firma.fw.png");
                btn_stok.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\stok.fw.png");
                btn_araclar.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\araclar.fw.png");
                btn_ayarlar.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\ayarlar.fw.png");
                this.Text = Localization.form6;
            }

            if (panel3.Visible == true)
            {
                cmbbx_firma_adi.Text = "";
                txt_urun_kodu.Text = ""; 
            }
            else if(panel4.Visible==true)
            {
                cmbx_firmaadi.Text = "";
                cmbx_urunadi.Text = "";
                txt_adet.Text = "";
                txt_giristarihi.Text = DateTime.Now.ToString();
                txt_islem.Text = "";
                pctrbx_resim.Image = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\barkod.png");
            }
            else if (panel5.Visible==true)
            {
                cmbbx_firma5.Text = "";
                cmbx_urunkodu5.Text = "";
                txt_adet5.Text = "";
                txt_cikis5.Text = DateTime.Now.ToString();
                pctrbx_resim5.Image = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\barkod.png"); 
            }
            else if (panel6.Visible == true)
            {
                txt_firmaadi.Text = "";
                txt_sorumlu.Text = "";
                txt_telno.Text = "";
                txt_vergidaire.Text = "";
                txt_vergino.Text = "";
                cmbx_il.Text = "";
                cmbx_ilce.Text = "";
                txt_adres.Text = "";
            }
            panel1.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            panel6.Visible = false;
            panel7.Visible = false;
            panel8.Visible = false;
            
        }
        private void firma_listele()
        {
            komut = new SqlCommand("select * from FirmaKayit", baglanti);
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbbx_firma_adi.Items.Add(dr["FirmaAdi"]);
            }
            baglanti.Close();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            cmbbx_firma_adi.Text = "";
            txt_urun_kodu.Text = "";
            txt_kayit_tarihi.Text = DateTime.Now.ToString() ; 
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (cmbbx_firma_adi.Text != "" && txt_urun_kodu.Text != "")
            {
                urun_kayit();
            }
            else
            {
                baglanti.Close();
                MessageBox.Show("Lütfen Bilgileri Tam Giriniz.");
            }
        }
        private void urun_kayit()
        {
            FileStream fs = new FileStream(resimpath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            byte[] resim = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();

            SqlCommand komut2 = new SqlCommand();
            komut2.Connection = baglanti;
            baglanti.Open();
            komut2.CommandText = "insert into UrunKayit(FirmaAdi, UrunKodu, KayitTarihi, UrunResim, ToplamAdet) values ('" + cmbbx_firma_adi.Text + "','" + txt_urun_kodu.Text + "','" + txt_kayit_tarihi.Text + "',@image,0)";
            komut2.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;
            komut2.ExecuteNonQuery();
            MessageBox.Show("Başarılı.");
            baglanti.Close();
        }
        private void btn_resim_yukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd1 = new OpenFileDialog();
            opfd1.Filter = "Png Dosyası (*.png)|*.png";
            if (opfd1.ShowDialog() == DialogResult.OK)
            {
                pctrbx_urunresim.Image = Image.FromFile(opfd1.FileName);
                resimpath = opfd1.FileName.ToString();
            }
        }

        private void btn_resim_sil_Click(object sender, EventArgs e)
        {
            pctrbx_urunresim.Image = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\barkod.png");
        }
        private void il_listele()
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from iller ORDER BY id ASC", baglanti);
            da.Fill(dt);
            cmbx_il.ValueMember = "id";
            cmbx_il.DisplayMember = "sehir";
            cmbx_il.DataSource = dt;
            baglanti.Close();
        }

        private void btn_temizle4_Click(object sender, EventArgs e)
        {
            txt_firmaadi.Text = "";
            txt_sorumlu.Text = "";
            txt_telno.Text = "";
            txt_vergidaire.Text = "";
            txt_vergino.Text = "";
            txt_kayit4.Text = DateTime.Now.ToString();
            cmbx_il.Text = "";
            cmbx_ilce.Text = "";
            txt_adres.Text = "";
        }

        private void btn_kaydet4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            if (txt_adres.Text != " " && txt_firmaadi.Text != "" && cmbx_il.Text != "" && cmbx_ilce.Text != "" && txt_sorumlu.Text != "" && txt_vergidaire.Text != "" && txt_vergino.Text != "" && txt_mersis.Text != "")
            {
                if (txt_telno.Text.Length == 11)
                {
                    komut.CommandText = "insert into FirmaKayit(FirmaAdi, SorumluAdi, TelefonNo, VergiDairesiAdi, VergiNo, KayitTarihi, Sehir, ilce, Adres, MersisNo) values ('" + txt_firmaadi.Text + "','" + txt_sorumlu.Text + "','" + txt_telno.Text + "','" + txt_vergidaire.Text + "','" + txt_vergino.Text + "','" + txt_kayit4.Text + "','" + cmbx_il.Text + "','" + cmbx_ilce.Text + "','" + txt_adres.Text + "','" + txt_mersis.Text + "')";
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Başarılı!");
                }
                else
                    MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.");

            }
            else
                MessageBox.Show("Lütfen gerekli tüm alanları doldurun.");

            baglanti.Close();
        }

        private void cmbx_il_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_il.SelectedIndex != -1)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from ilceler where sehir=" + cmbx_il.SelectedValue, baglanti);
                da.Fill(dt);
                cmbx_ilce.DisplayMember = "ilce";
                cmbx_ilce.DataSource = dt;
            }
        }

        private void excelDokümanıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(panel6.Visible==true)
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from FirmaKayit", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                string data = null;

                Microsoft.Office.Interop.Excel.Application xl = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook wb = default(Microsoft.Office.Interop.Excel.Workbook);
                wb = xl.Workbooks.Add(@"C:\\Users\\NFM-1PC\\Documents\\Firma Kayit.xls");
                Microsoft.Office.Interop.Excel.Worksheet ws = default(Microsoft.Office.Interop.Excel.Worksheet);
                ws = wb.Worksheets.get_Item(1);

                for (int i = 2; i <= ds.Tables[0].Rows.Count + 1; i++)
                {
                    for (int j = 2; j <= ds.Tables[0].Columns.Count + 1; j++)
                    {
                        data = ds.Tables[0].Rows[i - 2].ItemArray[j - 2].ToString();
                        ws.Cells[i, j - 1] = data;
                        ws.Cells[i, j - 1].ColumnWidth = 20;
                    }
                }
                baglanti.Close();
                xl.Visible = true;
            }
            else if (panel5.Visible == true)
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from UretimCikis", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                string data = null;

                Microsoft.Office.Interop.Excel.Application xl = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook wb = default(Microsoft.Office.Interop.Excel.Workbook);
                wb = xl.Workbooks.Add(@"C:\\Users\\NFM-1PC\\Documents\\uretim cikis.xls");
                Microsoft.Office.Interop.Excel.Worksheet ws = default(Microsoft.Office.Interop.Excel.Worksheet);
                ws = wb.Worksheets.get_Item(1);

                for (int i = 2; i <= ds.Tables[0].Rows.Count + 1; i++)
                {
                    for (int j = 2; j <= ds.Tables[0].Columns.Count + 1; j++)
                    {
                        data = ds.Tables[0].Rows[i - 2].ItemArray[j - 2].ToString();
                        ws.Cells[i, j - 1] = data;
                        ws.Cells[i, j - 1].ColumnWidth = 20;
                    }
                }
                baglanti.Close();
                xl.Visible = true;
            }
            else if (panel4.Visible == true)
            {
                baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("Select * from UrunGiris", baglanti);
                DataSet ds = new DataSet();
                da.Fill(ds);
                string data = null;

                Microsoft.Office.Interop.Excel.Application xl = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook wb = default(Microsoft.Office.Interop.Excel.Workbook);
                wb = xl.Workbooks.Add(@"C:\\Users\\NFM-1PC\\Documents\\uretim giris.xls");
                Microsoft.Office.Interop.Excel.Worksheet ws = default(Microsoft.Office.Interop.Excel.Worksheet);
                ws = wb.Worksheets.get_Item(1);

                for (int i = 2; i <= ds.Tables[0].Rows.Count + 1; i++)
                {
                    for (int j = 2; j <= ds.Tables[0].Columns.Count + 1; j++)
                    {
                        data = ds.Tables[0].Rows[i - 2].ItemArray[j - 2].ToString();
                        ws.Cells[i, j - 1] = data;
                        ws.Cells[i, j - 1].ColumnWidth = 20;
                    }
                }
                baglanti.Close();
                xl.Visible = true;
            }
        }

        private void btn_temizle5_Click(object sender, EventArgs e)
        {
            cmbbx_firma5.Text = "";
            cmbx_urunkodu5.Text = "";
            txt_adet5.Text = "";
            txt_cikis5.Text = DateTime.Now.ToString();
            pctrbx_resim5.Image = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\barkod.png");            
        }

        private void cmbx_urunkodu5_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from UrunKayit where UrunKodu=@kod ";
            komut.Parameters.AddWithValue("@kod", cmbx_urunkodu5.Text);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Stream stream = dr.GetStream(4);
                pctrbx_resim5.Image = Image.FromStream(stream);

            }
            baglanti.Close(); 
        }

        private void btn_kaydet5_Click(object sender, EventArgs e)
        {
            if (cmbbx_firma5.Text != "" && cmbx_urunkodu5.Text != "" && txt_adet5.Text != "")
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("select * from UrunKayit where UrunKodu=@id", baglanti);
                komut3.Parameters.AddWithValue("@id", cmbx_urunkodu5.Text);
                SqlDataReader dr = komut3.ExecuteReader();
                if (dr.Read())
                {

                    if (int.Parse(txt_adet5.Text) <= int.Parse(dr[5].ToString()) && int.Parse(dr[5].ToString()) != 0)
                    {
                        baglanti.Close();

                        baglanti.Open();
                        komut = new SqlCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "insert into UretimCikis(FirmaAdi, UrunKodu, CikisTarihi, UrunAdet) values ('" + cmbbx_firma5.Text + "','" + cmbx_urunkodu5.Text + "','" + txt_cikis5.Text + "','" + txt_adet5.Text + "')";
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand();
                        komut2.Connection = baglanti;
                        komut2.CommandText = "update UrunKayit set ToplamAdet=ToplamAdet-@miktar where UrunKodu=@kod";
                        komut2.Parameters.AddWithValue("@kod", cmbx_urunkodu5.Text);
                        komut2.Parameters.AddWithValue("@miktar", int.Parse(txt_adet5.Text));
                        komut2.ExecuteNonQuery();
                        baglanti.Close();

                        MessageBox.Show("Kayıt Başarılı.");
                    }
                    else
                    {
                        MessageBox.Show("Stokta yeterli ürün yok!");
                        baglanti.Close();
                    }
                }
            }
            else
                MessageBox.Show("Kayıt Gerçekleştirilemedi.Tekrar Deneyiniz.");
        }
        private void firma_listele7()
        {
            komut = new SqlCommand();
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = "select * from FirmaKayit";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbx_firmaadi.Items.Add(dr["FirmaAdi"]);
            }
            baglanti.Close();
        }
        private void urun_listele7()
        {
                cmbx_urunadi.Items.Clear(); //yazılmadığı zaman cmbx_urunadi elemanları kademeli olarak artmaktadır.
                komut = new SqlCommand();
                komut.Connection = baglanti;
                baglanti.Open();
                komut.CommandText = "select * from UrunKayit where FirmaAdi=@firma";
                komut.Parameters.AddWithValue("@firma", cmbx_firmaadi.Text);
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmbx_urunadi.Items.Add(dr["UrunKodu"]);
                }
                baglanti.Close();
        }

        private void cmbx_urunadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from UrunKayit where UrunKodu=@kod ";
            komut.Parameters.AddWithValue("@kod", cmbx_urunadi.Text);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Stream stream = dr.GetStream(4);
                pctrbx_resim.Image = Image.FromStream(stream);

            }
            baglanti.Close();  
        }

        private void cmbx_firmaadi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbx_firmaadi.SelectedIndex != -1)
            {
                urun_listele7();
            }
        }

        private void btn_temizle2_Click(object sender, EventArgs e)
        {
            cmbx_firmaadi.Text = "";
            cmbx_urunadi.Text = "";
            txt_adet.Text = "";
            txt_giristarihi.Text = DateTime.Now.ToString();
            txt_islem.Text = "";
            pctrbx_resim.Image = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\barkod.png");
        }

        private void btn_kaydet2_Click(object sender, EventArgs e)
        {
            if (cmbx_firmaadi.Text != "" && cmbx_urunadi.Text != "" && txt_adet.Text != "" && txt_islem.Text != "")
            {
                baglanti.Open();
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "insert into UrunGiris(FirmaAdi, UrunKodu, GirisTarihi, UrunAdet, İslem) values ('" + cmbx_firmaadi.Text + "','" + cmbx_urunadi.Text + "','" + txt_giristarihi.Text + "','" + txt_adet.Text + "','" + txt_islem.Text + "')";
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand();
                komut2.Connection = baglanti;
                komut2.CommandText = "update UrunKayit set ToplamAdet=ToplamAdet+@miktar where UrunKodu=@kod";
                komut2.Parameters.AddWithValue("@kod", cmbx_urunadi.Text);
                komut2.Parameters.AddWithValue("@miktar", int.Parse(txt_adet.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kayıt Başarılı.");
            }

            else
                MessageBox.Show("Kayıt Gerçekleştirilemedi.Tekrar Deneyiniz.");
        }

        private void türkçeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("");
            Properties.Settings.Default.dil = "Türkçe";
            Properties.Settings.Default.Save();
            metin9();
        }

        private void ingilizceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localization.Culture = new CultureInfo("en-US");
            Properties.Settings.Default.dil = "İngilizce";
            Properties.Settings.Default.Save();
            metin9();
        }

        private void btn_tema_Click(object sender, EventArgs e)
        {
            DialogResult kontrol;
            ColorDialog renk = new ColorDialog();
            kontrol = renk.ShowDialog();
            if (kontrol == DialogResult.OK)
            {
                this.BackColor = renk.Color;
                Properties.Settings.Default.tema = renk.Color;
                Properties.Settings.Default.Save();
            }
        }
        private void firma_listele5()
        {
            komut = new SqlCommand();
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = "select * from FirmaKayit";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbbx_firma5.Items.Add(dr["FirmaAdi"]);
            }
            baglanti.Close();
        }
        private void urun_listele5()
        {
            komut = new SqlCommand();
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = "select * from UrunKayit";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbx_urunkodu5.Items.Add(dr["UrunKodu"]);
            }
            baglanti.Close();
        }

        private void btn_yazici_ekle_Click(object sender, EventArgs e)
        {
            string sPrinterName = "abc";
            yazici_ekle(sPrinterName);
            cmbx_yazici.Items.Clear();
            foreach (String yazici in PrinterSettings.InstalledPrinters)
            {
                cmbx_yazici.Items.Add(yazici);
            }
        }

        private static ManagementScope oManagementScope = null;
        public static bool yazici_ekle(string sPrinterName)
        {
            try
            {
                oManagementScope = new ManagementScope(ManagementPath.DefaultPath);
                oManagementScope.Connect();
                ManagementClass oPrinterClass = new ManagementClass(new ManagementPath("Win32_Printer"), null);
                ManagementBaseObject oInputParameters = oPrinterClass.GetMethodParameters("AddPrinterConnection");
                oInputParameters.SetPropertyValue("Name", sPrinterName);
                oPrinterClass.InvokeMethod("AddPrinterConnection", oInputParameters, null);
                MessageBox.Show("başarılı");
                return true;
            }

            catch (Exception ex)
            {
                return false;
            }
        }
    }

}
