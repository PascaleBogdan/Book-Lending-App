using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FImprumuturi : Form
    {
        public FImprumuturi()
        {
            InitializeComponent();
        }

        private void FImprumuturi_Load(object sender, EventArgs e)
        {
            refreshGrid();
            try
            {
       //         imprumuturiContinutBindingSource.Filter = "IdImprumut=" + txtIdImprumut.Text;
            }
            catch { }
         //   txtIdImprumut.ReadOnly = true;

        }
        private void refreshGrid()
        {
            imprumuturiTableAdapter.Fill(dBProiectDataSet.Imprumuturi);
            imprumuturiContinutTableAdapter.Fill(dBProiectDataSet.ImprumuturiContinut);
        }
        private void imprumuturiBindingSource_PositionChanged(object sender, EventArgs e)
        {
           
                try
                {
                    DataRowView currentImprumut = (DataRowView)imprumuturiBindingSource.Current;
                    if (currentImprumut != null)
                    {
                        int idImprumut = (int)currentImprumut["IdImprumut"];
                        imprumuturiContinutBindingSource.Filter = "IdImprumut=" + idImprumut;
                    }
                }
                catch { }
            
        }
        private void btnImprumutNou_Click(object sender, EventArgs e)
        {
            FImprumuturiAct f = new FImprumuturiAct();
            f.ShowDialog();
            refreshGrid();
        }
        private void btnStergeImprumut_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rezultat == DialogResult.No) return;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = imprumuturiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            try
            {
                con.Open();

                // Sterg continut comanda
             //   cmd.CommandText = "Delete From  ImprumuturiContinut Where IdImprumut = " + txtIdImprumut.Text;
                cmd.ExecuteNonQuery();

                // Sterg comanda
            //    cmd.CommandText = "Delete From Imprumuturi Where IdImprumut = " + txtIdImprumut.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}");
            }
            finally
            {
                con.Close();
            }

            // Refresh grid-uri
            refreshGrid();
        }

        private void btnModificaImprumut_Click(object sender, EventArgs e)
        {
            FImprumuturiAct f = new FImprumuturiAct();
            f.completeazaTitlu("MODIFICARE IMPRUMUT");
            f.bs1 = imprumuturiBindingSource;
            f.bs2 = imprumuturiContinutBindingSource;
            f.ShowDialog();
            refreshGrid();

        }
    }
}
