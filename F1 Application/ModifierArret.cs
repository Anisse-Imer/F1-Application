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
    public partial class frmModifierArret : Form
    {
      //  int arretselec;
        public frmModifierArret()
        {
           // arretselec = arret;
            InitializeComponent();
        }

        private void cmdAnnulerModifierArret_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModifierArret_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.chaperon_rouge;
            string[] arret;
            arret = BDD.GetAllArret();
            for (int i = 0; i < arret.Length; i++)
            {
                lstArretsReseau.Items.Add(arret[i]);
            }
        }

        private void cmdConfirmerModifierArret_Click(object sender, EventArgs e)
        {
            if(lstArretsReseau.SelectedItem != null)
            {
                if(txtNomArret != null && txtNomArret.TextLength >= 3)
                {
                    int numArret = BDD.GetNumArret(lstArretsReseau.SelectedItem.ToString());

                    bool resultat = BDD.ModifierNomArret(numArret, txtNomArret.Text.ToString());

                    if (resultat)
                    {
                        MessageBox.Show($"Le nom de l'arret a bien été modifié en : {txtNomArret.Text.ToString()} !");
                        this.Close();
                    } else
                    {
                        MessageBox.Show("Une erreur est survenue !");
                    }
                }
                else
                {
                    MessageBox.Show("Le nouveau nom doit faire au moins 3 caractères !");
                }
            }
            else
            {
                MessageBox.Show("Vous devez selectionner un arret !");
            }
        }
    }
}
