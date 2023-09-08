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
    public partial class AnaSayfam : Form
    {
        public AnaSayfam()
        {
            InitializeComponent();
        }

        private void btn_arabalar_Click(object sender, EventArgs e)
        {
            Araclar arac = new Araclar();
            arac.Show();
            this.Hide();
        }

        private void btn_müsteriler_Click(object sender, EventArgs e)
        {
            Customers customer = new Customers();
            customer.Show();
            this.Hide();
        }

        private void btn_Sevkiyat_Click(object sender, EventArgs e)
        {
            Sevkiyatim sevkiyatim = new Sevkiyatim();
            sevkiyatim.Show();
            this.Hide();
        }

        private void btn_personeller_Click(object sender, EventArgs e)
        {
            Personellers person = new Personellers();
            person.Show();
            this.Hide();
        }
    }
}
