namespace softEmprunt.View
{
    partial class FrmListeLivreEmprunter
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
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAuteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEditeur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateEmprunt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateRetour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Button();
            this.tbx_rechercher = new System.Windows.Forms.TextBox();
            this.btn_anuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTitre,
            this.colAuteur,
            this.colEditeur,
            this.colNom,
            this.colDateEmprunt,
            this.colDateRetour});
            this.listView1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(26, 106);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1030, 456);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 34;
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
            // colNom
            // 
            this.colNom.Text = "Nom Emprunteurs";
            this.colNom.Width = 183;
            // 
            // colDateEmprunt
            // 
            this.colDateEmprunt.Text = "Date Emprunt";
            this.colDateEmprunt.Width = 137;
            // 
            // colDateRetour
            // 
            this.colDateRetour.Text = "Date Retour";
            this.colDateRetour.Width = 122;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "LISTE DES LIVRES EMPRUNTER";
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(911, 42);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(117, 32);
            this.btn_quit.TabIndex = 4;
            this.btn_quit.Text = "QUITTER";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_rechercher_Click);
            // 
            // tbx_rechercher
            // 
            this.tbx_rechercher.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_rechercher.Location = new System.Drawing.Point(538, 41);
            this.tbx_rechercher.Name = "tbx_rechercher";
            this.tbx_rechercher.Size = new System.Drawing.Size(183, 28);
            this.tbx_rechercher.TabIndex = 6;
            this.tbx_rechercher.TextChanged += new System.EventHandler(this.tbx_rechercher_TextChanged);
            // 
            // btn_anuler
            // 
            this.btn_anuler.Location = new System.Drawing.Point(754, 42);
            this.btn_anuler.Name = "btn_anuler";
            this.btn_anuler.Size = new System.Drawing.Size(127, 32);
            this.btn_anuler.TabIndex = 7;
            this.btn_anuler.Text = "ANNULER";
            this.btn_anuler.UseVisualStyleBackColor = true;
            this.btn_anuler.Click += new System.EventHandler(this.btn_anuler_Click);
            // 
            // FrmListeLivreEmprunter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1068, 601);
            this.Controls.Add(this.btn_anuler);
            this.Controls.Add(this.tbx_rechercher);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "FrmListeLivreEmprunter";
            this.Text = "FrmListeLivreEmprunter";
            this.Load += new System.EventHandler(this.FrmListeLivreEmprunter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colTitre;
        private System.Windows.Forms.ColumnHeader colAuteur;
        private System.Windows.Forms.ColumnHeader colEditeur;
        private System.Windows.Forms.ColumnHeader colNom;
        private System.Windows.Forms.ColumnHeader colDateEmprunt;
        private System.Windows.Forms.ColumnHeader colDateRetour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.TextBox tbx_rechercher;
        private System.Windows.Forms.Button btn_anuler;
    }
}