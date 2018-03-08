namespace BE_Informatique
{
    partial class Administrateur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrateur));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titre = new System.Windows.Forms.Label();
            this.reduire = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.hotelor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.r = new System.Windows.Forms.Label();
            this.o1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.confAnnuler = new System.Windows.Forms.Button();
            this.confValider = new System.Windows.Forms.Button();
            this.nouveau = new System.Windows.Forms.GroupBox();
            this.nouveauLogin1 = new System.Windows.Forms.MaskedTextBox();
            this.nouveauPass1 = new System.Windows.Forms.MaskedTextBox();
            this.confirmation1 = new System.Windows.Forms.MaskedTextBox();
            this.nouveauLogin = new System.Windows.Forms.Label();
            this.nouveauPass = new System.Windows.Forms.Label();
            this.confirmation = new System.Windows.Forms.Label();
            this.configuration2 = new System.Windows.Forms.Label();
            this.ancien = new System.Windows.Forms.GroupBox();
            this.ancienPass1 = new System.Windows.Forms.MaskedTextBox();
            this.ancienLogin1 = new System.Windows.Forms.MaskedTextBox();
            this.ancienLogin = new System.Windows.Forms.Label();
            this.ancienPass = new System.Windows.Forms.Label();
            this.configuration1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.nouveau.SuspendLayout();
            this.ancien.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(796, 42);
            this.panel1.TabIndex = 5;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(320, 3);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(176, 33);
            this.titre.TabIndex = 16;
            this.titre.Text = "Administrateur";
            // 
            // reduire
            // 
            this.reduire.FlatAppearance.BorderSize = 0;
            this.reduire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduire.Image = ((System.Drawing.Image)(resources.GetObject("reduire.Image")));
            this.reduire.Location = new System.Drawing.Point(740, 4);
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
            this.fermer.Location = new System.Drawing.Point(762, 4);
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
            this.hotelor.Location = new System.Drawing.Point(3, 4);
            this.hotelor.Name = "hotelor";
            this.hotelor.Size = new System.Drawing.Size(68, 26);
            this.hotelor.TabIndex = 8;
            this.hotelor.Text = "Hotelor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.confAnnuler);
            this.panel2.Controls.Add(this.confValider);
            this.panel2.Controls.Add(this.nouveau);
            this.panel2.Controls.Add(this.configuration2);
            this.panel2.Controls.Add(this.ancien);
            this.panel2.Controls.Add(this.configuration1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 517);
            this.panel2.TabIndex = 6;
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
            this.panel3.Size = new System.Drawing.Size(69, 517);
            this.panel3.TabIndex = 86;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(11, 403);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(40, 57);
            this.r.TabIndex = 8;
            this.r.Text = "r";
            // 
            // o1
            // 
            this.o1.AutoSize = true;
            this.o1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o1.Location = new System.Drawing.Point(9, 346);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(45, 57);
            this.o1.TabIndex = 6;
            this.o1.Text = "o";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(12, 289);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(38, 57);
            this.l.TabIndex = 5;
            this.l.Text = "l";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(10, 232);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(42, 57);
            this.e.TabIndex = 4;
            this.e.Text = "e";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(11, 175);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(41, 57);
            this.t.TabIndex = 3;
            this.t.Text = "t";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.Location = new System.Drawing.Point(9, 118);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(45, 57);
            this.o.TabIndex = 2;
            this.o.Text = "o";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(2, 61);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(59, 57);
            this.h.TabIndex = 1;
            this.h.Text = "H";
            // 
            // confAnnuler
            // 
            this.confAnnuler.BackColor = System.Drawing.Color.Yellow;
            this.confAnnuler.FlatAppearance.BorderSize = 0;
            this.confAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confAnnuler.ForeColor = System.Drawing.Color.Red;
            this.confAnnuler.Location = new System.Drawing.Point(629, 426);
            this.confAnnuler.Name = "confAnnuler";
            this.confAnnuler.Size = new System.Drawing.Size(107, 43);
            this.confAnnuler.TabIndex = 2;
            this.confAnnuler.Text = "Retour";
            this.confAnnuler.UseVisualStyleBackColor = false;
            this.confAnnuler.Click += new System.EventHandler(this.confAnnuler_Click);
            // 
            // confValider
            // 
            this.confValider.BackColor = System.Drawing.Color.Yellow;
            this.confValider.FlatAppearance.BorderSize = 0;
            this.confValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confValider.ForeColor = System.Drawing.Color.Red;
            this.confValider.Location = new System.Drawing.Point(516, 426);
            this.confValider.Name = "confValider";
            this.confValider.Size = new System.Drawing.Size(107, 43);
            this.confValider.TabIndex = 1;
            this.confValider.Text = "Valider";
            this.confValider.UseVisualStyleBackColor = false;
            this.confValider.Click += new System.EventHandler(this.confValider_Click);
            // 
            // nouveau
            // 
            this.nouveau.BackColor = System.Drawing.Color.Transparent;
            this.nouveau.Controls.Add(this.nouveauLogin1);
            this.nouveau.Controls.Add(this.nouveauPass1);
            this.nouveau.Controls.Add(this.confirmation1);
            this.nouveau.Controls.Add(this.nouveauLogin);
            this.nouveau.Controls.Add(this.nouveauPass);
            this.nouveau.Controls.Add(this.confirmation);
            this.nouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveau.ForeColor = System.Drawing.Color.Blue;
            this.nouveau.Location = new System.Drawing.Point(100, 261);
            this.nouveau.Name = "nouveau";
            this.nouveau.Size = new System.Drawing.Size(657, 133);
            this.nouveau.TabIndex = 40;
            this.nouveau.TabStop = false;
            this.nouveau.Text = "Nouveau";
            // 
            // nouveauLogin1
            // 
            this.nouveauLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauLogin1.Location = new System.Drawing.Point(291, 28);
            this.nouveauLogin1.Name = "nouveauLogin1";
            this.nouveauLogin1.Size = new System.Drawing.Size(355, 29);
            this.nouveauLogin1.TabIndex = 0;
            this.nouveauLogin1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nouveauLogin1_KeyPress);
            // 
            // nouveauPass1
            // 
            this.nouveauPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauPass1.Location = new System.Drawing.Point(291, 61);
            this.nouveauPass1.Name = "nouveauPass1";
            this.nouveauPass1.Size = new System.Drawing.Size(355, 29);
            this.nouveauPass1.TabIndex = 1;
            this.nouveauPass1.UseSystemPasswordChar = true;
            this.nouveauPass1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nouveauPass1_KeyPress);
            // 
            // confirmation1
            // 
            this.confirmation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmation1.Location = new System.Drawing.Point(291, 94);
            this.confirmation1.Name = "confirmation1";
            this.confirmation1.Size = new System.Drawing.Size(355, 29);
            this.confirmation1.TabIndex = 2;
            this.confirmation1.UseSystemPasswordChar = true;
            // 
            // nouveauLogin
            // 
            this.nouveauLogin.AutoSize = true;
            this.nouveauLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauLogin.ForeColor = System.Drawing.Color.Blue;
            this.nouveauLogin.Location = new System.Drawing.Point(18, 31);
            this.nouveauLogin.Name = "nouveauLogin";
            this.nouveauLogin.Size = new System.Drawing.Size(74, 24);
            this.nouveauLogin.TabIndex = 4;
            this.nouveauLogin.Text = "Login :";
            // 
            // nouveauPass
            // 
            this.nouveauPass.AutoSize = true;
            this.nouveauPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauPass.ForeColor = System.Drawing.Color.Blue;
            this.nouveauPass.Location = new System.Drawing.Point(18, 64);
            this.nouveauPass.Name = "nouveauPass";
            this.nouveauPass.Size = new System.Drawing.Size(147, 24);
            this.nouveauPass.TabIndex = 5;
            this.nouveauPass.Text = "Mot de passe :";
            // 
            // confirmation
            // 
            this.confirmation.AutoSize = true;
            this.confirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmation.ForeColor = System.Drawing.Color.Blue;
            this.confirmation.Location = new System.Drawing.Point(18, 97);
            this.confirmation.Name = "confirmation";
            this.confirmation.Size = new System.Drawing.Size(267, 24);
            this.confirmation.TabIndex = 6;
            this.confirmation.Text = "Confirmer le mot de passe :";
            // 
            // configuration2
            // 
            this.configuration2.AutoSize = true;
            this.configuration2.BackColor = System.Drawing.Color.Transparent;
            this.configuration2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuration2.ForeColor = System.Drawing.Color.Red;
            this.configuration2.Location = new System.Drawing.Point(96, 61);
            this.configuration2.Name = "configuration2";
            this.configuration2.Size = new System.Drawing.Size(669, 24);
            this.configuration2.TabIndex = 38;
            this.configuration2.Text = "login, le mot de passe administrateur ainsi que le nombre de chambre.";
            // 
            // ancien
            // 
            this.ancien.BackColor = System.Drawing.Color.Transparent;
            this.ancien.Controls.Add(this.ancienPass1);
            this.ancien.Controls.Add(this.ancienLogin1);
            this.ancien.Controls.Add(this.ancienLogin);
            this.ancien.Controls.Add(this.ancienPass);
            this.ancien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ancien.ForeColor = System.Drawing.Color.Blue;
            this.ancien.Location = new System.Drawing.Point(100, 118);
            this.ancien.Name = "ancien";
            this.ancien.Size = new System.Drawing.Size(657, 109);
            this.ancien.TabIndex = 39;
            this.ancien.TabStop = false;
            this.ancien.Text = "Ancien";
            // 
            // ancienPass1
            // 
            this.ancienPass1.Location = new System.Drawing.Point(171, 71);
            this.ancienPass1.Name = "ancienPass1";
            this.ancienPass1.Size = new System.Drawing.Size(461, 29);
            this.ancienPass1.TabIndex = 1;
            this.ancienPass1.UseSystemPasswordChar = true;
            this.ancienPass1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ancienPass1_KeyPress);
            // 
            // ancienLogin1
            // 
            this.ancienLogin1.Location = new System.Drawing.Point(171, 31);
            this.ancienLogin1.Name = "ancienLogin1";
            this.ancienLogin1.Size = new System.Drawing.Size(461, 29);
            this.ancienLogin1.TabIndex = 0;
            this.ancienLogin1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ancienLogin1_KeyPress);
            // 
            // ancienLogin
            // 
            this.ancienLogin.AutoSize = true;
            this.ancienLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ancienLogin.ForeColor = System.Drawing.Color.Blue;
            this.ancienLogin.Location = new System.Drawing.Point(18, 34);
            this.ancienLogin.Name = "ancienLogin";
            this.ancienLogin.Size = new System.Drawing.Size(74, 24);
            this.ancienLogin.TabIndex = 2;
            this.ancienLogin.Text = "Login :";
            // 
            // ancienPass
            // 
            this.ancienPass.AutoSize = true;
            this.ancienPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ancienPass.ForeColor = System.Drawing.Color.Blue;
            this.ancienPass.Location = new System.Drawing.Point(18, 74);
            this.ancienPass.Name = "ancienPass";
            this.ancienPass.Size = new System.Drawing.Size(147, 24);
            this.ancienPass.TabIndex = 3;
            this.ancienPass.Text = "Mot de passe :";
            // 
            // configuration1
            // 
            this.configuration1.AutoSize = true;
            this.configuration1.BackColor = System.Drawing.Color.Transparent;
            this.configuration1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuration1.ForeColor = System.Drawing.Color.Red;
            this.configuration1.Location = new System.Drawing.Point(92, 37);
            this.configuration1.Name = "configuration1";
            this.configuration1.Size = new System.Drawing.Size(673, 24);
            this.configuration1.TabIndex = 37;
            this.configuration1.Text = "Vous pouvez éffectuer la configuration de l\'application en définissant le";
            // 
            // Administrateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administrateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.nouveau.ResumeLayout(false);
            this.nouveau.PerformLayout();
            this.ancien.ResumeLayout(false);
            this.ancien.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Button reduire;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Label hotelor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button confAnnuler;
        private System.Windows.Forms.Button confValider;
        private System.Windows.Forms.GroupBox nouveau;
        private System.Windows.Forms.MaskedTextBox nouveauLogin1;
        private System.Windows.Forms.MaskedTextBox nouveauPass1;
        private System.Windows.Forms.MaskedTextBox confirmation1;
        private System.Windows.Forms.Label nouveauLogin;
        private System.Windows.Forms.Label nouveauPass;
        private System.Windows.Forms.Label confirmation;
        private System.Windows.Forms.Label configuration2;
        private System.Windows.Forms.GroupBox ancien;
        private System.Windows.Forms.MaskedTextBox ancienPass1;
        private System.Windows.Forms.MaskedTextBox ancienLogin1;
        private System.Windows.Forms.Label ancienLogin;
        private System.Windows.Forms.Label ancienPass;
        private System.Windows.Forms.Label configuration1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label o1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label o;
        private System.Windows.Forms.Label h;
    }
}