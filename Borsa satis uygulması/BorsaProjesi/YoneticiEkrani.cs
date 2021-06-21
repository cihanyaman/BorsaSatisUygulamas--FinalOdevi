using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaProjesi
{
    public partial class YoneticiEkrani : Form
    {
        public YoneticiEkrani()
        {
            InitializeComponent();
        }
       
        private void btnIslemler_Click(object sender, EventArgs e)
        {
            new YapilanIslemler().ShowDialog();
        }
        void PanelGuncelle()
        {
            foreach (Kullanici kullanici in GirilenVeriler.kullanicilar)
            {
                Kullanicilar.Items.Add(kullanici.KullaniciAdi + " - " + kullanici.Ad + " " + kullanici.Soyad + " Bakiye: " + kullanici.Bakiye);
            }
        }
        private void listKullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            TalepleriGuncelle();
        }
        private void YoneticiEkrani_Load(object sender, EventArgs e)
        {
            PanelGuncelle();
            GirilenVeriler.TalepKontrol();
        }

        void TalepleriGuncelle()
        {
            if (Kullanicilar.SelectedIndex>=0)
            {
                string nickname = Kullanicilar.SelectedItem.ToString().Split('-')[0].Trim();
                Kullanici secilen = GirilenVeriler.kullaniciAra(nickname);
                urunTalebi.Items.Clear();
                lbltalep.Text = secilen.BakiyeOnay.ToString()+" TL";
                foreach (UrunBilgi urun in secilen.Mahsuller )
                {
                    if (urun.Onay==false)
                    {
                        urunTalebi.Items.Add("Ad :" + urun.Ad + " Miktar: " + urun.Miktar + " Fiyat: " + urun.Fiyat+" TL");
                    }
                }
            }
        }

        private void YoneticiEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            GirilenVeriler.TalepKontrol();
        }

        // Talepleri onaylanır.
        private void btnTalep_Click(object sender, EventArgs e)
        {
            if (Kullanicilar.SelectedIndex>=0)
            {
                string nickname = Kullanicilar.SelectedItem.ToString().Split('-')[0].Trim();
                Kullanici secilen = GirilenVeriler.kullaniciAra(nickname);
                foreach (UrunBilgi urun in secilen.Mahsuller)
                {
                    if (urun.Onay==false)
                    {
                        urun.Onay = true;
                    }
                }
            }
            TalepleriGuncelle();
            GirilenVeriler.TalepKontrol();
        }

        private void btnBakiyeOnay_Click(object sender, EventArgs e)
        {
            if (Kullanicilar.SelectedIndex >= 0)
            {
                string nickname = Kullanicilar.SelectedItem.ToString().Split('-')[0].Trim();
                Kullanici secilen = GirilenVeriler.kullaniciAra(nickname);
                secilen.Bakiye += secilen.BakiyeOnay;
                secilen.BakiyeOnay = 0;
            }
            TalepleriGuncelle();
        }

        private void btnDovizGuncelle_Click(object sender, EventArgs e)
        {
            GirilenVeriler.dovizTarihi = dateTimeTarih.Value;
            MessageBox.Show("Güncelleme başarılı");
        }

        private void lbltalep_Click(object sender, EventArgs e)
        {

        }
    }
}
