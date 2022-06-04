using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ConnexionBD;
using Information;
using System.Diagnostics;

namespace F1_Application
{
    public partial class frmGestionArret : Form
    {
        public frmGestionArret()
        {
            InitializeComponent();
        }

        private void frmGestionArret_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.chaperon_rouge;
            string[] arret;
            arret = BDD.GetAllArret();
            for (int i = 0; i < arret.Length; i++)
            {
                cboArret.Items.Add(arret[i]);
            }
        }

        private void cmdAnnulerGestionArret_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdModifierArret_Click(object sender, EventArgs e)
        {
            if (cboArret.SelectedItem != null)
            {
                frmModifierArret modifierArret = new frmModifierArret(BDD.GetNumArret(cboArret.SelectedItem.ToString()));
                modifierArret.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un arrêt !");
            }

            ReloadArret();
        }

        private void cmdAjouterArret_Click(object sender, EventArgs e)
        {
            frmAjouterArret ajouterArret = new frmAjouterArret();
            ajouterArret.ShowDialog();

            ReloadArret();
        }

        /// <summary>
        /// Permet de reload la combobox des arrêts
        /// </summary>
        private void ReloadArret()
        {
            cboArret.Items.Clear();

            string[] arret;
            arret = BDD.GetAllArret();
            for (int i = 0; i < arret.Length; i++)
            {
                cboArret.Items.Add(arret[i]);
            }
        }

        private void cmdSupprimerArret_Click(object sender, EventArgs e)
        {
            if (cboArret.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cet arrêt ? \nC'est une action irréversible. ", "Supprimer Arrêt", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {

                    int num_Arret = BDD.GetNumArret(cboArret.SelectedItem.ToString());

                    // Supprimer l'arrêt de toutes les lignes au quel il appartient

                    BDD.SupprimerUnArretDesLignes(num_Arret);

                    // Supprimer l'arrêt de tout les Trajet

                    BDD.SupprimerTempsArret(num_Arret);

                    // Remettre les lignes dans le bon ordre

                    string[] ligne;
                    ligne = BDD.GetAllLigne(); // Obtenir toutes les lignes

                    for (int i = 0; i < ligne.Length; i++)
                    {
                        int j = 0;
                        int Num_Ligne = BDD.GetNumLigne(ligne[i].ToString());

                        int[] arretEtRangDeLarret = new int[20];
                        arretEtRangDeLarret = BDD.GetAllArretInLigne(Num_Ligne);

                        bool arretSupprimerEtaitSurLaLigne = false;

                        while (arretEtRangDeLarret[j] != 0)
                        {
                            if(BDD.GetPosition(Num_Ligne, arretEtRangDeLarret[j]) != j + 1 && arretSupprimerEtaitSurLaLigne == false)
                            {
                                // Debug.Print("ERROR");
                                arretSupprimerEtaitSurLaLigne = true;
                            }

                            if(arretSupprimerEtaitSurLaLigne == true)
                            {
                                // Debug.Print("TEST");
                                bool changePosition = BDD.SetPosition(Num_Ligne, arretEtRangDeLarret[j], j+1);

                                if(changePosition == false)
                                {
                                    MessageBox.Show("Une erreur est survenu lors de la modificaiton des positions des arrêts !");
                                }
                            }

                            // Debug.Print($"Ligne {Num_Ligne} | Rang {j + 1} : {BDD.GetNomArret(arretEtRangDeLarret[j])} | Vrai rang : {BDD.GetPosition(Num_Ligne, arretEtRangDeLarret[j])}");
                            j++;
                        }
                    }



                    // Supprimer l'arrêt définitivement

                    bool supprmierArret = BDD.SupprimerArret(num_Arret);

                    if (supprmierArret == false)
                    {
                        MessageBox.Show("Une erreur est survenu lors de la supression de l'arrêt !");
                    }
                    else
                    {
                        MessageBox.Show("Arrêt supprimer avec succès !");
                    }

                    information.RemoveArret();

                    ReloadArret();
                }

            }
            else
            {
                MessageBox.Show("Vous devez selectionner un arrêt !");
            }
        } 
    }
}
