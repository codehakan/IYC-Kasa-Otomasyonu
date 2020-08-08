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
    public partial class frmKaydiSilinenler : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        public frmKaydiSilinenler()
        {
            InitializeComponent();
            listele();
        }

        private void ebatlar()
        {
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Columns[0].HeaderText = "ID";
                dataGridView1.Columns[0].Width = 30;
                dataGridView1.Columns[1].HeaderText = "Öğrenci Adı";
                dataGridView1.Columns[1].Width = 170;
                dataGridView1.Columns[2].HeaderText = "T.C";
                dataGridView1.Columns[3].HeaderText = "Kayıt Tarihi";
                dataGridView1.Columns[4].HeaderText = "Telefon";
                dataGridView1.Columns[4].Width = 130;
                dataGridView1.Columns[5].HeaderText = "Dönem";
                dataGridView1.Columns[6].HeaderText = "Kayıt Fiyatı";
                dataGridView1.Columns[7].HeaderText = "Kalan Tutar";
                dataGridView1.Columns[7].Width = 90;
                dataGridView1.Columns[8].HeaderText = "Ödenen Taksit";
                dataGridView1.Columns[9].HeaderText = "Toplam Taksit";
                dataGridView1.Columns[10].Visible = false;

            }
        }

        private void listele()
        {
            try
            {
                SQLiteDataAdapter komut = new SQLiteDataAdapter("Select id,adsoyad,kalan_tutar,cikis_tarihi,tarih from ogrenciBilgileri where kayit_durumu=0", bgl.baglanti());
                DataTable dt = new DataTable();
                komut.Fill(dt);
                dataGridView1.DataSource = dt;
                bgl.baglanti().Close();
                /*SQLiteCommand komut = new SQLiteCommand("select *from ogrenciBilgileri", bgl.baglanti());
                SQLiteDataReader oku = komut.ExecuteReader();
                if(oku.Read())
                {
                    DataTable tb = new DataTable();
                    SQLiteDataAdapter da = new SQLiteDataAdapter("Select *from cikisYapanlar", bgl.baglanti());
                    da.Fill(tb);
                    dataGridView1.DataSource = tb;
                    bgl.baglanti().Close();
                }
                oku.Close();*/
            }
            catch (Exception e)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Hata!!\n\n-" + e.Message);
            }

        }

        private void kaydi_geriAl()
        {
            try
            {
                SQLiteCommand komut = new SQLiteCommand("update ogrenciBilgileri set kayit_durumu=1,cikis_tarihi=@cikistarihi where adsoyad=@adsoyad", bgl.baglanti());
                komut.Parameters.AddWithValue("@adsoyad", dataGridView1.SelectedRows[0].Cells[1].Value);
                komut.Parameters.AddWithValue("@cikistarihi", "-");
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt başarıyla geri alındı.", "Başarı", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
            }
            catch (Exception e)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Hata tespit edildi!\n" + e.Message);
            }
        }

        private void btn_kaydiGeriAl_Click(object sender, EventArgs e)
        {
            kaydi_geriAl();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_kaydiGeriAl.Enabled = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKaydiSilinenler_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
