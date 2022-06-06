using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConnexionBD;

namespace F1_Application
{
    public partial class frmTempsEntreArret : Form
    {

        int premiereArret;
        int deuxiemeArret;
        public frmTempsEntreArret(int arret1, int arret2)
        {
            InitializeComponent();
            premiereArret = arret1;
            deuxiemeArret = arret2;
        }

        private void frmTempsEntreArret_Load(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.chaperon_rouge;
            lblArret.Text = $"Le temps entre {BDD.GetNomArret(premiereArret).ToString()}" +
                $" et {BDD.GetNomArret(deuxiemeArret).ToString()} est inconnu.\n" +
                $"Definissez-le :";
        }

        private void cmdConfirmer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTempsEntreArret_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show($"Voulez-vous vraiment mettre {Convert.ToInt32(nudTempsEntreArret.Value)} minute(s) ?", "Ajouter temps", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                BDD.AjoutTempsEntreArret(premiereArret, deuxiemeArret, Convert.ToInt32(nudTempsEntreArret.Value));
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
