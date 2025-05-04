using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;


namespace softEmprunt.View
{
    public partial class FrmAddEmprunteurs1 : Form
    {
        private string connectionString = "server=localhost;database=bibliotheque;uid=root;pwd=;";
        private int idBiblioAdmin;

        public FrmAddEmprunteurs1(int idBiblio)
        {
            InitializeComponent();
            idBiblioAdmin = idBiblio;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string nomEmprunteur = tbx_nom.Text;
            string prenomEmprunteur = tbx_prenom.Text;
            string adresseResidence = tbx_residence.Text;
            string telephone = tbx_tel.Text;
            string adresseMail = tbx_email.Text;

            if (string.IsNullOrEmpty(nomEmprunteur) || string.IsNullOrEmpty(prenomEmprunteur) ||
                string.IsNullOrEmpty(adresseResidence) || string.IsNullOrEmpty(telephone) ||
                string.IsNullOrEmpty(adresseMail))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            if (!IsValidEmail(adresseMail))
            {
                MessageBox.Show("Format d'email invalide.");
                return;
            }

            if (EmailExists(adresseMail))
            {
                MessageBox.Show("Cet email existe déjà.");
                return;
            }

            // Récupérer le nom du bibliothécaire à partir de l'idBiblioAdmin
            string nomBibliothecaire = GetNomBibliothecaire(idBiblioAdmin);

            if (string.IsNullOrEmpty(nomBibliothecaire))
            {
                MessageBox.Show("Bibliothécaire introuvable.");
                return;
            }

            string query = "INSERT INTO emprunteurs (id_biblio, nom_emprunteur, prenom_emprunteur, adresse_residence, telephone, adresse_mail) " +
                           "VALUES (@idBiblio, @nomEmprunteur, @prenomEmprunteur, @adresseResidence, @telephone, @adresseMail)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idBiblio", idBiblioAdmin);
                    command.Parameters.AddWithValue("@nomEmprunteur", nomEmprunteur);
                    command.Parameters.AddWithValue("@prenomEmprunteur", prenomEmprunteur);
                    command.Parameters.AddWithValue("@adresseResidence", adresseResidence);
                    command.Parameters.AddWithValue("@telephone", telephone);
                    command.Parameters.AddWithValue("@adresseMail", adresseMail);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Emprunteur enregistré avec succès.");
                            tbx_nom.Text = "";
                            tbx_prenom.Text = "";
                            tbx_residence.Text = "";
                            tbx_tel.Text = "";
                            tbx_email.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("L'enregistrement de l'emprunteur a échoué.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur s'est produite : " + ex.Message);
                    }
                }
            }
        }

        private string GetNomBibliothecaire(int idBiblio)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT nom_biblio FROM bibliothecaire WHERE id_biblio = @idBiblio";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idBiblio", idBiblio);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? result.ToString() : null;
                }
            }
        }
         

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private bool EmailExists(string email)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM emprunteurs WHERE adresse_mail = @email";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_effacer_Click(object sender, EventArgs e)
        {
            tbx_nom.Text = "";
            tbx_prenom.Text = "";
            tbx_residence.Text = "";
            tbx_tel.Text = "";
            tbx_email.Text = "";
            tbx_nom.Focus();
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Fermer le formulaire courant ou l'application entière
                this.Close(); // Ferme le formulaire courant
                
            }
            
        }
        
    }
}
