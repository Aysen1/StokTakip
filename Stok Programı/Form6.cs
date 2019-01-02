using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
using System.IO;


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
            btn_araclar.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Downloads\\araclar.png");
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

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_araclar_Click(object sender, EventArgs e)
        {

        }

        private void btn_stok_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=NFM-1\\MSSQLSERVER01; Integrated Security=TRUE; Initial Catalog=StokTakip");
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from UrunKayit", baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            string data = null;

            object misvalue = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Application xl = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = default(Microsoft.Office.Interop.Excel.Workbook);
            wb = xl.Workbooks.Add(misvalue);
            Microsoft.Office.Interop.Excel.Worksheet ws = default(Microsoft.Office.Interop.Excel.Worksheet);
            ws = wb.Worksheets.get_Item(1);
            ws.Cells[1, 1].Value = "UrunID";
            ws.Cells[1, 2].Value = "FirmaAdi";
            ws.Cells[1, 3].Value = "UrunKodu";
            ws.Cells[1, 4].Value = "KayitTarihi";
            ws.Cells[1, 5].Value = "UrunResim";
            ws.Cells[1, 6].Value = "ToplamAdet";
            for (int i = 2; i <= ds.Tables[0].Rows.Count +1; i++)
            {
                for (int j = 2; j <= ds.Tables[0].Columns.Count+1 ; j++)
                {
                    data = ds.Tables[0].Rows[i-2].ItemArray[j-2].ToString();
                    ws.Cells[i , j -1] = data;
                }
            }
            baglanti.Close();
            xl.Visible = true;
        }
    }
}
