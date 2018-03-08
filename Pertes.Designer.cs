namespace BE_Informatique
{
    partial class Pertes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pertes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titre = new System.Windows.Forms.Label();
            this.reduire = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.hotelor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pertesChambre1 = new System.Windows.Forms.MaskedTextBox();
            this.pertesArticles1 = new System.Windows.Forms.MaskedTextBox();
            this.pertesNoms1 = new System.Windows.Forms.MaskedTextBox();
            this.pertesArticles = new System.Windows.Forms.Label();
            this.pertesChambre = new System.Windows.Forms.Label();
            this.pertesNoms = new System.Windows.Forms.Label();
            this.pertesAnnuler = new System.Windows.Forms.Button();
            this.pertesValider = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.r = new System.Windows.Forms.Label();
            this.o1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.titre);
            this.panel1.Controls.Add(this.reduire);
            this.panel1.Controls.Add(this.fermer);
            this.panel1.Controls.Add(this.hotelor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 39);
            this.panel1.TabIndex = 4;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(360, 4);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(80, 33);
            this.titre.TabIndex = 16;
            this.titre.Text = "Pertes";
            // 
            // reduire
            // 
            this.reduire.FlatAppearance.BorderSize = 0;
            this.reduire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduire.Image = ((System.Drawing.Image)(resources.GetObject("reduire.Image")));
            this.reduire.Location = new System.Drawing.Point(713, 3);
            this.reduire.Name = "reduire";
            this.reduire.Size = new System.Drawing.Size(25, 25);
            this.reduire.TabIndex = 14;
            this.reduire.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reduire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reduire.UseVisualStyleBackColor = true;
            this.reduire.Click += new System.EventHandler(this.reduire_Click);
            // 
            // fermer
            // 
            this.fermer.FlatAppearance.BorderSize = 0;
            this.fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.Image = ((System.Drawing.Image)(resources.GetObject("fermer.Image")));
            this.fermer.Location = new System.Drawing.Point(735, 3);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(31, 23);
            this.fermer.TabIndex = 13;
            this.fermer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fermer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // hotelor
            // 
            this.hotelor.AutoSize = true;
            this.hotelor.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelor.Location = new System.Drawing.Point(3, 3);
            this.hotelor.Name = "hotelor";
            this.hotelor.Size = new System.Drawing.Size(68, 26);
            this.hotelor.TabIndex = 8;
            this.hotelor.Text = "Hotelor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.pertesAnnuler);
            this.panel2.Controls.Add(this.pertesValider);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(773, 323);
            this.panel2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.pertesChambre1);
            this.groupBox1.Controls.Add(this.pertesArticles1);
            this.groupBox1.Controls.Add(this.pertesNoms1);
            this.groupBox1.Controls.Add(this.pertesArticles);
            this.groupBox1.Controls.Add(this.pertesChambre);
            this.groupBox1.Controls.Add(this.pertesNoms);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(80, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 186);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pertes";
            // 
            // pertesChambre1
            // 
            this.pertesChambre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pertesChambre1.Location = new System.Drawing.Point(214, 84);
            this.pertesChambre1.Name = "pertesChambre1";
            this.pertesChambre1.Size = new System.Drawing.Size(436, 29);
            this.pertesChambre1.TabIndex = 1;
            // 
            // pertesArticles1
            // 
            this.pertesArticles1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pertesArticles1.Location = new System.Drawing.Point(214, 131);
            this.pertesArticles1.Name = "pertesArticles1";
            this.pertesArticles1.Size = new System.Drawing.Size(436, 29);
            this.pertesArticles1.TabIndex = 2;
            // 
            // pertesNoms1
            // 
            this.pertesNoms1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pertesNoms1.Location = new System.Drawing.Point(214, 36);
            this.pertesNoms1.Name = "pertesNoms1";
            this.pertesNoms1.Size = new System.Drawing.Size(436, 29);
            this.pertesNoms1.TabIndex = 0;
            // 
            // pertesArticles
            // 
            this.pertesArticles.AutoSize = true;
            this.pertesArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pertesArticles.ForeColor = System.Drawing.Color.Blue;
            this.pertesArticles.Location = new System.Drawing.Point(20, 135);
            this.pertesArticles.Name = "pertesArticles";
            this.pertesArticles.Size = new System.Drawing.Size(91, 24);
            this.pertesArticles.TabIndex = 19;
            this.pertesArticles.Text = "Articles :";
            // 
            // pertesChambre
            // 
            this.pertesChambre.AutoSize = true;
            this.pertesChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pertesChambre.ForeColor = System.Drawing.Color.Blue;
            this.pertesChambre.Location = new System.Drawing.Point(20, 87);
            this.pertesChambre.Name = "pertesChambre";
            this.pertesChambre.Size = new System.Drawing.Size(107, 24);
            this.pertesChambre.TabIndex = 18;
            this.pertesChambre.Text = "Chambre :";
            // 
            // pertesNoms
            // 
            this.pertesNoms.AutoSize = true;
            this.pertesNoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pertesNoms.ForeColor = System.Drawing.Color.Blue;
            this.pertesNoms.Location = new System.Drawing.Point(20, 39);
            this.pertesNoms.Name = "pertesNoms";
            this.pertesNoms.Size = new System.Drawing.Size(188, 24);
            this.pertesNoms.TabIndex = 17;
            this.pertesNoms.Text = "Noms et Prénoms :";
            // 
            // pertesAnnuler
            // 
            this.pertesAnnuler.BackColor = System.Drawing.Color.Yellow;
            this.pertesAnnuler.FlatAppearance.BorderSize = 0;
            this.pertesAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pertesAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pertesAnnuler.ForeColor = System.Drawing.Color.Red;
            this.pertesAnnuler.Location = new System.Drawing.Point(632, 249);
            this.pertesAnnuler.Name = "pertesAnnuler";
            this.pertesAnnuler.Size = new System.Drawing.Size(106, 44);
            this.pertesAnnuler.TabIndex = 4;
            this.pertesAnnuler.Text = "Retour";
            this.pertesAnnuler.UseVisualStyleBackColor = false;
            this.pertesAnnuler.Click += new System.EventHandler(this.pertesAnnuler_Click);
            // 
            // pertesValider
            // 
            this.pertesValider.BackColor = System.Drawing.Color.Yellow;
            this.pertesValider.FlatAppearance.BorderSize = 0;
            this.pertesValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pertesValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pertesValider.ForeColor = System.Drawing.Color.Red;
            this.pertesValider.Location = new System.Drawing.Point(519, 249);
            this.pertesValider.Name = "pertesValider";
            this.pertesValider.Size = new System.Drawing.Size(107, 44);
            this.pertesValider.TabIndex = 3;
            this.pertesValider.Text = "Valider";
            this.pertesValider.UseVisualStyleBackColor = false;
            this.pertesValider.Click += new System.EventHandler(this.pertesValider_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.r);
            this.panel3.Controls.Add(this.o1);
            this.panel3.Controls.Add(this.l);
            this.panel3.Controls.Add(this.e);
            this.panel3.Controls.Add(this.t);
            this.panel3.Controls.Add(this.o);
            this.panel3.Controls.Add(this.h);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(60, 323);
            this.panel3.TabIndex = 85;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(12, 272);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(32, 45);
            this.r.TabIndex = 8;
            this.r.Text = "r";
            // 
            // o1
            // 
            this.o1.AutoSize = true;
            this.o1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o1.Location = new System.Drawing.Point(11, 227);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(36, 45);
            this.o1.TabIndex = 6;
            this.o1.Text = "o";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(13, 182);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(30, 45);
            this.l.TabIndex = 5;
            this.l.Text = "l";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(12, 137);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(34, 45);
            this.e.TabIndex = 4;
            this.e.Text = "e";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(12, 92);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(33, 45);
            this.t.TabIndex = 3;
            this.t.Text = "t";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.Location = new System.Drawing.Point(11, 47);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(36, 45);
            this.o.TabIndex = 2;
            this.o.Text = "o";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(7, 2);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(46, 45);
            this.h.TabIndex = 1;
            this.h.Text = "H";
            // 
            // Pertes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 362);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pertes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pertes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Button reduire;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Label hotelor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label o1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label o;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox pertesChambre1;
        private System.Windows.Forms.Button pertesAnnuler;
        private System.Windows.Forms.Button pertesValider;
        private System.Windows.Forms.MaskedTextBox pertesArticles1;
        private System.Windows.Forms.MaskedTextBox pertesNoms1;
        private System.Windows.Forms.Label pertesArticles;
        private System.Windows.Forms.Label pertesChambre;
        private System.Windows.Forms.Label pertesNoms;
    }
}