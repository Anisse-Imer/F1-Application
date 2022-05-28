using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ConnexionBD;
using Information;

namespace F1_Application
{
    public partial class frmGestionArret : Form
    {
        public frmGestionArret()
        {
            InitializeComponent();
        }

        private void frmGestionArret_Load(object sender, EventArgs e)
        {
            string[] arret;
            arret = BDD.GetAllArret();
            for (int i = 0; i < arret.Length; i++)
            {
                cboArret.Items.Add(arret[i]);
            }
        }

        private void cmdAnnulerGestionArret_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdModifierArret_Click(object sender, EventArgs e)
        {
            frmModifierArret modifierArret = new frmModifierArret();
            modifierArret.ShowDialog();

            
            cboArret.Items.Clear();
            string[] arret;
            arret = BDD.GetAllArret();
            for (int i = 0; i < arret.Length; i++)
            {
                cboArret.Items.Add(arret[i]);
            }
        }
    }
}
