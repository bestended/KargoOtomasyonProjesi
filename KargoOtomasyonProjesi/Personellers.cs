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
    public partial class Personellers : Form
    {
        public Personellers()
        {
            InitializeComponent();
        }

        #region personel işlemleri UI
        private void btn_ekle_Click(object sender, EventArgs e)
        {

            Employees employee = new Employees();
            employee.nameSurname = txt_adSoyad.Text;
            employee.duty = txt_görev.Text;
            employee.title = txt_ünvan.Text;
            employee.telephone = txt_telefon.Text;
            employee.mail = txt_mail.Text;
            employee.salary =Convert.ToDecimal(txt_maas.Text);

            GCRUD.personelEkle(employee);
            

        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();

            employee.employeeNum =Convert.ToInt32(txt_calisanNo.Text);
            employee.nameSurname = txt_adSoyad.Text;
            employee.duty = txt_görev.Text;
            employee.title = txt_ünvan.Text;
            employee.telephone = txt_telefon.Text;
            employee.mail = txt_mail.Text;
            employee.salary = Convert.ToDecimal(txt_maas.Text);

            GCRUD.personelGüncelle(employee);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Employees employee = new Employees();
            employee.employeeNum = Convert.ToInt32(txt_calisanNo.Text);
            GCRUD.personelSil(employee);

        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dgw_personelBilgi.DataSource = GCRUD.personelListele();
        }


       

        private void btn_bul_Click(object sender, EventArgs e)
        {

            string isim=txt_adSoyad.Text;
            dgw_personelBilgi.DataSource=GCRUD.personelBul(isim);


        }
        #endregion

        private void btn_raporlar_Click(object sender, EventArgs e)
        {

            PersonelRaporlari rapor = new PersonelRaporlari();
            rapor.Show();
            this.Hide();



        }

        private void Personellers_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource=GCRUD.comboListPersonel();
            comboBox1.ValueMember = "employeeNum";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDosyalari dosyam = new XmlDosyalari();
            dosyam.Show();

        }
    }
}
