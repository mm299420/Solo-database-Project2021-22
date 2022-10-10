using System.ComponentModel;

namespace RolkeKlausurProjekt
{
    partial class ViewAll
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProjekte = new System.Windows.Forms.Button();
            this.btnMitarbeiter = new System.Windows.Forms.Button();
            this.btnKunden = new System.Windows.Forms.Button();
            this.dGView = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProjekte
            // 
            this.btnProjekte.Location = new System.Drawing.Point(12, 94);
            this.btnProjekte.Name = "btnProjekte";
            this.btnProjekte.Size = new System.Drawing.Size(150, 35);
            this.btnProjekte.TabIndex = 8;
            this.btnProjekte.Text = "Projekte";
            this.btnProjekte.UseVisualStyleBackColor = true;
            this.btnProjekte.Click += new System.EventHandler(this.btnProjekte_Click);
            // 
            // btnMitarbeiter
            // 
            this.btnMitarbeiter.Location = new System.Drawing.Point(12, 53);
            this.btnMitarbeiter.Name = "btnMitarbeiter";
            this.btnMitarbeiter.Size = new System.Drawing.Size(150, 35);
            this.btnMitarbeiter.TabIndex = 7;
            this.btnMitarbeiter.Text = "Mitarbeiter";
            this.btnMitarbeiter.UseVisualStyleBackColor = true;
            this.btnMitarbeiter.Click += new System.EventHandler(this.btnMitarbeiter_Click);
            // 
            // btnKunden
            // 
            this.btnKunden.Location = new System.Drawing.Point(12, 12);
            this.btnKunden.Name = "btnKunden";
            this.btnKunden.Size = new System.Drawing.Size(150, 35);
            this.btnKunden.TabIndex = 6;
            this.btnKunden.Text = "Kunden";
            this.btnKunden.UseVisualStyleBackColor = true;
            this.btnKunden.Click += new System.EventHandler(this.btnKunden_Click);
            // 
            // dGView
            // 
            this.dGView.AllowUserToOrderColumns = true;
            this.dGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView.Location = new System.Drawing.Point(179, 15);
            this.dGView.Name = "dGView";
            this.dGView.Size = new System.Drawing.Size(660, 296);
            this.dGView.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(12, 274);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 35);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnEdit.Location = new System.Drawing.Point(12, 233);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 35);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Editor";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ViewAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 321);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dGView);
            this.Controls.Add(this.btnProjekte);
            this.Controls.Add(this.btnMitarbeiter);
            this.Controls.Add(this.btnKunden);
            this.Name = "ViewAll";
            this.Text = "ViewAll";
            this.Load += new System.EventHandler(this.ViewAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;

        private System.Windows.Forms.DataGridView dGView;

        private System.Windows.Forms.DataGridView dataGView;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button btnProjekte;
        private System.Windows.Forms.Button btnMitarbeiter;
        private System.Windows.Forms.Button btnKunden;

        #endregion
    }
}