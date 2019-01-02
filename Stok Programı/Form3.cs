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
using System.IO;

namespace Stok_Programı
{
    public partial class Form3 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        string resimpath;
        SqlDataReader dr;
        public Form3()
        {
            InitializeComponent();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            timer1.Start();
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            baglanti = new SqlConnection("Data Source=NFM-1\\MSSQLSERVER01; Integrated Security=TRUE; Initial Catalog=StokTakip");
            firma_listele();
            pctrbx_urunresim.Image = Image.FromFile("C:\\Users\\NFM-1PC\\Downloads\\barkod.png");
            btn_temizle.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\temizle.fw.png");
            btn_kaydet.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\kaydet.fw.png");
            btn_resim_yukle.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\yukle.fw.png");
            btn_resim_sil.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\sill.fw.png");
        }
        private void firma_listele()
        {
            komut = new SqlCommand("select * from FirmaKayit",baglanti);
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
            txt_kayit_tarihi.Text = ""; 
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
            //opfd1.ShowDialog();
            if(opfd1.ShowDialog()==DialogResult.OK)
            {
                pctrbx_urunresim.Image = Image.FromFile(opfd1.FileName);
                resimpath = opfd1.FileName.ToString();
            }
        }

        private void btn_resim_sil_Click(object sender, EventArgs e)
        {
            pctrbx_urunresim.Image = null;
        }

        private void anaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nfmajans.com/iletisim.html");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_kayit_tarihi.Text = DateTime.Now.ToString();
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            timer1.Start();
        }

        private void txt_urun_kodu_TextChanged(object sender, EventArgs e)
        {
       
        }
        private void urunkod_kontrol()
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from UrunKayit where UrunKodu=@kod ";
            komut.Parameters.AddWithValue("@kod", txt_urun_kodu.Text);
            dr = komut.ExecuteReader();
            if (dr.Read())
            {
                if (txt_urun_kodu.Text == dr["UrunKodu"].ToString())
                {
                    MessageBox.Show("Ürün Bulunmaktadır.");
                }
            }
            baglanti.Close(); 
        }
    }
}
