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
    public partial class Araclar : Form
    {
        public Araclar()
        {
            InitializeComponent();
        }

        #region Araç işlemleri
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Araclars arac = new Araclars();
            arac.carName = txt_marka.Text;
            arac.carCapacity =Convert.ToInt32(txt_kapasite.Text);
            arac.carDriverName = txt_sürücüAd.Text;
            arac.carExpense = Convert.ToInt32(txt_masraf.Text);
            arac.customerNumber = Convert.ToInt32( txt_müsteriNo.Text);
            arac.shipmentNumber = Convert.ToInt32(txt_sevkiyatNo.Text);
            GCRUD.AracEkle(arac);

            dgw_aracBilgi.DataSource = GCRUD.ListeleArac();


        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            Araclars arac = new Araclars();
            arac.carNumber = Convert.ToInt32(txt_aracNo.Text);
            arac.carName = txt_marka.Text;
            arac.carCapacity = Convert.ToInt32(txt_kapasite.Text);
            arac.carDriverName = txt_sürücüAd.Text;
            arac.carExpense = Convert.ToInt32(txt_masraf.Text);
            arac.customerNumber = Convert.ToInt32(txt_müsteriNo.Text);
            arac.shipmentNumber = Convert.ToInt32(txt_sevkiyatNo.Text);
            GCRUD.AracGüncelle(arac);



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {

            Araclars arac = new Araclars();
            arac.carNumber = Convert.ToInt32(txt_aracNo.Text);
            GCRUD.AracSil(arac);



        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dgw_aracBilgi.DataSource = GCRUD.ListeleArac();
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            string marka = txt_marka.Text;
            dgw_aracBilgi.DataSource = GCRUD.aracBul(marka);


        }
        #endregion

        private void btn_raporlar_Click(object sender, EventArgs e)
        {
            AracRaporlari aracRaporlari = new AracRaporlari();
            aracRaporlari.Show();
            this.Hide();
        }

        private void Araclar_Load(object sender, EventArgs e)
        {

            comboBox1.DataSource = GCRUD.comboListAraclar();
            comboBox1.ValueMember = "carNumber";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDosyalari dosyam = new XmlDosyalari();
            dosyam.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AraclarXml XMLaRAC = new AraclarXml();
            XMLaRAC.Show();
        }
    }
}
