using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BorsaProjesi
{
    class AdminEkrani : Kullanici
    {
        
        public static List<UrunBilgi> OnaylanacakMahsuller()
        {
            List<UrunBilgi> liste = new List<UrunBilgi>();
            foreach (Kullanici kullanici in GirilenVeriler.kullanicilar)
            {
                foreach (UrunBilgi UrunBilgi in kullanici.Mahsuller)
                {
                    if (!UrunBilgi.Onay)
                    {
                        liste.Add(UrunBilgi);
                    }
                }
            }
            return liste;
        }
        public AdminEkrani(string kullaniciAdi, 
            string sifre, string tC, string ad, 
            string soyad, string telefon, string email, 
            string adres) : base(kullaniciAdi, sifre, tC, ad, soyad, 
                telefon, email, adres)
        {
        }
    }
}
