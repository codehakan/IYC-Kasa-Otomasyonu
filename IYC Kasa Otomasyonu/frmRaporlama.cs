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
using System.Data.SQLite;
using Microsoft.Reporting.WinForms;

namespace IYC_Kasa_Otomasyonu
{
    public partial class frmRaporlama : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        public frmRaporlama()
        {
            InitializeComponent();
            isimleri_cek();
            this.WindowState = FormWindowState.Maximized;
            cmx_isim.Text = frmAnaSayfa.ogrenci_adi;
        }

        private void isimleri_cek()
        {
            try
            {
                SQLiteCommand komut = new SQLiteCommand("select adsoyad from ogrenciBilgileri", bgl.baglanti());
                SQLiteDataReader oku = komut.ExecuteReader();
                while(oku.Read())
                {
                    cmx_isim.Items.Add(oku["adsoyad"]);
                }
                bgl.baglanti().Close();
            }
            catch (Exception e)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Hata: " + e.Message);
            }
        }

        private void frmRaporlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kasa_otomasyonuDataSet.odemeYapanlar' table. You can move, or remove it, as needed.
            //////////////this.odemeYapanlarTableAdapter.Fill(this.kasa_otomasyonuDataSet1.odemeYapanlar,cmx_isim.Text);
            // TODO: This line of code loads data into the 'kasa_otomasyonuDataSet.ogrenciBilgileri' table. You can move, or remove it, as needed.
           ///////////////// this.ogrenciBilgileriTableAdapter.Fill(this.kasa_otomasyonuDataSet1.ogrenciBilgileri,cmx_isim.Text);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 150;
            this.reportViewer1.RefreshReport();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            
        }

        private void cmx_isim_SelectedIndexChanged(object sender, EventArgs e)
        {
            //////////////this.odemeYapanlarTableAdapter.Fill(this.kasa_otomasyonuDataSet1.odemeYapanlar, cmx_isim.Text);
            /////////////////this.ogrenciBilgileriTableAdapter.Fill(this.kasa_otomasyonuDataSet1.ogrenciBilgileri, cmx_isim.Text);
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 150;
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmRaporlama_Load_1(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }
    }
}
