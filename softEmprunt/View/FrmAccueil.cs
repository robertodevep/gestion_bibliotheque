using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softEmprunt.View
{
    public partial class FrmAccueil : Form
    {
        private int idBiblioAdmin;

        public FrmAccueil(int idBiblio)
        {
            
            idBiblioAdmin = idBiblio;

            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void ajouterLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddLivre f = new FrmAddLivre(idBiblioAdmin);
              f.Show();

        }

        private void FrmAccueil_Load(object sender, EventArgs e)
        {

        }

        private void listeDesLivresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeLivres l = new FrmListeLivres(idBiblioAdmin);
            l.Show();
        }

        private void ajouterEmprunteurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddEmprunteurs1 h = new FrmAddEmprunteurs1(idBiblioAdmin);
                h.Show();
        }

        private void listeDesEmprunteursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeEmprunteurs le = new FrmListeEmprunteurs(idBiblioAdmin);
            le.Show();
        }

        private void ajouterEmpruntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpruntLivre el = new FrmEmpruntLivre();
               el.Show();
        }

        private void listeEmpruntToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListeLivreEmprunter ele = new FrmListeLivreEmprunter();
            ele.Show();
        }

        private void retournerLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRetournerLivre re = new FrmRetournerLivre();
            re.Show();
        }

        private void detailleLivreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDetails de = new FrmDetails();
            de.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
