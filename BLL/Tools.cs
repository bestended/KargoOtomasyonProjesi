﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace BLL
{
    public class Tools
    {

        public static SqlConnection baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Kargo"].ToString());
        public static bool ConnectSet(SqlCommand command)
        {

            try
            {

                if (command.Connection.State != System.Data.ConnectionState.Open)
                    command.Connection.Open();
                return command.ExecuteNonQuery() > 0;



            }
            catch
            {

                return false;
            }

            finally
            {
                if (command.Connection.State != System.Data.ConnectionState.Closed)
                {
                    command.Connection.Close();
                }
            }



        }

    }
}
