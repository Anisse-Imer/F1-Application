namespace F1_Application
{
    partial class ModifierArret
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
            this.lblNomArret = new System.Windows.Forms.Label();
            this.txtNomArret = new System.Windows.Forms.TextBox();
            this.lstArretsReseau = new System.Windows.Forms.ListBox();
            this.cmdAnnulerModifierArret = new System.Windows.Forms.Button();
            this.cmdConfirmerModifierArret = new System.Windows.Forms.Button();
            this.lblArretsReseau = new System.Windows.Forms.Label();
            this.lblModifierArret = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNomArret
            // 
            this.lblNomArret.AutoSize = true;
            this.lblNomArret.Location = new System.Drawing.Point(11, 50);
            this.lblNomArret.Name = "lblNomArret";
            this.lblNomArret.Size = new System.Drawing.Size(89, 15);
            this.lblNomArret.TabIndex = 25;
            this.lblNomArret.Text = "Nom de l\'arret :";
            // 
            // txtNomArret
            // 
            this.txtNomArret.Location = new System.Drawing.Point(11, 68);
            this.txtNomArret.Name = "txtNomArret";
            this.txtNomArret.Size = new System.Drawing.Size(201, 23);
            this.txtNomArret.TabIndex = 26;
            // 
            // lstArretsReseau
            // 
            this.lstArretsReseau.FormattingEnabled = true;
            this.lstArretsReseau.ItemHeight = 15;
            this.lstArretsReseau.Location = new System.Drawing.Point(11, 124);
            this.lstArretsReseau.Name = "lstArretsReseau";
            this.lstArretsReseau.Size = new System.Drawing.Size(201, 199);
            this.lstArretsReseau.TabIndex = 31;
            // 
            // cmdAnnulerModifierArret
            // 
            this.cmdAnnulerModifierArret.BackColor = System.Drawing.Color.Silver;
            this.cmdAnnulerModifierArret.Location = new System.Drawing.Point(11, 329);
            this.cmdAnnulerModifierArret.Name = "cmdAnnulerModifierArret";
            this.cmdAnnulerModifierArret.Size = new System.Drawing.Size(78, 34);
            this.cmdAnnulerModifierArret.TabIndex = 30;
            this.cmdAnnulerModifierArret.Text = "Annuler";
            this.cmdAnnulerModifierArret.UseVisualStyleBackColor = false;
            // 
            // cmdConfirmerModifierArret
            // 
            this.cmdConfirmerModifierArret.BackColor = System.Drawing.Color.Silver;
            this.cmdConfirmerModifierArret.Location = new System.Drawing.Point(127, 329);
            this.cmdConfirmerModifierArret.Name = "cmdConfirmerModifierArret";
            this.cmdConfirmerModifierArret.Size = new System.Drawing.Size(85, 34);
            this.cmdConfirmerModifierArret.TabIndex = 29;
            this.cmdConfirmerModifierArret.Text = "Confirmer";
            this.cmdConfirmerModifierArret.UseVisualStyleBackColor = false;
            // 
            // lblArretsReseau
            // 
            this.lblArretsReseau.AutoSize = true;
            this.lblArretsReseau.Location = new System.Drawing.Point(11, 106);
            this.lblArretsReseau.Name = "lblArretsReseau";
            this.lblArretsReseau.Size = new System.Drawing.Size(112, 15);
            this.lblArretsReseau.TabIndex = 28;
            this.lblArretsReseau.Text = "Arrêts sur le réseau :";
            // 
            // lblModifierArret
            // 
            this.lblModifierArret.AutoSize = true;
            this.lblModifierArret.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModifierArret.Location = new System.Drawing.Point(11, 9);
            this.lblModifierArret.Name = "lblModifierArret";
            this.lblModifierArret.Size = new System.Drawing.Size(178, 31);
            this.lblModifierArret.TabIndex = 27;
            this.lblModifierArret.Text = "Modifier l\'arret";
            // 
            // ModifierArret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(218, 371);
            this.Controls.Add(this.lblNomArret);
            this.Controls.Add(this.txtNomArret);
            this.Controls.Add(this.lstArretsReseau);
            this.Controls.Add(this.cmdAnnulerModifierArret);
            this.Controls.Add(this.cmdConfirmerModifierArret);
            this.Controls.Add(this.lblArretsReseau);
            this.Controls.Add(this.lblModifierArret);
            this.Name = "ModifierArret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierArret";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomArret;
        private System.Windows.Forms.TextBox txtNomArret;
        private System.Windows.Forms.ListBox lstArretsReseau;
        private System.Windows.Forms.Button cmdAnnulerModifierArret;
        private System.Windows.Forms.Button cmdConfirmerModifierArret;
        private System.Windows.Forms.Label lblArretsReseau;
        private System.Windows.Forms.Label lblModifierArret;
    }
}