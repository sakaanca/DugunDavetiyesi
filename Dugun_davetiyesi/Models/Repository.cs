﻿using System.Collections.Generic;

namespace Dugun_davetiyesi.Models
{
    public class Repository
    {
        private static List<Cevap> cevaplar = new List<Cevap>();
        public static IEnumerable<Cevap> Cevaplar=> cevaplar;
        public static void CevapEkle(Cevap cevap)
        {
            cevaplar.Add(cevap);
        }
    }
}
