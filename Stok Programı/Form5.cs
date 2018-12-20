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
    
    public partial class Form5 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        //string resimpath;
        SqlDataReader dr;
        //string sorgu;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            txt_giristarihi.Text = DateTime.Now.ToString();
            timer1.Start();
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            baglanti = new SqlConnection("Data Source=NFM-1\\MSSQLSERVER01; Integrated Security=TRUE; Initial Catalog=StokTakip");            
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
              
            if (cmbx_firmaadi.Text != "" && cmbx_urunadi.Text != "" && txt_adet.Text != "" && txt_islem.Text != "")
            {
                baglanti.Open(); 
                komut = new SqlCommand();
                komut.Connection = baglanti;
                komut.CommandText = "insert into UrunGiris(FirmaAdi, UrunKodu, GirisTarihi, UrunAdet, İslem) values ('"+cmbx_firmaadi.Text+"','"+cmbx_urunadi.Text+"','"+ txt_giristarihi.Text +"','"+ txt_adet.Text +"','"+txt_islem.Text+"')";
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
            }
            else if (cmbx_firmaadi.Text != "" && cmbx_urunadi.Text != "" && txt_adet.Text != "")
            {
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
                komut2.Parameters.AddWithValue("@miktar",int.Parse(txt_adet.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }
            
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }




        private void cmbx_urunadi_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            
        }

        private void btn_resim_Click(object sender, EventArgs e)
        {     
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            komut.CommandText = "select * from UrunKayit where UrunKodu=@kod ";
            komut.Parameters.AddWithValue("@kod",cmbx_urunadi.Text);
            dr = komut.ExecuteReader(); 
            if(dr.Read())
            { 
            Stream stream = dr.GetStream(4);
            pictureBox1.Image = Image.FromStream(stream);
            }
            baglanti.Close();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            cmbx_firmaadi.Text="";
            cmbx_urunadi.Text = "";
            txt_adet.Text = "";
            txt_giristarihi.Text = "";
            txt_islem.Text = "";
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nfmajans.com/iletisim.html");
        }
    }
}
