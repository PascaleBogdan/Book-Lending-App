using System;
using System.Data.OleDb;
using System.Text;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class LoginForm : Form
    {
        private bool isLoggedin = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        // Other methods...

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validate input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Introduceți username-ul și parola.");
                return;
            }

            // Check the credentials against the database (without hashing the password)
            if (CheckLogin(username, password))
            {
                // Login successful, show Form3
                isLoggedin = true;
                Meniu meniu = new Meniu();
                meniu.Show();
                this.Hide();
            }
            else
            {
                // Login failed, show an error message
                MessageBox.Show("Username sau parola incorecte. Va rugam reîncercați!");
            }
        }

        private bool CheckLogin(string username, string password)
        {
            try
            {
                // Connect to the database and check the credentials
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Bogdan\\Desktop\\project\\DBProiect.accdb";
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    // Update the query to compare passwords in plain text
                    string query = "SELECT COUNT(*) FROM Utilizatori WHERE username = @username AND parola = @parola";
                    using (OleDbCommand command = new OleDbCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@parola", password);

                        int count = (int)command.ExecuteScalar();
                        return count > 0; // Return true if there is at least one matching user
                    }
                }
            }
            catch (Exception ex)
            {
                // Display an error message and return false in case of an error
                MessageBox.Show($"Error during login: {ex.Message}");
                return false;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
