
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
            this.lblArriveeOuDepart = new System.Windows.Forms.Label();
            this.optDépart = new System.Windows.Forms.RadioButton();
            this.optArrivée = new System.Windows.Forms.RadioButton();
            this.lblH = new System.Windows.Forms.Label();
            this.pnlVisualisation = new System.Windows.Forms.Panel();
            this.lblVisualisationDemande = new System.Windows.Forms.Label();
            this.pnlAdministrateur = new System.Windows.Forms.Panel();
            this.lblResultatRecherche = new System.Windows.Forms.Label();
            this.pnlResultatRecherche = new System.Windows.Forms.Panel();
            this.pnlAffichage = new System.Windows.Forms.Panel();
            this.lblVisualiserLigne = new System.Windows.Forms.Label();
            this.pnlAfficherLigne = new System.Windows.Forms.Panel();
            this.lblAffichageResultatRecherche = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeure)).BeginInit();
            this.pnlRecherche.SuspendLayout();
            this.pnlVisualisation.SuspendLayout();
            this.pnlAdministrateur.SuspendLayout();
            this.pnlResultatRecherche.SuspendLayout();
            this.pnlAffichage.SuspendLayout();
            this.pnlAfficherLigne.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.BackColor = System.Drawing.Color.AliceBlue;
            this.lblRecherche.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherche.Location = new System.Drawing.Point(33, 15);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(236, 33);
            this.lblRecherche.TabIndex = 0;
            this.lblRecherche.Text = "Recherche de Trajet ";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.BackColor = System.Drawing.Color.AliceBlue;
            this.lblDepart.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepart.Location = new System.Drawing.Point(56, 58);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(85, 28);
            this.lblDepart.TabIndex = 1;
            this.lblDepart.Text = "Départ :";
            this.lblDepart.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblArrivee
            // 
            this.lblArrivee.AutoSize = true;
            this.lblArrivee.BackColor = System.Drawing.Color.AliceBlue;
            this.lblArrivee.Font = new System.Drawing.Font("Perpetua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArrivee.Location = new System.Drawing.Point(56, 111);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(90, 28);
            this.lblArrivee.TabIndex = 2;
            this.lblArrivee.Text = "Arrivée :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(107, 173);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(122, 20);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.Value = new System.DateTime(2022, 5, 25, 14, 55, 0, 0);
            // 
            // cboDepart
            // 
            this.cboDepart.BackColor = System.Drawing.Color.White;
            this.cboDepart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDepart.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.cboDepart.FormattingEnabled = true;
            this.cboDepart.Location = new System.Drawing.Point(58, 90);
            this.cboDepart.Name = "cboDepart";
            this.cboDepart.Size = new System.Drawing.Size(182, 21);
            this.cboDepart.TabIndex = 7;
            // 
            // cboArrivee
            // 
            this.cboArrivee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArrivee.FormattingEnabled = true;
            this.cboArrivee.Location = new System.Drawing.Point(58, 140);
            this.cboArrivee.Name = "cboArrivee";
            this.cboArrivee.Size = new System.Drawing.Size(182, 21);
            this.cboArrivee.TabIndex = 8;
            // 
            // nudHeure
            // 
            this.nudHeure.Location = new System.Drawing.Point(122, 203);
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
            this.nudMinute.Location = new System.Drawing.Point(180, 203);
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
            this.pbDate.Size = new System.Drawing.Size(23, 23);
            this.pbDate.TabIndex = 16;
            this.pbDate.TabStop = false;
            // 
            // pbHeure
            // 
            this.pbHeure.BackColor = System.Drawing.Color.Transparent;
            this.pbHeure.Image = global::F1_Application.Properties.Resources.horolge_image1;
            this.pbHeure.Location = new System.Drawing.Point(56, 200);
            this.pbHeure.Name = "pbHeure";
            this.pbHeure.Size = new System.Drawing.Size(23, 23);
            this.pbHeure.TabIndex = 17;
            this.pbHeure.TabStop = false;
            // 
            // cmdVisualisation
            // 
            this.cmdVisualisation.BackColor = System.Drawing.Color.Lavender;
            this.cmdVisualisation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVisualisation.Location = new System.Drawing.Point(56, 110);
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
            this.cmdRechercher.Location = new System.Drawing.Point(60, 311);
            this.cmdRechercher.Name = "cmdRechercher";
            this.cmdRechercher.Size = new System.Drawing.Size(182, 26);
            this.cmdRechercher.TabIndex = 19;
            this.cmdRechercher.Text = "Rechercher";
            this.cmdRechercher.UseVisualStyleBackColor = false;
            this.cmdRechercher.Click += new System.EventHandler(this.cmdRechercher_Click);
            // 
            // lblVisualisation
            // 
            this.lblVisualisation.AutoSize = true;
            this.lblVisualisation.BackColor = System.Drawing.Color.AliceBlue;
            this.lblVisualisation.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualisation.Location = new System.Drawing.Point(19, 23);
            this.lblVisualisation.Name = "lblVisualisation";
            this.lblVisualisation.Size = new System.Drawing.Size(255, 33);
            this.lblVisualisation.TabIndex = 20;
            this.lblVisualisation.Text = "Visualisation des lignes";
            // 
            // cboVisualiserLigne
            // 
            this.cboVisualiserLigne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVisualiserLigne.FormattingEnabled = true;
            this.cboVisualiserLigne.Location = new System.Drawing.Point(56, 83);
            this.cboVisualiserLigne.Name = "cboVisualiserLigne";
            this.cboVisualiserLigne.Size = new System.Drawing.Size(182, 21);
            this.cboVisualiserLigne.TabIndex = 21;
            // 
            // cmdConnexionAdmin
            // 
            this.cmdConnexionAdmin.BackColor = System.Drawing.Color.Lavender;
            this.cmdConnexionAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConnexionAdmin.Location = new System.Drawing.Point(36, 57);
            this.cmdConnexionAdmin.Name = "cmdConnexionAdmin";
            this.cmdConnexionAdmin.Size = new System.Drawing.Size(233, 91);
            this.cmdConnexionAdmin.TabIndex = 22;
            this.cmdConnexionAdmin.Text = "Connexion Administrateur";
            this.cmdConnexionAdmin.UseVisualStyleBackColor = false;
            this.cmdConnexionAdmin.Click += new System.EventHandler(this.cmdConnexionAdmin_Click);
            // 
            // lblAdministrateur
            // 
            this.lblAdministrateur.AutoSize = true;
            this.lblAdministrateur.BackColor = System.Drawing.Color.AliceBlue;
            this.lblAdministrateur.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrateur.Location = new System.Drawing.Point(33, 12);
            this.lblAdministrateur.Name = "lblAdministrateur";
            this.lblAdministrateur.Size = new System.Drawing.Size(241, 33);
            this.lblAdministrateur.TabIndex = 23;
            this.lblAdministrateur.Text = "Accès Administrateur";
            this.lblAdministrateur.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdGererLignes
            // 
            this.cmdGererLignes.BackColor = System.Drawing.Color.Lavender;
            this.cmdGererLignes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGererLignes.Location = new System.Drawing.Point(60, 72);
            this.cmdGererLignes.Name = "cmdGererLignes";
            this.cmdGererLignes.Size = new System.Drawing.Size(91, 35);
            this.cmdGererLignes.TabIndex = 24;
            this.cmdGererLignes.Text = "Gérer lignes ";
            this.cmdGererLignes.UseVisualStyleBackColor = false;
            this.cmdGererLignes.Visible = false;
            this.cmdGererLignes.Click += new System.EventHandler(this.cmdGererLignes_Click);
            // 
            // cmdGererArrêts
            // 
            this.cmdGererArrêts.BackColor = System.Drawing.Color.Lavender;
            this.cmdGererArrêts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGererArrêts.Location = new System.Drawing.Point(157, 72);
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
            this.cmdDeconnexionAdmin.Location = new System.Drawing.Point(36, 112);
            this.cmdDeconnexionAdmin.Name = "cmdDeconnexionAdmin";
            this.cmdDeconnexionAdmin.Size = new System.Drawing.Size(233, 36);
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
            this.pnlRecherche.Controls.Add(this.lblArriveeOuDepart);
            this.pnlRecherche.Controls.Add(this.cmdRechercher);
            this.pnlRecherche.Controls.Add(this.optDépart);
            this.pnlRecherche.Controls.Add(this.lblArrivee);
            this.pnlRecherche.Controls.Add(this.optArrivée);
            this.pnlRecherche.Controls.Add(this.lblDepart);
            this.pnlRecherche.Controls.Add(this.dtpDate);
            this.pnlRecherche.Controls.Add(this.nudHeure);
            this.pnlRecherche.Controls.Add(this.nudMinute);
            this.pnlRecherche.Controls.Add(this.lblH);
            this.pnlRecherche.Controls.Add(this.lblRecherche);
            this.pnlRecherche.Controls.Add(this.pbHeure);
            this.pnlRecherche.Location = new System.Drawing.Point(1, 2);
            this.pnlRecherche.Name = "pnlRecherche";
            this.pnlRecherche.Size = new System.Drawing.Size(307, 356);
            this.pnlRecherche.TabIndex = 27;
            // 
            // lblArriveeOuDepart
            // 
            this.lblArriveeOuDepart.AutoSize = true;
            this.lblArriveeOuDepart.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArriveeOuDepart.Location = new System.Drawing.Point(33, 244);
            this.lblArriveeOuDepart.Name = "lblArriveeOuDepart";
            this.lblArriveeOuDepart.Size = new System.Drawing.Size(239, 15);
            this.lblArriveeOuDepart.TabIndex = 22;
            this.lblArriveeOuDepart.Text = "Recherche pour un départ ou une arrivée ?";
            // 
            // optDépart
            // 
            this.optDépart.AutoSize = true;
            this.optDépart.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optDépart.Location = new System.Drawing.Point(48, 271);
            this.optDépart.Name = "optDépart";
            this.optDépart.Size = new System.Drawing.Size(101, 19);
            this.optDépart.TabIndex = 21;
            this.optDépart.TabStop = true;
            this.optDépart.Text = "Heure de départ";
            this.optDépart.UseVisualStyleBackColor = true;
            // 
            // optArrivée
            // 
            this.optArrivée.AutoSize = true;
            this.optArrivée.Font = new System.Drawing.Font("Perpetua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optArrivée.Location = new System.Drawing.Point(156, 271);
            this.optArrivée.Name = "optArrivée";
            this.optArrivée.Size = new System.Drawing.Size(96, 19);
            this.optArrivée.TabIndex = 20;
            this.optArrivée.TabStop = true;
            this.optArrivée.Text = "Heure d\'arrivée";
            this.optArrivée.UseVisualStyleBackColor = true;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Impact", 12F);
            this.lblH.Location = new System.Drawing.Point(157, 203);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(17, 20);
            this.lblH.TabIndex = 13;
            this.lblH.Text = "h";
            // 
            // pnlVisualisation
            // 
            this.pnlVisualisation.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlVisualisation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlVisualisation.Controls.Add(this.lblVisualisationDemande);
            this.pnlVisualisation.Controls.Add(this.cboVisualiserLigne);
            this.pnlVisualisation.Controls.Add(this.lblVisualisation);
            this.pnlVisualisation.Controls.Add(this.cmdVisualisation);
            this.pnlVisualisation.Location = new System.Drawing.Point(1, 357);
            this.pnlVisualisation.Name = "pnlVisualisation";
            this.pnlVisualisation.Size = new System.Drawing.Size(307, 185);
            this.pnlVisualisation.TabIndex = 28;
            // 
            // lblVisualisationDemande
            // 
            this.lblVisualisationDemande.AutoSize = true;
            this.lblVisualisationDemande.Location = new System.Drawing.Point(57, 67);
            this.lblVisualisationDemande.Name = "lblVisualisationDemande";
            this.lblVisualisationDemande.Size = new System.Drawing.Size(160, 13);
            this.lblVisualisationDemande.TabIndex = 22;
            this.lblVisualisationDemande.Text = "Sélectionner la ligne à visualiser.";
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
            this.pnlAdministrateur.Location = new System.Drawing.Point(1, 542);
            this.pnlAdministrateur.Name = "pnlAdministrateur";
            this.pnlAdministrateur.Size = new System.Drawing.Size(307, 206);
            this.pnlAdministrateur.TabIndex = 29;
            // 
            // lblResultatRecherche
            // 
            this.lblResultatRecherche.AutoSize = true;
            this.lblResultatRecherche.BackColor = System.Drawing.Color.AliceBlue;
            this.lblResultatRecherche.Font = new System.Drawing.Font("Perpetua", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultatRecherche.Location = new System.Drawing.Point(62, 15);
            this.lblResultatRecherche.Name = "lblResultatRecherche";
            this.lblResultatRecherche.Size = new System.Drawing.Size(200, 35);
            this.lblResultatRecherche.TabIndex = 1;
            this.lblResultatRecherche.Text = "Votre recherche";
            // 
            // pnlResultatRecherche
            // 
            this.pnlResultatRecherche.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlResultatRecherche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResultatRecherche.Controls.Add(this.lblAffichageResultatRecherche);
            this.pnlResultatRecherche.Controls.Add(this.lblResultatRecherche);
            this.pnlResultatRecherche.Location = new System.Drawing.Point(1041, 2);
            this.pnlResultatRecherche.Name = "pnlResultatRecherche";
            this.pnlResultatRecherche.Size = new System.Drawing.Size(327, 746);
            this.pnlResultatRecherche.TabIndex = 30;
            // 
            // pnlAffichage
            // 
            this.pnlAffichage.BackColor = System.Drawing.Color.Azure;
            this.pnlAffichage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAffichage.Controls.Add(this.pnlAfficherLigne);
            this.pnlAffichage.Location = new System.Drawing.Point(308, 2);
            this.pnlAffichage.Name = "pnlAffichage";
            this.pnlAffichage.Size = new System.Drawing.Size(734, 746);
            this.pnlAffichage.TabIndex = 31;
            this.pnlAffichage.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAffichage_Paint);
            // 
            // lblVisualiserLigne
            // 
            this.lblVisualiserLigne.AutoSize = true;
            this.lblVisualiserLigne.Font = new System.Drawing.Font("Perpetua", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisualiserLigne.Location = new System.Drawing.Point(18, 22);
            this.lblVisualiserLigne.Name = "lblVisualiserLigne";
            this.lblVisualiserLigne.Size = new System.Drawing.Size(276, 33);
            this.lblVisualiserLigne.TabIndex = 0;
            this.lblVisualiserLigne.Text = "Aucune ligne selectionné";
            // 
            // pnlAfficherLigne
            // 
            this.pnlAfficherLigne.AutoScroll = true;
            this.pnlAfficherLigne.Controls.Add(this.lblVisualiserLigne);
            this.pnlAfficherLigne.Location = new System.Drawing.Point(9, 10);
            this.pnlAfficherLigne.Name = "pnlAfficherLigne";
            this.pnlAfficherLigne.Size = new System.Drawing.Size(723, 731);
            this.pnlAfficherLigne.TabIndex = 0;
            // 
            // lblAffichageResultatRecherche
            // 
            this.lblAffichageResultatRecherche.AutoSize = true;
            this.lblAffichageResultatRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAffichageResultatRecherche.Location = new System.Drawing.Point(20, 61);
            this.lblAffichageResultatRecherche.Name = "lblAffichageResultatRecherche";
            this.lblAffichageResultatRecherche.Size = new System.Drawing.Size(143, 20);
            this.lblAffichageResultatRecherche.TabIndex = 2;
            this.lblAffichageResultatRecherche.Text = "Aucune recherche.";
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pbDate);
            this.Controls.Add(this.cboArrivee);
            this.Controls.Add(this.cboDepart);
            this.Controls.Add(this.pnlRecherche);
            this.Controls.Add(this.pnlVisualisation);
            this.Controls.Add(this.pnlAdministrateur);
            this.Controls.Add(this.pnlResultatRecherche);
            this.Controls.Add(this.pnlAffichage);
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
            this.pnlAfficherLigne.ResumeLayout(false);
            this.pnlAfficherLigne.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblArriveeOuDepart;
        private System.Windows.Forms.RadioButton optDépart;
        private System.Windows.Forms.RadioButton optArrivée;
        private System.Windows.Forms.Label lblVisualisationDemande;
        private System.Windows.Forms.Panel pnlAfficherLigne;
        private System.Windows.Forms.Label lblAffichageResultatRecherche;
    }
}

