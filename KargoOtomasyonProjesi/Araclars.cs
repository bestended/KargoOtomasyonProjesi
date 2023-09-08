using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KargoOtomasyonProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Araç işlem UI
        private void btn_listele_Click(object sender, EventArgs e)
        {

            dgw_aracBilgi.DataSource = GCRUD.ListeleArac();

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {


            Araclars arac = new Araclars();
            arac.carName = txt_Markasi.Text;
            arac.carCapacity =Convert.ToInt32(txt_kapasite.Text);
            arac.carDriverName = txt_sürücüAdi.Text;
            arac.carExpense = Convert.ToInt32(txt_expense.Text);
            arac.customerNumber = Convert.ToInt32(txt_müsteriNo.Text);
            arac.shipmentNumber = Convert.ToInt32(txt_sevkiyatNo.Text);

            bool sonuc=GCRUD.AracEkle(arac);
            if (sonuc)
            {
                MessageBox.Show("Kayıt başarılı");
            }

            dgw_aracBilgi.DataSource = GCRUD.ListeleArac();

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Araclars arac = new Araclars();
            arac.carNumber= Convert.ToInt32(txt_arabaNo.Text);
         
            bool sonuc = GCRUD.AracSil(arac);
            if (sonuc)
            {
                MessageBox.Show("Kayıt başarılı");
            }

            dgw_aracBilgi.DataSource = GCRUD.ListeleArac();

        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            Araclars arac = new Araclars();
            arac.carNumber = Convert.ToInt32(txt_arabaNo.Text);
            arac.carName = txt_Markasi.Text;
            arac.carCapacity = Convert.ToInt32(txt_kapasite.Text);
            arac.carDriverName = txt_sürücüAdi.Text;
            arac.carExpense = Convert.ToInt32(txt_expense.Text);
            arac.customerNumber = Convert.ToInt32(txt_müsteriNo.Text);
            arac.shipmentNumber = Convert.ToInt32(txt_sevkiyatNo.Text);
            bool sonuc = GCRUD.AracGüncelle(arac);
            if (sonuc)
            {
                MessageBox.Show("Kayıt başarılı");
            }
            dgw_aracBilgi.DataSource = GCRUD.ListeleArac();
        }




        #endregion

        private void btn_bul_Click(object sender, EventArgs e)
        {
            string ad=txt_Markasi.Text;
            dgw_aracBilgi.DataSource=GCRUD.aracBul(ad);

        }
    }
}
