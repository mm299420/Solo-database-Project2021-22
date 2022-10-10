using System.ComponentModel;

namespace RolkeKlausurProjekt
{
    partial class ProjektVerwaltung
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
            this.label1 = new System.Windows.Forms.Label();
            this.cBoxKID = new System.Windows.Forms.ComboBox();
            this.lblEnde = new System.Windows.Forms.Label();
            this.lblBeginn = new System.Windows.Forms.Label();
            this.dateTPEnde = new System.Windows.Forms.DateTimePicker();
            this.lblKID = new System.Windows.Forms.Label();
            this.dateTPBeginn = new System.Windows.Forms.DateTimePicker();
            this.cBoxID = new System.Windows.Forms.ComboBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblAnschrift = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cBoxAnrede = new System.Windows.Forms.ComboBox();
            this.txtAnschrift = new System.Windows.Forms.TextBox();
            this.TBoxName = new System.Windows.Forms.TextBox();
            this.dGView = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtPStdSum = new System.Windows.Forms.TextBox();
            this.txtPLohnSum = new System.Windows.Forms.TextBox();
            this.txtPLohnStd = new System.Windows.Forms.TextBox();
            this.gBoxProj = new System.Windows.Forms.GroupBox();
            this.txtMID = new System.Windows.Forms.TextBox();
            this.cBoxPID2 = new System.Windows.Forms.ComboBox();
            this.dTPEinsatz = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPAccept = new System.Windows.Forms.Button();
            this.btnPCreate = new System.Windows.Forms.Button();
            this.btnPEdit = new System.Windows.Forms.Button();
            this.txtEinStd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gBoxMit = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cBoxMID2 = new System.Windows.Forms.ComboBox();
            this.txtLohn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.btnMDelete = new System.Windows.Forms.Button();
            this.btnMEdit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMAccept = new System.Windows.Forms.Button();
            this.btnMCreate = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPStdSatz = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            this.gBoxProj.SuspendLayout();
            this.gBoxMit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 23);
            this.label1.TabIndex = 17;
            this.label1.Text = "Projekt";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxKID
            // 
            this.cBoxKID.FormattingEnabled = true;
            this.cBoxKID.Location = new System.Drawing.Point(221, 85);
            this.cBoxKID.Name = "cBoxKID";
            this.cBoxKID.Size = new System.Drawing.Size(59, 21);
            this.cBoxKID.TabIndex = 14;
            this.cBoxKID.SelectedIndexChanged += new System.EventHandler(this.cBoxKID_SelectedIndexChanged);
            this.cBoxKID.TextUpdate += new System.EventHandler(this.cBoxKID_SelectedIndexChanged);
            this.cBoxKID.TextChanged += new System.EventHandler(this.cBoxKID_SelectedIndexChanged);
            // 
            // lblEnde
            // 
            this.lblEnde.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblEnde.Location = new System.Drawing.Point(12, 107);
            this.lblEnde.Name = "lblEnde";
            this.lblEnde.Size = new System.Drawing.Size(203, 23);
            this.lblEnde.TabIndex = 12;
            this.lblEnde.Text = "Projekt Ende\r\n";
            this.lblEnde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBeginn
            // 
            this.lblBeginn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblBeginn.Location = new System.Drawing.Point(12, 59);
            this.lblBeginn.Name = "lblBeginn";
            this.lblBeginn.Size = new System.Drawing.Size(203, 23);
            this.lblBeginn.TabIndex = 11;
            this.lblBeginn.Text = "Projekt Beginn\r\n";
            this.lblBeginn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTPEnde
            // 
            this.dateTPEnde.Location = new System.Drawing.Point(12, 133);
            this.dateTPEnde.Name = "dateTPEnde";
            this.dateTPEnde.Size = new System.Drawing.Size(203, 20);
            this.dateTPEnde.TabIndex = 10;
            this.dateTPEnde.Value = new System.DateTime(2022, 6, 9, 10, 55, 58, 0);
            // 
            // lblKID
            // 
            this.lblKID.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblKID.Location = new System.Drawing.Point(220, 59);
            this.lblKID.Name = "lblKID";
            this.lblKID.Size = new System.Drawing.Size(202, 23);
            this.lblKID.TabIndex = 13;
            this.lblKID.Text = "Kunde";
            this.lblKID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTPBeginn
            // 
            this.dateTPBeginn.Location = new System.Drawing.Point(11, 81);
            this.dateTPBeginn.Name = "dateTPBeginn";
            this.dateTPBeginn.Size = new System.Drawing.Size(203, 20);
            this.dateTPBeginn.TabIndex = 9;
            this.dateTPBeginn.Value = new System.DateTime(2022, 6, 9, 0, 0, 0, 0);
            // 
            // cBoxID
            // 
            this.cBoxID.FormattingEnabled = true;
            this.cBoxID.Location = new System.Drawing.Point(12, 35);
            this.cBoxID.Name = "cBoxID";
            this.cBoxID.Size = new System.Drawing.Size(47, 21);
            this.cBoxID.TabIndex = 15;
            this.cBoxID.SelectedIndexChanged += new System.EventHandler(this.cBoxID_SelectedIndexChanged);
            this.cBoxID.TextUpdate += new System.EventHandler(this.cBoxID_SelectedIndexChanged);
            this.cBoxID.TextChanged += new System.EventHandler(this.cBoxID_SelectedIndexChanged);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Yellow;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(959, 490);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(59, 58);
            this.btnReload.TabIndex = 14;
            this.btnReload.Text = "R";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblAnschrift
            // 
            this.lblAnschrift.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblAnschrift.Location = new System.Drawing.Point(428, 59);
            this.lblAnschrift.Name = "lblAnschrift";
            this.lblAnschrift.Size = new System.Drawing.Size(126, 23);
            this.lblAnschrift.TabIndex = 8;
            this.lblAnschrift.Text = "Anschrift";
            this.lblAnschrift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblName.Location = new System.Drawing.Point(286, 108);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(136, 23);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Orange;
            this.txtName.Location = new System.Drawing.Point(286, 134);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(136, 20);
            this.txtName.TabIndex = 3;
            // 
            // cBoxAnrede
            // 
            this.cBoxAnrede.BackColor = System.Drawing.Color.Orange;
            this.cBoxAnrede.FormattingEnabled = true;
            this.cBoxAnrede.Items.AddRange(new object[] { "Firma", "Herr", "Frau", "Sonstiges" });
            this.cBoxAnrede.Location = new System.Drawing.Point(286, 84);
            this.cBoxAnrede.Name = "cBoxAnrede";
            this.cBoxAnrede.Size = new System.Drawing.Size(136, 21);
            this.cBoxAnrede.TabIndex = 2;
            this.cBoxAnrede.Text = "Anrede";
            // 
            // txtAnschrift
            // 
            this.txtAnschrift.BackColor = System.Drawing.Color.Orange;
            this.txtAnschrift.Location = new System.Drawing.Point(428, 84);
            this.txtAnschrift.Multiline = true;
            this.txtAnschrift.Name = "txtAnschrift";
            this.txtAnschrift.Size = new System.Drawing.Size(126, 69);
            this.txtAnschrift.TabIndex = 7;
            // 
            // TBoxName
            // 
            this.TBoxName.Location = new System.Drawing.Point(65, 35);
            this.TBoxName.Name = "TBoxName";
            this.TBoxName.Size = new System.Drawing.Size(215, 20);
            this.TBoxName.TabIndex = 15;
            // 
            // dGView
            // 
            this.dGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView.Location = new System.Drawing.Point(12, 159);
            this.dGView.Name = "dGView";
            this.dGView.Size = new System.Drawing.Size(466, 267);
            this.dGView.TabIndex = 18;
            this.dGView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGView_CellContentClick);
            this.dGView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGView_CellMouseClick);
            this.dGView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGView_CellMouseDoubleClick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Maroon;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExit.Location = new System.Drawing.Point(1024, 490);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 58);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(560, 106);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(59, 47);
            this.btnChange.TabIndex = 20;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtPStdSum
            // 
            this.txtPStdSum.Location = new System.Drawing.Point(15, 478);
            this.txtPStdSum.Name = "txtPStdSum";
            this.txtPStdSum.ReadOnly = true;
            this.txtPStdSum.Size = new System.Drawing.Size(124, 20);
            this.txtPStdSum.TabIndex = 21;
            this.txtPStdSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPLohnSum
            // 
            this.txtPLohnSum.Location = new System.Drawing.Point(145, 501);
            this.txtPLohnSum.Name = "txtPLohnSum";
            this.txtPLohnSum.ReadOnly = true;
            this.txtPLohnSum.Size = new System.Drawing.Size(124, 20);
            this.txtPLohnSum.TabIndex = 22;
            this.txtPLohnSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPLohnStd
            // 
            this.txtPLohnStd.Location = new System.Drawing.Point(145, 453);
            this.txtPLohnStd.Name = "txtPLohnStd";
            this.txtPLohnStd.ReadOnly = true;
            this.txtPLohnStd.Size = new System.Drawing.Size(124, 20);
            this.txtPLohnStd.TabIndex = 23;
            this.txtPLohnStd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gBoxProj
            // 
            this.gBoxProj.Controls.Add(this.txtMID);
            this.gBoxProj.Controls.Add(this.cBoxPID2);
            this.gBoxProj.Controls.Add(this.dTPEinsatz);
            this.gBoxProj.Controls.Add(this.label4);
            this.gBoxProj.Controls.Add(this.label5);
            this.gBoxProj.Controls.Add(this.label3);
            this.gBoxProj.Controls.Add(this.btnPAccept);
            this.gBoxProj.Controls.Add(this.btnPCreate);
            this.gBoxProj.Controls.Add(this.btnPEdit);
            this.gBoxProj.Controls.Add(this.txtEinStd);
            this.gBoxProj.Controls.Add(this.label2);
            this.gBoxProj.Location = new System.Drawing.Point(484, 159);
            this.gBoxProj.Name = "gBoxProj";
            this.gBoxProj.Size = new System.Drawing.Size(295, 267);
            this.gBoxProj.TabIndex = 24;
            this.gBoxProj.TabStop = false;
            this.gBoxProj.Text = "Projekt";
            // 
            // txtMID
            // 
            this.txtMID.Location = new System.Drawing.Point(193, 95);
            this.txtMID.Name = "txtMID";
            this.txtMID.ReadOnly = true;
            this.txtMID.Size = new System.Drawing.Size(96, 20);
            this.txtMID.TabIndex = 42;
            // 
            // cBoxPID2
            // 
            this.cBoxPID2.FormattingEnabled = true;
            this.cBoxPID2.Location = new System.Drawing.Point(6, 94);
            this.cBoxPID2.Name = "cBoxPID2";
            this.cBoxPID2.Size = new System.Drawing.Size(64, 21);
            this.cBoxPID2.TabIndex = 41;
            this.cBoxPID2.SelectedIndexChanged += new System.EventHandler(this.cBoxPID2_SelectedIndexChanged);
            this.cBoxPID2.TextUpdate += new System.EventHandler(this.cBoxPID2_SelectedIndexChanged);
            this.cBoxPID2.TextChanged += new System.EventHandler(this.cBoxPID2_SelectedIndexChanged);
            // 
            // dTPEinsatz
            // 
            this.dTPEinsatz.Enabled = false;
            this.dTPEinsatz.Location = new System.Drawing.Point(6, 143);
            this.dTPEinsatz.Name = "dTPEinsatz";
            this.dTPEinsatz.Size = new System.Drawing.Size(181, 20);
            this.dTPEinsatz.TabIndex = 31;
            this.dTPEinsatz.Value = new System.DateTime(2022, 6, 9, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(6, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Einsatz Datum";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(193, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 33;
            this.label5.Text = "Mitarbeiter";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(76, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Einsatz Std";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPAccept
            // 
            this.btnPAccept.BackColor = System.Drawing.Color.MistyRose;
            this.btnPAccept.Enabled = false;
            this.btnPAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPAccept.Location = new System.Drawing.Point(230, 203);
            this.btnPAccept.Name = "btnPAccept";
            this.btnPAccept.Size = new System.Drawing.Size(59, 58);
            this.btnPAccept.TabIndex = 26;
            this.btnPAccept.Text = "A";
            this.btnPAccept.UseVisualStyleBackColor = false;
            this.btnPAccept.Click += new System.EventHandler(this.btnPAccept_Click);
            // 
            // btnPCreate
            // 
            this.btnPCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCreate.Location = new System.Drawing.Point(6, 19);
            this.btnPCreate.Name = "btnPCreate";
            this.btnPCreate.Size = new System.Drawing.Size(140, 47);
            this.btnPCreate.TabIndex = 27;
            this.btnPCreate.Text = "Create";
            this.btnPCreate.UseVisualStyleBackColor = true;
            this.btnPCreate.Click += new System.EventHandler(this.btnPCreate_Click);
            // 
            // btnPEdit
            // 
            this.btnPEdit.Enabled = false;
            this.btnPEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPEdit.Location = new System.Drawing.Point(160, 17);
            this.btnPEdit.Name = "btnPEdit";
            this.btnPEdit.Size = new System.Drawing.Size(129, 47);
            this.btnPEdit.TabIndex = 26;
            this.btnPEdit.Text = "Edit";
            this.btnPEdit.UseVisualStyleBackColor = true;
            this.btnPEdit.Click += new System.EventHandler(this.btnPEdit_Click);
            // 
            // txtEinStd
            // 
            this.txtEinStd.Location = new System.Drawing.Point(76, 95);
            this.txtEinStd.Name = "txtEinStd";
            this.txtEinStd.ReadOnly = true;
            this.txtEinStd.Size = new System.Drawing.Size(111, 20);
            this.txtEinStd.TabIndex = 19;
            this.txtEinStd.TextChanged += new System.EventHandler(this.txtEinStd_TextChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 20;
            this.label2.Text = "Projekt";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBoxMit
            // 
            this.gBoxMit.Controls.Add(this.label8);
            this.gBoxMit.Controls.Add(this.cBoxMID2);
            this.gBoxMit.Controls.Add(this.txtLohn);
            this.gBoxMit.Controls.Add(this.label6);
            this.gBoxMit.Controls.Add(this.txtMName);
            this.gBoxMit.Controls.Add(this.btnMDelete);
            this.gBoxMit.Controls.Add(this.btnMEdit);
            this.gBoxMit.Controls.Add(this.label7);
            this.gBoxMit.Controls.Add(this.btnMAccept);
            this.gBoxMit.Controls.Add(this.btnMCreate);
            this.gBoxMit.Location = new System.Drawing.Point(785, 159);
            this.gBoxMit.Name = "gBoxMit";
            this.gBoxMit.Size = new System.Drawing.Size(295, 267);
            this.gBoxMit.TabIndex = 25;
            this.gBoxMit.TabStop = false;
            this.gBoxMit.Text = "Mitarbeiter";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(6, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 23);
            this.label8.TabIndex = 41;
            this.label8.Text = "Mitarbeiter";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cBoxMID2
            // 
            this.cBoxMID2.FormattingEnabled = true;
            this.cBoxMID2.Location = new System.Drawing.Point(6, 93);
            this.cBoxMID2.Name = "cBoxMID2";
            this.cBoxMID2.Size = new System.Drawing.Size(140, 21);
            this.cBoxMID2.TabIndex = 40;
            this.cBoxMID2.SelectedIndexChanged += new System.EventHandler(this.cBoxMID_SelectedIndexChanged);
            this.cBoxMID2.TextUpdate += new System.EventHandler(this.cBoxMID_SelectedIndexChanged);
            this.cBoxMID2.TextChanged += new System.EventHandler(this.cBoxMID_SelectedIndexChanged);
            // 
            // txtLohn
            // 
            this.txtLohn.Location = new System.Drawing.Point(160, 143);
            this.txtLohn.Name = "txtLohn";
            this.txtLohn.ReadOnly = true;
            this.txtLohn.Size = new System.Drawing.Size(129, 20);
            this.txtLohn.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(160, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "€ / Std";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(6, 143);
            this.txtMName.Name = "txtMName";
            this.txtMName.ReadOnly = true;
            this.txtMName.Size = new System.Drawing.Size(140, 20);
            this.txtMName.TabIndex = 27;
            // 
            // btnMDelete
            // 
            this.btnMDelete.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnMDelete.Enabled = false;
            this.btnMDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMDelete.Location = new System.Drawing.Point(6, 203);
            this.btnMDelete.Name = "btnMDelete";
            this.btnMDelete.Size = new System.Drawing.Size(59, 58);
            this.btnMDelete.TabIndex = 36;
            this.btnMDelete.Text = "Delete";
            this.btnMDelete.UseVisualStyleBackColor = false;
            this.btnMDelete.Click += new System.EventHandler(this.btnMDel_Click);
            // 
            // btnMEdit
            // 
            this.btnMEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMEdit.Location = new System.Drawing.Point(160, 17);
            this.btnMEdit.Name = "btnMEdit";
            this.btnMEdit.Size = new System.Drawing.Size(129, 47);
            this.btnMEdit.TabIndex = 34;
            this.btnMEdit.Text = "Edit";
            this.btnMEdit.UseVisualStyleBackColor = true;
            this.btnMEdit.Click += new System.EventHandler(this.btnMEdit_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(6, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Mitarbeiter Name";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMAccept
            // 
            this.btnMAccept.BackColor = System.Drawing.Color.MistyRose;
            this.btnMAccept.Enabled = false;
            this.btnMAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMAccept.Location = new System.Drawing.Point(230, 203);
            this.btnMAccept.Name = "btnMAccept";
            this.btnMAccept.Size = new System.Drawing.Size(59, 58);
            this.btnMAccept.TabIndex = 35;
            this.btnMAccept.Text = "A";
            this.btnMAccept.UseVisualStyleBackColor = false;
            this.btnMAccept.Click += new System.EventHandler(this.btnMAccept_Click);
            // 
            // btnMCreate
            // 
            this.btnMCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMCreate.Location = new System.Drawing.Point(6, 19);
            this.btnMCreate.Name = "btnMCreate";
            this.btnMCreate.Size = new System.Drawing.Size(140, 47);
            this.btnMCreate.TabIndex = 37;
            this.btnMCreate.Text = "Create";
            this.btnMCreate.UseVisualStyleBackColor = true;
            this.btnMCreate.Click += new System.EventHandler(this.btnMCreate_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(12, 455);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Arbeitsstunden";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(145, 478);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Löhne Insg.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(275, 455);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Stundensatz";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPStdSatz
            // 
            this.txtPStdSatz.Location = new System.Drawing.Point(275, 478);
            this.txtPStdSatz.Name = "txtPStdSatz";
            this.txtPStdSatz.ReadOnly = true;
            this.txtPStdSatz.Size = new System.Drawing.Size(124, 20);
            this.txtPStdSatz.TabIndex = 29;
            this.txtPStdSatz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label12.Location = new System.Drawing.Point(145, 430);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Löhne €/std";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjektVerwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1102, 560);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPStdSatz);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gBoxMit);
            this.Controls.Add(this.gBoxProj);
            this.Controls.Add(this.txtPLohnStd);
            this.Controls.Add(this.txtPLohnSum);
            this.Controls.Add(this.txtPStdSum);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dGView);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.TBoxName);
            this.Controls.Add(this.lblAnschrift);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cBoxKID);
            this.Controls.Add(this.cBoxAnrede);
            this.Controls.Add(this.txtAnschrift);
            this.Controls.Add(this.cBoxID);
            this.Controls.Add(this.lblEnde);
            this.Controls.Add(this.dateTPBeginn);
            this.Controls.Add(this.lblBeginn);
            this.Controls.Add(this.lblKID);
            this.Controls.Add(this.dateTPEnde);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "ProjektVerwaltung";
            this.Text = "Projekt Verwaltung";
            this.Load += new System.EventHandler(this.ProjektVerwaltung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
            this.gBoxProj.ResumeLayout(false);
            this.gBoxProj.PerformLayout();
            this.gBoxMit.ResumeLayout(false);
            this.gBoxMit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPStdSatz;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.TextBox txtMID;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cBoxMID2;

        private System.Windows.Forms.ComboBox cBoxPID2;

        private System.Windows.Forms.TextBox txtEinStd;

        private System.Windows.Forms.Button btnMDelete;
        private System.Windows.Forms.Button btnMAccept;
        private System.Windows.Forms.Button btnMCreate;
        private System.Windows.Forms.Button btnMEdit;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLohn;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTPEinsatz;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Button btnPEdit;
        private System.Windows.Forms.Button btnPCreate;
        private System.Windows.Forms.Button btnPAccept;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.GroupBox gBoxMit;

        private System.Windows.Forms.GroupBox gBoxProj;

        private System.Windows.Forms.TextBox txtPStdSum;
        private System.Windows.Forms.TextBox txtPLohnSum;
        private System.Windows.Forms.TextBox txtPLohnStd;

        private System.Windows.Forms.Button btnReload;

        private System.Windows.Forms.Button btnChange;

        private System.Windows.Forms.Button btnExit;

        private System.Windows.Forms.DataGridView dGView;

        private System.Windows.Forms.Label lblAnschrift;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cBoxAnrede;
        private System.Windows.Forms.TextBox txtAnschrift;

        private System.Windows.Forms.TextBox TBoxName;
        private System.Windows.Forms.ComboBox cBoxID;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.ComboBox cBoxKID;
        private System.Windows.Forms.Label lblBeginn;
        private System.Windows.Forms.Label lblKID;
        private System.Windows.Forms.DateTimePicker dateTPBeginn;
        private System.Windows.Forms.DateTimePicker dateTPEnde;
        private System.Windows.Forms.Label lblEnde;

        #endregion
    }
}