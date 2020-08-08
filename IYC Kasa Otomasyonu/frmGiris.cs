using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IYC_Kasa_Otomasyonu
{
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();

        private void kullanici_girisi_kontrol()
        {
            try
            {
                SQLiteCommand komut = new SQLiteCommand("select kullanici_adi,kullanici_sifre from girisBilgileri", bgl.baglanti());
                SQLiteDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    if (textEdit1.Text == Convert.ToString(oku["kullanici_adi"]))
                    {
                        if (textEdit2.Text == Convert.ToString(oku["kullanici_sifre"]))
                        {
                            frmAnaSayfa baslat = new frmAnaSayfa();
                            baslat.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Şifreyi adını yanlış girdiniz.", "Şifre Yanlış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adını yanlış girdiniz.", "Kullanıcı Adı Yanlış", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                oku.Close();
                bgl.baglanti().Close();
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show(hata.Message);
            }
        }


        private void btn_cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            kullanici_girisi_kontrol();
        }
    }
}
