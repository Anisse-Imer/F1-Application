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
        public frmModifierLigne()
        {
            InitializeComponent();
        }

        private void lblModifierLigne_Click(object sender, EventArgs e)
        {

        }

        private void cmdAnnulerModifierLigne_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModifierLigne_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.chaperon_rouge;
            string[] arret;
            arret = BDD.GetAllArret();
            for (int i = 0; i < arret.Length; i++)
            {
                clstListeArrets.Items.Add(arret[i]);
            }

            string[] ligne;
            ligne = BDD.GetAllLigne();
            for (int i = 0; i < ligne.Length; i++)
            {
                cboLigneAModifier.Items.Add(ligne[i]);
            }

            cboCouleur.Items.Add("Rouge");
            cboCouleur.Items.Add("Bleu");
            cboCouleur.Items.Add("Vert");
            cboCouleur.Items.Add("Orange");
            cboCouleur.Items.Add("Rose");
        }

        NumericUpDown[] listeNUD = new NumericUpDown[20];
        Label[] listeLBL = new Label[20];
        bool ligneSelection = true;

        private void cboLigneAModifier_SelectedValueChanged(object sender, EventArgs e)
        {
            ligneSelection = true;
            flpRangDesArret.Controls.Clear();

            int num_Ligne = BDD.GetNumLigne(cboLigneAModifier.SelectedItem.ToString());

            string couleurLigne = BDD.GetCouleur(num_Ligne);

            bool flag = false;
            for(int i=0; i < cboCouleur.Items.Count; i++)
            {
                if(cboCouleur.Items[i].ToString() == couleurLigne.ToString())
                {
                    flag = true;
                    cboCouleur.SelectedIndex = i;
                }
            }

            if(flag == false)
            {
                cboCouleur.Items.Add(couleurLigne);
                cboCouleur.SelectedIndex = cboCouleur.Items.Count - 1;
            }
            

            txtNomLigne.Text = cboLigneAModifier.SelectedItem.ToString();

            int[] arretEtRangDeLarret = new int[20];
            arretEtRangDeLarret = BDD.GetAllArretInLigne(num_Ligne);

            string[] nomArretEtRangDeLarret = new string[20];

            for(int i=0; i < 20; i++)
            {
                nomArretEtRangDeLarret[i] = BDD.GetNomArret(arretEtRangDeLarret[i]).ToString();
            }

            int nbrArret = 0;
            
            for(int i=0; i < clstListeArrets.Items.Count; i++)
            {

                bool arretDansLigne = false;
                for (int j = 0; arretEtRangDeLarret[j] != 0 && arretDansLigne == false ; j++)
                {
                    // Debug.Print(arretEtRangDeLarret[j].ToString());
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

            for(int i = 0; i < nbrArret; i++)
            {
                listeNUD[i].Maximum = nbrArret;
            }

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
                bool flag = false;

                string[] ligne;
                ligne = BDD.GetAllLigne();
                for (int i = 0; i < ligne.Length; i++)
                {
                    if (ligne[i] == txtNomLigne.Text.ToString() && txtNomLigne.Text.ToString() != cboLigneAModifier.SelectedItem.ToString())
                    {
                        flag = true;
                    }
                }

                if (flag == false)
                {
                    // Debug.Print(flpRangArret.Controls.Count.ToString());
                    if (flpRangDesArret.Controls.Count >= 6 && flpRangDesArret.Controls.Count <= 40)
                    {
                        int[] verif = new int[flpRangDesArret.Controls.Count / 2];

                        bool rangIdentique = false;

                        for (int i = 0; i < flpRangDesArret.Controls.Count / 2 && rangIdentique == false; i++)
                        {
                            verif[i] = Convert.ToInt32(listeNUD[i].Value);
                            // Debug.Print(listeNUD[i].Value.ToString());
                            // Debug.Print(listeLBL[i].Text.ToString());

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

                                // Suppression de l'ancienne ligne

                                int num_Ligne = BDD.GetNumLigne(cboLigneAModifier.SelectedItem.ToString());
                                BDD.SupprimerLignePositionnement(num_Ligne);
                                BDD.SupprimerLigne(num_Ligne);


                                // Ajout de la nouvelle ligne

                                int n_Ligne = BDD.AjoutLigne(txtNomLigne.Text.ToString(), cboCouleur.SelectedItem.ToString());

                                if (n_Ligne != 1)
                                {

                                    bool ajoutPosition = true;

                                    for (int i = 0; i < flpRangDesArret.Controls.Count / 2 && ajoutPosition == true; i++)
                                    {
                                        int n_Arret = BDD.GetNumArret(listeLBL[i].Text.ToString());

                                        ajoutPosition = BDD.AjoutPositionnement(n_Ligne, n_Arret, Convert.ToInt32(listeNUD[i].Value));
                                    }

                                    if (ajoutPosition == false)
                                    {
                                        MessageBox.Show("Une erreur est survenue lors de la modification d'une des positions !");
                                    }

                                    MessageBox.Show("Ligne modifié avec succès !");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Une erreur est survenue lors de la modification de la ligne !");
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
