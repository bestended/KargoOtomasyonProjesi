using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoOtomasyonProjesi
{
    public partial class KullaniciKontrolEkrani : Form
    {
        public KullaniciKontrolEkrani()
        {
            InitializeComponent();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {

            YetkiliGirisKontrolü yetkiliGirisKontrolü = new YetkiliGirisKontrolü();
            yetkiliGirisKontrolü.kullaniciAdi=txt_kullaniciAdi.Text;
            yetkiliGirisKontrolü.sifre = txt_sifre.Text;

            bool sonuc=GCRUD.kullaniciKontrol(yetkiliGirisKontrolü);
            if (sonuc)
            {

                AnaSayfam sayfa = new AnaSayfam();
                sayfa.Show();
             




            }
            else
            {
                MessageBox.Show("Giriş başarısız");
            }



        }
    }
}
