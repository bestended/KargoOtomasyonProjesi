using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace KargoOtomasyonProjesi
{
    public partial class SevkiyatXML : Form
    {
        public SevkiyatXML()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load(@"sevkVerisi.xml");
            xDoc.Element("sevkiyatim").Add(new XElement("Sevkiyat",
                new XElement("shipmentNum", txt_sevkNo.Text),
                new XElement("shipmentName", txt_sevkiyatAdi.Text),
                new XElement("dispatchPoint", txt_kalkisNoktasi.Text),
                new XElement("transportationPoint", txt_tasimaNoktasi.Text),
                new XElement("distance", txt_mesafe.Text),
                new XElement("amount", txt_miktar.Text)

                ));

            xDoc.Save(@"sevkVerisi.xml");
            listele();



        }
        public void listele()
        {
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"sevkVerisi.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            dataGridView1.DataSource = ds.Tables[0];
            xmlFile.Close();




        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {

            XDocument x = XDocument.Load(@"sevkVerisi.xml");
            XElement node = x.Element("sevkiyatim").Elements("Sevkiyat").FirstOrDefault(a => a.Element("shipmentNum").Value.Trim() == txt_sevkNo.Text);
            if (node != null)
            {


                node.SetElementValue("shipmentNum", txt_sevkNo.Text);
                node.SetElementValue("shipmentName", txt_sevkiyatAdi.Text);
                node.SetElementValue("dispatchPoint", txt_kalkisNoktasi.Text);
                node.SetElementValue("transportationPoint", txt_tasimaNoktasi.Text);
                node.SetElementValue("distance", txt_mesafe.Text);
                node.SetElementValue("amount", txt_miktar.Text);


                x.Save(@"sevkVerisi.xml");
                listele();
            }



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"sevkVerisi.xml");
            x.Root.Elements().Where(a => a.Element("shipmentNum").Value == txt_sevkNo.Text).Remove();
            x.Save(@"sevkVerisi.xml");

            listele();
        }
    }
}
