using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace RolkeKlausurProjekt
{
    public partial class DataConfig : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbDataReader dr;
        private OleDbCommand cmd;
        private OleDbCommand cmdID;
        public bool proj = false, mitarb = false, kund = false;
        private bool create = false, edit = false,del = false, IDselect = true;
        private string dd, mm, yyyy;
        DateTime dateB, dateE;
        private int ID, Lohn;
        public DataConfig()
        {
            InitializeComponent();
        }
        private void chooseMode() 
        //Choose button mode by changing the button text 
        {
            if (btnKunden.Text == "Kunden")
            {
                btnKunden.Text = "Edit";
                btnMitarbeiter.Text = "Create";
                btnProjekte.Text = "Delete";
            }
            else
            {
                btnKunden.Text = "Kunden";
                btnMitarbeiter.Text = "Mitarbeiter";
                btnProjekte.Text = "Projekte";
            }
        }

        private void DataConfig_Load(object sender, EventArgs e) 
        //Form Load method for the FormClass DataConfig
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
            if (mitarb)
            {
                var ID = Convert.ToInt16(cBoxID.Text);
                cmd = new OleDbCommand($"select * from Mitarbeiter where mid={ID}", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                        
                string lohn = dr["MStdLohn".ToString()].ToString();
                string name = dr["kname".ToString()].ToString();
                MessageBox.Show(lohn + "\n" + name);
            }
        }

        private void btnKunden_Click(object sender, EventArgs e) //Costumer Button
        {
            if (btnKunden.Text == "Kunden")
            {
                kunden();
            }
            else
            {
                edit = true;
                if (kund)
                {
                    cBoxAnrede.Enabled = true;
                    txtName.ReadOnly = false;
                    txtAnschrift.ReadOnly = false;
                }
                else if (mitarb)
                {
                    txtName.ReadOnly = false;
                    txtLohn.ReadOnly = false;
                }
                else
                {
                    dateTPEnde.Enabled = true;
                    dateTPBeginn.Enabled = true;
                    cBoxKID.Enabled = true;
                    cBoxAnrede.Enabled = true;
                }
                btnMitarbeiter.Visible = false;
                btnKunden.Enabled = false;
            }
        }
        public void kunden() 
        //Costumer button action as method
        {
            lblLohn.Visible = false;
            txtLohn.Visible = false;
            kund = true;
            cmd = new OleDbCommand("select * from Kunden", con);
            dr = cmd.ExecuteReader();
            chooseMode();
            cBoxID.Update();
            cBoxID.Items.Clear();
            while (dr.Read())
            {
                cBoxID.Items.Add(dr["KID".ToString()]);
            }

            cBoxID.EndUpdate();
            txtLohn.Text = "";
            cBoxID.SelectedIndex = 0;

            gBoxConfig.Visible = true;

            try
            {
                ID = Convert.ToInt16(cBoxID.Text);
                cmd = new OleDbCommand($"select * from Kunden where kid={ID}", con);
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

        private void btnMitarbeiter_Click(object sender, EventArgs e) //employee Button
        {
            if (btnMitarbeiter.Text == "Mitarbeiter")
            {
                mitarbeiter();
            }
            else
            {
                load();
                create = true;
                if (kund)
                {
                    cBoxAnrede.Enabled = true;
                    txtName.ReadOnly = false;
                    txtAnschrift.ReadOnly = false;
                }
                else if (mitarb)
                {
                    txtName.ReadOnly = false;
                    txtLohn.ReadOnly = false;
                }
                else
                {
                    dateTPEnde.Enabled = true;
                    dateTPBeginn.Enabled = true;
                    //DateTime d = DateTime.Now;
                    //dateTPEnde.Value = d;
                    //dateTPBeginn.Value = d;
                    dateTPBeginn.Enabled = true;
                    
                    cBoxKID.Enabled = true;
                    cBoxAnrede.Enabled = true;

                    cBoxAnrede.Update();
                    cBoxAnrede.Items.Clear();
                    cBoxAnrede.EndUpdate();
                }

                txtLohn.Text = "";
                txtName.Text = "";
                txtAnschrift.Text = "";
                cBoxKID.Text = "";

                cBoxID.Enabled = false;
                btnKunden.Visible = false;
                btnProjekte.Visible = false;
                btnMitarbeiter.Enabled = false;
            }
        }

        public void mitarbeiter() 
        //employee button action as method
        {
            try
            {
                cBoxAnrede.Visible = false;
                mitarb = true;
                cmd = new OleDbCommand("select * from Mitarbeiter", con);
                dr = cmd.ExecuteReader();

                chooseMode();
                cBoxID.Update();
                cBoxID.Items.Clear();
                while (dr.Read())
                {
                    cBoxID.Items.Add(dr["MID".ToString()]);
                }
                cBoxID.EndUpdate();
                gBoxConfig.Visible = true;
                txtAnschrift.Visible = false;
                lblAnschrift.Visible = false;
                cBoxID.SelectedIndex = 0;
                try
                {
                }
                catch
                {
                    ID = Convert.ToInt16(cBoxID.Text);
                    cmd = new OleDbCommand($"select * from Mitarbeiter where mid={ID}", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    txtLohn.Text = dr["MStdLohn".ToString()].ToString();
                    txtName.Text = dr["mname".ToString()].ToString();
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
        private void btnProjekte_Click(object sender, EventArgs e) //Projects Button
        {
            
            if (btnProjekte.Text == "Projekte")
            {
                projekte();
            }
            else
            {
                load();
                btnMitarbeiter.Visible = false;
                btnKunden.Visible = false;
                btnProjekte.Visible = false;
                del = true;
                accept();
                acc();
            }
        }

        public void projekte() 
        //Projects button action as methode
        {
            dateTPEnde.Enabled = false;
            dateTPBeginn.Enabled = false;
            cBoxKID.Enabled = false;
            cBoxAnrede.Enabled = false;
            cBoxID.Enabled = true;
            
            txtName.Visible = false;
            lblName.Visible = false;
            lblLohn.Visible = false;
            txtLohn.Visible = false;
            lblAnschrift.Visible = false;
            txtAnschrift.Visible = false;
            try
            {
                proj = true;
                cmd = new OleDbCommand("select * from Projekte", con);
                dr = cmd.ExecuteReader();
                chooseMode();
                cBoxID.Update();
                cBoxID.Items.Clear();
                while (dr.Read())
                {
                    cBoxID.Items.Add(dr["PID".ToString()]);
                }
                cBoxID.EndUpdate();
                txtLohn.Text = "";
                cBoxAnrede.Text = "";
                gBoxConfig.Visible = true;
                cBoxID.SelectedIndex = 0;
                
                cmd = new OleDbCommand($"select * from Kunden", con);
                dr = cmd.ExecuteReader();
            
                cBoxKID.Update();
                cBoxKID.Items.Clear();
                while (dr.Read())
                {
                    cBoxKID.Items.Add(dr["KID".ToString()]);
                }
                cBoxKID.EndUpdate();
                
                
                
                try
                {
                    ID = Convert.ToInt16(cBoxID.Text);
                    cmd = new OleDbCommand($"select * from Projekte where PID={ID}", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    
                    cBoxAnrede.Update();
                    cBoxAnrede.Items.Clear();
                    while (dr.Read())
                    {
                        cBoxAnrede.Items.Add(dr["PName".ToString()]);
                    }
                    cBoxAnrede.EndUpdate();
                    
                    cBoxKID.Text = dr["pkid".ToString()].ToString();
                    dateB = Convert.ToDateTime(dr["PBeginn".ToString()]);
                    dateE = Convert.ToDateTime(dr["PEnde".ToString()]);
                    dateTPBeginn.Value = dateB;
                    dateTPEnde.Value = dateE;
                }
                catch
                {
                    
                }
                

                gBoxZeit.Visible = true;
            }
            catch (Exception M)
            {
                MessageBox.Show(M.ToString());
                throw;
            }
        }
        private void cBoxID_TextChanged(object sender, EventArgs e) 
        //the text from the ComboBox to choose the ID changed
        {
            load();
        }

        private void load() 
        //Method to Load and Refresh the informations we've got from the database
        {
            ID = Convert.ToInt16(cBoxID.Text);
            try
            {
                if (kund)
                {
                    cmd = new OleDbCommand($"select * from Kunden where kid={ID}", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    
                    cBoxAnrede.Text = dr["kanrede".ToString()].ToString();
                    txtName.Text = dr["kname".ToString()].ToString();
                    txtAnschrift.Text = dr["kanschrift".ToString()].ToString();
                }
                else if (mitarb)
                {
                    cmd = new OleDbCommand($"select * from Mitarbeiter where mid={ID}", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    txtLohn.Text = dr["MStdLohn".ToString()].ToString();
                    txtName.Text = dr["mname".ToString()].ToString();
                }
                else
                {
                    cmd = new OleDbCommand($"select * from Projekte where pid={ID}", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();

                    try
                    {
                        cBoxKID.Text = dr["pkid".ToString()].ToString();

                        ID = Convert.ToInt16(dr["pkid".ToString()].ToString());
                        cBoxAnrede.Text = dr["PName".ToString()].ToString();
                        
                        dateB = Convert.ToDateTime(dr["PBeginn".ToString()]);
                        dateE = Convert.ToDateTime(dr["PEnde".ToString()]);
                        dateTPBeginn.Value = dateB;
                        dateTPEnde.Value = dateE;
                    }
                    catch
                    {
                        
                    }
                }
            }
            catch
            {
                
            }
        }

        private void btnEnter_Click(object sender, EventArgs e) //Accept button
        {
            accept();
            acc();
        }

        void accept() 
        //Accept Method to run the SQL Commands for manipulating the database 
        {
            if (kund)
            {
                if (create)
                {
                    cmd = new OleDbCommand($"insert into kunden (kname, kanschrift, kanrede) values ('{txtName.Text}', '{txtAnschrift.Text}', '{cBoxAnrede.Text}')", con);      
                    cmd.ExecuteNonQuery();
                    dr.Read();
                }

                if (edit)
                {
                    cmd = new OleDbCommand($"UPDATE kunden SET kanschrift='{txtAnschrift.Text}', kname='{txtName.Text}', kanrede='{cBoxAnrede.Text}' WHERE KID={ID}", con);
                    cmd.ExecuteNonQuery();
                    dr.Read();
                }
                else if (del)
                {
                    cmd = new OleDbCommand(
                        $"DELETE FROM kunden WHERE kid={ID}", con);
                    cmd.ExecuteNonQuery();
                    dr.Read();
                }
            }
            else if (mitarb)
            {
                if (create)
                {
                    cmd = new OleDbCommand($"insert into mitarbeiter (MName, MStdLohn) values ('{txtName.Text}', '{txtLohn.Text}')", con);      
                    cmd.ExecuteNonQuery();
                    dr.Read();
                }

                else if (edit)
                {
                    cmd = new OleDbCommand($"UPDATE mitarbeiter SET MStdLohn='{txtLohn.Text}', MName='{txtName.Text}' WHERE MID={ID}", con);
                    cmd.ExecuteNonQuery();
                    dr.Read();
                }
                else if (del)
                {
                    cmd = new OleDbCommand(
                        $"DELETE FROM mitarbeiter WHERE MID={ID}", con);
                    cmd.ExecuteNonQuery();
                    dr.Read();
                }
            }
            else if (proj)
            {
                string name = cBoxAnrede.Text;
                int KID = Convert.ToInt16(cBoxKID.Text); 
                ID = Convert.ToInt16(cBoxID.Text);
                    
                if (create)
                {
                    cmd = new OleDbCommand(
                        $"insert into projekte (PBeginn, PEnde, PName, PKID) values ('{dateTPBeginn.Value}', '{dateTPEnde.Value}', '{name}', {KID})",
                        con);
                    cmd.ExecuteNonQuery();
                    dr.Read();
                }

                else if (edit)
                {
                    cmd = new OleDbCommand(
                        $"UPDATE projekte SET PBeginn='{dateTPBeginn.Value}', PEnde='{dateTPEnde.Value}', PName='{name}', PKID={KID} WHERE PID={ID}",
                        con);
                    cmd.ExecuteNonQuery();
                    dr.Read();
                }
                else if (del)
                {
                    cmd = new OleDbCommand(
                        $"DELETE FROM projekte WHERE PID={ID}", con);
                    cmd.ExecuteNonQuery();
                    dr.Read();
                }
            }

            load();
        }

        void acc() 
        //Accept method to change the properties of the elements/ objects used for creating, editing and deleting a database entry
        {
            btnMitarbeiter.Text = "Mitarbeiter";
            btnKunden.Text = "Kunden";
            btnProjekte.Text = "Projekte";
            btnKunden.Visible = true;
            btnProjekte.Visible = true;
            btnMitarbeiter.Visible = true;
            btnKunden.Enabled = true;
            btnProjekte.Enabled = true;
            btnMitarbeiter.Enabled = true;

            gBoxConfig.Visible = false;
            gBoxZeit.Visible = false;

            kund = false;
            proj = false;
            mitarb = false;
                
            txtName.ReadOnly = true;
            txtLohn.ReadOnly = true;
            txtAnschrift.ReadOnly = true;
            txtName.Visible = true;
            txtLohn.Visible = true;
            txtAnschrift.Visible = true;
            lblAnschrift.Visible = true;
            lblLohn.Visible = true;
            lblName.Visible = true;

            btnMitarbeiter.Text = "Mitarbeiter";
            btnKunden.Text = "Kunden";
            btnProjekte.Text = "Projekte";
            btnKunden.Visible = true;
            btnProjekte.Visible = true;
            btnMitarbeiter.Visible = true;
            btnKunden.Enabled = true;
            btnProjekte.Enabled = true;
            btnMitarbeiter.Enabled = true;

            cBoxID.Enabled = true;
            gBoxConfig.Visible = false;
            edit = false;
            kund = false;

            txtName.ReadOnly = true;
            txtAnschrift.ReadOnly = true;
            cBoxID.Enabled = true;
            
            dateTPEnde.Enabled = false;
            dateTPBeginn.Enabled = false;
                    
            cBoxKID.Enabled = true;
            cBoxAnrede.Enabled = true;
            create = false;
            del = false;
            edit = false;
            cBoxAnrede.Enabled = false;
            cBoxAnrede.Visible = true;
            lblLohn.Visible = true;
            txtLohn.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e) //Exit Button
        {
            Close();
        }

        private void txtReload_Click(object sender, EventArgs e) 
        //Method to Refresh the informations from the database
        {
            if (kund)
            {
                cmd = new OleDbCommand($"select * from Kunden", con);
                dr = cmd.ExecuteReader();
                
                cBoxID.Update();
                cBoxID.Items.Clear();
                while (dr.Read())
                {
                    cBoxID.Items.Add(dr["KID".ToString()]);
                }
                cBoxID.EndUpdate();
            }
            else if (mitarb)
            {
                cmd = new OleDbCommand($"select * from Mitarbeiter", con);
                dr = cmd.ExecuteReader();
                
                cBoxID.Update();
                cBoxID.Items.Clear();
                while (dr.Read())
                {
                    cBoxID.Items.Add(dr["MID".ToString()]);
                }
                cBoxID.EndUpdate();
            }
            else if (proj)
            {
                cmd = new OleDbCommand($"select * from Projekte", con);
                dr = cmd.ExecuteReader();
                
                cBoxID.Update();
                cBoxID.Items.Clear();
                while (dr.Read())
                {
                    cBoxID.Items.Add(dr["PID".ToString()]);
                }
                cBoxID.EndUpdate();
            }
        }
    }
}