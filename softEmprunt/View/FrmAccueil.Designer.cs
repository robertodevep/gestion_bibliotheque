namespace softEmprunt.View
{
    partial class FrmAccueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccueil));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.livreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesLivresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprunteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterEmprunteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesEmprunteursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emprunterLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterEmpruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeEmpruntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retournerLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailleLivreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 472);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1166, 117);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(0, 47);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(1166, 483);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 2;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livreToolStripMenuItem,
            this.emprunteurToolStripMenuItem,
            this.emprunterLivreToolStripMenuItem,
            this.retournerLivreToolStripMenuItem,
            this.detailleLivreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1166, 44);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // livreToolStripMenuItem
            // 
            this.livreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterLivreToolStripMenuItem,
            this.listeDesLivresToolStripMenuItem});
            this.livreToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("livreToolStripMenuItem.Image")));
            this.livreToolStripMenuItem.Name = "livreToolStripMenuItem";
            this.livreToolStripMenuItem.Size = new System.Drawing.Size(112, 40);
            this.livreToolStripMenuItem.Text = "LIVRE";
            // 
            // ajouterLivreToolStripMenuItem
            // 
            this.ajouterLivreToolStripMenuItem.Name = "ajouterLivreToolStripMenuItem";
            this.ajouterLivreToolStripMenuItem.Size = new System.Drawing.Size(281, 40);
            this.ajouterLivreToolStripMenuItem.Text = "Ajouter Livre";
            this.ajouterLivreToolStripMenuItem.Click += new System.EventHandler(this.ajouterLivreToolStripMenuItem_Click);
            // 
            // listeDesLivresToolStripMenuItem
            // 
            this.listeDesLivresToolStripMenuItem.Name = "listeDesLivresToolStripMenuItem";
            this.listeDesLivresToolStripMenuItem.Size = new System.Drawing.Size(281, 40);
            this.listeDesLivresToolStripMenuItem.Text = "Liste Des Livres";
            this.listeDesLivresToolStripMenuItem.Click += new System.EventHandler(this.listeDesLivresToolStripMenuItem_Click);
            // 
            // emprunteurToolStripMenuItem
            // 
            this.emprunteurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterEmprunteurToolStripMenuItem,
            this.listeDesEmprunteursToolStripMenuItem});
            this.emprunteurToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emprunteurToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emprunteurToolStripMenuItem.Image")));
            this.emprunteurToolStripMenuItem.Name = "emprunteurToolStripMenuItem";
            this.emprunteurToolStripMenuItem.Size = new System.Drawing.Size(225, 40);
            this.emprunteurToolStripMenuItem.Text = "EMPRUNTEURS";
            // 
            // ajouterEmprunteurToolStripMenuItem
            // 
            this.ajouterEmprunteurToolStripMenuItem.Name = "ajouterEmprunteurToolStripMenuItem";
            this.ajouterEmprunteurToolStripMenuItem.Size = new System.Drawing.Size(366, 40);
            this.ajouterEmprunteurToolStripMenuItem.Text = "Ajouter Emprunteur";
            this.ajouterEmprunteurToolStripMenuItem.Click += new System.EventHandler(this.ajouterEmprunteurToolStripMenuItem_Click);
            // 
            // listeDesEmprunteursToolStripMenuItem
            // 
            this.listeDesEmprunteursToolStripMenuItem.Name = "listeDesEmprunteursToolStripMenuItem";
            this.listeDesEmprunteursToolStripMenuItem.Size = new System.Drawing.Size(366, 40);
            this.listeDesEmprunteursToolStripMenuItem.Text = "Liste Des Emprunteurs";
            this.listeDesEmprunteursToolStripMenuItem.Click += new System.EventHandler(this.listeDesEmprunteursToolStripMenuItem_Click);
            // 
            // emprunterLivreToolStripMenuItem
            // 
            this.emprunterLivreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterEmpruntToolStripMenuItem,
            this.listeEmpruntToolStripMenuItem});
            this.emprunterLivreToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emprunterLivreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("emprunterLivreToolStripMenuItem.Image")));
            this.emprunterLivreToolStripMenuItem.Name = "emprunterLivreToolStripMenuItem";
            this.emprunterLivreToolStripMenuItem.Size = new System.Drawing.Size(271, 40);
            this.emprunterLivreToolStripMenuItem.Text = "EMPRUNTER LIVRE";
            // 
            // ajouterEmpruntToolStripMenuItem
            // 
            this.ajouterEmpruntToolStripMenuItem.Name = "ajouterEmpruntToolStripMenuItem";
            this.ajouterEmpruntToolStripMenuItem.Size = new System.Drawing.Size(298, 40);
            this.ajouterEmpruntToolStripMenuItem.Text = "Ajouter Emprunt";
            this.ajouterEmpruntToolStripMenuItem.Click += new System.EventHandler(this.ajouterEmpruntToolStripMenuItem_Click);
            // 
            // listeEmpruntToolStripMenuItem
            // 
            this.listeEmpruntToolStripMenuItem.Name = "listeEmpruntToolStripMenuItem";
            this.listeEmpruntToolStripMenuItem.Size = new System.Drawing.Size(298, 40);
            this.listeEmpruntToolStripMenuItem.Text = "Liste Emprunt";
            this.listeEmpruntToolStripMenuItem.Click += new System.EventHandler(this.listeEmpruntToolStripMenuItem_Click);
            // 
            // retournerLivreToolStripMenuItem
            // 
            this.retournerLivreToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retournerLivreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("retournerLivreToolStripMenuItem.Image")));
            this.retournerLivreToolStripMenuItem.Name = "retournerLivreToolStripMenuItem";
            this.retournerLivreToolStripMenuItem.Size = new System.Drawing.Size(267, 40);
            this.retournerLivreToolStripMenuItem.Text = "RETOURNER LIVRE";
            this.retournerLivreToolStripMenuItem.Click += new System.EventHandler(this.retournerLivreToolStripMenuItem_Click);
            // 
            // detailleLivreToolStripMenuItem
            // 
            this.detailleLivreToolStripMenuItem.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailleLivreToolStripMenuItem.Name = "detailleLivreToolStripMenuItem";
            this.detailleLivreToolStripMenuItem.Size = new System.Drawing.Size(201, 40);
            this.detailleLivreToolStripMenuItem.Text = "DETAILS LIVRE";
            this.detailleLivreToolStripMenuItem.Click += new System.EventHandler(this.detailleLivreToolStripMenuItem_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1087, -8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // FrmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1166, 589);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAccueil";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmAccueil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem livreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesLivresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprunterLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterEmpruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeEmpruntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retournerLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailleLivreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emprunteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterEmprunteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesEmprunteursToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}