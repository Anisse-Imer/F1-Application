using System;

namespace Information
{
    public class information
    {
        private static bool admin = true;
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

        public static int GetNbrArret()
        {
            return nbrArret;
        }

        public static void SetNbrLigne(int newNbrLigne)
        {
            nbrLigne = newNbrLigne;
        }

        public static int GetNbrLigne()
        {
            return nbrLigne;
        }
    }
}
