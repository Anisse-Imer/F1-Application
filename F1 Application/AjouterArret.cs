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
    public partial class frmAjouterArret : Form
    {
        public frmAjouterArret()
        {
            InitializeComponent();
        }

        private void lblArretsAjouterLigne_Click(object sender, EventArgs e)
        {

        }

        private void cmdAnnulerAjouterArret_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdConfirmerAjouterArret_Click(object sender, EventArgs e)
        {
            if (txtNomArret != null && txtNomArret.TextLength >= 3 && txtNomArret.TextLength <= 20)
            {

                // On regarde si un arrêt ne porte pas déjà le nom du nouvel arrêt

                bool nomArretDejaExistant = false;

                string[] arret;
                arret = BDD.GetAllArret();
                for (int i = 0; i < arret.Length; i++)
                {
                    if(arret[i] == txtNomArret.Text.ToString())
                    {
                        nomArretDejaExistant = true;
                    }
                }

                if(nomArretDejaExistant == false)
                {
                    int idNouvelArret = BDD.AjoutArret(txtNomArret.Text.ToString());

                    if (idNouvelArret != -1)
                    {
                        MessageBox.Show($"L'arrêt {txtNomArret.Text.ToString()} a bien été ajouté, il porte le numéro {idNouvelArret} !");
                        information.AddArret();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Une erreur est survenue !");
                    }
                }
                else
                {
                    MessageBox.Show("Un arrêt porte déjà ce nom !");
                }
            }
            else
            {
                MessageBox.Show("Le nom doit faire entre 3 et 20 caractères !");
            }
        }

        private void frmAjouterArret_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.chaperon_rouge;
            string[] arret;
            arret = BDD.GetAllArret();
            for (int i = 0; i < arret.Length; i++)
            {
                lstArretsReseau.Items.Add(arret[i]);
            }
        }
    }
}
