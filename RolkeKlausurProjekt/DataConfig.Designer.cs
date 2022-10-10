using System.ComponentModel;

namespace RolkeKlausurProjekt
{
    partial class DataConfig
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
            this.btnKunden = new System.Windows.Forms.Button();
            this.btnMitarbeiter = new System.Windows.Forms.Button();
            this.btnProjekte = new System.Windows.Forms.Button();
            this.gBoxConfig = new System.Windows.Forms.GroupBox();
            this.txtReload = new System.Windows.Forms.Button();
            this.lblAnschrift = new System.Windows.Forms.Label();
            this.txtLohn = new System.Windows.Forms.TextBox();
            this.lblLohn = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cBoxAnrede = new System.Windows.Forms.ComboBox();
            this.cBoxID = new System.Windows.Forms.ComboBox();
            this.lblModeOverview = new System.Windows.Forms.Label();
            this.txtAnschrift = new System.Windows.Forms.TextBox();
            this.gBoxZeit = new System.Windows.Forms.GroupBox();
            this.cBoxKID = new System.Windows.Forms.ComboBox();
            this.lblBeginn = new System.Windows.Forms.Label();
            this.lblKID = new System.Windows.Forms.Label();
            this.dateTPBeginn = new System.Windows.Forms.DateTimePicker();
            this.dateTPEnde = new System.Windows.Forms.DateTimePicker();
            this.lblEnde = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gBoxConfig.SuspendLayout();
            this.gBoxZeit.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKunden
            // 
            this.btnKunden.Location = new System.Drawing.Point(12, 12);
            this.btnKunden.Name = "btnKunden";
            this.btnKunden.Size = new System.Drawing.Size(150, 35);
            this.btnKunden.TabIndex = 0;
            this.btnKunden.Text = "Kunden";
            this.btnKunden.UseVisualStyleBackColor = true;
            this.btnKunden.Click += new System.EventHandler(this.btnKunden_Click);
            // 
            // btnMitarbeiter
            // 
            this.btnMitarbeiter.Location = new System.Drawing.Point(12, 53);
            this.btnMitarbeiter.Name = "btnMitarbeiter";
            this.btnMitarbeiter.Size = new System.Drawing.Size(150, 35);
            this.btnMitarbeiter.TabIndex = 1;
            this.btnMitarbeiter.Text = "Mitarbeiter";
            this.btnMitarbeiter.UseVisualStyleBackColor = true;
            this.btnMitarbeiter.Click += new System.EventHandler(this.btnMitarbeiter_Click);
            // 
            // btnProjekte
            // 
            this.btnProjekte.Location = new System.Drawing.Point(12, 94);
            this.btnProjekte.Name = "btnProjekte";
            this.btnProjekte.Size = new System.Drawing.Size(150, 35);
            this.btnProjekte.TabIndex = 2;
            this.btnProjekte.Text = "Projekte";
            this.btnProjekte.UseVisualStyleBackColor = true;
            this.btnProjekte.Click += new System.EventHandler(this.btnProjekte_Click);
            // 
            // gBoxConfig
            // 
            this.gBoxConfig.Controls.Add(this.txtReload);
            this.gBoxConfig.Controls.Add(this.lblAnschrift);
            this.gBoxConfig.Controls.Add(this.txtLohn);
            this.gBoxConfig.Controls.Add(this.lblLohn);
            this.gBoxConfig.Controls.Add(this.lblName);
            this.gBoxConfig.Controls.Add(this.txtName);
            this.gBoxConfig.Controls.Add(this.cBoxAnrede);
            this.gBoxConfig.Controls.Add(this.cBoxID);
            this.gBoxConfig.Controls.Add(this.lblModeOverview);
            this.gBoxConfig.Controls.Add(this.txtAnschrift);
            this.gBoxConfig.Location = new System.Drawing.Point(178, 14);
            this.gBoxConfig.Name = "gBoxConfig";
            this.gBoxConfig.Size = new System.Drawing.Size(280, 303);
            this.gBoxConfig.TabIndex = 3;
            this.gBoxConfig.TabStop = false;
            this.gBoxConfig.Text = "Config";
            this.gBoxConfig.Visible = false;
            // 
            // txtReload
            // 
            this.txtReload.BackColor = System.Drawing.Color.Yellow;
            this.txtReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReload.Location = new System.Drawing.Point(237, 255);
            this.txtReload.Name = "txtReload";
            this.txtReload.Size = new System.Drawing.Size(37, 42);
            this.txtReload.TabIndex = 14;
            this.txtReload.Text = "R";
            this.txtReload.UseVisualStyleBackColor = false;
            this.txtReload.Click += new System.EventHandler(this.txtReload_Click);
            // 
            // lblAnschrift
            // 
            this.lblAnschrift.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblAnschrift.Location = new System.Drawing.Point(6, 126);
            this.lblAnschrift.Name = "lblAnschrift";
            this.lblAnschrift.Size = new System.Drawing.Size(268, 23);
            this.lblAnschrift.TabIndex = 8;
            this.lblAnschrift.Text = "Anschrift";
            this.lblAnschrift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLohn
            // 
            this.txtLohn.Location = new System.Drawing.Point(148, 103);
            this.txtLohn.Name = "txtLohn";
            this.txtLohn.ReadOnly = true;
            this.txtLohn.Size = new System.Drawing.Size(126, 20);
            this.txtLohn.TabIndex = 6;
            this.txtLohn.Text = "€ / Std";
            // 
            // lblLohn
            // 
            this.lblLohn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblLohn.Location = new System.Drawing.Point(148, 77);
            this.lblLohn.Name = "lblLohn";
            this.lblLohn.Size = new System.Drawing.Size(126, 23);
            this.lblLohn.TabIndex = 5;
            this.lblLohn.Text = "Lohn";
            this.lblLohn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblName.Location = new System.Drawing.Point(6, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(136, 23);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 103);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(136, 20);
            this.txtName.TabIndex = 3;
            // 
            // cBoxAnrede
            // 
            this.cBoxAnrede.Enabled = false;
            this.cBoxAnrede.FormattingEnabled = true;
            this.cBoxAnrede.Items.AddRange(new object[] { "Firma", "Herr", "Frau", "Sonstiges" });
            this.cBoxAnrede.Location = new System.Drawing.Point(59, 53);
            this.cBoxAnrede.Name = "cBoxAnrede";
            this.cBoxAnrede.Size = new System.Drawing.Size(215, 21);
            this.cBoxAnrede.TabIndex = 2;
            this.cBoxAnrede.Text = "Anrede";
            // 
            // cBoxID
            // 
            this.cBoxID.FormattingEnabled = true;
            this.cBoxID.Location = new System.Drawing.Point(6, 53);
            this.cBoxID.Name = "cBoxID";
            this.cBoxID.Size = new System.Drawing.Size(47, 21);
            this.cBoxID.TabIndex = 1;
            this.cBoxID.SelectedIndexChanged += new System.EventHandler(this.cBoxID_TextChanged);
            this.cBoxID.TextChanged += new System.EventHandler(this.cBoxID_TextChanged);
            // 
            // lblModeOverview
            // 
            this.lblModeOverview.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblModeOverview.Location = new System.Drawing.Point(6, 25);
            this.lblModeOverview.Name = "lblModeOverview";
            this.lblModeOverview.Size = new System.Drawing.Size(268, 23);
            this.lblModeOverview.TabIndex = 0;
            this.lblModeOverview.Text = "Mode";
            this.lblModeOverview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAnschrift
            // 
            this.txtAnschrift.Location = new System.Drawing.Point(6, 152);
            this.txtAnschrift.Multiline = true;
            this.txtAnschrift.Name = "txtAnschrift";
            this.txtAnschrift.ReadOnly = true;
            this.txtAnschrift.Size = new System.Drawing.Size(225, 147);
            this.txtAnschrift.TabIndex = 7;
            // 
            // gBoxZeit
            // 
            this.gBoxZeit.Controls.Add(this.cBoxKID);
            this.gBoxZeit.Controls.Add(this.lblBeginn);
            this.gBoxZeit.Controls.Add(this.lblKID);
            this.gBoxZeit.Controls.Add(this.dateTPBeginn);
            this.gBoxZeit.Controls.Add(this.dateTPEnde);
            this.gBoxZeit.Controls.Add(this.lblEnde);
            this.gBoxZeit.Location = new System.Drawing.Point(178, 91);
            this.gBoxZeit.Name = "gBoxZeit";
            this.gBoxZeit.Size = new System.Drawing.Size(285, 126);
            this.gBoxZeit.TabIndex = 13;
            this.gBoxZeit.TabStop = false;
            this.gBoxZeit.Text = "Projekt Zeit";
            this.gBoxZeit.Visible = false;
            // 
            // cBoxKID
            // 
            this.cBoxKID.Enabled = false;
            this.cBoxKID.FormattingEnabled = true;
            this.cBoxKID.Location = new System.Drawing.Point(215, 41);
            this.cBoxKID.Name = "cBoxKID";
            this.cBoxKID.Size = new System.Drawing.Size(59, 21);
            this.cBoxKID.TabIndex = 14;
            // 
            // lblBeginn
            // 
            this.lblBeginn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblBeginn.Location = new System.Drawing.Point(6, 15);
            this.lblBeginn.Name = "lblBeginn";
            this.lblBeginn.Size = new System.Drawing.Size(203, 23);
            this.lblBeginn.TabIndex = 11;
            this.lblBeginn.Text = "Projekt Beginn\r\n";
            this.lblBeginn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKID
            // 
            this.lblKID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblKID.Location = new System.Drawing.Point(214, 15);
            this.lblKID.Name = "lblKID";
            this.lblKID.Size = new System.Drawing.Size(60, 23);
            this.lblKID.TabIndex = 13;
            this.lblKID.Text = "Kunde";
            this.lblKID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTPBeginn
            // 
            this.dateTPBeginn.Enabled = false;
            this.dateTPBeginn.Location = new System.Drawing.Point(6, 41);
            this.dateTPBeginn.Name = "dateTPBeginn";
            this.dateTPBeginn.Size = new System.Drawing.Size(203, 20);
            this.dateTPBeginn.TabIndex = 9;
            this.dateTPBeginn.Value = new System.DateTime(2022, 6, 9, 0, 0, 0, 0);
            // 
            // dateTPEnde
            // 
            this.dateTPEnde.Enabled = false;
            this.dateTPEnde.Location = new System.Drawing.Point(6, 89);
            this.dateTPEnde.Name = "dateTPEnde";
            this.dateTPEnde.Size = new System.Drawing.Size(203, 20);
            this.dateTPEnde.TabIndex = 10;
            this.dateTPEnde.Value = new System.DateTime(2022, 6, 9, 10, 55, 58, 0);
            // 
            // lblEnde
            // 
            this.lblEnde.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblEnde.Location = new System.Drawing.Point(6, 63);
            this.lblEnde.Name = "lblEnde";
            this.lblEnde.Size = new System.Drawing.Size(203, 23);
            this.lblEnde.TabIndex = 12;
            this.lblEnde.Text = "Projekt Ende\r\n";
            this.lblEnde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.Color.MistyRose;
            this.btnEnter.Location = new System.Drawing.Point(464, 222);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(70, 57);
            this.btnEnter.TabIndex = 4;
            this.btnEnter.Text = "Accept";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(464, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 32);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DataConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 321);
            this.Controls.Add(this.gBoxZeit);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.gBoxConfig);
            this.Controls.Add(this.btnProjekte);
            this.Controls.Add(this.btnMitarbeiter);
            this.Controls.Add(this.btnKunden);
            this.Name = "DataConfig";
            this.Text = "DataConfig";
            this.Load += new System.EventHandler(this.DataConfig_Load);
            this.gBoxConfig.ResumeLayout(false);
            this.gBoxConfig.PerformLayout();
            this.gBoxZeit.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox cBoxKID;

        private System.Windows.Forms.Button txtReload;

        private System.Windows.Forms.GroupBox gBoxZeit;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblKID;

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.Button button1;

        public System.Windows.Forms.Button btnProjekte;

        private System.Windows.Forms.Button btn;

        private System.Windows.Forms.DateTimePicker dateTPEnde;
        private System.Windows.Forms.DateTimePicker dateTPBeginn;
        private System.Windows.Forms.Label lblEnde;
        private System.Windows.Forms.Label lblBeginn;

        private System.Windows.Forms.Label lblLohn;
        private System.Windows.Forms.TextBox txtLohn;
        private System.Windows.Forms.Label lblAnschrift;
        private System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.TextBox txtAnschrift;

        private System.Windows.Forms.Label lblModeOverview;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gBoxConfig;
        private System.Windows.Forms.ComboBox cBoxAnrede;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cBoxID;

        public System.Windows.Forms.Button btnKunden;
        public System.Windows.Forms.Button btnMitarbeiter;
        private System.Windows.Forms.Button btnProjektet;
        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}