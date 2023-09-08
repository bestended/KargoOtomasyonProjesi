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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Müsterilers müsteri = new Müsterilers();
            müsteri.nameSurname = txt_adSoyad.Text;
            müsteri.adress = txt_adres.Text;
            müsteri.telephone = txt_telefon.Text;
            müsteri.mail = txt_mail.Text;
            müsteri.paymentStuation = txt_ödemeDurum.Text;
            müsteri.employeeNum =Convert.ToInt32(txt_calisanNo.Text);
            GCRUD.MüsteriEkle(müsteri);

        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            Müsterilers müsteri = new Müsterilers();
            müsteri.customerNumber = Convert.ToInt32(txt_müsteriNo.Text);
            müsteri.nameSurname = txt_adSoyad.Text;
            müsteri.adress = txt_adres.Text;
            müsteri.telephone = txt_telefon.Text;
            müsteri.mail = txt_mail.Text;
            müsteri.paymentStuation = txt_ödemeDurum.Text;
            müsteri.employeeNum = Convert.ToInt32(txt_calisanNo.Text);

            GCRUD.MüsteriGüncelle(müsteri);

        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Müsterilers müsteri = new Müsterilers();
            müsteri.customerNumber = Convert.ToInt32(txt_müsteriNo.Text);

            GCRUD.MüsteriSil(müsteri);

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {

            dgw_müsteriBilgi.DataSource = GCRUD.müsteriListele();

        }

        private void btn_bul_Click(object sender, EventArgs e)
        {

            string isim=txt_adSoyad.Text;

            dgw_müsteriBilgi.DataSource = GCRUD.müsteriBul(isim);

        }

        private void btn_raporlar_Click(object sender, EventArgs e)
        {
            CustomerRaporlar rapor = new CustomerRaporlar();
            rapor.Show();
            this.Hide();
        }

        private void Customers_Load(object sender, EventArgs e)
        {

            

            comboBox1.DataSource=GCRUD.comboListMüsteri();
            comboBox1.ValueMember = "customerNum";




        }

        private void button1_Click(object sender, EventArgs e)
        {

            XmlDosyalari dosyam = new XmlDosyalari();
            dosyam.Show();




        }
    }
}
