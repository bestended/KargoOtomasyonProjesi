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
    public partial class CustomerRaporlar : Form
    {
        public CustomerRaporlar()
        {
            InitializeComponent();
        }

        private void cmb_müsteriNo_SelectedIndexChanged(object sender, EventArgs e)
        {


            //int müsteriNo = Convert.ToInt32(cmb_müsteriNo.Text);
            //dgw_müsteriRaporlar.DataSource=GCRUD.müsteriGetir(müsteriNo);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            string müsteriAd = txt_müsteriAdi1.Text;
            dgw_müsteriRaporlar .DataSource= GCRUD.müsteriAracGetir(müsteriAd);



        }

        private void btn_ad_marka_varis_Click(object sender, EventArgs e)
        {

            string müsteriAd = txt_müsteriAdi.Text;
            dgw_müsteriRaporlar.DataSource = GCRUD.müsteriMarkaVaris(müsteriAd);


        }

        private void btn_ödemeyenler_Click(object sender, EventArgs e)
        {

            dgw_müsteriRaporlar.DataSource = GCRUD.ödemeyenMüsteriler();


        }

        private void button2_Click(object sender, EventArgs e)
        {


            dgw_müsteriRaporlar.DataSource = GCRUD.müsteriPersonel(txt_müsteriAdres.Text);


        }
    }
}
