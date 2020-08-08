using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IYC_Kasa_Otomasyonu
{
    class tabloKontrol
    {
        public void TabloOlustur()
        {
            string baglantiCumlesi = "Data Source=D:\\test.sql;Initial Catalog=yurt_kasa_otomasyonu;Integrated Security=True";
            // using ifadesi baglanti nesnesinin işi bittiğinde yok edilmesini, kullanılan kaynakların boşaltılmasını sağlayacak
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {

                    baglanti.Open();
                    using (SqlCommand command = new SqlCommand("CREATE TABLE Kisiler(Ad char(50),Soyad char(50),Adres char(50));", baglanti))
                        // Sorguyu çalıştır
                        command.ExecuteNonQuery();

                    MessageBox.Show("Tablo oluşturuldu");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
