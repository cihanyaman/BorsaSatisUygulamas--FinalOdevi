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
    public partial class KullaniciEkrani : Form
    {
        Kullanici kullanici;
        public KullaniciEkrani(Kullanici kullanici)
        {
            this.kullanici = kullanici;
            InitializeComponent();
        }

        private void KullaniciEkrani_Load(object sender, EventArgs e)
        {
            Text = " " + kullanici.Ad + " " + kullanici.Soyad + " " ;
            GirilenVeriler.TalepKontrol();
            EkranGuncelle();
            cmbBxBakiye.SelectedIndex = 0;

        }
  
        void EkranGuncelle()
        {
            listUrun.Items.Clear();
            foreach (UrunBilgi mahsul in kullanici.Mahsuller)
            {
                listUrun.Items.Add("Ad :" + mahsul.Ad + " Fiyat: " + mahsul.Fiyat + " Miktar: " + mahsul.Miktar);
            }
            listAlisTalep.Items.Clear();
            List<Talepler> talepler = GirilenVeriler.KullaniciTalepleri(kullanici);
            foreach (Talepler talep in talepler)
            {
                listAlisTalep.Items.Add("Ad: " + talep.Urun + " Miktar: " + talep.Miktar);
            }
            lblbakiye.Text = kullanici.Bakiye.ToString() + " TL";
            lblbakiyeonay.Text = kullanici.BakiyeOnay.ToString() + " TL";
        }
        
        private void btnOnay_Click(object sender, EventArgs e)
        {
            if (cmbUrunTipi.SelectedIndex >= 0)
            {
                UrunBilgi yeni = new UrunBilgi(cmbUrunTipi.Text, int.Parse(tbmiktar.Value.ToString()), double.Parse(tbbirimfiyat.Value.ToString()), kullanici);
                kullanici.MahsulEkle(yeni);
                EkranGuncelle();
                MessageBox.Show("Ürün onayı alınıyor.");
            }
            else MessageBox.Show("Seçim yapınız.");
        }

        
        private void btnOnayaGonder_Click(object sender, EventArgs e)
        {
            while (true)
            {
                try
                {
                    if (cmbBxBakiye.SelectedItem.ToString() == "Türk Lirası")
                    {
                        kullanici.BakiyeOnay += double.Parse(txtBakiye.Text);
                    }
                    else
                    {
                        kullanici.BakiyeOnay += GirilenVeriler.DovizDonustur(double.Parse(txtBakiye.Text), cmbBxBakiye.SelectedItem.ToString());
                    }
                    EkranGuncelle();
                    MessageBox.Show("Bakiyeniz alındı.");
                    break;
                }
                catch (Exception)
                {
                    GirilenVeriler.dovizTarihi = GirilenVeriler.dovizTarihi.AddDays(-1);
                }
            }
        }
        //Sipariş edilen ürün onaya gider.
        private void btnAlisTalep_Click(object sender, EventArgs e)
        {
            if (cmbUrunTipi.SelectedIndex >= 0)
            {
                Talepler talep = new Talepler(kullanici, cmbUrunTipi.Text, int.Parse(tbmiktar.Value.ToString()), int.Parse(tbbirimfiyat.Value.ToString()));
                GirilenVeriler.UrunTalepleri.Add(talep);
                GirilenVeriler.TalepKontrol();
                EkranGuncelle();
                MessageBox.Show("Onay bekleniyor.");
            }
        }
        
        private void btnRapor_Click(object sender, EventArgs e)
        {
            GirilenVeriler.RaporAl(dateTimeBaslangic.Value, dateTimeBitis.Value);
        }
    }
}
