namespace F1_Application
{
    partial class AjouterLigne
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
            this.pnlRangArrets = new System.Windows.Forms.Panel();
            this.pnlNomNombreArrets = new System.Windows.Forms.Panel();
            this.nudNombreArrets = new System.Windows.Forms.NumericUpDown();
            this.lblNombreArrets = new System.Windows.Forms.Label();
            this.txtNomLigne = new System.Windows.Forms.TextBox();
            this.lblNomLigne = new System.Windows.Forms.Label();
            this.lblAjouterLigne = new System.Windows.Forms.Label();
            this.cmdAnnulerAjouterLigne = new System.Windows.Forms.Button();
            this.cmdConfirmerAjouterLigne = new System.Windows.Forms.Button();
            this.pnlNomNombreArrets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombreArrets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRangArretsAjouterLigne
            // 
            this.lblRangArretsAjouterLigne.AutoSize = true;
            this.lblRangArretsAjouterLigne.Location = new System.Drawing.Point(306, 142);
            this.lblRangArretsAjouterLigne.Name = "lblRangArretsAjouterLigne";
            this.lblRangArretsAjouterLigne.Size = new System.Drawing.Size(96, 15);
            this.lblRangArretsAjouterLigne.TabIndex = 13;
            this.lblRangArretsAjouterLigne.Text = "Rang des arrêts : ";
            // 
            // lblArretsAjouterLigne
            // 
            this.lblArretsAjouterLigne.AutoSize = true;
            this.lblArretsAjouterLigne.Location = new System.Drawing.Point(113, 142);
            this.lblArretsAjouterLigne.Name = "lblArretsAjouterLigne";
            this.lblArretsAjouterLigne.Size = new System.Drawing.Size(104, 15);
            this.lblArretsAjouterLigne.TabIndex = 12;
            this.lblArretsAjouterLigne.Text = "Arrêts sur la ligne :";
            // 
            // clstListeArrets
            // 
            this.clstListeArrets.FormattingEnabled = true;
            this.clstListeArrets.Location = new System.Drawing.Point(111, 160);
            this.clstListeArrets.Name = "clstListeArrets";
            this.clstListeArrets.Size = new System.Drawing.Size(187, 220);
            this.clstListeArrets.TabIndex = 11;
            // 
            // pnlRangArrets
            // 
            this.pnlRangArrets.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlRangArrets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRangArrets.Location = new System.Drawing.Point(304, 160);
            this.pnlRangArrets.Name = "pnlRangArrets";
            this.pnlRangArrets.Size = new System.Drawing.Size(230, 220);
            this.pnlRangArrets.TabIndex = 10;
            // 
            // pnlNomNombreArrets
            // 
            this.pnlNomNombreArrets.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlNomNombreArrets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNomNombreArrets.Controls.Add(this.nudNombreArrets);
            this.pnlNomNombreArrets.Controls.Add(this.lblNombreArrets);
            this.pnlNomNombreArrets.Controls.Add(this.txtNomLigne);
            this.pnlNomNombreArrets.Controls.Add(this.lblNomLigne);
            this.pnlNomNombreArrets.Location = new System.Drawing.Point(113, 67);
            this.pnlNomNombreArrets.Name = "pnlNomNombreArrets";
            this.pnlNomNombreArrets.Size = new System.Drawing.Size(421, 59);
            this.pnlNomNombreArrets.TabIndex = 9;
            // 
            // nudNombreArrets
            // 
            this.nudNombreArrets.Location = new System.Drawing.Point(240, 30);
            this.nudNombreArrets.Name = "nudNombreArrets";
            this.nudNombreArrets.Size = new System.Drawing.Size(163, 23);
            this.nudNombreArrets.TabIndex = 4;
            // 
            // lblNombreArrets
            // 
            this.lblNombreArrets.AutoSize = true;
            this.lblNombreArrets.Location = new System.Drawing.Point(253, 12);
            this.lblNombreArrets.Name = "lblNombreArrets";
            this.lblNombreArrets.Size = new System.Drawing.Size(99, 15);
            this.lblNombreArrets.TabIndex = 6;
            this.lblNombreArrets.Text = "Nombre d\'arrêts :";
            // 
            // txtNomLigne
            // 
            this.txtNomLigne.Location = new System.Drawing.Point(21, 30);
            this.txtNomLigne.Name = "txtNomLigne";
            this.txtNomLigne.Size = new System.Drawing.Size(163, 23);
            this.txtNomLigne.TabIndex = 5;
            // 
            // lblNomLigne
            // 
            this.lblNomLigne.AutoSize = true;
            this.lblNomLigne.Location = new System.Drawing.Point(35, 12);
            this.lblNomLigne.Name = "lblNomLigne";
            this.lblNomLigne.Size = new System.Drawing.Size(97, 15);
            this.lblNomLigne.TabIndex = 4;
            this.lblNomLigne.Text = "Nom de la ligne :";
            // 
            // lblAjouterLigne
            // 
            this.lblAjouterLigne.AutoSize = true;
            this.lblAjouterLigne.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAjouterLigne.Location = new System.Drawing.Point(214, 20);
            this.lblAjouterLigne.Name = "lblAjouterLigne";
            this.lblAjouterLigne.Size = new System.Drawing.Size(209, 31);
            this.lblAjouterLigne.TabIndex = 8;
            this.lblAjouterLigne.Text = "Ajouter une igne :";
            // 
            // cmdAnnulerAjouterLigne
            // 
            this.cmdAnnulerAjouterLigne.BackColor = System.Drawing.Color.Silver;
            this.cmdAnnulerAjouterLigne.Location = new System.Drawing.Point(12, 415);
            this.cmdAnnulerAjouterLigne.Name = "cmdAnnulerAjouterLigne";
            this.cmdAnnulerAjouterLigne.Size = new System.Drawing.Size(122, 34);
            this.cmdAnnulerAjouterLigne.TabIndex = 15;
            this.cmdAnnulerAjouterLigne.Text = "Annuler";
            this.cmdAnnulerAjouterLigne.UseVisualStyleBackColor = false;
            // 
            // cmdConfirmerAjouterLigne
            // 
            this.cmdConfirmerAjouterLigne.BackColor = System.Drawing.Color.Silver;
            this.cmdConfirmerAjouterLigne.Location = new System.Drawing.Point(514, 415);
            this.cmdConfirmerAjouterLigne.Name = "cmdConfirmerAjouterLigne";
            this.cmdConfirmerAjouterLigne.Size = new System.Drawing.Size(122, 34);
            this.cmdConfirmerAjouterLigne.TabIndex = 14;
            this.cmdConfirmerAjouterLigne.Text = "Confirmer";
            this.cmdConfirmerAjouterLigne.UseVisualStyleBackColor = false;
            // 
            // AjouterLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 461);
            this.Controls.Add(this.cmdAnnulerAjouterLigne);
            this.Controls.Add(this.cmdConfirmerAjouterLigne);
            this.Controls.Add(this.lblRangArretsAjouterLigne);
            this.Controls.Add(this.lblArretsAjouterLigne);
            this.Controls.Add(this.clstListeArrets);
            this.Controls.Add(this.pnlRangArrets);
            this.Controls.Add(this.pnlNomNombreArrets);
            this.Controls.Add(this.lblAjouterLigne);
            this.Name = "AjouterLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouterLigne";
            this.pnlNomNombreArrets.ResumeLayout(false);
            this.pnlNomNombreArrets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombreArrets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRangArretsAjouterLigne;
        private System.Windows.Forms.Label lblArretsAjouterLigne;
        private System.Windows.Forms.CheckedListBox clstListeArrets;
        private System.Windows.Forms.Panel pnlRangArrets;
        private System.Windows.Forms.Panel pnlNomNombreArrets;
        private System.Windows.Forms.NumericUpDown nudNombreArrets;
        private System.Windows.Forms.Label lblNombreArrets;
        private System.Windows.Forms.TextBox txtNomLigne;
        private System.Windows.Forms.Label lblNomLigne;
        private System.Windows.Forms.Label lblAjouterLigne;
        private System.Windows.Forms.Button cmdAnnulerAjouterLigne;
        private System.Windows.Forms.Button cmdConfirmerAjouterLigne;
    }
}