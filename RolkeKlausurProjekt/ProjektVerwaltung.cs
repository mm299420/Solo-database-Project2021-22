using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace RolkeKlausurProjekt
{
    public partial class ProjektVerwaltung : Form
    {
        DataSet ds = new DataSet();
        public OleDbDataAdapter DataAdapt;
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        private OleDbCommand cmdID;
        private bool proj = false, mitarb = false, kund = false;
        private bool create = false, edit = false, del = false, IDselect = true;
        private string PName, dateEinStd;
        DateTime dateB, dateE, dateEin;
        private int ID, KID, PID, PMID, MID;
        
        public ProjektVerwaltung()
        {
            InitializeComponent();
        }

        private void ProjektVerwaltung_Load(object sender, EventArgs e) //Form Load Method for FormsClass ProjektVerwaltung
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
            try
            {
                DataAdapt = new OleDbDataAdapter($"Select * from ProjektVerwaltung", con);
                cmd = new OleDbCommand("select * from ProjektVerwaltung", con);
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    dr.Read();
                }
                try
                {
                    ds.Clear();
                    DataAdapt.Fill(ds, "ProjektVerwaltung");
                    dGView.DataSource = ds;
                    dGView.DataMember = "ProjektVerwaltung";
                    ReplaceColumns();
                }
                catch
                {}
                
                
                proj = true;
                cmd = new OleDbCommand("select * from Projekte", con);
                dr = cmd.ExecuteReader();
                cBoxID.Update();
                cBoxID.Items.Clear();
                while (dr.Read())
                {
                    cBoxID.Items.Add(dr["PID".ToString()]);
                }
                cBoxID.SelectedIndex = 0;
                cBoxID.EndUpdate();
                
                cmd = new OleDbCommand("select * from Mitarbeiter", con); 
                dr = cmd.ExecuteReader();
                cBoxMID2.Update();
                cBoxMID2.Items.Clear();
                while (dr.Read())
                {
                    cBoxMID2.Items.Add(dr["MID".ToString()]);
                }
                cBoxMID2.EndUpdate();
                cBoxMID2.SelectedIndex = 0;
                
                cmd = new OleDbCommand($"select * from Kunden", con);
                dr = cmd.ExecuteReader();
            
                cBoxKID.Update();
                cBoxKID.Items.Clear();
                while (dr.Read())
                {
                    cBoxKID.Items.Add(dr["KID".ToString()]);
                }
                cBoxKID.EndUpdate();
                load();
            }
            catch (Exception M)
            {
                MessageBox.Show(M.ToString());
            }
        }
        

        private void cBoxID_SelectedIndexChanged(object sender, EventArgs e) 
        //we want to manipulate all the objects wich are using and showing the ProjectID whenever a change in This ComboBox occourd (is conected as eventhandler for SelectedIndexChanged, TextChanged & TextUpdates)
        {
            List<string> MIDLohnMID = new List<string>();
            List<string> MIDSumStd = new List<string>();
            string lohn;
            int LohnCountStd = 0;
            int std;
            int i=0;
            try
            {
                load();
                cBoxPID2.Text = cBoxID.Text;
            
                cmd = new OleDbCommand($"select sum(PEinStd) as Gesamtstunden from ProjektVerwaltung where PID2={ID}", con); //Gesamtstunden
                dr = cmd.ExecuteReader();
                dr.Read();
            
                txtPStdSum.Text = dr["Gesamtstunden".ToString()].ToString();
                txtPStdSum.Text += " std.";
                std = Convert.ToInt16(dr["Gesamtstunden".ToString()].ToString());
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }

            try
            {
                cmd = new OleDbCommand($"select sum(PEinStd) as Gesamtstunden, PMID from ProjektVerwaltung where PID2={ID} group by PMID", con); //select the total sum of hours
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MIDLohnMID.Add(dr["PMID".ToString()].ToString());
                    MIDSumStd.Add(dr["Gesamtstunden".ToString()].ToString());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }

            try
            {
                foreach (var a in MIDLohnMID)
                {
                    cmd = new OleDbCommand($"select MStdLohn from Mitarbeiter where MID={Convert.ToInt16(a)}", //counting all the wages per hour of the employed employees
                        con); //Gesamtstunden
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    lohn = dr["MStdLohn".ToString()].ToString();
                    LohnCountStd += Convert.ToInt16(lohn);
                    i++;
                }
            }
            catch
            {
                
            }
            
            txtPLohnStd.Text = LohnCountStd.ToString(); //Count all wages per hour along with total hours worked from the selected project
            txtPLohnStd.Text += " €/Std.";
            
            txtPLohnSum.Text = (LohnCountStd * std).ToString();
            txtPLohnSum.Text += " €";
        }

        void load() //load method to load and refresh all the informations we read
        {
            try
            {
                ID = Convert.ToInt16(cBoxID.Text);
                try
                {
                    cmd = new OleDbCommand($"select * from Projekte", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    dateB = Convert.ToDateTime(dr["PBeginn".ToString()]);
                    dateE = Convert.ToDateTime(dr["PEnde".ToString()]);
                    cBoxKID.Text = dr["pkid".ToString()].ToString();
                    TBoxName.Text = dr["PName".ToString()].ToString();
                    KID = Convert.ToInt16(cBoxKID.Text);
                    dateTPBeginn.Value = dateB;
                    dateTPEnde.Value = dateE;
                    
                    
                    DataAdapt = new OleDbDataAdapter($"Select * from ProjektVerwaltung where pid2={ID}", con);
                    ds.Clear();
                    DataAdapt.Fill(ds, "ProjektVerwaltung");
                    dGView.DataSource = ds;
                    dGView.DataMember = "ProjektVerwaltung";
                    ReplaceColumns();
                }
                catch
                {
                    cmd = new OleDbCommand($"select * from Projekte where pid={ID}", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                
                        
                    dateB = Convert.ToDateTime(dr["PBeginn".ToString()]);
                    dateE = Convert.ToDateTime(dr["PEnde".ToString()]);
                    cBoxKID.Text = dr["pkid".ToString()].ToString();
                    TBoxName.Text = dr["PName".ToString()].ToString();
                    KID = Convert.ToInt16(cBoxKID.Text);
                    dateTPBeginn.Value = dateB;
                    dateTPEnde.Value = dateE;
                }
                
                
                try
                {
                    cmd = new OleDbCommand($"select * from Kunden where kid={KID}", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                        
                    cBoxAnrede.Text = dr["kanrede".ToString()].ToString();
                    txtName.Text = dr["kname".ToString()].ToString();
                    txtAnschrift.Text = dr["kanschrift".ToString()].ToString();
                }
                catch
                {
                }
            }
            catch
            {
                ID = Convert.ToInt16(cBoxID.Text);
            }
        }

        private void cBoxKID_SelectedIndexChanged(object sender, EventArgs e) 
        //We want to manipulate all the objects which are showing the customerID when change occurs in This ComboBox (is connected as event handler for SelectedIndexChanged, TextChanged & TextUpdates).
        {
            KID = Convert.ToInt16(cBoxKID.Text);
            cmd = new OleDbCommand($"select * from Kunden where kid={KID}", con);
            dr = cmd.ExecuteReader();
            dr.Read();
                    
            cBoxAnrede.Text = dr["kanrede".ToString()].ToString();
            txtName.Text = dr["kname".ToString()].ToString();
            txtAnschrift.Text = dr["kanschrift".ToString()].ToString();
        }

        void updateKunde() //Update costumer sql entry
        {
            cmd = new OleDbCommand($"UPDATE kunden SET kanschrift='{txtAnschrift.Text}', kname='{txtName.Text}', kanrede='{cBoxAnrede.Text}' WHERE KID={KID}", con);
            cmd.ExecuteNonQuery();
            dr.Read();
        }

        void updateProjekt() //Update project sql entry 
        {
            cmd = new OleDbCommand(
                $"UPDATE projekte SET PBeginn='{dateTPBeginn.Value}', PEnde='{dateTPEnde.Value}', PName='{TBoxName.Text}', PKID={KID} WHERE PID={ID}",
                con);
            cmd.ExecuteNonQuery();
            dr.Read();
        }

        private void btnExit_Click(object sender, EventArgs e) //Exit button
        {
            Close();
        }

        private void btnReload_Click(object sender, EventArgs e) //Reload SQL
        {
            TBoxName.Text = "";
            try
            {
                ID = Convert.ToInt16(cBoxID.Text);
                cmd = new OleDbCommand($"select * from Projekte where pid={ID}", con);
                dr = cmd.ExecuteReader();
                dr.Read();
            
                    
                dateB = Convert.ToDateTime(dr["PBeginn".ToString()]);
                dateE = Convert.ToDateTime(dr["PEnde".ToString()]);
                cBoxKID.Text = dr["pkid".ToString()].ToString();
                TBoxName.Text = dr["PName".ToString()].ToString();
                KID = Convert.ToInt16(cBoxKID.Text);
                dateTPBeginn.Value = dateB;
                dateTPEnde.Value = dateE;
                
            }
            catch
            {
                ID = Convert.ToInt16(cBoxID.Text);
                cmd = new OleDbCommand($"select * from Projekte where pid={ID}", con);
                dr = cmd.ExecuteReader();
                dr.Read();
            
                    
                dateB = Convert.ToDateTime(dr["PBeginn".ToString()]);
                dateE = Convert.ToDateTime(dr["PEnde".ToString()]);
                cBoxKID.Text = dr["pkid".ToString()].ToString();
                TBoxName.Text = dr["PName".ToString()].ToString();
                KID = Convert.ToInt16(cBoxKID.Text);
                dateTPBeginn.Value = dateB;
                dateTPEnde.Value = dateE;
            }
            
            
            try
            {
                cmd = new OleDbCommand($"select * from Kunden where kid={KID}", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                    
                cBoxAnrede.Text = dr["kanrede".ToString()].ToString();
                txtName.Text = dr["kname".ToString()].ToString();
                txtAnschrift.Text = dr["kanschrift".ToString()].ToString();
            }
            catch
            {
            }
        }

        private void btnChange_Click(object sender, EventArgs e) 
        //button to edit the costumer and update the informations on the database
        {
            updateProjekt();
            updateKunde();
        }

        private void dGView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) 
        //DataGridView Mouse Click, save the values from the selected rows and cells in existing variables
        {
            PID = Convert.ToInt16(dGView.SelectedRows[0].Cells[0].Value.ToString());
            PMID = Convert.ToInt16(dGView.SelectedRows[0].Cells[1].Value.ToString());
            gBoxProj.Enabled = true;
        }
        private void dGView_CellContentClick(object sender, DataGridViewCellEventArgs e) //select a cell 
        {
            try
            {
                try
                {

                }
                catch
                {
                    
                }
            }
            catch
            {
            }
        }
        private void dGView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e) 
        //DataGridView Double Mouse Click, after selecting the rows and cells to use these Value to get read informations from the database
        {
            PID = Convert.ToInt16(dGView.SelectedRows[0].Cells[0].Value.ToString());
            PMID = Convert.ToInt16(dGView.SelectedRows[0].Cells[1].Value.ToString());
            dateEin = Convert.ToDateTime(dGView.SelectedRows[0].Cells[2].Value.ToString());
            dateEinStd = dGView.SelectedRows[0].Cells[3].Value.ToString();

            try
            {
                 txtMID.Text = PMID.ToString();
                 txtEinStd.Text = dateEinStd.ToString();
                 dTPEinsatz.Value = dateEin;
                 cBoxPID2.Text = PID.ToString();
                 
                 cmd = new OleDbCommand("select * from Mitarbeiter", con);
                 dr = cmd.ExecuteReader();
                 
                 cBoxMID2.Update();
                 cBoxMID2.Items.Clear();
                 while (dr.Read())
                 {
                     cBoxMID2.Items.Add(dr["MID".ToString()]);
                 }
                 cBoxMID2.Text = txtMID.Text;
                 cBoxMID2.EndUpdate();
                 
                 
                 var MID = Convert.ToInt16(txtMID.Text);
                 cmd = new OleDbCommand($"select * from Mitarbeiter where MID={MID}", con);
                 dr = cmd.ExecuteReader();
                 dr.Read();
            
                 txtLohn.Text = dr["MStdLohn".ToString()].ToString();
                 txtMName.Text = dr["MName".ToString()].ToString();
            }
            catch
            {
                cmd = new OleDbCommand($"select * from ProjektVerwaltung where PID2={ID}", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                txtEinStd.Text = dr["PEinStd".ToString()].ToString();
                txtMID.Text = dr["PMID".ToString()].ToString();
                dateEin = Convert.ToDateTime(dr["PEinDat".ToString()]);
                dTPEinsatz.Value = dateEin;
            }
        }
        private void ReplaceColumns() //replace the DataGridView columns 
        {
            dGView.Columns.Remove("PID2");
            DataGridViewTextBoxColumn tb0_pid2 = new DataGridViewTextBoxColumn();
            tb0_pid2.DataPropertyName = "PID2";
            tb0_pid2.HeaderText = "Projekt-ID";
            tb0_pid2.DisplayIndex = 0;
            tb0_pid2.ToolTipText = "Dies ist die Projekt Nummer & der Eindeutige Tabellenschlüssel";
            tb0_pid2.ReadOnly = true;
            dGView.Columns.Add(tb0_pid2);
            
            dGView.Columns.Remove("PMID");
            DataGridViewTextBoxColumn tb1_PMID = new DataGridViewTextBoxColumn();
            tb1_PMID.DataPropertyName = "PMID";
            tb1_PMID.HeaderText = "Mitarbeiter";
            tb1_PMID.DisplayIndex = 1;
            tb0_pid2.ToolTipText = "Dies ist die Mitarbeiter Nummer";
            dGView.Columns.Add(tb1_PMID);

            dGView.Columns.Remove("PEinDat");
            DataGridViewTextBoxColumn tb2_PEinDat = new DataGridViewTextBoxColumn();
            tb2_PEinDat.DataPropertyName = "PEinDat";
            tb2_PEinDat.HeaderText = "Einsatzdatum";
            tb2_PEinDat.DisplayIndex = 2;
            dGView.Columns.Add(tb2_PEinDat);
            
            dGView.Columns.Remove("PEinStd");
            DataGridViewTextBoxColumn tb3_PEinStd = new DataGridViewTextBoxColumn();
            tb3_PEinStd.DataPropertyName = "PEinStd";
            tb3_PEinStd.HeaderText = "EinsatzStunden";
            dGView.Columns.Add(tb3_PEinStd);
        }
        
        private void cBoxMID_SelectedIndexChanged(object sender, EventArgs e)
        /*
        we want to manipulate all the objects wich show the EmpleeID to change to the selected value
        whenever a change in This ComboBox occourd (is conected as eventhandler for SelectedIndexChanged, TextChanged & TextUpdates)
        */
        {
            MID = Convert.ToInt16(cBoxMID2.Text);
            if (gBoxProj.Enabled && (edit || create))
            {
                txtMID.Text = cBoxMID2.Text;
            }
            cmd = new OleDbCommand($"select * from Mitarbeiter where MID={MID}", con);
            dr = cmd.ExecuteReader();
            dr.Read();

            try
            {
                txtLohn.Text = dr["MStdLohn".ToString()].ToString();
                txtMName.Text = dr["MName".ToString()].ToString();
            }
            catch{}
        }

        private void btnPEdit_Click(object sender, EventArgs e) //Button project edit
        {
            txtMID.Enabled = true;
            txtEinStd.ReadOnly = false;
            dTPEinsatz.Enabled = true;
            btnPAccept.Enabled = true;
            
            cmd = new OleDbCommand("select * from Mitarbeiter", con);
            dr = cmd.ExecuteReader();
            txtMID.Text = dr["MID".ToString()].ToString();

            btnPEdit.Enabled = false;
            btnPCreate.Visible = false;
            
            edit = true;
        }

        private void btnPCreate_Click(object sender, EventArgs e) //Button project create
        {
            txtMID.ReadOnly = false;
            txtEinStd.ReadOnly = false;
            dTPEinsatz.Enabled = true;
            btnPAccept.Enabled = true;
            cBoxPID2.Enabled = true;

            try
            {
                txtEinStd.Text = "";
                dTPEinsatz.Value = DateTime.Now;
                txtMID.Text = "";
            }
            catch 
            {
            }

            try
            {
                cmd = new OleDbCommand("select * from Mitarbeiter", con); //select employee table and read the informations we wont
                dr = cmd.ExecuteReader();
                cBoxMID2.Update();
                cBoxMID2.Items.Clear();
                while (dr.Read())
                {
                    cBoxMID2.Items.Add(dr["MID".ToString()]);
                }
                cBoxMID2.EndUpdate();
                cBoxMID2.SelectedIndex = 0;
                txtMID.Text = cBoxMID2.Text;
                
                cmd = new OleDbCommand("select * from Projekte", con); //select project table and read the informations we wont
                dr = cmd.ExecuteReader();

                cBoxPID2.Update();
                cBoxPID2.Items.Clear();
                while (dr.Read())
                {
                    cBoxPID2.Items.Add(dr["PID".ToString()]);
                }
                cBoxPID2.EndUpdate();
            }
            catch{}
            
            btnPEdit.Visible = false;
            btnPCreate.Enabled = false;

            create = true;
        }

        private void btnPAccept_Click(object sender, EventArgs e) //Button project accept
        {
            try
            {
                if (edit)
                {
                    
                    cmd = new OleDbCommand(
                        $"UPDATE ProjektVerwaltung SET PEinDat='{dTPEinsatz.Value}', PEinStd={Convert.ToInt16(txtEinStd.Text)}, PMID={Convert.ToInt16(txtMID.Text)}, PID2={Convert.ToInt16(cBoxPID2.Text)} WHERE PID2={PID} and PMID={MID} and PEinDat='{dateEin}'",
                        con);
                    cmd.ExecuteNonQuery();
                    dr.Read();
                }

                else// if (create)
                {
                    cmd = new OleDbCommand(
                        $"insert into ProjektVerwaltung (PID2, PEinDat, PEinStd, PMID) values ({Convert.ToInt16(cBoxPID2.Text)}, '{dTPEinsatz.Value}', {Convert.ToInt16(txtEinStd.Text)}, {Convert.ToInt16(txtMID.Text)})",
                        con);
                    cmd.ExecuteNonQuery();
                    dr.Read();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
                throw;
            }
            DataAdapt = new OleDbDataAdapter($"Select * from ProjektVerwaltung", con);
            cmd = new OleDbCommand("select * from ProjektVerwaltung", con);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dr.Read();
            }
            try
            {
                ds.Clear();
                DataAdapt.Fill(ds, "ProjektVerwaltung");
                dGView.DataSource = ds;
                dGView.DataMember = "ProjektVerwaltung";
                ReplaceColumns();
            }
            catch
            {}

            create = false;
            edit = false;
            txtMID.Enabled = false;
            dTPEinsatz.Enabled = false;
            txtEinStd.ReadOnly = true;
            txtMID.ReadOnly = true;

            cBoxPID2.Update();
            cBoxPID2.Items.Clear();
            cBoxPID2.Text = ID.ToString();
            cBoxPID2.EndUpdate();
            
            cBoxID.Update();
            cBoxID.Items.Clear();
            cBoxID.Text = cBoxPID2.Text;
            cBoxID.EndUpdate();

            btnPCreate.Enabled = true;     
            btnPCreate.Visible = true;
            btnPAccept.Enabled = false;
        }        


        private void btnMCreate_Click(object sender, EventArgs e)//Button employee create
        {
            txtMName.Text = "";
            txtLohn.Text = "";
            txtMName.ReadOnly = false;
            txtLohn.ReadOnly = false;
            btnMCreate.Enabled = false;
            btnMEdit.Visible = false;
            btnMDelete.Enabled = true;
            btnMAccept.Enabled = true;
        }

        private void btnMEdit_Click(object sender, EventArgs e)//Button employee edit
        {
            txtMName.ReadOnly = false;
            txtLohn.ReadOnly = false;
            btnMAccept.Enabled = true;
            btnMEdit.Enabled = false;
            btnMCreate.Visible = false;
            btnMDelete.Enabled = true;
            btnMDelete.Enabled = true;
            btnMAccept.Enabled = true;
        }        
        private void btnMAccept_Click(object sender, EventArgs e) //Button employee accept
        {
            try
            {
                if (create)
                {
                    cmd = new OleDbCommand($"insert into mitarbeiter (MName, MStdLohn) values ('{txtMName.Text}', '{txtLohn.Text}')", con);      
                    cmd.ExecuteNonQuery();
                    dr.Read();
                }

                else if (edit)
                {
                    cmd = new OleDbCommand($"UPDATE mitarbeiter SET MStdLohn='{txtLohn.Text}', MName='{txtMName.Text}' WHERE MID={Convert.ToInt16(txtMID.Text)}", con);
                    cmd.ExecuteNonQuery();
                    dr.Read();
                }
            }
            catch
            {
            }
             txtMName.ReadOnly = false;
             txtLohn.ReadOnly = false;
             
             btnMCreate.Enabled = true;
             btnMEdit.Enabled = true;
             btnMCreate.Visible = true;
             btnMEdit.Visible = true;
             btnMDelete.Enabled = false;
             btnMAccept.Enabled = false;
        }
        
        private void btnMDel_Click(object sender, EventArgs e) //Button employee Delete
        {
            cmd = new OleDbCommand(
                $"DELETE FROM Mitarbeiter WHERE MID={Convert.ToInt16(cBoxMID2.Text)}", con);
            cmd.ExecuteNonQuery();
            dr.Read();
        }

        private void txtPID2_TextChanged(object sender, EventArgs e)
        {
            try
            //Database entries for the selected ProjectID are available
            {
                cmd = new OleDbCommand($"select * from ProjektVerwaltung where PID2={ID}", con); 
                dr = cmd.ExecuteReader();
                dr.Read();
                dateEin = Convert.ToDateTime(dr["PEinDat".ToString()]);
                dTPEinsatz.Value = dateEin;
                txtEinStd.Text = dr["PEinStd".ToString()].ToString();
                txtMID.Text = dr["PMID".ToString()].ToString();
                dateEin = Convert.ToDateTime(dr["PEinDat".ToString()]);
                dTPEinsatz.Value = dateEin;
            
                create = false;
                edit = false;
                txtMID.Enabled = false;
                dTPEinsatz.Enabled = false;
                txtEinStd.ReadOnly = true;

                btnPCreate.Enabled = true;
                btnPEdit.Enabled = true;            
                btnPCreate.Visible = true;
                btnPEdit.Visible = true;
                btnPAccept.Enabled = false;
            }
            catch
            //the database entry for the selected ProjectID is empty
            {
            }
        }

        private void cBoxPID2_SelectedIndexChanged(object sender, EventArgs e) 
        //We want to store the selected PID2 as a value in ID  whenever a change in This ComboBox occourd (is conected as eventhandler for SelectedIndexChanged, TextChanged & TextUpdates)
        {
            ID = Convert.ToInt16(cBoxPID2.Text);
        }

        private void txtEinStd_TextChanged(object sender, EventArgs e) //when changing the text the program will check if the work time is over 13h  (10hours work time and 3 hours at most as overwork time)
        {
            if (Convert.ToInt16(txtEinStd.Text) > 13 )
            {
                txtEinStd.Text = "13";
            }

            try
            {
                int test = Convert.ToInt16(txtEinStd.Text);
            }
            catch 
            {
                txtEinStd.Text = "";
            }
        }
    }
}