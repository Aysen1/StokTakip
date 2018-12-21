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

namespace Stok_Programı
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
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
            if (data.Read())
            {
                Form6 form6 = new Form6();
                form6.Show();
                this.Hide();
               
            }
            else
                lbl_hatali_giris.Text = "Girilen Bilgiler Hatalıdır!Tekrar Deneyiniz.";
            baglanti.Close();
         /*   if (txt_kullanici_isim.Text=="aysen" & txt_kullanici_sifre.Text=="1")
            {
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
                
            }
            else
                lbl_hatali_giris.Text = "Girilen Bilgiler Hatalıdır!Tekrar Deneyiniz.";*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=NFM-1\\MSSQLSERVER01; Integrated Security=TRUE; Initial Catalog=StokTakip");
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void yardımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nfmajans.com/iletisim.html");
        }

       
    }
}
