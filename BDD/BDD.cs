using System;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace ConnexionBDD
{
    public class BDD
    {
        private static MySqlConnection maCnx;

        public static bool InitConnexion()
        {
            string serveur = "10.1.139.236";
            string login = "f1";
            string passwd = "mdp";
            string BD = "basef1";
            string chaineDeConnexion = $"server={serveur};uid={login};pwd={passwd}; database={BD}";

            maCnx = new MySqlConnection(chaineDeConnexion);

            try
            {
                maCnx.Open();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public static bool CloseConnexion()
        {
            try
            {
                if (maCnx.State == System.Data.ConnectionState.Open)
                {
                    maCnx.Close();
                    maCnx.Dispose();
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }


        public static String GetTest()
        {
            string sql;
            string reponse = "";

            sql = $"SELECT * FROM Ligne";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    reponse = reponse + rdr.GetInt32(0).ToString() + " |";
                }

                rdr.Close();

                cmd.Dispose();

                return reponse;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                reponse = ex.ToString();
                return reponse;
            }
        }


        public static void Affiche(string table)
        {
            string serveur = "10.1.139.236";
            string login = "f1";
            string passwd = "mdp";
            string BD = "basef1";
            string chaineDeConnection = $"server={serveur};uid={login};pwd={passwd};database={BD}";

            MySqlConnection MaCnx = new MySqlConnection(@chaineDeConnection);

            string sql = $"SELECT * FROM {table}";

            try
            {
                MaCnx.Open();

                MySqlCommand cmd = new MySqlCommand(sql, MaCnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        Debug.Print(rdr.GetValue(i).ToString());
                    }
                }

                MaCnx.Dispose();
                MaCnx.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
