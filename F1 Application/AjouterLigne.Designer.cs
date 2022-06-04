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
            this.lblDebutLigne = new System.Windows.Forms.Label();
            this.lblHeureDebutLigne = new System.Windows.Forms.Label();
            this.lblMinuteDebutLigne = new System.Windows.Forms.Label();
            this.lblFinLigne = new System.Windows.Forms.Label();
            this.lblHeureFinLigne = new System.Windows.Forms.Label();
            this.lblMinuteFinLigne = new System.Windows.Forms.Label();
            this.nudHeureDebutLigne = new System.Windows.Forms.NumericUpDown();
            this.nudMinuteDebutLigne = new System.Windows.Forms.NumericUpDown();
            this.nudHeureFinLigne = new System.Windows.Forms.NumericUpDown();
            this.nudMinuteFinLigne = new System.Windows.Forms.NumericUpDown();
            this.pnlNomNombreArrets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureDebutLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteDebutLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureFinLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteFinLigne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRangArretsAjouterLigne
            // 
            this.lblRangArretsAjouterLigne.AutoSize = true;
            this.lblRangArretsAjouterLigne.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangArretsAjouterLigne.Location = new System.Drawing.Point(234, 137);
            this.lblRangArretsAjouterLigne.Name = "lblRangArretsAjouterLigne";
            this.lblRangArretsAjouterLigne.Size = new System.Drawing.Size(85, 14);
            this.lblRangArretsAjouterLigne.TabIndex = 13;
            this.lblRangArretsAjouterLigne.Text = "Rang des arrêts : ";
            // 
            // lblArretsAjouterLigne
            // 
            this.lblArretsAjouterLigne.AutoSize = true;
            this.lblArretsAjouterLigne.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArretsAjouterLigne.Location = new System.Drawing.Point(62, 137);
            this.lblArretsAjouterLigne.Name = "lblArretsAjouterLigne";
            this.lblArretsAjouterLigne.Size = new System.Drawing.Size(94, 14);
            this.lblArretsAjouterLigne.TabIndex = 12;
            this.lblArretsAjouterLigne.Text = "Arrêts sur la ligne :";
            // 
            // clstListeArrets
            // 
            this.clstListeArrets.FormattingEnabled = true;
            this.clstListeArrets.Location = new System.Drawing.Point(65, 154);
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
            this.pnlNomNombreArrets.Location = new System.Drawing.Point(67, 67);
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
            this.lblCouleur.Location = new System.Drawing.Point(287, 11);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(91, 14);
            this.lblCouleur.TabIndex = 18;
            this.lblCouleur.Text = "Couleur de la ligne";
            // 
            // lblNbrArretSelectionne
            // 
            this.lblNbrArretSelectionne.AutoSize = true;
            this.lblNbrArretSelectionne.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblNbrArretSelectionne.Location = new System.Drawing.Point(213, 30);
            this.lblNbrArretSelectionne.Name = "lblNbrArretSelectionne";
            this.lblNbrArretSelectionne.Size = new System.Drawing.Size(15, 16);
            this.lblNbrArretSelectionne.TabIndex = 7;
            this.lblNbrArretSelectionne.Text = "0";
            // 
            // lblNombreArrets
            // 
            this.lblNombreArrets.AutoSize = true;
            this.lblNombreArrets.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArrets.Location = new System.Drawing.Point(181, 11);
            this.lblNombreArrets.Name = "lblNombreArrets";
            this.lblNombreArrets.Size = new System.Drawing.Size(86, 14);
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
            this.lblNomLigne.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomLigne.Location = new System.Drawing.Point(30, 11);
            this.lblNomLigne.Name = "lblNomLigne";
            this.lblNomLigne.Size = new System.Drawing.Size(85, 14);
            this.lblNomLigne.TabIndex = 4;
            this.lblNomLigne.Text = "Nom de la ligne :";
            // 
            // lblAjouterLigne
            // 
            this.lblAjouterLigne.AutoSize = true;
            this.lblAjouterLigne.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblAjouterLigne.Location = new System.Drawing.Point(153, 23);
            this.lblAjouterLigne.Name = "lblAjouterLigne";
            this.lblAjouterLigne.Size = new System.Drawing.Size(217, 31);
            this.lblAjouterLigne.TabIndex = 8;
            this.lblAjouterLigne.Text = "Ajouter une ligne :";
            // 
            // cmdAnnulerAjouterLigne
            // 
            this.cmdAnnulerAjouterLigne.BackColor = System.Drawing.Color.Silver;
            this.cmdAnnulerAjouterLigne.Location = new System.Drawing.Point(10, 388);
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
            this.cmdConfirmerAjouterLigne.Location = new System.Drawing.Point(441, 388);
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
            this.flpRangArret.BackColor = System.Drawing.Color.Green;
            this.flpRangArret.Location = new System.Drawing.Point(237, 154);
            this.flpRangArret.Name = "flpRangArret";
            this.flpRangArret.Size = new System.Drawing.Size(248, 199);
            this.flpRangArret.TabIndex = 16;
            // 
            // lblDebutLigne
            // 
            this.lblDebutLigne.AutoSize = true;
            this.lblDebutLigne.Location = new System.Drawing.Point(547, 94);
            this.lblDebutLigne.Name = "lblDebutLigne";
            this.lblDebutLigne.Size = new System.Drawing.Size(89, 14);
            this.lblDebutLigne.TabIndex = 17;
            this.lblDebutLigne.Text = "Début de la ligne :";
            // 
            // lblHeureDebutLigne
            // 
            this.lblHeureDebutLigne.AutoSize = true;
            this.lblHeureDebutLigne.Location = new System.Drawing.Point(547, 108);
            this.lblHeureDebutLigne.Name = "lblHeureDebutLigne";
            this.lblHeureDebutLigne.Size = new System.Drawing.Size(34, 14);
            this.lblHeureDebutLigne.TabIndex = 18;
            this.lblHeureDebutLigne.Text = "Heure";
            // 
            // lblMinuteDebutLigne
            // 
            this.lblMinuteDebutLigne.AutoSize = true;
            this.lblMinuteDebutLigne.Location = new System.Drawing.Point(626, 109);
            this.lblMinuteDebutLigne.Name = "lblMinuteDebutLigne";
            this.lblMinuteDebutLigne.Size = new System.Drawing.Size(40, 14);
            this.lblMinuteDebutLigne.TabIndex = 19;
            this.lblMinuteDebutLigne.Text = "Minute";
            // 
            // lblFinLigne
            // 
            this.lblFinLigne.AutoSize = true;
            this.lblFinLigne.Location = new System.Drawing.Point(547, 188);
            this.lblFinLigne.Name = "lblFinLigne";
            this.lblFinLigne.Size = new System.Drawing.Size(77, 14);
            this.lblFinLigne.TabIndex = 20;
            this.lblFinLigne.Text = "Fin de la ligne :";
            // 
            // lblHeureFinLigne
            // 
            this.lblHeureFinLigne.AutoSize = true;
            this.lblHeureFinLigne.Location = new System.Drawing.Point(547, 202);
            this.lblHeureFinLigne.Name = "lblHeureFinLigne";
            this.lblHeureFinLigne.Size = new System.Drawing.Size(34, 14);
            this.lblHeureFinLigne.TabIndex = 21;
            this.lblHeureFinLigne.Text = "Heure";
            // 
            // lblMinuteFinLigne
            // 
            this.lblMinuteFinLigne.AutoSize = true;
            this.lblMinuteFinLigne.Location = new System.Drawing.Point(626, 202);
            this.lblMinuteFinLigne.Name = "lblMinuteFinLigne";
            this.lblMinuteFinLigne.Size = new System.Drawing.Size(40, 14);
            this.lblMinuteFinLigne.TabIndex = 22;
            this.lblMinuteFinLigne.Text = "Minute";
            // 
            // nudHeureDebutLigne
            // 
            this.nudHeureDebutLigne.Location = new System.Drawing.Point(552, 126);
            this.nudHeureDebutLigne.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHeureDebutLigne.Name = "nudHeureDebutLigne";
            this.nudHeureDebutLigne.Size = new System.Drawing.Size(39, 20);
            this.nudHeureDebutLigne.TabIndex = 23;
            // 
            // nudMinuteDebutLigne
            // 
            this.nudMinuteDebutLigne.Location = new System.Drawing.Point(629, 126);
            this.nudMinuteDebutLigne.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinuteDebutLigne.Name = "nudMinuteDebutLigne";
            this.nudMinuteDebutLigne.Size = new System.Drawing.Size(37, 20);
            this.nudMinuteDebutLigne.TabIndex = 24;
            // 
            // nudHeureFinLigne
            // 
            this.nudHeureFinLigne.Location = new System.Drawing.Point(550, 226);
            this.nudHeureFinLigne.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHeureFinLigne.Name = "nudHeureFinLigne";
            this.nudHeureFinLigne.Size = new System.Drawing.Size(40, 20);
            this.nudHeureFinLigne.TabIndex = 25;
            // 
            // nudMinuteFinLigne
            // 
            this.nudMinuteFinLigne.Location = new System.Drawing.Point(630, 226);
            this.nudMinuteFinLigne.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinuteFinLigne.Name = "nudMinuteFinLigne";
            this.nudMinuteFinLigne.Size = new System.Drawing.Size(36, 20);
            this.nudMinuteFinLigne.TabIndex = 26;
            // 
            // frmAjouterLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 431);
            this.Controls.Add(this.nudMinuteFinLigne);
            this.Controls.Add(this.nudHeureFinLigne);
            this.Controls.Add(this.nudMinuteDebutLigne);
            this.Controls.Add(this.nudHeureDebutLigne);
            this.Controls.Add(this.lblMinuteFinLigne);
            this.Controls.Add(this.lblHeureFinLigne);
            this.Controls.Add(this.lblFinLigne);
            this.Controls.Add(this.lblMinuteDebutLigne);
            this.Controls.Add(this.lblHeureDebutLigne);
            this.Controls.Add(this.lblDebutLigne);
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
            this.Text = "AjouterLigne";
            this.Load += new System.EventHandler(this.frmAjouterLigne_Load);
            this.pnlNomNombreArrets.ResumeLayout(false);
            this.pnlNomNombreArrets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureDebutLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteDebutLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureFinLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteFinLigne)).EndInit();
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
        private System.Windows.Forms.Label lblDebutLigne;
        private System.Windows.Forms.Label lblHeureDebutLigne;
        private System.Windows.Forms.Label lblMinuteDebutLigne;
        private System.Windows.Forms.Label lblFinLigne;
        private System.Windows.Forms.Label lblHeureFinLigne;
        private System.Windows.Forms.Label lblMinuteFinLigne;
        private System.Windows.Forms.NumericUpDown nudHeureDebutLigne;
        private System.Windows.Forms.NumericUpDown nudMinuteDebutLigne;
        private System.Windows.Forms.NumericUpDown nudHeureFinLigne;
        private System.Windows.Forms.NumericUpDown nudMinuteFinLigne;
    }
}