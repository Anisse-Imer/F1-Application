﻿namespace F1_Application
{
    partial class ModifierLigne
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
            this.lblModifierLigne = new System.Windows.Forms.Label();
            this.cmdConfirmerModifierLigne = new System.Windows.Forms.Button();
            this.cmdAnnulerModifierLigne = new System.Windows.Forms.Button();
            this.pnlNomNombreArrêt = new System.Windows.Forms.Panel();
            this.nudNombreArrets = new System.Windows.Forms.NumericUpDown();
            this.lblNombreArrets = new System.Windows.Forms.Label();
            this.txtNomLigne = new System.Windows.Forms.TextBox();
            this.lblNomLigne = new System.Windows.Forms.Label();
            this.pnlRangArrets = new System.Windows.Forms.Panel();
            this.clstListeArrets = new System.Windows.Forms.CheckedListBox();
            this.lblArretsModifierLigne = new System.Windows.Forms.Label();
            this.lblRangArretsModifierLigne = new System.Windows.Forms.Label();
            this.pnlNomNombreArrêt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombreArrets)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModifierLigne
            // 
            this.lblModifierLigne.AutoSize = true;
            this.lblModifierLigne.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModifierLigne.Location = new System.Drawing.Point(185, 9);
            this.lblModifierLigne.Name = "lblModifierLigne";
            this.lblModifierLigne.Size = new System.Drawing.Size(216, 31);
            this.lblModifierLigne.TabIndex = 0;
            this.lblModifierLigne.Text = "Modifier une ligne";
            this.lblModifierLigne.Click += new System.EventHandler(this.lblModifierLigne_Click);
            // 
            // cmdConfirmerModifierLigne
            // 
            this.cmdConfirmerModifierLigne.BackColor = System.Drawing.Color.Silver;
            this.cmdConfirmerModifierLigne.Location = new System.Drawing.Point(514, 417);
            this.cmdConfirmerModifierLigne.Name = "cmdConfirmerModifierLigne";
            this.cmdConfirmerModifierLigne.Size = new System.Drawing.Size(122, 34);
            this.cmdConfirmerModifierLigne.TabIndex = 1;
            this.cmdConfirmerModifierLigne.Text = "Confirmer";
            this.cmdConfirmerModifierLigne.UseVisualStyleBackColor = false;
            // 
            // cmdAnnulerModifierLigne
            // 
            this.cmdAnnulerModifierLigne.BackColor = System.Drawing.Color.Silver;
            this.cmdAnnulerModifierLigne.Location = new System.Drawing.Point(12, 417);
            this.cmdAnnulerModifierLigne.Name = "cmdAnnulerModifierLigne";
            this.cmdAnnulerModifierLigne.Size = new System.Drawing.Size(122, 34);
            this.cmdAnnulerModifierLigne.TabIndex = 2;
            this.cmdAnnulerModifierLigne.Text = "Annuler";
            this.cmdAnnulerModifierLigne.UseVisualStyleBackColor = false;
            // 
            // pnlNomNombreArrêt
            // 
            this.pnlNomNombreArrêt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlNomNombreArrêt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNomNombreArrêt.Controls.Add(this.nudNombreArrets);
            this.pnlNomNombreArrêt.Controls.Add(this.lblNombreArrets);
            this.pnlNomNombreArrêt.Controls.Add(this.txtNomLigne);
            this.pnlNomNombreArrêt.Controls.Add(this.lblNomLigne);
            this.pnlNomNombreArrêt.Location = new System.Drawing.Point(96, 56);
            this.pnlNomNombreArrêt.Name = "pnlNomNombreArrêt";
            this.pnlNomNombreArrêt.Size = new System.Drawing.Size(421, 59);
            this.pnlNomNombreArrêt.TabIndex = 3;
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
            // pnlRangArrets
            // 
            this.pnlRangArrets.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlRangArrets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRangArrets.Location = new System.Drawing.Point(287, 149);
            this.pnlRangArrets.Name = "pnlRangArrets";
            this.pnlRangArrets.Size = new System.Drawing.Size(230, 220);
            this.pnlRangArrets.TabIndex = 4;
            // 
            // clstListeArrets
            // 
            this.clstListeArrets.FormattingEnabled = true;
            this.clstListeArrets.Location = new System.Drawing.Point(94, 149);
            this.clstListeArrets.Name = "clstListeArrets";
            this.clstListeArrets.Size = new System.Drawing.Size(187, 220);
            this.clstListeArrets.TabIndex = 5;
            // 
            // lblArretsModifierLigne
            // 
            this.lblArretsModifierLigne.AutoSize = true;
            this.lblArretsModifierLigne.Location = new System.Drawing.Point(96, 131);
            this.lblArretsModifierLigne.Name = "lblArretsModifierLigne";
            this.lblArretsModifierLigne.Size = new System.Drawing.Size(104, 15);
            this.lblArretsModifierLigne.TabIndex = 6;
            this.lblArretsModifierLigne.Text = "Arrêts sur la ligne :";
            // 
            // lblRangArretsModifierLigne
            // 
            this.lblRangArretsModifierLigne.AutoSize = true;
            this.lblRangArretsModifierLigne.Location = new System.Drawing.Point(294, 131);
            this.lblRangArretsModifierLigne.Name = "lblRangArretsModifierLigne";
            this.lblRangArretsModifierLigne.Size = new System.Drawing.Size(96, 15);
            this.lblRangArretsModifierLigne.TabIndex = 7;
            this.lblRangArretsModifierLigne.Text = "Rang des arrêts : ";
            // 
            // ModifierLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(644, 461);
            this.Controls.Add(this.lblRangArretsModifierLigne);
            this.Controls.Add(this.lblArretsModifierLigne);
            this.Controls.Add(this.clstListeArrets);
            this.Controls.Add(this.pnlRangArrets);
            this.Controls.Add(this.pnlNomNombreArrêt);
            this.Controls.Add(this.cmdAnnulerModifierLigne);
            this.Controls.Add(this.cmdConfirmerModifierLigne);
            this.Controls.Add(this.lblModifierLigne);
            this.Name = "ModifierLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierLigne";
            this.pnlNomNombreArrêt.ResumeLayout(false);
            this.pnlNomNombreArrêt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNombreArrets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModifierLigne;
        private System.Windows.Forms.Button cmdConfirmerModifierLigne;
        private System.Windows.Forms.Button cmdAnnulerModifierLigne;
        private System.Windows.Forms.Panel pnlNomNombreArrêt;
        private System.Windows.Forms.NumericUpDown nudNombreArrets;
        private System.Windows.Forms.Label lblNombreArrets;
        private System.Windows.Forms.TextBox txtNomLigne;
        private System.Windows.Forms.Label lblNomLigne;
        private System.Windows.Forms.Panel pnlRangArrets;
        private System.Windows.Forms.CheckedListBox clstListeArrets;
        private System.Windows.Forms.Label lblArretsModifierLigne;
        private System.Windows.Forms.Label lblRangArretsModifierLigne;
    }
}