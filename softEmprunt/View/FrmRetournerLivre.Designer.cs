namespace softEmprunt.View
{
    partial class FrmRetournerLivre
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
            this.btnRetourner = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxDatEmprunt = new System.Windows.Forms.TextBox();
            this.tbxNomLivre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_quit = new System.Windows.Forms.Button();
            this.tbxDatRetour = new System.Windows.Forms.DateTimePicker();
            this.cmbxEmail = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetourner
            // 
            this.btnRetourner.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetourner.Location = new System.Drawing.Point(1023, 401);
            this.btnRetourner.Name = "btnRetourner";
            this.btnRetourner.Size = new System.Drawing.Size(123, 38);
            this.btnRetourner.TabIndex = 5;
            this.btnRetourner.Text = "Retourner";
            this.btnRetourner.UseVisualStyleBackColor = true;
            this.btnRetourner.Click += new System.EventHandler(this.btnRetourner_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 27);
            this.label1.TabIndex = 6;
            this.label1.Text = "Entrer votre Email";
            // 
            // tbxDatEmprunt
            // 
            this.tbxDatEmprunt.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDatEmprunt.Location = new System.Drawing.Point(739, 436);
            this.tbxDatEmprunt.Name = "tbxDatEmprunt";
            this.tbxDatEmprunt.Size = new System.Drawing.Size(255, 31);
            this.tbxDatEmprunt.TabIndex = 10;
            this.tbxDatEmprunt.TextChanged += new System.EventHandler(this.tbxDatEmprunt_TextChanged);
            // 
            // tbxNomLivre
            // 
            this.tbxNomLivre.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNomLivre.Location = new System.Drawing.Point(739, 383);
            this.tbxNomLivre.Name = "tbxNomLivre";
            this.tbxNomLivre.Size = new System.Drawing.Size(255, 31);
            this.tbxNomLivre.TabIndex = 11;
            this.tbxNomLivre.TextChanged += new System.EventHandler(this.tbxNomLivre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(572, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nom Du Livre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(572, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Date D\'Emprunt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(572, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "Date Retour";
            // 
            // btn_quit
            // 
            this.btn_quit.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.Location = new System.Drawing.Point(1023, 469);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(123, 38);
            this.btn_quit.TabIndex = 16;
            this.btn_quit.Text = "Quitter";
            this.btn_quit.UseVisualStyleBackColor = true;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // tbxDatRetour
            // 
            this.tbxDatRetour.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDatRetour.Location = new System.Drawing.Point(739, 495);
            this.tbxDatRetour.Name = "tbxDatRetour";
            this.tbxDatRetour.Size = new System.Drawing.Size(255, 31);
            this.tbxDatRetour.TabIndex = 18;
            this.tbxDatRetour.ValueChanged += new System.EventHandler(this.tbxDatRetour_ValueChanged);
            // 
            // cmbxEmail
            // 
            this.cmbxEmail.FormattingEnabled = true;
            this.cmbxEmail.Location = new System.Drawing.Point(17, 172);
            this.cmbxEmail.Name = "cmbxEmail";
            this.cmbxEmail.Size = new System.Drawing.Size(166, 30);
            this.cmbxEmail.TabIndex = 19;
            this.cmbxEmail.SelectedIndexChanged += new System.EventHandler(this.cmbxEmail_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(216, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(930, 322);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmRetournerLivre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(1170, 539);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbxEmail);
            this.Controls.Add(this.tbxDatRetour);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxNomLivre);
            this.Controls.Add(this.tbxDatEmprunt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetourner);
            this.Font = new System.Drawing.Font("Trebuchet MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmRetournerLivre";
            this.Text = "FrmRetournerLivre";
            this.Load += new System.EventHandler(this.FrmRetournerLivre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetourner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxDatEmprunt;
        private System.Windows.Forms.TextBox tbxNomLivre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.DateTimePicker tbxDatRetour;
        private System.Windows.Forms.ComboBox cmbxEmail;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}