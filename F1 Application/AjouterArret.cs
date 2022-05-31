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
            if (txtNomArret != null && txtNomArret.TextLength >= 3)
            {
                bool flag = false;

                string[] arret;
                arret = BDD.GetAllArret();
                for (int i = 0; i < arret.Length; i++)
                {
                    if(arret[i] == txtNomArret.Text.ToString())
                    {
                        flag = true;
                    }
                }

                if(flag == false)
                {
                    int resultat = BDD.AjoutArret(txtNomArret.Text.ToString());

                    if (resultat != -1)
                    {
                        MessageBox.Show($"L'arrêts {txtNomArret.Text.ToString()} a bien été ajouté, il porte le numéro {resultat} !");
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
                MessageBox.Show("Le nom doit faire au moins 3 caractères !");
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
