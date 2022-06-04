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


        /// <summary>
        /// Initialise la connexion avec la BDD
        /// </summary>
        /// <returns>true ou false selon si la fonction a réussi à se connecter à la BDD</returns>
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

        /// <summary>
        /// Ferme la connexion avec la CDD
        /// </summary>
        public static void FermerConnexion()
        {
            if (maCnx.State == System.Data.ConnectionState.Open)
                maCnx.Close();
        }

        /// <summary>
        /// Permet de savoir le nombre d'entrée dans une table
        /// </summary>
        /// <param name="tablename">Le nom de la table choisi</param>
        /// <returns>Le nombre d'entrée dans une table</returns>
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

        /// <summary>
        /// Permet d'obtenir tout les noms des arrêts du réseau
        /// </summary>
        /// <returns>Les noms des arrêts du réseau</returns>
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

        /// <summary>
        /// Permet d'obtenir tout les noms des lignes du réseau
        /// </summary>
        /// <returns>Les noms des lignes du réseau</returns>
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

        /// <summary>
        /// Permet d'obtenir le numéro d'une ligne en fonction de son nom
        /// </summary>
        /// <param name="nomDeLaLigne">Le nom de la ligne</param>
        /// <returns>Le numéro de la ligne</returns>
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


        /// <summary>
        /// Permet d'obtenir le nom d'une ligne en fonction de son numéro
        /// </summary>
        /// <param name="numDeLaLigne">Le numéro de la ligne</param>
        /// <returns>Le nom de la ligne</returns>
        public static string GetNomLigne(int numDeLaLigne)
        {

            string sql = $"SELECT Nom_ligne FROM Ligne WHERE N_ligne = {numDeLaLigne}";
            string nomDeLaLigne = "";

            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    nomDeLaLigne = rdr.GetString(0);
                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return nomDeLaLigne;
        }

        /// <summary>
        /// Permet d'obtenir le nom d'un arrêt en fonction de son numéro
        /// </summary>
        /// <param name="numDeLarret">Le numéro de l'arrêt</param>
        /// <returns>Le nom de l'arrêt</returns>
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

        /// <summary>
        /// Permet d'obtenir le numéro d'un arrêt en fonction de son nom
        /// </summary>
        /// <param name="nomDeLarret">Le nom de l'arrêt</param>
        /// <returns>Le numéro de l'arrêt</returns>
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

        /// <summary>
        /// Permet d'obtenir tout les arrêts d'une ligne
        /// </summary>
        /// <param name="Num_ligne">Le numéro de la ligne</param>
        /// <returns>Le numéro des arrêts de la ligne</returns>
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

        /// <summary>
        /// Permet de modifier le nom d'un arrêt
        /// </summary>
        /// <param name="numArret">Le numéro de l'arrêt</param>
        /// <param name="nouveauNomArret">Le nouveau nom de l'arrêt</param>
        /// <returns>true ou false selon si la commande a fonctionné ou non</returns>
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

        /// <summary>
        /// Permet de rajout un arrêt dans le réseau
        /// </summary>
        /// <param name="nomArret">Le nom de l'arrêt</param>
        /// <returns>true ou false selon si la commande a fonctionné ou non</returns>
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

        /// <summary>
        /// Permet de supprimer un arrêt de la table Positionnement
        /// </summary>
        /// <param name="num_Arret">Le numéro de l'arrêt</param>
        /// <returns>true ou false selon si la commande a fonctionné ou non</returns>
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

        /// <summary>
        /// Permet d'ajouter une ligne
        /// </summary>
        /// <param name="nomLigne">Le nom de la ligne</param>
        /// <param name="couleurLigne">La couleur de la ligne</param>
        /// <returns>Le numéro de la nouvelle ligne</returns>
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

        /// <summary>
        /// Permet d'ajouter le positionnement d'un arrêt sur une ligne
        /// </summary>
        /// <param name="n_Ligne">Le numéro de la ligne</param>
        /// <param name="n_Arret">Le numéro de l'arrêt</param>
        /// <param name="rang_Arret">Le rang de l'arrêt</param>
        /// <returns>true ou false selon si la commande a fonctionné ou non</returns>
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

        /// <summary>
        /// Permet de modifier le positionnement d'un arrêt sur une ligne
        /// </summary>
        /// <param name="numLigne">Le numéro de la ligne</param>
        /// <param name="numArret">Le numéro de l'arrêt</param>
        /// <param name="rangArret">Le rang de l'arrêt</param>
        /// <returns>true ou false selon si la commande a fonctionné ou non</returns>
        public static bool ModifierPositionnement(int numLigne, int numArret, int rangArret)
        {
            bool retour = true;

            string sql = $"UPDATE Positionnement SET Rang_Arret={rangArret} WHERE N_Arret={numArret} AND N_ligne={numLigne}";

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

        /// <summary>
        /// Permet d'obtenir la position d'un arrêt sur une ligne
        /// </summary>
        /// <param name="Num_ligne">Le numéro de la ligne</param>
        /// <param name="Num_Arret">Le numéro de l'arrêt</param>
        /// <returns>La position de l'arrêt</returns>
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

        /// <summary>
        /// Permet de modifier le positionnement d'un arrêt sur une ligne
        /// </summary>
        /// <param name="Num_ligne">Le numéro de la ligne</param>
        /// <param name="Num_Arret">Le numéro de l'arrêt</param>
        /// <param name="Rang_Arret">Le rang de l'arrêt</param>
        /// <returns>true ou false selon si la commande a fonctionné ou non</returns>
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

        /// <summary>
        /// Permet de supprimer un arrêt
        /// </summary>
        /// <param name="num_Arret">Le numéro de l'arrêt</param>
        /// <returns>true ou false selon si la commande a fonctionné ou non</returns>
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

        /// <summary>
        /// Permet de supprimer une ligne de la table Positionnement
        /// </summary>
        /// <param name="num_Ligne">Le numéro de la ligne</param>
        /// <returns>true ou false selon si la commande a fonctionné ou non</returns>
        public static bool SupprimerLignePositionnement(int num_Ligne)
        {
            bool retour = true;

            string sql = $"DELETE FROM Positionnement WHERE N_ligne = {num_Ligne}";

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

        /// <summary>
        /// Permet de supprimer une ligne
        /// </summary>
        /// <param name="num_Ligne">Le numéro de la ligne</param>
        /// <returns>true ou false selon si la commande a fonctionné ou non</returns>
        public static bool SupprimerLigne(int num_Ligne)
        {
            bool retour = true;

            string sql = $"DELETE FROM Ligne WHERE N_ligne = {num_Ligne}";

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

        /// <summary>
        /// Permet d'obtenir la couleur d'une ligne
        /// </summary>
        /// <param name="num_Ligne">Le numéro de la ligne</param>
        /// <returns>La couleur</returns>
        public static string GetCouleur(int num_Ligne)
        {

            string sql = $"SELECT Couleur_ligne FROM Ligne WHERE N_ligne = {num_Ligne}";
            string couleur = "rouge";

            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    couleur = rdr.GetString(0);
                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return couleur;
        }

        /// <summary>
        /// Permet d'obtenir l'heure de début d'une ligne
        /// </summary>
        /// <param name="num_Ligne">Le numéro de la ligne</param>
        /// <returns>L'heure et la minute du début de la ligne</returns>
        public static int[] GetPassageDebut(int num_Ligne)
        {

            // string sql = $"SELECT HOUR(Heure_debut), MINUTE(Heure_debut) FROM Passage WHERE N_ligne = {num_Ligne} AND ((HOUR(Heure_debut) < {heure}) OR (HOUR(Heure_debut) <= {heure} AND MINUTE(Heure_debut) <= {minute})) ";
            string sql = $"SELECT HOUR(Heure_debut), MINUTE(Heure_debut) FROM Passage WHERE N_ligne = {num_Ligne}";
            int[] Heure_Debut_Passage = new int[2];

            Heure_Debut_Passage[0] = -1;

            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Heure_Debut_Passage[0] = rdr.GetInt32(0);
                    Heure_Debut_Passage[1] = rdr.GetInt32(1);

                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return Heure_Debut_Passage;
        }

        /// <summary>
        /// Permet d'obtenir l'heure de la fin d'une ligne
        /// </summary>
        /// <param name="num_Ligne">Le numéro de la ligne</param>
        /// <returns>L'heure et la minute de la fin de la ligne</returns>
        public static int[] GetPassageFin(int num_Ligne)
        {

            string sql = $"SELECT HOUR(Heure_fin), MINUTE(Heure_fin) FROM Passage WHERE N_ligne = {num_Ligne}";
            int[] Heure_Debut_Passage = new int[2];

            Heure_Debut_Passage[0] = -1;

            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Heure_Debut_Passage[0] = rdr.GetInt32(0);
                    Heure_Debut_Passage[1] = rdr.GetInt32(1);

                }

                rdr.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return Heure_Debut_Passage;
        }

        /// <summary>
        /// Permet d'obtenir le temps entre deux arrêts
        /// </summary>
        /// <param name="num_Arret1">Le numéro de l'arrêt 1</param>
        /// <param name="num_Arret2">Le numéro de l'arrêt 2</param>
        /// <returns>Le temps entre les deux arrêts</returns>
        public static int TempsEntreArret(int num_Arret1, int num_Arret2)
        {

            string sql = $"SELECT MINUTE(Temps_entre_arrets) FROM Trajet WHERE N_Arret={num_Arret1} AND N_Arret_1={num_Arret2}";
            int temps = -1;

            try
            {

                MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                MySqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    temps = rdr.GetInt32(0);
                }

                rdr.Close();
                cmd.Dispose();
            }
            finally
            {
                sql = $"SELECT MINUTE(Temps_entre_arrets) FROM Trajet WHERE N_Arret={num_Arret2} AND N_Arret_1={num_Arret1}";

                try
                {

                    MySqlCommand cmd = new MySqlCommand(sql, maCnx);
                    MySqlDataReader rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        temps = rdr.GetInt32(0);
                    }

                    rdr.Close();
                    cmd.Dispose();
                }
                catch
                {
                    
                }
            }

            return temps;
        }

        /// <summary>
        /// Permet d'ajouter un temps entre deux arrêts
        /// </summary>
        /// <param name="numArret1">Le numéro du première arrêt</param>
        /// <param name="numArret2">Le numéro du deuxième arrêt</param>
        /// <param name="tempsEntreArret">Le temps entre les deux arrêts</param>
        /// <returns>true ou false selon si la commande a fonctionné ou non</returns>
        public static bool AjoutTempsEntreArret(int numArret1, int numArret2, int tempsEntreArret)
        {
            bool retour = true;

            string temps;
            if(tempsEntreArret < 10){
                temps = $"00:0{tempsEntreArret}:00.0000";
            }
            else
            {
                temps = $"00:{tempsEntreArret}:00.0000";
            }
            string sql = $"INSERT INTO Trajet (N_Arret,N_Arret_1,Temps_entre_arrets) VALUES ({numArret1},{numArret2},'{temps}')";

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

        /// <summary>
        /// permet de supprimet un temps entre deux arrêt
        /// </summary>
        /// <param name="num_Arret">l'arrêt que l'on veut supprimer</param>
        /// <returns>true ou false selon si la commande a fonctionné ou non</returns>
        public static bool SupprimerTempsArret(int num_Arret)
        {
            bool retour = true;

            string sql = $"DELETE FROM Trajet WHERE N_Arret = {num_Arret}";

            MySqlCommand cmd = new MySqlCommand(sql, maCnx);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                sql = $"DELETE FROM Trajet WHERE N_Arret_1 = {num_Arret}";

                cmd = new MySqlCommand(sql, maCnx);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    retour = false;
                }
            }

            return retour;
        }

        /// <summary>
        /// Permet d'ajouter un bus
        /// </summary>
        /// <returns>le numéro du nouveau bus</returns>
        public static int AjoutBus()
        {
            int retour = -1;

            string sql = $"INSERT INTO Bus (Nb_Place_Bus) VALUES (50)";

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


        public static bool AjoutPassage(int numLigne, int heureDebutLigne, int minuteDebutLigne, int heureFinLigne, int minuteFinLigne, int numBus)
        {
            bool retour = true;

            string debutLigne;
            string finLigne;

            if (heureDebutLigne < 10)
            {
                if(minuteDebutLigne < 10)
                {
                    debutLigne = $"0{heureDebutLigne}:0{minuteDebutLigne}:00.0000";
                }
                else
                {
                    debutLigne = $"0{heureDebutLigne}:{minuteDebutLigne}:00.0000";
                }
                
            }
            else
            {
                if (minuteDebutLigne < 10)
                {
                    debutLigne = $"{heureDebutLigne}:0{minuteDebutLigne}:00.0000";
                }
                else
                {
                    debutLigne = $"{heureDebutLigne}:{minuteDebutLigne}:00.0000";
                }
            }


            if (heureFinLigne < 10)
            {
                if (minuteFinLigne < 10)
                {
                    finLigne = $"0{heureFinLigne}:0{minuteFinLigne}:00.0000";
                }
                else
                {
                    finLigne = $"0{heureFinLigne}:{minuteFinLigne}:00.0000";
                }

            }
            else
            {
                if (minuteDebutLigne < 10)
                {
                    finLigne = $"{heureFinLigne}:0{minuteFinLigne}:00.0000";
                }
                else
                {
                    finLigne = $"{heureFinLigne}:{minuteFinLigne}:00.0000";
                }
            }


            string sql = $"INSERT INTO Passage (Heure_debut, Heure_fin, N_ligne, N_Bus) VALUES ('{debutLigne}', '{finLigne}', {numLigne}, {numBus})";
            
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



        public static bool ModifieDebutPassage(int numLigne, int heureDebutLigne, int minuteDebutLigne)
        {
            bool retour = true;

            string debutLigne;

            if (heureDebutLigne < 10)
            {
                if (minuteDebutLigne < 10)
                {
                    debutLigne = $"0{heureDebutLigne}:0{minuteDebutLigne}:00.0000";
                }
                else
                {
                    debutLigne = $"0{heureDebutLigne}:{minuteDebutLigne}:00.0000";
                }

            }
            else
            {
                if (minuteDebutLigne < 10)
                {
                    debutLigne = $"{heureDebutLigne}:0{minuteDebutLigne}:00.0000";
                }
                else
                {
                    debutLigne = $"{heureDebutLigne}:{minuteDebutLigne}:00.0000";
                }
            }

            string sql = $"UPDATE Passage SET Heure_debut='{debutLigne}' WHERE N_ligne={numLigne}";


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


        public static bool ModifieFinPassage(int numLigne, int heureFinLigne, int minuteFinLigne)
        {
            bool retour = true;

            string finLigne;

            if (heureFinLigne < 10)
            {
                if (minuteFinLigne < 10)
                {
                    finLigne = $"0{heureFinLigne}:0{minuteFinLigne}:00.0000";
                }
                else
                {
                    finLigne = $"0{heureFinLigne}:{minuteFinLigne}:00.0000";
                }

            }
            else
            {
                if (minuteFinLigne < 10)
                {
                    finLigne = $"{heureFinLigne}:0{minuteFinLigne}:00.0000";
                }
                else
                {
                    finLigne = $"{heureFinLigne}:{minuteFinLigne}:00.0000";
                }
            }

            string sql = $"UPDATE Passage SET Heure_fin='{finLigne}' WHERE N_ligne={numLigne}";


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

        public static bool SupprimerPassage(int num_Ligne)
        {
            bool retour = true;

            string sql = $"DELETE FROM Passage WHERE N_ligne = {num_Ligne}";

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

        public static bool SupprimerUnArretDuneLignes(int numLigne, int numArret)
        {
            bool retour = true;

            string sql = $"DELETE FROM Positionnement WHERE N_ligne = {numLigne} AND N_Arret = {numArret}";

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
