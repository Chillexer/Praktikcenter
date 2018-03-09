using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace GeoTema
{
    class Connection
    {
        private static SqlConnection server;
        public static string name;

        public Connection() { }

        public Connection(string username, string password, string db)
        {
            //Gemmer brugernavn til senere brug
            name = username;

            //Samling af data der indeholder alle serverens forbindelses informationtioner
            server = new SqlConnection(
              "server=" + db + ";" +
              "database=fødselsrate_2017; " +
              "user id=" + username + ";" +
              "password=" + password + ";" +
              "connection timeout=10");
        }

        public Exception Login()
        {
            try
            {
                //Åbner forbindelsen til serveren
                server.Open();

                //Returnere NULL
                return null;
            }
            catch (Exception e)
            {
                //Returnere exceptionen
                return e;
            }
            finally
            {
                //Lukker forbindelsen til serveren
                server.Close();
            }
        }

        public void Send(string query)
        {
            try
            {
                //Åbner forbindelsen til serveren
                server.Open();

                //En SQL kommando bliver lavet udfra input
                SqlCommand cmd = new SqlCommand(query, server);

                //Udføre kommandoen
                cmd.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                //Lukker forbindelsen til serveren
                server.Close();
            }
        }

        public static List<string> Get(string query)
        {
            //En string liste bliver lavet
            List<string> temp = new List<string>();

            try
            {
                //Åbner forbindelsen til serveren
                server.Open();

                //En SQL kommando bliver lavet udfra input
                SqlCommand cmd = new SqlCommand(query, server);

                //Bruger SQL reader og lukker forbindelse efter den er færdig
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    //Så længe der er noget at læse vil while loopet køre
                    while (reader.Read())
                    {
                        //Tilføjer informationer fra datareader til temp listen
                        temp.Add(reader.GetString(0));
                    }
                }
            }
            catch { }
            finally
            {
                //Lukker forbindelsen til serveren
                server.Close();
            }
            return temp;
        }

        public static DataSet grid()
        {
            try
            {
                //Hvad skal den hente
                string sql = "SELECT Land.ID,Land.Land,Land.Verdensdel,Rang.Rang,Rang.Fødselsrate FROM Land,Rang WHERE Land.id = Rang.id;";

                //Adaptaren bruges til at hente data
                SqlDataAdapter dataadapter = new SqlDataAdapter(sql, server);

                //Et dataset bliver lavet
                DataSet ds = new DataSet();

                //Åbner forbindelsen til serveren
                server.Open();

                //Adapteren fylder et dataset
                dataadapter.Fill(ds, "*");

                //Dataset returneres
                return ds;
            }
            catch (Exception)
            {
            }
            finally
            {
                //Lukker forbindelsen til serveren
                server.Close();
            }
            return null;
        }
    }
}