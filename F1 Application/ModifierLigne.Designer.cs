namespace F1_Application
{
    partial class frmModifierLigne
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
            this.lblNbrArretSelectionner = new System.Windows.Forms.Label();
            this.lblNombreArrets = new System.Windows.Forms.Label();
            this.txtNomLigne = new System.Windows.Forms.TextBox();
            this.lblNomLigne = new System.Windows.Forms.Label();
            this.clstListeArrets = new System.Windows.Forms.CheckedListBox();
            this.lblArretsModifierLigne = new System.Windows.Forms.Label();
            this.lblRangArretsModifierLigne = new System.Windows.Forms.Label();
            this.flpRangDesArret = new System.Windows.Forms.FlowLayoutPanel();
            this.cboCouleur = new System.Windows.Forms.ComboBox();
            this.nudMinuteFinLigne = new System.Windows.Forms.NumericUpDown();
            this.nudHeureFinLigne = new System.Windows.Forms.NumericUpDown();
            this.nudMinuteDebutLigne = new System.Windows.Forms.NumericUpDown();
            this.nudHeureDebutLigne = new System.Windows.Forms.NumericUpDown();
            this.lblMinuteFinLigne = new System.Windows.Forms.Label();
            this.lblHeureFinLigne = new System.Windows.Forms.Label();
            this.lblFinLigne = new System.Windows.Forms.Label();
            this.lblMinuteDebutLigne = new System.Windows.Forms.Label();
            this.lblHeureDebutLigne = new System.Windows.Forms.Label();
            this.lblDebutLigne = new System.Windows.Forms.Label();
            this.pnlNomNombreArrêt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteFinLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureFinLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteDebutLigne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureDebutLigne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModifierLigne
            // 
            this.lblModifierLigne.AutoSize = true;
            this.lblModifierLigne.Font = new System.Drawing.Font("Times New Roman", 20F);
            this.lblModifierLigne.Location = new System.Drawing.Point(177, 8);
            this.lblModifierLigne.Name = "lblModifierLigne";
            this.lblModifierLigne.Size = new System.Drawing.Size(216, 31);
            this.lblModifierLigne.TabIndex = 0;
            this.lblModifierLigne.Text = "Modifier une ligne";
            this.lblModifierLigne.Click += new System.EventHandler(this.lblModifierLigne_Click);
            // 
            // cmdConfirmerModifierLigne
            // 
            this.cmdConfirmerModifierLigne.BackColor = System.Drawing.Color.Silver;
            this.cmdConfirmerModifierLigne.Location = new System.Drawing.Point(441, 361);
            this.cmdConfirmerModifierLigne.Name = "cmdConfirmerModifierLigne";
            this.cmdConfirmerModifierLigne.Size = new System.Drawing.Size(105, 29);
            this.cmdConfirmerModifierLigne.TabIndex = 1;
            this.cmdConfirmerModifierLigne.Text = "Confirmer";
            this.cmdConfirmerModifierLigne.UseVisualStyleBackColor = false;
            this.cmdConfirmerModifierLigne.Click += new System.EventHandler(this.cmdConfirmerModifierLigne_Click);
            // 
            // cmdAnnulerModifierLigne
            // 
            this.cmdAnnulerModifierLigne.BackColor = System.Drawing.Color.Silver;
            this.cmdAnnulerModifierLigne.Location = new System.Drawing.Point(10, 361);
            this.cmdAnnulerModifierLigne.Name = "cmdAnnulerModifierLigne";
            this.cmdAnnulerModifierLigne.Size = new System.Drawing.Size(105, 29);
            this.cmdAnnulerModifierLigne.TabIndex = 2;
            this.cmdAnnulerModifierLigne.Text = "Annuler";
            this.cmdAnnulerModifierLigne.UseVisualStyleBackColor = false;
            this.cmdAnnulerModifierLigne.Click += new System.EventHandler(this.cmdAnnulerModifierLigne_Click);
            // 
            // pnlNomNombreArrêt
            // 
            this.pnlNomNombreArrêt.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlNomNombreArrêt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNomNombreArrêt.Controls.Add(this.lblNbrArretSelectionner);
            this.pnlNomNombreArrêt.Controls.Add(this.lblNombreArrets);
            this.pnlNomNombreArrêt.Controls.Add(this.txtNomLigne);
            this.pnlNomNombreArrêt.Controls.Add(this.lblNomLigne);
            this.pnlNomNombreArrêt.Location = new System.Drawing.Point(100, 49);
            this.pnlNomNombreArrêt.Name = "pnlNomNombreArrêt";
            this.pnlNomNombreArrêt.Size = new System.Drawing.Size(361, 51);
            this.pnlNomNombreArrêt.TabIndex = 3;
            // 
            // lblNbrArretSelectionner
            // 
            this.lblNbrArretSelectionner.AutoSize = true;
            this.lblNbrArretSelectionner.Location = new System.Drawing.Point(224, 30);
            this.lblNbrArretSelectionner.Name = "lblNbrArretSelectionner";
            this.lblNbrArretSelectionner.Size = new System.Drawing.Size(13, 13);
            this.lblNbrArretSelectionner.TabIndex = 7;
            this.lblNbrArretSelectionner.Text = "0";
            // 
            // lblNombreArrets
            // 
            this.lblNombreArrets.AutoSize = true;
            this.lblNombreArrets.Location = new System.Drawing.Point(217, 10);
            this.lblNombreArrets.Name = "lblNombreArrets";
            this.lblNombreArrets.Size = new System.Drawing.Size(87, 13);
            this.lblNombreArrets.TabIndex = 6;
            this.lblNombreArrets.Text = "Nombre d\'arrêts :";
            // 
            // txtNomLigne
            // 
            this.txtNomLigne.Location = new System.Drawing.Point(18, 26);
            this.txtNomLigne.Name = "txtNomLigne";
            this.txtNomLigne.Size = new System.Drawing.Size(140, 20);
            this.txtNomLigne.TabIndex = 5;
            // 
            // lblNomLigne
            // 
            this.lblNomLigne.AutoSize = true;
            this.lblNomLigne.Location = new System.Drawing.Point(30, 10);
            this.lblNomLigne.Name = "lblNomLigne";
            this.lblNomLigne.Size = new System.Drawing.Size(86, 13);
            this.lblNomLigne.TabIndex = 4;
            this.lblNomLigne.Text = "Nom de la ligne :";
            // 
            // clstListeArrets
            // 
            this.clstListeArrets.FormattingEnabled = true;
            this.clstListeArrets.Location = new System.Drawing.Point(99, 129);
            this.clstListeArrets.Name = "clstListeArrets";
            this.clstListeArrets.Size = new System.Drawing.Size(138, 184);
            this.clstListeArrets.TabIndex = 5;
            this.clstListeArrets.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clstListeArrets_ItemCheck);
            // 
            // lblArretsModifierLigne
            // 
            this.lblArretsModifierLigne.AutoSize = true;
            this.lblArretsModifierLigne.Location = new System.Drawing.Point(100, 114);
            this.lblArretsModifierLigne.Name = "lblArretsModifierLigne";
            this.lblArretsModifierLigne.Size = new System.Drawing.Size(93, 13);
            this.lblArretsModifierLigne.TabIndex = 6;
            this.lblArretsModifierLigne.Text = "Arrêts sur la ligne :";
            // 
            // lblRangArretsModifierLigne
            // 
            this.lblRangArretsModifierLigne.AutoSize = true;
            this.lblRangArretsModifierLigne.Location = new System.Drawing.Point(270, 114);
            this.lblRangArretsModifierLigne.Name = "lblRangArretsModifierLigne";
            this.lblRangArretsModifierLigne.Size = new System.Drawing.Size(91, 13);
            this.lblRangArretsModifierLigne.TabIndex = 7;
            this.lblRangArretsModifierLigne.Text = "Rang des arrêts : ";
            // 
            // flpRangDesArret
            // 
            this.flpRangDesArret.AutoScroll = true;
            this.flpRangDesArret.BackColor = System.Drawing.Color.Green;
            this.flpRangDesArret.Location = new System.Drawing.Point(274, 135);
            this.flpRangDesArret.Name = "flpRangDesArret";
            this.flpRangDesArret.Size = new System.Drawing.Size(245, 177);
            this.flpRangDesArret.TabIndex = 9;
            // 
            // cboCouleur
            // 
            this.cboCouleur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCouleur.FormattingEnabled = true;
            this.cboCouleur.Location = new System.Drawing.Point(1, 129);
            this.cboCouleur.Name = "cboCouleur";
            this.cboCouleur.Size = new System.Drawing.Size(92, 21);
            this.cboCouleur.TabIndex = 8;
            // 
            // nudMinuteFinLigne
            // 
            this.nudMinuteFinLigne.Location = new System.Drawing.Point(645, 231);
            this.nudMinuteFinLigne.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinuteFinLigne.Name = "nudMinuteFinLigne";
            this.nudMinuteFinLigne.Size = new System.Drawing.Size(36, 20);
            this.nudMinuteFinLigne.TabIndex = 36;
            // 
            // nudHeureFinLigne
            // 
            this.nudHeureFinLigne.Location = new System.Drawing.Point(565, 231);
            this.nudHeureFinLigne.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHeureFinLigne.Name = "nudHeureFinLigne";
            this.nudHeureFinLigne.Size = new System.Drawing.Size(40, 20);
            this.nudHeureFinLigne.TabIndex = 35;
            // 
            // nudMinuteDebutLigne
            // 
            this.nudMinuteDebutLigne.Location = new System.Drawing.Point(644, 131);
            this.nudMinuteDebutLigne.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudMinuteDebutLigne.Name = "nudMinuteDebutLigne";
            this.nudMinuteDebutLigne.Size = new System.Drawing.Size(37, 20);
            this.nudMinuteDebutLigne.TabIndex = 34;
            // 
            // nudHeureDebutLigne
            // 
            this.nudHeureDebutLigne.Location = new System.Drawing.Point(567, 131);
            this.nudHeureDebutLigne.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudHeureDebutLigne.Name = "nudHeureDebutLigne";
            this.nudHeureDebutLigne.Size = new System.Drawing.Size(39, 20);
            this.nudHeureDebutLigne.TabIndex = 33;
            // 
            // lblMinuteFinLigne
            // 
            this.lblMinuteFinLigne.AutoSize = true;
            this.lblMinuteFinLigne.Location = new System.Drawing.Point(641, 207);
            this.lblMinuteFinLigne.Name = "lblMinuteFinLigne";
            this.lblMinuteFinLigne.Size = new System.Drawing.Size(39, 13);
            this.lblMinuteFinLigne.TabIndex = 32;
            this.lblMinuteFinLigne.Text = "Minute";
            // 
            // lblHeureFinLigne
            // 
            this.lblHeureFinLigne.AutoSize = true;
            this.lblHeureFinLigne.Location = new System.Drawing.Point(562, 207);
            this.lblHeureFinLigne.Name = "lblHeureFinLigne";
            this.lblHeureFinLigne.Size = new System.Drawing.Size(36, 13);
            this.lblHeureFinLigne.TabIndex = 31;
            this.lblHeureFinLigne.Text = "Heure";
            // 
            // lblFinLigne
            // 
            this.lblFinLigne.AutoSize = true;
            this.lblFinLigne.Location = new System.Drawing.Point(562, 193);
            this.lblFinLigne.Name = "lblFinLigne";
            this.lblFinLigne.Size = new System.Drawing.Size(78, 13);
            this.lblFinLigne.TabIndex = 30;
            this.lblFinLigne.Text = "Fin de la ligne :";
            // 
            // lblMinuteDebutLigne
            // 
            this.lblMinuteDebutLigne.AutoSize = true;
            this.lblMinuteDebutLigne.Location = new System.Drawing.Point(641, 114);
            this.lblMinuteDebutLigne.Name = "lblMinuteDebutLigne";
            this.lblMinuteDebutLigne.Size = new System.Drawing.Size(39, 13);
            this.lblMinuteDebutLigne.TabIndex = 29;
            this.lblMinuteDebutLigne.Text = "Minute";
            // 
            // lblHeureDebutLigne
            // 
            this.lblHeureDebutLigne.AutoSize = true;
            this.lblHeureDebutLigne.Location = new System.Drawing.Point(562, 113);
            this.lblHeureDebutLigne.Name = "lblHeureDebutLigne";
            this.lblHeureDebutLigne.Size = new System.Drawing.Size(36, 13);
            this.lblHeureDebutLigne.TabIndex = 28;
            this.lblHeureDebutLigne.Text = "Heure";
            // 
            // lblDebutLigne
            // 
            this.lblDebutLigne.AutoSize = true;
            this.lblDebutLigne.Location = new System.Drawing.Point(562, 99);
            this.lblDebutLigne.Name = "lblDebutLigne";
            this.lblDebutLigne.Size = new System.Drawing.Size(93, 13);
            this.lblDebutLigne.TabIndex = 27;
            this.lblDebutLigne.Text = "Début de la ligne :";
            // 
            // frmModifierLigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(735, 400);
            this.Controls.Add(this.nudMinuteFinLigne);
            this.Controls.Add(this.nudHeureFinLigne);
            this.Controls.Add(this.nudMinuteDebutLigne);
            this.Controls.Add(this.nudHeureDebutLigne);
            this.Controls.Add(this.lblMinuteFinLigne);
            this.Controls.Add(this.lblHeureFinLigne);
            this.Controls.Add(this.lblFinLigne);
            this.Controls.Add(this.lblMinuteDebutLigne);
            this.Controls.Add(this.lblHeureDebutLigne);
            this.Controls.Add(this.lblDebutLigne);
            this.Controls.Add(this.flpRangDesArret);
            this.Controls.Add(this.cboCouleur);
            this.Controls.Add(this.lblRangArretsModifierLigne);
            this.Controls.Add(this.lblArretsModifierLigne);
            this.Controls.Add(this.clstListeArrets);
            this.Controls.Add(this.pnlNomNombreArrêt);
            this.Controls.Add(this.cmdAnnulerModifierLigne);
            this.Controls.Add(this.cmdConfirmerModifierLigne);
            this.Controls.Add(this.lblModifierLigne);
            this.Name = "frmModifierLigne";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierLigne";
            this.Load += new System.EventHandler(this.frmModifierLigne_Load);
            this.pnlNomNombreArrêt.ResumeLayout(false);
            this.pnlNomNombreArrêt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteFinLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureFinLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuteDebutLigne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeureDebutLigne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModifierLigne;
        private System.Windows.Forms.Button cmdConfirmerModifierLigne;
        private System.Windows.Forms.Button cmdAnnulerModifierLigne;
        private System.Windows.Forms.Panel pnlNomNombreArrêt;
        private System.Windows.Forms.Label lblNombreArrets;
        private System.Windows.Forms.TextBox txtNomLigne;
        private System.Windows.Forms.Label lblNomLigne;
        private System.Windows.Forms.CheckedListBox clstListeArrets;
        private System.Windows.Forms.Label lblArretsModifierLigne;
        private System.Windows.Forms.Label lblRangArretsModifierLigne;
        private System.Windows.Forms.Label lblNbrArretSelectionner;
        private System.Windows.Forms.FlowLayoutPanel flpRangDesArret;
        private System.Windows.Forms.ComboBox cboCouleur;
        private System.Windows.Forms.NumericUpDown nudMinuteFinLigne;
        private System.Windows.Forms.NumericUpDown nudHeureFinLigne;
        private System.Windows.Forms.NumericUpDown nudMinuteDebutLigne;
        private System.Windows.Forms.NumericUpDown nudHeureDebutLigne;
        private System.Windows.Forms.Label lblMinuteFinLigne;
        private System.Windows.Forms.Label lblHeureFinLigne;
        private System.Windows.Forms.Label lblFinLigne;
        private System.Windows.Forms.Label lblMinuteDebutLigne;
        private System.Windows.Forms.Label lblHeureDebutLigne;
        private System.Windows.Forms.Label lblDebutLigne;
    }
}