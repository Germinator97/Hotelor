namespace BE_Informatique
{
    partial class Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titre = new System.Windows.Forms.Label();
            this.reduire = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.hotelor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hotelChambre1 = new System.Windows.Forms.MaskedTextBox();
            this.hotelChambre = new System.Windows.Forms.Label();
            this.hotelLogo1 = new System.Windows.Forms.MaskedTextBox();
            this.hotelLogo = new System.Windows.Forms.Label();
            this.hotelWeb1 = new System.Windows.Forms.MaskedTextBox();
            this.hotelWeb = new System.Windows.Forms.Label();
            this.hotelMail1 = new System.Windows.Forms.MaskedTextBox();
            this.hotelMail = new System.Windows.Forms.Label();
            this.hotelAdresse1 = new System.Windows.Forms.MaskedTextBox();
            this.hotelAdresse = new System.Windows.Forms.Label();
            this.hotelContacts1 = new System.Windows.Forms.MaskedTextBox();
            this.hotelContacts = new System.Windows.Forms.Label();
            this.hotelNom1 = new System.Windows.Forms.MaskedTextBox();
            this.hotelNom = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.r = new System.Windows.Forms.Label();
            this.o1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.hotelAnnuler = new System.Windows.Forms.Button();
            this.hotelValider = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(755, 42);
            this.panel1.TabIndex = 6;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(351, 5);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(73, 33);
            this.titre.TabIndex = 16;
            this.titre.Text = "Hotel";
            // 
            // reduire
            // 
            this.reduire.FlatAppearance.BorderSize = 0;
            this.reduire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduire.Image = ((System.Drawing.Image)(resources.GetObject("reduire.Image")));
            this.reduire.Location = new System.Drawing.Point(699, 3);
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
            this.fermer.Location = new System.Drawing.Point(721, 3);
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
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 470);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.hotelChambre1);
            this.panel3.Controls.Add(this.hotelChambre);
            this.panel3.Controls.Add(this.hotelLogo1);
            this.panel3.Controls.Add(this.hotelLogo);
            this.panel3.Controls.Add(this.hotelWeb1);
            this.panel3.Controls.Add(this.hotelWeb);
            this.panel3.Controls.Add(this.hotelMail1);
            this.panel3.Controls.Add(this.hotelMail);
            this.panel3.Controls.Add(this.hotelAdresse1);
            this.panel3.Controls.Add(this.hotelAdresse);
            this.panel3.Controls.Add(this.hotelContacts1);
            this.panel3.Controls.Add(this.hotelContacts);
            this.panel3.Controls.Add(this.hotelNom1);
            this.panel3.Controls.Add(this.hotelNom);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.hotelAnnuler);
            this.panel3.Controls.Add(this.hotelValider);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(755, 470);
            this.panel3.TabIndex = 7;
            // 
            // hotelChambre1
            // 
            this.hotelChambre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelChambre1.Location = new System.Drawing.Point(330, 322);
            this.hotelChambre1.Name = "hotelChambre1";
            this.hotelChambre1.Size = new System.Drawing.Size(383, 29);
            this.hotelChambre1.TabIndex = 99;
            // 
            // hotelChambre
            // 
            this.hotelChambre.AutoSize = true;
            this.hotelChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelChambre.ForeColor = System.Drawing.Color.Blue;
            this.hotelChambre.Location = new System.Drawing.Point(99, 325);
            this.hotelChambre.Name = "hotelChambre";
            this.hotelChambre.Size = new System.Drawing.Size(225, 24);
            this.hotelChambre.TabIndex = 100;
            this.hotelChambre.Text = "Nombre de chambres :";
            // 
            // hotelLogo1
            // 
            this.hotelLogo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelLogo1.Location = new System.Drawing.Point(330, 277);
            this.hotelLogo1.Name = "hotelLogo1";
            this.hotelLogo1.Size = new System.Drawing.Size(383, 29);
            this.hotelLogo1.TabIndex = 97;
            // 
            // hotelLogo
            // 
            this.hotelLogo.AutoSize = true;
            this.hotelLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelLogo.ForeColor = System.Drawing.Color.Blue;
            this.hotelLogo.Location = new System.Drawing.Point(99, 280);
            this.hotelLogo.Name = "hotelLogo";
            this.hotelLogo.Size = new System.Drawing.Size(69, 24);
            this.hotelLogo.TabIndex = 98;
            this.hotelLogo.Text = "Logo :";
            // 
            // hotelWeb1
            // 
            this.hotelWeb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelWeb1.Location = new System.Drawing.Point(330, 229);
            this.hotelWeb1.Name = "hotelWeb1";
            this.hotelWeb1.Size = new System.Drawing.Size(383, 29);
            this.hotelWeb1.TabIndex = 95;
            // 
            // hotelWeb
            // 
            this.hotelWeb.AutoSize = true;
            this.hotelWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelWeb.ForeColor = System.Drawing.Color.Blue;
            this.hotelWeb.Location = new System.Drawing.Point(99, 232);
            this.hotelWeb.Name = "hotelWeb";
            this.hotelWeb.Size = new System.Drawing.Size(102, 24);
            this.hotelWeb.TabIndex = 96;
            this.hotelWeb.Text = "Site web :";
            // 
            // hotelMail1
            // 
            this.hotelMail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelMail1.Location = new System.Drawing.Point(330, 185);
            this.hotelMail1.Name = "hotelMail1";
            this.hotelMail1.Size = new System.Drawing.Size(383, 29);
            this.hotelMail1.TabIndex = 93;
            // 
            // hotelMail
            // 
            this.hotelMail.AutoSize = true;
            this.hotelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelMail.ForeColor = System.Drawing.Color.Blue;
            this.hotelMail.Location = new System.Drawing.Point(99, 188);
            this.hotelMail.Name = "hotelMail";
            this.hotelMail.Size = new System.Drawing.Size(81, 24);
            this.hotelMail.TabIndex = 94;
            this.hotelMail.Text = "E-mail :";
            // 
            // hotelAdresse1
            // 
            this.hotelAdresse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelAdresse1.Location = new System.Drawing.Point(330, 143);
            this.hotelAdresse1.Name = "hotelAdresse1";
            this.hotelAdresse1.Size = new System.Drawing.Size(383, 29);
            this.hotelAdresse1.TabIndex = 91;
            // 
            // hotelAdresse
            // 
            this.hotelAdresse.AutoSize = true;
            this.hotelAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelAdresse.ForeColor = System.Drawing.Color.Blue;
            this.hotelAdresse.Location = new System.Drawing.Point(99, 146);
            this.hotelAdresse.Name = "hotelAdresse";
            this.hotelAdresse.Size = new System.Drawing.Size(99, 24);
            this.hotelAdresse.TabIndex = 92;
            this.hotelAdresse.Text = "Adresse :";
            // 
            // hotelContacts1
            // 
            this.hotelContacts1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelContacts1.Location = new System.Drawing.Point(330, 97);
            this.hotelContacts1.Name = "hotelContacts1";
            this.hotelContacts1.Size = new System.Drawing.Size(383, 29);
            this.hotelContacts1.TabIndex = 89;
            // 
            // hotelContacts
            // 
            this.hotelContacts.AutoSize = true;
            this.hotelContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelContacts.ForeColor = System.Drawing.Color.Blue;
            this.hotelContacts.Location = new System.Drawing.Point(99, 100);
            this.hotelContacts.Name = "hotelContacts";
            this.hotelContacts.Size = new System.Drawing.Size(102, 24);
            this.hotelContacts.TabIndex = 90;
            this.hotelContacts.Text = "Contacts :";
            // 
            // hotelNom1
            // 
            this.hotelNom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelNom1.Location = new System.Drawing.Point(330, 53);
            this.hotelNom1.Name = "hotelNom1";
            this.hotelNom1.Size = new System.Drawing.Size(383, 29);
            this.hotelNom1.TabIndex = 87;
            // 
            // hotelNom
            // 
            this.hotelNom.AutoSize = true;
            this.hotelNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelNom.ForeColor = System.Drawing.Color.Blue;
            this.hotelNom.Location = new System.Drawing.Point(99, 56);
            this.hotelNom.Name = "hotelNom";
            this.hotelNom.Size = new System.Drawing.Size(66, 24);
            this.hotelNom.TabIndex = 88;
            this.hotelNom.Text = "Nom :";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Controls.Add(this.r);
            this.panel4.Controls.Add(this.o1);
            this.panel4.Controls.Add(this.l);
            this.panel4.Controls.Add(this.e);
            this.panel4.Controls.Add(this.t);
            this.panel4.Controls.Add(this.o);
            this.panel4.Controls.Add(this.h);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(68, 481);
            this.panel4.TabIndex = 86;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(11, 385);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(40, 57);
            this.r.TabIndex = 8;
            this.r.Text = "r";
            // 
            // o1
            // 
            this.o1.AutoSize = true;
            this.o1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o1.Location = new System.Drawing.Point(9, 328);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(45, 57);
            this.o1.TabIndex = 6;
            this.o1.Text = "o";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(12, 271);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(38, 57);
            this.l.TabIndex = 5;
            this.l.Text = "l";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(10, 214);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(42, 57);
            this.e.TabIndex = 4;
            this.e.Text = "e";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(11, 157);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(41, 57);
            this.t.TabIndex = 3;
            this.t.Text = "t";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.Location = new System.Drawing.Point(9, 100);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(45, 57);
            this.o.TabIndex = 2;
            this.o.Text = "o";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(2, 43);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(59, 57);
            this.h.TabIndex = 1;
            this.h.Text = "H";
            // 
            // hotelAnnuler
            // 
            this.hotelAnnuler.BackColor = System.Drawing.Color.Yellow;
            this.hotelAnnuler.FlatAppearance.BorderSize = 0;
            this.hotelAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotelAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelAnnuler.ForeColor = System.Drawing.Color.Red;
            this.hotelAnnuler.Location = new System.Drawing.Point(574, 393);
            this.hotelAnnuler.Name = "hotelAnnuler";
            this.hotelAnnuler.Size = new System.Drawing.Size(107, 43);
            this.hotelAnnuler.TabIndex = 2;
            this.hotelAnnuler.Text = "Retour";
            this.hotelAnnuler.UseVisualStyleBackColor = false;
            this.hotelAnnuler.Click += new System.EventHandler(this.hotelAnnuler_Click);
            // 
            // hotelValider
            // 
            this.hotelValider.BackColor = System.Drawing.Color.Yellow;
            this.hotelValider.FlatAppearance.BorderSize = 0;
            this.hotelValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hotelValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelValider.ForeColor = System.Drawing.Color.Red;
            this.hotelValider.Location = new System.Drawing.Point(461, 393);
            this.hotelValider.Name = "hotelValider";
            this.hotelValider.Size = new System.Drawing.Size(107, 43);
            this.hotelValider.TabIndex = 1;
            this.hotelValider.Text = "Valider";
            this.hotelValider.UseVisualStyleBackColor = false;
            this.hotelValider.Click += new System.EventHandler(this.hotelValider_Click);
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 512);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.MaskedTextBox hotelChambre1;
        private System.Windows.Forms.Label hotelChambre;
        private System.Windows.Forms.MaskedTextBox hotelLogo1;
        private System.Windows.Forms.Label hotelLogo;
        private System.Windows.Forms.MaskedTextBox hotelWeb1;
        private System.Windows.Forms.Label hotelWeb;
        private System.Windows.Forms.MaskedTextBox hotelMail1;
        private System.Windows.Forms.Label hotelMail;
        private System.Windows.Forms.MaskedTextBox hotelAdresse1;
        private System.Windows.Forms.Label hotelAdresse;
        private System.Windows.Forms.MaskedTextBox hotelContacts1;
        private System.Windows.Forms.Label hotelContacts;
        private System.Windows.Forms.MaskedTextBox hotelNom1;
        private System.Windows.Forms.Label hotelNom;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label o1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label o;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Button hotelAnnuler;
        private System.Windows.Forms.Button hotelValider;
        private System.Windows.Forms.Label r;
    }
}