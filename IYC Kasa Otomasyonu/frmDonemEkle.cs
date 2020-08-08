using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace IYC_Kasa_Otomasyonu
{
    public partial class frmDonemEkle : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        public frmDonemEkle()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void yeniDonemEkle()
        {
            try
            {
                SQLiteCommand komut = new SQLiteCommand("insert into donemBilgileri (donem) values (@donem)", bgl.baglanti());
                komut.Parameters.AddWithValue("@donem", txt_donem.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Yeni dönem eklendi.", "Dönem eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Veritabanı bağlantısı sağlanamadı.\n\n"+hata.Message,"Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            yeniDonemEkle();
            this.Close();
        }
    }
}
