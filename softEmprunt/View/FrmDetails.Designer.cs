namespace softEmprunt.View
{
    partial class FrmDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitreLivre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEditeur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNbrExemp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateEmp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateRetour = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.IdR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNomEmpR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colResidenceR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTelR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmailR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTitreLivreR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEditeurR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNbreExempR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDateEmpR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDatRetourR = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxTotaLivre = new System.Windows.Forms.TextBox();
            this.tbxNbrEmprunteur = new System.Windows.Forms.TextBox();
            this.tbxNbLivDispo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_rechercherLivreEmp = new System.Windows.Forms.TextBox();
            this.btn_annuleremp = new System.Windows.Forms.Button();
            this.tbxrechercherRetour = new System.Windows.Forms.TextBox();
            this.btn_annulerRetour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "DETAILLE DES LIVRES EMPRUNTER";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colTitreLivre,
            this.colEditeur,
            this.colNbrExemp,
            this.colDateEmp,
            this.colDateRetour});
            this.listView1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(30, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1349, 218);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 162;
            // 
            // colTitreLivre
            // 
            this.colTitreLivre.Text = "Titre Livre";
            this.colTitreLivre.Width = 128;
            // 
            // colEditeur
            // 
            this.colEditeur.Text = "Editeur Livre";
            this.colEditeur.Width = 125;
            // 
            // colNbrExemp
            // 
            this.colNbrExemp.Text = "Nombre Exemplaire";
            this.colNbrExemp.Width = 181;
            // 
            // colDateEmp
            // 
            this.colDateEmp.Text = "Date Emprunt";
            this.colDateEmp.Width = 133;
            // 
            // colDateRetour
            // 
            this.colDateRetour.Text = "Date Retour";
            this.colDateRetour.Width = 128;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(345, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "DETAILLE DES LIVRES RETOURNER";
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.Color.White;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdR,
            this.colNomEmpR,
            this.colResidenceR,
            this.colTelR,
            this.colEmailR,
            this.colTitreLivreR,
            this.colEditeurR,
            this.colNbreExempR,
            this.colDateEmpR,
            this.colDatRetourR});
            this.listView2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(30, 382);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1367, 288);
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // IdR
            // 
            this.IdR.Text = "Id";
            this.IdR.Width = 34;
            // 
            // colNomEmpR
            // 
            this.colNomEmpR.Text = "Nom Emprunteur";
            this.colNomEmpR.Width = 158;
            // 
            // colResidenceR
            // 
            this.colResidenceR.Text = "Residence";
            this.colResidenceR.Width = 114;
            // 
            // colTelR
            // 
            this.colTelR.Text = "TelephoneEmprunt";
            this.colTelR.Width = 172;
            // 
            // colEmailR
            // 
            this.colEmailR.Text = "Email";
            this.colEmailR.Width = 146;
            // 
            // colTitreLivreR
            // 
            this.colTitreLivreR.Text = "Titre Livre";
            this.colTitreLivreR.Width = 137;
            // 
            // colEditeurR
            // 
            this.colEditeurR.Text = "Editeur Livre";
            this.colEditeurR.Width = 121;
            // 
            // colNbreExempR
            // 
            this.colNbreExempR.Text = "Nombre Exemplaire";
            this.colNbreExempR.Width = 176;
            // 
            // colDateEmpR
            // 
            this.colDateEmpR.Text = "Date Emprunt";
            this.colDateEmpR.Width = 134;
            // 
            // colDatRetourR
            // 
            this.colDatRetourR.Text = "Date Retour";
            this.colDatRetourR.Width = 125;
            // 
            // tbxTotaLivre
            // 
            this.tbxTotaLivre.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotaLivre.Location = new System.Drawing.Point(735, 304);
            this.tbxTotaLivre.Name = "tbxTotaLivre";
            this.tbxTotaLivre.Size = new System.Drawing.Size(60, 33);
            this.tbxTotaLivre.TabIndex = 10;
            this.tbxTotaLivre.TextChanged += new System.EventHandler(this.tbxTotaLivre_TextChanged);
            // 
            // tbxNbrEmprunteur
            // 
            this.tbxNbrEmprunteur.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNbrEmprunteur.Location = new System.Drawing.Point(279, 298);
            this.tbxNbrEmprunteur.Name = "tbxNbrEmprunteur";
            this.tbxNbrEmprunteur.Size = new System.Drawing.Size(60, 33);
            this.tbxNbrEmprunteur.TabIndex = 11;
            this.tbxNbrEmprunteur.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbxNbLivDispo
            // 
            this.tbxNbLivDispo.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNbLivDispo.Location = new System.Drawing.Point(453, 9);
            this.tbxNbLivDispo.Name = "tbxNbLivDispo";
            this.tbxNbLivDispo.Size = new System.Drawing.Size(54, 33);
            this.tbxNbLivDispo.TabIndex = 12;
            this.tbxNbLivDispo.TextChanged += new System.EventHandler(this.tbxNbLivDispo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nombre d\'Emprunteurs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(812, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nombre Total de Livre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(408, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nombre D\'Exemplaire De Livre Disponible";
            // 
            // tbx_rechercherLivreEmp
            // 
            this.tbx_rechercherLivreEmp.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_rechercherLivreEmp.Location = new System.Drawing.Point(918, 11);
            this.tbx_rechercherLivreEmp.Name = "tbx_rechercherLivreEmp";
            this.tbx_rechercherLivreEmp.Size = new System.Drawing.Size(156, 33);
            this.tbx_rechercherLivreEmp.TabIndex = 16;
            this.tbx_rechercherLivreEmp.TextChanged += new System.EventHandler(this.tbx_rechercherLivreEmp_TextChanged);
            // 
            // btn_annuleremp
            // 
            this.btn_annuleremp.BackColor = System.Drawing.Color.White;
            this.btn_annuleremp.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuleremp.Location = new System.Drawing.Point(1153, 7);
            this.btn_annuleremp.Name = "btn_annuleremp";
            this.btn_annuleremp.Size = new System.Drawing.Size(107, 39);
            this.btn_annuleremp.TabIndex = 17;
            this.btn_annuleremp.Text = "Annuler";
            this.btn_annuleremp.UseVisualStyleBackColor = false;
            this.btn_annuleremp.Click += new System.EventHandler(this.btn_annuleremp_Click);
            // 
            // tbxrechercherRetour
            // 
            this.tbxrechercherRetour.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxrechercherRetour.Location = new System.Drawing.Point(1051, 301);
            this.tbxrechercherRetour.Name = "tbxrechercherRetour";
            this.tbxrechercherRetour.Size = new System.Drawing.Size(156, 33);
            this.tbxrechercherRetour.TabIndex = 18;
            this.tbxrechercherRetour.TextChanged += new System.EventHandler(this.tbxrechercherRetour_TextChanged);
            // 
            // btn_annulerRetour
            // 
            this.btn_annulerRetour.BackColor = System.Drawing.Color.White;
            this.btn_annulerRetour.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annulerRetour.Location = new System.Drawing.Point(1246, 295);
            this.btn_annulerRetour.Name = "btn_annulerRetour";
            this.btn_annulerRetour.Size = new System.Drawing.Size(117, 39);
            this.btn_annulerRetour.TabIndex = 20;
            this.btn_annulerRetour.Text = "Annuler";
            this.btn_annulerRetour.UseVisualStyleBackColor = false;
            this.btn_annulerRetour.Click += new System.EventHandler(this.btn_annulerRetour_Click);
            // 
            // FrmDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1416, 699);
            this.Controls.Add(this.btn_annulerRetour);
            this.Controls.Add(this.tbxrechercherRetour);
            this.Controls.Add(this.btn_annuleremp);
            this.Controls.Add(this.tbx_rechercherLivreEmp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxNbLivDispo);
            this.Controls.Add(this.tbxNbrEmprunteur);
            this.Controls.Add(this.tbxTotaLivre);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetails";
            this.Text = "FrmDetaille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colTitreLivre;
        private System.Windows.Forms.ColumnHeader colEditeur;
        private System.Windows.Forms.ColumnHeader colNbrExemp;
        private System.Windows.Forms.ColumnHeader colDateEmp;
        private System.Windows.Forms.ColumnHeader colDateRetour;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader IdR;
        private System.Windows.Forms.ColumnHeader colNomEmpR;
        private System.Windows.Forms.ColumnHeader colResidenceR;
        private System.Windows.Forms.ColumnHeader colTelR;
        private System.Windows.Forms.ColumnHeader colEmailR;
        private System.Windows.Forms.ColumnHeader colTitreLivreR;
        private System.Windows.Forms.ColumnHeader colEditeurR;
        private System.Windows.Forms.ColumnHeader colNbreExempR;
        private System.Windows.Forms.ColumnHeader colDateEmpR;
        private System.Windows.Forms.ColumnHeader colDatRetourR;
        private System.Windows.Forms.TextBox tbxTotaLivre;
        private System.Windows.Forms.TextBox tbxNbrEmprunteur;
        private System.Windows.Forms.TextBox tbxNbLivDispo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_rechercherLivreEmp;
        private System.Windows.Forms.Button btn_annuleremp;
        private System.Windows.Forms.TextBox tbxrechercherRetour;
        private System.Windows.Forms.Button btn_annulerRetour;
    }
}