
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
    public partial class FrmRetournerLivre : Form
    {
        private string connectionString = "server=localhost;database=bibliotheque;uid=root;pwd=;";
        public FrmRetournerLivre()
        {
            InitializeComponent();
            LoadEmailsEmprunteurs();
        }

        private void LoadEmailsEmprunteurs()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT e.adresse_mail FROM emprunteurs e " +
                                   "INNER JOIN emprunt em ON e.id_emprunteur = em.id_emprunteur WHERE em.etat = 'emprunter'"; // Ajout de la clause WHERE
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            cmbxEmail.DataSource = dt;
                            cmbxEmail.DisplayMember = "adresse_mail";
                            cmbxEmail.ValueMember = "adresse_mail";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des emails : " + ex.Message);
            }
        }


        private void cmbxEmail_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbxEmail.SelectedValue != null)
            {
                string emailSelectionne = cmbxEmail.SelectedValue.ToString();
                AfficherLivresEmpruntes(emailSelectionne);
            }
        }

        private void AfficherLivresEmpruntes(string emailEmprunteur)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT e.id_emprunteur, e.nom_emprunteur, e.prenom_emprunteur, e.adresse_residence, e.telephone, e.adresse_mail, l.titre_livre, em.date_emprunt, em.date_retour " +
                                   "FROM emprunteurs e " +
                                   "INNER JOIN emprunt em ON e.id_emprunteur = em.id_emprunteur " +
                                   "INNER JOIN livres l ON em.id_livre = l.id_livre " +
                                   "WHERE e.adresse_mail = @email AND em.etat = 'emprunter'"; // Filtrer les livres non rendus
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", emailEmprunteur);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage des livres empruntés : " + ex.Message);
            }
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxNomLivre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxDatEmprunt_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxDatRetour_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRetourner_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxNomLivre.Text) || string.IsNullOrEmpty(tbxDatEmprunt.Text))
            {
                MessageBox.Show("Veuillez sélectionner un livre à retourner.");
                return;
            }

            try
            {
                int idEmprunteur = ObtenirIdEmprunteur(cmbxEmail.SelectedValue.ToString());
                if (idEmprunteur != -1)
                {
                    if (RendreLivre(idEmprunteur)) // Utilisation de la fonction RendreLivre
                    {
                        MessageBox.Show("Livre retourné avec succès.");
                        AfficherLivresEmpruntes(cmbxEmail.SelectedValue.ToString()); // Rafraîchir le DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Erreur lors du retour du livre.");
                    }
                }
                else
                {
                    MessageBox.Show("Emprunteur non trouvé.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du retour du livre : " + ex.Message);
            }
        }

        public bool RendreLivre(int idEmprunteur)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Récupérer le nombre_emprunt actuel
                        int nombreEmpruntActuel = 0;
                        string getNombreQuery = "SELECT nombre_emprunt FROM emprunt WHERE id_emprunteur = @idEmprunteur AND id_livre = (SELECT id_livre FROM livres WHERE titre_livre = @titreLivre) AND date_emprunt = @dateEmprunt LIMIT 1";

                        DateTime dateEmprunt;
                        if (!DateTime.TryParse(tbxDatEmprunt.Text, out dateEmprunt))
                        {
                            MessageBox.Show("Format de date d'emprunt invalide.");
                            return false;
                        }

                        using (MySqlCommand getNombreCommand = new MySqlCommand(getNombreQuery, connection, transaction))
                        {
                            getNombreCommand.Parameters.AddWithValue("@idEmprunteur", idEmprunteur);
                            getNombreCommand.Parameters.AddWithValue("@titreLivre", tbxNomLivre.Text);
                            getNombreCommand.Parameters.AddWithValue("@dateEmprunt", dateEmprunt);
                            object result = getNombreCommand.ExecuteScalar();
                            if (result != null)
                            {
                                nombreEmpruntActuel = Convert.ToInt32(result);
                            }
                        }

                        // Mise à jour de l'état de l'emprunt
                        string updateQuery = "UPDATE emprunt SET etat = 'rendu' WHERE id_emprunteur = @idEmprunteur AND id_livre = (SELECT id_livre FROM livres WHERE titre_livre = @titreLivre) AND date_emprunt = @dateEmprunt LIMIT 1";
                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection, transaction))
                        {
                            updateCommand.Parameters.AddWithValue("@idEmprunteur", idEmprunteur);
                            updateCommand.Parameters.AddWithValue("@titreLivre", tbxNomLivre.Text);
                            updateCommand.Parameters.AddWithValue("@dateEmprunt", dateEmprunt);
                            updateCommand.ExecuteNonQuery();
                        }

                        // Mettre à jour les autres emprunts pour décrémenter leur nombre_emprunt
                        string updateNombreQuery = "UPDATE emprunt SET nombre_emprunt = nombre_emprunt - 1 WHERE id_emprunteur = @idEmprunteur AND etat = 'emprunter' AND nombre_emprunt > @nombreEmpruntActuel";
                        using (MySqlCommand updateNombreCommand = new MySqlCommand(updateNombreQuery, connection, transaction))
                        {
                            updateNombreCommand.Parameters.AddWithValue("@idEmprunteur", idEmprunteur);
                            updateNombreCommand.Parameters.AddWithValue("@nombreEmpruntActuel", nombreEmpruntActuel);
                            updateNombreCommand.ExecuteNonQuery();
                        }

                        //  Incrémentation du nombre d'exemplaires disponibles
                        string updateLivreQuery = "UPDATE livres SET nbre_exemplaire_dispo = nbre_exemplaire_dispo + 1 WHERE titre_livre = @titreLivre";
                        using (MySqlCommand updateLivreCommand = new MySqlCommand(updateLivreQuery, connection, transaction))
                        {
                            updateLivreCommand.Parameters.AddWithValue("@titreLivre", tbxNomLivre.Text);
                            updateLivreCommand.ExecuteNonQuery();
                        }

                        // Mise à jour de l'état du livre si nécessaire
                        string updateEtatLivreQuery = "UPDATE livres SET etat = 'encours' WHERE titre_livre = @titreLivre AND nbre_exemplaire_dispo > 0";
                        using (MySqlCommand updateEtatLivreCommand = new MySqlCommand(updateEtatLivreQuery, connection, transaction))
                        {
                            updateEtatLivreCommand.Parameters.AddWithValue("@titreLivre", tbxNomLivre.Text);
                            updateEtatLivreCommand.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erreur lors du retour du livre : " + ex.Message);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : " + ex.Message);
                return false;
            }
        }


        // compte livre emprunter
        private int CompterLivresEmpruntes(int idEmprunteur)
        {
            int nombreLivresEmpruntes = 0;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM emprunt WHERE id_emprunteur = @idEmprunteur AND etat = 'emprunter'"; // Compter uniquement les livres empruntés
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@idEmprunteur", idEmprunteur);
                        nombreLivresEmpruntes = Convert.ToInt32(command.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du comptage des livres empruntés : " + ex.Message);
            }

            return nombreLivresEmpruntes;
        }

        // Fonction pour obtenir l'ID de l'emprunteur à partir de son email
        private int ObtenirIdEmprunteur(string emailEmprunteur)
        {
            int idEmprunteur = -1;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id_emprunteur FROM emprunteurs WHERE adresse_mail = @email";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", emailEmprunteur);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            idEmprunteur = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération de l'ID de l'emprunteur : " + ex.Message);
            }

            return idEmprunteur;
        }

        private void btnCan_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérification que l'index de ligne est valide (pas un en-tête)
            if (e.RowIndex >= 0)
            {
                // Récupération de la ligne sélectionnée
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                // Mise à jour des TextBox avec les valeurs de la ligne
                tbxNomLivre.Text = row.Cells["titre_livre"].Value.ToString();
                tbxDatEmprunt.Text = row.Cells["date_emprunt"].Value.ToString();
            }
        }

        private void btn_quit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                this.Close();

            }
        }

        private void FrmRetournerLivre_Load(object sender, EventArgs e)
        {

        }
    }
}
