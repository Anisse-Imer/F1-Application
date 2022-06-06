using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Information;
using ConnexionBD;
using System.Diagnostics;

namespace F1_Application
{
    public partial class frmAjouterLigne : Form
    {
        public frmAjouterLigne()
        {
            InitializeComponent();
        }

        private void cmdAnnulerAjouterLigne_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAjouterLigne_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.chaperon_rouge;
            string[] arret;
            arret = BDD.GetAllArret();
            for (int i = 0; i < arret.Length; i++)
            {
                clstListeArrets.Items.Add(arret[i]);
            }

            cboCouleur.Items.Add("Rouge");
            cboCouleur.Items.Add("Orange");
            cboCouleur.Items.Add("Jaune");
            cboCouleur.Items.Add("Vert");
            cboCouleur.Items.Add("Bleu");
            cboCouleur.Items.Add("Violet");
            cboCouleur.Items.Add("Rose");
            cboCouleur.Items.Add("Noir");
            cboCouleur.Items.Add("Cyan");
            cboCouleur.Items.Add("Marron");


            // On enlève les couleurs qui sont déjà prises par des lignes

            string[] ligne;
            ligne = BDD.GetAllLigne();
            for (int i = 0; i < ligne.Length; i++)
            {
                int numLigne = BDD.GetNumLigne(ligne[i]);
                for (int y = 0; y < cboCouleur.Items.Count; y++)
                {
                    if (cboCouleur.Items[y].ToString() == BDD.GetCouleur(numLigne).ToString())
                    {
                        cboCouleur.Items.RemoveAt(y);
                    }
                }
            }
        }

        NumericUpDown[] listeNUD = new NumericUpDown[20];
        Label[] listeLBL = new Label[20];

        private void clstListeArrets_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            int newNbrArretSelectionnet;
            bool arretEnleve = false;
            int error = 1;
            int compteur = 0;


            // On regarde si l'utilisateur a rajouté ou enlevé un arrêt

            if (e.NewValue == CheckState.Checked)
            {
                newNbrArretSelectionnet = clstListeArrets.CheckedItems.Count + 1;
            }
            else
            {
                newNbrArretSelectionnet = clstListeArrets.CheckedItems.Count - 1;
                arretEnleve = true;
                error = -1;
            }

            if (newNbrArretSelectionnet != 0 && newNbrArretSelectionnet <= 20)
            {
                int i;

                lblNbrArretSelectionne.Text = newNbrArretSelectionnet.ToString();

                flpRangArret.Controls.Clear();

                for (i = 0; i < newNbrArretSelectionnet - error; i++)
                {

                    if (clstListeArrets.Items[e.Index].ToString() != clstListeArrets.CheckedItems[i].ToString() || arretEnleve == false)
                    {
                        Label lbl = new Label();
                        lbl.Name = $"lblArret{i}";
                        lbl.AutoSize = false;
                        lbl.Size = new Size(120, 30);
                        lbl.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Text = clstListeArrets.CheckedItems[i].ToString();

                        NumericUpDown nud = new NumericUpDown();
                        nud.Name = $"nudArret{i}";
                        nud.Minimum = 1;
                        nud.Maximum = newNbrArretSelectionnet;
                        nud.AutoSize = false;
                        nud.Size = new Size(60, 30);
                        nud.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);
                        nud.Text = "Rang :";

                        flpRangArret.Controls.Add(lbl);
                        flpRangArret.Controls.Add(nud);

                        listeNUD[compteur] = nud;
                        listeLBL[compteur] = lbl;
                        compteur++;
                    }
                }

                if (arretEnleve == false)
                {
                    Label denierLbl = new Label();
                    denierLbl.Name = $"lblArret{i}";
                    denierLbl.AutoSize = false;
                    denierLbl.Size = new Size(120, 30);
                    denierLbl.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);
                    denierLbl.TextAlign = ContentAlignment.MiddleCenter;
                    denierLbl.Text = clstListeArrets.Items[e.Index].ToString();

