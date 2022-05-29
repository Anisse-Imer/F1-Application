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
            this.lblNbrArretSelectionne = new System.Windows.Forms.Label();
            this.lblNombreArrets = new System.Windows.Forms.Label();
            this.txtNomLigne = new System.Windows.Forms.TextBox();
            this.lblNomLigne = new System.Windows.Forms.Label();
            this.lblAjouterLigne = new System.Windows.Forms.Label();
            this.cmdAnnulerAjouterLigne = new System.Windows.Forms.Button();
            this.cmdConfirmerAjouterLigne = new System.Windows.Forms.Button();
            this.flpRangArret = new System.Windows.Forms.FlowLayoutPanel();
            this.cboCouleur = new System.Windows.Forms.ComboBox();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.pnlNomNombreArrets.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRangArretsAjouterLigne
            // 
            this.lblRangArretsAjouterLigne.AutoSize = true;
            this.lblRangArretsAjouterLigne.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangArretsAjouterLigne.Location = new System.Drawing.Point(264, 132);
            this.lblRangArretsAjouterLigne.Name = "lblRangArretsAjouterLigne";
            this.lblRangArretsAjouterLigne.Size = new System.Drawing.Size(85, 14);
            this.lblRangArretsAjouterLigne.TabIndex = 13;
            this.lblRangArretsAjouterLigne.Text = "Rang des arrêts : ";
            // 
            // lblArretsAjouterLigne
            // 
            this.lblArretsAjouterLigne.AutoSize = true;
            this.lblArretsAjouterLigne.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArretsAjouterLigne.Location = new System.Drawing.Point(97, 132);
            this.lblArretsAjouterLigne.Name = "lblArretsAjouterLigne";
            this.lblArretsAjouterLigne.Size = new System.Drawing.Size(94, 14);
            this.lblArretsAjouterLigne.TabIndex = 12;
            this.lblArretsAjouterLigne.Text = "Arrêts sur la ligne :";
            // 
            // clstListeArrets
            // 
            this.clstListeArrets.FormattingEnabled = true;
            this.clstListeArrets.Location = new System.Drawing.Point(95, 150);
            this.clstListeArrets.Name = "clstListeArrets";
            this.clstListeArrets.Size = new System.Drawing.Size(161, 199);
            this.clstListeArrets.TabIndex = 11;
            this.clstListeArrets.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clstListeArrets_ItemCheck);
            // 
            // pnlNomNombreArrets
            // 
            this.pnlNomNombreArrets.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlNomNombreArrets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNomNombreArrets.Controls.Add(this.lblNbrArretSelectionne);
            this.pnlNomNombreArrets.Controls.Add(this.lblNombreArrets);
            this.pnlNomNombreArrets.Controls.Add(this.txtNomLigne);
            this.pnlNomNombreArrets.Controls.Add(this.lblNomLigne);
            this.pnlNomNombreArrets.Location = new System.Drawing.Point(97, 62);
            this.pnlNomNombreArrets.Name = "pnlNomNombreArrets";
            this.pnlNomNombreArrets.Size = new System.Drawing.Size(361, 55);
            this.pnlNomNombreArrets.TabIndex = 9;
            // 
            // lblNbrArretSelectionne
            // 
            this.lblNbrArretSelectionne.AutoSize = true;
            this.lblNbrArretSelectionne.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblNbrArretSelectionne.Location = new System.Drawing.Point(252, 32);
            this.lblNbrArretSelectionne.Name = "lblNbrArretSelectionne";
            this.lblNbrArretSelectionne.Size = new System.Drawing.Size(15, 16);
            this.lblNbrArretSelectionne.TabIndex = 7;
            this.lblNbrArretSelectionne.Text = "0";
            // 
            // lblNombreArrets
            // 
            this.lblNombreArrets.AutoSize = true;
            this.lblNombreArrets.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreArrets.Location = new System.Drawing.Point(217, 11);
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
            this.lblAjouterLigne.Location = new System.Drawing.Point(183, 18);
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
            this.flpRangArret.Location = new System.Drawing.Point(267, 149);
            this.flpRangArret.Name = "flpRangArret";
            this.flpRangArret.Size = new System.Drawing.Size(248, 199);
            this.flpRangArret.TabIndex = 16;
            // 
            // cboCouleur
            // 
            this.cboCouleur.FormattingEnabled = true;
            this.cboCouleur.Location = new System.Drawing.Point(4, 153);
            this.cboCouleur.Name = "cboCouleur";
            this.cboCouleur.Size = new System.Drawing.Size(82, 22);
            this.cboCouleur.TabIndex = 17;
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Location = new System.Drawing.Point(0, 132);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(91, 14);
            this.lblCouleur.TabIndex = 18;
            this.lblCouleur.Text = "Couleur de la ligne";
            // 
            // frmAjouterLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 431);
            this.Controls.Add(this.lblCouleur);
            this.Controls.Add(this.cboCouleur);
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
    }
}