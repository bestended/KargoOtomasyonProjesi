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
    public partial class PersonelRaporlari : Form
    {
        public PersonelRaporlari()
        {
            InitializeComponent();
        }

        private void btn_sürücüAdi_aracMarka_Click(object sender, EventArgs e)
        {
            dgw_personelRapor.DataSource= GCRUD.personelUnvanGrup();



        }

        private void button1_Click(object sender, EventArgs e)
        {


            Decimal minMaas = Convert.ToDecimal(txt_minMaas.Text);
            Decimal maksMaas = Convert.ToDecimal(txt_maksMaas.Text);


            dgw_personelRapor.DataSource = GCRUD.maasAralik(minMaas,maksMaas);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string personelAdi = txt_persAdi.Text;

            dgw_personelRapor.DataSource = GCRUD.personelSevk(personelAdi);



        }

        private void button3_Click(object sender, EventArgs e)
        {
            string personelAdim = txt_personelAdim.Text;

            dgw_personelRapor.DataSource = GCRUD.personelSevkTutar(personelAdim);
        }
    }
}
