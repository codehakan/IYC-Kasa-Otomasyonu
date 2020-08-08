using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IYC_Kasa_Otomasyonu
{
    public partial class tutarBelirle : Form
    {
        public tutarBelirle()
        {
            InitializeComponent();
        }

        private string yaziyaCevir(decimal tutar)
        {
            try
            {
                string sTutar = tutar.ToString("F2").Replace('.', ','); // Replace('.',',') ondalık ayracının . olma durumu için            
                string lira = sTutar.Substring(0, sTutar.IndexOf(',')); //tutarın tam kısmı
                string kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);
                string yazi = "";

                string[] birler = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
                string[] onlar = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
                string[] binler = { "katrilyon", "trilyon", "milyar", "milyon", "bin", "" }; //KATRİLYON'un önüne ekleme yapılarak artırabilir.

                int grupSayisi = 6; //sayıdaki 3'lü grup sayısı. katrilyon içi 6. (1.234,00 daki grup sayısı 2'dir.)
                                    //KATRİLYON'un başına ekleyeceğiniz her değer için grup sayısını artırınız.

                lira = lira.PadLeft(grupSayisi * 3, '0'); //sayının soluna '0' eklenerek sayı 'grup sayısı x 3' basakmaklı yapılıyor.            

                string grupDegeri;

                for (int i = 0; i < grupSayisi * 3; i += 3) //sayı 3'erli gruplar halinde ele alınıyor.
                {
                    grupDegeri = "";

                    if (lira.Substring(i, 1) != "0")
                        grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "yüz"; //yüzler                

                    if (grupDegeri == "biryüz") //biryüz düzeltiliyor.
                        grupDegeri = "yüz";

                    grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))]; //onlar

                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))]; //birler                

                    if (grupDegeri != "") //binler
                        grupDegeri += binler[i / 3];

                    if (grupDegeri == "birbin") //birbin düzeltiliyor.
                        grupDegeri = "bin";

                    yazi += grupDegeri;
                }

                if (yazi != "")
                    yazi += "lira";

                int yaziUzunlugu = yazi.Length;

                if (kurus.Substring(0, 1) != "0") //kuruş onlar
                    yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];

                if (kurus.Substring(1, 1) != "0") //kuruş birler
                    yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];

                if (yazi.Length > yaziUzunlugu)
                    yazi += "kuruş";
                //else
                  //  yazi += " sıfır kuruş";

                return yazi;
            }
            catch (Exception)
            {
                MessageBox.Show("Tutarda boşluk olamaz !");
                return null;
            }
        }

        private void txt_ucret_TextChanged(object sender, EventArgs e)
        {
            if(txt_ucret.Text !="")
            {
                txt_ucret_yazi.Text = yaziyaCevir(Convert.ToDecimal(txt_ucret.Text));
            }
        }

        private void btn_okay_Click(object sender, EventArgs e)
        {
            try
            {
                frmAnaSayfa.ucret = txt_ucret.Text;
                frmAnaSayfa.ucret_yazi = txt_ucret_yazi.Text;
                frmAnaSayfa.tarih = txt_tarih.Text;
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Tutarda boşluk olamaz !");
            }
        }

        private void txt_ucret_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
    }
}
