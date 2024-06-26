﻿using System;
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
        int arretSelectionne;
        public frmModifierArret(int arret)
        {
            arretSelectionne = arret;
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

            txtNomArret.Text = BDD.GetNomArret(arretSelectionne);
        }

        private void cmdConfirmerModifierArret_Click(object sender, EventArgs e)
        {
            if(txtNomArret != null && txtNomArret.TextLength >= 3 && txtNomArret.TextLength <= 20)
            {
                // On regarde si un arrêt ne porte pas déjà le nouveau nom de l'arrêt

                bool nomArretDejaExistant = false;

                string[] arret;
                arret = BDD.GetAllArret();
                for (int i = 0; i < arret.Length; i++)
                {
                    if (arret[i] == txtNomArret.Text.ToString() && BDD.GetNomArret(arretSelectionne) != txtNomArret.Text.ToString())
                    {
                        nomArretDejaExistant = true;
                    }
                }

                if (nomArretDejaExistant == false)
                {
                    int numArret = arretSelectionne;

                    bool resultat = BDD.ModifierNomArret(numArret, txtNomArret.Text.ToString());

                    if (resultat)
                    {
                        MessageBox.Show($"Le nom de l'arrêt a bien été modifié en : {txtNomArret.Text.ToString()} !");
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
                MessageBox.Show("Le nouveau nom doit faire entre 3 et 20 caractères !");
            }
        }
    }
}
