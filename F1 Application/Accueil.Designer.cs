﻿
namespace F1_Application
{
    partial class frmAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccueil));
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
            this.cboVisualiserLigne = new System.Windows.Forms.ComboBox();
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
            this.lblVisualiserLigne = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeure)).BeginInit();
            this.pnlRecherche.SuspendLayout();
            this.pnlVisualisation.SuspendLayout();
            this.pnlAdministrateur.SuspendLayout();
            this.pnlResultatRecherche.SuspendLayout();
            this.pnlAffichage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.BackColor = System.Drawing.Color.AliceBlue;
            this.lblRecherche.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lblRecherche.Location = new System.Drawing.Point(42, 23);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(231, 32);
            this.lblRecherche.TabIndex = 0;
            this.lblRecherche.Text = "Recherche de Trajet ";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDepart.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblDepart.Location = new System.Drawing.Point(58, 68);
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
            this.lblArrivee.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.lblArrivee.Location = new System.Drawing.Point(58, 118);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(83, 22);
            this.lblArrivee.TabIndex = 2;
            this.lblArrivee.Text = "Arrivée :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(89, 173);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(151, 20);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.Value = new System.DateTime(2022, 5, 25, 14, 55, 0, 0);
            // 
            // cboDepart
            // 
            this.cboDepart.BackColor = System.Drawing.Color.White;
            this.cboDepart.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cboDepart.FormattingEnabled = true;
            this.cboDepart.Location = new System.Drawing.Point(58, 90);
            this.cboDepart.Name = "cboDepart";
            this.cboDepart.Size = new System.Drawing.Size(182, 21);
            this.cboDepart.TabIndex = 7;
            // 
            // cboArrivee
            // 
            this.cboArrivee.FormattingEnabled = true;
            this.cboArrivee.Location = new System.Drawing.Point(58, 140);
            this.cboArrivee.Name = "cboArrivee";
            this.cboArrivee.Size = new System.Drawing.Size(182, 21);
            this.cboArrivee.TabIndex = 8;
            // 
            // nudHeure
            // 
            this.nudHeure.Location = new System.Drawing.Point(124, 206);
            this.nudHeure.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHeure.Name = "nudHeure";
            this.nudHeure.Size = new System.Drawing.Size(34, 20);
            this.nudHeure.TabIndex = 14;
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(176, 206);
            this.nudMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(34, 20);
            this.nudMinute.TabIndex = 15;
            // 
            // pbDate
            // 
            this.pbDate.BackColor = System.Drawing.Color.Transparent;
            this.pbDate.Image = global::F1_Application.Properties.Resources.Calendrier_image1;
            this.pbDate.Location = new System.Drawing.Point(58, 173);
            this.pbDate.Name = "pbDate";
            this.pbDate.Size = new System.Drawing.Size(20, 20);
            this.pbDate.TabIndex = 16;
            this.pbDate.TabStop = false;
            // 
            // pbHeure
            // 
            this.pbHeure.BackColor = System.Drawing.Color.Transparent;
            this.pbHeure.Image = global::F1_Application.Properties.Resources.horolge_image1;
            this.pbHeure.Location = new System.Drawing.Point(58, 205);
            this.pbHeure.Name = "pbHeure";
            this.pbHeure.Size = new System.Drawing.Size(20, 20);
            this.pbHeure.TabIndex = 17;
            this.pbHeure.TabStop = false;
            // 
            // cmdVisualisation
            // 
            this.cmdVisualisation.BackColor = System.Drawing.Color.Lavender;
            this.cmdVisualisation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVisualisation.Location = new System.Drawing.Point(59, 373);
            this.cmdVisualisation.Name = "cmdVisualisation";
            this.cmdVisualisation.Size = new System.Drawing.Size(182, 26);
            this.cmdVisualisation.TabIndex = 18;
            this.cmdVisualisation.Text = "Visualiser";
            this.cmdVisualisation.UseVisualStyleBackColor = false;
            this.cmdVisualisation.Click += new System.EventHandler(this.cmdVisualisation_Click);
            // 
            // cmdRechercher
            // 
            this.cmdRechercher.BackColor = System.Drawing.Color.Lavender;
            this.cmdRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRechercher.ForeColor = System.Drawing.Color.Black;
            this.cmdRechercher.Location = new System.Drawing.Point(58, 240);
            this.cmdRechercher.Name = "cmdRechercher";
            this.cmdRechercher.Size = new System.Drawing.Size(182, 26);
            this.cmdRechercher.TabIndex = 19;
            this.cmdRechercher.Text = "Rechercher";
            this.cmdRechercher.UseVisualStyleBackColor = false;
            // 
            // lblVisualisation
            // 
            this.lblVisualisation.AutoSize = true;
            this.lblVisualisation.BackColor = System.Drawing.Color.AliceBlue;
            this.lblVisualisation.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lblVisualisation.Location = new System.Drawing.Point(8, 3);
            this.lblVisualisation.Name = "lblVisualisation";
            this.lblVisualisation.Size = new System.Drawing.Size(292, 37);
            this.lblVisualisation.TabIndex = 20;
            this.lblVisualisation.Text = "Visualisation des lignes";
            // 
            // cboVisualiserLigne
            // 
            this.cboVisualiserLigne.FormattingEnabled = true;
            this.cboVisualiserLigne.Location = new System.Drawing.Point(59, 332);
            this.cboVisualiserLigne.Name = "cboVisualiserLigne";
            this.cboVisualiserLigne.Size = new System.Drawing.Size(182, 21);
            this.cboVisualiserLigne.TabIndex = 21;
            // 
            // cmdConnexionAdmin
            // 
            this.cmdConnexionAdmin.BackColor = System.Drawing.Color.Lavender;
            this.cmdConnexionAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConnexionAdmin.Location = new System.Drawing.Point(40, 57);
            this.cmdConnexionAdmin.Name = "cmdConnexionAdmin";
            this.cmdConnexionAdmin.Size = new System.Drawing.Size(233, 109);
            this.cmdConnexionAdmin.TabIndex = 22;
            this.cmdConnexionAdmin.Text = "Connexion Administrateur";
            this.cmdConnexionAdmin.UseVisualStyleBackColor = false;
            this.cmdConnexionAdmin.Click += new System.EventHandler(this.cmdConnexionAdmin_Click);
            // 
            // lblAdministrateur
            // 
            this.lblAdministrateur.AutoSize = true;
            this.lblAdministrateur.BackColor = System.Drawing.Color.AliceBlue;
            this.lblAdministrateur.Font = new System.Drawing.Font("Segoe UI", 19F);
            this.lblAdministrateur.Location = new System.Drawing.Point(17, 0);
            this.lblAdministrateur.Name = "lblAdministrateur";
            this.lblAdministrateur.Size = new System.Drawing.Size(258, 36);
            this.lblAdministrateur.TabIndex = 23;
            this.lblAdministrateur.Text = "Accès Administrateur";
            this.lblAdministrateur.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdGererLignes
            // 
            this.cmdGererLignes.BackColor = System.Drawing.Color.Lavender;
            this.cmdGererLignes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGererLignes.Location = new System.Drawing.Point(65, 72);
            this.cmdGererLignes.Name = "cmdGererLignes";
            this.cmdGererLignes.Size = new System.Drawing.Size(91, 35);
            this.cmdGererLignes.TabIndex = 24;
            this.cmdGererLignes.Text = "Gérer lignes ";
            this.cmdGererLignes.UseVisualStyleBackColor = false;
            this.cmdGererLignes.Visible = false;
            // 
            // cmdGererArrêts
            // 
            this.cmdGererArrêts.BackColor = System.Drawing.Color.Lavender;
            this.cmdGererArrêts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGererArrêts.Location = new System.Drawing.Point(161, 72);
            this.cmdGererArrêts.Name = "cmdGererArrêts";
            this.cmdGererArrêts.Size = new System.Drawing.Size(91, 35);
            this.cmdGererArrêts.TabIndex = 25;
            this.cmdGererArrêts.Text = "Gérer arrêts";
            this.cmdGererArrêts.UseVisualStyleBackColor = false;
            this.cmdGererArrêts.Visible = false;
            this.cmdGererArrêts.Click += new System.EventHandler(this.cmdGererArrêts_Click);
            // 
            // cmdDeconnexionAdmin
            // 
            this.cmdDeconnexionAdmin.BackColor = System.Drawing.Color.Lavender;
            this.cmdDeconnexionAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDeconnexionAdmin.Location = new System.Drawing.Point(40, 112);
            this.cmdDeconnexionAdmin.Name = "cmdDeconnexionAdmin";
            this.cmdDeconnexionAdmin.Size = new System.Drawing.Size(233, 55);
            this.cmdDeconnexionAdmin.TabIndex = 26;
            this.cmdDeconnexionAdmin.Text = "Quitter le mode Administrateur";
            this.cmdDeconnexionAdmin.UseVisualStyleBackColor = false;
            this.cmdDeconnexionAdmin.Visible = false;
            this.cmdDeconnexionAdmin.Click += new System.EventHandler(this.cmdDeconnexionAdmin_Click);
            // 
            // pnlRecherche
            // 
            this.pnlRecherche.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlRecherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecherche.Controls.Add(this.lblRecherche);
            this.pnlRecherche.Location = new System.Drawing.Point(1, 2);
            this.pnlRecherche.Name = "pnlRecherche";
            this.pnlRecherche.Size = new System.Drawing.Size(307, 269);
            this.pnlRecherche.TabIndex = 27;
            // 
            // pnlVisualisation
            // 
            this.pnlVisualisation.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlVisualisation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVisualisation.Controls.Add(this.lblVisualisation);
            this.pnlVisualisation.Location = new System.Drawing.Point(1, 270);
            this.pnlVisualisation.Name = "pnlVisualisation";
            this.pnlVisualisation.Size = new System.Drawing.Size(307, 135);
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
            this.pnlAdministrateur.Location = new System.Drawing.Point(1, 404);
            this.pnlAdministrateur.Name = "pnlAdministrateur";
            this.pnlAdministrateur.Size = new System.Drawing.Size(307, 192);
            this.pnlAdministrateur.TabIndex = 29;
            // 
            // lblResultatRecherche
            // 
            this.lblResultatRecherche.AutoSize = true;
            this.lblResultatRecherche.BackColor = System.Drawing.Color.AliceBlue;
            this.lblResultatRecherche.Font = new System.Drawing.Font("Segoe UI", 23F);
            this.lblResultatRecherche.Location = new System.Drawing.Point(9, 14);
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
            this.pnlResultatRecherche.Location = new System.Drawing.Point(943, 2);
            this.pnlResultatRecherche.Name = "pnlResultatRecherche";
            this.pnlResultatRecherche.Size = new System.Drawing.Size(213, 594);
            this.pnlResultatRecherche.TabIndex = 30;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Impact", 12F);
            this.lblH.Location = new System.Drawing.Point(160, 207);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(17, 20);
            this.lblH.TabIndex = 13;
            this.lblH.Text = "h";
            // 
            // pnlAffichage
            // 
            this.pnlAffichage.BackColor = System.Drawing.Color.Azure;
            this.pnlAffichage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAffichage.Controls.Add(this.lblVisualiserLigne);
            this.pnlAffichage.Location = new System.Drawing.Point(308, 2);
            this.pnlAffichage.Name = "pnlAffichage";
            this.pnlAffichage.Size = new System.Drawing.Size(635, 594);
            this.pnlAffichage.TabIndex = 31;
            // 
            // lblVisualiserLigne
            // 
            this.lblVisualiserLigne.AutoSize = true;
            this.lblVisualiserLigne.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblVisualiserLigne.Location = new System.Drawing.Point(3, 0);
            this.lblVisualiserLigne.Name = "lblVisualiserLigne";
            this.lblVisualiserLigne.Size = new System.Drawing.Size(230, 25);
            this.lblVisualiserLigne.TabIndex = 0;
            this.lblVisualiserLigne.Text = "Aucune ligne selectionné";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 595);
            this.Controls.Add(this.cboVisualiserLigne);
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
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1171, 634);
            this.Name = "frmAccueil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le guide du petit arpenteur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Accueil_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Accueil_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHeure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeure)).EndInit();
            this.pnlRecherche.ResumeLayout(false);
            this.pnlRecherche.PerformLayout();
            this.pnlVisualisation.ResumeLayout(false);
            this.pnlVisualisation.PerformLayout();
            this.pnlAdministrateur.ResumeLayout(false);
            this.pnlAdministrateur.PerformLayout();
            this.pnlResultatRecherche.ResumeLayout(false);
            this.pnlResultatRecherche.PerformLayout();
            this.pnlAffichage.ResumeLayout(false);
            this.pnlAffichage.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboVisualiserLigne;
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
        private System.Windows.Forms.Label lblVisualiserLigne;
    }
}

