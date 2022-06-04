namespace F1_Application
{
    partial class frmModifierArret
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
            this.lblNomArret.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomArret.Location = new System.Drawing.Point(9, 43);
            this.lblNomArret.Name = "lblNomArret";
            this.lblNomArret.Size = new System.Drawing.Size(120, 14);
            this.lblNomArret.TabIndex = 25;
            this.lblNomArret.Text = "Nouveau nom de l\'arret :";
            // 
            // txtNomArret
            // 
            this.txtNomArret.Location = new System.Drawing.Point(9, 59);
            this.txtNomArret.Name = "txtNomArret";
            this.txtNomArret.Size = new System.Drawing.Size(173, 20);
            this.txtNomArret.TabIndex = 26;
            // 
            // lstArretsReseau
            // 
            this.lstArretsReseau.FormattingEnabled = true;
            this.lstArretsReseau.Location = new System.Drawing.Point(9, 107);
            this.lstArretsReseau.Name = "lstArretsReseau";
            this.lstArretsReseau.Size = new System.Drawing.Size(173, 173);
            this.lstArretsReseau.TabIndex = 31;
            // 
            // cmdAnnulerModifierArret
            // 
            this.cmdAnnulerModifierArret.BackColor = System.Drawing.Color.Silver;
            this.cmdAnnulerModifierArret.Location = new System.Drawing.Point(9, 285);
            this.cmdAnnulerModifierArret.Name = "cmdAnnulerModifierArret";
            this.cmdAnnulerModifierArret.Size = new System.Drawing.Size(67, 29);
            this.cmdAnnulerModifierArret.TabIndex = 30;
            this.cmdAnnulerModifierArret.Text = "Annuler";
            this.cmdAnnulerModifierArret.UseVisualStyleBackColor = false;
            this.cmdAnnulerModifierArret.Click += new System.EventHandler(this.cmdAnnulerModifierArret_Click);
            // 
            // cmdConfirmerModifierArret
            // 
            this.cmdConfirmerModifierArret.BackColor = System.Drawing.Color.Silver;
            this.cmdConfirmerModifierArret.Location = new System.Drawing.Point(109, 285);
            this.cmdConfirmerModifierArret.Name = "cmdConfirmerModifierArret";
            this.cmdConfirmerModifierArret.Size = new System.Drawing.Size(73, 29);
            this.cmdConfirmerModifierArret.TabIndex = 29;
            this.cmdConfirmerModifierArret.Text = "Confirmer";
            this.cmdConfirmerModifierArret.UseVisualStyleBackColor = false;
            this.cmdConfirmerModifierArret.Click += new System.EventHandler(this.cmdConfirmerModifierArret_Click);
            // 
            // lblArretsReseau
            // 
            this.lblArretsReseau.AutoSize = true;
            this.lblArretsReseau.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArretsReseau.Location = new System.Drawing.Point(9, 92);
            this.lblArretsReseau.Name = "lblArretsReseau";
            this.lblArretsReseau.Size = new System.Drawing.Size(100, 14);
            this.lblArretsReseau.TabIndex = 28;
            this.lblArretsReseau.Text = "Arrêts sur le réseau :";
            // 
            // lblModifierArret
            // 
            this.lblModifierArret.AutoSize = true;
            this.lblModifierArret.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblModifierArret.Location = new System.Drawing.Point(9, 8);
            this.lblModifierArret.Name = "lblModifierArret";
            this.lblModifierArret.Size = new System.Drawing.Size(178, 31);
            this.lblModifierArret.TabIndex = 27;
            this.lblModifierArret.Text = "Modifier l\'arret";
            // 
            // frmModifierArret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(187, 322);
            this.Controls.Add(this.lblNomArret);
            this.Controls.Add(this.txtNomArret);
            this.Controls.Add(this.lstArretsReseau);
            this.Controls.Add(this.cmdAnnulerModifierArret);
            this.Controls.Add(this.cmdConfirmerModifierArret);
            this.Controls.Add(this.lblArretsReseau);
            this.Controls.Add(this.lblModifierArret);
            this.Name = "frmModifierArret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le guide du petit arpenteur";
            this.Load += new System.EventHandler(this.frmModifierArret_Load);
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