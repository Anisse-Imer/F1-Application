using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Information;

namespace F1_Application
{
    public partial class frmConnexionAdmin : Form
    {
        public frmConnexionAdmin()
        {
            InitializeComponent();
        }

        private void cmdValiderAdministrateur_Click(object sender, EventArgs e)
        {
            String identifiant = txtIdentifiant.Text;
            String motDePasse = txtMotDePasse.Text;

            bool motDePasseCorrect = false;

            if(identifiant == "U3IA" && motDePasse == "admin")
            {
                motDePasseCorrect = true;
            }

            if (motDePasseCorrect == true)
            {
                MessageBox.Show("Vous êtes connecté en tant qu'administrateur", "Correct");
                information.ChangeAdminMode();
                this.Close();

            }
            else
            {
                MessageBox.Show($"Identifiant ou mot de passe incorrect", "Erreur");
            }
        }
    }
}
