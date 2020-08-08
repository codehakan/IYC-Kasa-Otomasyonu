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
using System.Collections;

namespace IYC_Kasa_Otomasyonu
{
    public partial class frmOdemeYapanlar : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        public frmOdemeYapanlar()
        {
            InitializeComponent();
            listele();
            isimlericek();
            if (frmAnaSayfa.ogrenci_adi != "")
                belirlenenVerileriGetir();
        }
        // cmbx_isimler'e öğrenci isimlerini çekelim
        private void isimlericek()
        {
            SQLiteCommand komut = new SQLiteCommand("select adsoyad from ogrenciBilgileri", bgl.baglanti());
            SQLiteDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbx_isimler.Items.Add(oku["adsoyad"]);
            }
            bgl.baglanti().Close();
        }


        // Veritabanından ödeme yapanları listeleme fonksiyonunu yazalım
        private void listele()
        {
            try
            {
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter("Select *from odemeYapanlar", bgl.baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.baglanti().Close();
                ebatlar();
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Bir hata meydana geldi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txt_isimara_TextChanged(object sender, EventArgs e)
        {
            verileriGetir();
        }

        private void ebatlar()
        {
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[0].Width = 80;
                dataGridView1.Columns[1].HeaderText = "Ödeme Yapan";
                dataGridView1.Columns[1].Width = 280;
                dataGridView1.Columns[2].HeaderText = "Ödenen";
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[3].HeaderText = "Ödeme Türü";
                dataGridView1.Columns[4].HeaderText = "Ödeme Tarihi";
            }
        }

        private void belirlenenVerileriGetir()
        {
            try
            {
                DataTable tbl = new DataTable();
                string cumle = "Select id,odeme_yapan,odeme_tutari,odeme_turu,odeme_tarihi from odemeYapanlar where odeme_yapan like '%" + Convert.ToString(frmAnaSayfa.ogrenci_adi) + "%'";
                SQLiteDataAdapter adptr = new SQLiteDataAdapter(cumle, bgl.baglanti());
                adptr.Fill(tbl);
                dataGridView1.DataSource = tbl;
                bgl.baglanti().Close();
                ebatlar();
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Bir hata meydana geldi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //cmbx_isimler'de seçilen ismin verileni getirme
        private void verileriGetir()
        {
            try
            {
                DataTable tbl = new DataTable();
                string cumle = "Select id,odeme_yapan,odeme_tutari,odeme_turu,odeme_tarihi from odemeYapanlar where odeme_yapan like '%" + txt_isimara.Text + "%'";
                SQLiteDataAdapter adptr = new SQLiteDataAdapter(cumle, bgl.baglanti());
                adptr.Fill(tbl);
                dataGridView1.DataSource = tbl;
                bgl.baglanti().Close();
                ebatlar();
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Bir hata meydana geldi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbx_isimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            verileriGetir();
        }
        public static int odeme_id = 0;
        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (odeme_id == 0)
            {
                MessageBox.Show("Lütfen öğrenci seçimi yapın!");
            }
            else
            {
                frmTahsilEtDuzenle baslat = new frmTahsilEtDuzenle();
                baslat.ShowDialog();
                belirlenenVerileriGetir();
            }
        }
        public static int duzenlenecek_ucret = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                odeme_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                duzenlenecek_ucret = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen öğrenci seçimi yapın!");
            }
        }

        private void frmOdemeYapanlar_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult msg = MessageBox.Show("Silmek istediğinize emin misiniz?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {
                    SQLiteCommand komut = new SQLiteCommand("delete from odemeYapanlar where id=@id", bgl.baglanti());
                    komut.Parameters.AddWithValue("@id", Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value));
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    SQLiteCommand komut2 = new SQLiteCommand("update ogrenciBilgileri set odenen_taksit=odenen_taksit-1,kalan_tutar=kalan_tutar+@kalan_tutar where adsoyad=@adsoyad", bgl.baglanti());
                    komut2.Parameters.AddWithValue("@adsoyad", Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value));
                    komut2.Parameters.AddWithValue("@kalan_tutar", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value));
                    komut2.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    notifyIcon1.ShowBalloonTip(3000, "Silindi!", "Seçilen ödeme başarıyla silindi.", ToolTipIcon.Info);
                    belirlenenVerileriGetir();
                }
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Bir hata meydana geldi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