                    NumericUpDown dernierNud = new NumericUpDown();
                    dernierNud.Name = $"nudArret{i}";
                    dernierNud.Minimum = 1;
                    dernierNud.Maximum = newNbrArretSelectionnet;
                    dernierNud.AutoSize = false;
                    dernierNud.Size = new Size(60, 30);
                    dernierNud.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);
                    dernierNud.Text = "Rang :";

                    flpRangArret.Controls.Add(denierLbl);
                    flpRangArret.Controls.Add(dernierNud);

                    listeNUD[compteur] = dernierNud;
                    listeLBL[compteur] = denierLbl;
                }
            }
            else
            {
                if(newNbrArretSelectionnet != 0)
                {
                    // Si l'utilisateur sélectionne plus que 20 arrêts
                    e.NewValue = CheckState.Unchecked;
                    MessageBox.Show("20 arrêts maximum !");
                }
                else
                {
                    // Si l'utilisateur sélectionne 0 arrêt
                    flpRangArret.Controls.Clear();
                }
                
            }
        }

        private void cmdConfirmerAjouterLigne_Click(object sender, EventArgs e)
        {
            if (txtNomLigne != null && txtNomLigne.TextLength >= 3)
            {

                // On vérifie si le nom de la ligne n'est pas déjà pris

                bool nomLigneDejaExistant = false;

                string[] ligne;
                ligne = BDD.GetAllLigne();
                for (int i = 0; i < ligne.Length; i++)
                {
                    if (ligne[i] == txtNomLigne.Text.ToString())
                    {
                        nomLigneDejaExistant = true;
                    }
                }

                if (nomLigneDejaExistant == false)
                {

                    if (flpRangArret.Controls.Count >= 6 && flpRangArret.Controls.Count <= 40)
                    {
                        // Si l'utilisateur a sélectionné entre 3 et 20 arrêts

                        // On vérifie que tout les rangs des arrêts sélectionnés soient différents
                        int[] verif = new int[flpRangArret.Controls.Count / 2];

                        bool rangIdentique = false;

                        for(int i = 0; i < flpRangArret.Controls.Count / 2 && rangIdentique == false; i++)
                        {
                            verif[i] = Convert.ToInt32(listeNUD[i].Value);

                            for (int j = 0; j < i; j++)
                            {
                                if(verif[j] == listeNUD[i].Value)
                                {
                                    rangIdentique = true;
                                }
                            }
                        }



                        if(rangIdentique == false)
                        {
                            if(cboCouleur.SelectedItem != null)
                            {

                                if (nudHeureDebutLigne.Value != nudHeureFinLigne.Value)
                                {

                                    int n_Ligne = BDD.AjoutLigne(txtNomLigne.Text.ToString(), cboCouleur.SelectedItem.ToString());

                                    if (n_Ligne != -1)
                                    {

                                        // On créer un bus pour la ligne

                                        int numBus = BDD.AjoutBus();

                                        // On ajoute les horaires de la ligne

                                        BDD.AjoutPassage(n_Ligne, Convert.ToInt32(nudHeureDebutLigne.Value), Convert.ToInt32(nudMinuteDebutLigne.Value), Convert.ToInt32(nudHeureFinLigne.Value), Convert.ToInt32(nudMinuteFinLigne.Value), numBus);


                                        // Tri des rangs des arrêts

                                        for (int i = 0; i < flpRangArret.Controls.Count / 2 == true; i++)
                                        {
                                            int minimum = i;
                                            for (int j = i + 1; j < flpRangArret.Controls.Count / 2; j++)
                                            {
                                                if (Convert.ToInt32(listeNUD[j].Value) < Convert.ToInt32(listeNUD[minimum].Value))
                                                {
                                                    minimum = j;
                                                }
                                            }

                                            if (minimum != i)
                                            {
                                                int saveNud = Convert.ToInt32(listeNUD[i].Value);
                                                listeNUD[i].Value = Convert.ToInt32(listeNUD[minimum].Value);
                                                listeNUD[minimum].Value = saveNud;

                                                string saveLbl = listeLBL[i].Text.ToString();
                                                listeLBL[i].Text = listeLBL[minimum].Text;
                                                listeLBL[minimum].Text = saveLbl;
                                            }
                                        }

                                        // On demande à l'utilisateur de saisir un temps entre 2 arrêts si celui-ci n'existe pas

                                        for (int i = 0; i < (flpRangArret.Controls.Count / 2) - 1; i++)
                                        {
                                            int numArret1 = BDD.GetNumArret(listeLBL[i].Text.ToString());
                                            int numArret2 = BDD.GetNumArret(listeLBL[i + 1].Text.ToString());

                                            int tempsEntreArret = BDD.TempsEntreArret(numArret1, numArret2);

                                            if (tempsEntreArret == -1)
                                            {
                                                frmTempsEntreArret tempsEntreArretFormulaire = new frmTempsEntreArret(numArret1, numArret2);
                                                tempsEntreArretFormulaire.ShowDialog();
                                            }
                                        }

                                        // On ajoute les positions des arrêts sélectionné sur la ligne

                                        bool ajoutPosition = true;

                                        for (int i = 0; i < flpRangArret.Controls.Count / 2 && ajoutPosition == true; i++)
                                        {
                                            int n_Arret = BDD.GetNumArret(listeLBL[i].Text.ToString());
                                            ajoutPosition = BDD.AjoutPositionnement(n_Ligne, n_Arret, Convert.ToInt32(listeNUD[i].Value));
                                        }

                                        if (ajoutPosition == false)
                                        {
                                            MessageBox.Show("Une erreur est survenue lors de la création d'une des positions !");
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ligne créée avec succès !");
                                        }

                                        information.AddLigne();
                                        this.Close();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Une erreur est survenue lors de la création de la ligne !");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("L'heure de début et de fin de la ligne doivent être différents !");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Vous devez sélectionner une couleur !");
                            }
                        } 
                        else
                        {
                            MessageBox.Show("Vous devez mettre des rangs différents pour chaque arrêt !");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Vous devez sélectionner entre 3 et 20 arrêts !");
                    }
                }
                else
                {
                    MessageBox.Show("Une ligne porte déjà ce nom !");
                }
            }
            else
            {
                MessageBox.Show("Le nom doit faire au moins 3 caractères !");
            }
        }
    }
}
