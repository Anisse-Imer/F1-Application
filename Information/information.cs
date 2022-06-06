using System;

namespace Information
{
    public class information
    {
        private static bool admin = false;
        private static int nbrArret;
        private static int nbrLigne;

        /// <summary>
        /// Change le mode admin à true ou false
        /// </summary>
        public static void ChangeAdminMode()
        {
            if(admin == false)
            {
                admin = true;
            }
            else
            {
                admin = false;
            }
        }

        /// <summary>
        /// Permet de savoir si le mode admin est activé ou non
        /// </summary>
        /// <returns>true ou false</returns>
        public static bool GetAdminMode()
        {
            return admin;
        }

        /// <summary>
        /// Permet de modifier le nombre d'arrêts
        /// </summary>
        /// <param name="newNbrArret">Le nouveau nombre d'arrêts</param>
        public static void SetNbrArret(int newNbrArret)
        {
            nbrArret = newNbrArret;
        }

        /// <summary>
        /// Permet de rajouter 1 au nombre d'arrêts
        /// </summary>
        public static void AddArret()
        {
            nbrArret = nbrArret + 1;
        }

        /// <summary>
        /// Permet de retirer 1 au nombre d'arrêts
        /// </summary>
        public static void RemoveArret()
        {
            nbrArret = nbrArret - 1;
        }

        /// <summary>
        /// Permet d'obtenir le nombre d'arrêts
        /// </summary>
        /// <returns>Le nombre d'arrêts</returns>
        public static int GetNbrArret()
        {
            return nbrArret;
        }

        /// <summary>
        /// Permet de définir le nombre de lignes
        /// </summary>
        /// <param name="newNbrLigne">Le nouveau nombre de lignes</param>
        public static void SetNbrLigne(int newNbrLigne)
        {
            nbrLigne = newNbrLigne;
        }

        /// <summary>
        /// Permet de rajouter 1 au nombre de lignes
        /// </summary>
        public static void AddLigne()
        {
            nbrLigne = nbrLigne + 1;
        }

        /// <summary>
        /// Permet de retirer 1 au nombre de lignes
        /// </summary>
        public static void RemoveLigne()
        {
            nbrLigne = nbrLigne - 1;
        }

        /// <summary>
        /// Permet d'obtenir le nombre de lignes
        /// </summary>
        /// <returns>Le nombre de lignes</returns>
        public static int GetNbrLigne()
        {
            return nbrLigne;
        }

    }
}
