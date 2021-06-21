using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaProjesi
{
    
    public class UrunBilgi
    {
        private string ad;
        private int miktar;
        private double fiyat;
        private Kullanici sahibi;
        private bool onay;
        public UrunBilgi(string ad, int miktar, double fiyat,Kullanici sahibi)
        {
            Ad = ad;
            Miktar = miktar;
            Fiyat = fiyat;
            onay = false;
            this.Sahibi = sahibi;
        }
        public bool Onay { get => onay; set => onay=value; }
        public string Ad { get => ad; set => ad = value; }
        public int Miktar { get => miktar; set => miktar = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
        public Kullanici Sahibi { get => sahibi; set => sahibi = value; }
    }
}
