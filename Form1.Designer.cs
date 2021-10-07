namespace Opticien
{
    partial class Opticien
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblModele = new System.Windows.Forms.Label();
            this.lblCategorie = new System.Windows.Forms.Label();
            this.lblMarque = new System.Windows.Forms.Label();
            this.lblTaille = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.lblNbExemp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.tbModele = new System.Windows.Forms.TextBox();
            this.tbCouleur = new System.Windows.Forms.TextBox();
            this.tbTaille = new System.Windows.Forms.TextBox();
            this.tbPrix = new System.Windows.Forms.TextBox();
            this.cbMarque = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.gbGestion = new System.Windows.Forms.GroupBox();
            this.btnReserver = new System.Windows.Forms.Button();
            this.gpListe = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gbGestion.SuspendLayout();
            this.gpListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModele
            // 
            this.lblModele.AutoSize = true;
            this.lblModele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModele.Location = new System.Drawing.Point(7, 25);
            this.lblModele.Name = "lblModele";
            this.lblModele.Size = new System.Drawing.Size(74, 24);
            this.lblModele.TabIndex = 0;
            this.lblModele.Text = "Modèle";
            // 
            // lblCategorie
            // 
            this.lblCategorie.AutoSize = true;
            this.lblCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategorie.Location = new System.Drawing.Point(7, 68);
            this.lblCategorie.Name = "lblCategorie";
            this.lblCategorie.Size = new System.Drawing.Size(91, 24);
            this.lblCategorie.TabIndex = 1;
            this.lblCategorie.Text = "Catégorie";
            // 
            // lblMarque
            // 
            this.lblMarque.AutoSize = true;
            this.lblMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarque.Location = new System.Drawing.Point(7, 111);
            this.lblMarque.Name = "lblMarque";
            this.lblMarque.Size = new System.Drawing.Size(75, 24);
            this.lblMarque.TabIndex = 2;
            this.lblMarque.Text = "Marque";
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaille.Location = new System.Drawing.Point(7, 153);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(55, 24);
            this.lblTaille.TabIndex = 3;
            this.lblTaille.Text = "Taille";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.Location = new System.Drawing.Point(7, 192);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(42, 24);
            this.lblPrix.TabIndex = 4;
            this.lblPrix.Text = "Prix";
            // 
            // lblCouleur
            // 
            this.lblCouleur.AutoSize = true;
            this.lblCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCouleur.Location = new System.Drawing.Point(7, 234);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(77, 24);
            this.lblCouleur.TabIndex = 5;
            this.lblCouleur.Text = "Couleur";
            // 
            // lblNbExemp
            // 
            this.lblNbExemp.AutoSize = true;
            this.lblNbExemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNbExemp.Location = new System.Drawing.Point(7, 281);
            this.lblNbExemp.Name = "lblNbExemp";
            this.lblNbExemp.Size = new System.Drawing.Size(202, 24);
            this.lblNbExemp.TabIndex = 6;
            this.lblNbExemp.Text = "Nombre d\'exemplaires";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(11, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cbCategorie
            // 
            this.cbCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(119, 64);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(245, 28);
            this.cbCategorie.TabIndex = 8;
            // 
            // tbModele
            // 
            this.tbModele.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModele.Location = new System.Drawing.Point(119, 23);
            this.tbModele.Name = "tbModele";
            this.tbModele.Size = new System.Drawing.Size(245, 26);
            this.tbModele.TabIndex = 9;
            // 
            // tbCouleur
            // 
            this.tbCouleur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCouleur.Location = new System.Drawing.Point(119, 232);
            this.tbCouleur.Name = "tbCouleur";
            this.tbCouleur.Size = new System.Drawing.Size(245, 26);
            this.tbCouleur.TabIndex = 10;
            // 
            // tbTaille
            // 
            this.tbTaille.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTaille.Location = new System.Drawing.Point(119, 151);
            this.tbTaille.Name = "tbTaille";
            this.tbTaille.Size = new System.Drawing.Size(245, 26);
            this.tbTaille.TabIndex = 11;
            // 
            // tbPrix
            // 
            this.tbPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrix.Location = new System.Drawing.Point(119, 190);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.Size = new System.Drawing.Size(245, 26);
            this.tbPrix.TabIndex = 12;
            // 
            // cbMarque
            // 
            this.cbMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarque.FormattingEnabled = true;
            this.cbMarque.Location = new System.Drawing.Point(119, 107);
            this.cbMarque.Name = "cbMarque";
            this.cbMarque.Size = new System.Drawing.Size(245, 28);
            this.cbMarque.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(232, 279);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 26);
            this.textBox3.TabIndex = 14;
            // 
            // gbGestion
            // 
            this.gbGestion.Controls.Add(this.btnReserver);
            this.gbGestion.Controls.Add(this.textBox3);
            this.gbGestion.Controls.Add(this.cbMarque);
            this.gbGestion.Controls.Add(this.tbPrix);
            this.gbGestion.Controls.Add(this.tbTaille);
            this.gbGestion.Controls.Add(this.tbCouleur);
            this.gbGestion.Controls.Add(this.tbModele);
            this.gbGestion.Controls.Add(this.cbCategorie);
            this.gbGestion.Controls.Add(this.button1);
            this.gbGestion.Controls.Add(this.lblNbExemp);
            this.gbGestion.Controls.Add(this.lblCouleur);
            this.gbGestion.Controls.Add(this.lblPrix);
            this.gbGestion.Controls.Add(this.lblTaille);
            this.gbGestion.Controls.Add(this.lblMarque);
            this.gbGestion.Controls.Add(this.lblCategorie);
            this.gbGestion.Controls.Add(this.lblModele);
            this.gbGestion.Location = new System.Drawing.Point(16, 21);
            this.gbGestion.Name = "gbGestion";
            this.gbGestion.Size = new System.Drawing.Size(431, 390);
            this.gbGestion.TabIndex = 15;
            this.gbGestion.TabStop = false;
            this.gbGestion.Text = "Gestion des modèles et exemplaires";
            // 
            // btnReserver
            // 
            this.btnReserver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserver.Location = new System.Drawing.Point(134, 325);
            this.btnReserver.Name = "btnReserver";
            this.btnReserver.Size = new System.Drawing.Size(97, 31);
            this.btnReserver.TabIndex = 15;
            this.btnReserver.Text = "Reserver";
            this.btnReserver.UseVisualStyleBackColor = true;
            // 
            // gpListe
            // 
            this.gpListe.Controls.Add(this.button2);
            this.gpListe.Controls.Add(this.textBox1);
            this.gpListe.Controls.Add(this.label1);
            this.gpListe.Controls.Add(this.dataGridView1);
            this.gpListe.Location = new System.Drawing.Point(489, 21);
            this.gpListe.Name = "gpListe";
            this.gpListe.Size = new System.Drawing.Size(493, 504);
            this.gpListe.TabIndex = 18;
            this.gpListe.TabStop = false;
            this.gpListe.Text = "Liste des modèles et exemplaires";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(421, 352);
            this.dataGridView1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre d\'exemplaires";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(269, 431);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 19;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(353, 425);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 35);
            this.button2.TabIndex = 20;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Opticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 627);
            this.Controls.Add(this.gpListe);
            this.Controls.Add(this.gbGestion);
            this.Name = "Opticien";
            this.Text = "Opticien";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Opticien_FormClosed);
            this.Load += new System.EventHandler(this.Opticien_Load);
            this.gbGestion.ResumeLayout(false);
            this.gbGestion.PerformLayout();
            this.gpListe.ResumeLayout(false);
            this.gpListe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblModele;
        private System.Windows.Forms.Label lblCategorie;
        private System.Windows.Forms.Label lblMarque;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblNbExemp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.TextBox tbModele;
        private System.Windows.Forms.TextBox tbCouleur;
        private System.Windows.Forms.TextBox tbTaille;
        private System.Windows.Forms.TextBox tbPrix;
        private System.Windows.Forms.ComboBox cbMarque;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox gbGestion;
        private System.Windows.Forms.GroupBox gpListe;
        private System.Windows.Forms.Button btnReserver;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

