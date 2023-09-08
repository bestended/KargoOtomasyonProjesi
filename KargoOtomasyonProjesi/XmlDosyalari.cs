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

namespace KargoOtomasyonProjesi
{
    public partial class XmlDosyalari : Form
    {
        public XmlDosyalari()
        {
            InitializeComponent();
        }


        #region Sevkiyat xml
        private void btn_sevkiyatXml_Click(object sender, EventArgs e)
        {


            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("Sevkiyatim");
            SqlConnection con = new SqlConnection(connectionStringOlustur());

            SqlCommand cmd = new SqlCommand("select * from Sevkiyatlar", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                XmlElement sevkiyat = xmlDoc.CreateElement("Sevkiyat");
                
                XmlAttribute shipmentNum = xmlDoc.CreateAttribute("shipmentNum");
                shipmentNum.Value = reader["shipmentNum"].ToString();

                XmlAttribute shipmentName = xmlDoc.CreateAttribute("shipmentName");
                shipmentName.Value = reader["shipmentName"].ToString();

                XmlAttribute dispatchPoint = xmlDoc.CreateAttribute("dispatchPoint");
                dispatchPoint.Value = reader["dispatchPoint"].ToString();

                XmlAttribute transportationPoint = xmlDoc.CreateAttribute("transportationPoint");
                transportationPoint.Value = reader["transportationPoint"].ToString();

                XmlAttribute distance = xmlDoc.CreateAttribute("distance");
                distance.Value = reader["distance"].ToString();

                XmlAttribute amount = xmlDoc.CreateAttribute("amount");
                amount.Value = reader["amount"].ToString();

            

                sevkiyat.Attributes.Append(shipmentNum);
                sevkiyat.Attributes.Append(shipmentName);
                sevkiyat.Attributes.Append(dispatchPoint);
                sevkiyat.Attributes.Append(transportationPoint);
                sevkiyat.Attributes.Append(distance);
                sevkiyat.Attributes.Append(amount);


                root.AppendChild(sevkiyat);



            }

            con.Close();
            xmlDoc.AppendChild(root);
            xmlDoc.Save("sevkiyatVerisi.xml");



        }
        #endregion
        string connectionStringOlustur()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            #region
            builder.DataSource = "DESKTOP-1PBLKBH\\SQLEXPRESS";
            builder.InitialCatalog = "KargoOtomasyonu";
            builder.UserID = "sa";
            builder.Password = "12345";
            #endregion
            return builder.ConnectionString;


        }

        #region Customer xml
        private void btn_customer_Click(object sender, EventArgs e)
        {
       

                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement("Customer");
                SqlConnection con = new SqlConnection(connectionStringOlustur());

                SqlCommand cmd = new SqlCommand("select * from Müsteriler", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    XmlElement müsteri = xmlDoc.CreateElement("Müsteri");

                    XmlAttribute customerNum = xmlDoc.CreateAttribute("customerNum");
                    customerNum.Value = reader["customerNum"].ToString();

                    XmlAttribute NameSurname = xmlDoc.CreateAttribute("NameSurname");
                    NameSurname.Value = reader["NameSurname"].ToString();

                    XmlAttribute adress = xmlDoc.CreateAttribute("adress");
                    adress.Value = reader["adress"].ToString();

                    XmlAttribute telephone = xmlDoc.CreateAttribute("telephone");
                    telephone.Value = reader["telephone"].ToString();

                    XmlAttribute mail = xmlDoc.CreateAttribute("mail");
                    mail.Value = reader["mail"].ToString();

                    XmlAttribute paymentStuation = xmlDoc.CreateAttribute("paymentStuation");
                    paymentStuation.Value = reader["paymentStuation"].ToString();



                müsteri.Attributes.Append(customerNum);
                müsteri.Attributes.Append(NameSurname);
                müsteri.Attributes.Append(adress);
                müsteri.Attributes.Append(telephone);
                müsteri.Attributes.Append(mail);
                müsteri.Attributes.Append(paymentStuation);


                    root.AppendChild(müsteri);



                }

                con.Close();
                xmlDoc.AppendChild(root);
                xmlDoc.Save("müsteriVerisi.xml");



            }




        #endregion

        #region Araclar xml


       

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("Araclar");
            SqlConnection con = new SqlConnection(connectionStringOlustur());

            SqlCommand cmd = new SqlCommand("select * from Araclar", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                XmlElement arac = xmlDoc.CreateElement("Arac");

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

                arac.Attributes.Append(carNumber);
                arac.Attributes.Append(carName);
                arac.Attributes.Append(carCapacity);
                arac.Attributes.Append(carDriverName);
                arac.Attributes.Append(carExpense);
                arac.Attributes.Append(customerNumber);
                arac.Attributes.Append(shipmentNum);


                root.AppendChild(arac);



            }

            con.Close();
            xmlDoc.AppendChild(root);
            xmlDoc.Save("aracVerisi.xml");



        }
        #endregion


        #region Personeller

        private void button3_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlElement root = xmlDoc.CreateElement("Personeller");
            SqlConnection con = new SqlConnection(connectionStringOlustur());

            SqlCommand cmd = new SqlCommand("select * from Personeller", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {

                XmlElement Personel = xmlDoc.CreateElement("Personel");

                XmlAttribute employeeNum = xmlDoc.CreateAttribute("employeeNum");
                employeeNum.Value = reader["employeeNum"].ToString();

                XmlAttribute nameSurname = xmlDoc.CreateAttribute("nameSurname");
                nameSurname.Value = reader["nameSurname"].ToString();

                XmlAttribute duty = xmlDoc.CreateAttribute("duty");
                duty.Value = reader["duty"].ToString();

                XmlAttribute title = xmlDoc.CreateAttribute("title");
                title.Value = reader["title"].ToString();

                XmlAttribute telephone = xmlDoc.CreateAttribute("telephone");
                telephone.Value = reader["telephone"].ToString();

                XmlAttribute mail = xmlDoc.CreateAttribute("mail");
                mail.Value = reader["mail"].ToString();

                XmlAttribute salary = xmlDoc.CreateAttribute("salary");
                salary.Value = reader["salary"].ToString();

                Personel.Attributes.Append(employeeNum);
                Personel.Attributes.Append(nameSurname);
                Personel.Attributes.Append(duty);
                Personel.Attributes.Append(title);
                Personel.Attributes.Append(telephone);
                Personel.Attributes.Append(mail);
                Personel.Attributes.Append(salary);


                root.AppendChild(Personel);



            }

            con.Close();
            xmlDoc.AppendChild(root);
            xmlDoc.Save("personelVerisi.xml");


        }
        #endregion
    }



}


