using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using Information;

namespace ConnexionBD
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


        public static void FermerConnexion()
        {
            if (maCnx.State == System.Data.ConnectionState.Open)
                maCnx.Close();
        }


        public static int GetTableCount(string tablename)
        {
            int compteur = 0;

            string sql = $"SELECT COUNT(*) FROM {tablename}";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    compteur = rdr.GetInt32(0);
                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return compteur;
        }

        public static string[] GetAllArret()
        {

            int nbrArret = information.GetNbrArret();
            //Debug.Print($"Nombre d'arret : {nbrArret}");
            string[] arret = new string[nbrArret];
            int compteur = 0;

            string sql = $"SELECT * FROM Arret";

            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    /*
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        Debug.Print(rdr.GetValue(i).ToString());
                    }
                    */
                    //Debug.Print(rdr.GetValue(1).ToString());

                    arret[compteur] = rdr.GetValue(1).ToString();
                    compteur++;
                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return arret;
        }


        public static string[] GetAllLigne()
        {

            int nbrLigne = information.GetNbrLigne();
            //Debug.Print($"Nombre de ligne : {nbrLigne}");
            string[] ligne = new string[nbrLigne];
            int compteur = 0;

            string sql = $"SELECT * FROM Ligne";

            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    ligne[compteur] = rdr.GetValue(1).ToString();
                    compteur++;
                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return ligne;
        }

        public static int GetNumLigne(string nomDeLaLigne)
        {

            string sql = $"SELECT N_ligne FROM Ligne WHERE Nom_ligne = '{nomDeLaLigne}'";
            int numeroDeLaLigne = 0;

            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    numeroDeLaLigne = rdr.GetInt32(0);
                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return numeroDeLaLigne;
        }

        public static string GetNomArret(int numDeLarret)
        {

            string sql = $"SELECT Nom_Arret FROM Arret WHERE N_Arret = {numDeLarret}";
            string nomDeLarret = "";

            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    nomDeLarret = rdr.GetString(0);
                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return nomDeLarret;
        }

        public static int GetNumArret(string nomDeLarret)
        {
            
            string sql = $"SELECT N_Arret FROM Arret WHERE Nom_Arret = '{nomDeLarret}'";
            int numArret = 0;

            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    numArret = rdr.GetInt32(0);
                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return numArret;
        }

        public static int[] GetAllArretInLigne(int Num_ligne)
        {

            string sql = $"SELECT * FROM Positionnement WHERE N_ligne = {Num_ligne} GROUP BY Rang_Arret";
            int[] arretEtRangDeLarret = new int[20];
            int compteur = 0;

            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {

                    arretEtRangDeLarret[compteur] = rdr.GetInt32(1);
                    compteur++;

                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return arretEtRangDeLarret;
        }

        public static bool ModifierNomArret(int numArret, string nouveauNomArret)
        {
            bool retour = true;

            string sql = $"UPDATE Arret SET Nom_Arret='{nouveauNomArret}' WHERE N_Arret={numArret}";

            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                retour = false;
            }

            return retour;
        }

        public static int AjoutArret(string nomArret)
        {
            int retour = -1;


            string sql = $"INSERT INTO Arret (Nom_Arret) VALUES ('{nomArret}')";

            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                cmd.ExecuteNonQuery();
                retour = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }

            return retour;
        }

        public static bool SupprimerUnArretDesLignes(int num_Arret)
        {
            bool retour = true;

            string sql = $"DELETE FROM Positionnement WHERE N_Arret = {num_Arret}";

            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                retour = false;
            }

            return retour;
        }


        public static int AjoutLigne(string nomLigne, string couleurLigne)
        {
            int retour = -1;


            string sql = $"INSERT INTO Ligne (Nom_ligne,Etat_ligne,Couleur_ligne) VALUES ('{nomLigne}',1,'{couleurLigne}')";

            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                cmd.ExecuteNonQuery();
                retour = (int)cmd.LastInsertedId;
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
            }

            return retour;
        }


        public static bool AjoutPositionnement(int n_Ligne, int n_Arret, int rang_Arret)
        {
            bool retour = true;


            string sql = $"INSERT INTO Positionnement (N_ligne,N_Arret,Rang_Arret) VALUES ({n_Ligne},{n_Arret},{rang_Arret})";

            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.Print(ex.Message);
                retour = false;
            }

            return retour;
        }

        public static int GetPosition(int Num_ligne, int Num_Arret)
        {

            string sql = $"SELECT * FROM Positionnement WHERE N_ligne = {Num_ligne} AND N_Arret = {Num_Arret}";
            int rang = -1;

            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    rang = rdr.GetInt32(2);
                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return rang;
        }

        public static bool SetPosition(int Num_ligne, int Num_Arret, int Rang_Arret)
        {
            bool retour = true;

            string sql = $"UPDATE Positionnement SET Rang_Arret={Rang_Arret} WHERE N_ligne={Num_ligne} AND N_Arret={Num_Arret}";

            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                retour = false;
            }

            return retour;
        }

        public static bool SupprimerArret(int num_Arret)
        {
            bool retour = true;

            string sql = $"DELETE FROM Arret WHERE N_Arret = {num_Arret}";

            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                retour = false;
            }

            return retour;
        }
    }
}
