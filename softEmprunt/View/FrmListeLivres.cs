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
    public partial class FrmListeLivres : Form
    {
        private string connectionString = "server=localhost;database=bibliotheque;uid=root;pwd=;";
        private int idBiblioAdmin;

        public FrmListeLivres(int idBiblio)
        {
            InitializeComponent();
            idBiblioAdmin = idBiblio;
            tbxRechercher.TextChanged += tbxRechercher_TextChanged; // Ajout de l'événement TextChang
            AfficherLivres();
        }

        private void AfficherLivres(string recherche = "")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT id_livre, titre_livre, auteur_livre, editeur_livre, annee_pub, nbre_exemplaire_dispo, etat FROM livres";

                    if (!string.IsNullOrEmpty(recherche))
                    {
                        query += " WHERE titre_livre LIKE @recherche OR auteur_livre LIKE @recherche OR editeur_livre LIKE @recherche";
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(recherche))
                        {
                            command.Parameters.AddWithValue("@recherche", "%" + recherche + "%");
                        }

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            dgvLivres.DataSource = dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'affichage des livres : " + ex.Message);
            }
        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmListeLivres_Load(object sender, EventArgs e)
        {
            AfficherLivres();
        }

        private void tbnModifier_Click(object sender, EventArgs e)
        {
            if (dgvLivres.SelectedRows.Count > 0)
            {
                int idLivre = Convert.ToInt32(dgvLivres.SelectedRows[0].Cells["id_livre"].Value);
                string etatLivre = dgvLivres.SelectedRows[0].Cells["etat"].Value.ToString();

                if (etatLivre == "inactif")
                {
                    MessageBox.Show("Ce livre est actuellement emprunté et ne peut pas être modifié.");
                    return;
                }

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "UPDATE livres SET titre_livre = @titre, auteur_livre = @auteur, editeur_livre = @editeur, " +
                                       "annee_pub = @annee, nbre_exemplaire_dispo = @nbDispo WHERE id_livre = @idLivre";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@idLivre", idLivre);
                            command.Parameters.AddWithValue("@titre", tbx_titre.Text);
                            command.Parameters.AddWithValue("@auteur", tbx_auteur.Text);
                            command.Parameters.AddWithValue("@editeur", tbx_editeur.Text);
                            command.Parameters.AddWithValue("@annee", tbx_anneePub.Text);
                            command.Parameters.AddWithValue("@nbDispo", tbx_nbDispo.Text);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Livre mis à jour avec succès.");
                            AfficherLivres(); // Rafraîchir le DataGridView
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la mise à jour du livre : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un livre à modifier.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvLivres.SelectedRows.Count > 0)
            {
                int idLivre = Convert.ToInt32(dgvLivres.SelectedRows[0].Cells["id_livre"].Value);
                string etatLivre = dgvLivres.SelectedRows[0].Cells["etat"].Value.ToString();

                if (etatLivre == "inactif")
                {
                    MessageBox.Show("Ce livre est actuellement emprunté et ne peut pas être supprimé.");
                    return;
                }

                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM livres WHERE id_livre = @idLivre";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@idLivre", idLivre);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Livre supprimé avec succès.");
                            AfficherLivres(); // Rafraîchir le DataGridView
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression du livre : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un livre à supprimer.");
            }
        }

        private void tbxRechercher_TextChanged(object sender, EventArgs e)
        {
            AfficherLivres(tbxRechercher.Text);
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            tbxRechercher.Text = "";
            AfficherLivres();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvLivres.Rows[e.RowIndex];

                tbx_titre.Text = row.Cells["titre_livre"].Value.ToString();
                tbx_auteur.Text = row.Cells["auteur_livre"].Value.ToString();
                tbx_editeur.Text = row.Cells["editeur_livre"].Value.ToString();
                tbx_anneePub.Text = row.Cells["annee_pub"].Value.ToString();
                tbx_nbDispo.Text = row.Cells["nbre_exemplaire_dispo"].Value.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
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
