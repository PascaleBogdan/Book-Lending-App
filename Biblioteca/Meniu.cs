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
    public partial class Meniu : Form
    {
        private bool isLoggedIn = true;

        public Meniu()
        {
            InitializeComponent();
        }

        private void cartiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CartiForm cartiform = new CartiForm();
            cartiform.Show();
        }

        private void persoaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersoaneForm persoaneform = new PersoaneForm();
            persoaneform.Show();
        }

        private void imprumuturiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FImprumuturi imprumuturiform = new FImprumuturi();
            imprumuturiform.Show();
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            isLoggedIn = false;
            LoginForm loginform = new LoginForm();
            loginform.Show();
            this.Close();
        }

        private void Meniu_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
