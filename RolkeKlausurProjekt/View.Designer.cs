using System.ComponentModel;

namespace RolkeKlausurProjekt
{
    partial class View
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProjekte = new System.Windows.Forms.Button();
            this.btnMitarbeiter = new System.Windows.Forms.Button();
            this.btnKunden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProjekte
            // 
            this.btnProjekte.Location = new System.Drawing.Point(3, 85);
            this.btnProjekte.Name = "btnProjekte";
            this.btnProjekte.Size = new System.Drawing.Size(150, 35);
            this.btnProjekte.TabIndex = 5;
            this.btnProjekte.Text = "Projekte";
            this.btnProjekte.UseVisualStyleBackColor = true;
            // 
            // btnMitarbeiter
            // 
            this.btnMitarbeiter.Location = new System.Drawing.Point(3, 44);
            this.btnMitarbeiter.Name = "btnMitarbeiter";
            this.btnMitarbeiter.Size = new System.Drawing.Size(150, 35);
            this.btnMitarbeiter.TabIndex = 4;
            this.btnMitarbeiter.Text = "Mitarbeiter";
            this.btnMitarbeiter.UseVisualStyleBackColor = true;
            // 
            // btnKunden
            // 
            this.btnKunden.Location = new System.Drawing.Point(3, 3);
            this.btnKunden.Name = "btnKunden";
            this.btnKunden.Size = new System.Drawing.Size(150, 35);
            this.btnKunden.TabIndex = 3;
            this.btnKunden.Text = "Kunden";
            this.btnKunden.UseVisualStyleBackColor = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.btnProjekte);
            this.Controls.Add(this.btnMitarbeiter);
            this.Controls.Add(this.btnKunden);
            this.Name = "View";
            this.Size = new System.Drawing.Size(645, 327);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnProjekte;
        private System.Windows.Forms.Button btnMitarbeiter;
        private System.Windows.Forms.Button btnKunden;

        #endregion
    }
}