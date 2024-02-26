using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class CartiForm : Form
    {
        const int IdCarteIndex = 0;
        const int TitluIndex = 1;
        const int AutorIndex = 2;
        const int NrInventarIndex = 3;
        const int TarifZiIndex = 4;
        const int SpImagineIndex = 5;


        public CartiForm()
        {
            InitializeComponent();
        }
        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;
            dataGridView1.Columns[TitluIndex].ReadOnly = v;
            dataGridView1.Columns[AutorIndex].ReadOnly = v;
            dataGridView1.Columns[NrInventarIndex].ReadOnly = v;
            dataGridView1.Columns[SpImagineIndex].ReadOnly = v;
            dataGridView1.Columns[TarifZiIndex].ReadOnly = v;
            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;

        }

        private void refresh()
        {
            cartiTableAdapter.Fill(dBProiectDataSet.Carti);
        }

        private void CartiForm_Load(object sender, EventArgs e)
        {

            //A1
            config(true);
            refresh();
            dataGridView1.Columns[IdCarteIndex].ReadOnly = true;


        }
        private void btnActualizare_Click(object sender, EventArgs e)
        {

            config(false);
        }
        private void btnSalvare_Click(object sender, EventArgs e)
        {
            //A4
            if (!completareCampuri()) return;
            try
            {
                cartiTableAdapter.Update(dBProiectDataSet.Carti);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                string s = exc.Message;
                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Inregistrare deja existenta !");
                else if (s.IndexOf("cannot be deleted") > 0)
                    MessageBox.Show("Ati sters inregistrari referite in alte tabele !");
            }
        }
        private void btnRenuntare_Click(object sender, EventArgs e)
        {

            //A3

            config(true);

            refresh();
        }
        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            if (btnRenuntare.Focused)
            {
                dataGridView1.CancelEdit();
                //A3
                config(true);
                refresh();

                return;
            }
            MessageBox.Show("Format eronat");
        }
        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }
        private bool completareCampuri()
        {
            bool raspuns = true;
            foreach (DataRow r in dBProiectDataSet.Carti)
            {
                if (r.RowState == DataRowState.Deleted) continue;
                if (r["Titlu"] == DBNull.Value)
                {
                    MessageBox.Show("Completati Titlu la linia cu Id " + r["IdCarte"]);
                    raspuns = false;
                }
                if (r["Autor"] == DBNull.Value)
                {
                    MessageBox.Show("Completati Autor la linia cu Id " + r["IdCarte"]);
                    raspuns = false;
                }
                if (r["NrInventar"] == DBNull.Value)
                {
                    MessageBox.Show("Completati NrInventar la linia cu Id " + r["IdCarte"]);
                    raspuns = false;
                }
                if (r["TarifZi"] == DBNull.Value)
                {
                    MessageBox.Show("Completati TarifZi la linia cu Id " + r["IdCarte"]);
                    raspuns = false;
                }
            }
            return raspuns;
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (btnActualizare.Enabled) return;

            if (dataGridView1.CurrentCell.ColumnIndex == SpImagineIndex)
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string s = openFileDialog1.FileName; ;
                    dataGridView1.CurrentRow.Cells[SpImagineIndex].Value = s;
                    pictureBox1.ImageLocation = s;
                }
        }

        private void persoaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersoaneForm persoaneform = new PersoaneForm();
            persoaneform.Show();
            this.Hide();
        }
    }
}