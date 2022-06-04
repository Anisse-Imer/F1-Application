namespace F1_Application
{
    partial class frmGestionLignes
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
            this.cboSelectionLigne = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmdSupprimerLigne
            // 
            this.cmdSupprimerLigne.BackColor = System.Drawing.Color.Lavender;
            this.cmdSupprimerLigne.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmdSupprimerLigne.Location = new System.Drawing.Point(62, 79);
            this.cmdSupprimerLigne.Name = "cmdSupprimerLigne";
            this.cmdSupprimerLigne.Size = new System.Drawing.Size(99, 48);
            this.cmdSupprimerLigne.TabIndex = 0;
            this.cmdSupprimerLigne.Text = "Supprimer la ligne";
            this.cmdSupprimerLigne.UseVisualStyleBackColor = false;
            this.cmdSupprimerLigne.Click += new System.EventHandler(this.cmdSupprimerLigne_Click);
            // 
            // cmdAjouterLigne
            // 
            this.cmdAjouterLigne.BackColor = System.Drawing.Color.Lavender;
            this.cmdAjouterLigne.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmdAjouterLigne.Location = new System.Drawing.Point(271, 79);
            this.cmdAjouterLigne.Name = "cmdAjouterLigne";
            this.cmdAjouterLigne.Size = new System.Drawing.Size(99, 48);
            this.cmdAjouterLigne.TabIndex = 1;
            this.cmdAjouterLigne.Text = "Ajouter une nouvelle ligne";
            this.cmdAjouterLigne.UseVisualStyleBackColor = false;
            this.cmdAjouterLigne.Click += new System.EventHandler(this.cmdAjouterLigne_Click);
            // 
            // cmdModifierLigne
            // 
            this.cmdModifierLigne.BackColor = System.Drawing.Color.Lavender;
            this.cmdModifierLigne.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmdModifierLigne.Location = new System.Drawing.Point(167, 79);
            this.cmdModifierLigne.Name = "cmdModifierLigne";
            this.cmdModifierLigne.Size = new System.Drawing.Size(99, 48);
            this.cmdModifierLigne.TabIndex = 2;
            this.cmdModifierLigne.Text = "Modifier la ligne";
            this.cmdModifierLigne.UseVisualStyleBackColor = false;
            this.cmdModifierLigne.Click += new System.EventHandler(this.cmdModifierLigne_Click);
            // 
            // cmdAnnulerGestionLigne
            // 
            this.cmdAnnulerGestionLigne.BackColor = System.Drawing.Color.Silver;
            this.cmdAnnulerGestionLigne.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.cmdAnnulerGestionLigne.Location = new System.Drawing.Point(12, 133);
            this.cmdAnnulerGestionLigne.Name = "cmdAnnulerGestionLigne";
            this.cmdAnnulerGestionLigne.Size = new System.Drawing.Size(87, 28);
            this.cmdAnnulerGestionLigne.TabIndex = 3;
            this.cmdAnnulerGestionLigne.Text = "Annuler";
            this.cmdAnnulerGestionLigne.UseVisualStyleBackColor = false;
            this.cmdAnnulerGestionLigne.Click += new System.EventHandler(this.cmdAnnulerGestionLigne_Click);
            // 
            // lblTitreGestionLigne
            // 
            this.lblTitreGestionLigne.AutoSize = true;
            this.lblTitreGestionLigne.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblTitreGestionLigne.Location = new System.Drawing.Point(63, 11);
            this.lblTitreGestionLigne.Name = "lblTitreGestionLigne";
            this.lblTitreGestionLigne.Size = new System.Drawing.Size(266, 31);
            this.lblTitreGestionLigne.TabIndex = 5;
            this.lblTitreGestionLigne.Text = "Séletionner une ligne : ";
            // 
            // cboSelectionLigne
            // 
            this.cboSelectionLigne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSelectionLigne.FormattingEnabled = true;
            this.cboSelectionLigne.Location = new System.Drawing.Point(62, 52);
            this.cboSelectionLigne.Name = "cboSelectionLigne";
            this.cboSelectionLigne.Size = new System.Drawing.Size(308, 21);
            this.cboSelectionLigne.TabIndex = 6;
            // 
            // frmGestionLignes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(432, 167);
            this.Controls.Add(this.cboSelectionLigne);
            this.Controls.Add(this.lblTitreGestionLigne);
            this.Controls.Add(this.cmdAnnulerGestionLigne);
            this.Controls.Add(this.cmdModifierLigne);
            this.Controls.Add(this.cmdAjouterLigne);
            this.Controls.Add(this.cmdSupprimerLigne);
            this.Name = "frmGestionLignes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le guide du petit arpenteur";
            this.Load += new System.EventHandler(this.frmGestionLignes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSupprimerLigne;
        private System.Windows.Forms.Button cmdAjouterLigne;
        private System.Windows.Forms.Button cmdModifierLigne;
        private System.Windows.Forms.Button cmdAnnulerGestionLigne;
        private System.Windows.Forms.Label lblTitreGestionLigne;
        private System.Windows.Forms.ComboBox cboSelectionLigne;
    }
}