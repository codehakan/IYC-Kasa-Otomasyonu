using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;


namespace IYC_Kasa_Otomasyonu
{
    class SqlBaglantim
    {
        //public SqlConnection baglanti()
        //{
        //    SqlConnection baglan = new SqlConnection("Data Source=.;Initial Catalog=yurt_kasa_otomasyonu;Integrated Security=True;MultipleActiveResultSets=True");
        //    baglan.Open();
        //    return baglan;
        //}

        public SQLiteConnection baglanti()
        {
            SQLiteConnection baglan = new SQLiteConnection(@"Data Source=kasa_otomasyonu.s3db");
            //SQLiteConnection baglan = new SQLiteConnection(@"Data Source =" + System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "kasa_otomasyonu.s3db; Version = 3; New = false; Read Only = true");

            baglan.Open();
            return baglan;
        }

        /*public SQLiteConnection baglanti()
        {
            SQLiteConnection baglanti = new SQLiteConnection("Data Source=db/kasa_otomasyonu.s3db");
            if (baglanti.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    baglanti.Open();
                }
                catch
                {
                    MessageBox.Show("Bağlantı Kurulamadı", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            return baglanti;
        }*/
    }
}
