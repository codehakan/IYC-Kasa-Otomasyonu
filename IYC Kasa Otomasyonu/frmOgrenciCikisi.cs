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
    public partial class frmOgrenciCikisi : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        public frmOgrenciCikisi()
        {
            InitializeComponent();
            ogrencileri_getir();
            txt_cikisTarihi.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        //private void bilgileri_getir()
        //{
        //    SQLiteCommand komut = new SQLiteCommand("select *from ogrenciBilgileri", bgl.baglanti());
        //    SQLiteDataReader oku = komut.ExecuteReader();
        //    if(oku.Read())
        //    {

        //    }
        //}

        private void ogrencileri_getir()
        {
            try
            {
                DataTable tbl = new DataTable();
                string cumle = "Select id,adsoyad,kayit_fiyati,kalan_tutar,odenen_taksit,kayit_durumu,tarih from ogrenciBilgileri where kayit_durumu=1";
                SQLiteDataAdapter da = new SQLiteDataAdapter(cumle, bgl.baglanti());
                da.Fill(tbl);
                dataGridView1.DataSource = tbl;
                ebatlar();
                bgl.baglanti().Close();
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Öğrenci bilgileri çekilirken hata meydana geldi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void ebatlar()
        {
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[0].Width = 50;
                dataGridView1.Columns[1].HeaderText = "Öğrenci Adı";
                dataGridView1.Columns[1].Width = 150;
                dataGridView1.Columns[2].HeaderText = "Kayıt Fiyatı";
                dataGridView1.Columns[2].Width = 80;
                dataGridView1.Columns[3].HeaderText = "Kalan Tutar";
                dataGridView1.Columns[4].HeaderText = "Kalan Taksit";
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
            }
        }
        public static int duzenleme_idsi = 0;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_ok.Enabled = true;
            duzenleme_idsi = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            txt_odedigiUcret.Text = Convert.ToString(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value) - Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value));
            txt_adiSoyadi.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
            txt_kayitTarihi.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[6].Value);
        }

        private void ogrenciCikisiYap()
        {
            try
            {
                SQLiteCommand komut = new SQLiteCommand("insert into cikisYapanlar (adsoyad,odedigi_miktar,cikis_tarihi,kayit_tarihi) values (@adsoyad,@miktar,@tarih,@kayit)", bgl.baglanti());
                komut.Parameters.AddWithValue("@adsoyad", txt_adiSoyadi.Text);
                komut.Parameters.AddWithValue("@miktar", txt_odedigiUcret.Text);
                komut.Parameters.AddWithValue("@tarih", txt_cikisTarihi.Text);
                komut.Parameters.AddWithValue("@kayit", txt_kayitTarihi.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                SQLiteCommand komut2 = new SQLiteCommand("update ogrenciBilgileri set kayit_durumu=@status,cikis_tarihi=@cikis_tarihi where adsoyad=@adsoyad", bgl.baglanti());
                komut2.Parameters.AddWithValue("@adsoyad", txt_adiSoyadi.Text);
                komut2.Parameters.AddWithValue("@status", 0);
                komut2.Parameters.AddWithValue("@cikis_tarihi", txt_cikisTarihi.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Öğrencinin çıkışı verildi.");
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show(hata.Message);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            ogrenciCikisiYap();
            this.Close();
        }

        private void frmOgrenciCikisi_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
