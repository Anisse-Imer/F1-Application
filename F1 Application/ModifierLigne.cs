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
    public partial class frmModifierLigne : Form
    {
        int ligneSelectionner;
        public frmModifierLigne(int ligne)
        {
            InitializeComponent();
            ligneSelectionner = ligne;
        }

        private void lblModifierLigne_Click(object sender, EventArgs e)
        {

        }

        private void cmdAnnulerModifierLigne_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        NumericUpDown[] listeNUD = new NumericUpDown[20];
        Label[] listeLBL = new Label[20];
        bool ligneSelection = true; // empeche pendant le chargement du formulaire que clstListeArrets_ItemCheck ne soit utilisée.

        private void frmModifierLigne_Load(object sender, EventArgs e)
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


            // On retire les couleurs qui sont déjà prises

            string[] ligne;
            ligne = BDD.GetAllLigne();
            for (int i = 0; i < ligne.Length; i++)
            {
                int numLigne = BDD.GetNumLigne(ligne[i]);
                for (int y = 0; y < cboCouleur.Items.Count; y++)
                {
                    if (ligne[i] != BDD.GetNomLigne(ligneSelectionner))
                    {
                        if (cboCouleur.Items[y].ToString() == BDD.GetCouleur(numLigne).ToString())
                        {
                            cboCouleur.Items.RemoveAt(y);
                        }
                    }
                }
            }

            ligneSelection = true;

            string couleurLigne = BDD.GetCouleur(ligneSelectionner);

            bool flag = false;
            for (int i = 0; i < cboCouleur.Items.Count; i++)
            {
                if (cboCouleur.Items[i].ToString() == couleurLigne.ToString())
                {
                    flag = true;
                    cboCouleur.SelectedIndex = i;
                }
            }

            if (flag == false)
            {
                cboCouleur.Items.Add(couleurLigne);
                cboCouleur.SelectedIndex = cboCouleur.Items.Count - 1;
            }


            txtNomLigne.Text = BDD.GetNomLigne(ligneSelectionner);

            int[] arretEtRangDeLarret = new int[20];
            arretEtRangDeLarret = BDD.GetAllArretInLigne(ligneSelectionner);

            string[] nomArretEtRangDeLarret = new string[20];

            for (int i = 0; i < 20; i++)
            {
                nomArretEtRangDeLarret[i] = BDD.GetNomArret(arretEtRangDeLarret[i]).ToString();
            }

            int nbrArret = 0;

            for (int i = 0; i < clstListeArrets.Items.Count; i++)
            {

                bool arretDansLigne = false;
                for (int j = 0; arretEtRangDeLarret[j] != 0 && arretDansLigne == false; j++)
                {

                    if (clstListeArrets.Items[i].ToString() == nomArretEtRangDeLarret[j].ToString())
                    {
                        clstListeArrets.SetItemChecked(i, true);

                        arretDansLigne = true;

                        Label lbl = new Label();
                        lbl.Name = $"lblArret{i}";
                        lbl.AutoSize = false;
                        lbl.Size = new Size(120, 30);
                        lbl.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Text = clstListeArrets.Items[i].ToString();

                        NumericUpDown nud = new NumericUpDown();
                        nud.Name = $"nudArret{i}";
                        nud.Value = j + 1;
                        nud.Minimum = 1;
                        nud.AutoSize = false;
                        nud.Size = new Size(60, 30);
                        nud.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);
                        nud.Text = "Rang :";

                        flpRangDesArret.Controls.Add(lbl);
                        flpRangDesArret.Controls.Add(nud);

                        listeNUD[nbrArret] = nud;
                        listeLBL[nbrArret] = lbl;

                        nbrArret++;
                    }

                    else
                    {
                        clstListeArrets.SetItemChecked(i, false);
                    }
                }
            }

            lblNbrArretSelectionner.Text = nbrArret.ToString();

            for (int i = 0; i < nbrArret; i++)
            {
                listeNUD[i].Maximum = nbrArret;
            }

            int[] Heure_Debut_Passage = BDD.GetPassageDebut(ligneSelectionner);
            int[] Heure_Fin_Passage = BDD.GetPassageFin(ligneSelectionner);

            nudHeureDebutLigne.Value = Heure_Debut_Passage[0];
            nudMinuteDebutLigne.Value = Heure_Debut_Passage[1];

            nudHeureFinLigne.Value = Heure_Fin_Passage[0];
            nudMinuteFinLigne.Value = Heure_Fin_Passage[1];

            ligneSelection = false;
        }


        private void clstListeArrets_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if(ligneSelection == false)
            {
                int newNbrArretSelectionnet;
                bool flag = false;
                int error = 1;
                int compteur = 0;

                if (e.NewValue == CheckState.Checked)
                {
                    newNbrArretSelectionnet = clstListeArrets.CheckedItems.Count + 1;
                }
                else
                {
                    newNbrArretSelectionnet = clstListeArrets.CheckedItems.Count - 1;
                    flag = true;
                    error = -1;
                }

                if (newNbrArretSelectionnet != 0 && newNbrArretSelectionnet <= 20)
                {
                    int i;

                    lblNbrArretSelectionner.Text = newNbrArretSelectionnet.ToString();

                    flpRangDesArret.Controls.Clear();

                    for (i = 0; i < newNbrArretSelectionnet - error; i++)
                    {

                        if (clstListeArrets.Items[e.Index].ToString() != clstListeArrets.CheckedItems[i].ToString() || flag == false)
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
                            int positionArret = BDD.GetPosition(ligneSelectionner, BDD.GetNumArret(clstListeArrets.CheckedItems[i].ToString()));
                            if (positionArret != -1)
                            {
                                nud.Value = positionArret;
                            }
                            else
                            {
                                nud.Value = 1;
                            }
                            
                            nud.Minimum = 1;
                            nud.Maximum = newNbrArretSelectionnet;
                            nud.AutoSize = false;
                            nud.Size = new Size(60, 30);
                            nud.Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Regular);
                            nud.Text = "Rang :";

                            flpRangDesArret.Controls.Add(lbl);
                            flpRangDesArret.Controls.Add(nud);

                            listeNUD[compteur] = nud;
                            listeLBL[compteur] = lbl;
                            compteur++;
                        }
                    }

                    if (flag == false)
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

                        flpRangDesArret.Controls.Add(denierLbl);
                        flpRangDesArret.Controls.Add(dernierNud);

                        listeNUD[compteur] = dernierNud;
                        listeLBL[compteur] = denierLbl;
                    }
                }
                else
                {
                    if (newNbrArretSelectionnet != 0)
                    {
                        e.NewValue = CheckState.Unchecked;
                        MessageBox.Show("20 arrêts maximum !");
                    }
                    else
                    {
                        flpRangDesArret.Controls.Clear();
                    }

                }
            }
        }

        private void cmdConfirmerModifierLigne_Click(object sender, EventArgs e)
        {
            if (txtNomLigne != null && txtNomLigne.TextLength >= 3)
            {

                // On vérifie que le nom de la ligne n'est pas déjà pris

                bool flag = false;

                string[] ligne;
                ligne = BDD.GetAllLigne();
                for (int i = 0; i < ligne.Length; i++)
                {
                    if (ligne[i] == txtNomLigne.Text.ToString() && txtNomLigne.Text.ToString() != BDD.GetNomLigne(ligneSelectionner))
                    {
                        flag = true;
                    }
                }

                if (flag == false)
                {

                    // On vérifie que tout les rangs sont différents

                    if (flpRangDesArret.Controls.Count >= 6 && flpRangDesArret.Controls.Count <= 40)
                    {
                        int[] verif = new int[flpRangDesArret.Controls.Count / 2];

                        bool rangIdentique = false;

                        for (int i = 0; i < flpRangDesArret.Controls.Count / 2 && rangIdentique == false; i++)
                        {
                            verif[i] = Convert.ToInt32(listeNUD[i].Value);

                            for (int j = 0; j < i; j++)
                            {
                                if (verif[j] == listeNUD[i].Value)
                                {
                                    rangIdentique = true;
                                }
                            }
                        }

                        if (rangIdentique == false)
                        {
                            if (cboCouleur.SelectedItem != null)
                            {

                                // On modifie l'horaire de la ligne

                                BDD.ModifieDebutPassage(ligneSelectionner, Convert.ToInt32(nudHeureDebutLigne.Value), Convert.ToInt32(nudMinuteDebutLigne.Value));
                                BDD.ModifieFinPassage(ligneSelectionner, Convert.ToInt32(nudHeureFinLigne.Value), Convert.ToInt32(nudMinuteFinLigne.Value));

                                // Tri des rangs des arrêts

                                for (int i = 0; i < flpRangDesArret.Controls.Count / 2 == true; i++)
                                {
                                    int minimum = i;
                                    for (int j = i + 1; j < flpRangDesArret.Controls.Count / 2; j++)
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

                                for (int i = 0; i < (flpRangDesArret.Controls.Count / 2) - 1; i++)
                                {
                                    int numArret1 = BDD.GetNumArret(listeLBL[i].Text.ToString());
                                    int numArret2 = BDD.GetNumArret(listeLBL[i + 1].Text.ToString());

                                    int tempsEntreArret = BDD.TempsEntreArret(numArret1, numArret2);

                                    if (tempsEntreArret == -1)
                                    {
                                        frmTempsEntreArret tempsEntreArretFormulaire = new frmTempsEntreArret(numArret1, numArret2);
                                        tempsEntreArretFormulaire.ShowDialog();
                                    }


                                    tempsEntreArret = BDD.TempsEntreArret(numArret1, numArret2);

                                }

                                // Supprimer les arrêts qui ne sont plus dans la ligne

                                int[] arretEtRangDeLarret = new int[20];
                                arretEtRangDeLarret = BDD.GetAllArretInLigne(ligneSelectionner);

                                for (int i = 0; i < arretEtRangDeLarret.Length; i++)
                                {
                                    bool arretDansLigneModifiee = false;
                                    for (int j = 0; j < flpRangDesArret.Controls.Count / 2; j++)
                                    {
                                        if (arretEtRangDeLarret[i] == BDD.GetNumArret(listeLBL[j].ToString()))
                                            arretDansLigneModifiee = true;
                                    }

                                    if (arretDansLigneModifiee == false)
                                        BDD.SupprimerUnArretDuneLignes(ligneSelectionner, arretEtRangDeLarret[i]);
                                }

                                bool ajoutOuModificationPosition = true;
                                bool ajoutPosition;

                                for (int i = 0; i < flpRangDesArret.Controls.Count / 2 && ajoutOuModificationPosition == true; i++)
                                {
                                    int n_Arret = BDD.GetNumArret(listeLBL[i].Text.ToString());

                                    ajoutPosition = BDD.AjoutPositionnement(ligneSelectionner, n_Arret, Convert.ToInt32(listeNUD[i].Value));

                                    if (ajoutPosition == false)
                                    {
                                        ajoutOuModificationPosition = BDD.ModifierPositionnement(ligneSelectionner, n_Arret, Convert.ToInt32(listeNUD[i].Value));
                                    }


                                }

                                if (ajoutOuModificationPosition == false)
                                {
                                    MessageBox.Show("Une erreur est survenue lors de la modification d'une des positions !");
                                }
                                else
                                {
                                    MessageBox.Show("Ligne modifié avec succès !");
                                    this.Close();
                                }


                            }
                            else
                            {
                                MessageBox.Show("Vous devez selectionner une couleur !");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Vous devez mettre des rangs différent pour chaque arrêt !");
                        }


                    }
                    else
                    {
                        MessageBox.Show("Vous devez selectionner entre 3 et 20 arrêts !");
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
