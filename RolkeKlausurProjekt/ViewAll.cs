using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace RolkeKlausurProjekt
{
    public partial class ViewAll : Form
    {
        DataSet ds = new DataSet();
        OleDbConnection con = new OleDbConnection();
        public OleDbDataAdapter DataAdapt;
        public OleDbDataReader dr;
        public OleDbCommand cmd;
        private int kdnr;
        public bool AlleVerwalten = false, edit = false, create = false;
        string plzB, nameB, addrB;
        DataConfig DC = new DataConfig();
        public ViewAll()
        {
            InitializeComponent();
        }

        private void ViewAll_Load(object sender, EventArgs e)
            //Form Load method for the FormClass ViewAll
        {
            try
            {
                try
                {
                    con.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.16.0;Data Source=ProjKlausurRolke.accdb";
                    con.Open();
                }
                catch
                {
                    con.ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjKlausurRolke.accdb";
                    con.Open();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                throw;
            }
        }
        private void btnKunden_Click(object sender, EventArgs e) //DataGridView Kunden
        {
            DataAdapt = new OleDbDataAdapter($"Select * from Kunden", con);
            ds.Clear();
            DataAdapt.Fill(ds, "Kunden");
            dGView.DataSource = ds;
            dGView.DataSource = ds;
            dGView.DataMember = "Kunden";
            ReplaceColumsK();
            DC.mitarb = false;
            DC.proj = false;
            DC.kund = true;
            DC.kunden();
        }
        private void ReplaceColumsK() //DataGridView Kunden Ersetze Spalten
        {
            dGView.Columns.Remove("KID");
            DataGridViewTextBoxColumn tb0_kid = new DataGridViewTextBoxColumn();
            tb0_kid.DataPropertyName = "KID";
            tb0_kid.HeaderText = "Kunden-Nr";
            tb0_kid.DisplayIndex = 0;
            tb0_kid.ToolTipText = "Dies ist die Kundennummer sowie der eindeutige Tabellenschlüssel";
            tb0_kid.ReadOnly = true;
            dGView.Columns.Add(tb0_kid);
            
            dGView.Columns.Remove("kname");
            DataGridViewTextBoxColumn tb1_kname = new DataGridViewTextBoxColumn();
            tb1_kname.DataPropertyName = "kname";
            tb1_kname.HeaderText = "Name";
            tb1_kname.DisplayIndex = 1;
            dGView.Columns.Add(tb1_kname);

            dGView.Columns.Remove("kanrede");
            DataGridViewTextBoxColumn tb2_Anrede = new DataGridViewTextBoxColumn();
            tb2_Anrede.DataPropertyName = "kanrede";
            tb2_Anrede.HeaderText = "Anrede";
            tb2_Anrede.DisplayIndex = 2;
            dGView.Columns.Add(tb2_Anrede);
            
            dGView.Columns.Remove("kanschrift");
            DataGridViewTextBoxColumn tb4_kanschrift = new DataGridViewTextBoxColumn();
            tb4_kanschrift.DataPropertyName = "kanschrift";
            tb4_kanschrift.HeaderText = "Anschrift";
            dGView.Columns.Add(tb4_kanschrift);
        }
        
        private void btnMitarbeiter_Click(object sender, EventArgs e) //DataGridView Mitarbeiter
        {
            DataAdapt = new OleDbDataAdapter($"Select * from Mitarbeiter", con);
            ds.Clear();
            DataAdapt.Fill(ds, "Mitarbeiter");
            dGView.DataSource = ds;
            dGView.DataMember = "Mitarbeiter";
            ReplaceColumsM();
            DC.mitarb = true;
            DC.proj = false;
            DC.kund = false;
            DC.mitarbeiter();
        }
        private void ReplaceColumsM() //DataGridView Mitarbeiter Ersetze Spalten
        {
            dGView.Columns.Remove("MID");
            DataGridViewTextBoxColumn tb0_MID = new DataGridViewTextBoxColumn();
            tb0_MID.DataPropertyName = "MID";
            tb0_MID.HeaderText = "Mitarbeiter-Nr";
            tb0_MID.DisplayIndex = 0;
            tb0_MID.ToolTipText = "Dies ist die Mitarbeiternummer sowie der eindeutige Tabellenschlüssel";
            tb0_MID.ReadOnly = true;
            dGView.Columns.Add(tb0_MID);
            
            dGView.Columns.Remove("MName");
            DataGridViewTextBoxColumn tb1_MName = new DataGridViewTextBoxColumn();
            tb1_MName.DataPropertyName = "MName";
            tb1_MName.HeaderText = "Name";
            tb1_MName.DisplayIndex = 1;
            dGView.Columns.Add(tb1_MName);

            dGView.Columns.Remove("MStdLohn");
            DataGridViewTextBoxColumn tb2_MStdLohn = new DataGridViewTextBoxColumn();
            tb2_MStdLohn.DataPropertyName = "MStdLohn";
            tb2_MStdLohn.HeaderText = "Lohn";
            tb2_MStdLohn.DisplayIndex = 2;
            dGView.Columns.Add(tb2_MStdLohn);
        }

        private void btnProjekte_Click(object sender, EventArgs e) //DataGridView Projekte
        {
            DataAdapt = new OleDbDataAdapter($"Select * from Projekte", con);
            ds.Clear();
            DataAdapt.Fill(ds, "Projekte");
            dGView.DataSource = ds;
            dGView.DataMember = "Projekte";
            ReplaceColumsP();
            DC.mitarb = false;
            DC.proj = true;
            DC.kund = false;
            DC.projekte();
        }
        private void ReplaceColumsP() //DataGridView Projekte Ersetze Spalten
        {
            dGView.Columns.Remove("PID");
            DataGridViewTextBoxColumn tb0_kid = new DataGridViewTextBoxColumn();
            tb0_kid.DataPropertyName = "KID";
            tb0_kid.HeaderText = "Projekt-Nr";
            tb0_kid.DisplayIndex = 0;
            tb0_kid.ToolTipText = "Dies ist die Projektnummer sowie der eindeutige Tabellenschlüssel";
            tb0_kid.ReadOnly = true;
            dGView.Columns.Add(tb0_kid);
            
            dGView.Columns.Remove("PName");
            DataGridViewTextBoxColumn tb1_PName = new DataGridViewTextBoxColumn();
            tb1_PName.DataPropertyName = "PName";
            tb1_PName.HeaderText = "Name";
            tb1_PName.DisplayIndex = 1;
            dGView.Columns.Add(tb1_PName);

            dGView.Columns.Remove("PBeginn");
            DataGridViewTextBoxColumn tb2_PBeginn = new DataGridViewTextBoxColumn();
            tb2_PBeginn.DataPropertyName = "PBeginn";
            tb2_PBeginn.HeaderText = "Projekt-Beginn";
            tb2_PBeginn.DisplayIndex = 2;
            dGView.Columns.Add(tb2_PBeginn);
            
            dGView.Columns.Remove("PEnde");
            DataGridViewTextBoxColumn tb3_PEnde = new DataGridViewTextBoxColumn();
            tb3_PEnde.DataPropertyName = "PEnde";
            tb3_PEnde.HeaderText = "Projekt-Ende";
            tb3_PEnde.DisplayIndex = 3;
            dGView.Columns.Add(tb3_PEnde);
            
            dGView.Columns.Remove("PKID");
            DataGridViewTextBoxColumn tb4_PKID = new DataGridViewTextBoxColumn();
            tb4_PKID.DataPropertyName = "PKID";
            tb4_PKID.HeaderText = "Kunden-Nr";
            tb0_kid.ToolTipText = "Dies ist die Kundennummer die sich auf die Kundennummer in der Tabelle Kunden Bezieht";
            tb4_PKID.DisplayIndex = 4;
            dGView.Columns.Add(tb4_PKID);
        }

        private void btnEdit_Click(object sender, EventArgs e) //Button to open the editor
        {
            DC.btnKunden.Text = "Edit";
            DC.btnMitarbeiter.Text = "Create";
            DC.btnProjekte.Text = "Delete";
            DC.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e) //Exit Button
        {
            Close();
        }
    }
}