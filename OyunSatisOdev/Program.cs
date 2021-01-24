using System;
using System.Collections.Generic;

namespace OyunSatisOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.MusteriAd = "Rukiye";
            musteri.MusteriSoyad = "yılmaz";
            musteri.Id = "1";
            musteri.TCKN = "12132434";
            musteri.DogumYili = 1991;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.musteriEkle(musteri);
            musteriManager.musteriGuncelle(musteri);
            musteriManager.musteriSil(musteri);
            musteriManager.musteriDogrula(musteri.TCKN,musteri.MusteriAd,musteri.MusteriSoyad,musteri.DogumYili);

            Oyun oyun = new Oyun();
            oyun.OyunId = "12";
            oyun.OyunAd = "Kelime Oyunu";
            oyun.OyunFiyat = 120;
            oyun.OyunStok = "30";

            IKampanyaManager kampanya1 = new Kampaya1();
            IKampanyaManager kampanya2 = new Kampanya2();

            Kampanya kampanya = new Kampanya();
            kampanya.KampanyaAdi = "2 al 1 öde";
            kampanya.KampanyaId = "0002";

            Kampanya kampanya01 = new Kampanya();
            kampanya01.KampanyaAdi = "1 ürün alana 2. ürün %50";
            kampanya01.KampanyaId = "0013";

            kampanya1.ekle(kampanya01);
            kampanya1.guncelle(kampanya01);
            kampanya1.sil(kampanya01);

            kampanya1.ekle(kampanya);
            kampanya1.guncelle(kampanya);
            kampanya1.sil(kampanya);

            Satis satis = new Satis();

            List<IKampanyaManager> kampanyalar = new List<IKampanyaManager> { kampanya2, kampanya1 };
            satis.KampanyaBilgilendirme(kampanyalar);

        
            satis.SatisYap(kampanya2,musteri,oyun);


        }
    }
}
