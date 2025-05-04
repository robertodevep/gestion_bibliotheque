
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
    public partial class FrmEmpruntLivre : Form
    {
        private string connectionString = "server=localhost;database=bibliotheque;uid=root;pwd=;";
        public FrmEmpruntLivre()
        {
            InitializeComponent();
            LoadLivres();
            LoadEmprunteurs();
        }

        private void LoadLivres()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id_livre, titre_livre FROM livres WHERE etat = 'encours' AND nbre_exemplaire_dispo > 0"; // Seuls les livres disponibles
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            cmbLivre.DataSource = dt;
                            cmbLivre.DisplayMember = "titre_livre";
                            cmbLivre.ValueMember = "id_livre";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des livres : " + ex.Message);
            }
        }

        private void LoadEmprunteurs()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id_emprunteur, nom_emprunteur FROM emprunteurs";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            cmbxNom.DataSource = dt;
                            cmbxNom.DisplayMember = "nom_emprunteur";
                            cmbxNom.ValueMember = "id_emprunteur";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des emprunteurs : " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


        private void btnSave_Click(object sender, EventArgs e)
        {

            int idLivre = Convert.ToInt32(cmbLivre.SelectedValue);
            int idEmprunteur = Convert.ToInt32(cmbxNom.SelectedValue);
            DateTime dateEmprunt = dtpDateEmprunt.Value;
            DateTime dateRetour = dtpDateRetour.Value;

            // Vérification du nombre d'emprunts en cours
            int nombreEmpruntsEnCours = CompterLivresEmpruntes(idEmprunteur);
            if (nombreEmpruntsEnCours >= 3)
            {
                MessageBox.Show("Cet emprunteur a déjà emprunté 3 livres. Il doit retourner un livre avant de pouvoir en emprunter un nouveau.");
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlTransaction transaction = connection.BeginTransaction();

                    try
                    {
                        // Vérifier que le livre est toujours disponible
                        string queryCheckDispo = "SELECT nbre_exemplaire_dispo, etat FROM livres WHERE id_livre = @idLivre FOR UPDATE";
                        int quantiteDisponible;
                        string etatLivre;

                        using (MySqlCommand commandCheck = new MySqlCommand(queryCheckDispo, connection, transaction))
                        {
                            commandCheck.Parameters.AddWithValue("@idLivre", idLivre);
                            // Exécution de la requête et lecture des résultats
                            using (MySqlDataReader reader = commandCheck.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    quantiteDisponible = reader.GetInt32("nbre_exemplaire_dispo");
                                    etatLivre = reader.GetString("etat");
                                }
                                else
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Livre non trouvé.");
                                    return;
                                }
                            }
                        }

                        if (quantiteDisponible <= 0 || etatLivre != "encours")
                        {
                            transaction.Rollback();
                            MessageBox.Show("Ce livre n'est plus disponible pour l'emprunt.");
                            return;
                        }

                        //  Calculer le nouveau nombre_emprunt
                        int nouveauNombreEmprunt = nombreEmpruntsEnCours + 1;

                        // 3. Enregistrer l'emprunt avec le nombre_emprunt
                        string queryEmprunt = "INSERT INTO emprunt (id_livre, id_emprunteur, date_emprunt, date_retour, etat, nombre_emprunt) " +
                                            "VALUES (@idLivre, @idEmprunteur, @dateEmprunt, @dateRetour, 'emprunter', @nombreEmprunt)";

                        using (MySqlCommand commandEmprunt = new MySqlCommand(queryEmprunt, connection, transaction))
                        {
                            commandEmprunt.Parameters.AddWithValue("@idLivre", idLivre);
                            commandEmprunt.Parameters.AddWithValue("@idEmprunteur", idEmprunteur);
                            commandEmprunt.Parameters.AddWithValue("@dateEmprunt", dateEmprunt);
                            commandEmprunt.Parameters.AddWithValue("@dateRetour", dateRetour);
                            commandEmprunt.Parameters.AddWithValue("@nombreEmprunt", nouveauNombreEmprunt);
                            commandEmprunt.ExecuteNonQuery();
                        }

                        // Décrémenter la quantité disponible
                        string queryUpdateQuantite = "UPDATE livres SET nbre_exemplaire_dispo = nbre_exemplaire_dispo - 1 WHERE id_livre = @idLivre";
                        using (MySqlCommand commandUpdateQuantite = new MySqlCommand(queryUpdateQuantite, connection, transaction))
                        {
                            commandUpdateQuantite.Parameters.AddWithValue("@idLivre", idLivre);
                            commandUpdateQuantite.ExecuteNonQuery();
                        }

                        // Vérifier si la quantité est 0 et mettre à jour l'état
                        if (quantiteDisponible == 1) // Car on vient de décrémenter
                        {
                            string queryUpdateEtat = "UPDATE livres SET etat = 'inactif' WHERE id_livre = @idLivre";
                            using (MySqlCommand commandUpdateEtat = new MySqlCommand(queryUpdateEtat, connection, transaction))
                            {
                                commandUpdateEtat.Parameters.AddWithValue("@idLivre", idLivre);
                                commandUpdateEtat.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();
                        MessageBox.Show("Emprunt enregistré avec succès.");
                        LoadLivres();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Erreur lors de l'enregistrement de l'emprunt : " + ex.Message);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la connexion à la base de données : " + ex.Message);
            }
        }

        

        // la méthode CompterLivresEmpruntes
        public int CompterLivresEmpruntes(int idEmprunteur)
        {
            int nombreLivresEmpruntes = 0;
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM emprunt WHERE id_emprunteur = @idEmprunteur AND etat = 'emprunter'";
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


        private void FrmEmpruntLivre_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                this.Close(); 

            }
        }
    }
}