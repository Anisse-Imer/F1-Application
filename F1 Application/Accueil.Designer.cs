
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
            this.lblRecherche = new System.Windows.Forms.Label();
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrivee = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboDepart = new System.Windows.Forms.ComboBox();
            this.cboArrivee = new System.Windows.Forms.ComboBox();
            this.lblH = new System.Windows.Forms.Label();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeure)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.BackColor = System.Drawing.Color.SlateGray;
            this.lblRecherche.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecherche.Location = new System.Drawing.Point(0, 25);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(292, 42);
            this.lblRecherche.TabIndex = 0;
            this.lblRecherche.Text = "Recherche de Trajet ";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.BackColor = System.Drawing.Color.SlateGray;
            this.lblDepart.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDepart.Location = new System.Drawing.Point(116, 95);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(75, 22);
            this.lblDepart.TabIndex = 1;
            this.lblDepart.Text = "Départ :";
            this.lblDepart.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblArrivee
            // 
            this.lblArrivee.AutoSize = true;
            this.lblArrivee.BackColor = System.Drawing.Color.SlateGray;
            this.lblArrivee.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArrivee.Location = new System.Drawing.Point(116, 152);
            this.lblArrivee.Name = "lblArrivee";
            this.lblArrivee.Size = new System.Drawing.Size(83, 22);
            this.lblArrivee.TabIndex = 2;
            this.lblArrivee.Text = "Arrivée :";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(152, 216);
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
            this.cboDepart.Location = new System.Drawing.Point(116, 120);
            this.cboDepart.Name = "cboDepart";
            this.cboDepart.Size = new System.Drawing.Size(212, 23);
            this.cboDepart.TabIndex = 7;
            // 
            // cboArrivee
            // 
            this.cboArrivee.FormattingEnabled = true;
            this.cboArrivee.Location = new System.Drawing.Point(116, 177);
            this.cboArrivee.Name = "cboArrivee";
            this.cboArrivee.Size = new System.Drawing.Size(212, 23);
            this.cboArrivee.TabIndex = 8;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblH.Location = new System.Drawing.Point(235, 255);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(17, 20);
            this.lblH.TabIndex = 13;
            this.lblH.Text = "h";
            // 
            // nudHeure
            // 
            this.nudHeure.Location = new System.Drawing.Point(193, 254);
            this.nudHeure.Name = "nudHeure";
            this.nudHeure.Size = new System.Drawing.Size(40, 23);
            this.nudHeure.TabIndex = 14;
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(253, 254);
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(40, 23);
            this.nudMinute.TabIndex = 15;
            // 
            // pbDate
            // 
            this.pbDate.BackColor = System.Drawing.Color.Olive;
            this.pbDate.Image = global::F1_Application.Properties.Resources.Calendrier_image1;
            this.pbDate.Location = new System.Drawing.Point(116, 216);
            this.pbDate.Name = "pbDate";
            this.pbDate.Size = new System.Drawing.Size(23, 23);
            this.pbDate.TabIndex = 16;
            this.pbDate.TabStop = false;
            // 
            // pbHeure
            // 
            this.pbHeure.BackColor = System.Drawing.Color.Olive;
            this.pbHeure.Image = global::F1_Application.Properties.Resources.horolge_image1;
            this.pbHeure.Location = new System.Drawing.Point(116, 252);
            this.pbHeure.Name = "pbHeure";
            this.pbHeure.Size = new System.Drawing.Size(23, 23);
            this.pbHeure.TabIndex = 17;
            this.pbHeure.TabStop = false;
            // 
            // cmdVisualisation
            // 
            this.cmdVisualisation.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdVisualisation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdVisualisation.Location = new System.Drawing.Point(116, 442);
            this.cmdVisualisation.Name = "cmdVisualisation";
            this.cmdVisualisation.Size = new System.Drawing.Size(212, 30);
            this.cmdVisualisation.TabIndex = 18;
            this.cmdVisualisation.Text = "Visualiser";
            this.cmdVisualisation.UseVisualStyleBackColor = false;
            // 
            // cmdRechercher
            // 
            this.cmdRechercher.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdRechercher.ForeColor = System.Drawing.Color.Black;
            this.cmdRechercher.Location = new System.Drawing.Point(116, 293);
            this.cmdRechercher.Name = "cmdRechercher";
            this.cmdRechercher.Size = new System.Drawing.Size(212, 30);
            this.cmdRechercher.TabIndex = 19;
            this.cmdRechercher.Text = "Rechercher";
            this.cmdRechercher.UseVisualStyleBackColor = false;
            // 
            // lblVisualisation
            // 
            this.lblVisualisation.AutoSize = true;
            this.lblVisualisation.BackColor = System.Drawing.Color.SlateGray;
            this.lblVisualisation.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVisualisation.Location = new System.Drawing.Point(56, 338);
            this.lblVisualisation.Name = "lblVisualisation";
            this.lblVisualisation.Size = new System.Drawing.Size(336, 42);
            this.lblVisualisation.TabIndex = 20;
            this.lblVisualisation.Text = "Visualisation des lignes";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(116, 395);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 23);
            this.comboBox1.TabIndex = 21;
            // 
            // cmdConnexionAdmin
            // 
            this.cmdConnexionAdmin.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdConnexionAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdConnexionAdmin.Location = new System.Drawing.Point(95, 539);
            this.cmdConnexionAdmin.Name = "cmdConnexionAdmin";
            this.cmdConnexionAdmin.Size = new System.Drawing.Size(272, 75);
            this.cmdConnexionAdmin.TabIndex = 22;
            this.cmdConnexionAdmin.Text = "Connexion Administrateur";
            this.cmdConnexionAdmin.UseVisualStyleBackColor = false;
            // 
            // lblAdministrateur
            // 
            this.lblAdministrateur.AutoSize = true;
            this.lblAdministrateur.BackColor = System.Drawing.Color.SlateGray;
            this.lblAdministrateur.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdministrateur.Location = new System.Drawing.Point(11, 1);
            this.lblAdministrateur.Name = "lblAdministrateur";
            this.lblAdministrateur.Size = new System.Drawing.Size(322, 45);
            this.lblAdministrateur.TabIndex = 23;
            this.lblAdministrateur.Text = "Accès Administrateur";
            this.lblAdministrateur.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmdGererLignes
            // 
            this.cmdGererLignes.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdGererLignes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGererLignes.Location = new System.Drawing.Point(115, 550);
            this.cmdGererLignes.Name = "cmdGererLignes";
            this.cmdGererLignes.Size = new System.Drawing.Size(106, 40);
            this.cmdGererLignes.TabIndex = 24;
            this.cmdGererLignes.Text = "Gérer lignes ";
            this.cmdGererLignes.UseVisualStyleBackColor = false;
            this.cmdGererLignes.Visible = false;
            // 
            // cmdGererArrêts
            // 
            this.cmdGererArrêts.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdGererArrêts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdGererArrêts.Location = new System.Drawing.Point(234, 550);
            this.cmdGererArrêts.Name = "cmdGererArrêts";
            this.cmdGererArrêts.Size = new System.Drawing.Size(106, 40);
            this.cmdGererArrêts.TabIndex = 25;
            this.cmdGererArrêts.Text = "Gérer arrêts";
            this.cmdGererArrêts.UseVisualStyleBackColor = false;
            this.cmdGererArrêts.Visible = false;
            // 
            // cmdDeconnexionAdmin
            // 
            this.cmdDeconnexionAdmin.BackColor = System.Drawing.Color.RoyalBlue;
            this.cmdDeconnexionAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDeconnexionAdmin.Location = new System.Drawing.Point(95, 596);
            this.cmdDeconnexionAdmin.Name = "cmdDeconnexionAdmin";
            this.cmdDeconnexionAdmin.Size = new System.Drawing.Size(272, 63);
            this.cmdDeconnexionAdmin.TabIndex = 26;
            this.cmdDeconnexionAdmin.Text = "Quitter le mode Administrateur";
            this.cmdDeconnexionAdmin.UseVisualStyleBackColor = false;
            this.cmdDeconnexionAdmin.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.lblRecherche);
            this.panel1.Location = new System.Drawing.Point(78, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 307);
            this.panel1.TabIndex = 27;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateGray;
            this.panel2.Location = new System.Drawing.Point(56, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 131);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SlateGray;
            this.panel3.Controls.Add(this.lblAdministrateur);
            this.panel3.Location = new System.Drawing.Point(56, 490);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 185);
            this.panel3.TabIndex = 29;
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 687);
            this.Controls.Add(this.cmdDeconnexionAdmin);
            this.Controls.Add(this.cmdGererArrêts);
            this.Controls.Add(this.cmdGererLignes);
            this.Controls.Add(this.cmdConnexionAdmin);
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
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.MinimumSize = new System.Drawing.Size(1364, 726);
            this.Name = "Accueil";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHeure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHeure)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Label lblH;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

