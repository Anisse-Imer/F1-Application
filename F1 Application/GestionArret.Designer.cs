namespace F1_Application
{
    partial class frmGestionArret
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
            this.lblTitreGestionArret = new System.Windows.Forms.Label();
            this.cmdAnnulerGestionArret = new System.Windows.Forms.Button();
            this.cmdModifierArret = new System.Windows.Forms.Button();
            this.cmdAjouterArret = new System.Windows.Forms.Button();
            this.cmdSupprimerArret = new System.Windows.Forms.Button();
            this.cboArret = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblTitreGestionArret
            // 
            this.lblTitreGestionArret.AutoSize = true;
            this.lblTitreGestionArret.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblTitreGestionArret.Location = new System.Drawing.Point(78, 9);
            this.lblTitreGestionArret.Name = "lblTitreGestionArret";
            this.lblTitreGestionArret.Size = new System.Drawing.Size(257, 31);
            this.lblTitreGestionArret.TabIndex = 11;
            this.lblTitreGestionArret.Text = "Séletionner un Arrêt : ";
            // 
            // cmdAnnulerGestionArret
            // 
            this.cmdAnnulerGestionArret.BackColor = System.Drawing.Color.Silver;
            this.cmdAnnulerGestionArret.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmdAnnulerGestionArret.Location = new System.Drawing.Point(12, 134);
            this.cmdAnnulerGestionArret.Name = "cmdAnnulerGestionArret";
            this.cmdAnnulerGestionArret.Size = new System.Drawing.Size(87, 28);
            this.cmdAnnulerGestionArret.TabIndex = 10;
            this.cmdAnnulerGestionArret.Text = "Annuler";
            this.cmdAnnulerGestionArret.UseVisualStyleBackColor = false;
            this.cmdAnnulerGestionArret.Click += new System.EventHandler(this.cmdAnnulerGestionArret_Click);
            // 
            // cmdModifierArret
            // 
            this.cmdModifierArret.BackColor = System.Drawing.Color.Lavender;
            this.cmdModifierArret.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmdModifierArret.Location = new System.Drawing.Point(173, 80);
            this.cmdModifierArret.Name = "cmdModifierArret";
            this.cmdModifierArret.Size = new System.Drawing.Size(99, 47);
            this.cmdModifierArret.TabIndex = 9;
            this.cmdModifierArret.Text = "Modifier un arrêt";
            this.cmdModifierArret.UseVisualStyleBackColor = false;
            this.cmdModifierArret.Click += new System.EventHandler(this.cmdModifierArret_Click);
            // 
            // cmdAjouterArret
            // 
            this.cmdAjouterArret.BackColor = System.Drawing.Color.Lavender;
            this.cmdAjouterArret.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmdAjouterArret.Location = new System.Drawing.Point(278, 80);
            this.cmdAjouterArret.Name = "cmdAjouterArret";
            this.cmdAjouterArret.Size = new System.Drawing.Size(99, 47);
            this.cmdAjouterArret.TabIndex = 8;
            this.cmdAjouterArret.Text = "Ajouter un nouvel arrêt";
            this.cmdAjouterArret.UseVisualStyleBackColor = false;
            this.cmdAjouterArret.Click += new System.EventHandler(this.cmdAjouterArret_Click);
            // 
            // cmdSupprimerArret
            // 
            this.cmdSupprimerArret.BackColor = System.Drawing.Color.Lavender;
            this.cmdSupprimerArret.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmdSupprimerArret.Location = new System.Drawing.Point(68, 80);
            this.cmdSupprimerArret.Name = "cmdSupprimerArret";
            this.cmdSupprimerArret.Size = new System.Drawing.Size(99, 47);
            this.cmdSupprimerArret.TabIndex = 7;
            this.cmdSupprimerArret.Text = "Supprimer l\'arrêt";
            this.cmdSupprimerArret.UseVisualStyleBackColor = false;
            this.cmdSupprimerArret.Click += new System.EventHandler(this.cmdSupprimerArret_Click);
            // 
            // cboArret
            // 
            this.cboArret.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboArret.FormattingEnabled = true;
            this.cboArret.Location = new System.Drawing.Point(72, 53);
            this.cboArret.Name = "cboArret";
            this.cboArret.Size = new System.Drawing.Size(297, 21);
            this.cboArret.TabIndex = 12;
            // 
            // frmGestionArret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(432, 174);
            this.Controls.Add(this.cboArret);
            this.Controls.Add(this.lblTitreGestionArret);
            this.Controls.Add(this.cmdAnnulerGestionArret);
            this.Controls.Add(this.cmdModifierArret);
            this.Controls.Add(this.cmdAjouterArret);
            this.Controls.Add(this.cmdSupprimerArret);
            this.Name = "frmGestionArret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le guide du petit arpenteur";
            this.Load += new System.EventHandler(this.frmGestionArret_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitreGestionArret;
        private System.Windows.Forms.Button cmdAnnulerGestionArret;
        private System.Windows.Forms.Button cmdModifierArret;
        private System.Windows.Forms.Button cmdAjouterArret;
        private System.Windows.Forms.Button cmdSupprimerArret;
        private System.Windows.Forms.ComboBox cboArret;
    }
}