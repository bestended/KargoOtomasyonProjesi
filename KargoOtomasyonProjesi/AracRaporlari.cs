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
    public partial class AracRaporlari : Form
    {
        public AracRaporlari()
        {
            InitializeComponent();
        }

        private void btn_sürücüAdi_aracMarka_Click(object sender, EventArgs e)
        {

            string aracAdi = txt_sürücüAdi.Text;
            dgw_aracRapor.DataSource=GCRUD.sürücüAdAracBul(aracAdi);


        }

        private void button1_Click(object sender, EventArgs e)
        {

            string aracMarka = txt_aracMarka.Text;
            dgw_aracRapor.DataSource = GCRUD.aracMüsteriList(aracMarka);



        }

        private void button2_Click(object sender, EventArgs e)
        {


            int minDeger = Convert.ToInt32(txt_miniGider.Text);
            int maksDeger = Convert.ToInt32(txt_maksiGider.Text);

            dgw_aracRapor.DataSource = GCRUD.giderDegerler(minDeger,maksDeger);



        }

        private void btn_giderSiralamaAzCok_Click(object sender, EventArgs e)
        {


            dgw_aracRapor.DataSource = GCRUD.giderSiralamaAzCok();


        }

        private void btn_giderSiralaCokAz_Click(object sender, EventArgs e)
        {
            dgw_aracRapor.DataSource = GCRUD.giderSiralamaCokAz();
        }
    }
}
