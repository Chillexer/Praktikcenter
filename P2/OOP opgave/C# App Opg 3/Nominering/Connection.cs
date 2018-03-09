using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Nominering
{
    class Connection
    {
        static public MySqlConnection Conn { get; set; }
        public bool ConnWorking { get; set; }
        public Exception ex { get; set; }

        public Connection(string username, string password, string server)//denne constructor opretter klassen
        {
            string database = "Nominerede";
            string uid = username;
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            Conn = new MySqlConnection(connectionString);
            TestConn();
        }
        private void TestConn()//denne metode tjekker om koden og brugernavnet er korrekt
        {
            try
            {
                Conn.Open();
                ConnWorking = true;
                ex = null;
            }
            catch(Exception e)
            {
                ex = e;
            }
            finally
            {
                Conn.Close();
            }
        }
        static public DataTable Reload()//denne metode henter data fra Film tabelen og returner dem
        {
            DataTable dt = new DataTable();
            try
            {
                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Film", Conn))
                {
                    Conn.Open();
                    using (dt)
                    {
                        da.Fill(dt);
                    }
                }
            }
            finally
            {
                Conn.Close();
            }
            return dt;
        }
        static public Exception Delete(int ID, int N) // denne metode sletter en række i film udfra hvilket id der er angivet
        {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM Film WHERE ID = " + ID 
                + "; ALTER TABLE Film AUTO_INCREMENT = "+ N + ";", Conn );
            try
            {
                Conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return e;
            }
            finally
            {
                Conn.Close();
            }
            return null;
        }
        static public Exception Insert(List<string> values) // denne metode indsætter en række i tabellen med de data den får i listen
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO Film (Titel,Year,Genre,Skuespillere)" + 
                $"VALUES ('{values[0]}','{values[1]}','{values[2]}','{values[3]}')", Conn);
            try
            {
                Conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                return e;
            }
            finally
            {
                Conn.Close();
            }
            return null;
        }
    }
}
