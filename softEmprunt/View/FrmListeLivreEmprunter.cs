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
    public partial class FrmListeLivreEmprunter : Form
    {
        private string connectionString = "server=localhost;database=bibliotheque;uid=root;pwd=;";
        public FrmListeLivreEmprunter()
        {
            InitializeComponent();
            ChargerLivresEmpruntes(); // Charger les données au chargement du formulaire
        }
        private void ChargerLivresEmpruntes(string recherche = null)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open(); //l.auteur_livre,
                    string query = "SELECT l.id_livre, l.titre_livre, l.auteur_livre, l.editeur_livre, e.nom_emprunteur, em.date_emprunt, em.date_retour " +
                                   "FROM livres l " +
                                   "INNER JOIN emprunt em ON l.id_livre = em.id_livre " +
                                   "INNER JOIN emprunteurs e ON em.id_emprunteur = e.id_emprunteur " +
                                   "WHERE em.etat = 'emprunter'";

                    if (!string.IsNullOrEmpty(recherche))
                    {
                        query += " AND (l.titre_livre LIKE @recherche OR l.auteur_livre LIKE @recherche OR e.nom_emprunteur LIKE @recherche)";
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

                            listView1.Items.Clear();
                            foreach (DataRow row in dt.Rows)
                            {
                                ListViewItem item = new ListViewItem(row["id_livre"].ToString());
                                item.SubItems.Add(row["titre_livre"].ToString());
                                item.SubItems.Add(row["auteur_livre"].ToString());
                                item.SubItems.Add(row["editeur_livre"].ToString());
                                item.SubItems.Add(row["nom_emprunteur"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(row["date_emprunt"]).ToShortDateString());
                                item.SubItems.Add(Convert.ToDateTime(row["date_retour"]).ToShortDateString());

                              
                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des livres empruntés : " + ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmListeLivreEmprunter_Load(object sender, EventArgs e)
        {

        }

        private void tbx_rechercher_TextChanged(object sender, EventArgs e)
        {
            ChargerLivresEmpruntes(tbx_rechercher.Text);
        }

        private void btn_rechercher_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir quitter ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Fermer le formulaire courant ou l'application entière
                this.Close(); // Ferme le formulaire courant

            }
        }

        private void btn_anuler_Click(object sender, EventArgs e)
        {
            tbx_rechercher.Text = "";
            ChargerLivresEmpruntes();
        }
    }
}
