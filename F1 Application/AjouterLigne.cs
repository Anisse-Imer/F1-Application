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
            string[] arret;
            arret = BDD.GetAllArret();
            for (int i = 0; i < arret.Length; i++)
            {
                clstListeArrets.Items.Add(arret[i]);
            }

            cboCouleur.Items.Add("rouge");
            cboCouleur.Items.Add("bleu");
            cboCouleur.Items.Add("vert");
            cboCouleur.Items.Add("orange");
            cboCouleur.Items.Add("rose");
        }

        NumericUpDown[] listeNUD = new NumericUpDown[20];
        Label[] listeLBL = new Label[20];

        private void clstListeArrets_ItemCheck(object sender, ItemCheckEventArgs e)
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

                lblNbrArretSelectionne.Text = newNbrArretSelectionnet.ToString();

                flpRangArret.Controls.Clear();

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

                        flpRangArret.Controls.Add(lbl);
                        flpRangArret.Controls.Add(nud);

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
                    e.NewValue = CheckState.Unchecked;
                    MessageBox.Show("20 arrêts maximum !");
                }
                else
                {
                    flpRangArret.Controls.Clear();
                }
                
            }
        }

        private void cmdConfirmerAjouterLigne_Click(object sender, EventArgs e)
        {
            if (txtNomLigne != null && txtNomLigne.TextLength >= 3)
            {
                bool flag = false;

                string[] ligne;
                ligne = BDD.GetAllLigne();
                for (int i = 0; i < ligne.Length; i++)
                {
                    if (ligne[i] == txtNomLigne.Text.ToString())
                    {
                        flag = true;
                    }
                }

                if (flag == false)
                {
                    // Debug.Print(flpRangArret.Controls.Count.ToString());
                    if (flpRangArret.Controls.Count >= 6 && flpRangArret.Controls.Count <= 40)
                    {
                        int[] verif = new int[flpRangArret.Controls.Count / 2];

                        bool rangIdentique = false;

                        for(int i = 0; i < flpRangArret.Controls.Count / 2 && rangIdentique == false; i++)
                        {
                            verif[i] = Convert.ToInt32(listeNUD[i].Value);
                            // Debug.Print(listeNUD[i].Value.ToString());
                            // Debug.Print(listeLBL[i].Text.ToString());

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
                                int n_Ligne = BDD.AjoutLigne(txtNomLigne.Text.ToString(), cboCouleur.SelectedItem.ToString());

                                if (n_Ligne != 1)
                                {

                                    bool ajoutPosition = true;

                                    for (int i = 0; i < flpRangArret.Controls.Count / 2 && ajoutPosition == true; i++)
                                    {
                                        int n_Arret = BDD.GetNumArret(listeLBL[i].Text.ToString());

                                        ajoutPosition = BDD.AjoutPositionnement(n_Ligne, n_Arret, Convert.ToInt32(listeNUD[i].Value));
                                    }

                                    if(ajoutPosition == false)
                                    {
                                        MessageBox.Show("Une erreur est survenue lors de la création d'une des positions !");
                                    }

                                    information.AddLigne();

                                    MessageBox.Show("Ligne créée avec succès !");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Une erreur est survenue lors de la création de la ligne !");
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
