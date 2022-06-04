namespace F1_Application
{
    partial class frmModifierLigne
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
            this.lblModifierLigne = new System.Windows.Forms.Label();
            this.cmdConfirmerModifierLigne = new System.Windows.Forms.Button();
            this.cmdAnnulerModifierLigne = new System.Windows.Forms.Button();
            this.pnlNomNombreArrêt = new System.Windows.Forms.Panel();
            this.lblNbrArretSelectionner = new System.Windows.Forms.Label();
            this.lblNombreArrets = new System.Windows.Forms.Label();
            this.txtNomLigne = new System.Windows.Forms.TextBox();
            this.lblNomLigne = new System.Windows.Forms.Label();
            this.clstListeArrets = new System.Windows.Forms.CheckedListBox();
            this.lblArretsModifierLigne = new System.Windows.Forms.Label();
            this.lblRangArretsModifierLigne = new System.Windows.Forms.Label();
            this.flpRangDesArret = new System.Windows.Forms.FlowLayoutPanel();
            this.cboCouleur = new System.Windows.Forms.ComboBox();
            this.nudMinuteFinLigne = new System.Windows.Forms.NumericUpDown();
            this.nudHeureFinLigne = new System.Windows.Forms.NumericUpDown();
            this.nudMinuteDebutLigne = new System.Windows.Forms.NumericUpDown();
            this.nudHeureDebutLigne = new System.Windows.Forms.NumericUpDown();
            this.lblMinuteFinLigne = new System.Windows.Forms.Label();
            this.lblHeureFinLigne = new System.Windows.Forms.Label();
            this.lblFinLigne = new System.Windows.Forms.Label();
            this.lblMinuteDebutLigne = new System.Windows.Forms.Label();
            this.lblHeureDebutLigne = new System.Windows.Forms.Label();
            this.lblDebutLigne = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.pnlLigneActive = new System.Windows.Forms.Panel();
            this.pnlNomNombreArrêt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteFinLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureFinLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteDebutLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureDebutLigne)).BeginInit();
            this.pnlLigneActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModifierLigne
            // 
            this.lblModifierLigne.AutoSize = true;
            this.lblModifierLigne.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblModifierLigne.Location = new System.Drawing.Point(89, 23);
            this.lblModifierLigne.Name = "lblModifierLigne";
            this.lblModifierLigne.Size = new System.Drawing.Size(216, 31);
            this.lblModifierLigne.TabIndex = 0;
            this.lblModifierLigne.Text = "Modifier une ligne";
            this.lblModifierLigne.Click += new System.EventHandler(this.lblModifierLigne_Click);
            // 
            // cmdConfirmerModifierLigne
            // 
            this.cmdConfirmerModifierLigne.BackColor = System.Drawing.Color.Silver;
            this.cmdConfirmerModifierLigne.Location = new System.Drawing.Point(326, 421);
            this.cmdConfirmerModifierLigne.Name = "cmdConfirmerModifierLigne";
            this.cmdConfirmerModifierLigne.Size = new System.Drawing.Size(105, 29);
            this.cmdConfirmerModifierLigne.TabIndex = 1;
            this.cmdConfirmerModifierLigne.Text = "Confirmer";
            this.cmdConfirmerModifierLigne.UseVisualStyleBackColor = false;
            this.cmdConfirmerModifierLigne.Click += new System.EventHandler(this.cmdConfirmerModifierLigne_Click);
            // 
            // cmdAnnulerModifierLigne
            // 
            this.cmdAnnulerModifierLigne.BackColor = System.Drawing.Color.Silver;
            this.cmdAnnulerModifierLigne.Location = new System.Drawing.Point(11, 421);
            this.cmdAnnulerModifierLigne.Name = "cmdAnnulerModifierLigne";
            this.cmdAnnulerModifierLigne.Size = new System.Drawing.Size(105, 29);
            this.cmdAnnulerModifierLigne.TabIndex = 2;
            this.cmdAnnulerModifierLigne.Text = "Annuler";
            this.cmdAnnulerModifierLigne.UseVisualStyleBackColor = false;
            this.cmdAnnulerModifierLigne.Click += new System.EventHandler(this.cmdAnnulerModifierLigne_Click);
            // 
            // pnlNomNombreArrêt
            // 
            this.pnlNomNombreArrêt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlNomNombreArrêt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNomNombreArrêt.Controls.Add(this.lblCouleur);
            this.pnlNomNombreArrêt.Controls.Add(this.lblNbrArretSelectionner);
            this.pnlNomNombreArrêt.Controls.Add(this.lblNombreArrets);
            this.pnlNomNombreArrêt.Controls.Add(this.txtNomLigne);
            this.pnlNomNombreArrêt.Controls.Add(this.lblNomLigne);
            this.pnlNomNombreArrêt.Controls.Add(this.cboCouleur);
            this.pnlNomNombreArrêt.Location = new System.Drawing.Point(12, 64);
            this.pnlNomNombreArrêt.Name = "pnlNomNombreArrêt";
            this.pnlNomNombreArrêt.Size = new System.Drawing.Size(419, 51);
            this.pnlNomNombreArrêt.TabIndex = 3;
            // 
            // lblNbrArretSelectionner
            // 
            this.lblNbrArretSelectionner.AutoSize = true;
            this.lblNbrArretSelectionner.Location = new System.Drawing.Point(209, 29);
            this.lblNbrArretSelectionner.Name = "lblNbrArretSelectionner";
            this.lblNbrArretSelectionner.Size = new System.Drawing.Size(13, 13);
            this.lblNbrArretSelectionner.TabIndex = 7;
            this.lblNbrArretSelectionner.Text = "0";
            // 
            // lblNombreArrets
            // 
            this.lblNombreArrets.AutoSize = true;
            this.lblNombreArrets.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArrets.Location = new System.Drawing.Point(169, 6);
            this.lblNombreArrets.Name = "lblNombreArrets";
            this.lblNombreArrets.Size = new System.Drawing.Size(97, 15);
            this.lblNombreArrets.TabIndex = 6;
            this.lblNombreArrets.Text = "Nombre d\'arrêts :";
            // 
            // txtNomLigne
            // 
            this.txtNomLigne.Location = new System.Drawing.Point(18, 26);
            this.txtNomLigne.Name = "txtNomLigne";
            this.txtNomLigne.Size = new System.Drawing.Size(140, 20);
            this.txtNomLigne.TabIndex = 5;
            // 
            // lblNomLigne
            // 
            this.lblNomLigne.AutoSize = true;
            this.lblNomLigne.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomLigne.Location = new System.Drawing.Point(23, 6);
            this.lblNomLigne.Name = "lblNomLigne";
            this.lblNomLigne.Size = new System.Drawing.Size(95, 15);
            this.lblNomLigne.TabIndex = 4;
            this.lblNomLigne.Text = "Nom de la ligne :";
            this.lblNomLigne.Click += new System.EventHandler(this.lblNomLigne_Click);
            // 
            // clstListeArrets
            // 
            this.clstListeArrets.BackColor = System.Drawing.Color.Lavender;
            this.clstListeArrets.FormattingEnabled = true;
            this.clstListeArrets.Location = new System.Drawing.Point(12, 231);
            this.clstListeArrets.Name = "clstListeArrets";
            this.clstListeArrets.Size = new System.Drawing.Size(138, 184);
            this.clstListeArrets.TabIndex = 5;
            this.clstListeArrets.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clstListeArrets_ItemCheck);
            // 
            // lblArretsModifierLigne
            // 
            this.lblArretsModifierLigne.AutoSize = true;
            this.lblArretsModifierLigne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArretsModifierLigne.Location = new System.Drawing.Point(18, 209);
            this.lblArretsModifierLigne.Name = "lblArretsModifierLigne";
            this.lblArretsModifierLigne.Size = new System.Drawing.Size(142, 19);
            this.lblArretsModifierLigne.TabIndex = 6;
            this.lblArretsModifierLigne.Text = "Séletionnez les arrêts :";
            // 
            // lblRangArretsModifierLigne
            // 
            this.lblRangArretsModifierLigne.AutoSize = true;
            this.lblRangArretsModifierLigne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangArretsModifierLigne.Location = new System.Drawing.Point(181, 209);
            this.lblRangArretsModifierLigne.Name = "lblRangArretsModifierLigne";
            this.lblRangArretsModifierLigne.Size = new System.Drawing.Size(181, 19);
            this.lblRangArretsModifierLigne.TabIndex = 7;
            this.lblRangArretsModifierLigne.Text = "Rang des arrêts sur la ligne : ";
            // 
            // flpRangDesArret
            // 
            this.flpRangDesArret.AutoScroll = true;
            this.flpRangDesArret.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.flpRangDesArret.Location = new System.Drawing.Point(156, 231);
            this.flpRangDesArret.Name = "flpRangDesArret";
            this.flpRangDesArret.Size = new System.Drawing.Size(274, 184);
            this.flpRangDesArret.TabIndex = 9;
            // 
            // cboCouleur
            // 
            this.cboCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCouleur.FormattingEnabled = true;
            this.cboCouleur.Location = new System.Drawing.Point(274, 24);
            this.cboCouleur.Name = "cboCouleur";
            this.cboCouleur.Size = new System.Drawing.Size(132, 21);
            this.cboCouleur.TabIndex = 8;
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
            // lblDebutLigne
            // 
            this.lblDebutLigne.AutoSize = true;
            this.lblDebutLigne.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebutLigne.Location = new System.Drawing.Point(21, 4);
            this.lblDebutLigne.Name = "lblDebutLigne";
            this.lblDebutLigne.Size = new System.Drawing.Size(141, 19);
            this.lblDebutLigne.TabIndex = 27;
            this.lblDebutLigne.Text = "Ouverture de la ligne :";
            this.lblDebutLigne.Click += new System.EventHandler(this.lblDebutLigne_Click);
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleur.Location = new System.Drawing.Point(276, 6);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(106, 15);
            this.lblCouleur.TabIndex = 37;
            this.lblCouleur.Text = "Couleur de la ligne";
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
            this.pnlLigneActive.Location = new System.Drawing.Point(11, 130);
            this.pnlLigneActive.Name = "pnlLigneActive";
            this.pnlLigneActive.Size = new System.Drawing.Size(419, 68);
            this.pnlLigneActive.TabIndex = 37;
            // 
            // frmModifierLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(442, 462);
            this.Controls.Add(this.pnlLigneActive);
            this.Controls.Add(this.flpRangDesArret);
            this.Controls.Add(this.lblRangArretsModifierLigne);
            this.Controls.Add(this.lblArretsModifierLigne);
            this.Controls.Add(this.clstListeArrets);
            this.Controls.Add(this.pnlNomNombreArrêt);
            this.Controls.Add(this.cmdAnnulerModifierLigne);
            this.Controls.Add(this.cmdConfirmerModifierLigne);
            this.Controls.Add(this.lblModifierLigne);
            this.Name = "frmModifierLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le guide du petit arpenteur";
            this.Load += new System.EventHandler(this.frmModifierLigne_Load);
            this.pnlNomNombreArrêt.ResumeLayout(false);
            this.pnlNomNombreArrêt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteFinLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureFinLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteDebutLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureDebutLigne)).EndInit();
            this.pnlLigneActive.ResumeLayout(false);
            this.pnlLigneActive.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModifierLigne;
        private System.Windows.Forms.Button cmdConfirmerModifierLigne;
        private System.Windows.Forms.Button cmdAnnulerModifierLigne;
        private System.Windows.Forms.Panel pnlNomNombreArrêt;
        private System.Windows.Forms.Label lblNombreArrets;
        private System.Windows.Forms.TextBox txtNomLigne;
        private System.Windows.Forms.Label lblNomLigne;
        private System.Windows.Forms.CheckedListBox clstListeArrets;
        private System.Windows.Forms.Label lblArretsModifierLigne;
        private System.Windows.Forms.Label lblRangArretsModifierLigne;
        private System.Windows.Forms.Label lblNbrArretSelectionner;
        private System.Windows.Forms.FlowLayoutPanel flpRangDesArret;
        private System.Windows.Forms.ComboBox cboCouleur;
        private System.Windows.Forms.NumericUpDown nudMinuteFinLigne;
        private System.Windows.Forms.NumericUpDown nudHeureFinLigne;
        private System.Windows.Forms.NumericUpDown nudMinuteDebutLigne;
        private System.Windows.Forms.NumericUpDown nudHeureDebutLigne;
        private System.Windows.Forms.Label lblMinuteFinLigne;
        private System.Windows.Forms.Label lblHeureFinLigne;
        private System.Windows.Forms.Label lblFinLigne;
        private System.Windows.Forms.Label lblMinuteDebutLigne;
        private System.Windows.Forms.Label lblHeureDebutLigne;
        private System.Windows.Forms.Label lblDebutLigne;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Panel pnlLigneActive;
    }
}