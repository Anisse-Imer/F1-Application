namespace F1_Application
{
    partial class frmAjouterLigne
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRangArretsAjouterLigne = new System.Windows.Forms.Label();
            this.lblArretsAjouterLigne = new System.Windows.Forms.Label();
            this.clstListeArrets = new System.Windows.Forms.CheckedListBox();
            this.pnlNomNombreArrets = new System.Windows.Forms.Panel();
            this.cboCouleur = new System.Windows.Forms.ComboBox();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblNbrArretSelectionne = new System.Windows.Forms.Label();
            this.lblNombreArrets = new System.Windows.Forms.Label();
            this.txtNomLigne = new System.Windows.Forms.TextBox();
            this.lblNomLigne = new System.Windows.Forms.Label();
            this.lblAjouterLigne = new System.Windows.Forms.Label();
            this.cmdAnnulerAjouterLigne = new System.Windows.Forms.Button();
            this.cmdConfirmerAjouterLigne = new System.Windows.Forms.Button();
            this.flpRangArret = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlLigneActive = new System.Windows.Forms.Panel();
            this.nudMinuteFinLigne = new System.Windows.Forms.NumericUpDown();
            this.lblDebutLigne = new System.Windows.Forms.Label();
            this.nudHeureFinLigne = new System.Windows.Forms.NumericUpDown();
            this.lblHeureDebutLigne = new System.Windows.Forms.Label();
            this.nudMinuteDebutLigne = new System.Windows.Forms.NumericUpDown();
            this.lblMinuteDebutLigne = new System.Windows.Forms.Label();
            this.nudHeureDebutLigne = new System.Windows.Forms.NumericUpDown();
            this.lblFinLigne = new System.Windows.Forms.Label();
            this.lblMinuteFinLigne = new System.Windows.Forms.Label();
            this.lblHeureFinLigne = new System.Windows.Forms.Label();
            this.pnlNomNombreArrets.SuspendLayout();
            this.pnlLigneActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteFinLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureFinLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteDebutLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureDebutLigne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRangArretsAjouterLigne
            // 
            this.lblRangArretsAjouterLigne.AutoSize = true;
            this.lblRangArretsAjouterLigne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangArretsAjouterLigne.Location = new System.Drawing.Point(194, 190);
            this.lblRangArretsAjouterLigne.Name = "lblRangArretsAjouterLigne";
            this.lblRangArretsAjouterLigne.Size = new System.Drawing.Size(181, 19);
            this.lblRangArretsAjouterLigne.TabIndex = 13;
            this.lblRangArretsAjouterLigne.Text = "Rang des arrêts sur la ligne : ";
            // 
            // lblArretsAjouterLigne
            // 
            this.lblArretsAjouterLigne.AutoSize = true;
            this.lblArretsAjouterLigne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArretsAjouterLigne.Location = new System.Drawing.Point(13, 190);
            this.lblArretsAjouterLigne.Name = "lblArretsAjouterLigne";
            this.lblArretsAjouterLigne.Size = new System.Drawing.Size(149, 19);
            this.lblArretsAjouterLigne.TabIndex = 12;
            this.lblArretsAjouterLigne.Text = "Sélectionnez les arrêts :";
            // 
            // clstListeArrets
            // 
            this.clstListeArrets.BackColor = System.Drawing.Color.Lavender;
            this.clstListeArrets.FormattingEnabled = true;
            this.clstListeArrets.Location = new System.Drawing.Point(11, 212);
            this.clstListeArrets.Name = "clstListeArrets";
            this.clstListeArrets.Size = new System.Drawing.Size(161, 199);
            this.clstListeArrets.TabIndex = 11;
            this.clstListeArrets.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clstListeArrets_ItemCheck);
            // 
            // pnlNomNombreArrets
            // 
            this.pnlNomNombreArrets.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlNomNombreArrets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNomNombreArrets.Controls.Add(this.cboCouleur);
            this.pnlNomNombreArrets.Controls.Add(this.lblCouleur);
            this.pnlNomNombreArrets.Controls.Add(this.lblNbrArretSelectionne);
            this.pnlNomNombreArrets.Controls.Add(this.lblNombreArrets);
            this.pnlNomNombreArrets.Controls.Add(this.txtNomLigne);
            this.pnlNomNombreArrets.Controls.Add(this.lblNomLigne);
            this.pnlNomNombreArrets.Location = new System.Drawing.Point(12, 53);
            this.pnlNomNombreArrets.Name = "pnlNomNombreArrets";
            this.pnlNomNombreArrets.Size = new System.Drawing.Size(418, 55);
            this.pnlNomNombreArrets.TabIndex = 9;
            // 
            // cboCouleur
            // 
            this.cboCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCouleur.FormattingEnabled = true;
            this.cboCouleur.Location = new System.Drawing.Point(273, 28);
            this.cboCouleur.Name = "cboCouleur";
            this.cboCouleur.Size = new System.Drawing.Size(140, 22);
            this.cboCouleur.TabIndex = 17;
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleur.Location = new System.Drawing.Point(276, 10);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(106, 15);
            this.lblCouleur.TabIndex = 18;
            this.lblCouleur.Text = "Couleur de la ligne";
            // 
            // lblNbrArretSelectionne
            // 
            this.lblNbrArretSelectionne.AutoSize = true;
            this.lblNbrArretSelectionne.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblNbrArretSelectionne.Location = new System.Drawing.Point(213, 30);
            this.lblNbrArretSelectionne.Name = "lblNbrArretSelectionne";
            this.lblNbrArretSelectionne.Size = new System.Drawing.Size(14, 16);
            this.lblNbrArretSelectionne.TabIndex = 7;
            this.lblNbrArretSelectionne.Text = "0";
            // 
            // lblNombreArrets
            // 
            this.lblNombreArrets.AutoSize = true;
            this.lblNombreArrets.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArrets.Location = new System.Drawing.Point(170, 10);
            this.lblNombreArrets.Name = "lblNombreArrets";
            this.lblNombreArrets.Size = new System.Drawing.Size(97, 15);
            this.lblNombreArrets.TabIndex = 6;
            this.lblNombreArrets.Text = "Nombre d\'arrêts :";
            // 
            // txtNomLigne
            // 
            this.txtNomLigne.Location = new System.Drawing.Point(18, 28);
            this.txtNomLigne.Name = "txtNomLigne";
            this.txtNomLigne.Size = new System.Drawing.Size(140, 20);
            this.txtNomLigne.TabIndex = 5;
            // 
            // lblNomLigne
            // 
            this.lblNomLigne.AutoSize = true;
            this.lblNomLigne.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomLigne.Location = new System.Drawing.Point(19, 10);
            this.lblNomLigne.Name = "lblNomLigne";
            this.lblNomLigne.Size = new System.Drawing.Size(95, 15);
            this.lblNomLigne.TabIndex = 4;
            this.lblNomLigne.Text = "Nom de la ligne :";
            // 
            // lblAjouterLigne
            // 
            this.lblAjouterLigne.AutoSize = true;
            this.lblAjouterLigne.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblAjouterLigne.Location = new System.Drawing.Point(98, 9);
            this.lblAjouterLigne.Name = "lblAjouterLigne";
            this.lblAjouterLigne.Size = new System.Drawing.Size(217, 31);
            this.lblAjouterLigne.TabIndex = 8;
            this.lblAjouterLigne.Text = "Ajouter une ligne :";
            // 
            // cmdAnnulerAjouterLigne
            // 
            this.cmdAnnulerAjouterLigne.BackColor = System.Drawing.Color.Silver;
            this.cmdAnnulerAjouterLigne.Location = new System.Drawing.Point(11, 417);
            this.cmdAnnulerAjouterLigne.Name = "cmdAnnulerAjouterLigne";
            this.cmdAnnulerAjouterLigne.Size = new System.Drawing.Size(105, 31);
            this.cmdAnnulerAjouterLigne.TabIndex = 15;
            this.cmdAnnulerAjouterLigne.Text = "Annuler";
            this.cmdAnnulerAjouterLigne.UseVisualStyleBackColor = false;
            this.cmdAnnulerAjouterLigne.Click += new System.EventHandler(this.cmdAnnulerAjouterLigne_Click);
            // 
            // cmdConfirmerAjouterLigne
            // 
            this.cmdConfirmerAjouterLigne.BackColor = System.Drawing.Color.Silver;
            this.cmdConfirmerAjouterLigne.Location = new System.Drawing.Point(326, 417);
            this.cmdConfirmerAjouterLigne.Name = "cmdConfirmerAjouterLigne";
            this.cmdConfirmerAjouterLigne.Size = new System.Drawing.Size(105, 31);
            this.cmdConfirmerAjouterLigne.TabIndex = 14;
            this.cmdConfirmerAjouterLigne.Text = "Confirmer";
            this.cmdConfirmerAjouterLigne.UseVisualStyleBackColor = false;
            this.cmdConfirmerAjouterLigne.Click += new System.EventHandler(this.cmdConfirmerAjouterLigne_Click);
            // 
            // flpRangArret
            // 
            this.flpRangArret.AutoScroll = true;
            this.flpRangArret.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.flpRangArret.Location = new System.Drawing.Point(183, 212);
            this.flpRangArret.Name = "flpRangArret";
            this.flpRangArret.Size = new System.Drawing.Size(248, 199);
            this.flpRangArret.TabIndex = 16;
            // 
            // pnlLigneActive
            // 
            this.pnlLigneActive.BackColor = System.Drawing.Color.LavenderBlush;
            this.pnlLigneActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLigneActive.Controls.Add(this.nudMinuteFinLigne);
            this.pnlLigneActive.Controls.Add(this.lblDebutLigne);
            this.pnlLigneActive.Controls.Add(this.nudHeureFinLigne);
            this.pnlLigneActive.Controls.Add(this.lblHeureDebutLigne);
            this.pnlLigneActive.Controls.Add(this.nudMinuteDebutLigne);
            this.pnlLigneActive.Controls.Add(this.lblMinuteDebutLigne);
            this.pnlLigneActive.Controls.Add(this.nudHeureDebutLigne);
            this.pnlLigneActive.Controls.Add(this.lblFinLigne);
            this.pnlLigneActive.Controls.Add(this.lblMinuteFinLigne);
            this.pnlLigneActive.Controls.Add(this.lblHeureFinLigne);
            this.pnlLigneActive.Location = new System.Drawing.Point(12, 114);
            this.pnlLigneActive.Name = "pnlLigneActive";
            this.pnlLigneActive.Size = new System.Drawing.Size(419, 68);
            this.pnlLigneActive.TabIndex = 38;
            // 
            // nudMinuteFinLigne
            // 
            this.nudMinuteFinLigne.Location = new System.Drawing.Point(349, 43);
            this.nudMinuteFinLigne.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinuteFinLigne.Name = "nudMinuteFinLigne";
            this.nudMinuteFinLigne.Size = new System.Drawing.Size(36, 20);
            this.nudMinuteFinLigne.TabIndex = 36;
            // 
            // lblDebutLigne
            // 
            this.lblDebutLigne.AutoSize = true;
            this.lblDebutLigne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebutLigne.Location = new System.Drawing.Point(21, 4);
            this.lblDebutLigne.Name = "lblDebutLigne";
            this.lblDebutLigne.Size = new System.Drawing.Size(141, 19);
            this.lblDebutLigne.TabIndex = 27;
            this.lblDebutLigne.Text = "Ouverture de la ligne :";
            // 
            // nudHeureFinLigne
            // 
            this.nudHeureFinLigne.Location = new System.Drawing.Point(269, 43);
            this.nudHeureFinLigne.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHeureFinLigne.Name = "nudHeureFinLigne";
            this.nudHeureFinLigne.Size = new System.Drawing.Size(40, 20);
            this.nudHeureFinLigne.TabIndex = 35;
            // 
            // lblHeureDebutLigne
            // 
            this.lblHeureDebutLigne.AutoSize = true;
            this.lblHeureDebutLigne.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeureDebutLigne.Location = new System.Drawing.Point(29, 25);
            this.lblHeureDebutLigne.Name = "lblHeureDebutLigne";
            this.lblHeureDebutLigne.Size = new System.Drawing.Size(40, 15);
            this.lblHeureDebutLigne.TabIndex = 28;
            this.lblHeureDebutLigne.Text = "Heure";
            // 
            // nudMinuteDebutLigne
            // 
            this.nudMinuteDebutLigne.Location = new System.Drawing.Point(111, 43);
            this.nudMinuteDebutLigne.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinuteDebutLigne.Name = "nudMinuteDebutLigne";
            this.nudMinuteDebutLigne.Size = new System.Drawing.Size(37, 20);
            this.nudMinuteDebutLigne.TabIndex = 34;
            // 
            // lblMinuteDebutLigne
            // 
            this.lblMinuteDebutLigne.AutoSize = true;
            this.lblMinuteDebutLigne.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuteDebutLigne.Location = new System.Drawing.Point(108, 26);
            this.lblMinuteDebutLigne.Name = "lblMinuteDebutLigne";
            this.lblMinuteDebutLigne.Size = new System.Drawing.Size(46, 15);
            this.lblMinuteDebutLigne.TabIndex = 29;
            this.lblMinuteDebutLigne.Text = "Minute";
            // 
            // nudHeureDebutLigne
            // 
            this.nudHeureDebutLigne.Location = new System.Drawing.Point(34, 43);
            this.nudHeureDebutLigne.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHeureDebutLigne.Name = "nudHeureDebutLigne";
            this.nudHeureDebutLigne.Size = new System.Drawing.Size(39, 20);
            this.nudHeureDebutLigne.TabIndex = 33;
            // 
            // lblFinLigne
            // 
            this.lblFinLigne.AutoSize = true;
            this.lblFinLigne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinLigne.Location = new System.Drawing.Point(255, 5);
            this.lblFinLigne.Name = "lblFinLigne";
            this.lblFinLigne.Size = new System.Drawing.Size(142, 19);
            this.lblFinLigne.TabIndex = 30;
            this.lblFinLigne.Text = "Fermeture de la ligne :";
            // 
            // lblMinuteFinLigne
            // 
            this.lblMinuteFinLigne.AutoSize = true;
            this.lblMinuteFinLigne.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinuteFinLigne.Location = new System.Drawing.Point(345, 26);
            this.lblMinuteFinLigne.Name = "lblMinuteFinLigne";
            this.lblMinuteFinLigne.Size = new System.Drawing.Size(46, 15);
            this.lblMinuteFinLigne.TabIndex = 32;
            this.lblMinuteFinLigne.Text = "Minute";
            // 
            // lblHeureFinLigne
            // 
            this.lblHeureFinLigne.AutoSize = true;
            this.lblHeureFinLigne.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeureFinLigne.Location = new System.Drawing.Point(266, 26);
            this.lblHeureFinLigne.Name = "lblHeureFinLigne";
            this.lblHeureFinLigne.Size = new System.Drawing.Size(40, 15);
            this.lblHeureFinLigne.TabIndex = 31;
            this.lblHeureFinLigne.Text = "Heure";
            // 
            // frmAjouterLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 456);
            this.Controls.Add(this.pnlLigneActive);
            this.Controls.Add(this.flpRangArret);
            this.Controls.Add(this.cmdAnnulerAjouterLigne);
            this.Controls.Add(this.cmdConfirmerAjouterLigne);
            this.Controls.Add(this.lblRangArretsAjouterLigne);
            this.Controls.Add(this.lblArretsAjouterLigne);
            this.Controls.Add(this.clstListeArrets);
            this.Controls.Add(this.pnlNomNombreArrets);
            this.Controls.Add(this.lblAjouterLigne);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Name = "frmAjouterLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le guide du petit arpenteur";
            this.Load += new System.EventHandler(this.frmAjouterLigne_Load);
            this.pnlNomNombreArrets.ResumeLayout(false);
            this.pnlNomNombreArrets.PerformLayout();
            this.pnlLigneActive.ResumeLayout(false);
            this.pnlLigneActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteFinLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureFinLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteDebutLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureDebutLigne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRangArretsAjouterLigne;
        private System.Windows.Forms.Label lblArretsAjouterLigne;
        private System.Windows.Forms.CheckedListBox clstListeArrets;
        private System.Windows.Forms.Panel pnlNomNombreArrets;
        private System.Windows.Forms.Label lblNombreArrets;
        private System.Windows.Forms.TextBox txtNomLigne;
        private System.Windows.Forms.Label lblNomLigne;
        private System.Windows.Forms.Label lblAjouterLigne;
        private System.Windows.Forms.Button cmdAnnulerAjouterLigne;
        private System.Windows.Forms.Button cmdConfirmerAjouterLigne;
        private System.Windows.Forms.Label lblNbrArretSelectionne;
        private System.Windows.Forms.FlowLayoutPanel flpRangArret;
        private System.Windows.Forms.ComboBox cboCouleur;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Panel pnlLigneActive;
        private System.Windows.Forms.NumericUpDown nudMinuteFinLigne;
        private System.Windows.Forms.Label lblDebutLigne;
        private System.Windows.Forms.NumericUpDown nudHeureFinLigne;
        private System.Windows.Forms.Label lblHeureDebutLigne;
        private System.Windows.Forms.NumericUpDown nudMinuteDebutLigne;
        private System.Windows.Forms.Label lblMinuteDebutLigne;
        private System.Windows.Forms.NumericUpDown nudHeureDebutLigne;
        private System.Windows.Forms.Label lblFinLigne;
        private System.Windows.Forms.Label lblMinuteFinLigne;
        private System.Windows.Forms.Label lblHeureFinLigne;
    }
}