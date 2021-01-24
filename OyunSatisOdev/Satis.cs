using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisOdev
{
    class Satis
    {
        public void SatisYap(IKampanyaManager kampanyaManager, Musteri musteri, Oyun oyun)
        {
            kampanyaManager.KampanyaHesapla();
            Console.WriteLine(musteri.MusteriAd +" " + oyun.OyunAd);
        }
        public void KampanyaBilgilendirme(List<IKampanyaManager> kampanyalar)
        {
            foreach (var kampanya in kampanyalar)
            {
                kampanya.KampanyaHesapla();
            }
        }
    }
}
