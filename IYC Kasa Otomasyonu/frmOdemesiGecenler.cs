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
using MesajPaneli.Business;
using MesajPaneli.Models.JsonPostModels;
using MesajPaneli.Models;

namespace IYC_Kasa_Otomasyonu
{
    public partial class frmOdemesiGecenler : Form
    {
        SqlBaglantim bgl = new SqlBaglantim();

        public frmOdemesiGecenler()
        {
            InitializeComponent();
            odemesiGecikenlerinListesi();
        }

        private void smsGonder()
        {
            try
            {
                smsData MesajPaneli = new smsData();

                MesajPaneli.user = new UserInfo("05536298853", "iycmalatya1951");
                MesajPaneli.msgBaslik = "IAKINCIYURT";
                MesajPaneli.msgData.Add(new msgdata("5457247036", richTextBox1.Text));   // Numaralar başında "0" olmadan yazılacaktır
                MesajPaneli.tr = true;

                ReturnValue ReturnData = MesajPaneli.DoPost("http://api.mesajpaneli.com/json_api/", true, true);

                /*if (ReturnData.status)
                {
                    richTextBox1.Text = ReturnData.Ref + "\n";      //Rapor sorgulaması için referans numarası
                    richTextBox1.Text += ReturnData.status + "\n";   //Gönderim Durumu
                    richTextBox1.Text += ReturnData.amount + "\n";   //Hesabınızdan düşülen kredi
                    richTextBox1.Text += ReturnData.type + "\n";     //Gönderim Tipi Numeric => Numerik gönderim
                    //Alphanumeric => Başlıklı gönderim 
                    richTextBox1.Text += ReturnData.credits + "\n";  //Gönderim sonrası hesabınızda kalan kredi
                }
                else
                {
                    richTextBox1.Text += ReturnData.error + "\n";    //Gönderimin Başarısız Olması Durumunda Hata Mesajı
                }*/
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Bir hata meydana geldi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void odemesiGecikenlerinListesi()
        {
            try
            {
                SQLiteDataAdapter da = new SQLiteDataAdapter("Select odeme_yapan, odeme_tutari, odeme_tarihi from odemeYapanlar,ogrenciBilgileri", bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                data_odemesiGecikenler.DataSource = dt;
                bgl.baglanti().Close();
            }
            catch (Exception hata)
            {
                bgl.baglanti().Close();
                MessageBox.Show("Bilinmeyen bir hata meydana geldi.\n\n" + hata.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_herkeseGonder_Click(object sender, EventArgs e)
        {
            smsGonder();
        }

        private void frmOdemesiGecenler_Load(object sender, EventArgs e)
        {
            data_odemesiGecikenler.ClearSelection();
        }

        private void data_odemesiGecikenler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "Sayın " + data_odemesiGecikenler.SelectedRows[0].Cells[0].Value + ", yurt kaydınızın aylık ödeme tutarı " + data_odemesiGecikenler.SelectedRows[0].Cells[1].Value + " TL değerinde olan taksidinizin ödeme tarihi gelmiştir.";
        }

    }
}
