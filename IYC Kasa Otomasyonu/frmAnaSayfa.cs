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
using MesajPaneli.Business;
using MesajPaneli.Models.JsonPostModels;
using MesajPaneli.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace IYC_Kasa_Otomasyonu
{
    public partial class frmAnaSayfa : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();
        DataTable dt = new DataTable();
        public static int ogrenci_id = 0;
        public frmAnaSayfa()
        {
            InitializeComponent();
            listele();
            ogrencileri_listele();
            donemleri_listele();
            toplam = Convert.ToInt32(txt_toplamUcret.Text);
            label6.Text = toplam + " ₺";
        }
        public static string ucret;
        public static string ucret_yazi;
        public static string tarih;
        private void listele()
        {
            data_ogrenciListesi.Columns.Clear();
            DataTable tbl = new DataTable();
            string cumle = "SELECT id,adsoyad,tc,tarih,telefon,donemi,kayit_fiyati,kalan_tutar,odenen_taksit,taksit,kayit_durumu from ogrenciBilgileri where kayit_durumu=1 order by adsoyad ASC";
            SQLiteCommand komut = new SQLiteCommand(cumle, bgl.baglanti());
            SQLiteDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                if (Convert.ToInt32(oku["kayit_durumu"]) == 1)
                {
                    SQLiteDataAdapter adptr = new SQLiteDataAdapter(cumle, bgl.baglanti());
                    adptr.Fill(tbl);
                    data_ogrenciListesi.DataSource = tbl;
                    bgl.baglanti().Close();
                }
            }
            oku.Close();
            bgl.baglanti().Close();
            ebatlar();
            toplam_kayit_sayisi.Text = "Toplam Kayıt Sayısı: " + Convert.ToString(data_ogrenciListesi.Rows.Count);
        }

        private void ebatlar()
        {
            if (data_ogrenciListesi.Rows.Count != 0)
            {
                data_ogrenciListesi.Columns[0].HeaderText = "ID";
                data_ogrenciListesi.Columns[0].Width = 50;
                data_ogrenciListesi.Columns[1].HeaderText = "Öğrenci Adı Soyadı";
                data_ogrenciListesi.Columns[1].Width = 240;
                data_ogrenciListesi.Columns[2].HeaderText = "T.C Kimlik Numarası";
                data_ogrenciListesi.Columns[2].Width = 120;
                data_ogrenciListesi.Columns[3].HeaderText = "Kayıt Tarihi";
                //data_ogrenciListesi.Columns[3].Width = 120;
                data_ogrenciListesi.Columns[4].HeaderText = "Telefon Numarası";
                data_ogrenciListesi.Columns[4].Width = 140;
                data_ogrenciListesi.Columns[5].HeaderText = "Kayıt Olduğu Dönem";
                data_ogrenciListesi.Columns[5].Width = 120;
                data_ogrenciListesi.Columns[6].HeaderText = "Kayıt Fiyatı";
                data_ogrenciListesi.Columns[6].Width = 65;
                data_ogrenciListesi.Columns[7].HeaderText = "Kalan Tutar";
                data_ogrenciListesi.Columns[7].Width = 65;
                data_ogrenciListesi.Columns[8].HeaderText = "Ödenen Taksit";
                data_ogrenciListesi.Columns[8].Width = 65;
                data_ogrenciListesi.Columns[9].HeaderText = "Toplam Taksit";
                data_ogrenciListesi.Columns[9].Width = 65;
                data_ogrenciListesi.Columns[10].Visible = false;

            }
        }

        private void frmAnaSayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void yeniÖğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYeniOgrenci baslat = new frmYeniOgrenci();
            baslat.ShowDialog();
            listele();
            ogrencileri_listele();
        }

        private void ogrencileri_listele()
        {
            cmbx_ogrenciler.Items.Clear();
            SQLiteCommand komut = new SQLiteCommand("select adsoyad,kayit_durumu from ogrenciBilgileri", bgl.baglanti());
            SQLiteDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                if (Convert.ToInt32(oku["kayit_durumu"]) == 1)
                {
                    cmbx_ogrenciler.Items.Add(oku["adsoyad"]);
                }
            }
            oku.Close();
            if (cmbx_ogrenciler.Items.Count != 0)
            {
                //cmbx_ogrenciler.SelectedIndex = 0;
            }
        }

        private void donemleri_listele()
        {
            try
            {
                cmbx_donemler.Items.Clear();
                SQLiteCommand komut = new SQLiteCommand("select donemi from ogrenciBilgileri where adsoyad=@adsoyad", bgl.baglanti());
                komut.Parameters.AddWithValue("@adsoyad", cmbx_ogrenciler.Text);
                komut.ExecuteNonQuery();
                SQLiteDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    cmbx_donemler.Items.Add(oku["donemi"]);
                }
                if (cmbx_donemler.Items.Count != 0)
                {
                    cmbx_donemler.SelectedIndex = 0;
                }
                oku.Close();
                bgl.baglanti().Close();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void txt_toplamUcret_EditValueChanged(object sender, EventArgs e)
        {
            label6.Text = txt_toplamUcret.Text + " ₺";
            if (txt_toplamUcret.Text != "")
            {
                toplam = Convert.ToInt32(txt_toplamUcret.Text);
            }
            else
            {
                toplam = 0;
            }
            btn_yeniFiyat.Enabled = true;
        }
        public static string ogrenci_adi;
        private void ogrenci_bilgilerini_getir()
        {
            SQLiteCommand komut = new SQLiteCommand("select *from ogrenciBilgileri where adsoyad=@adsoyad", bgl.baglanti());
            komut.Parameters.AddWithValue("@adsoyad", cmbx_ogrenciler.Text);
            SQLiteDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                txt_adiSoyadi.Text = Convert.ToString(oku["adsoyad"]);
                ogrenci_adi = Convert.ToString(oku["adsoyad"]);
                txt_kayittarihi.Text = Convert.ToString(oku["tarih"]);
                txt_tcno.Text = Convert.ToString(oku["tc"]);
                txt_telefon.Text = Convert.ToString(oku["telefon"]);
                richTextBox1.Text = Convert.ToString(oku["aciklama"]);
                txt_toplamUcret.Text = Convert.ToString(oku["kayit_fiyati"]);
            }
            oku.Close();
            bgl.baglanti().Close();
        }

        private void cmbx_ogrenciler_SelectedIndexChanged(object sender, EventArgs e)
        {
            ogrenci_bilgilerini_getir();
            donemleri_listele();
            groupControl3.Text = "--> " + cmbx_ogrenciler.Text + "<-- hakkında not gir";
        }

        static int toplam;
        private void btn_indirim_Click(object sender, EventArgs e)
        {
            frmIndirim baslat = new frmIndirim();
            baslat.ShowDialog();
            btn_yeniFiyat.Enabled = true;
        }


        private void txt_toplamUcret_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void yeniFiyatGuncelle()
        {
            try
            {
                if (txt_toplamUcret.Text != "")
                {
                    ogrenciKayitFiyati = Convert.ToInt32(data_ogrenciListesi.SelectedRows[0].Cells[6].Value);
                    label6.Text = toplam + " ₺";
                    txt_toplamUcret.Text = Convert.ToString(toplam);
                    SQLiteCommand komut = new SQLiteCommand("update ogrenciBilgileri set kayit_fiyati=@kayit_fiyati where adsoyad=@adsoyad", bgl.baglanti());
                    komut.Parameters.AddWithValue("@adsoyad", cmbx_ogrenciler.Text);
                    //komut.Parameters.AddWithValue("@kalan_tutar", Convert.ToInt32(txt_toplamUcret.Text)-Convert.ToInt32());
                    komut.Parameters.AddWithValue("@kayit_fiyati", toplam);
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                    listele();
                    yeniFiyatiGuncelle();
                    notifyIcon1.ShowBalloonTip(3000, "Güncellendi!", "Yeni fiyat kayıt edildi.", ToolTipIcon.Info);
                }
                else
                {
                    toplam = 0;
                }
                btn_yeniFiyat.Enabled = false;
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Hata tespit edildi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static int ogrenciKayitFiyati = 0, yeniogrenciKayitFiyati = 0;
        private void yeniFiyatiGuncelle()
        {
            try
            {
                SQLiteCommand komut = new SQLiteCommand("Select *from ogrenciBilgileri where adsoyad=@adsoyad", bgl.baglanti());
                komut.Parameters.AddWithValue("@adsoyad", txt_adiSoyadi.Text);
                SQLiteDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    yeniogrenciKayitFiyati = Convert.ToInt32(oku["kayit_fiyati"]);
                }
                oku.Close();
                bgl.baglanti().Close();
                SQLiteCommand komut2 = new SQLiteCommand("update ogrenciBilgileri set kalan_tutar=kalan_tutar-@kalan_tutar where adsoyad=@adsoyad", bgl.baglanti());
                komut2.Parameters.AddWithValue("@adsoyad", txt_adiSoyadi.Text);
                if (ogrenciKayitFiyati >= yeniogrenciKayitFiyati)
                {
                    komut2.Parameters.AddWithValue("@kalan_tutar", ogrenciKayitFiyati - yeniogrenciKayitFiyati);
                }
                else
                {
                    komut2.Parameters.AddWithValue("@kalan_tutar", -(yeniogrenciKayitFiyati - ogrenciKayitFiyati));
                }
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Bir hata meydana geldi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_yeniFiyat_Click(object sender, EventArgs e)
        {
            yeniFiyatGuncelle();
            listele();
            ogrencileri_listele();
        }

        private void dönemEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDonemEkle baslat = new frmDonemEkle();
            bgl.baglanti().Close();
            baslat.ShowDialog();
            donemleri_listele();
        }

        private void gridDoubleClick()
        {
            try
            {
                SQLiteCommand komut = new SQLiteCommand("select *from ogrenciBilgileri where id=@id", bgl.baglanti());
                komut.Parameters.AddWithValue("@id", data_ogrenciListesi.SelectedRows[0].Cells[0].Value);
                SQLiteDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    txt_adiSoyadi.Text = Convert.ToString(oku["adsoyad"]);
                    ogrenci_adi = Convert.ToString(oku["adsoyad"]);
                    txt_kayittarihi.Text = Convert.ToString(oku["tarih"]);
                    txt_tcno.Text = Convert.ToString(oku["tc"]);
                    txt_telefon.Text = Convert.ToString(oku["telefon"]);
                    richTextBox1.Text = Convert.ToString(oku["aciklama"]);
                    cmbx_ogrenciler.Text = Convert.ToString(oku["adsoyad"]);
                }
                oku.Close();
                bgl.baglanti().Close();
            }
            catch (Exception hata)
            {
                data_ogrenciListesi.ClearSelection();
                bgl.baglanti().Close();
                MessageBox.Show("Lütfen öğrenci seçimi yapın.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            btn_aciklama.Enabled = true;
        }

        private void aciklamaEkle()
        {
            try
            {
                SQLiteCommand komut = new SQLiteCommand("update ogrenciBilgileri set aciklama=@aciklama where adsoyad=@adsoyad", bgl.baglanti());
                komut.Parameters.AddWithValue("@adsoyad", cmbx_ogrenciler.Text);
                komut.Parameters.AddWithValue("@aciklama", richTextBox1.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Hata meydana geldi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_aciklama_Click(object sender, EventArgs e)
        {
            btn_aciklama.Enabled = false;
            aciklamaEkle();
            notifyIcon1.ShowBalloonTip(3000, "Başarı!", "Açıklama başarıyla kaydedildi.", ToolTipIcon.Info);
        }

        private void ödemeListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOdemeYapanlar baslat = new frmOdemeYapanlar();
            baslat.ShowDialog();
        }

        private void öğrenciÇıkışıYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrenciCikisi baslat = new frmOgrenciCikisi();
            baslat.ShowDialog();
            listele();
            ogrencileri_listele();
        }

        private void kaydıSilinenÖğrencilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKaydiSilinenler baslat = new frmKaydiSilinenler();
            baslat.ShowDialog();
            listele();
            ogrencileri_listele();
        }

        private void ismeGoreAra()
        {
            try
            {

                BindingSource bs = new BindingSource();
                bs.DataSource = data_ogrenciListesi.DataSource;
                bs.Filter =  "adsoyad like '%" + txt_ismeGoreAra.Text + "%'";
                data_ogrenciListesi.DataSource = bs;
                //

                /*
                DataTable tbl = new DataTable();
                string cumle2 = "SELECT id,adsoyad,tc,tarih,telefon,donemi,kayit_fiyati,kalan_tutar,odenen_taksit,taksit,kayit_durumu from ogrenciBilgileri where adsoyad like '%" + txt_ismeGoreAra.Text + "%' and kayit_durumu=1 order by adsoyad ASC";
                SQLiteDataAdapter adptr = new SQLiteDataAdapter(cumle2, bgl.baglanti());
                adptr.Fill(tbl);
                data_ogrenciListesi.DataSource = tbl;
                bgl.baglanti().Close();
                bgl.baglanti().Close();
                ebatlar();
                toplam_kayit_sayisi.Text = "Toplam Kayıt Sayısı: " + Convert.ToString(data_ogrenciListesi.Rows.Count);*/
            }
            catch (Exception e)
            {
                bgl.baglanti().Close();
                MessageBox.Show(e.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                data_ogrenciListesi.ClearSelection();
            }
        }

        private void txt_ismeGoreAra_TextChanged(object sender, EventArgs e)
        {
            ismeGoreAra();
            data_ogrenciListesi.ClearSelection();
        }

        private void txt_belgeYazdir_Click(object sender, EventArgs e)
        {
            frmRaporlama baslat = new frmRaporlama();
            baslat.ShowDialog();
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ogrenci_id == 0)
            {
                MessageBox.Show("Lütfen öğrenci seçimi yapın!");
            }
            else
            {
                frmDuzenle baslat = new frmDuzenle();
                baslat.ShowDialog();
                listele();
                donemleri_listele();
                ogrencileri_listele();
            }
        }

        private void data_ogrenciListesi_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                ogrenci_id = Convert.ToInt32(data_ogrenciListesi.SelectedRows[0].Cells[0].Value);
                
            }
            catch (Exception)
            {
                //MessageBox.Show("Seçilecek öğrenci bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tahsilEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ogrenci_id == 0)
            {
                MessageBox.Show("Lütfen öğrenci seçimi yapın!");
            }
            else
            {
                frmTahsilEt baslat = new frmTahsilEt();
                baslat.ShowDialog();
                listele();
                ogrencileri_listele();
            }
        }

        private void ödemeRaporuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ogrenci_id == 0)
            {
                MessageBox.Show("Lütfen öğrenci seçimi yapın!");
            }
            else
            {
                frmOdemeYapanlar baslat = new frmOdemeYapanlar();
                baslat.ShowDialog();
                listele();
                ogrencileri_listele();
            }
        }

        private void data_ogrenciListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                gridDoubleClick();
                donemleri_listele();
                if (Convert.ToInt32(data_ogrenciListesi.SelectedRows[0].Cells[7].Value) == 0)
                {
                    tahsilEtToolStripMenuItem.Enabled = false;
                    tahsilEtToolStripMenuItem.Text = "BORÇ KALMADI";
                }
                else
                {
                    tahsilEtToolStripMenuItem.Enabled = true;
                    tahsilEtToolStripMenuItem.Text = "Tahsil Et";
                }
            }
            catch (Exception hata)
            {
                data_ogrenciListesi.ClearSelection();
                MessageBox.Show("Lütfen seçim yapın.\nHatanın detayları:" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            data_ogrenciListesi.ClearSelection();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult msg = MessageBox.Show("Seçilen " + data_ogrenciListesi.SelectedRows[0].Cells[0].Value.ToString() + " numaralı ve " + data_ogrenciListesi.SelectedRows[0].Cells[1].Value.ToString()+" isimli kaydı silmek istediğinize emin misiniz ?", "Bilgilendirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(msg==DialogResult.Yes)
                {
                    SQLiteCommand komut = new SQLiteCommand("DELETE from ogrenciBilgileri where id=@id", bgl.baglanti());
                    komut.Parameters.AddWithValue("@id", data_ogrenciListesi.SelectedRows[0].Cells[0].Value.ToString());
                    komut.ExecuteNonQuery();
                    bgl.baglanti().Close();
                }
                listele();
                ogrencileri_listele();
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void ogrenciSil()
        {
            try
            {
                DialogResult msg = MessageBox.Show("Seçilen öğrenciyi silmek istediğinize emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (msg == DialogResult.Yes)
                {

                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void sMSGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOdemesiGecenler baslat = new frmOdemesiGecenler();
            baslat.ShowDialog();
        }

        private void ogrenciCikisiYap()
        {
            try
            {
                if (ogrenci_adi == null)
                {
                    MessageBox.Show("Lütfen işlem yapmak istediğiniz öğrenciyi seçin.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DialogResult msg = MessageBox.Show("Öğrencinin çıkışını yapmak istediğinize emin misiniz?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (msg == DialogResult.Yes)
                    {
                        SQLiteCommand komut2 = new SQLiteCommand("update ogrenciBilgileri set kayit_durumu=@status,cikis_tarihi=@cikis_tarihi where adsoyad=@adsoyad", bgl.baglanti());
                        komut2.Parameters.AddWithValue("@adsoyad", frmAnaSayfa.ogrenci_adi);
                        komut2.Parameters.AddWithValue("@status", 0);
                        komut2.Parameters.AddWithValue("@cikis_tarihi", DateTime.Now.ToString("dd.MM.yyyy"));
                        komut2.ExecuteNonQuery();
                        bgl.baglanti().Close();
                        MessageBox.Show(frmAnaSayfa.ogrenci_adi + " isimli öğrencinin çıkışı yapıldı", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Bir hata meydana geldi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void çıkışVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ogrenciCikisiYap();
            listele();
            data_ogrenciListesi.ClearSelection();
            ogrencileri_listele();
        }

        private void eXCELLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tutarBelirle test = new tutarBelirle();
            test.ShowDialog();

            Excel.Application xlApp = new Excel.Application();
            xlApp.Visible = true;
            xlApp.DisplayAlerts = true;

            Excel.Workbook wb = xlApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet ws = (Excel.Worksheet)wb.Sheets[1];
            string ad = data_ogrenciListesi.SelectedRows[0].Cells[1].Value.ToString();
            string tc = data_ogrenciListesi.SelectedRows[0].Cells[2].Value.ToString();
            string tarih = frmAnaSayfa.tarih;
            ws.Range[ws.Cells[12, 1], ws.Cells[12, 4]].Merge();
            ws.Range[ws.Cells[13, 1], ws.Cells[13, 4]].Merge();
            ws.Range[ws.Cells[22, 2], ws.Cells[22, 3]].Merge();
            ws.Range[ws.Cells[35, 7], ws.Cells[35, 8]].Merge();
            ws.Range[ws.Cells[36, 3], ws.Cells[36, 9]].Merge();
            //ws.Range[ws.Cells[40, 2], ws.Cells[40, 4]].Merge();
            ws.Cells[12, 1] = ad;
            ws.Cells[12, 1].Font.Bold = true;
            ws.Cells[12, 1].Font.Size = 14;
            ws.Cells[12, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[13, 1] = tc;
            ws.Cells[13, 1].Font.Bold = true;
            ws.Cells[13, 1].Font.Size = 14;
            ws.Cells[13, 1].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[12, 10] = tarih;
            ws.Cells[12, 10].Font.Bold = true;
            ws.Cells[12, 10].Font.Size = 10;
            ws.Cells[12, 10].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            ws.Cells[22, 5] = "YURT HİZMETİ";
            ws.Cells[22, 5].Font.Bold = true;
            ws.Cells[22, 5].Font.Size = 10;
            ws.Cells[22, 5].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[22, 10] = frmAnaSayfa.ucret+",00";
            ws.Cells[22, 10].Font.Bold = true;
            ws.Cells[22, 10].Font.Size = 10;
            ws.Cells[22, 10].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            ws.Cells[35, 9] = "TOPLAM";
            ws.Cells[35, 9].Font.Bold = true;
            ws.Cells[35, 9].Font.Size = 10;
            ws.Cells[35, 9].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            ws.Cells[35, 10] = frmAnaSayfa.ucret + ",00";
            ws.Cells[35, 10].Font.Bold = true;
            ws.Cells[35, 10].Font.Size = 10;
            ws.Cells[35, 10].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            ws.Cells[37, 9] = "YEKÜN";
            ws.Cells[37, 9].Font.Bold = true;
            ws.Cells[37, 9].Font.Size = 10;
            ws.Cells[37, 9].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            ws.Cells[37, 10] = frmAnaSayfa.ucret+",00";
            ws.Cells[37, 10].Font.Bold = true;
            ws.Cells[37, 10].Font.Size = 10;
            ws.Cells[37, 10].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            ws.Cells[40, 4] = frmAnaSayfa.ucret_yazi;
            ws.Cells[40, 4].Font.Bold = true;
            ws.Cells[40, 4].Font.Size = 10;
            ws.Cells[40, 4].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignRight;
            ws.Cells[36, 3] = "3065 sayılı KDV Kanunun 17/2-a maddesi uyarınca istisna uygulanmıştır";
            ws.Cells[36, 3].Font.Bold = true;
            ws.Cells[36, 3].Font.Size = 10;
            // sayfaya sığdırma denemesi başla.
            ws.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            ws.PageSetup.Zoom = false;
            ws.PageSetup.FitToPagesTall = 1;
            ws.PageSetup.FitToPagesWide = 1;
            // sayfaya sığdırma denemesi bitir.



        }

        private void data_ogrenciListesi_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int rowSelected = e.RowIndex;
                if (e.RowIndex != -1)
                {
                    this.data_ogrenciListesi.ClearSelection();
                    this.data_ogrenciListesi.Rows[rowSelected].Selected = true;
                }
                // you now have the selected row with the context menu showing for the user to delete etc.
            }
        }

        private void belgeYazdırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if(ogrenci_adi==null)
                {
                    MessageBox.Show("Lütfen öğrenci seçimi yapın.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    frmRaporlama baslat = new frmRaporlama();
                    baslat.ShowDialog();
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata meydana geldi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
