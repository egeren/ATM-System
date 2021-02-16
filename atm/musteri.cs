using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    static class musteri
    {
        public static int id;
        public static string ad;
        public static string soyad;
        public static string tc;
        public static string sifre;
        public static float bakiye;
        public static string tel;
        public static float borc;
        public static float limit;


        public static void musteriOlustur(int id, string ad, string soyad, string tc, string sifre, float bakiye, string tel , float borc, float limit)
        {
            musteri.id = id;
            musteri.ad = ad;
            musteri.soyad = soyad;
            musteri.tc = tc;
            musteri.sifre = sifre;
            musteri.bakiye = bakiye;
            musteri.tel = tel;
            musteri.borc = borc;
            musteri.limit = limit;
        }

    }
}
