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

namespace IYC_Kasa_Otomasyonu
{
    public partial class frmTahsilEt : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        public frmTahsilEt()
        {
            InitializeComponent();
            try
            {
                odemeTurleriniGetir();
                txt_adiSoyadi.Text = frmAnaSayfa.ogrenci_adi;
                bilgileriCek();
                txt_ucret.Text = Convert.ToString(Convert.ToInt32(toplam_odenmesi_gereken_ucret) / Convert.ToInt32(txt_taksit.Text));
                txt_odemeTarihi.Text = DateTime.Now.ToString("dd.MM.yyyy");
            }
            catch (Exception hata)
            {
                MessageBox.Show("Lütfen öğrenci seçimini yaptıktan sonra işlemleri gerçekleştirin." + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void odemeTurleriniGetir()
        {
            cmbx_odemeTurleri.Items.Clear();
            SQLiteCommand komut = new SQLiteCommand("select odeme_turleri from odemeTurleri", bgl.baglanti());
            SQLiteDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbx_odemeTurleri.Items.Add(oku["odeme_turleri"]);
            }
            oku.Close();
            if (cmbx_odemeTurleri.Items.Count != 0)
                cmbx_odemeTurleri.SelectedIndex = 0;
            else
                MessageBox.Show("Lütfen ödeme türleri ekleyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            bgl.baglanti().Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int odenecek_tutar = 0;
        private void odemeYap()
        {
            try
            {
                SQLiteCommand komut = new SQLiteCommand("insert into odemeYapanlar (odeme_yapan,odeme_tutari,odeme_turu,odeme_tarihi,aciklama) values (@ad,@tutar,@tur,@tarih,@aciklama)", bgl.baglanti());
                komut.Parameters.AddWithValue("@ad", txt_adiSoyadi.Text);
                komut.Parameters.AddWithValue("@tutar", txt_ucret.Text);
                komut.Parameters.AddWithValue("@tur", cmbx_odemeTurleri.Text);
                komut.Parameters.AddWithValue("@tarih", txt_odemeTarihi.Text);
                komut.Parameters.AddWithValue("@aciklama", richTextBox1.Text);
                komut.ExecuteNonQuery();
                SQLiteCommand taksit_ekle = new SQLiteCommand("update ogrenciBilgileri set odenen_taksit=odenen_taksit+1,kalan_tutar=kalan_tutar-" + odenecek_tutar + " where adsoyad=@ad", bgl.baglanti());
                taksit_ekle.Parameters.AddWithValue("@ad", txt_adiSoyadi.Text);
                taksit_ekle.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ödeme alındı", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Hata bulundu:\n\n" + hata.Message, "İşlem Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int toplam_odenmesi_gereken_ucret = 0;
        private void bilgileriCek()
        {
            SQLiteCommand komut = new SQLiteCommand("select kayit_fiyati,taksit,odenen_taksit,kalan_tutar from ogrenciBilgileri where adsoyad=@adsoyad", bgl.baglanti());
            komut.Parameters.AddWithValue("@adsoyad", txt_adiSoyadi.Text);
            SQLiteDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                if (txt_ucret.Text != "")
                {
                    label6.Text = Convert.ToString(Convert.ToInt32(oku["kalan_tutar"]) - Convert.ToInt32(txt_ucret.Text) + " ₺");
                    //txt_ucret.Text = Convert.ToString(Convert.ToInt32(oku["kayit_fiyati"]) / Convert.ToInt32(oku["taksit"]));
                    txt_taksit.Text = Convert.ToString(oku["taksit"]);
                    odenecek_tutar = Convert.ToInt32(txt_ucret.Text);
                }
                else
                {
                    label6.Text = Convert.ToString(Convert.ToInt32(oku["kalan_tutar"]) + " ₺");
                    //txt_ucret.Text = Convert.ToString(Convert.ToInt32(oku["kayit_fiyati"]) / Convert.ToInt32(oku["taksit"]));
                    txt_taksit.Text = Convert.ToString(oku["taksit"]);
                    if (txt_ucret.Text != "")
                    {
                        odenecek_tutar = Convert.ToInt32(txt_ucret.Text);
                    }
                }
                toplam_odenmesi_gereken_ucret = Convert.ToInt32(oku["kayit_fiyati"]);
            }
            oku.Close();
            bgl.baglanti().Close();
        }

        private void txt_ucret_EditValueChanged(object sender, EventArgs e)
        {
            bilgileriCek();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label6.Text.Replace(" ₺", "")) < 0)
            {
                MessageBox.Show("Kalacak tutar 0'dan düşük", "UYARI");
            }
            else
            {
                odemeYap();
                this.Close();
            }

        }

        private void txt_ucret_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
