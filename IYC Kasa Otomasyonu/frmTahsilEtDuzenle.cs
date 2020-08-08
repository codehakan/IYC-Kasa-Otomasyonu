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
    public partial class frmTahsilEtDuzenle : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        public frmTahsilEtDuzenle()
        {
            InitializeComponent();
            bilgileriCek();
            odemeTurleri();
        }

        private void guncelle()
        {
            //try
            //{
                SQLiteCommand komut = new SQLiteCommand("update odemeYapanlar set odeme_yapan=@ad,odeme_tutari=@tutar,odeme_turu=@tur,odeme_tarihi=@tarih,aciklama=@aciklama where id=@id", bgl.baglanti());
                komut.Parameters.AddWithValue("@id", frmOdemeYapanlar.odeme_id);
                komut.Parameters.AddWithValue("@ad", txt_adiSoyadi.Text);
                komut.Parameters.AddWithValue("@tutar", txt_ucret.Text);
                komut.Parameters.AddWithValue("@tur", cmbx_odemeTurleri.Text);
                komut.Parameters.AddWithValue("@tarih", txt_odemeTarihi.Text);
                komut.Parameters.AddWithValue("@aciklama", richTextBox1.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                yeniFiyatiGuncelle();
                notifyIcon1.ShowBalloonTip(3000, "Güncellendi!", "Yeni bilgiler kayıt edildi.", ToolTipIcon.Info);
            //}
            //catch (Exception hata)
            //{
            //    bgl.baglanti().Close();
            //    MessageBox.Show("Bir hata meydana geldi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void bilgileriCek()
        {
            try
            {
                SQLiteCommand komut = new SQLiteCommand("Select *from odemeYapanlar where id=@id", bgl.baglanti());
                komut.Parameters.AddWithValue("@id", frmOdemeYapanlar.odeme_id);
                komut.ExecuteNonQuery();
                SQLiteDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    txt_adiSoyadi.Text = Convert.ToString(oku["odeme_yapan"]);
                    txt_odemeTarihi.Text = Convert.ToString(oku["odeme_tarihi"]);
                    txt_ucret.Text = Convert.ToString(oku["odeme_tutari"]);
                    richTextBox1.Text = Convert.ToString(oku["aciklama"]);
                }
                oku.Close();
                bgl.baglanti().Close();

            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Bir hata meydana geldi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void odemeTurleri()
        {
            //try
            //{
                SQLiteCommand komut = new SQLiteCommand("Select *from odemeTurleri", bgl.baglanti());
                SQLiteDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    cmbx_odemeTurleri.Items.Add(oku["odeme_turleri"]);
                }
                oku.Close();
                bgl.baglanti().Close();
                if (cmbx_odemeTurleri.Items.Count != 0)
                    cmbx_odemeTurleri.SelectedIndex = 0;
            //}
            //catch (Exception hata)
            //{
            //    bgl.baglanti().Close();
            //    MessageBox.Show("Bir hata meydana geldi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            guncelle();
            this.Close();
        }

        public static int alinanUcret = 0;
        private void yeniFiyatiGuncelle()
        {
            //try
            //{
                SQLiteCommand komut = new SQLiteCommand("update ogrenciBilgileri set kalan_tutar=kalan_tutar+@kalan_tutar where adsoyad=@adsoyad", bgl.baglanti());
                komut.Parameters.AddWithValue("@adsoyad", txt_adiSoyadi.Text);
                SQLiteCommand komut2 = new SQLiteCommand("select *from ogrenciBilgileri where adsoyad=@adsoyad", bgl.baglanti());
                komut2.Parameters.AddWithValue("@adsoyad", txt_adiSoyadi.Text);
                SQLiteDataReader oku = komut2.ExecuteReader();
                if (oku.Read())
                {
                    alinanUcret = Convert.ToInt32(txt_ucret.Text);
                }
                //MessageBox.Show(Convert.ToString(alinanUcret));
                oku.Close();
                if (frmOdemeYapanlar.duzenlenecek_ucret >= alinanUcret)
                {
                    komut.Parameters.AddWithValue("@kalan_tutar", Convert.ToInt32(frmOdemeYapanlar.duzenlenecek_ucret - alinanUcret));
                    komut.ExecuteNonQuery();
                }
                else
                {
                    komut.Parameters.AddWithValue("@kalan_tutar", Convert.ToInt32(-(alinanUcret - frmOdemeYapanlar.duzenlenecek_ucret)));
                    komut.ExecuteNonQuery();
                }
                //MessageBox.Show(Convert.ToString(frmOdemeYapanlar.duzenlenecek_ucret));

                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                bgl.baglanti().Close();
            //}
            //catch (Exception hata)
            //{
            //    bgl.baglanti().Close();
            //    MessageBox.Show("Bir hata meydana geldi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}
