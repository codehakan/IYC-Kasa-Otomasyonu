using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MesajPaneli.Business;
using MesajPaneli.Models;
using MesajPaneli.Models.JsonPostModels;

namespace MesajPaneliConsoleApp
{
    class SendParametricMessage
    {
        public static void DoPost()
        {
            smsData MesajPaneli = new smsData();

            MesajPaneli.user = new UserInfo("05536298853", "iycmalatya1951");
            MesajPaneli.msgBaslik = "Test Mesajı";
            MesajPaneli.msgData.Add(new msgdata("5457247036", "Test mesajı gönderiyorum."));   // Numaralar başında "0" olmadan yazılacaktır
            MesajPaneli.tr = true;

            ReturnValue ReturnData = MesajPaneli.DoPost("http://api.mesajpaneli.com/json_api/", true, true);

            if (ReturnData.status)
            {
                Console.WriteLine(ReturnData.Ref);      //Rapor sorgulaması için referans numarası
                Console.WriteLine(ReturnData.status);   //Gönderim Durumu
                Console.WriteLine(ReturnData.amount);   //Hesabınızdan düşülen kredi
                Console.WriteLine(ReturnData.type);     //Gönderim Tipi Numeric => Numerik gönderim
                //Alphanumeric => Başlıklı gönderim 
                Console.WriteLine(ReturnData.credits);  //Gönderim sonrası hesabınızda kalan kredi
            }
            else
            {
                Console.WriteLine(ReturnData.error);    //Gönderimin Başarısız Olması Durumunda Hata Mesajı
            }
            Console.ReadLine();
        }
    }
}
