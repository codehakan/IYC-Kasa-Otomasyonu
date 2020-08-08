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
    public partial class testSqlite : Form
    {
        public testSqlite()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection baglanti = new SQLiteConnection();
                baglanti.ConnectionString = ("Data Source=db/kasa_otomasyonu.s3db");
                baglanti.Open();
                string sql = "insert into cikisYapanlar (adsoyad,odedigi_miktar,cikis_tarihi,kayit_tarihi) values (@ad,@para,@cikis,@kayit)";
                SQLiteCommand komut = new SQLiteCommand(sql,baglanti);
                komut.Parameters.AddWithValue("@ad", textBox1.Text);
                komut.Parameters.AddWithValue("@para", textBox2.Text);
                komut.Parameters.AddWithValue("@cikis", textBox3.Text);
                komut.Parameters.AddWithValue("@kayit", textBox4.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("başarı");
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }
    }
}
