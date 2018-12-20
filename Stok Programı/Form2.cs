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
    public partial class Form2 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;

        public Form2()
        {
            InitializeComponent();
            
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "insert into StokGiris(UrunID, UrunAdi, BarkodNo, BirimFiyati, Miktari, GirisTarihi) values ("+ txt_urun_kod.Text +",'"+ txt_urun_ismi.Text +"','"+ txt_barkod.Text +"','"+ txt_fiyat.Text +"','"+ txt_miktar.Text +"','"+ DateTime.Now +"')";
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            baglanti = new SqlConnection("Data Source=NFM-1\\MSSQLSERVER01; Integrated Security=TRUE; Initial Catalog=StokTakip");
            baglanti.Open();
           // MessageBox.Show("Bağlantı Açıldı.");
            baglanti.Close();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            
            //MessageBox.Show("Bağlantı Kapandı.");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "insert into StokSatis(UrunId, UrunAdi, BarkodNo, BirimFiyati, Miktari, SatisTarihi) values ("+ txt_urun_kod.Text +",'"+ txt_urun_ismi.Text +"','"+ txt_barkod.Text +"', '"+ txt_fiyat.Text +"','"+ txt_miktar.Text +"','"+ DateTime.Now +"') ";
            komut.ExecuteNonQuery();

            SqlCommand komut2 = new SqlCommand();
            komut2.Connection = baglanti;
            komut2.CommandText = "delete from StokGiris where UrunID="+ txt_urun_kod.Text +"";
            komut2.ExecuteNonQuery();
            baglanti.Close();
        }
    }

}
