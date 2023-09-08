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
using System.Xml;
using System.Xml.Linq;

namespace KargoOtomasyonProjesi
{
    public partial class AraclarXml : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        public AraclarXml()
        {
            InitializeComponent();

            con = new SqlConnection(ConnectionStringOlustur());
        }
        public static string ConnectionStringOlustur()
        {
            SqlConnectionStringBuilder build = new SqlConnectionStringBuilder();
            build.DataSource = "DESKTOP-1PBLKBH\\SQLEXPRESS";
            build.InitialCatalog = "KargoOtomasyonu";
            build.UserID = "sa";
            build.Password = "12345";

            return build.ConnectionString;

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            XDocument xDoc = XDocument.Load(@"aracVerim.xml");
            xDoc.Element("Araclar").Add(new XElement("Araclarim",
                new XElement("carNumber", txt_aracNo.Text),
                new XElement("carName", txt_aracMarkasi.Text),
                new XElement("carCapacity", txt_kapasite.Text),
                new XElement("carDriverName", txt_sürücüAd.Text),
                new XElement("carExpense", txt_masraf.Text),
                new XElement("customerNumber", txt_müsteriNo.Text),
                new XElement("shipmentNum", txt_sevkiyatNo.Text)


                ));

            xDoc.Save(@"aracVerim.xml");
            listele();


        }

        private void btn_listele_Click(object sender, EventArgs e)
        {
            listele();
        }

        public void listele()
        {
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"aracVerim.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            dataGridView1.DataSource = ds.Tables[0];
            xmlFile.Close();




        }

        private void button1_Click(object sender, EventArgs e)
        {

            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("Araclar");

            con = new SqlConnection(ConnectionStringOlustur());
            cmd = new SqlCommand("select * from Araclar ", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                XmlElement Araclarim = xmlDoc.CreateElement("Araclarim");

                XmlAttribute carNumber = xmlDoc.CreateAttribute("carNumber");
                carNumber.Value = reader["carNumber"].ToString();

                XmlAttribute carName = xmlDoc.CreateAttribute("carName");
                carName.Value = reader["carName"].ToString();

                XmlAttribute carCapacity = xmlDoc.CreateAttribute("carCapacity");
                carCapacity.Value = reader["carCapacity"].ToString();

                XmlAttribute carDriverName = xmlDoc.CreateAttribute("carDriverName");
                carDriverName.Value = reader["carDriverName"].ToString();

                XmlAttribute carExpense = xmlDoc.CreateAttribute("carExpense");
                carExpense.Value = reader["carExpense"].ToString();

                XmlAttribute customerNumber = xmlDoc.CreateAttribute("customerNumber");
                customerNumber.Value = reader["customerNumber"].ToString();

                XmlAttribute shipmentNum = xmlDoc.CreateAttribute("shipmentNum");
                shipmentNum.Value = reader["shipmentNum"].ToString();




                Araclarim.Attributes.Append(carNumber);
                Araclarim.Attributes.Append(carName);
                Araclarim.Attributes.Append(carCapacity);
                Araclarim.Attributes.Append(carDriverName);
                Araclarim.Attributes.Append(carExpense);
                Araclarim.Attributes.Append(customerNumber);
                Araclarim.Attributes.Append(shipmentNum);

                root.AppendChild(Araclarim);

            }

            con.Close();
            xmlDoc.AppendChild(root);
            xmlDoc.Save("aracVerisi.xml");



        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"aracVerim.xml");
            x.Root.Elements().Where(a => a.Element("carNumber").Value == txt_aracNo.Text).Remove();
            x.Save(@"aracVerim.xml");

            listele();



        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {

            XDocument x = XDocument.Load(@"aracVerim.xml");
            XElement node = x.Element("Araclar").Elements("Araclarim").FirstOrDefault(a => a.Element("carNumber").Value.Trim() == txt_aracNo.Text);
            if (node != null)
            {


                node.SetElementValue("carName", txt_aracMarkasi.Text);
                node.SetElementValue("carCapacity", txt_kapasite.Text);
                node.SetElementValue("carDriverName", txt_sürücüAd.Text);
                node.SetElementValue("carExpense", txt_masraf.Text);
                node.SetElementValue("customerNumber", txt_müsteriNo.Text);
                node.SetElementValue("shipmentNum", txt_sevkiyatNo.Text);


                x.Save(@"aracVerim.xml");
                listele();
            }



        }
    }
}
