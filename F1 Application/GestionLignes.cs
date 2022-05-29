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
            ReloadLigne();
        }


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
    }
}
