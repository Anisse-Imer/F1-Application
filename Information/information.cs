using System;

namespace Information
{
    public class information
    {
        private static bool admin = false;
        private static int nbrArret;
        private static int nbrLigne;


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

        public static bool GetAdminMode()
        {
            return admin;
        }

        public static void SetNbrArret(int newNbrArret)
        {
            nbrArret = newNbrArret;
        }

        public static void AddArret()
        {
            nbrArret = nbrArret + 1;
        }

        public static void RemoveArret()
        {
            nbrArret = nbrArret - 1;
        }

        public static int GetNbrArret()
        {
            return nbrArret;
        }

        public static void SetNbrLigne(int newNbrLigne)
        {
            nbrLigne = newNbrLigne;
        }

        public static void AddLigne()
        {
            nbrLigne = nbrLigne + 1;
        }

        public static void RemoveLigne()
        {
            nbrLigne = nbrLigne - 1;
        }

        public static int GetNbrLigne()
        {
            return nbrLigne;
        }

    }
}
