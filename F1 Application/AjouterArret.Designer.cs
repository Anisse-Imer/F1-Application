namespace F1_Application
{
    partial class frmAjouterArret
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
            this.cmdAnnulerAjouterArret = new System.Windows.Forms.Button();
            this.cmdConfirmerAjouterArret = new System.Windows.Forms.Button();
            this.lblArretsReseau = new System.Windows.Forms.Label();
            this.lblAjouterArret = new System.Windows.Forms.Label();
            this.lstArretsReseau = new System.Windows.Forms.ListBox();
            this.lblNomArret = new System.Windows.Forms.Label();
            this.txtNomArret = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdAnnulerAjouterArret
            // 
            this.cmdAnnulerAjouterArret.BackColor = System.Drawing.Color.Silver;
            this.cmdAnnulerAjouterArret.Location = new System.Drawing.Point(10, 284);
            this.cmdAnnulerAjouterArret.Name = "cmdAnnulerAjouterArret";
            this.cmdAnnulerAjouterArret.Size = new System.Drawing.Size(67, 29);
            this.cmdAnnulerAjouterArret.TabIndex = 23;
            this.cmdAnnulerAjouterArret.Text = "Annuler";
            this.cmdAnnulerAjouterArret.UseVisualStyleBackColor = false;
            this.cmdAnnulerAjouterArret.Click += new System.EventHandler(this.cmdAnnulerAjouterArret_Click);
            // 
            // cmdConfirmerAjouterArret
            // 
            this.cmdConfirmerAjouterArret.BackColor = System.Drawing.Color.Silver;
            this.cmdConfirmerAjouterArret.Location = new System.Drawing.Point(110, 284);
            this.cmdConfirmerAjouterArret.Name = "cmdConfirmerAjouterArret";
            this.cmdConfirmerAjouterArret.Size = new System.Drawing.Size(73, 29);
            this.cmdConfirmerAjouterArret.TabIndex = 22;
            this.cmdConfirmerAjouterArret.Text = "Confirmer";
            this.cmdConfirmerAjouterArret.UseVisualStyleBackColor = false;
            this.cmdConfirmerAjouterArret.Click += new System.EventHandler(this.cmdConfirmerAjouterArret_Click);
            // 
            // lblArretsReseau
            // 
            this.lblArretsReseau.AutoSize = true;
            this.lblArretsReseau.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArretsReseau.Location = new System.Drawing.Point(10, 91);
            this.lblArretsReseau.Name = "lblArretsReseau";
            this.lblArretsReseau.Size = new System.Drawing.Size(100, 14);
            this.lblArretsReseau.TabIndex = 20;
            this.lblArretsReseau.Text = "Arrêts sur le réseau :";
            this.lblArretsReseau.Click += new System.EventHandler(this.lblArretsAjouterLigne_Click);
            // 
            // lblAjouterArret
            // 
            this.lblAjouterArret.AutoSize = true;
            this.lblAjouterArret.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjouterArret.Location = new System.Drawing.Point(5, 9);
            this.lblAjouterArret.Name = "lblAjouterArret";
            this.lblAjouterArret.Size = new System.Drawing.Size(166, 27);
            this.lblAjouterArret.TabIndex = 16;
            this.lblAjouterArret.Text = "Ajouter un arrêt";
            // 
            // lstArretsReseau
            // 
            this.lstArretsReseau.FormattingEnabled = true;
            this.lstArretsReseau.Location = new System.Drawing.Point(10, 107);
            this.lstArretsReseau.Name = "lstArretsReseau";
            this.lstArretsReseau.Size = new System.Drawing.Size(173, 173);
            this.lstArretsReseau.TabIndex = 24;
            // 
            // lblNomArret
            // 
            this.lblNomArret.AutoSize = true;
            this.lblNomArret.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomArret.Location = new System.Drawing.Point(10, 42);
            this.lblNomArret.Name = "lblNomArret";
            this.lblNomArret.Size = new System.Drawing.Size(108, 14);
            this.lblNomArret.TabIndex = 4;
            this.lblNomArret.Text = "Nom du nouvel arrêt :";
            // 
            // txtNomArret
            // 
            this.txtNomArret.Location = new System.Drawing.Point(10, 58);
            this.txtNomArret.Name = "txtNomArret";
            this.txtNomArret.Size = new System.Drawing.Size(173, 20);
            this.txtNomArret.TabIndex = 5;
            // 
            // frmAjouterArret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(188, 322);
            this.Controls.Add(this.lblNomArret);
            this.Controls.Add(this.txtNomArret);
            this.Controls.Add(this.lstArretsReseau);
            this.Controls.Add(this.cmdAnnulerAjouterArret);
            this.Controls.Add(this.cmdConfirmerAjouterArret);
            this.Controls.Add(this.lblArretsReseau);
            this.Controls.Add(this.lblAjouterArret);
            this.Name = "frmAjouterArret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le guide du petit arpenteur";
            this.Load += new System.EventHandler(this.frmAjouterArret_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdAnnulerAjouterArret;
        private System.Windows.Forms.Button cmdConfirmerAjouterArret;
        private System.Windows.Forms.Label lblArretsReseau;
        private System.Windows.Forms.Label lblAjouterArret;
        private System.Windows.Forms.ListBox lstArretsReseau;
        private System.Windows.Forms.Label lblNomArret;
        private System.Windows.Forms.TextBox txtNomArret;
    }
}