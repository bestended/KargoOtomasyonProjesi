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
    public partial class Sevkiyatim : Form
    {
        public Sevkiyatim()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            Shipments ship = new Shipments();
            ship.shipmentName = txt_sevkiyatAdi.Text;
            ship.dispatchPoint = txt_kalkisNoktasi.Text;
            ship.transportationPoint = txt_varisNoktasi.Text;
            ship.distance = Convert.ToInt32(txt_mesafe.Text);
            ship.amount = Convert.ToInt32(txt_miktar.Text);

            GCRUD.sevkiyatEkle(ship);
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            Shipments ship = new Shipments();
            ship.shipmentNumber = Convert.ToInt32(txt_sevkiyatNo.Text);
            ship.shipmentName = txt_sevkiyatAdi.Text;
            ship.dispatchPoint = txt_kalkisNoktasi.Text;
            ship.transportationPoint = txt_varisNoktasi.Text;
            ship.distance = Convert.ToInt32(txt_mesafe.Text);
            ship.amount = Convert.ToInt32(txt_miktar.Text);

            GCRUD.sevkiyatGüncelle(ship);
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GCRUD.sevkiyatList();
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            Shipments ship = new Shipments();
            ship.shipmentNumber = Convert.ToInt32(txt_sevkiyatNo.Text);

            GCRUD.sevkiyatSil(ship);
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            Shipments ship = new Shipments();
            ship.shipmentName = txt_sevkiyatAdi.Text;

            string deger = txt_sevkiyatAdi.Text;


            dataGridView1.DataSource = GCRUD.sevkiyatBulma(deger);
        }

        private void btn_raporlar_Click(object sender, EventArgs e)
        {
            SevkiyatRaporlari rapor = new SevkiyatRaporlari();
            rapor.Show();
            this.Show();



        }

        private void Sevkiyatim_Load(object sender, EventArgs e)
        {
           

            cmb_sevkiyat.DataSource = GCRUD.comboListSevkiyat();
            cmb_sevkiyat.ValueMember = "shipmentNum";

           



        }

        private void button2_Click(object sender, EventArgs e)
        {
            SevkiyatXML XML = new SevkiyatXML();
            XML.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDosyalari dosya = new XmlDosyalari();
            dosya.Show();
        }
    }
}
