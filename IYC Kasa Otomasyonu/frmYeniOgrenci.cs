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
using System.Globalization;

namespace IYC_Kasa_Otomasyonu
{
    public partial class frmYeniOgrenci : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        public frmYeniOgrenci()
        {
            InitializeComponent();
            donemleri_listele();
            txt_kayittarihi.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }
        private void ekle()
        {
            try
            {

                SQLiteCommand komut = new SQLiteCommand("SELECT *from ogrenciBilgileri where tc=@tc", bgl.baglanti());
                komut.Parameters.AddWithValue("@tc", txt_tcno.Text);
                komut.ExecuteNonQuery();
                SQLiteDataReader oku = komut.ExecuteReader();

                if (oku.Read())
                {
                    MessageBox.Show("Bu kayıt zaten mevcut", "Aynı Kayıt Girişi Yaptınız.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    komut = new SQLiteCommand("insert into ogrenciBilgileri (adsoyad,tc,tarih,telefon,donemi,kayit_fiyati,taksit,kalan_tutar,depozito,kayit_durumu) values (@adsoyad,@tc,@tarih,@telefon,@donemi,@fiyat,@taksit,@kalan_tutar,@depozito,@kayit)", bgl.baglanti());
                    komut.Parameters.AddWithValue("@adsoyad", txt_adiSoyadi.Text);
                    komut.Parameters.AddWithValue("@tc", txt_tcno.Text);
                    komut.Parameters.AddWithValue("@tarih", txt_kayittarihi.Text);
                    komut.Parameters.AddWithValue("@telefon", txt_telefon.Text);
                    komut.Parameters.AddWithValue("@donemi", cmbx_donem.Text);
                    komut.Parameters.AddWithValue("@fiyat", txt_ucret.Text);
                    komut.Parameters.AddWithValue("@taksit", txt_taksit.Text);
                    komut.Parameters.AddWithValue("@kalan_tutar", txt_ucret.Text);
                    komut.Parameters.AddWithValue("@depozito", txt_depozito.Text);
                    komut.Parameters.AddWithValue("@kayit", 1);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    MessageBox.Show("Kayıt başarıyla yapıldı.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Veritabanı bağlantısında veya ekleme durumunda hata meydana geldi.\n\n" + hata.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public bool kontrol_et(string tc)
        {
            try
            {
                SQLiteCommand komut = new SQLiteCommand("SELECT *from ogrenciBilgileri where tc=@tc",bgl.baglanti());
                komut.Parameters.AddWithValue("@tc", tc);
                komut.ExecuteNonQuery();
                SQLiteDataReader oku = komut.ExecuteReader();

                if(oku.Read())
                {
                    MessageBox.Show("Bu kayıt zaten mevcut", "Aynı Kayıt Girişi Yaptınız.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
                oku.Close();
                bgl.baglanti().Close();
                
                
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show(hata.Message);
            }
            return false;
        }
        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            if (txt_adiSoyadi.Text == "")
            {
                MessageBox.Show("Öğrenci ismi boş bırakılamaz.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_tcno.Text == "")
            {
                MessageBox.Show("Öğrenci T.C numarası boş bırakılamaz.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            else if (txt_ucret.Text == "")
            {
                MessageBox.Show("Kayıt tutarı boş bırakılamaz.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_taksit.Text == "")
            {
                MessageBox.Show("Taksit sayısı boş bırakılamaz.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txt_depozito.Text == "")
            {
                MessageBox.Show("Depozito tutarı boş bırakılamaz.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            /*else if (txt_telefon.Text == "(   )    -")
            {
                MessageBox.Show("Telefon numarası boş bırakılamaz.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }*/
            else
            {
                if (!kontrol_et(Convert.ToString(txt_tcno.Text)))
                {
                    ekle();
                    this.Close();
                }
            }
        }

        private void donemleri_listele()
        {
            cmbx_donem.Items.Clear();
            SQLiteCommand komut = new SQLiteCommand("select donem from donemBilgileri", bgl.baglanti());
            SQLiteDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbx_donem.Items.Add(oku["donem"]);
            }
            if (cmbx_donem.Items.Count != 0)
                cmbx_donem.SelectedIndex = 0;
            oku.Close();
            bgl.baglanti().Close();
        }

        private void txt_adiSoyadi_TextChanged(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;
            txt_adiSoyadi.Text = textInfo.ToTitleCase(txt_adiSoyadi.Text);

        }

        private void txt_adiSoyadi_EditValueChanged(object sender, EventArgs e)
        {
            if (txt_adiSoyadi.Text != "")
                txt_adiSoyadi.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Convert.ToString(txt_adiSoyadi.Text));

        }
    }
}
