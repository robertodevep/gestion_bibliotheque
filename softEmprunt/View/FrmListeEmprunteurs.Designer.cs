namespace softEmprunt.View
{
    partial class FrmListeEmprunteurs
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
            this.colNomEmprunteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrenomEmpruneur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colResidenceEmprunteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTelephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmailEmprunteur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_effacer = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.tbx_email = new System.Windows.Forms.TextBox();
            this.tbx_tel = new System.Windows.Forms.TextBox();
            this.tbx_residence = new System.Windows.Forms.TextBox();
            this.tbx_prenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colNomEmprunteur,
            this.colPrenomEmpruneur,
            this.colResidenceEmprunteur,
            this.colTelephone,
            this.colEmailEmprunteur});
            this.listView1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(530, 62);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(888, 484);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 34;
            // 
            // colNomEmprunteur
            // 
            this.colNomEmprunteur.Text = "Nom";
            this.colNomEmprunteur.Width = 110;
            // 
            // colPrenomEmpruneur
            // 
            this.colPrenomEmpruneur.Text = "Prenom";
            this.colPrenomEmpruneur.Width = 127;
            // 
            // colResidenceEmprunteur
            // 
            this.colResidenceEmprunteur.Text = "Residence";
            this.colResidenceEmprunteur.Width = 180;
            // 
            // colTelephone
            // 
            this.colTelephone.Text = "Telephone";
            this.colTelephone.Width = 172;
            // 
            // colEmailEmprunteur
            // 
            this.colEmailEmprunteur.Text = "Email";
            this.colEmailEmprunteur.Width = 183;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_effacer);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_modifier);
            this.panel2.Controls.Add(this.btn_quit);
            this.panel2.Controls.Add(this.tbx_email);
            this.panel2.Controls.Add(this.tbx_tel);
            this.panel2.Controls.Add(this.tbx_residence);
            this.panel2.Controls.Add(this.tbx_prenom);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbx_nom);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(524, 565);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_effacer
            // 
            this.btn_effacer.Location = new System.Drawing.Point(174, 462);
            this.btn_effacer.Name = "btn_effacer";
            this.btn_effacer.Size = new System.Drawing.Size(123, 35);
            this.btn_effacer.TabIndex = 14;
            this.btn_effacer.Text = "Effacer";
            this.btn_effacer.UseVisualStyleBackColor = true;
            this.btn_effacer.Click += new System.EventHandler(this.btn_effacer_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(174, 401);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(123, 35);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(356, 401);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(124, 35);
            this.btn_modifier.TabIndex = 12;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.Location = new System.Drawing.Point(356, 462);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(124, 35);
            this.btn_quit.TabIndex = 10;
            this.btn_quit.Text = "Quitter";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // tbx_email
            // 
            this.tbx_email.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_email.Location = new System.Drawing.Point(190, 329);
            this.tbx_email.Name = "tbx_email";
            this.tbx_email.Size = new System.Drawing.Size(290, 31);
            this.tbx_email.TabIndex = 9;
            // 
            // tbx_tel
            // 
            this.tbx_tel.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_tel.Location = new System.Drawing.Point(190, 257);
            this.tbx_tel.Name = "tbx_tel";
            this.tbx_tel.Size = new System.Drawing.Size(290, 31);
            this.tbx_tel.TabIndex = 8;
            // 
            // tbx_residence
            // 
            this.tbx_residence.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_residence.Location = new System.Drawing.Point(190, 190);
            this.tbx_residence.Name = "tbx_residence";
            this.tbx_residence.Size = new System.Drawing.Size(290, 31);
            this.tbx_residence.TabIndex = 7;
            // 
            // tbx_prenom
            // 
            this.tbx_prenom.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_prenom.Location = new System.Drawing.Point(190, 124);
            this.tbx_prenom.Name = "tbx_prenom";
            this.tbx_prenom.Size = new System.Drawing.Size(290, 31);
            this.tbx_prenom.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "PRENOM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "RESIDENCE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "TELEPHONE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "EMAIL";
            // 
            // tbx_nom
            // 
            this.tbx_nom.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nom.Location = new System.Drawing.Point(190, 62);
            this.tbx_nom.Name = "tbx_nom";
            this.tbx_nom.Size = new System.Drawing.Size(290, 31);
            this.tbx_nom.TabIndex = 1;
            this.tbx_nom.TextChanged += new System.EventHandler(this.tbx_nom_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(800, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 27);
            this.label6.TabIndex = 5;
            this.label6.Text = "LISTE DES EMPRUNTEURS";
            // 
            // FrmListeEmprunteurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1430, 565);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Name = "FrmListeEmprunteurs";
            this.Text = "FrmListeEmprunteurs";
            this.Load += new System.EventHandler(this.FrmListeEmprunteurs_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colNomEmprunteur;
        private System.Windows.Forms.ColumnHeader colPrenomEmpruneur;
        private System.Windows.Forms.ColumnHeader colResidenceEmprunteur;
        private System.Windows.Forms.ColumnHeader colTelephone;
        private System.Windows.Forms.ColumnHeader colEmailEmprunteur;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.TextBox tbx_email;
        private System.Windows.Forms.TextBox tbx_tel;
        private System.Windows.Forms.TextBox tbx_residence;
        private System.Windows.Forms.TextBox tbx_prenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_effacer;
        private System.Windows.Forms.Label label6;
    }
}