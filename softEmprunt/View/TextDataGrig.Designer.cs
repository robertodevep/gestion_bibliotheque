namespace softEmprunt.View
{
    partial class TextDataGrig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAuteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEditeur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAnneePub = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNbrExempDispo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView2 = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNomEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrenomEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colResidense = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTelEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmailEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNomLivre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDatEmprunt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDatRetour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.colTitre,
            this.colAuteur,
            this.colEditeur,
            this.colAnneePub,
            this.colNbrExempDispo});
            this.listView1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(65, -2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(854, 328);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "Id";
            this.id.Width = 34;
            // 
            // colTitre
            // 
            this.colTitre.Text = "Titre";
            this.colTitre.Width = 110;
            // 
            // colAuteur
            // 
            this.colAuteur.Text = "Auteur";
            this.colAuteur.Width = 127;
            // 
            // colEditeur
            // 
            this.colEditeur.Text = "Editeur";
            this.colEditeur.Width = 147;
            // 
            // colAnneePub
            // 
            this.colAnneePub.Text = "Annee Publication";
            this.colAnneePub.Width = 140;
            // 
            // colNbrExempDispo
            // 
            this.colNbrExempDispo.Text = "Nombre exemplaire disponible";
            this.colNbrExempDispo.Width = 280;
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.LimeGreen;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colNomEmp,
            this.colPrenomEmp,
            this.colResidense,
            this.colTelEmp,
            this.colEmailEmp,
            this.colNomLivre,
            this.colDatEmprunt,
            this.colDatRetour});
            this.listView2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(-7, 234);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1284, 341);
            this.listView2.TabIndex = 4;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 34;
            // 
            // colNomEmp
            // 
            this.colNomEmp.Text = "NomEmp";
            this.colNomEmp.Width = 110;
            // 
            // colPrenomEmp
            // 
            this.colPrenomEmp.Text = "Prenom";
            this.colPrenomEmp.Width = 127;
            // 
            // colResidense
            // 
            this.colResidense.Text = "Residence";
            this.colResidense.Width = 147;
            // 
            // colTelEmp
            // 
            this.colTelEmp.Text = "TelephoneEmprunt";
            this.colTelEmp.Width = 157;
            // 
            // colEmailEmp
            // 
            this.colEmailEmp.Text = "Email";
            this.colEmailEmp.Width = 183;
            // 
            // colNomLivre
            // 
            this.colNomLivre.Text = "Nom Livre";
            this.colNomLivre.Width = 137;
            // 
            // colDatEmprunt
            // 
            this.colDatEmprunt.Text = "Date Emprunt";
            this.colDatEmprunt.Width = 158;
            // 
            // colDatRetour
            // 
            this.colDatRetour.Text = "Date Retour";
            this.colDatRetour.Width = 122;
            // 
            // TextDataGrig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 735);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Name = "TextDataGrig";
            this.Text = "TextDataGrig";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader colTitre;
        private System.Windows.Forms.ColumnHeader colAuteur;
        private System.Windows.Forms.ColumnHeader colEditeur;
        private System.Windows.Forms.ColumnHeader colAnneePub;
        private System.Windows.Forms.ColumnHeader colNbrExempDispo;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNomEmp;
        private System.Windows.Forms.ColumnHeader colPrenomEmp;
        private System.Windows.Forms.ColumnHeader colResidense;
        private System.Windows.Forms.ColumnHeader colTelEmp;
        private System.Windows.Forms.ColumnHeader colEmailEmp;
        private System.Windows.Forms.ColumnHeader colNomLivre;
        private System.Windows.Forms.ColumnHeader colDatEmprunt;
        private System.Windows.Forms.ColumnHeader colDatRetour;

    }
}