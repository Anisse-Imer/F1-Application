
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
            this.lblArret.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArret.Location = new System.Drawing.Point(12, 9);
            this.lblArret.Name = "lblArret";
            this.lblArret.Size = new System.Drawing.Size(261, 15);
            this.lblArret.TabIndex = 0;
            this.lblArret.Text = "Le temps entre de  arret 1 et arret 2 est inconnu :";
            // 
            // nudTempsEntreArret
            // 
            this.nudTempsEntreArret.Location = new System.Drawing.Point(92, 60);
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
            this.nudTempsEntreArret.Size = new System.Drawing.Size(94, 20);
            this.nudTempsEntreArret.TabIndex = 1;
            this.nudTempsEntreArret.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmdConfirmer
            // 
            this.cmdConfirmer.BackColor = System.Drawing.Color.Lavender;
            this.cmdConfirmer.Location = new System.Drawing.Point(92, 86);
            this.cmdConfirmer.Name = "cmdConfirmer";
            this.cmdConfirmer.Size = new System.Drawing.Size(94, 31);
            this.cmdConfirmer.TabIndex = 2;
            this.cmdConfirmer.Text = "Confirmer";
            this.cmdConfirmer.UseVisualStyleBackColor = false;
            this.cmdConfirmer.Click += new System.EventHandler(this.cmdConfirmer_Click);
            // 
            // frmTempsEntreArret
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(418, 122);
            this.Controls.Add(this.cmdConfirmer);
            this.Controls.Add(this.nudTempsEntreArret);
            this.Controls.Add(this.lblArret);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmTempsEntreArret";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le guide du petit arpenteur";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTempsEntreArret_FormClosing);
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