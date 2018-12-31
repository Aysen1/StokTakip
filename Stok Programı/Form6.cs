using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Stok_Programı
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            timer1.Start();
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            btn_giris.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Downloads\\urungiris.png");
            btn_cikis.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Downloads\\urunckis.png");
            btn_stok.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\stok.fw.png");
            btn_urun.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\ukayit.fw.png");
            btn_firma.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\firma.fw.png");
            btn_ayarlar.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Downloads\\firmakayit.png");
            pctrbx_logo.Image = Image.FromFile("C:\\Users\\NFM-1PC\\Downloads\\logo.jpeg");
            menuStrip1.Visible = false;
        }

        private void btn_urun_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void btn_firma_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
           
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void anasayfaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
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
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            timer1.Start();
        }
    }
}
