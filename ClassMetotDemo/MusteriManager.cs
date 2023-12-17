using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi :" + " " +  musteri.MusteriAdi + " " + musteri.MusteriSoyadi);
            Console.WriteLine("Müşteri Yaşı Eklendi :" + " " + musteri.MusteriYasi);
            Console.WriteLine("Müşteri TC Kimlik Numarası Eklendi :" + " " +  musteri.TcNo);
            Console.WriteLine("Müşterinin Yaşadığı Şehir Eklendi :" +  " " +  musteri.MusterininYasadigiSehir);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi :" +  " " + musteri.MusteriAdi + " " +  musteri.MusteriSoyadi);
            Console.WriteLine("Müşteri Yaşı Listelendi :" + " " +  musteri.MusteriYasi);
            Console.WriteLine("Müşteri TC Kimlik Numarası Listelendi :" + " " + musteri.TcNo);
            Console.WriteLine("Müşterinin Yaşadığı Şehir Listelendi :"  + " " + musteri.MusterininYasadigiSehir);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi :" + " " + musteri.MusteriAdi + " " +  musteri.MusteriSoyadi);
            Console.WriteLine("Müşteri Yaşı Silindi :" + " " + musteri.MusteriYasi);
            Console.WriteLine("Müşteri TC Kimlik Numarası Silindi :" + " " +  musteri.TcNo);
            Console.WriteLine("Müşterinin Yaşadığı Şehir Silindi :" + " " + musteri.MusterininYasadigiSehir);
        }
    }


    //Manager classı böyle imzalı komutların girildiği yer.
}
