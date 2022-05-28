using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ConnexionBD2
{
    public static class BDD
    {

        private static MySqlConnection maCnx;

        public static bool InitConnexion()
        {
            string serveur = "10.1.139.236";
            string login = "f1";
            string passwd = "mdp";
            string BD = "basef1";
            string chaineDeConnexion = $"server={serveur};uid={login};pwd={passwd};database={BD}";

            bool retour = true;

            maCnx = new MySqlConnection(chaineDeConnexion);

            try
            {
                maCnx.Open();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                retour = false;

            }
            return retour;
        }
    }
}
