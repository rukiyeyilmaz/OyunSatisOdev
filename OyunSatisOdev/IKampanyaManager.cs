using System;
using System.Collections.Generic;
using System.Text;

namespace OyunSatisOdev
{
    interface IKampanyaManager
    {
        void KampanyaHesapla();
        public void ekle(Kampanya Kampanya01)
        {
            Console.WriteLine(Kampanya01.KampanyaAdi + " eklendi");
        }

        public void guncelle(Kampanya kampanya01)
        {
            Console.WriteLine(kampanya01.KampanyaAdi + " güncellendi");
        }

        public void sil(Kampanya kampanya01)
        {
            Console.WriteLine(kampanya01.KampanyaAdi + " silindi");
        }

    }

}
