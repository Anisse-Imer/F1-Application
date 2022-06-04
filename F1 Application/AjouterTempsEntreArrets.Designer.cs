
namespace F1_Application
{
    partial class frmTempsEntreArret
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
            this.lblArret = new System.Windows.Forms.Label();
            this.nudTempsEntreArret = new System.Windows.Forms.NumericUpDown();
            this.cmdConfirmer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempsEntreArret)).BeginInit();
            this.SuspendLayout();
            // 
            // lblArret
            // 
            this.lblArret.AutoSize = true;
            this.lblArret.Location = new System.Drawing.Point(151, 42);
            this.lblArret.Name = "lblArret";
            this.lblArret.Size = new System.Drawing.Size(80, 13);
            this.lblArret.TabIndex = 0;
            this.lblArret.Text = "Temps inconnu";
            // 
            // nudTempsEntreArret
            // 
            this.nudTempsEntreArret.Location = new System.Drawing.Point(169, 70);
            this.nudTempsEntreArret.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nudTempsEntreArret.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTempsEntreArret.Name = "nudTempsEntreArret";
            this.nudTempsEntreArret.Size = new System.Drawing.Size(40, 20);
            this.nudTempsEntreArret.TabIndex = 1;
            this.nudTempsEntreArret.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmdConfirmer
            // 
            this.cmdConfirmer.Location = new System.Drawing.Point(260, 122);
            this.cmdConfirmer.Name = "cmdConfirmer";
            this.cmdConfirmer.Size = new System.Drawing.Size(94, 31);
            this.cmdConfirmer.TabIndex = 2;
            this.cmdConfirmer.Text = "Confirmer";
            this.cmdConfirmer.UseVisualStyleBackColor = true;
            this.cmdConfirmer.Click += new System.EventHandler(this.cmdConfirmer_Click);
            // 
            // frmTempsEntreArret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 162);
            this.Controls.Add(this.cmdConfirmer);
            this.Controls.Add(this.nudTempsEntreArret);
            this.Controls.Add(this.lblArret);
            this.Name = "frmTempsEntreArret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouveau temps entre 2 arrêts";
            this.Load += new System.EventHandler(this.frmTempsEntreArret_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTempsEntreArret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArret;
        private System.Windows.Forms.NumericUpDown nudTempsEntreArret;
        private System.Windows.Forms.Button cmdConfirmer;
    }
}