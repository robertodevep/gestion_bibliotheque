namespace softEmprunt.View
{
    partial class FrmListeLivres
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.tbxRechercher = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbx_auteur = new System.Windows.Forms.TextBox();
            this.tbx_editeur = new System.Windows.Forms.TextBox();
            this.tbx_nbDispo = new System.Windows.Forms.TextBox();
            this.tbx_anneePub = new System.Windows.Forms.TextBox();
            this.tbx_titre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbnModifier = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvLivres = new System.Windows.Forms.DataGridView();
            this.btn_quit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.btnAnnuler);
            this.panel1.Controls.Add(this.tbxRechercher);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 75);
            this.panel1.TabIndex = 0;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(804, 20);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(113, 36);
            this.btnAnnuler.TabIndex = 2;
            this.btnAnnuler.Text = "ANNULER";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // tbxRechercher
            // 
            this.tbxRechercher.Location = new System.Drawing.Point(516, 24);
            this.tbxRechercher.Name = "tbxRechercher";
            this.tbxRechercher.Size = new System.Drawing.Size(227, 26);
            this.tbxRechercher.TabIndex = 3;
            this.tbxRechercher.TextChanged += new System.EventHandler(this.tbxRechercher_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(384, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "RECHERCHER";
            // 
            // tbx_auteur
            // 
            this.tbx_auteur.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_auteur.Location = new System.Drawing.Point(45, 193);
            this.tbx_auteur.Name = "tbx_auteur";
            this.tbx_auteur.Size = new System.Drawing.Size(237, 31);
            this.tbx_auteur.TabIndex = 13;
            // 
            // tbx_editeur
            // 
            this.tbx_editeur.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_editeur.Location = new System.Drawing.Point(48, 262);
            this.tbx_editeur.Name = "tbx_editeur";
            this.tbx_editeur.Size = new System.Drawing.Size(237, 31);
            this.tbx_editeur.TabIndex = 12;
            // 
            // tbx_nbDispo
            // 
            this.tbx_nbDispo.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_nbDispo.Location = new System.Drawing.Point(45, 409);
            this.tbx_nbDispo.Name = "tbx_nbDispo";
            this.tbx_nbDispo.Size = new System.Drawing.Size(237, 31);
            this.tbx_nbDispo.TabIndex = 11;
            // 
            // tbx_anneePub
            // 
            this.tbx_anneePub.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_anneePub.Location = new System.Drawing.Point(45, 337);
            this.tbx_anneePub.Name = "tbx_anneePub";
            this.tbx_anneePub.Size = new System.Drawing.Size(237, 31);
            this.tbx_anneePub.TabIndex = 10;
            // 
            // tbx_titre
            // 
            this.tbx_titre.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_titre.Location = new System.Drawing.Point(45, 123);
            this.tbx_titre.Name = "tbx_titre";
            this.tbx_titre.Size = new System.Drawing.Size(237, 31);
            this.tbx_titre.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "AUTEUR";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "EDITEUR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "NOMBRE DISPONIBLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "ANNEE DE PUBLICATION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "TITRE";
            // 
            // tbnModifier
            // 
            this.tbnModifier.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnModifier.Location = new System.Drawing.Point(347, 473);
            this.tbnModifier.Name = "tbnModifier";
            this.tbnModifier.Size = new System.Drawing.Size(156, 45);
            this.tbnModifier.TabIndex = 19;
            this.tbnModifier.Text = "UPDATE";
            this.tbnModifier.UseVisualStyleBackColor = true;
            this.tbnModifier.Click += new System.EventHandler(this.tbnModifier_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(587, 473);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(156, 45);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvLivres
            // 
            this.dgvLivres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivres.Location = new System.Drawing.Point(315, 108);
            this.dgvLivres.Name = "dgvLivres";
            this.dgvLivres.RowTemplate.Height = 28;
            this.dgvLivres.Size = new System.Drawing.Size(725, 347);
            this.dgvLivres.TabIndex = 22;
            this.dgvLivres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_quit
            // 
            this.btn_quit.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.Location = new System.Drawing.Point(794, 473);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(156, 45);
            this.btn_quit.TabIndex = 23;
            this.btn_quit.Text = "QUITTER";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmListeLivres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 545);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.dgvLivres);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbnModifier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_auteur);
            this.Controls.Add(this.tbx_editeur);
            this.Controls.Add(this.tbx_nbDispo);
            this.Controls.Add(this.tbx_anneePub);
            this.Controls.Add(this.tbx_titre);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmListeLivres";
            this.Text = "FrmListeLivres";
            this.Load += new System.EventHandler(this.FrmListeLivres_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox tbxRechercher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbx_auteur;
        private System.Windows.Forms.TextBox tbx_editeur;
        private System.Windows.Forms.TextBox tbx_nbDispo;
        private System.Windows.Forms.TextBox tbx_anneePub;
        private System.Windows.Forms.TextBox tbx_titre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button tbnModifier;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvLivres;
        private System.Windows.Forms.Button btn_quit;
    }
}