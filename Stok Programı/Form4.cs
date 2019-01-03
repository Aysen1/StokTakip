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
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            baglanti = new SqlConnection("Data Source=NFM-1\\MSSQLSERVER01; Integrated Security=TRUE; Initial Catalog=StokTakip");
            btn_temizle.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\temizle.fw.png");
            btn_kaydet.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\kaydet.fw.png");
            btn_simge.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\simge.fw.png");
            btn_tamekran.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\tamekran.fw.png");
            btn_cikiss.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\cikis.fw.png");
            il_listele();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_firmaadi.Text = "";
            txt_sorumlu.Text = "";
            txt_telno.Text = "";
            txt_vergidaire.Text = "";
            txt_vergino.Text = "";
            txt_kayit_tarihi.Text = DateTime.Now.ToString();
            cmbx_il.Text = "";
            cmbx_ilce.Text = "";
            txt_adres.Text = "";
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand();
            komut.Connection = baglanti;
            if(txt_adres.Text != " " && txt_firmaadi.Text!="" && cmbx_il.Text!="" && cmbx_ilce.Text!="" && txt_sorumlu.Text!=""  && txt_vergidaire.Text!="" && txt_vergino.Text!="" && txt_mersis.Text!="")
            {
                if (txt_telno.Text.Length == 11)
                {
                    komut.CommandText = "insert into FirmaKayit(FirmaAdi, SorumluAdi, TelefonNo, VergiDairesiAdi, VergiNo, KayitTarihi, Sehir, ilce, Adres, MersisNo) values ('" + txt_firmaadi.Text + "','" + txt_sorumlu.Text + "','" + txt_telno.Text + "','" + txt_vergidaire.Text + "','" + txt_vergino.Text + "','" + txt_kayit_tarihi.Text + "','" + cmbx_il.Text + "','" + cmbx_ilce.Text + "','" + txt_adres.Text + "','" + txt_mersis.Text + "')";
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

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Close();
            form6.Show();
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
    }
}
