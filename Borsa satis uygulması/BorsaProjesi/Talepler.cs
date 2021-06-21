using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaProjesi
{
    class Talepler
    {
        
       private Kullanici alici;
        private string urun;
        private double fiyat;
        private int miktar;

        
        public Talepler(Kullanici alici, string urun,double fiyat, int miktar)
        {
            Alici = alici;
            Urun = urun;
            this.fiyat = fiyat;
            Miktar = miktar;
        }

        public Kullanici Alici { get => alici; set => alici = value; }
        public string Urun { get => urun; set => urun = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
        public int Miktar { get => miktar; set => miktar = value; }

        public void AlimiGerceklestir(UrunBilgi urun)
        {
            IslemDetaylari islem;
            double baslangicBakiye = alici.Bakiye;
            int gecicimiktar = miktar;
            double toplamTutar =  urun.Fiyat * miktar;
            if (this.fiyat >= urun.Fiyat && alici.Bakiye>0  )
            {
                if (urun.Miktar >= miktar && alici.Bakiye >= toplamTutar)
                {
                    urun.Miktar -= miktar;
                    miktar = 0;
                    alici.Bakiye -= toplamTutar;
                    alici.Bakiye -= (toplamTutar * 0.01);
                    UrunBilgi yeniUrun = new UrunBilgi(urun.Ad, miktar, urun.Fiyat, alici);
                    yeniUrun.Onay = true;

                    alici.MahsulEkle(yeniUrun);
                    urun.Sahibi.Bakiye += toplamTutar;

                }
                
                else if (urun.Miktar >= miktar && alici.Bakiye <= toplamTutar)
                {
                    int yeterliMiktar = (int)(alici.Bakiye / urun.Fiyat);
                    if (yeterliMiktar > 0)
                    {
                        toplamTutar = yeterliMiktar * urun.Fiyat;
                        urun.Miktar -= yeterliMiktar;
                        miktar -= yeterliMiktar;
                        alici.Bakiye -= toplamTutar;
                        alici.Bakiye -= (toplamTutar * 0.01);
                        UrunBilgi yeniUrun = new UrunBilgi(urun.Ad, yeterliMiktar, urun.Fiyat, alici);
                        yeniUrun.Onay = true;

                        urun.Sahibi.Bakiye += toplamTutar;
                        alici.MahsulEkle(yeniUrun);
                    }
                }
                else
                {

                    int yeterliMiktar = urun.Miktar;
                    toplamTutar = yeterliMiktar * urun.Fiyat;
                    if (alici.Bakiye >= toplamTutar)
                    {
                        alici.Bakiye -= toplamTutar;
                        alici.Bakiye -= (toplamTutar * 0.01);
                        urun.Sahibi.Bakiye += toplamTutar;
                        miktar -= yeterliMiktar;

                        urun.Miktar -= yeterliMiktar;
                        UrunBilgi yeniUrun = new UrunBilgi(urun.Ad, yeterliMiktar, urun.Fiyat, alici);
                        yeniUrun.Onay = true;

                        alici.MahsulEkle(yeniUrun);
                    }
                }
                if (baslangicBakiye != alici.Bakiye)
                {
                    islem = new IslemDetaylari(alici.Ad + " " + gecicimiktar + " kilo " + urun.Ad + " almak ister ise " + urun.Fiyat + " tl'den alım işlemi gerçekleşti",
                    alici.Ad + " " + urun.Sahibi.Ad + "'in hesabına " + toplamTutar + " TL gönderdi.", alici.Ad + " " + alici.Bakiye + " tl parası kaldı",
                    urun.Fiyat + " tl");
                    GirilenVeriler.Islemler.Add(islem);
                }
            }
        }

        public bool Hazirmi()
        {
            return miktar == 0;
        }
       
    }
}
