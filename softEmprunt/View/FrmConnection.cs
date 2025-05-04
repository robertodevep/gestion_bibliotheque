using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace softEmprunt.View
{
    public partial class FrmConnection : Form
    {
        // private string connectionString = "server=localhost;database=bibliotheque;uid=root;pwd=;";
        private string connectionString = "server=localhost;database=bibliotheque;uid=root;pwd=;";
        public FrmConnection()
        {
            InitializeComponent();
        }

        private void FrmConnection_Load(object sender, EventArgs e)
        {



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbnCon_Click(object sender, EventArgs e)
        {
            string nom_biblio = tbxNom.Text;
            string passwords = tbxPassword.Text;

            if (string.IsNullOrEmpty(nom_biblio) || string.IsNullOrEmpty(passwords))
            {
                MessageBox.Show("Veuillez saisir le nom et le mot de passe", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString)) // Utilisation de MySqlConnection
                {
                    connection.Open();

                    string query = "SELECT id_biblio FROM bibliothecaire WHERE nom_biblio = @nom AND passwords = @password";

                    using (MySqlCommand command = new MySqlCommand(query, connection)) // Utilisation de MySqlCommand
                    {
                        command.Parameters.AddWithValue("@nom", nom_biblio);
                        command.Parameters.AddWithValue("@password", passwords);

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            int idBiblio = Convert.ToInt32(result);
                            MessageBox.Show("Connexion réussie!", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            FrmAccueil ac = new FrmAccueil(idBiblio);
                            ac.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Nom ou mot de passe incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (MySqlException ex) // Gestion des exceptions MySQL
            {
                MessageBox.Show("Erreur de connexion MySQL: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
