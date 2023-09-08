using BLL;
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
    public partial class SevkiyatRaporlari : Form
    {
        public SevkiyatRaporlari()
        {
            InitializeComponent();
        }

        private void btn_tutarGirilen_Click(object sender, EventArgs e)
        {
            int minTutar=Convert.ToInt32(txt_minSevkTutar.Text);
            int maksTutar=Convert.ToInt32(txt_maksSevkTutar.Text);

            dgw_sevkRaporlarim.DataSource = GCRUD.tutarAralikSevkAdi(minTutar, maksTutar);


        }

        private void btn_sürücüAdi_aracMarka_Click(object sender, EventArgs e)
        {
           
            dgw_sevkRaporlarim.DataSource = GCRUD.varisAracSürücüGideri(txt_varisNokta.Text);
        }

        private void btn_sevkAdiMarkaKapasite_Click(object sender, EventArgs e)
        {

            dgw_sevkRaporlarim.DataSource = GCRUD.sevkAdiMarkaKapasite(txt_sevkAdi.Text);




        }

        private void btn_sevkAdi_Click(object sender, EventArgs e)
        {
            
            
            dgw_sevkRaporlarim.DataSource=GCRUD.sevkAdiMarkaMüsAdiPersAdim(txt_sevkAdi2.Text);




        }

        private void btn_kalkisTutar_Click(object sender, EventArgs e)
        {


            dgw_sevkRaporlarim.DataSource = GCRUD.sevkKalkisNoktasi(txt_kalkisTutar.Text);


        }
    }
}
