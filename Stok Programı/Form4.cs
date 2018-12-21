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
    public partial class Form4 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            timer1.Start();
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            baglanti = new SqlConnection("Data Source=NFM-1\\MSSQLSERVER01; Integrated Security=TRUE; Initial Catalog=StokTakip");
            
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_firmaadi.Text = "";
            txt_sorumlu.Text = "";
            txt_telno.Text = "";
            txt_vergidaire.Text = "";
            txt_vergino.Text = "";
            txt_kayit_tarihi.Text = DateTime.Now.ToString();
            txt_il.Text = "";
            txt_ilce.Text = "";
            txt_adres.Text = "";
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            if(txt_adres.Text != " " && txt_firmaadi.Text!="" && txt_il.Text!="" && txt_ilce.Text!="" && txt_sorumlu.Text!="" && txt_telno.Text!="" && txt_vergidaire.Text!="" && txt_vergino.Text!="")
            {
                komut.CommandText = "insert into FirmaKayit(FirmaAdi, SorumluAdi, TelefonNo, VergiDairesiAdi, VergiNo, KayitTarihi, Sehir, ilce, Adres) values ('"+ txt_firmaadi.Text +"','"+ txt_sorumlu.Text +"','"+ txt_telno.Text +"','"+ txt_vergidaire.Text +"','"+ txt_vergino.Text +"','"+txt_kayit_tarihi.Text+"','"+txt_il.Text+"','"+txt_ilce.Text +"','"+ txt_adres.Text +"')";
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
                MessageBox.Show("Lütfen gerekli tüm alanları doldurun.");
            
            baglanti.Close();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
