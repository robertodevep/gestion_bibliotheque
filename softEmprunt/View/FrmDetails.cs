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
    public partial class FrmDetails : Form
    {
        private string connectionString = "server=localhost;database=bibliotheque;uid=root;pwd=;";
        public FrmDetails()
        {
            InitializeComponent();
            LoadDetailsLivres();
            AfficherStatistiques();
            LoadLivresRetournes();
            tbx_rechercherLivreEmp.TextChanged += tbx_rechercherLivreEmp_TextChanged;
            tbxrechercherRetour.TextChanged += tbxrechercherRetour_TextChanged;
        }

        private void LoadDetailsLivres(string recherche = "")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT l.id_livre, l.titre_livre, l.auteur_livre, 
                                     e.nom_emprunteur, e.prenom_emprunteur, 
                                     em.date_emprunt, em.date_retour, em.nombre_emprunt
                                     FROM emprunt em
                                     JOIN livres l ON em.id_livre = l.id_livre
                                     JOIN emprunteurs e ON em.id_emprunteur = e.id_emprunteur
                                     WHERE em.etat = 'emprunter'";

                    if (!string.IsNullOrEmpty(recherche))
                    {
                        query += @" AND (l.titre_livre LIKE @recherche OR 
                                         e.nom_emprunteur LIKE @recherche OR 
                                         e.prenom_emprunteur LIKE @recherche OR
                                         em.date_emprunt LIKE @recherche OR
                                         em.date_retour LIKE @recherche)";
                    }

                    query += " ORDER BY em.date_retour";

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

                            listView1.View = System.Windows.Forms.View.Details;
                            listView1.FullRowSelect = true;
                            listView1.GridLines = true;

                            listView1.Columns.Clear();
                            listView1.Columns.Add("ID Livre", 80);
                            listView1.Columns.Add("Titre", 200);
                            listView1.Columns.Add("Auteur", 150);
                            listView1.Columns.Add("Emprunteur", 150);
                            listView1.Columns.Add("Date Emprunt", 100);
                            listView1.Columns.Add("Date Retour", 100);
                            listView1.Columns.Add("Nombre Exemplaire", 200);

                            listView1.Items.Clear();
                            foreach (DataRow row in dt.Rows)
                            {
                                ListViewItem item = new ListViewItem(row["id_livre"].ToString());
                                item.SubItems.Add(row["titre_livre"].ToString());
                                item.SubItems.Add(row["auteur_livre"].ToString());
                                item.SubItems.Add(row["prenom_emprunteur"].ToString() + " " + row["nom_emprunteur"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(row["date_emprunt"]).ToShortDateString());
                                item.SubItems.Add(Convert.ToDateTime(row["date_retour"]).ToShortDateString());
                                item.SubItems.Add(row["nombre_emprunt"].ToString());

                                listView1.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des détails: " + ex.Message);
            }
        }

        private void AfficherStatistiques()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string queryTotal = "SELECT SUM(nbre_exemplaire_dispo) FROM livres WHERE etat = 'encours'";
                    using (MySqlCommand cmdTotal = new MySqlCommand(queryTotal, connection))
                    {
                        object resultTotal = cmdTotal.ExecuteScalar();
                        tbxNbLivDispo.Text = resultTotal != DBNull.Value ? resultTotal.ToString() : "0";
                    }

                    string queryTotalLivres = "SELECT COUNT(id_livre) FROM livres; ";
                    using (MySqlCommand cmdTotalLivres = new MySqlCommand(queryTotalLivres, connection))
                    {
                        object resultTotalLivres = cmdTotalLivres.ExecuteScalar();
                        tbxTotaLivre.Text = resultTotalLivres != DBNull.Value ? resultTotalLivres.ToString() : "0";
                    }

                    string queryEmprunts = @"SELECT COUNT(DISTINCT e.id_emprunteur) 
                                             FROM emprunteurs e
                                             INNER JOIN emprunt em ON e.id_emprunteur = em.id_emprunteur
                                             WHERE em.etat = 'emprunter' ";
                    using (MySqlCommand cmdEmprunts = new MySqlCommand(queryEmprunts, connection))
                    {
                        tbxNbrEmprunteur.Text = cmdEmprunts.ExecuteScalar().ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des statistiques: " + ex.Message);
            }
        }

        // listview qui gere le Detai des livre retourner

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView2.SelectedItems[0];
               // textBox2.Text = selectedItem.SubItems[1].Text; // Affiche le titre du livre sélectionné
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];
                //textBox2.Text = selectedItem.SubItems[1].Text; // Affiche le titre du livre sélectionné
            }
        }

        private void btnRafraichir_Click(object sender, EventArgs e)
        {
            LoadDetailsLivres();
            AfficherStatistiques();
            LoadLivresRetournes();
            MessageBox.Show("Données rafraîchies avec succès!");
        }
        private void tbxNbLivDispo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbxTotaLivre_TextChanged(object sender, EventArgs e)
        {

        }

        // PARTIE DU CODE QUI GERE LE DETAIL DES LIVRE RETOURNER


        private void LoadLivresRetournes(string recherche = "")
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"SELECT l.id_livre, l.titre_livre, l.auteur_livre, 
                                     e.nom_emprunteur, e.prenom_emprunteur, 
                                     em.date_emprunt, em.date_retour
                                     FROM emprunt em
                                     JOIN livres l ON em.id_livre = l.id_livre
                                     JOIN emprunteurs e ON em.id_emprunteur = e.id_emprunteur
                                     WHERE em.etat = 'rendu'";

                    if (!string.IsNullOrEmpty(recherche))
                    {
                        query += @" AND (l.titre_livre LIKE @recherche OR 
                                         e.nom_emprunteur LIKE @recherche OR 
                                         e.prenom_emprunteur LIKE @recherche OR
                                         em.date_emprunt LIKE @recherche OR
                                         em.date_retour LIKE @recherche)";
                    }

                    query += " ORDER BY em.date_retour DESC";

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

                            listView2.View = System.Windows.Forms.View.Details;
                            listView2.FullRowSelect = true;
                            listView2.GridLines = true;

                            listView2.Columns.Clear();
                            listView2.Columns.Add("ID Livre", 80);
                            listView2.Columns.Add("Titre", 200);
                            listView2.Columns.Add("Auteur", 150);
                            listView2.Columns.Add("Emprunteur", 150);
                            listView2.Columns.Add("Date Emprunt", 100);
                            listView2.Columns.Add("Date Retour Prévu", 120);

                            listView2.Items.Clear();
                            foreach (DataRow row in dt.Rows)
                            {
                                ListViewItem item = new ListViewItem(row["id_livre"].ToString());
                                item.SubItems.Add(row["titre_livre"].ToString());
                                item.SubItems.Add(row["auteur_livre"].ToString());
                                item.SubItems.Add(row["prenom_emprunteur"].ToString() + " " + row["nom_emprunteur"].ToString());
                                item.SubItems.Add(Convert.ToDateTime(row["date_emprunt"]).ToShortDateString());
                                item.SubItems.Add(Convert.ToDateTime(row["date_retour"]).ToShortDateString());

                                listView2.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des livres retournés: " + ex.Message);
            }
        }


        private void tbx_rechercherLivreEmp_TextChanged(object sender, EventArgs e)
        {
            LoadDetailsLivres(tbx_rechercherLivreEmp.Text);
        }

        private void btn_annuleremp_Click(object sender, EventArgs e)
        {
            tbx_rechercherLivreEmp.Text = "";
            LoadDetailsLivres(tbx_rechercherLivreEmp.Text);
        }

        private void tbxrechercherRetour_TextChanged(object sender, EventArgs e)
        {
            LoadLivresRetournes(tbxrechercherRetour.Text);
        }

        private void btn_annulerRetour_Click(object sender, EventArgs e)
        {
            tbxrechercherRetour.Text = "";
            LoadLivresRetournes(tbxrechercherRetour.Text);
        }
    }
}
