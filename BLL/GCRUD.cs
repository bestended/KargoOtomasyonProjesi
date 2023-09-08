using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace BLL
{
    public class GCRUD
    {

        public static bool kullaniciKontrol(YetkiliGirisKontrolü kontrol)
        {
            SqlCommand cmd = new SqlCommand("girisSorgu",Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@kullaniciAdi",kontrol.kullaniciAdi);
            cmd.Parameters.AddWithValue("@sifre",kontrol.sifre);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            int sonuc=sda.Fill(data);

            if (sonuc > 0)
            {
                return true;

            }
            else { return false; }


        }




        #region Araç işlemleri
        public static DataTable ListeleArac()
        {
            SqlDataAdapter adp = new SqlDataAdapter("carList", Tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }


        public static bool AracEkle(Araclars araclar)
        {

            SqlCommand cmd = new SqlCommand("carAdd", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@carName", araclar.carName);
            cmd.Parameters.AddWithValue("@carCapacity", araclar.carCapacity);
            cmd.Parameters.AddWithValue("@carDriverName", araclar.carDriverName);
            cmd.Parameters.AddWithValue("@carExpense", araclar.carExpense);
            cmd.Parameters.AddWithValue("@customerNumber", araclar.customerNumber);
            cmd.Parameters.AddWithValue("@shipmentNum", araclar.shipmentNumber);
            return Tools.ConnectSet(cmd);

        }
        public static bool AracGüncelle(Araclars araclar)
        {

            SqlCommand cmd = new SqlCommand("CarUpDate", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@carNumber", araclar.carNumber);
            cmd.Parameters.AddWithValue("@carName", araclar.carName);
            cmd.Parameters.AddWithValue("@carCapacity", araclar.carCapacity);
            cmd.Parameters.AddWithValue("@carDriverName", araclar.carDriverName);
            cmd.Parameters.AddWithValue("@carExpense", araclar.carExpense);
            cmd.Parameters.AddWithValue("@customerNumber", araclar.customerNumber);
            cmd.Parameters.AddWithValue("@shipmentNum", araclar.shipmentNumber);
            return Tools.ConnectSet(cmd);

        }

        public static bool AracSil(Araclars arac)
        {
            SqlCommand cmd = new SqlCommand("carDel", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@carNum", arac.carNumber );

            return Tools.ConnectSet(cmd);
        }
        public static DataTable aracBul(string aracAd)
        {

            SqlCommand cmd = new SqlCommand("aracBul", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@carName", aracAd);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }

        public static DataTable comboListAraclar()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select carNumber from Araclar", Tools.baglanti);
            sda.Fill(dt);
            return dt;



        }

        #endregion

        #region personel işlem


        public static bool personelEkle(Employees employee)
        {

            SqlCommand cmd = new SqlCommand("empAdd", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@nameSurname", employee.nameSurname);
            cmd.Parameters.AddWithValue("@duty", employee.duty);
            cmd.Parameters.AddWithValue("@title", employee.title);
            cmd.Parameters.AddWithValue("@telephone", employee.telephone);
            cmd.Parameters.AddWithValue("@mail", employee.mail);
            cmd.Parameters.AddWithValue("@salary", employee.salary);
            return Tools.ConnectSet(cmd);

        }
        public static bool personelGüncelle(Employees employee)
        {

            SqlCommand cmd = new SqlCommand("empUpdate", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@employeeNum", employee.employeeNum);
            cmd.Parameters.AddWithValue("@nameSurname", employee.nameSurname);
            cmd.Parameters.AddWithValue("@duty", employee.duty);
            cmd.Parameters.AddWithValue("@title", employee.title);
            cmd.Parameters.AddWithValue("@telephone", employee.telephone);
            cmd.Parameters.AddWithValue("@mail", employee.mail);
            cmd.Parameters.AddWithValue("@salary", employee.salary);
            return Tools.ConnectSet(cmd);

        }

        public static bool personelSil(Employees employees)
        {
            SqlCommand cmd = new SqlCommand("empDel", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@employeeNum", employees.employeeNum);

            return Tools.ConnectSet(cmd);
        }


        public static DataTable personelListele()
        {
            SqlDataAdapter adp = new SqlDataAdapter("empList", Tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }

        public static DataTable personelBul(string personelAd)
        {

            SqlCommand cmd = new SqlCommand("personelBul", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nameSurname", personelAd);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }

        public static DataTable comboListPersonel()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select employeeNum from personeller", Tools.baglanti);
            sda.Fill(dt);
            return dt;



        }

        #endregion

        #region Müşteri işlemleri

        public static bool MüsteriEkle(Müsterilers müsteri)
        {
            SqlCommand cmd = new SqlCommand("CustomerAdd",Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("NameSurname", müsteri.nameSurname);
            cmd.Parameters.AddWithValue("adress", müsteri.adress);
            cmd.Parameters.AddWithValue("telephone", müsteri.telephone);
            cmd.Parameters.AddWithValue("mail", müsteri.mail);
            cmd.Parameters.AddWithValue("paymentStuation", müsteri.paymentStuation);
            cmd.Parameters.AddWithValue("employeeNum", müsteri.employeeNum);

            return Tools.ConnectSet(cmd);
        }

        public static bool MüsteriGüncelle(Müsterilers müsteri)
        {

            SqlCommand cmd = new SqlCommand("CustomerUpdate",Tools.baglanti);
            cmd.Parameters.AddWithValue("customerNum",müsteri.customerNumber);
            cmd.Parameters.AddWithValue("NameSurname", müsteri.nameSurname);
            cmd.Parameters.AddWithValue("adress", müsteri.adress);
            cmd.Parameters.AddWithValue("telephone", müsteri.telephone);
            cmd.Parameters.AddWithValue("mail", müsteri.mail);
            cmd.Parameters.AddWithValue("paymentStuation", müsteri.paymentStuation);
            cmd.Parameters.AddWithValue("employeeNum", müsteri.employeeNum);

            return Tools.ConnectSet(cmd);
        }

        public static bool MüsteriSil(Müsterilers müsteri)
        {

            SqlCommand cmd = new SqlCommand("customerDel",Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("customerNum",müsteri.customerNumber);

            return Tools.ConnectSet(cmd);
        }

        public static DataTable müsteriListele()
        {

            SqlDataAdapter adp = new SqlDataAdapter("customerList", Tools.baglanti);
            adp.SelectCommand.CommandType = System.Data.CommandType.Text;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;


            
        }

        public static DataTable müsteriBul(string müsteriAd)
        {

            SqlCommand cmd = new SqlCommand("müsteriBul", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nameSurname", müsteriAd);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }
        public static DataTable comboListMüsteri()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select customerNum from Müsteriler", Tools.baglanti);
            sda.Fill(dt);
            return dt;



        }




        

        #endregion


        #region sevkiyat işlemleri
        public static DataTable sevkiyatBulma(string sevkiyatAdi)
        {

            SqlCommand cmd = new SqlCommand("sevkiyatBul", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@shipmentName", sevkiyatAdi);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }

        public static bool sevkiyatEkle(Shipments ship)
        {
            SqlCommand cmd = new SqlCommand("shipmentAdd",Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@shipmentName",ship.shipmentName);
            cmd.Parameters.AddWithValue("@dispatchPoint",ship.dispatchPoint);
            cmd.Parameters.AddWithValue("@transportationPoint",ship.transportationPoint);
            cmd.Parameters.AddWithValue("@distance",ship.distance);
            cmd.Parameters.AddWithValue("@amount",ship.amount);
            return Tools.ConnectSet(cmd);

        }

        public static bool sevkiyatGüncelle(Shipments ship)
        {

            SqlCommand cmd = new SqlCommand("shipmentUpdate", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@shipmentNum",ship.shipmentNumber);
            cmd.Parameters.AddWithValue("@shipmentName", ship.shipmentName);
            cmd.Parameters.AddWithValue("@dispatchPoint", ship.dispatchPoint);
            cmd.Parameters.AddWithValue("@transportationPoint", ship.transportationPoint);
            cmd.Parameters.AddWithValue("@distance", ship.distance);
            cmd.Parameters.AddWithValue("@amount", ship.amount);
            return Tools.ConnectSet(cmd);


        }

        public static bool sevkiyatSil(Shipments ship)
        {

            SqlCommand cmd = new SqlCommand("shipmentDel",Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("shipmentNum",ship.shipmentNumber);


            return Tools.ConnectSet(cmd);
        }

        public static DataTable sevkiyatList()
        {
            SqlCommand cmd = new SqlCommand("shipmentList",Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


           

        }

        public static DataTable comboListSevkiyat()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter("select shipmentNum from Sevkiyatlar", Tools.baglanti);
            sda.Fill(dt);
            return dt;



        }



        #endregion




        #region Araç raporları

        public static DataTable sürücüAdAracBul(string sürücüAd)
        {

            SqlCommand cmd = new SqlCommand("sürücüAdAracBul", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@driverName", sürücüAd);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }
        public static DataTable aracMüsteriList(string aracMarka)
        {

            SqlCommand cmd = new SqlCommand("aracMüsteriListesi", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@carName", aracMarka);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }

        public static DataTable giderDegerler(int minDeger,int maxDeger)
        {

            SqlCommand cmd = new SqlCommand("aracSevkiyatGider", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@minExpense", minDeger);
            cmd.Parameters.AddWithValue("@maksExpense", maxDeger);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }


        public static DataTable giderSiralamaAzCok()
        {
            SqlCommand cmd = new SqlCommand("aracGiderAzCok",Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }
        public static DataTable giderSiralamaCokAz()
        {
            SqlCommand cmd = new SqlCommand("aracGiderCokAz", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;


            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }


        #endregion

     
        #region Müşteri raporları

        public static DataTable müsteriAracGetir(string müsteriAd)
        {
            SqlCommand cmd = new SqlCommand("müsteriArac", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@customername", müsteriAd);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;

        }


        public static DataTable müsteriMarkaVaris(string müsteriAdi)
        {
            SqlCommand cmd = new SqlCommand("müsteriMarkaVarislar", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@customername", müsteriAdi);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;


        }



        public static DataTable ödemeyenMüsteriler()
        {
            SqlCommand cmd = new SqlCommand("ödemeyenMüsteri", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;



        }


        public static DataTable müsteriPersonel(string adres)
        {
            SqlCommand cmd = new SqlCommand("müsteriPersonel", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@customerAdress", adres);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;




        }







        #endregion


        #region Personel raporları
        public static DataTable personelUnvanGrup()
        {
            SqlCommand cmd = new SqlCommand("persUnvanGrup", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;



        }


        public static DataTable maasAralik(decimal minMaas,decimal maksMaas)
        {
            SqlCommand cmd = new SqlCommand("maasAralik", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@minSalary", minMaas);
            cmd.Parameters.AddWithValue("@maksSalary", maksMaas);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }

        public static DataTable personelSevk(string isimPersonel)
        {
            
            SqlCommand cmd = new SqlCommand("persSevk", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@employeeName", isimPersonel);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }
        public static DataTable personelSevkTutar(string personelAdim)
        {

            SqlCommand cmd = new SqlCommand("persSevkTuta", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@employeeName", personelAdim);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }
        #endregion

        #region Sevkiyat
        public static DataTable varisAracSürücüGideri(string varisNokta)
        {

            SqlCommand cmd = new SqlCommand("varisAracSürücüGider", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@transportationPoint", varisNokta);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }
        public static DataTable tutarAralikSevkAdi(int minTutar,int maksTutar)
        {

            SqlCommand cmd = new SqlCommand("tutarAralikSevkAd", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@miniTutar", minTutar);
            cmd.Parameters.AddWithValue("@maksTutar", maksTutar);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;

        }

        public static DataTable sevkAdiMarkaKapasite(string sevkAdi)
        {
            SqlCommand cmd = new SqlCommand("sevkAdiMarkaKapasitem", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@shipmentName", sevkAdi);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }

        //sevkAdiMarkaMüsAdiPersAdi

        public static DataTable sevkAdiMarkaMüsAdiPersAdim(string sevkAdi)
        {
            SqlCommand cmd = new SqlCommand("sevkAdiMarkaMüsAdiPersAdi", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@shipmentName", sevkAdi);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }
        public static DataTable sevkKalkisNoktasi(string kalkisNokta)
        {
            SqlCommand cmd = new SqlCommand("kalkisNoktasiTutar", Tools.baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dispatchPoint", kalkisNokta);

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;


        }


        #endregion

    }
}
