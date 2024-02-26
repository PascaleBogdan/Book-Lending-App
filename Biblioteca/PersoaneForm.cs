using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class PersoaneForm : Form
    {
        private Form master;
        private bool selectie;
        public PersoaneForm()
        {
            InitializeComponent();
        }
        public void SetMaster(Form caller)
        {
            master=caller;
        }
        public void SetSelectVisible()
        {
            selectie = true;
        }

        private void PersoaneForm_Load(object sender, EventArgs e)
        {   
       //     btnSelectie.Visible=false;
            A1();
            

        }


        private void btnStergere_Click(object sender, EventArgs e)
        {
            
            A8();
        }


        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            
            A3();
            


        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            
            A4();
            
        }

        private void txtNrTelefon_Leave(object sender, EventArgs e)
        {
            A5(txtNrTelefon);
        }


        private void txtSpImagine_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            A6();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }


        private void A1()
        {

            //Umple cu date obiectele DataTable: Persoane
            persoaneTableAdapter.Fill(dBProiectDataSet.Persoane);

            //Configurare PB
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //Protectie grid 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;
            

            //Protectie txtIdPersoana
            txtIdPersoana.ReadOnly = true;


            A3();
        }
        private void A2()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);


       

            //Modifcare lblOp
            lblOp.Text = "ADAUGARE";

            //Pozitionare cursor pe primul camp
            txtNume.Focus();

            // Golire campuri
            golireCampuri();
        }

        private void A3()
        {
            
            //Initializare lblOp
            lblOp.Text = "";

            //Çonfigurare(butoane)
            configureazaButoane(true);

            //Protectie componente Panel
            protectiePanel(true);

            //Legare controale
            legareControale(true);
        }
        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;

                adauga_inregistrare();

                golireCampuri();

                //Pune cursor pe primul camp
                txtNume.Focus();
                refresh_grid(persoaneBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(persoaneBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }
        private void A5(TextBox txtB)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;
            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if(btnRenuntare.Focused) return;

            try
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtB.Text, @"^\d+$"))
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Format eronat. Introduceți un număr de telefon valid format doar din cifre.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB.Focus();
            }
            con.ConnectionString = persoaneTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            if (lblOp.Text == "ADAUGARE") {
                cmd.CommandText = "SELECT Nume FROM Persoane WHERE NrTelefon = @NrTelefon";
                cmd.Parameters.AddWithValue("@NrTelefon", txtNrTelefon.Text);


                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Numar de telefon deja existent");
                    txtNrTelefon.Focus();
                }
                con.Close();
            }
            else if (lblOp.Text =="MODIFICARE") {
                cmd.CommandText = "SELECT Nume FROM Persoane WHERE NrTelefon = @NrTelefon AND IdPersoana <> @IdPersoana";
                cmd.Parameters.AddWithValue("@NrTelefon", txtNrTelefon.Text);
                cmd.Parameters.AddWithValue("@IdPersoana", txtIdPersoana.Text);

                con.Open();
                r = cmd.ExecuteReader();
                if (r.Read())
                {
                    MessageBox.Show("Numar de telefon deja existent");
                    txtNrTelefon.Focus();
                }
                con.Close();
            }
        }



        private void A6()
        {
            if (lblOp.Text == "")
                return;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtSpImagine.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = txtSpImagine.Text;
            }
        }
        private void A7()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);


            //Modifcare lblOp
            lblOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp
            txtNume.Focus();
        }

        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = persoaneTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            // Check if there is a reference in the "Comenzi" table
            cmd.CommandText = "SELECT IdPersoana FROM Imprumuturi WHERE IdPersoana = " + txtIdPersoana.Text;

            con.Open();
            r = cmd.ExecuteReader();

            if (r.Read())
            {
                con.Close();

                // If there is a reference, show an error message
                MessageBox.Show("Persoana referita in tabela Imprumuturi! Nu se poate sterge!");
                return;
            }

            con.Close();

            // If there is no reference, prompt the user for confirmation
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezultat == DialogResult.No) return;

            // Continue with the deletion
            con.Open();
            cmd.CommandText = "DELETE FROM Persoane WHERE IdPersoana = " + txtIdPersoana.Text;
            cmd.ExecuteNonQuery();
            con.Close();

            // Refresh the grid after deletion
            refresh_grid(persoaneBindingSource.Position);
        }





        private void modifica_inregistrare()
        {
            string listaSet;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = persoaneTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaSet = "Nume = @Nume," +
                       "Adresa = @Adresa," +
                       "NrTelefon = @NrTelefon," +
                       "SpImagine = @SpImagine";

            cmd.CommandText = "Update Persoane Set " + listaSet + " Where IdPersoana=@IdPersoana";

            // Adăugare parametri
            cmd.Parameters.AddWithValue("@Nume", txtNume.Text);
            cmd.Parameters.AddWithValue("@Adresa", txtAdresa.Text);
            cmd.Parameters.AddWithValue("@NrTelefon", txtNrTelefon.Text);
            cmd.Parameters.AddWithValue("@SpImagine", txtSpImagine.Text);
            cmd.Parameters.AddWithValue("@IdPersoana", txtIdPersoana.Text);

           

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void refresh_grid(int p)
        {
            persoaneTableAdapter.Fill(dBProiectDataSet.Persoane);
            persoaneBindingSource.Position = p;
        }
        
        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = persoaneTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            listaCampuri = "Nume, Adresa, NrTelefon, SpImagine";
            listaValori = "@Nume, @Adresa, @NrTelefon, @SpImagine";

            cmd.CommandText = "Insert into Persoane(" + listaCampuri + ") Values (" + listaValori + ")";

            // Adăugare parametri
            cmd.Parameters.AddWithValue("@Nume", txtNume.Text);
            cmd.Parameters.AddWithValue("@Adresa", txtAdresa.Text);
            cmd.Parameters.AddWithValue("@NrTelefon", txtNrTelefon.Text);
            cmd.Parameters.AddWithValue("@SpImagine", txtSpImagine.Text);

            

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate
            if (txtNume.Text == "")
            {
                MessageBox.Show("Completati Nume !");
                txtNume.Focus();
                return false;
            }
            if (txtAdresa.Text == "")
            {
                MessageBox.Show("Completati Adresa !");
                txtAdresa.Focus();
                return false;
            }
            if (txtNrTelefon.Text == "")
            {
                MessageBox.Show("Completati NrTelefon !");
                txtNrTelefon.Focus();
                return false;
            }

            return true;
        }
        private void protectiePanel(bool v)
        {
            txtNume.ReadOnly = v;
            txtAdresa.ReadOnly = v;
            txtNrTelefon.ReadOnly = v;
            txtSpImagine.ReadOnly = v;
            
        }

        private void golireCampuri()
        {
            txtNume.Text = "";
            txtNrTelefon.Text = "";
            txtIdPersoana.Text = "";
            txtAdresa.Text = "";
            txtSpImagine.Text = "";
            pictureBox1.ImageLocation = "";
        }
        private void legareControale(bool v)
        {
            txtNume.DataBindings.Clear();
            txtAdresa.DataBindings.Clear();
            txtNrTelefon.DataBindings.Clear();
            txtSpImagine.DataBindings.Clear();
            txtIdPersoana.DataBindings.Clear();
            pictureBox1.DataBindings.Clear();

            if (v)
            {
                txtNume.DataBindings.Add("Text", persoaneBindingSource, "Nume");
                txtAdresa.DataBindings.Add("Text", persoaneBindingSource, "Adresa");
                txtNrTelefon.DataBindings.Add("Text", persoaneBindingSource, "NrTelefon");
                txtSpImagine.DataBindings.Add("Text", persoaneBindingSource, "SpImagine");
                txtIdPersoana.DataBindings.Add("Text", persoaneBindingSource, "IdPersoana");
                pictureBox1.DataBindings.Add("ImageLocation", persoaneBindingSource, "SpImagine");
            }
           
        }
        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirmare.Visible = !v;

            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;

         //   if (selectie) btnSelectie.Visible = v;
        }

        private void txtIdPersoana_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectie_Click(object sender, EventArgs e)
        {
            FImprumuturiAct f = (FImprumuturiAct)master;
            f.refreshPersoane(persoaneBindingSource.Position);
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
