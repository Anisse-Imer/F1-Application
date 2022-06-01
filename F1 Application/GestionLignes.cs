using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Information;
using ConnexionBD;


namespace F1_Application
{
    public partial class frmGestionLignes : Form
    {
        public frmGestionLignes()
        {
            InitializeComponent();
        }

        private void cmdAjouterLigne_Click(object sender, EventArgs e)
        {
            frmAjouterLigne ajouterLigne = new frmAjouterLigne();
            ajouterLigne.ShowDialog();

            ReloadLigne();
        }

        private void frmGestionLignes_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.chaperon_rouge;
            ReloadLigne();
        }

        /// <summary>
        /// Permet de reload la combobox des lignes
        /// </summary>
        private void ReloadLigne()
        {
            cboSelectionLigne.Items.Clear();

            string[] ligne;
            ligne = BDD.GetAllLigne();
            for (int i = 0; i < ligne.Length; i++)
            {
                cboSelectionLigne.Items.Add(ligne[i]);
            }
        }

        private void cmdAnnulerGestionLigne_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdSupprimerLigne_Click(object sender, EventArgs e)
        {
            if (cboSelectionLigne.SelectedItem != null)
            {
                DialogResult dialogResult = MessageBox.Show("Voulez-vous vraiment supprimer cette ligne ? \nC'est une action irréversible. ", "Supprimer Ligne", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    int num_Ligne = BDD.GetNumLigne(cboSelectionLigne.SelectedItem.ToString());

                    // Supprimer la ligne de la table positionnement

                    bool supressionPosition = BDD.SupprimerLignePositionnement(num_Ligne);

                    if(supressionPosition == false)
                    {
                        MessageBox.Show("Un erreur est survenue lors de la supression de la ligne dans la table Positionnement!");
                    }

                    // Supprimer la ligne définitivement

                    bool supressionLigne = BDD.SupprimerLigne(num_Ligne);
                    information.RemoveLigne();

                    if (supressionLigne == false)
                    {
                        MessageBox.Show("Un erreur est survenue lors de la supression de la ligne !");
                    } 
                    else
                    {
                        MessageBox.Show("La ligne a bien été supprimé !");
                    }

                    ReloadLigne();

                }

            }
            else
            {
                MessageBox.Show("Vous devez selectionner une ligne !");
            }
        }

        private void cmdModifierLigne_Click(object sender, EventArgs e)
        {
            if (cboSelectionLigne.SelectedItem != null)
            {
                frmModifierLigne modifierLigne = new frmModifierLigne(BDD.GetNumLigne(cboSelectionLigne.SelectedItem.ToString()));
                modifierLigne.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vous devez selectionner une ligne !");
            }

            ReloadLigne();
        }
    }
}
