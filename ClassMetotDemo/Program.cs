using System;

namespace ClassMetotDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdi = "Yağız";
            musteri1.MusteriSoyadi = "Zorlu";
            musteri1.MusteriYasi = 20;
            musteri1.MusterininYasadigiSehir = "İzmir";
            musteri1.TcNo = "222222222";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdi = "Ahmet";
            musteri2.MusteriSoyadi = "Korkmaz";
            musteri2.MusteriYasi = 32;
            musteri2.MusterininYasadigiSehir = "Ankara";
            musteri2.TcNo = "444444444";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdi = "Esra";
            musteri3.MusteriSoyadi = "Kartal";
            musteri3.MusteriYasi = 39;
            musteri3.MusterininYasadigiSehir = "Bursa";
            musteri3.TcNo = "6666666";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Müşterinin Adı ve Soyadı :" + musteri.MusteriAdi + " " +  musteri.MusteriSoyadi);
                Console.WriteLine("Müşterinin Yaşı :" + musteri.MusteriYasi);
                Console.WriteLine("Müşterinin Yaşadığı Şehir :" + musteri.MusterininYasadigiSehir);
                Console.WriteLine("--------------------------------------");
            }

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("Birinci Müşteri:");

            musteriManager.Ekle(musteri1);              //musteri1 olunca MusteriManagerda ekle kısmına girilen her şeyi musteri1 e uygular.

            Console.WriteLine("İkinci Müşteri:");  

            musteriManager.Ekle(musteri2);

            Console.WriteLine("Üçüncü Müşteri:");

            musteriManager.Ekle(musteri3);

            Console.WriteLine("-----------------Listeleme-------------------------");    

            musteriManager.Sil(musteri1);

            Console.WriteLine("İkinci Müşteri:");

            musteriManager.Sil(musteri2);

            Console.WriteLine("Üçüncü Müşteri:");

            musteriManager.Sil(musteri3);

            Console.WriteLine("----------------Silme--------------------------");

            musteriManager.Listele(musteri1);

            Console.WriteLine("İkinci Müşteri:");

            musteriManager.Listele(musteri2);

            Console.WriteLine("Üçüncü Müşteri:");

            musteriManager.Listele(musteri3);

            Console.WriteLine("------------------------------------------");
        }
    }
}