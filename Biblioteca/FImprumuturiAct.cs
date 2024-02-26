using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FImprumuturiAct : Form
    {
        private bool errorOccurred = false;
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private int idImprumut;
        public BindingSource bs1;
        public BindingSource bs2;


        public FImprumuturiAct()
        {
            Console.WriteLine($"Current Directory: {Environment.CurrentDirectory}");
            InitializeComponent();
            con.ConnectionString = cartiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;


        }
        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }
        private void completeazaImprumut()
        {
            DataRowView current = (DataRowView)bs1.Current;

            idImprumut = (int)current["IdImprumut"];


            cmbPersoana.Text = current["Nume"].ToString();
            //txtTotal.Text = current["Total"].ToString();

            dateTimePicker1.Value = Convert.ToDateTime(current["DataImprumut"]);

            bs2.MoveFirst();

            dBProiectDataSet.ImprumutContinutManevra.Clear();


            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;

                DBProiectDataSet.ImprumutContinutManevraRow r = dBProiectDataSet.ImprumutContinutManevra.NewImprumutContinutManevraRow();
                r.Nrc = Convert.ToInt16(current["Nrc"]);
                r.Titlu = Convert.ToString(current["Titlu"]);
                r.Autor = Convert.ToString(current["Autor"]);
                r.NRInventar = Convert.ToInt32(current["NrInventar"]);
                r.TarifZi = Convert.ToDecimal(current["TarifZi"]);
                r.NrZile = Convert.ToDecimal(current["NrZile"]);
                r.IdCarte = Convert.ToInt32(current["IdCarte"]);
                r.Valoare = Convert.ToDecimal(current["Valoare"]);

                dBProiectDataSet.ImprumutContinutManevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }

        private void A1()
        {
            // Check if persoaneTableAdapter is not null before using it
            if (persoaneTableAdapter != null)
            {
                // Incarcare DataTable Produse
                cartiTableAdapter.Fill(dBProiectDataSet.Carti);

                // Incarcare DataTable Clienti
                persoaneTableAdapter.Fill(dBProiectDataSet.Persoane);

                // Setare lblOp

                // Protectie la modificare
                //txtTotal.ReadOnly = true;
                nrcDataGridViewTextBoxColumn.ReadOnly = true;
                nRInventarDataGridViewTextBoxColumn.ReadOnly = true;
                tarifZiDataGridViewTextBoxColumn.ReadOnly = true;
                autorDataGridViewTextBoxColumn.ReadOnly = true;
                idCarteDataGridViewTextBoxColumn.ReadOnly = true;

                if (lblOp.Text == "MODIFICARE IMPRUMUT") completeazaImprumut();
                else if (lblOp.Text == "IMPRUMUT NOU") cmbPersoana.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("persoaneTableAdapter is null. Check if it's properly initialized.");
            }
        }

        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE IMPRUMUT")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariImprumuturiContinut();
                this.Close();
            }
            else if (lblOp.Text == "IMPRUMUT NOU")
            {

                adaugaInregistrareImprumuturi();
                cautaInregistrare();
                adaugaInregistrariImprumuturiContinut();
                golireCampuri();

            }
        }

        private void A3()
        {
            // Generare NrCrt
            if (imprumutContinutManevraBindingSource.Current != null)
            {
                DataRowView current = (DataRowView)imprumutContinutManevraBindingSource.Current;
                try { current["Nrc"] = imprumutContinutManevraBindingSource.Position + 1; }
                catch { }
            }
        }
        private void A4()
        {
            try
            {
                if (dataGridView1.CurrentCell != null)
                {
                    if (dataGridView1.CurrentCell.ColumnIndex == 1)
                    {
                        DataRowView current = (DataRowView)cartiBindingSource.Current;
                        dataGridView1.CurrentRow.Cells[2].Value = current["Autor"];
                        dataGridView1.CurrentRow.Cells[3].Value = current["NrInventar"];
                        dataGridView1.CurrentRow.Cells[4].Value = current["TarifZi"];
                        dataGridView1.CurrentRow.Cells[7].Value = current["IdCarte"];

                        calcTotal();
                    }

                    if (dataGridView1.CurrentCell.ColumnIndex == 5)
                    {
                        imprumutContinutManevraBindingSource.EndEdit();
                        calcTotal();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A intervenit o eroare: {ex.Message}");
            }
        }
        private void A5(DataGridViewRowCancelEventArgs e)
        {

            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

            if (rezultat == DialogResult.No) e.Cancel = true;
        }

        private void FImprumuturiAct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBProiectDataSet.Persoane' table. You can move, or remove it, as needed.
            this.persoaneTableAdapter.Fill(this.dBProiectDataSet.Persoane);

            A1();

        }
        private bool validareCampuriObligatorii()
        {

            if (cmbPersoana.Text == "")
            {
                MessageBox.Show("Completati Persoana !");
                cmbPersoana.Focus();
                return false;
            }


            if (imprumutContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut imprumut !");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }

        private void calcTotal()
        { // Calcul total valori
            decimal t = 0;
            foreach (DataRow r in dBProiectDataSet.ImprumutContinutManevra)
            {
                if (r["Valoare"] != DBNull.Value)
                    t += (decimal)r["Valoare"];
            }

            //txtTotal.Text = Convert.ToString(t);
        }
        private void imprumutContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            A4();
        }
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format Eronat");
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }
        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            try
            {
                A2(); // Assuming A2 contains your logic for adding a new Imprumut

                // Adaugă această verificare suplimentară pentru a evita continuarea după închiderea ferestrei
                if (errorOccurred)
                {
                    return;
                }
            }
            catch (OleDbException ex)
            {
                // Restul codului rămâne neschimbat

                if (ex.Errors.Count > 0 && ex.Errors[0].SQLState == "23000")
                {
                    MessageBox.Show("Persoana are deja un imprumut pentru aceeasi data. Modificati existentul.");
                    golireCampuri();

                }
                else
                {
                    // If it's a different type of exception, rethrow it
                    throw;
                }
            }
        }


        private void adaugaInregistrareImprumuturi()
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;

            listaCampuri = "DataImprumut, IdPersoana";
            listaValori = $"#{d.Month}/{d.Day}/{d.Year}#, {cmbPersoana.SelectedValue}";

            // Check if a record with the same DataImprumut and IdPersoana already exists
            cmd.CommandText = $"SELECT COUNT(*) FROM Imprumuturi WHERE DataImprumut = #{d.Month}/{d.Day}/{d.Year}# AND IdPersoana = {cmbPersoana.SelectedValue}";

            con.Open();
            int existingRecords = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (existingRecords > 0)
            {
                MessageBox.Show("Persoana are deja un imprumut pentru aceeasi data. Modificati existentul.");
                errorOccurred = true;
                this.Close();
                return;
            }

            cmd.CommandText = "INSERT INTO Imprumuturi (" + listaCampuri + ") " +
                              "VALUES (" + listaValori + ")";

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting record: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }

        private void cautaInregistrare()
        {

            cmd.CommandText = $"SELECT idImprumut From Imprumuturi Where DataImprumut =  #{dateTimePicker1.Value.Month}/{dateTimePicker1.Value.Day}/{dateTimePicker1.Value.Year}# and idPersoana= " + cmbPersoana.ValueMember;

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            idImprumut = rdr.GetInt32(0);
            rdr.Close();
            con.Close();
        }
        private void adaugaInregistrariImprumuturiContinut()
        {
            string listaCampuri = "IdImprumut, Nrc, IdCarte, NrInventar, TarifZi, NrZile"; 
            string listaValori;
            con.Open();
            foreach (DataRow r in dBProiectDataSet.ImprumutContinutManevra)
            {
                listaValori = $"{idImprumut}, {r["Nrc"]}, {r["IdCarte"]}, {r["NrInventar"]}, {r["TarifZi"]}, {r["NrZile"]}"; 
                cmd.CommandText = $"INSERT INTO ImprumuturiContinut ({listaCampuri}) VALUES ({listaValori})";
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (OleDbException ex)
                {
                    // Verificați dacă este o cheie semantică duplicată (erorile 3022 sau 3112)
                    if (ex.ErrorCode == 3022 || ex.ErrorCode == 3112)
                    {
                        MessageBox.Show("Nu se poate sterge!");
                        // Continuați sau tratați după cum doriți
                    }
                    else
                    {
                        // Afișați alte mesaje de eroare sau tratați excepția în alt mod
                        //MessageBox.Show("Eroare: " + ex.Message);
                    }
                }

            }
            con.Close();
        }

        private void golireCampuri()
        {
            cmbPersoana.SelectedIndex = -1;
            //txtTotal.Text = "";
            dBProiectDataSet.ImprumutContinutManevra.Clear();
        }
        private void modificaInregistrare()
        {
            DateTime d1 = dateTimePicker1.Value;

            con.ConnectionString = cartiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            string clauzaWhere = " Where IdImprumut = " + idImprumut;

            string clauzaSet = "Set DataImprumut = #" + d1.Month + "/"
                               + d1.Day + "/"
                               + d1.Year + "#,"
                               + "IdPersoana = " + cmbPersoana.SelectedValue;

            cmd.CommandText = "Update Imprumuturi " + clauzaSet + clauzaWhere;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void stergeContinut()
        {
            cmd.CommandText = "Delete from ImprumuturiContinut Where IdImprumut = " + idImprumut;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void btnPersoana_Click(object sender, EventArgs e)
        {
            PersoaneForm f = new PersoaneForm();
            f.SetMaster(this);
            f.SetSelectVisible();
            f.ShowDialog();
        }
        public void refreshPersoane(int selectedPosition)
        {
            // Verificăm dacă ComboBox-ul există și este gata de actualizare
            if (cmbPersoana != null)
            {
                // Salvăm poziția selectată


                // Actualizăm localitățile în ComboBox
                persoaneTableAdapter.Fill(dBProiectDataSet.Persoane);


                // Repunem ComboBox-ul în starea selectată înainte de actualizare
                cmbPersoana.SelectedIndex = selectedPosition;
            }
        }




    }
}