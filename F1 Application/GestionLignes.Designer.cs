namespace F1_Application
{
    partial class GestionLignes
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
            this.cmdSupprimerLigne = new System.Windows.Forms.Button();
            this.cmdAjouterLigne = new System.Windows.Forms.Button();
            this.cmdModifierLigne = new System.Windows.Forms.Button();
            this.cmdAnnulerGestionLigne = new System.Windows.Forms.Button();
            this.lblTitreGestionLigne = new System.Windows.Forms.Label();
            this.clstSelectionLigne = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // cmdSupprimerLigne
            // 
            this.cmdSupprimerLigne.BackColor = System.Drawing.Color.Lavender;
            this.cmdSupprimerLigne.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdSupprimerLigne.Location = new System.Drawing.Point(73, 195);
            this.cmdSupprimerLigne.Name = "cmdSupprimerLigne";
            this.cmdSupprimerLigne.Size = new System.Drawing.Size(116, 42);
            this.cmdSupprimerLigne.TabIndex = 0;
            this.cmdSupprimerLigne.Text = "Supprimer la ligne";
            this.cmdSupprimerLigne.UseVisualStyleBackColor = false;
            // 
            // cmdAjouterLigne
            // 
            this.cmdAjouterLigne.BackColor = System.Drawing.Color.Lavender;
            this.cmdAjouterLigne.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAjouterLigne.Location = new System.Drawing.Point(317, 195);
            this.cmdAjouterLigne.Name = "cmdAjouterLigne";
            this.cmdAjouterLigne.Size = new System.Drawing.Size(116, 42);
            this.cmdAjouterLigne.TabIndex = 1;
            this.cmdAjouterLigne.Text = "Ajouter une nouvelle ligne";
            this.cmdAjouterLigne.UseVisualStyleBackColor = false;
            // 
            // cmdModifierLigne
            // 
            this.cmdModifierLigne.BackColor = System.Drawing.Color.Lavender;
            this.cmdModifierLigne.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdModifierLigne.Location = new System.Drawing.Point(195, 195);
            this.cmdModifierLigne.Name = "cmdModifierLigne";
            this.cmdModifierLigne.Size = new System.Drawing.Size(116, 42);
            this.cmdModifierLigne.TabIndex = 2;
            this.cmdModifierLigne.Text = "Modifier la ligne";
            this.cmdModifierLigne.UseVisualStyleBackColor = false;
            // 
            // cmdAnnulerGestionLigne
            // 
            this.cmdAnnulerGestionLigne.BackColor = System.Drawing.Color.Silver;
            this.cmdAnnulerGestionLigne.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmdAnnulerGestionLigne.Location = new System.Drawing.Point(13, 257);
            this.cmdAnnulerGestionLigne.Name = "cmdAnnulerGestionLigne";
            this.cmdAnnulerGestionLigne.Size = new System.Drawing.Size(101, 32);
            this.cmdAnnulerGestionLigne.TabIndex = 3;
            this.cmdAnnulerGestionLigne.Text = "Annuler";
            this.cmdAnnulerGestionLigne.UseVisualStyleBackColor = false;
            // 
            // lblTitreGestionLigne
            // 
            this.lblTitreGestionLigne.AutoSize = true;
            this.lblTitreGestionLigne.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitreGestionLigne.Location = new System.Drawing.Point(73, 13);
            this.lblTitreGestionLigne.Name = "lblTitreGestionLigne";
            this.lblTitreGestionLigne.Size = new System.Drawing.Size(266, 31);
            this.lblTitreGestionLigne.TabIndex = 5;
            this.lblTitreGestionLigne.Text = "Séletionner une ligne : ";
            // 
            // clstSelectionLigne
            // 
            this.clstSelectionLigne.BackColor = System.Drawing.Color.Lavender;
            this.clstSelectionLigne.FormattingEnabled = true;
            this.clstSelectionLigne.Location = new System.Drawing.Point(73, 47);
            this.clstSelectionLigne.Name = "clstSelectionLigne";
            this.clstSelectionLigne.Size = new System.Drawing.Size(360, 130);
            this.clstSelectionLigne.TabIndex = 6;
            // 
            // GestionLignes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(504, 301);
            this.Controls.Add(this.clstSelectionLigne);
            this.Controls.Add(this.lblTitreGestionLigne);
            this.Controls.Add(this.cmdAnnulerGestionLigne);
            this.Controls.Add(this.cmdModifierLigne);
            this.Controls.Add(this.cmdAjouterLigne);
            this.Controls.Add(this.cmdSupprimerLigne);
            this.Name = "GestionLignes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionLignes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSupprimerLigne;
        private System.Windows.Forms.Button cmdAjouterLigne;
        private System.Windows.Forms.Button cmdModifierLigne;
        private System.Windows.Forms.Button cmdAnnulerGestionLigne;
        private System.Windows.Forms.Label lblTitreGestionLigne;
        private System.Windows.Forms.CheckedListBox clstSelectionLigne;
    }
}