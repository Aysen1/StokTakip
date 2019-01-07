﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Drawing2D;
using System.Globalization;

namespace Stok_Programı
{
    public partial class Form5 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;
        public Form5()
        {
            InitializeComponent();
        }
        private void firma_listele()
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
        private void urun_listele()
        {
            komut = new SqlCommand();
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = "select * from UrunKayit";
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbx_urunadi.Items.Add(dr["UrunKodu"]);
            }
            baglanti.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_giristarihi.Text = DateTime.Now.ToString();
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.tema;
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            baglanti = new SqlConnection("Data Source=NFM-1\\MSSQLSERVER01; Integrated Security=TRUE; Initial Catalog=StokTakip");
            firma_listele();
            urun_listele();
            pctrbx_resim.Image = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\barkod.png");
            btn_simge.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\simge.fw.png");
            btn_tamekran.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\tamekran.fw.png");
            btn_cikiss.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\cikis.fw.png");

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
                btn_temizle.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\temizleK.fw.png");
                btn_kaydet.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\kaydetK.fw.png");
            }
            else if (Properties.Settings.Default.dil == "Türkçe")
            {
                Localization.Culture = new CultureInfo("");
                btn_temizle.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\temizle.fw.png");
                btn_kaydet.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\kaydet.fw.png");
            }
            metin();
            toolStripStatusLabel1.BackColor = Color.White;            
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nfmajans.com/iletisim.html");
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            cmbx_firmaadi.Text = "";
            cmbx_urunadi.Text = "";
            txt_adet.Text = "";
            txt_giristarihi.Text = "";
            pctrbx_resim.Image = null;
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

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (cmbx_firmaadi.Text != "" && cmbx_urunadi.Text != "" && txt_adet.Text != "")
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("select * from UrunKayit where UrunKodu=@id", baglanti);
                komut3.Parameters.AddWithValue("@id", cmbx_urunadi.Text);
                SqlDataReader dr = komut3.ExecuteReader();
                if (dr.Read())
                {

                    if (int.Parse(txt_adet.Text) <= int.Parse(dr[5].ToString()) && int.Parse(dr[5].ToString()) != 0)
                    {
                        baglanti.Close();

                        baglanti.Open();
                        komut = new SqlCommand();
                        komut.Connection = baglanti;
                        komut.CommandText = "insert into UretimCikis(FirmaAdi, UrunKodu, CikisTarihi, UrunAdet) values ('" + cmbx_firmaadi.Text + "','" + cmbx_urunadi.Text + "','" + txt_giristarihi.Text + "','" + txt_adet.Text + "')";
                        komut.ExecuteNonQuery();
                        baglanti.Close();

                        baglanti.Open();
                        SqlCommand komut2 = new SqlCommand();
                        komut2.Connection = baglanti;
                        komut2.CommandText = "update UrunKayit set ToplamAdet=ToplamAdet-@miktar where UrunKodu=@kod";
                        komut2.Parameters.AddWithValue("@kod", cmbx_urunadi.Text);
                        komut2.Parameters.AddWithValue("@miktar", int.Parse(txt_adet.Text));
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

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Close();
            form6.Show();
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

        private void Form5_Shown(object sender, EventArgs e)
        {
            cmbx_firmaadi.Focus();
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=NFM-1\\MSSQLSERVER01; Integrated Security=TRUE; Initial Catalog=StokTakip");
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
        private void metin()
        {
            this.Text = Localization.form5;
            anasayfaToolStripMenuItem.Text = Localization.lbl_anasayfa;
            excelToolStripMenuItem.Text = Localization.excel_dokumani;
            yardımToolStripMenuItem.Text = Localization.lbl_yardim;
            cikisToolStripMenuItem.Text = Localization.lbl_cikis;
            lbl_firmaadi.Text = Localization.lbl_firmaadi;
            lbl_urunkodu.Text = Localization.lbl_urunkodu;
            lbl_giristarihi.Text = Localization.cikis; ;
            lbl_adet.Text = Localization.adet;
        }
    }
}
