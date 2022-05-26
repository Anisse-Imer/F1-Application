namespace F1_Application
{
    partial class GestionArret
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionArret));
            this.clstSelectionArret = new System.Windows.Forms.CheckedListBox();
            this.lblTitreGestionArret = new System.Windows.Forms.Label();
            this.cmdAnnulerGestionArret = new System.Windows.Forms.Button();
            this.cmdModifierArret = new System.Windows.Forms.Button();
            this.cmdAjouterArret = new System.Windows.Forms.Button();
            this.cmdSupprimerArret = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clstSelectionArret
            // 
            this.clstSelectionArret.BackColor = System.Drawing.Color.Lavender;
            this.clstSelectionArret.FormattingEnabled = true;
            this.clstSelectionArret.Location = new System.Drawing.Point(72, 48);
            this.clstSelectionArret.Name = "clstSelectionArret";
            this.clstSelectionArret.Size = new System.Drawing.Size(360, 130);
            this.clstSelectionArret.TabIndex = 12;
            // 
            // lblTitreGestionArret
            // 
            this.lblTitreGestionArret.AutoSize = true;
            this.lblTitreGestionArret.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitreGestionArret.Location = new System.Drawing.Point(72, 14);
            this.lblTitreGestionArret.Name = "lblTitreGestionArret";
            this.lblTitreGestionArret.Size = new System.Drawing.Size(257, 31);
            this.lblTitreGestionArret.TabIndex = 11;
            this.lblTitreGestionArret.Text = "Séletionner un Arret : ";
            // 
            // cmdAnnulerGestionArret
            // 
            this.cmdAnnulerGestionArret.BackColor = System.Drawing.Color.Silver;
            this.cmdAnnulerGestionArret.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAnnulerGestionArret.Location = new System.Drawing.Point(12, 258);
            this.cmdAnnulerGestionArret.Name = "cmdAnnulerGestionArret";
            this.cmdAnnulerGestionArret.Size = new System.Drawing.Size(101, 32);
            this.cmdAnnulerGestionArret.TabIndex = 10;
            this.cmdAnnulerGestionArret.Text = "Annuler";
            this.cmdAnnulerGestionArret.UseVisualStyleBackColor = false;
            // 
            // cmdModifierArret
            // 
            this.cmdModifierArret.BackColor = System.Drawing.Color.Lavender;
            this.cmdModifierArret.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdModifierArret.Location = new System.Drawing.Point(194, 196);
            this.cmdModifierArret.Name = "cmdModifierArret";
            this.cmdModifierArret.Size = new System.Drawing.Size(116, 42);
            this.cmdModifierArret.TabIndex = 9;
            this.cmdModifierArret.Text = "Modifier l\'arret";
            this.cmdModifierArret.UseVisualStyleBackColor = false;
            // 
            // cmdAjouterArret
            // 
            this.cmdAjouterArret.BackColor = System.Drawing.Color.Lavender;
            this.cmdAjouterArret.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAjouterArret.Location = new System.Drawing.Point(316, 196);
            this.cmdAjouterArret.Name = "cmdAjouterArret";
            this.cmdAjouterArret.Size = new System.Drawing.Size(116, 42);
            this.cmdAjouterArret.TabIndex = 8;
            this.cmdAjouterArret.Text = "Ajouter un nouvel arret";
            this.cmdAjouterArret.UseVisualStyleBackColor = false;
            // 
            // cmdSupprimerArret
            // 
            this.cmdSupprimerArret.BackColor = System.Drawing.Color.Lavender;
            this.cmdSupprimerArret.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdSupprimerArret.Location = new System.Drawing.Point(72, 196);
            this.cmdSupprimerArret.Name = "cmdSupprimerArret";
            this.cmdSupprimerArret.Size = new System.Drawing.Size(116, 42);
            this.cmdSupprimerArret.TabIndex = 7;
            this.cmdSupprimerArret.Text = "Supprimer l\'arret";
            this.cmdSupprimerArret.UseVisualStyleBackColor = false;
            // 
            // GestionArret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(504, 301);
            this.Controls.Add(this.clstSelectionArret);
            this.Controls.Add(this.lblTitreGestionArret);
            this.Controls.Add(this.cmdAnnulerGestionArret);
            this.Controls.Add(this.cmdModifierArret);
            this.Controls.Add(this.cmdAjouterArret);
            this.Controls.Add(this.cmdSupprimerArret);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GestionArret";
            this.Text = "GestionArret";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clstSelectionArret;
        private System.Windows.Forms.Label lblTitreGestionArret;
        private System.Windows.Forms.Button cmdAnnulerGestionArret;
        private System.Windows.Forms.Button cmdModifierArret;
        private System.Windows.Forms.Button cmdAjouterArret;
        private System.Windows.Forms.Button cmdSupprimerArret;
    }
}