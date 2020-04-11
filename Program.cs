using System;

namespace ErtugrulSefaAy
{
    class Program
    {
        static void Main(string[] args)
        {
            /****************************************************************************
            **                        SAKARYA ÜNİVERSİTESİ
            **              BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
            **               BİLİŞİM SİSTEMLERİ MÜHENDİSLİĞİ BÖLÜMÜ
            **                  NESNEYE DAYALI PROGRAMLAMA DERSİ
            **                     2019-2020 BAHAR DÖNEMİ
            **
            **               ÖDEV NUMARASI..........: 01
            **               ÖĞRENCİ ADI............: Ertuğrul Sefa Ay
            **               ÖĞRENCİ NUMARASI.......: b191200050
            **               DERSİN ALINDIĞI GRUP...: A
             ****************************************************************************/
            int ceza = 3150; //Belirlenen ceza degeri

            int toplamceza = 0;//Toplam cezanın hesaplanması icin kullanilen degisken tanımlandı

            int cezakesilenkisisayısı = 0;//Toplam ceza kesilen kisi sayısının hesaplanması icin kullanilen degisken tanımlandı

            string adsoyad;//Kisilerin adları icin string tanımlandı

            int yas;//Kisilerin yaslari icin int tanımlandı

            int dongu = 2;//Programın ne zaman sonlanıcagını belirlemek icin kullanıldı alt satırlarda bu degisken degiserek program sonlanıcak

            while (dongu == 2)//Programın tekrar etmesi icin while dongusu acildi
            {



                Console.WriteLine("Ad soyad giriniz.");// "..." icindekini yazdırmak icin kullanıldı

                adsoyad = Console.ReadLine();//Satır okunarak adsoyad stringine aktarıldı

                Console.WriteLine("Yaşını giriniz.");// "..." icindekini yazdırmak icin kullanıldı


                yas = Convert.ToInt32(Console.ReadLine());//Satır okunarak yas intine aktarıldı

                Console.WriteLine("Kontrol ediliyor...");// "..." icindekini yazdırmak icin kullanıldı

                DateTime tarih = DateTime.Now;//Cezanın kesim tarihi ve saati icin kullanildi



                if (yas <= 20 || yas >= 65) //Cezaya tabi tutulan yas aralıkları belirlendi
                {

                    cezakesilenkisisayısı += 1;//Program kapatıldıktan sonra islem yapılan süre boyunca ceza kesilen kisi sayisi hesaplanmak icin kullanildi

                    toplamceza += 3150;//Program kapatıldıktan sonra islem yapılan süre boyunca kesilen toplam ceza tutarnı hesaplamak icin kullanildi

                    Console.WriteLine("Sokaga cikma yasagini cignediginizden dolayı para cezası uygulanmıştır.");// "..." icindekini yazdırmak icin kullanıldı

                    Console.WriteLine("Adı Soyadı : " + adsoyad);// "..." icindekini yazdırmak icin kullanıldı

                    Console.WriteLine("Suç Tarihi : " + tarih);// "..." icindekini yazdırmak icin kullanıldı + tarih yazıldı

                    Console.WriteLine("Cezası :" + ceza + " lira " + "\n" + "****************************************************************" + "\n");// "..." icindekini yazdırmak icin kullanıldı



                }
                else // yas aralıgında degil ise ceza uygulanmayacaktır
                {
                    Console.WriteLine("Ceza uygulanmayacaktır.");// "..." icindekini yazdırmak icin kullanıldı
                }
                Console.WriteLine("Programi sonlandirmak icin 1 e devam etmek için 2 ye basin. ");// "..." icindekini yazdırmak icin kullanıldı

                dongu = Convert.ToInt32(Console.ReadLine());////Satır okunarak yas intine aktarıldı

                Console.WriteLine("****************************************************************\n");// "..." icindekini yazdırmak icin kullanıldı


            }
            Console.WriteLine("Bugun  " + cezakesilenkisisayısı + " kisiye para cezası uygulandı.");// "..." icindekini yazdırmak icin kullanıldı

            Console.WriteLine("Bugun toplam " + toplamceza + " lira para cezası kesildi.");// "..." icindekini yazdırmak icin kullanıldı

        }
    }
}
