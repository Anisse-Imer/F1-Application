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
            //BDD.Affiche("Ligne");

            bool connexionOuvertre = BDD.InitConnexion();
            /*
            if (connexionOuvertre)
            {
                MessageBox.Show("Connexion ouverte");
            }
            else
            {
                MessageBox.Show("Echec connexion");
            }
            */
            
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

                    lblVisualiserLigne.Text = $"{cboVisualiserLigne.SelectedItem.ToString()} : \n";

                    for (int j = 0; j < ligne.Length; j++)
                    {
                        int Num_Ligne = BDD.GetNumLigne(ligne[j]);
                        i = 0;

                        int[] arretEtRangDeLarret = new int[20];
                        arretEtRangDeLarret = BDD.GetAllArretInLigne(Num_Ligne);

                        lblVisualiserLigne.Text += $"{ligne[j]}";
                        while (arretEtRangDeLarret[i + 1] != 0)
                        {
                            // Debug.Print($"Rang {i + 1} : {BDD.GetNomArret(arretEtRangDeLarret[i])}");

                            if (i % 3 == 0)
                            {
                                lblVisualiserLigne.Text += "\n";
                            }
                            lblVisualiserLigne.Text += $"{BDD.GetNomArret(arretEtRangDeLarret[i])} --> ";
                            i++;
                        }
                        // Debug.Print($"Rang {i + 1} : {BDD.GetNomArret(arretEtRangDeLarret[i])}");
                        if (i % 3 == 0)
                            lblVisualiserLigne.Text += "\n";
                        lblVisualiserLigne.Text += $"{BDD.GetNomArret(arretEtRangDeLarret[i])}";
                        lblVisualiserLigne.Text += "\n\n";
                    }
                }
                else
                {
                    // Test

                    /*
                    Debug.Print($"Nom de la ligne : {cboVisualiserLigne.SelectedItem.ToString()}");

                    int Num_Ligne = BDD.GetNumLigne(cboVisualiserLigne.SelectedItem.ToString());
                    Debug.Print($"Numéro de la ligne : {BDD.GetNumLigne(cboVisualiserLigne.SelectedItem.ToString())}");

                    */





                    // Affichage de la ligne dans l'application

                    int i = 0;
                    int Num_Ligne = BDD.GetNumLigne(cboVisualiserLigne.SelectedItem.ToString());
                    int[] arretEtRangDeLarret = new int[20];
                    arretEtRangDeLarret = BDD.GetAllArretInLigne(Num_Ligne);

                    lblVisualiserLigne.Text = $"{cboVisualiserLigne.SelectedItem.ToString()} : \n";
                    while (arretEtRangDeLarret[i + 1] != 0)
                    {
                        // Debug.Print($"Rang {i + 1} : {BDD.GetNomArret(arretEtRangDeLarret[i])}");

                        if (i % 3 == 0)
                        {
                            lblVisualiserLigne.Text += "\n";
                        }
                        lblVisualiserLigne.Text += $"{BDD.GetNomArret(arretEtRangDeLarret[i])} --> ";
                        i++;
                    }
                    // Debug.Print($"Rang {i + 1} : {BDD.GetNomArret(arretEtRangDeLarret[i])}");
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
    }
}
