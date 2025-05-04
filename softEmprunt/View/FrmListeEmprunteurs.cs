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
    public partial class FrmListeEmprunteurs : Form
    {
        private string connectionString = "server=localhost;database=bibliotheque;uid=root;pwd=;";
        private int idBiblioAdmin;
        private int selectedEmprunteurId = -1;

        public FrmListeEmprunteurs(int idBiblio)
        {
            InitializeComponent();
            idBiblioAdmin = idBiblio;
            LoadEmprunteurs();
           
        }

        private void LoadEmprunteurs()
        {
            listView1.Items.Clear();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT id_emprunteur, nom_emprunteur, prenom_emprunteur, adresse_residence, telephone, adresse_mail FROM emprunteurs WHERE id_biblio = @idBiblio";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@idBiblio", idBiblioAdmin);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["id_emprunteur"].ToString());
                        item.SubItems.Add(reader["nom_emprunteur"].ToString());
                        item.SubItems.Add(reader["prenom_emprunteur"].ToString());
                        item.SubItems.Add(reader["adresse_residence"].ToString());
                        item.SubItems.Add(reader["telephone"].ToString());
                        item.SubItems.Add(reader["adresse_mail"].ToString());

                        listView1.Items.Add(item);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors du chargement des emprunteurs: " + ex.Message);
                }
            }
        }



        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (selectedEmprunteurId == -1)
            {
                MessageBox.Show("Veuillez sélectionner un emprunteur à supprimer");
                return;
            }

            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet emprunteur?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "DELETE FROM emprunteurs WHERE id_emprunteur = @id AND id_biblio = @idBiblio";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", selectedEmprunteurId);
                    cmd.Parameters.AddWithValue("@idBiblio", idBiblioAdmin);

                    try
                    {
                        connection.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Emprunteur supprimé avec succès");
                            ClearFields();
                            LoadEmprunteurs();
                            selectedEmprunteurId = -1;
                        }
                        else
                        {
                            MessageBox.Show("Aucun emprunteur supprimé. Vérifiez vos permissions.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression: " + ex.Message);
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                selectedEmprunteurId = int.Parse(selectedItem.SubItems[0].Text);

                tbx_nom.Text = selectedItem.SubItems[1].Text;
                tbx_prenom.Text = selectedItem.SubItems[2].Text;
                tbx_residence.Text = selectedItem.SubItems[3].Text;
                tbx_tel.Text = selectedItem.SubItems[4].Text;
                tbx_email.Text = selectedItem.SubItems[5].Text;
            }
        }

        private void tbx_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            if (selectedEmprunteurId == -1)
            {
                MessageBox.Show("Veuillez sélectionner un emprunteur à modifier");
                return;
            }

            if (string.IsNullOrWhiteSpace(tbx_nom.Text) || string.IsNullOrWhiteSpace(tbx_prenom.Text))
            {
                MessageBox.Show("Le nom et le prénom sont obligatoires");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = @"UPDATE emprunteurs SET 
                                nom_emprunteur = @nom, 
                                prenom_emprunteur = @prenom, 
                                adresse_residence = @adresse, 
                                telephone = @telephone, 
                                adresse_mail = @email
                                WHERE id_emprunteur = @id AND id_biblio = @idBiblio";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@nom", tbx_nom.Text);
                cmd.Parameters.AddWithValue("@prenom", tbx_prenom.Text);
                cmd.Parameters.AddWithValue("@adresse", tbx_residence.Text);
                cmd.Parameters.AddWithValue("@telephone", tbx_tel.Text);
                cmd.Parameters.AddWithValue("@email", tbx_email.Text);
                cmd.Parameters.AddWithValue("@id", selectedEmprunteurId);
                cmd.Parameters.AddWithValue("@idBiblio", idBiblioAdmin);

                try
                {
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Emprunteur modifié avec succès");
                        LoadEmprunteurs();
                    }
                    else
                    {
                        MessageBox.Show("Aucune modification effectuée. Vérifiez vos permissions.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification: " + ex.Message);
                }
            }

        }
        private void ClearFields()
        {
            tbx_nom.Text = "";
            tbx_prenom.Text = "";
            tbx_residence.Text= "";
            tbx_tel.Text = "";
            tbx_email.Text = "";
            selectedEmprunteurId = -1; 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_effacer_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void FrmListeEmprunteurs_Load(object sender, EventArgs e)
        {

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
