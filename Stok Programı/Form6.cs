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
using System.Drawing.Drawing2D;
using System.Globalization;


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
            this.WindowState = FormWindowState.Maximized;
            timer1.Start();
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            btn_giris.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\urungiris.png");
            btn_cikis.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\urunckis.png");
            btn_stok.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\stok.fw.png");
            btn_urun.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\ukayit.fw.png");
            btn_firma.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\firma.fw.png");
            btn_ayarlar.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\firmakayit.png");
            pctrbx_logo.Image = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\logo.jpeg");
            btn_araclar.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\araclar.png");
            btn_simge.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\simge.fw.png");
            btn_tamekran.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\tamekran.fw.png");
            btn_cikiss.BackgroundImage = Image.FromFile("C:\\Users\\NFM-1PC\\Pictures\\fw_files\\cikis.fw.png");
            menuStrip1.Visible = false;

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

            Localization.Culture = new CultureInfo("en-US");
            this.Text = Localization.form6;
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
        private void btn_araclar_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void btn_stok_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=NFM-1\\MSSQLSERVER01; Integrated Security=TRUE; Initial Catalog=StokTakip");
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

            for (int i = 2; i <= ds.Tables[0].Rows.Count +1; i++)
            {
                for (int j = 2; j <= ds.Tables[0].Columns.Count+1 ; j++)
                {
                    data = ds.Tables[0].Rows[i-2].ItemArray[j-2].ToString();
                    ws.Cells[i , j -1] = data;
                    ws.Cells[i, j - 1].ColumnWidth = 20;
                }
            }
            baglanti.Close();
            xl.Visible = true;
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
            Form form1 = new Form1();
            form1.Show();
            this.Dispose();
        }

        private void btn_ayarlar_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }
    }
}
