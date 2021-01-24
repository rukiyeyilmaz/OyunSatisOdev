using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisOdev
{
    class MusteriManager
    {
        public void musteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd+" eklendi.");
        }

        public void musteriGuncelle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " güncellendi.");
        }
        

        public void musteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " silindi.");
        }

         public void musteriDogrula(string tc,string ad, string soyad, int yil)
        {
            Console.WriteLine(tc +" "+ soyad +" "+ ad +" " + yil + " doğrulandı.");
        }
    }
}
