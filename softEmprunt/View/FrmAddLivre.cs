using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace softEmprunt.View
{
    public partial class FrmAddLivre : Form
    {

        private string connectionString = "server=localhost;database=bibliotheque;uid=root;pwd=;";
        private int idBiblioAdmin;
   
        public FrmAddLivre(int idBiblio)
        {
            InitializeComponent();
            idBiblioAdmin = idBiblio;
        }

        private void AddLivre_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string titreLivre = tbx_titre.Text;
            string auteurLivre = tbx_auteur.Text;
            string editeurLivre = tbx_editeur.Text;
            string AnneePub = tbx_anneePub.Text;
            string nombreDispo = tbx_nbDispo.Text;

            if (string.IsNullOrEmpty(titreLivre) || string.IsNullOrEmpty(auteurLivre) ||
                string.IsNullOrEmpty(editeurLivre) || string.IsNullOrEmpty(AnneePub) ||
                string.IsNullOrEmpty(nombreDispo))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            string query = "INSERT INTO livres (id_biblio, titre_livre, auteur_livre, editeur_livre, annee_pub, nbre_exemplaire_dispo, etat) " +
                           "VALUES (@idBiblio, @titre_livre, @auteur_livre, @editeur_livre, @annee_pub, @nbre_exemplaire_dispo, 'encours')";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idBiblio", idBiblioAdmin);
                    command.Parameters.AddWithValue("@titre_livre", titreLivre);
                    command.Parameters.AddWithValue("@auteur_livre", auteurLivre);
                    command.Parameters.AddWithValue("@editeur_livre", editeurLivre);
                    command.Parameters.AddWithValue("@annee_pub", AnneePub);
                    command.Parameters.AddWithValue("@nbre_exemplaire_dispo", nombreDispo);
                     //command.Parameters.AddWithValue("@etat", etat);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Livre enregistré avec succès.");
                           tbx_titre.Text= "";
                           tbx_auteur.Text = "";
                           tbx_editeur.Text = "";
                           tbx_anneePub.Text = "";
                           tbx_nbDispo.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("L'enregistrement du livre a échoué.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur s'est produite : " + ex.Message);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbx_titre.Text = "";
            tbx_auteur.Text = "";
            tbx_editeur.Text = "";
            tbx_anneePub.Text = "";
            tbx_nbDispo.Text = "";
            tbx_titre.Focus();
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

