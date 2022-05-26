
namespace F1_Application
{
    partial class Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.lblRecherche = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrivee = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboDepart = new System.Windows.Forms.ComboBox();
            this.cboArrivee = new System.Windows.Forms.ComboBox();
            this.nudHeure = new System.Windows.Forms.NumericUpDown();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.pbDate = new System.Windows.Forms.PictureBox();
            this.pbHeure = new System.Windows.Forms.PictureBox();
            this.cmdVisualisation = new System.Windows.Forms.Button();
            this.cmdRechercher = new System.Windows.Forms.Button();
            this.lblVisualisation = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmdConnexionAdmin = new System.Windows.Forms.Button();
            this.lblAdministrateur = new System.Windows.Forms.Label();
            this.cmdGererLignes = new System.Windows.Forms.Button();
            this.cmdGererArrêts = new System.Windows.Forms.Button();
            this.cmdDeconnexionAdmin = new System.Windows.Forms.Button();
            this.pnlRecherche = new System.Windows.Forms.Panel();
            this.pnlVisualisation = new System.Windows.Forms.Panel();
            this.pnlAdministrateur = new System.Windows.Forms.Panel();
            this.lblResultatRecherche = new System.Windows.Forms.Label();
            this.pnlResultatRecherche = new System.Windows.Forms.Panel();
            this.lblH = new System.Windows.Forms.Label();
            this.pnlAffichage = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeure)).BeginInit();
            this.pnlRecherche.SuspendLayout();
            this.pnlAdministrateur.SuspendLayout();
            this.pnlResultatRecherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.BackColor = System.Drawing.Color.AliceBlue;
            this.lblRecherche.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecherche.Location = new System.Drawing.Point(49, 27);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(292, 42);
            this.lblRecherche.TabIndex = 0;
            this.lblRecherche.Text = "Recherche de Trajet ";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDepart.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepart.Location = new System.Drawing.Point(68, 79);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(75, 22);
            this.lblDepart.TabIndex = 1;
            this.lblDepart.Text = "Départ :";
            this.lblDepart.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblArrivee
            // 
            this.lblArrivee.AutoSize = true;
            this.lblArrivee.BackColor = System.Drawing.Color.AliceBlue;
            this.lblArrivee.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArrivee.Location = new System.Drawing.Point(68, 136);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(83, 22);
            this.lblArrivee.TabIndex = 2;
            this.lblArrivee.Text = "Arrivée :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(104, 200);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(176, 23);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.Value = new System.DateTime(2022, 5, 25, 14, 55, 0, 0);
            // 
            // cboDepart
            // 
            this.cboDepart.BackColor = System.Drawing.Color.White;
            this.cboDepart.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cboDepart.FormattingEnabled = true;
            this.cboDepart.Location = new System.Drawing.Point(68, 104);
            this.cboDepart.Name = "cboDepart";
            this.cboDepart.Size = new System.Drawing.Size(212, 23);
            this.cboDepart.TabIndex = 7;
            // 
            // cboArrivee
            // 
            this.cboArrivee.FormattingEnabled = true;
            this.cboArrivee.Location = new System.Drawing.Point(68, 161);
            this.cboArrivee.Name = "cboArrivee";
            this.cboArrivee.Size = new System.Drawing.Size(212, 23);
            this.cboArrivee.TabIndex = 8;
            // 
            // nudHeure
            // 
            this.nudHeure.Location = new System.Drawing.Point(145, 238);
            this.nudHeure.Name = "nudHeure";
            this.nudHeure.Size = new System.Drawing.Size(40, 23);
            this.nudHeure.TabIndex = 14;
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(205, 238);
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(40, 23);
            this.nudMinute.TabIndex = 15;
            // 
            // pbDate
            // 
            this.pbDate.BackColor = System.Drawing.Color.Transparent;
            this.pbDate.Image = global::F1_Application.Properties.Resources.Calendrier_image1;
            this.pbDate.Location = new System.Drawing.Point(68, 200);
            this.pbDate.Name = "pbDate";
            this.pbDate.Size = new System.Drawing.Size(23, 23);
            this.pbDate.TabIndex = 16;
            this.pbDate.TabStop = false;
            // 
            // pbHeure
            // 
            this.pbHeure.BackColor = System.Drawing.Color.Transparent;
            this.pbHeure.Image = global::F1_Application.Properties.Resources.horolge_image1;
            this.pbHeure.Location = new System.Drawing.Point(68, 236);
            this.pbHeure.Name = "pbHeure";
            this.pbHeure.Size = new System.Drawing.Size(23, 23);
            this.pbHeure.TabIndex = 17;
            this.pbHeure.TabStop = false;
            // 
            // cmdVisualisation
            // 
            this.cmdVisualisation.BackColor = System.Drawing.Color.Lavender;
            this.cmdVisualisation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVisualisation.Location = new System.Drawing.Point(69, 430);
            this.cmdVisualisation.Name = "cmdVisualisation";
            this.cmdVisualisation.Size = new System.Drawing.Size(212, 30);
            this.cmdVisualisation.TabIndex = 18;
            this.cmdVisualisation.Text = "Visualiser";
            this.cmdVisualisation.UseVisualStyleBackColor = false;
            // 
            // cmdRechercher
            // 
            this.cmdRechercher.BackColor = System.Drawing.Color.Lavender;
            this.cmdRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRechercher.ForeColor = System.Drawing.Color.Black;
            this.cmdRechercher.Location = new System.Drawing.Point(68, 277);
            this.cmdRechercher.Name = "cmdRechercher";
            this.cmdRechercher.Size = new System.Drawing.Size(212, 30);
            this.cmdRechercher.TabIndex = 19;
            this.cmdRechercher.Text = "Rechercher";
            this.cmdRechercher.UseVisualStyleBackColor = false;
            // 
            // lblVisualisation
            // 
            this.lblVisualisation.AutoSize = true;
            this.lblVisualisation.BackColor = System.Drawing.Color.AliceBlue;
            this.lblVisualisation.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVisualisation.Location = new System.Drawing.Point(9, 326);
            this.lblVisualisation.Name = "lblVisualisation";
            this.lblVisualisation.Size = new System.Drawing.Size(336, 42);
            this.lblVisualisation.TabIndex = 20;
            this.lblVisualisation.Text = "Visualisation des lignes";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(69, 383);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 23);
            this.comboBox1.TabIndex = 21;
            // 
            // cmdConnexionAdmin
            // 
            this.cmdConnexionAdmin.BackColor = System.Drawing.Color.Lavender;
            this.cmdConnexionAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConnexionAdmin.Location = new System.Drawing.Point(47, 66);
            this.cmdConnexionAdmin.Name = "cmdConnexionAdmin";
            this.cmdConnexionAdmin.Size = new System.Drawing.Size(272, 126);
            this.cmdConnexionAdmin.TabIndex = 22;
            this.cmdConnexionAdmin.Text = "Connexion Administrateur";
            this.cmdConnexionAdmin.UseVisualStyleBackColor = false;
            // 
            // lblAdministrateur
            // 
            this.lblAdministrateur.AutoSize = true;
            this.lblAdministrateur.BackColor = System.Drawing.Color.AliceBlue;
            this.lblAdministrateur.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdministrateur.Location = new System.Drawing.Point(20, 0);
            this.lblAdministrateur.Name = "lblAdministrateur";
            this.lblAdministrateur.Size = new System.Drawing.Size(322, 45);
            this.lblAdministrateur.TabIndex = 23;
            this.lblAdministrateur.Text = "Accès Administrateur";
            this.lblAdministrateur.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdGererLignes
            // 
            this.cmdGererLignes.BackColor = System.Drawing.Color.Lavender;
            this.cmdGererLignes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGererLignes.Location = new System.Drawing.Point(76, 83);
            this.cmdGererLignes.Name = "cmdGererLignes";
            this.cmdGererLignes.Size = new System.Drawing.Size(106, 40);
            this.cmdGererLignes.TabIndex = 24;
            this.cmdGererLignes.Text = "Gérer lignes ";
            this.cmdGererLignes.UseVisualStyleBackColor = false;
            this.cmdGererLignes.Visible = false;
            // 
            // cmdGererArrêts
            // 
            this.cmdGererArrêts.BackColor = System.Drawing.Color.Lavender;
            this.cmdGererArrêts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGererArrêts.Location = new System.Drawing.Point(188, 83);
            this.cmdGererArrêts.Name = "cmdGererArrêts";
            this.cmdGererArrêts.Size = new System.Drawing.Size(106, 40);
            this.cmdGererArrêts.TabIndex = 25;
            this.cmdGererArrêts.Text = "Gérer arrêts";
            this.cmdGererArrêts.UseVisualStyleBackColor = false;
            this.cmdGererArrêts.Visible = false;
            // 
            // cmdDeconnexionAdmin
            // 
            this.cmdDeconnexionAdmin.BackColor = System.Drawing.Color.Lavender;
            this.cmdDeconnexionAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDeconnexionAdmin.Location = new System.Drawing.Point(47, 129);
            this.cmdDeconnexionAdmin.Name = "cmdDeconnexionAdmin";
            this.cmdDeconnexionAdmin.Size = new System.Drawing.Size(272, 63);
            this.cmdDeconnexionAdmin.TabIndex = 26;
            this.cmdDeconnexionAdmin.Text = "Quitter le mode Administrateur";
            this.cmdDeconnexionAdmin.UseVisualStyleBackColor = false;
            this.cmdDeconnexionAdmin.Visible = false;
            // 
            // pnlRecherche
            // 
            this.pnlRecherche.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlRecherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecherche.Controls.Add(this.lblRecherche);
            this.pnlRecherche.Location = new System.Drawing.Point(1, 2);
            this.pnlRecherche.Name = "pnlRecherche";
            this.pnlRecherche.Size = new System.Drawing.Size(358, 310);
            this.pnlRecherche.TabIndex = 27;
            // 
            // pnlVisualisation
            // 
            this.pnlVisualisation.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlVisualisation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVisualisation.Location = new System.Drawing.Point(1, 311);
            this.pnlVisualisation.Name = "pnlVisualisation";
            this.pnlVisualisation.Size = new System.Drawing.Size(358, 156);
            this.pnlVisualisation.TabIndex = 28;
            // 
            // pnlAdministrateur
            // 
            this.pnlAdministrateur.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlAdministrateur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdministrateur.Controls.Add(this.cmdGererLignes);
            this.pnlAdministrateur.Controls.Add(this.cmdGererArrêts);
            this.pnlAdministrateur.Controls.Add(this.cmdDeconnexionAdmin);
            this.pnlAdministrateur.Controls.Add(this.lblAdministrateur);
            this.pnlAdministrateur.Controls.Add(this.cmdConnexionAdmin);
            this.pnlAdministrateur.Location = new System.Drawing.Point(1, 466);
            this.pnlAdministrateur.Name = "pnlAdministrateur";
            this.pnlAdministrateur.Size = new System.Drawing.Size(358, 221);
            this.pnlAdministrateur.TabIndex = 29;
            // 
            // lblResultatRecherche
            // 
            this.lblResultatRecherche.AutoSize = true;
            this.lblResultatRecherche.BackColor = System.Drawing.Color.AliceBlue;
            this.lblResultatRecherche.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResultatRecherche.Location = new System.Drawing.Point(10, 16);
            this.lblResultatRecherche.Name = "lblResultatRecherche";
            this.lblResultatRecherche.Size = new System.Drawing.Size(233, 42);
            this.lblResultatRecherche.TabIndex = 1;
            this.lblResultatRecherche.Text = "Votre recherche";
            // 
            // pnlResultatRecherche
            // 
            this.pnlResultatRecherche.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlResultatRecherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResultatRecherche.Controls.Add(this.lblResultatRecherche);
            this.pnlResultatRecherche.Location = new System.Drawing.Point(1100, 2);
            this.pnlResultatRecherche.Name = "pnlResultatRecherche";
            this.pnlResultatRecherche.Size = new System.Drawing.Size(248, 685);
            this.pnlResultatRecherche.TabIndex = 30;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblH.Location = new System.Drawing.Point(187, 239);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(17, 20);
            this.lblH.TabIndex = 13;
            this.lblH.Text = "h";
            // 
            // pnlAffichage
            // 
            this.pnlAffichage.BackColor = System.Drawing.Color.Azure;
            this.pnlAffichage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAffichage.Location = new System.Drawing.Point(359, 2);
            this.pnlAffichage.Name = "pnlAffichage";
            this.pnlAffichage.Size = new System.Drawing.Size(741, 685);
            this.pnlAffichage.TabIndex = 31;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 687);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblVisualisation);
            this.Controls.Add(this.cmdRechercher);
            this.Controls.Add(this.cmdVisualisation);
            this.Controls.Add(this.pbHeure);
            this.Controls.Add(this.pbDate);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.nudHeure);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.cboArrivee);
            this.Controls.Add(this.cboDepart);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblArrivee);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.pnlRecherche);
            this.Controls.Add(this.pnlVisualisation);
            this.Controls.Add(this.pnlAdministrateur);
            this.Controls.Add(this.pnlResultatRecherche);
            this.Controls.Add(this.pnlAffichage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Accueil";
            this.Text = "Le guide du petit arpenteur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHeure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeure)).EndInit();
            this.pnlRecherche.ResumeLayout(false);
            this.pnlRecherche.PerformLayout();
            this.pnlAdministrateur.ResumeLayout(false);
            this.pnlAdministrateur.PerformLayout();
            this.pnlResultatRecherche.ResumeLayout(false);
            this.pnlResultatRecherche.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrivee;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cboDepart;
        private System.Windows.Forms.ComboBox cboArrivee;
        private System.Windows.Forms.NumericUpDown nudHeure;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.PictureBox pbDate;
        private System.Windows.Forms.PictureBox pbHeure;
        private System.Windows.Forms.Button cmdVisualisation;
        private System.Windows.Forms.Button cmdRechercher;
        private System.Windows.Forms.Label lblVisualisation;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cmdConnexionAdmin;
        private System.Windows.Forms.Label lblAdministrateur;
        private System.Windows.Forms.Button cmdGererLignes;
        private System.Windows.Forms.Button cmdGererArrêts;
        private System.Windows.Forms.Button cmdDeconnexionAdmin;
        private System.Windows.Forms.Panel pnlRecherche;
        private System.Windows.Forms.Panel pnlVisualisation;
        private System.Windows.Forms.Panel pnlAdministrateur;
        private System.Windows.Forms.Label lblResultatRecherche;
        private System.Windows.Forms.Panel pnlResultatRecherche;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Panel pnlAffichage;
    }
}

