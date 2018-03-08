namespace BE_Informatique
{
    partial class Modification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modification));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titre = new System.Windows.Forms.Label();
            this.reduire = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.hotelor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.modificationMontant1 = new System.Windows.Forms.ComboBox();
            this.modificationChambre1 = new System.Windows.Forms.ComboBox();
            this.modificationAdresse1 = new System.Windows.Forms.ComboBox();
            this.modificationMail1 = new System.Windows.Forms.ComboBox();
            this.modificationContacts1 = new System.Windows.Forms.ComboBox();
            this.modificationPrenoms1 = new System.Windows.Forms.ComboBox();
            this.modificationNoms1 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.r = new System.Windows.Forms.Label();
            this.o1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.modificationMontant = new System.Windows.Forms.Label();
            this.modificationBonus1 = new System.Windows.Forms.ComboBox();
            this.modificationMode1 = new System.Windows.Forms.ComboBox();
            this.modificationBancaire = new System.Windows.Forms.GroupBox();
            this.modificationCarte1 = new System.Windows.Forms.ComboBox();
            this.modificationNom1 = new System.Windows.Forms.ComboBox();
            this.modificationCarte = new System.Windows.Forms.Label();
            this.modificationNom = new System.Windows.Forms.Label();
            this.modificationValider = new System.Windows.Forms.Button();
            this.modificationMobile = new System.Windows.Forms.GroupBox();
            this.modificationContact = new System.Windows.Forms.Label();
            this.modificationContact1 = new System.Windows.Forms.ComboBox();
            this.modificationAnnuler = new System.Windows.Forms.Button();
            this.modificationMode = new System.Windows.Forms.Label();
            this.modificationSortie = new System.Windows.Forms.Label();
            this.modificationChambre = new System.Windows.Forms.Label();
            this.modificationSortie1 = new System.Windows.Forms.DateTimePicker();
            this.modificationAdresse = new System.Windows.Forms.Label();
            this.modificationPrenoms = new System.Windows.Forms.Label();
            this.modificationMail = new System.Windows.Forms.Label();
            this.modificationBonus = new System.Windows.Forms.Label();
            this.modificationContacts = new System.Windows.Forms.Label();
            this.modificationNoms = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.modificationBancaire.SuspendLayout();
            this.modificationMobile.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(769, 38);
            this.panel1.TabIndex = 2;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(315, 3);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(155, 33);
            this.titre.TabIndex = 17;
            this.titre.Text = "Modification";
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
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(769, 684);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.modificationMontant1);
            this.panel3.Controls.Add(this.modificationChambre1);
            this.panel3.Controls.Add(this.modificationAdresse1);
            this.panel3.Controls.Add(this.modificationMail1);
            this.panel3.Controls.Add(this.modificationContacts1);
            this.panel3.Controls.Add(this.modificationPrenoms1);
            this.panel3.Controls.Add(this.modificationNoms1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.modificationMontant);
            this.panel3.Controls.Add(this.modificationBonus1);
            this.panel3.Controls.Add(this.modificationMode1);
            this.panel3.Controls.Add(this.modificationBancaire);
            this.panel3.Controls.Add(this.modificationValider);
            this.panel3.Controls.Add(this.modificationMobile);
            this.panel3.Controls.Add(this.modificationAnnuler);
            this.panel3.Controls.Add(this.modificationMode);
            this.panel3.Controls.Add(this.modificationSortie);
            this.panel3.Controls.Add(this.modificationChambre);
            this.panel3.Controls.Add(this.modificationSortie1);
            this.panel3.Controls.Add(this.modificationAdresse);
            this.panel3.Controls.Add(this.modificationPrenoms);
            this.panel3.Controls.Add(this.modificationMail);
            this.panel3.Controls.Add(this.modificationBonus);
            this.panel3.Controls.Add(this.modificationContacts);
            this.panel3.Controls.Add(this.modificationNoms);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(769, 684);
            this.panel3.TabIndex = 4;
            // 
            // modificationMontant1
            // 
            this.modificationMontant1.BackColor = System.Drawing.Color.White;
            this.modificationMontant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationMontant1.FormattingEnabled = true;
            this.modificationMontant1.Location = new System.Drawing.Point(312, 534);
            this.modificationMontant1.Name = "modificationMontant1";
            this.modificationMontant1.Size = new System.Drawing.Size(415, 32);
            this.modificationMontant1.Sorted = true;
            this.modificationMontant1.TabIndex = 111;
            // 
            // modificationChambre1
            // 
            this.modificationChambre1.BackColor = System.Drawing.Color.White;
            this.modificationChambre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationChambre1.FormattingEnabled = true;
            this.modificationChambre1.Location = new System.Drawing.Point(312, 213);
            this.modificationChambre1.Name = "modificationChambre1";
            this.modificationChambre1.Size = new System.Drawing.Size(415, 32);
            this.modificationChambre1.Sorted = true;
            this.modificationChambre1.TabIndex = 108;
            // 
            // modificationAdresse1
            // 
            this.modificationAdresse1.BackColor = System.Drawing.Color.White;
            this.modificationAdresse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationAdresse1.FormattingEnabled = true;
            this.modificationAdresse1.Location = new System.Drawing.Point(312, 175);
            this.modificationAdresse1.Name = "modificationAdresse1";
            this.modificationAdresse1.Size = new System.Drawing.Size(415, 32);
            this.modificationAdresse1.Sorted = true;
            this.modificationAdresse1.TabIndex = 107;
            // 
            // modificationMail1
            // 
            this.modificationMail1.BackColor = System.Drawing.Color.White;
            this.modificationMail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationMail1.FormattingEnabled = true;
            this.modificationMail1.Location = new System.Drawing.Point(312, 137);
            this.modificationMail1.Name = "modificationMail1";
            this.modificationMail1.Size = new System.Drawing.Size(415, 32);
            this.modificationMail1.Sorted = true;
            this.modificationMail1.TabIndex = 106;
            // 
            // modificationContacts1
            // 
            this.modificationContacts1.BackColor = System.Drawing.Color.White;
            this.modificationContacts1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationContacts1.FormattingEnabled = true;
            this.modificationContacts1.Location = new System.Drawing.Point(312, 99);
            this.modificationContacts1.Name = "modificationContacts1";
            this.modificationContacts1.Size = new System.Drawing.Size(415, 32);
            this.modificationContacts1.Sorted = true;
            this.modificationContacts1.TabIndex = 105;
            // 
            // modificationPrenoms1
            // 
            this.modificationPrenoms1.BackColor = System.Drawing.Color.White;
            this.modificationPrenoms1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationPrenoms1.FormattingEnabled = true;
            this.modificationPrenoms1.Location = new System.Drawing.Point(312, 61);
            this.modificationPrenoms1.Name = "modificationPrenoms1";
            this.modificationPrenoms1.Size = new System.Drawing.Size(415, 32);
            this.modificationPrenoms1.Sorted = true;
            this.modificationPrenoms1.TabIndex = 104;
            // 
            // modificationNoms1
            // 
            this.modificationNoms1.BackColor = System.Drawing.Color.White;
            this.modificationNoms1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationNoms1.FormattingEnabled = true;
            this.modificationNoms1.Location = new System.Drawing.Point(312, 23);
            this.modificationNoms1.Name = "modificationNoms1";
            this.modificationNoms1.Size = new System.Drawing.Size(415, 32);
            this.modificationNoms1.Sorted = true;
            this.modificationNoms1.TabIndex = 9;
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
            this.panel4.Size = new System.Drawing.Size(69, 684);
            this.panel4.TabIndex = 103;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(11, 454);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(40, 57);
            this.r.TabIndex = 8;
            this.r.Text = "r";
            // 
            // o1
            // 
            this.o1.AutoSize = true;
            this.o1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o1.Location = new System.Drawing.Point(9, 397);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(45, 57);
            this.o1.TabIndex = 6;
            this.o1.Text = "o";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(12, 340);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(38, 57);
            this.l.TabIndex = 5;
            this.l.Text = "l";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(10, 283);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(42, 57);
            this.e.TabIndex = 4;
            this.e.Text = "e";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(11, 226);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(41, 57);
            this.t.TabIndex = 3;
            this.t.Text = "t";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.Location = new System.Drawing.Point(9, 169);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(45, 57);
            this.o.TabIndex = 2;
            this.o.Text = "o";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(2, 112);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(59, 57);
            this.h.TabIndex = 1;
            this.h.Text = "H";
            // 
            // modificationMontant
            // 
            this.modificationMontant.AutoSize = true;
            this.modificationMontant.BackColor = System.Drawing.Color.Transparent;
            this.modificationMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationMontant.ForeColor = System.Drawing.Color.Blue;
            this.modificationMontant.Location = new System.Drawing.Point(109, 537);
            this.modificationMontant.Name = "modificationMontant";
            this.modificationMontant.Size = new System.Drawing.Size(96, 24);
            this.modificationMontant.TabIndex = 88;
            this.modificationMontant.Text = "Montant :";
            // 
            // modificationBonus1
            // 
            this.modificationBonus1.BackColor = System.Drawing.Color.White;
            this.modificationBonus1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modificationBonus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationBonus1.FormattingEnabled = true;
            this.modificationBonus1.Location = new System.Drawing.Point(312, 496);
            this.modificationBonus1.Name = "modificationBonus1";
            this.modificationBonus1.Size = new System.Drawing.Size(415, 32);
            this.modificationBonus1.Sorted = true;
            this.modificationBonus1.TabIndex = 7;
            // 
            // modificationMode1
            // 
            this.modificationMode1.BackColor = System.Drawing.Color.White;
            this.modificationMode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modificationMode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationMode1.FormattingEnabled = true;
            this.modificationMode1.Location = new System.Drawing.Point(312, 251);
            this.modificationMode1.Name = "modificationMode1";
            this.modificationMode1.Size = new System.Drawing.Size(415, 32);
            this.modificationMode1.Sorted = true;
            this.modificationMode1.TabIndex = 6;
            // 
            // modificationBancaire
            // 
            this.modificationBancaire.BackColor = System.Drawing.Color.Transparent;
            this.modificationBancaire.Controls.Add(this.modificationCarte1);
            this.modificationBancaire.Controls.Add(this.modificationNom1);
            this.modificationBancaire.Controls.Add(this.modificationCarte);
            this.modificationBancaire.Controls.Add(this.modificationNom);
            this.modificationBancaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationBancaire.ForeColor = System.Drawing.Color.Blue;
            this.modificationBancaire.Location = new System.Drawing.Point(109, 377);
            this.modificationBancaire.Name = "modificationBancaire";
            this.modificationBancaire.Size = new System.Drawing.Size(618, 113);
            this.modificationBancaire.TabIndex = 86;
            this.modificationBancaire.TabStop = false;
            this.modificationBancaire.Text = "Bancaire";
            // 
            // modificationCarte1
            // 
            this.modificationCarte1.BackColor = System.Drawing.Color.White;
            this.modificationCarte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationCarte1.FormattingEnabled = true;
            this.modificationCarte1.Location = new System.Drawing.Point(235, 70);
            this.modificationCarte1.Name = "modificationCarte1";
            this.modificationCarte1.Size = new System.Drawing.Size(363, 32);
            this.modificationCarte1.Sorted = true;
            this.modificationCarte1.TabIndex = 110;
            // 
            // modificationNom1
            // 
            this.modificationNom1.BackColor = System.Drawing.Color.White;
            this.modificationNom1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modificationNom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationNom1.FormattingEnabled = true;
            this.modificationNom1.Location = new System.Drawing.Point(235, 32);
            this.modificationNom1.Name = "modificationNom1";
            this.modificationNom1.Size = new System.Drawing.Size(363, 32);
            this.modificationNom1.Sorted = true;
            this.modificationNom1.TabIndex = 0;
            // 
            // modificationCarte
            // 
            this.modificationCarte.AutoSize = true;
            this.modificationCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationCarte.ForeColor = System.Drawing.Color.Blue;
            this.modificationCarte.Location = new System.Drawing.Point(34, 73);
            this.modificationCarte.Name = "modificationCarte";
            this.modificationCarte.Size = new System.Drawing.Size(126, 24);
            this.modificationCarte.TabIndex = 8;
            this.modificationCarte.Text = "N° de carte :";
            // 
            // modificationNom
            // 
            this.modificationNom.AutoSize = true;
            this.modificationNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationNom.ForeColor = System.Drawing.Color.Blue;
            this.modificationNom.Location = new System.Drawing.Point(34, 35);
            this.modificationNom.Name = "modificationNom";
            this.modificationNom.Size = new System.Drawing.Size(195, 24);
            this.modificationNom.TabIndex = 7;
            this.modificationNom.Text = "Nom de la banque :";
            // 
            // modificationValider
            // 
            this.modificationValider.BackColor = System.Drawing.Color.Yellow;
            this.modificationValider.FlatAppearance.BorderSize = 0;
            this.modificationValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificationValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationValider.ForeColor = System.Drawing.Color.Red;
            this.modificationValider.Location = new System.Drawing.Point(466, 625);
            this.modificationValider.Name = "modificationValider";
            this.modificationValider.Size = new System.Drawing.Size(104, 42);
            this.modificationValider.TabIndex = 10;
            this.modificationValider.Text = "Valider";
            this.modificationValider.UseVisualStyleBackColor = false;
            this.modificationValider.Click += new System.EventHandler(this.modificationValider_Click);
            // 
            // modificationMobile
            // 
            this.modificationMobile.BackColor = System.Drawing.Color.Transparent;
            this.modificationMobile.Controls.Add(this.modificationContact);
            this.modificationMobile.Controls.Add(this.modificationContact1);
            this.modificationMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationMobile.ForeColor = System.Drawing.Color.Blue;
            this.modificationMobile.Location = new System.Drawing.Point(113, 289);
            this.modificationMobile.Name = "modificationMobile";
            this.modificationMobile.Size = new System.Drawing.Size(614, 82);
            this.modificationMobile.TabIndex = 85;
            this.modificationMobile.TabStop = false;
            this.modificationMobile.Text = "Mobile monney";
            // 
            // modificationContact
            // 
            this.modificationContact.AutoSize = true;
            this.modificationContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationContact.ForeColor = System.Drawing.Color.Blue;
            this.modificationContact.Location = new System.Drawing.Point(30, 39);
            this.modificationContact.Name = "modificationContact";
            this.modificationContact.Size = new System.Drawing.Size(92, 24);
            this.modificationContact.TabIndex = 6;
            this.modificationContact.Text = "Contact :";
            // 
            // modificationContact1
            // 
            this.modificationContact1.BackColor = System.Drawing.Color.White;
            this.modificationContact1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationContact1.FormattingEnabled = true;
            this.modificationContact1.Location = new System.Drawing.Point(179, 36);
            this.modificationContact1.Name = "modificationContact1";
            this.modificationContact1.Size = new System.Drawing.Size(415, 32);
            this.modificationContact1.Sorted = true;
            this.modificationContact1.TabIndex = 109;
            // 
            // modificationAnnuler
            // 
            this.modificationAnnuler.BackColor = System.Drawing.Color.Yellow;
            this.modificationAnnuler.FlatAppearance.BorderSize = 0;
            this.modificationAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificationAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationAnnuler.ForeColor = System.Drawing.Color.Red;
            this.modificationAnnuler.Location = new System.Drawing.Point(576, 625);
            this.modificationAnnuler.Name = "modificationAnnuler";
            this.modificationAnnuler.Size = new System.Drawing.Size(105, 42);
            this.modificationAnnuler.TabIndex = 11;
            this.modificationAnnuler.Text = "Retour";
            this.modificationAnnuler.UseVisualStyleBackColor = false;
            this.modificationAnnuler.Click += new System.EventHandler(this.modificationAnnuler_Click);
            // 
            // modificationMode
            // 
            this.modificationMode.AutoSize = true;
            this.modificationMode.BackColor = System.Drawing.Color.Transparent;
            this.modificationMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationMode.ForeColor = System.Drawing.Color.Blue;
            this.modificationMode.Location = new System.Drawing.Point(109, 254);
            this.modificationMode.Name = "modificationMode";
            this.modificationMode.Size = new System.Drawing.Size(197, 24);
            this.modificationMode.TabIndex = 84;
            this.modificationMode.Text = "Mode de paiement :";
            // 
            // modificationSortie
            // 
            this.modificationSortie.AutoSize = true;
            this.modificationSortie.BackColor = System.Drawing.Color.Transparent;
            this.modificationSortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationSortie.ForeColor = System.Drawing.Color.Blue;
            this.modificationSortie.Location = new System.Drawing.Point(109, 576);
            this.modificationSortie.Name = "modificationSortie";
            this.modificationSortie.Size = new System.Drawing.Size(151, 24);
            this.modificationSortie.TabIndex = 98;
            this.modificationSortie.Text = "Date de sortie :";
            // 
            // modificationChambre
            // 
            this.modificationChambre.AutoSize = true;
            this.modificationChambre.BackColor = System.Drawing.Color.Transparent;
            this.modificationChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationChambre.ForeColor = System.Drawing.Color.Blue;
            this.modificationChambre.Location = new System.Drawing.Point(109, 216);
            this.modificationChambre.Name = "modificationChambre";
            this.modificationChambre.Size = new System.Drawing.Size(107, 24);
            this.modificationChambre.TabIndex = 83;
            this.modificationChambre.Text = "Chambre :";
            // 
            // modificationSortie1
            // 
            this.modificationSortie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationSortie1.Location = new System.Drawing.Point(312, 572);
            this.modificationSortie1.Name = "modificationSortie1";
            this.modificationSortie1.Size = new System.Drawing.Size(415, 29);
            this.modificationSortie1.TabIndex = 9;
            // 
            // modificationAdresse
            // 
            this.modificationAdresse.AutoSize = true;
            this.modificationAdresse.BackColor = System.Drawing.Color.Transparent;
            this.modificationAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationAdresse.ForeColor = System.Drawing.Color.Blue;
            this.modificationAdresse.Location = new System.Drawing.Point(109, 178);
            this.modificationAdresse.Name = "modificationAdresse";
            this.modificationAdresse.Size = new System.Drawing.Size(99, 24);
            this.modificationAdresse.TabIndex = 82;
            this.modificationAdresse.Text = "Adresse :";
            // 
            // modificationPrenoms
            // 
            this.modificationPrenoms.AutoSize = true;
            this.modificationPrenoms.BackColor = System.Drawing.Color.Transparent;
            this.modificationPrenoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationPrenoms.ForeColor = System.Drawing.Color.Blue;
            this.modificationPrenoms.Location = new System.Drawing.Point(109, 64);
            this.modificationPrenoms.Name = "modificationPrenoms";
            this.modificationPrenoms.Size = new System.Drawing.Size(105, 24);
            this.modificationPrenoms.TabIndex = 100;
            this.modificationPrenoms.Text = "Prénoms :";
            // 
            // modificationMail
            // 
            this.modificationMail.AutoSize = true;
            this.modificationMail.BackColor = System.Drawing.Color.Transparent;
            this.modificationMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationMail.ForeColor = System.Drawing.Color.Blue;
            this.modificationMail.Location = new System.Drawing.Point(109, 140);
            this.modificationMail.Name = "modificationMail";
            this.modificationMail.Size = new System.Drawing.Size(81, 24);
            this.modificationMail.TabIndex = 81;
            this.modificationMail.Text = "E-mail :";
            // 
            // modificationBonus
            // 
            this.modificationBonus.AutoSize = true;
            this.modificationBonus.BackColor = System.Drawing.Color.Transparent;
            this.modificationBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationBonus.ForeColor = System.Drawing.Color.Blue;
            this.modificationBonus.Location = new System.Drawing.Point(109, 499);
            this.modificationBonus.Name = "modificationBonus";
            this.modificationBonus.Size = new System.Drawing.Size(81, 24);
            this.modificationBonus.TabIndex = 87;
            this.modificationBonus.Text = "Bonus :";
            // 
            // modificationContacts
            // 
            this.modificationContacts.AutoSize = true;
            this.modificationContacts.BackColor = System.Drawing.Color.Transparent;
            this.modificationContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationContacts.ForeColor = System.Drawing.Color.Blue;
            this.modificationContacts.Location = new System.Drawing.Point(109, 102);
            this.modificationContacts.Name = "modificationContacts";
            this.modificationContacts.Size = new System.Drawing.Size(102, 24);
            this.modificationContacts.TabIndex = 80;
            this.modificationContacts.Text = "Contacts :";
            // 
            // modificationNoms
            // 
            this.modificationNoms.AutoSize = true;
            this.modificationNoms.BackColor = System.Drawing.Color.Transparent;
            this.modificationNoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificationNoms.ForeColor = System.Drawing.Color.Blue;
            this.modificationNoms.Location = new System.Drawing.Point(109, 26);
            this.modificationNoms.Name = "modificationNoms";
            this.modificationNoms.Size = new System.Drawing.Size(76, 24);
            this.modificationNoms.TabIndex = 79;
            this.modificationNoms.Text = "Noms :";
            // 
            // Modification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 722);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.modificationBancaire.ResumeLayout(false);
            this.modificationBancaire.PerformLayout();
            this.modificationMobile.ResumeLayout(false);
            this.modificationMobile.PerformLayout();
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
        private System.Windows.Forms.ComboBox modificationMontant1;
        private System.Windows.Forms.ComboBox modificationChambre1;
        private System.Windows.Forms.ComboBox modificationAdresse1;
        private System.Windows.Forms.ComboBox modificationMail1;
        private System.Windows.Forms.ComboBox modificationContacts1;
        private System.Windows.Forms.ComboBox modificationPrenoms1;
        private System.Windows.Forms.ComboBox modificationNoms1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label o1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label o;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Label modificationMontant;
        private System.Windows.Forms.ComboBox modificationBonus1;
        private System.Windows.Forms.ComboBox modificationMode1;
        private System.Windows.Forms.GroupBox modificationBancaire;
        private System.Windows.Forms.ComboBox modificationCarte1;
        private System.Windows.Forms.ComboBox modificationNom1;
        private System.Windows.Forms.Label modificationCarte;
        private System.Windows.Forms.Label modificationNom;
        private System.Windows.Forms.Button modificationValider;
        private System.Windows.Forms.GroupBox modificationMobile;
        private System.Windows.Forms.Label modificationContact;
        private System.Windows.Forms.ComboBox modificationContact1;
        private System.Windows.Forms.Button modificationAnnuler;
        private System.Windows.Forms.Label modificationMode;
        private System.Windows.Forms.Label modificationSortie;
        private System.Windows.Forms.Label modificationChambre;
        private System.Windows.Forms.DateTimePicker modificationSortie1;
        private System.Windows.Forms.Label modificationAdresse;
        private System.Windows.Forms.Label modificationPrenoms;
        private System.Windows.Forms.Label modificationMail;
        private System.Windows.Forms.Label modificationBonus;
        private System.Windows.Forms.Label modificationContacts;
        private System.Windows.Forms.Label modificationNoms;
    }
}