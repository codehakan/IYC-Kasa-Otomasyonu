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
    public partial class frmDuzenle : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        public frmDuzenle()
        {
            InitializeComponent();
            bilgileriCek();
            donemleri_cek();
        }

        private void donemleri_cek()
        {
            try
            {
                SQLiteCommand komut = new SQLiteCommand("Select *from donemBilgileri", bgl.baglanti());
                SQLiteDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    cmbx_donem.Items.Add(oku["donem"]);
                }
                oku.Close();
                bgl.baglanti().Close();
                if (cmbx_donem.Items.Count != 0)
                    cmbx_donem.SelectedIndex = 0;
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show(hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bilgileriCek()
        {
            try
            {
                SQLiteCommand komut = new SQLiteCommand("Select *from ogrenciBilgileri where id=@ID", bgl.baglanti());
                komut.Parameters.AddWithValue("@ID", frmAnaSayfa.ogrenci_id);
                komut.ExecuteNonQuery();
                SQLiteDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    txt_adiSoyadi.Text = Convert.ToString(oku["adsoyad"]);
                    txt_tcno.Text = Convert.ToString(oku["tc"]);
                    txt_kayittarihi.Text = Convert.ToString(oku["tarih"]);
                    txt_telefon.Text = Convert.ToString(oku["telefon"]);
                    cmbx_donem.Text = Convert.ToString(oku["donemi"]);
                    txt_ucret.Text = Convert.ToString(oku["kayit_fiyati"]);
                    txt_taksit.Text = Convert.ToString(oku["taksit"]);
                    txt_depozito.Text = Convert.ToString(oku["depozito"]);
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

        private void guncelle()
        {
            try
            {
                SQLiteCommand komut = new SQLiteCommand("update ogrenciBilgileri set adsoyad=@adsoyad,tc=@tc,tarih=@tarih,telefon=@telefon,donemi=@donemi,kayit_fiyati=@kayit_fiyati,taksit=@taksit,depozito=@depozito where id=@ID", bgl.baglanti());
                komut.Parameters.AddWithValue("@ID", frmAnaSayfa.ogrenci_id);
                komut.Parameters.AddWithValue("@adsoyad", txt_adiSoyadi.Text);
                komut.Parameters.AddWithValue("@tc", txt_tcno.Text);
                komut.Parameters.AddWithValue("@tarih", txt_kayittarihi.Text);
                komut.Parameters.AddWithValue("@telefon", txt_telefon.Text);
                komut.Parameters.AddWithValue("@donemi", cmbx_donem.Text);
                komut.Parameters.AddWithValue("@kayit_fiyati", txt_ucret.Text);
                komut.Parameters.AddWithValue("@taksit", txt_taksit.Text);
                komut.Parameters.AddWithValue("@depozito", txt_depozito.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Güncelleme başarıyla tamamlandı.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Bir sorun ile karşılaşıldı.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_duzenle_Click(object sender, EventArgs e)
        {
            guncelle();
            this.Close();
        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
