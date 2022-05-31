using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Information;
using ConnexionBD;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace F1_Application
{
    public partial class frmAccueil : Form
    {
        public frmAccueil()
        {
            InitializeComponent();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            bool connexionOuvertre = BDD.InitConnexion();

            this.Icon = Properties.Resources.chaperon_rouge;

            if (connexionOuvertre != true)
            {
                MessageBox.Show("Echec de la connexion à la BDD");
                Application.Exit();
            }
            
            
            int newNbrArret = BDD.GetTableCount("Arret");
            information.SetNbrArret(newNbrArret);

            
            int newNbrLigne = BDD.GetTableCount("Ligne");
            information.SetNbrLigne(newNbrLigne);


            Reload();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmdConnexionAdmin_Click(object sender, EventArgs e)
        {
            frmConnexionAdmin connexionAdmin = new frmConnexionAdmin();
            connexionAdmin.ShowDialog();

            if (information.GetAdminMode())
            {
                cmdConnexionAdmin.Visible = false;
                cmdGererLignes.Visible = true;
                cmdGererArrêts.Visible = true;
                cmdDeconnexionAdmin.Visible = true;
            }
        }

        private void cmdDeconnexionAdmin_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment quitter le mode administrateur ?", "Quitter le mode administrateur", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                cmdConnexionAdmin.Visible = true;
                cmdGererLignes.Visible = false;
                cmdGererArrêts.Visible = false;
                cmdDeconnexionAdmin.Visible = false;

                information.ChangeAdminMode();
            }       
        }

        private void Accueil_FormClosed(object sender, FormClosedEventArgs e)
        {
            BDD.FermerConnexion();
        }

        private void Accueil_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void cmdVisualisation_Click(object sender, EventArgs e)
        {
            if(cboVisualiserLigne.SelectedItem != null)
            {

                if(cboVisualiserLigne.SelectedItem.ToString() == "Toutes les lignes")
                {
                    string[] ligne;
                    ligne = BDD.GetAllLigne();
                    int i;

                    lblVisualiserLigne.Text = "";

                    for (int j = 0; j < ligne.Length; j++)
                    {
                        int Num_Ligne = BDD.GetNumLigne(ligne[j]);
                        i = 0;

                        int[] arretEtRangDeLarret = new int[20];
                        arretEtRangDeLarret = BDD.GetAllArretInLigne(Num_Ligne);

                        lblVisualiserLigne.Text += $"{ligne[j]} :";
                        while (arretEtRangDeLarret[i + 1] != 0)
                        {

                            if (i % 3 == 0)
                            {
                                lblVisualiserLigne.Text += "\n";
                            }
                            lblVisualiserLigne.Text += $"{BDD.GetNomArret(arretEtRangDeLarret[i])} --> ";
                            i++;
                        }
                        if (i % 3 == 0)
                            lblVisualiserLigne.Text += "\n";
                        lblVisualiserLigne.Text += $"{BDD.GetNomArret(arretEtRangDeLarret[i])}";
                        lblVisualiserLigne.Text += "\n\n";
                    }
                }
                else
                {
                    

                    // Affichage de la ligne dans l'application

                    int i = 0;
                    int Num_Ligne = BDD.GetNumLigne(cboVisualiserLigne.SelectedItem.ToString());
                    int[] arretEtRangDeLarret = new int[20];
                    arretEtRangDeLarret = BDD.GetAllArretInLigne(Num_Ligne);

                    lblVisualiserLigne.Text = $"{cboVisualiserLigne.SelectedItem.ToString()} : \n";
                    while (arretEtRangDeLarret[i + 1] != 0)
                    {

                        if (i % 3 == 0)
                        {
                            lblVisualiserLigne.Text += "\n";
                        }
                        lblVisualiserLigne.Text += $"{BDD.GetNomArret(arretEtRangDeLarret[i])} --> ";
                        i++;
                    }

                    if (i % 3 == 0)
                        lblVisualiserLigne.Text += "\n";
                    lblVisualiserLigne.Text += $"{BDD.GetNomArret(arretEtRangDeLarret[i])}";
                }
            }
        }

        private void cmdGererArrêts_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionArret gestionArret = new frmGestionArret();
            gestionArret.ShowDialog();

            lblVisualiserLigne.Text = "Aucune ligne selectionné";

            Reload();
            this.Show();
        }



        private void Reload()
        {
            cboDepart.Items.Clear();
            cboArrivee.Items.Clear();
            cboVisualiserLigne.Items.Clear();


            string[] arret;
            arret = BDD.GetAllArret();
            for (int i = 0; i < arret.Length; i++)
            {
                cboDepart.Items.Add(arret[i]);
                cboArrivee.Items.Add(arret[i]);
            }

            string[] ligne;
            ligne = BDD.GetAllLigne();
            cboVisualiserLigne.Items.Add("Toutes les lignes");
            for (int i = 0; i < ligne.Length; i++)
            {
                cboVisualiserLigne.Items.Add(ligne[i]);
            }
        }

        private void cmdGererLignes_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGestionLignes gestionLigne = new frmGestionLignes();
            gestionLigne.ShowDialog();

            lblVisualiserLigne.Text = "Aucune ligne selectionné";

            Reload();
            this.Show();
        }

        private void pnlAffichage_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdRechercher_Click(object sender, EventArgs e)
        {
            if(cboDepart.SelectedItem != null)
            {
                if (cboArrivee.SelectedItem != null)
                {
                    if (cboDepart.SelectedItem.ToString() != cboArrivee.SelectedItem.ToString())
                    {
                        if (optArrivée.Checked == true || optDépart.Checked == true)
                        {
                            // Trouver si les 2 arrets sont sur une même ligne

                            int num_Arret_Depart = BDD.GetNumArret(cboDepart.SelectedItem.ToString());
                            int num_Arret_Arrivee = BDD.GetNumArret(cboArrivee.SelectedItem.ToString());

                            string[] ligne;
                            ligne = BDD.GetAllLigne(); // Obtenir toutes les lignes

                            bool arretsSurLaMemeLigne = false;
                            int ligneEnCommun = -1;
                            string nomLigneEnCommum = "Aucune";

                            for (int i = 0; i < ligne.Length && arretsSurLaMemeLigne == false; i++)
                            {
                                bool arretTrouve = false;

                                int j = 0;
                                int num_Ligne = BDD.GetNumLigne(ligne[i].ToString());

                                int[] arretEtRangDeLarret = new int[20];
                                arretEtRangDeLarret = BDD.GetAllArretInLigne(num_Ligne);

                                while (arretEtRangDeLarret[j] != 0 && arretsSurLaMemeLigne == false)
                                {
                                    if (arretEtRangDeLarret[j] == num_Arret_Depart)
                                    {
                                        if(arretTrouve == true)
                                        {
                                            arretsSurLaMemeLigne = true;
                                            ligneEnCommun = num_Ligne;
                                            nomLigneEnCommum = ligne[i].ToString();
                                        }
                                        else
                                        {
                                            arretTrouve = true;
                                        }
                                    } 
                                    else if (arretEtRangDeLarret[j] == num_Arret_Arrivee)
                                    {
                                        if (arretTrouve == true)
                                        {
                                            arretsSurLaMemeLigne = true;
                                            ligneEnCommun = num_Ligne;
                                            nomLigneEnCommum = ligne[i].ToString();
                                        }
                                        else
                                        {
                                            arretTrouve = true;
                                        }
                                    }

                                    j++;
                                }
                            }

                            if(arretsSurLaMemeLigne == true)
                            {


                                

                                lblAffichageResultatRecherche.Text = $"Vous devez prendre la ligne : {nomLigneEnCommum}\n";

                                // Debug.Print(Convert.ToInt32(nudHeure.Value).ToString());
                                int[] Heure_Debut_Passage = BDD.GetPassageDebut(ligneEnCommun);
                                int[] Heure_Fin_Passage = BDD.GetPassageFin(ligneEnCommun);

                                int heureSelectionne = Convert.ToInt32(nudHeure.Value);
                                int minuteSelectionne = Convert.ToInt32(nudMinute.Value);

                                bool heureCorrect = true;
                                /*
                                if (Heure_Fin_Passage[0] < Heure_Debut_Passage[0])
                                {
                                    Heure_Fin_Passage[0] += 24;

                                    if (heureSelectionne < Heure_Debut_Passage[0])
                                    {
                                        heureSelectionne += 24;

                                        if (heureSelectionne > Heure_Fin_Passage[0])
                                        {
                                            heureCorrect = false;
                                        }
                                        else if (heureSelectionne == Heure_Fin_Passage[0])
                                        {
                                            if (minuteSelectionne > Heure_Fin_Passage[1])
                                            {
                                                heureCorrect = false;
                                            }
                                        }
                                    }
                                    else if (heureSelectionne == Heure_Debut_Passage[0])
                                    {
                                        if (minuteSelectionne < Heure_Debut_Passage[1])
                                        {
                                            heureCorrect = false;
                                        }
                                    }
                                } 
                                else
                                {
                                    if(heureSelectionne < Heure_Debut_Passage[0] || heureSelectionne > Heure_Fin_Passage[0])
                                    {
                                        heureCorrect = false;
                                    }
                                    else if (heureSelectionne == Heure_Debut_Passage[0])
                                    {
                                        if (minuteSelectionne < Heure_Debut_Passage[1])
                                        {
                                            heureCorrect = false;
                                        }
                                    }
                                    else if (heureSelectionne == Heure_Fin_Passage[0])
                                    {
                                        if (minuteSelectionne > Heure_Fin_Passage[1])
                                        {
                                            heureCorrect = false;
                                        }
                                    }
                                }

                                */

                                

                                // Debug.Print(test.Length.ToString());

                                // Si un bus passe à l'horaire demandé
                                if (heureCorrect == true)
                                {
                                    // Debug.Print(BDD.TempsEntreArret(num_Arret_Depart, num_Arret_Arrivee).ToString());

                                    if (optDépart.Checked == true)
                                    {
                                        int[] arretEtRangDeLarret = new int[20];
                                        arretEtRangDeLarret = BDD.GetAllArretInLigne(ligneEnCommun);
                                        int k = 0;
                                        int tempsTrajetLigne = 0;

                                        while (arretEtRangDeLarret[k + 1] != 0)
                                        {
                                            tempsTrajetLigne += BDD.TempsEntreArret(arretEtRangDeLarret[k], arretEtRangDeLarret[k + 1]);
                                            k++;
                                        }

                                        // Debug.Print($"Temps de trajet de la ligne : {tempsTrajetLigne}");

                                        int debutLigne = Heure_Debut_Passage[0] * 60 + Heure_Debut_Passage[1];
                                        int debutTrajet = Convert.ToInt32(nudHeure.Value) * 60 + Convert.ToInt32(nudMinute.Value);
                                        int chercheHoraire = debutLigne;

                                        int DepartDuBus = -1;
                                        int ArriveDuBus = -1;

                                        // Debug.Print($"debutLigne : {debutLigne}");
                                        // Debug.Print($"debutTrajet : {debutTrajet}");




                                        if (BDD.GetPosition(ligneEnCommun, num_Arret_Depart) < BDD.GetPosition(ligneEnCommun, num_Arret_Arrivee))
                                        {
                                            // lblAffichageResultatRecherche.Text += "A l'endroit !\n";

                                            while (chercheHoraire + tempsTrajetLigne < debutTrajet)
                                            {
                                                chercheHoraire += tempsTrajetLigne * 2;
                                            }

                                            // Debug.Print($"chercheHoraire : {chercheHoraire}");

                                            int chercheHoraire2 = chercheHoraire;

                                            k = 0;
                                            while (arretEtRangDeLarret[k] != num_Arret_Depart)
                                            {
                                                chercheHoraire2 += BDD.TempsEntreArret(arretEtRangDeLarret[k], arretEtRangDeLarret[k + 1]);
                                                k++;
                                            }

                                            if (chercheHoraire2 < debutTrajet)
                                            {
                                                chercheHoraire += tempsTrajetLigne * 2;
                                                chercheHoraire2 = chercheHoraire;

                                                k = 0;
                                                while (arretEtRangDeLarret[k] != num_Arret_Depart)
                                                {
                                                    chercheHoraire2 += BDD.TempsEntreArret(arretEtRangDeLarret[k], arretEtRangDeLarret[k + 1]);
                                                    k++;
                                                }
                                            }
                                            DepartDuBus = chercheHoraire2;
                                            ArriveDuBus = DepartDuBus;
                                            while (arretEtRangDeLarret[k] != num_Arret_Arrivee)
                                            {
                                                ArriveDuBus += BDD.TempsEntreArret(arretEtRangDeLarret[k], arretEtRangDeLarret[k + 1]);
                                                k++;
                                            }

                                            // Debug.Print($"DepartDuBus : {DepartDuBus}");
                                            // Debug.Print($"ArriveDuBus : {ArriveDuBus}");

                                            int heureDepartDuBus = DepartDuBus / 60;
                                            int minuteDepartDuBus = DepartDuBus - (60 * heureDepartDuBus);

                                            int heureArriveDuBus = ArriveDuBus / 60;
                                            int minuteArriveDuBus = ArriveDuBus - (60 * heureArriveDuBus);

                                            if(heureDepartDuBus >= 24)
                                            {
                                                heureDepartDuBus -= 24;
                                            }

                                            if (heureArriveDuBus >= 24)
                                            {
                                                heureArriveDuBus -= 24;
                                            }

                                             // Debug.Print($"heureDepartDuBus : {heureDepartDuBus}");
                                             // Debug.Print($"minuteDepartDuBus : {minuteDepartDuBus}");
                                             // Debug.Print($"heureArriveDuBus : {heureArriveDuBus}");
                                             // Debug.Print($"minuteArriveDuBus : {minuteArriveDuBus}");

                                            bool heureTrouveCorrect = true;

                                            if (Heure_Fin_Passage[0] < Heure_Debut_Passage[0])
                                            {
                                                Heure_Fin_Passage[0] += 24;

                                                if (heureArriveDuBus < Heure_Debut_Passage[0])
                                                {
                                                    heureArriveDuBus += 24;

                                                    if (heureArriveDuBus > Heure_Fin_Passage[0])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                    else if (heureArriveDuBus == Heure_Fin_Passage[0])
                                                    {
                                                        if (minuteArriveDuBus > Heure_Fin_Passage[1])
                                                        {
                                                            heureTrouveCorrect = false;
                                                        }
                                                    }
                                                }
                                                else if (heureArriveDuBus == Heure_Debut_Passage[0])
                                                {
                                                    if (minuteArriveDuBus < Heure_Debut_Passage[1])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (heureArriveDuBus < Heure_Debut_Passage[0] || heureArriveDuBus > Heure_Fin_Passage[0])
                                                {
                                                    heureTrouveCorrect = false;
                                                }
                                                else if (heureArriveDuBus == Heure_Debut_Passage[0])
                                                {
                                                    if (minuteArriveDuBus < Heure_Debut_Passage[1])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                }
                                                else if (heureArriveDuBus == Heure_Fin_Passage[0])
                                                {
                                                    if (minuteArriveDuBus > Heure_Fin_Passage[1])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                }
                                            }


                                            if(heureTrouveCorrect == true)
                                            {
                                                lblAffichageResultatRecherche.Text += $"\nArrêt de départ : {BDD.GetNomArret(num_Arret_Depart)}\n";
                                                if (heureDepartDuBus < 10)
                                                {
                                                    if (minuteDepartDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : 0{heureDepartDuBus}h0{minuteDepartDuBus}\n";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : 0{heureDepartDuBus}h{minuteDepartDuBus}\n";
                                                    }

                                                }
                                                else
                                                {
                                                    if (minuteDepartDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : {heureDepartDuBus}h0{minuteDepartDuBus}\n";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : {heureDepartDuBus}h{minuteDepartDuBus}\n";
                                                    }
                                                }

                                                lblAffichageResultatRecherche.Text += $"\nArrêt d'arrivée : {BDD.GetNomArret(num_Arret_Arrivee)}\n";

                                                if (heureArriveDuBus < 10)
                                                {
                                                    if (minuteArriveDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : 0{heureArriveDuBus}h0{minuteArriveDuBus}";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : 0{heureArriveDuBus}h{minuteArriveDuBus}";
                                                    }

                                                }
                                                else
                                                {
                                                    if (minuteArriveDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : {heureArriveDuBus}h0{minuteArriveDuBus}";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : {heureArriveDuBus}h{minuteArriveDuBus}";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                lblAffichageResultatRecherche.Text = "Aucun résultat trouvé";
                                            }

                                            

                                        }
                                        else
                                        {
                                            chercheHoraire += tempsTrajetLigne;

                                            while (chercheHoraire + tempsTrajetLigne < debutTrajet)
                                            {
                                                chercheHoraire += tempsTrajetLigne * 2;
                                            }

                                            // Debug.Print($"chercheHoraire : {chercheHoraire}");

                                            int chercheHoraire2 = chercheHoraire;
                                            // Debug.Print($"chercheHoraire2 test : {chercheHoraire2}");

                                            int nbrArret = 0;
                                            while (arretEtRangDeLarret[nbrArret] != 0)
                                            {
                                                nbrArret++;
                                            }

                                            k = nbrArret - 1;

                                            while (arretEtRangDeLarret[k] != num_Arret_Depart)
                                            {
                                                // Debug.Print($"chercheHoraire2 test : {chercheHoraire2}");
                                                chercheHoraire2 += BDD.TempsEntreArret(arretEtRangDeLarret[k - 1], arretEtRangDeLarret[k]);
                                                k--;
                                            }

                                            if (chercheHoraire2 < debutTrajet)
                                            {
                                                chercheHoraire += tempsTrajetLigne * 2;
                                                chercheHoraire2 = chercheHoraire;

                                                k = nbrArret - 1;
                                                while (arretEtRangDeLarret[k] != num_Arret_Depart)
                                                {
                                                    chercheHoraire2 += BDD.TempsEntreArret(arretEtRangDeLarret[k - 1], arretEtRangDeLarret[k]);
                                                    k--;
                                                }
                                            }
                                            DepartDuBus = chercheHoraire2;
                                            ArriveDuBus = DepartDuBus;
                                            while (arretEtRangDeLarret[k] != num_Arret_Arrivee)
                                            {
                                                ArriveDuBus += BDD.TempsEntreArret(arretEtRangDeLarret[k - 1], arretEtRangDeLarret[k]);
                                                k--;
                                            }

                                            // Debug.Print($"DepartDuBus : {DepartDuBus}");
                                            // Debug.Print($"ArriveDuBus : {ArriveDuBus}");

                                            int heureDepartDuBus = DepartDuBus / 60;
                                            int minuteDepartDuBus = DepartDuBus - (60 * heureDepartDuBus);

                                            int heureArriveDuBus = ArriveDuBus / 60;
                                            int minuteArriveDuBus = ArriveDuBus - (60 * heureArriveDuBus);

                                            if (heureDepartDuBus >= 24)
                                            {
                                                heureDepartDuBus -= 24;
                                            }

                                            if (heureArriveDuBus >= 24)
                                            {
                                                heureArriveDuBus -= 24;
                                            }

                                            // Debug.Print($"heureDepartDuBus : {heureDepartDuBus}");
                                            // Debug.Print($"minuteDepartDuBus : {minuteDepartDuBus}");
                                            // Debug.Print($"heureArriveDuBus : {heureArriveDuBus}");
                                            // Debug.Print($"minuteArriveDuBus : {minuteArriveDuBus}");

                                            bool heureTrouveCorrect = true;

                                            if (Heure_Fin_Passage[0] < Heure_Debut_Passage[0])
                                            {
                                                Heure_Fin_Passage[0] += 24;

                                                if (heureArriveDuBus < Heure_Debut_Passage[0])
                                                {
                                                    heureArriveDuBus += 24;

                                                    if (heureArriveDuBus > Heure_Fin_Passage[0])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                    else if (heureArriveDuBus == Heure_Fin_Passage[0])
                                                    {
                                                        if (minuteArriveDuBus > Heure_Fin_Passage[1])
                                                        {
                                                            heureTrouveCorrect = false;
                                                        }
                                                    }
                                                }
                                                else if (heureArriveDuBus == Heure_Debut_Passage[0])
                                                {
                                                    if (minuteArriveDuBus < Heure_Debut_Passage[1])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (heureArriveDuBus < Heure_Debut_Passage[0] || heureArriveDuBus > Heure_Fin_Passage[0])
                                                {
                                                    heureTrouveCorrect = false;
                                                }
                                                else if (heureArriveDuBus == Heure_Debut_Passage[0])
                                                {
                                                    if (minuteArriveDuBus < Heure_Debut_Passage[1])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                }
                                                else if (heureArriveDuBus == Heure_Fin_Passage[0])
                                                {
                                                    if (minuteArriveDuBus > Heure_Fin_Passage[1])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                }
                                            }


                                            if (heureTrouveCorrect == true)
                                            {

                                                lblAffichageResultatRecherche.Text += $"\nArrêt de départ : {BDD.GetNomArret(num_Arret_Depart)}\n";
                                                if (heureDepartDuBus < 10)
                                                {
                                                    if (minuteDepartDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : 0{heureDepartDuBus}h0{minuteDepartDuBus}\n";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : 0{heureDepartDuBus}h{minuteDepartDuBus}\n";
                                                    }

                                                }
                                                else
                                                {
                                                    if (minuteDepartDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : {heureDepartDuBus}h0{minuteDepartDuBus}\n";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : {heureDepartDuBus}h{minuteDepartDuBus}\n";
                                                    }
                                                }

                                                lblAffichageResultatRecherche.Text += $"\nArrêt d'arrivée : {BDD.GetNomArret(num_Arret_Arrivee)}\n";

                                                if (heureArriveDuBus < 10)
                                                {
                                                    if (minuteArriveDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : 0{heureArriveDuBus}h0{minuteArriveDuBus}";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : 0{heureArriveDuBus}h{minuteArriveDuBus}";
                                                    }

                                                }
                                                else
                                                {
                                                    if (minuteArriveDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : {heureArriveDuBus}h0{minuteArriveDuBus}";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : {heureArriveDuBus}h{minuteArriveDuBus}";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                lblAffichageResultatRecherche.Text = "Aucun résultat trouvé";
                                            }
                                        }
                                    }
                                    else
                                    {
                                        // Pour si Heure d'arrivée coché :

                                        int[] arretEtRangDeLarret = new int[20];
                                        arretEtRangDeLarret = BDD.GetAllArretInLigne(ligneEnCommun);
                                        int k = 0;
                                        int tempsTrajetLigne = 0;

                                        while (arretEtRangDeLarret[k + 1] != 0)
                                        {
                                            tempsTrajetLigne += BDD.TempsEntreArret(arretEtRangDeLarret[k], arretEtRangDeLarret[k + 1]);
                                            k++;
                                        }

                                        // Debug.Print($"Temps de trajet de la ligne : {tempsTrajetLigne}");

                                        int debutLigne = Heure_Debut_Passage[0] * 60 + Heure_Debut_Passage[1];
                                        int finTrajet = Convert.ToInt32(nudHeure.Value) * 60 + Convert.ToInt32(nudMinute.Value);
                                        int chercheHoraire = debutLigne;

                                        int DepartDuBus = -1;
                                        int ArriveDuBus = -1;

                                        // Debug.Print($"debutLigne : {debutLigne}");
                                        // Debug.Print($"finTrajet : {finTrajet}");




                                        if (BDD.GetPosition(ligneEnCommun, num_Arret_Depart) < BDD.GetPosition(ligneEnCommun, num_Arret_Arrivee))
                                        {
                                            // lblAffichageResultatRecherche.Text += "A l'endroit !\n";

                                            while (chercheHoraire + tempsTrajetLigne < finTrajet)
                                            {
                                                chercheHoraire += tempsTrajetLigne * 2;
                                            }
                                            // Debug.Print($"chercheHoraire : {chercheHoraire}");
                                            // Debug.Print($"chercheHoraire+tempsTrajetLigne : {chercheHoraire+tempsTrajetLigne}");
                                            // Debug.Print($"finTrajet : {finTrajet}");

                                            // Debug.Print($"chercheHoraire : {chercheHoraire}");

                                            int chercheHoraire2 = chercheHoraire;
                                            int chercheHoraire3 = chercheHoraire;

                                            bool arretDepartTrouve = false;

                                            int saveArretDepart = 0;

                                            k = 0;
                                            while (arretEtRangDeLarret[k] != num_Arret_Arrivee)
                                            {
                                                if (arretEtRangDeLarret[k] == num_Arret_Depart)
                                                {
                                                    arretDepartTrouve = true;
                                                    saveArretDepart = k;
                                                }

                                                if (arretDepartTrouve == false)
                                                {
                                                    chercheHoraire3 += BDD.TempsEntreArret(arretEtRangDeLarret[k], arretEtRangDeLarret[k + 1]);
                                                }

                                                chercheHoraire2 += BDD.TempsEntreArret(arretEtRangDeLarret[k], arretEtRangDeLarret[k + 1]);
                                                k++;
                                                // Debug.Print($"arretEtRangDeLarret : {BDD.GetNomArret(arretEtRangDeLarret[k]).ToString()}");
                                                // Debug.Print($"k : {k}");
                                            }

                                            // Debug.Print($"chercheHoraire : {chercheHoraire}");
                                            // Debug.Print($"chercheHoraire2 : {chercheHoraire2}");
                                            // Debug.Print($"chercheHoraire3 : {chercheHoraire3}");
                                            // Debug.Print($"finTrajet : {finTrajet}");

                                            if (chercheHoraire2 > finTrajet)
                                            {
                                                // Debug.Print($"TEST");
                                                chercheHoraire -= tempsTrajetLigne * 2;
                                                chercheHoraire2 = chercheHoraire;
                                                chercheHoraire3 = chercheHoraire;

                                                k = 0;
                                                while (arretEtRangDeLarret[k] != num_Arret_Depart)
                                                {
                                                    chercheHoraire3 += BDD.TempsEntreArret(arretEtRangDeLarret[k], arretEtRangDeLarret[k + 1]);
                                                    k++;
                                                }
                                            }

                                            DepartDuBus = chercheHoraire3;
                                            ArriveDuBus = DepartDuBus;

                                            k = saveArretDepart;
                                            while (arretEtRangDeLarret[k] != num_Arret_Arrivee)
                                            { 

                                                ArriveDuBus += BDD.TempsEntreArret(arretEtRangDeLarret[k], arretEtRangDeLarret[k + 1]);
                                                k++;
                                            }

                                            // Debug.Print($"DepartDuBus : {DepartDuBus}");
                                            // Debug.Print($"ArriveDuBus : {ArriveDuBus}");

                                            int heureDepartDuBus = DepartDuBus / 60;
                                            int minuteDepartDuBus = DepartDuBus - (60 * heureDepartDuBus);

                                            int heureArriveDuBus = ArriveDuBus / 60;
                                            int minuteArriveDuBus = ArriveDuBus - (60 * heureArriveDuBus);

                                            if (heureDepartDuBus >= 24)
                                            {
                                                heureDepartDuBus -= 24;
                                            }

                                            if (heureArriveDuBus >= 24)
                                            {
                                                heureArriveDuBus -= 24;
                                            }

                                            // Debug.Print($"heureDepartDuBus : {heureDepartDuBus}");
                                            // Debug.Print($"minuteDepartDuBus : {minuteDepartDuBus}");
                                            // Debug.Print($"heureArriveDuBus : {heureArriveDuBus}");
                                            // Debug.Print($"minuteArriveDuBus : {minuteArriveDuBus}");

                                            bool heureTrouveCorrect = true;

                                            if (Heure_Fin_Passage[0] < Heure_Debut_Passage[0])
                                            {
                                                Heure_Fin_Passage[0] += 24;

                                                if (heureDepartDuBus < Heure_Debut_Passage[0])
                                                {
                                                    heureDepartDuBus += 24;

                                                    if (heureDepartDuBus > Heure_Fin_Passage[0])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                    else if (heureDepartDuBus == Heure_Fin_Passage[0])
                                                    {
                                                        if (minuteDepartDuBus > Heure_Fin_Passage[1])
                                                        {
                                                            heureTrouveCorrect = false;
                                                        }
                                                    }
                                                }
                                                else if (heureDepartDuBus == Heure_Debut_Passage[0])
                                                {
                                                    if (minuteDepartDuBus < Heure_Debut_Passage[1])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (heureDepartDuBus < Heure_Debut_Passage[0] || heureDepartDuBus > Heure_Fin_Passage[0])
                                                {
                                                    heureTrouveCorrect = false;
                                                }
                                                else if (heureDepartDuBus == Heure_Debut_Passage[0])
                                                {
                                                    if (minuteDepartDuBus < Heure_Debut_Passage[1])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                }
                                                else if (heureDepartDuBus == Heure_Fin_Passage[0])
                                                {
                                                    if (minuteDepartDuBus > Heure_Fin_Passage[1])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                }
                                            }


                                            if (heureTrouveCorrect == true)
                                            {

                                                lblAffichageResultatRecherche.Text += $"\nArrêt de départ : {BDD.GetNomArret(num_Arret_Depart)}\n";
                                                if (heureDepartDuBus < 10)
                                                {
                                                    if (minuteDepartDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : 0{heureDepartDuBus}h0{minuteDepartDuBus}\n";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : 0{heureDepartDuBus}h{minuteDepartDuBus}\n";
                                                    }

                                                }
                                                else
                                                {
                                                    if (minuteDepartDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : {heureDepartDuBus}h0{minuteDepartDuBus}\n";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : {heureDepartDuBus}h{minuteDepartDuBus}\n";
                                                    }
                                                }

                                                lblAffichageResultatRecherche.Text += $"\nArrêt d'arrivée : {BDD.GetNomArret(num_Arret_Arrivee)}\n";

                                                if (heureArriveDuBus < 10)
                                                {
                                                    if (minuteArriveDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : 0{heureArriveDuBus}h0{minuteArriveDuBus}";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : 0{heureArriveDuBus}h{minuteArriveDuBus}";
                                                    }

                                                }
                                                else
                                                {
                                                    if (minuteArriveDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : {heureArriveDuBus}h0{minuteArriveDuBus}";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : {heureArriveDuBus}h{minuteArriveDuBus}";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                lblAffichageResultatRecherche.Text += "Aucun résultat trouvé";
                                            }
                                        }
                                        else
                                        {
                                            // lblAffichageResultatRecherche.Text += "A l'envers !\n";

                                            chercheHoraire += tempsTrajetLigne;

                                            while (chercheHoraire + tempsTrajetLigne < finTrajet)
                                            {
                                                chercheHoraire += tempsTrajetLigne * 2;
                                            }

                                            // Debug.Print($"chercheHoraire : {chercheHoraire}");

                                            int chercheHoraire2 = chercheHoraire;
                                            int chercheHoraire3 = chercheHoraire;

                                            bool arretArriveTrouve = false;

                                            int nbrArret = 0;
                                            while (arretEtRangDeLarret[nbrArret] != 0)
                                            {
                                                nbrArret++;
                                            }

                                            k = nbrArret - 1;
                                            int saveArretDepart = 0;

                                            while (arretEtRangDeLarret[k] != num_Arret_Arrivee)
                                            {
                                                // Debug.Print($"chercheHoraire2 : {chercheHoraire2}");
                                                if (arretEtRangDeLarret[k] == num_Arret_Depart)
                                                {
                                                    arretArriveTrouve = true;
                                                    saveArretDepart = k;
                                                }

                                                if (arretArriveTrouve == false)
                                                {
                                                    chercheHoraire3 += BDD.TempsEntreArret(arretEtRangDeLarret[k - 1], arretEtRangDeLarret[k]);
                                                }

                                                chercheHoraire2 += BDD.TempsEntreArret(arretEtRangDeLarret[k - 1], arretEtRangDeLarret[k]);
                                                k--;
                                            }

                                             // Debug.Print($"chercheHoraire : {chercheHoraire}");
                                             // Debug.Print($"chercheHoraire2 : {chercheHoraire2}");
                                             // Debug.Print($"chercheHoraire3 : {chercheHoraire3}");

                                            if (chercheHoraire2 > finTrajet)
                                            {
                                                chercheHoraire -= tempsTrajetLigne * 2;
                                                chercheHoraire2 = chercheHoraire;
                                                chercheHoraire3 = chercheHoraire;

                                                k = nbrArret - 1;
                                                while (arretEtRangDeLarret[k] != num_Arret_Depart)
                                                {
                                                    chercheHoraire3 += BDD.TempsEntreArret(arretEtRangDeLarret[k - 1], arretEtRangDeLarret[k]);
                                                    k--;
                                                }
                                            }
                                            // Debug.Print($"chercheHoraire3 : {chercheHoraire3}");
                                            DepartDuBus = chercheHoraire3;
                                            ArriveDuBus = DepartDuBus;

                                            // k++;
                                            k = saveArretDepart;
                                            while (arretEtRangDeLarret[k] != num_Arret_Arrivee)
                                            {
                                                // Debug.Print($"TEST");
                                                ArriveDuBus += BDD.TempsEntreArret(arretEtRangDeLarret[k - 1], arretEtRangDeLarret[k]);
                                                k--;
                                            }

                                            // Debug.Print($"DepartDuBus : {DepartDuBus}");
                                            // Debug.Print($"ArriveDuBus : {ArriveDuBus}");

                                            int heureDepartDuBus = DepartDuBus / 60;
                                            int minuteDepartDuBus = DepartDuBus - (60 * heureDepartDuBus);

                                            int heureArriveDuBus = ArriveDuBus / 60;
                                            int minuteArriveDuBus = ArriveDuBus - (60 * heureArriveDuBus);

                                            if (heureDepartDuBus >= 24)
                                            {
                                                heureDepartDuBus -= 24;
                                            }

                                            if (heureArriveDuBus >= 24)
                                            {
                                                heureArriveDuBus -= 24;
                                            }

                                            // Debug.Print($"heureDepartDuBus : {heureDepartDuBus}");
                                            // Debug.Print($"minuteDepartDuBus : {minuteDepartDuBus}");
                                            // Debug.Print($"heureArriveDuBus : {heureArriveDuBus}");
                                            // Debug.Print($"minuteArriveDuBus : {minuteArriveDuBus}");


                                            bool heureTrouveCorrect = true;

                                            if (Heure_Fin_Passage[0] < Heure_Debut_Passage[0])
                                            {
                                                Heure_Fin_Passage[0] += 24;

                                                if (heureDepartDuBus < Heure_Debut_Passage[0])
                                                {
                                                    heureDepartDuBus += 24;

                                                    if (heureDepartDuBus > Heure_Fin_Passage[0])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                    else if (heureDepartDuBus == Heure_Fin_Passage[0])
                                                    {
                                                        if (minuteDepartDuBus > Heure_Fin_Passage[1])
                                                        {
                                                            heureTrouveCorrect = false;
                                                        }
                                                    }
                                                }
                                                else if (heureDepartDuBus == Heure_Debut_Passage[0])
                                                {
                                                    if (minuteDepartDuBus < Heure_Debut_Passage[1])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if (heureDepartDuBus < Heure_Debut_Passage[0] || heureDepartDuBus > Heure_Fin_Passage[0])
                                                {
                                                    heureTrouveCorrect = false;
                                                }
                                                else if (heureDepartDuBus == Heure_Debut_Passage[0])
                                                {
                                                    if (minuteDepartDuBus < Heure_Debut_Passage[1])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                }
                                                else if (heureDepartDuBus == Heure_Fin_Passage[0])
                                                {
                                                    if (minuteDepartDuBus > Heure_Fin_Passage[1])
                                                    {
                                                        heureTrouveCorrect = false;
                                                    }
                                                }
                                            }


                                            if (heureTrouveCorrect == true)
                                            {

                                                lblAffichageResultatRecherche.Text += $"\nArrêt de départ : {BDD.GetNomArret(num_Arret_Depart)}\n";
                                                if (heureDepartDuBus < 10)
                                                {
                                                    if (minuteDepartDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : 0{heureDepartDuBus}h0{minuteDepartDuBus}\n";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : 0{heureDepartDuBus}h{minuteDepartDuBus}\n";
                                                    }

                                                }
                                                else
                                                {
                                                    if (minuteDepartDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : {heureDepartDuBus}h0{minuteDepartDuBus}\n";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Depart du bus : {heureDepartDuBus}h{minuteDepartDuBus}\n";
                                                    }
                                                }

                                                lblAffichageResultatRecherche.Text += $"\nArrêt d'arrivée : {BDD.GetNomArret(num_Arret_Arrivee)}\n";

                                                if (heureArriveDuBus < 10)
                                                {
                                                    if (minuteArriveDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : 0{heureArriveDuBus}h0{minuteArriveDuBus}";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : 0{heureArriveDuBus}h{minuteArriveDuBus}";
                                                    }

                                                }
                                                else
                                                {
                                                    if (minuteArriveDuBus < 10)
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : {heureArriveDuBus}h0{minuteArriveDuBus}";
                                                    }
                                                    else
                                                    {
                                                        lblAffichageResultatRecherche.Text += $"Arrivée du bus : {heureArriveDuBus}h{minuteArriveDuBus}";
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                lblAffichageResultatRecherche.Text = "Aucun résultat trouvé";
                                            }
                                        }
                                    }

                                } 
                                else
                                {
                                    lblAffichageResultatRecherche.Text = "Aucun résultat trouvé";
                                }
                                
                            }
                            else
                            {
                                lblAffichageResultatRecherche.Text = "Aucun résultat trouvé";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vous devez choisir entre une heure de départ et d'arrivée !");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vous devez choisir deux arret différent !");
                    }
                }
                else
                {
                    MessageBox.Show("Vous devez choisir un arret d'arrivée !");
                }
            } 
            else
            {
                MessageBox.Show("Vous devez choisir un arret de départ !");
            }
        }
    }
}
