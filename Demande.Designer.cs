namespace BE_Informatique
{
    partial class Demande
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Demande));
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
            this.demandeMontant = new System.Windows.Forms.Label();
            this.demandeBonus1 = new System.Windows.Forms.ComboBox();
            this.demandeMode1 = new System.Windows.Forms.ComboBox();
            this.paiementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPaiements = new BE_Informatique.BDPaiements();
            this.demandeBancaire = new System.Windows.Forms.GroupBox();
            this.banqueNom1 = new System.Windows.Forms.ComboBox();
            this.banqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDBanque = new BE_Informatique.BDBanque();
            this.banqueCarte1 = new System.Windows.Forms.MaskedTextBox();
            this.banqueCarte = new System.Windows.Forms.Label();
            this.banqueNom = new System.Windows.Forms.Label();
            this.demandeVAlider = new System.Windows.Forms.Button();
            this.demandeMontant1 = new System.Windows.Forms.MaskedTextBox();
            this.demandeMobile = new System.Windows.Forms.GroupBox();
            this.mobileContact1 = new System.Windows.Forms.MaskedTextBox();
            this.mobileContact = new System.Windows.Forms.Label();
            this.demandeAnnuler = new System.Windows.Forms.Button();
            this.demandeAdresse1 = new System.Windows.Forms.MaskedTextBox();
            this.demandeMode = new System.Windows.Forms.Label();
            this.demandeSortie = new System.Windows.Forms.Label();
            this.demandeMail1 = new System.Windows.Forms.MaskedTextBox();
            this.demandeChambre = new System.Windows.Forms.Label();
            this.demandeSortie1 = new System.Windows.Forms.DateTimePicker();
            this.demandeContacts1 = new System.Windows.Forms.MaskedTextBox();
            this.demandeAdresse = new System.Windows.Forms.Label();
            this.demandePrenoms = new System.Windows.Forms.Label();
            this.demandeNoms1 = new System.Windows.Forms.MaskedTextBox();
            this.demandeMail = new System.Windows.Forms.Label();
            this.demandePrenoms1 = new System.Windows.Forms.MaskedTextBox();
            this.demandeBonus = new System.Windows.Forms.Label();
            this.demandeContacts = new System.Windows.Forms.Label();
            this.demandeChambre1 = new System.Windows.Forms.MaskedTextBox();
            this.demandeNoms = new System.Windows.Forms.Label();
            this.paiementsTableAdapter = new BE_Informatique.BDPaiementsTableAdapters.PaiementsTableAdapter();
            this.banqueTableAdapter = new BE_Informatique.BDBanqueTableAdapters.BanqueTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paiementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPaiements)).BeginInit();
            this.demandeBancaire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDBanque)).BeginInit();
            this.demandeMobile.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(779, 38);
            this.panel1.TabIndex = 1;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(334, 3);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(139, 33);
            this.titre.TabIndex = 17;
            this.titre.Text = "Réservation";
            // 
            // reduire
            // 
            this.reduire.FlatAppearance.BorderSize = 0;
            this.reduire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduire.Image = ((System.Drawing.Image)(resources.GetObject("reduire.Image")));
            this.reduire.Location = new System.Drawing.Point(723, 5);
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
            this.fermer.Location = new System.Drawing.Point(745, 5);
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
            this.hotelor.Location = new System.Drawing.Point(3, 2);
            this.hotelor.Name = "hotelor";
            this.hotelor.Size = new System.Drawing.Size(68, 26);
            this.hotelor.TabIndex = 8;
            this.hotelor.Text = "Hotelor";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.demandeMontant);
            this.panel2.Controls.Add(this.demandeBonus1);
            this.panel2.Controls.Add(this.demandeMode1);
            this.panel2.Controls.Add(this.demandeBancaire);
            this.panel2.Controls.Add(this.demandeVAlider);
            this.panel2.Controls.Add(this.demandeMontant1);
            this.panel2.Controls.Add(this.demandeMobile);
            this.panel2.Controls.Add(this.demandeAnnuler);
            this.panel2.Controls.Add(this.demandeAdresse1);
            this.panel2.Controls.Add(this.demandeMode);
            this.panel2.Controls.Add(this.demandeSortie);
            this.panel2.Controls.Add(this.demandeMail1);
            this.panel2.Controls.Add(this.demandeChambre);
            this.panel2.Controls.Add(this.demandeSortie1);
            this.panel2.Controls.Add(this.demandeContacts1);
            this.panel2.Controls.Add(this.demandeAdresse);
            this.panel2.Controls.Add(this.demandePrenoms);
            this.panel2.Controls.Add(this.demandeNoms1);
            this.panel2.Controls.Add(this.demandeMail);
            this.panel2.Controls.Add(this.demandePrenoms1);
            this.panel2.Controls.Add(this.demandeBonus);
            this.panel2.Controls.Add(this.demandeContacts);
            this.panel2.Controls.Add(this.demandeChambre1);
            this.panel2.Controls.Add(this.demandeNoms);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 649);
            this.panel2.TabIndex = 2;
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
            this.panel3.Size = new System.Drawing.Size(72, 649);
            this.panel3.TabIndex = 103;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(14, 453);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(40, 57);
            this.r.TabIndex = 8;
            this.r.Text = "r";
            // 
            // o1
            // 
            this.o1.AutoSize = true;
            this.o1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o1.Location = new System.Drawing.Point(12, 396);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(45, 57);
            this.o1.TabIndex = 6;
            this.o1.Text = "o";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(15, 339);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(38, 57);
            this.l.TabIndex = 5;
            this.l.Text = "l";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(13, 282);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(42, 57);
            this.e.TabIndex = 4;
            this.e.Text = "e";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(14, 225);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(41, 57);
            this.t.TabIndex = 3;
            this.t.Text = "t";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.Location = new System.Drawing.Point(12, 168);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(45, 57);
            this.o.TabIndex = 2;
            this.o.Text = "o";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(5, 111);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(59, 57);
            this.h.TabIndex = 1;
            this.h.Text = "H";
            // 
            // demandeMontant
            // 
            this.demandeMontant.AutoSize = true;
            this.demandeMontant.BackColor = System.Drawing.Color.Transparent;
            this.demandeMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeMontant.ForeColor = System.Drawing.Color.Blue;
            this.demandeMontant.Location = new System.Drawing.Point(106, 513);
            this.demandeMontant.Name = "demandeMontant";
            this.demandeMontant.Size = new System.Drawing.Size(96, 24);
            this.demandeMontant.TabIndex = 88;
            this.demandeMontant.Text = "Montant :";
            // 
            // demandeBonus1
            // 
            this.demandeBonus1.BackColor = System.Drawing.Color.White;
            this.demandeBonus1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.demandeBonus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeBonus1.FormattingEnabled = true;
            this.demandeBonus1.Location = new System.Drawing.Point(309, 473);
            this.demandeBonus1.Name = "demandeBonus1";
            this.demandeBonus1.Size = new System.Drawing.Size(427, 32);
            this.demandeBonus1.Sorted = true;
            this.demandeBonus1.TabIndex = 7;
            // 
            // demandeMode1
            // 
            this.demandeMode1.BackColor = System.Drawing.Color.White;
            this.demandeMode1.DataSource = this.paiementsBindingSource;
            this.demandeMode1.DisplayMember = "Paiement";
            this.demandeMode1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.demandeMode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeMode1.FormattingEnabled = true;
            this.demandeMode1.Location = new System.Drawing.Point(309, 235);
            this.demandeMode1.Name = "demandeMode1";
            this.demandeMode1.Size = new System.Drawing.Size(427, 32);
            this.demandeMode1.TabIndex = 6;
            this.demandeMode1.ValueMember = "Paiement";
            // 
            // paiementsBindingSource
            // 
            this.paiementsBindingSource.DataMember = "Paiements";
            this.paiementsBindingSource.DataSource = this.bDPaiements;
            // 
            // bDPaiements
            // 
            this.bDPaiements.DataSetName = "BDPaiements";
            this.bDPaiements.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // demandeBancaire
            // 
            this.demandeBancaire.BackColor = System.Drawing.Color.Transparent;
            this.demandeBancaire.Controls.Add(this.banqueNom1);
            this.demandeBancaire.Controls.Add(this.banqueCarte1);
            this.demandeBancaire.Controls.Add(this.banqueCarte);
            this.demandeBancaire.Controls.Add(this.banqueNom);
            this.demandeBancaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeBancaire.ForeColor = System.Drawing.Color.Blue;
            this.demandeBancaire.Location = new System.Drawing.Point(110, 353);
            this.demandeBancaire.Name = "demandeBancaire";
            this.demandeBancaire.Size = new System.Drawing.Size(626, 114);
            this.demandeBancaire.TabIndex = 86;
            this.demandeBancaire.TabStop = false;
            this.demandeBancaire.Text = "Bancaire";
            // 
            // banqueNom1
            // 
            this.banqueNom1.BackColor = System.Drawing.Color.White;
            this.banqueNom1.DataSource = this.banqueBindingSource;
            this.banqueNom1.DisplayMember = "Nom";
            this.banqueNom1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.banqueNom1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banqueNom1.FormattingEnabled = true;
            this.banqueNom1.Location = new System.Drawing.Point(243, 33);
            this.banqueNom1.Name = "banqueNom1";
            this.banqueNom1.Size = new System.Drawing.Size(364, 32);
            this.banqueNom1.TabIndex = 0;
            this.banqueNom1.ValueMember = "Nom";
            // 
            // banqueBindingSource
            // 
            this.banqueBindingSource.DataMember = "Banque";
            this.banqueBindingSource.DataSource = this.bDBanque;
            // 
            // bDBanque
            // 
            this.bDBanque.DataSetName = "BDBanque";
            this.bDBanque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // banqueCarte1
            // 
            this.banqueCarte1.BackColor = System.Drawing.Color.White;
            this.banqueCarte1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.banqueCarte1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banqueCarte1.Location = new System.Drawing.Point(243, 71);
            this.banqueCarte1.Name = "banqueCarte1";
            this.banqueCarte1.Size = new System.Drawing.Size(364, 29);
            this.banqueCarte1.TabIndex = 1;
            // 
            // banqueCarte
            // 
            this.banqueCarte.AutoSize = true;
            this.banqueCarte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banqueCarte.ForeColor = System.Drawing.Color.Blue;
            this.banqueCarte.Location = new System.Drawing.Point(42, 73);
            this.banqueCarte.Name = "banqueCarte";
            this.banqueCarte.Size = new System.Drawing.Size(126, 24);
            this.banqueCarte.TabIndex = 8;
            this.banqueCarte.Text = "N° de carte :";
            // 
            // banqueNom
            // 
            this.banqueNom.AutoSize = true;
            this.banqueNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banqueNom.ForeColor = System.Drawing.Color.Blue;
            this.banqueNom.Location = new System.Drawing.Point(42, 36);
            this.banqueNom.Name = "banqueNom";
            this.banqueNom.Size = new System.Drawing.Size(195, 24);
            this.banqueNom.TabIndex = 7;
            this.banqueNom.Text = "Nom de la banque :";
            // 
            // demandeVAlider
            // 
            this.demandeVAlider.BackColor = System.Drawing.Color.Yellow;
            this.demandeVAlider.FlatAppearance.BorderSize = 0;
            this.demandeVAlider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.demandeVAlider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeVAlider.ForeColor = System.Drawing.Color.Red;
            this.demandeVAlider.Location = new System.Drawing.Point(496, 591);
            this.demandeVAlider.Name = "demandeVAlider";
            this.demandeVAlider.Size = new System.Drawing.Size(103, 43);
            this.demandeVAlider.TabIndex = 10;
            this.demandeVAlider.Text = "Valider";
            this.demandeVAlider.UseVisualStyleBackColor = false;
            this.demandeVAlider.Click += new System.EventHandler(this.demandeVAlider_Click);
            // 
            // demandeMontant1
            // 
            this.demandeMontant1.BackColor = System.Drawing.Color.White;
            this.demandeMontant1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.demandeMontant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeMontant1.Location = new System.Drawing.Point(309, 511);
            this.demandeMontant1.Name = "demandeMontant1";
            this.demandeMontant1.Size = new System.Drawing.Size(427, 29);
            this.demandeMontant1.TabIndex = 8;
            // 
            // demandeMobile
            // 
            this.demandeMobile.BackColor = System.Drawing.Color.Transparent;
            this.demandeMobile.Controls.Add(this.mobileContact1);
            this.demandeMobile.Controls.Add(this.mobileContact);
            this.demandeMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeMobile.ForeColor = System.Drawing.Color.Blue;
            this.demandeMobile.Location = new System.Drawing.Point(110, 273);
            this.demandeMobile.Name = "demandeMobile";
            this.demandeMobile.Size = new System.Drawing.Size(626, 74);
            this.demandeMobile.TabIndex = 85;
            this.demandeMobile.TabStop = false;
            this.demandeMobile.Text = "Mobile monney";
            // 
            // mobileContact1
            // 
            this.mobileContact1.BackColor = System.Drawing.Color.White;
            this.mobileContact1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mobileContact1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileContact1.Location = new System.Drawing.Point(179, 32);
            this.mobileContact1.Name = "mobileContact1";
            this.mobileContact1.Size = new System.Drawing.Size(428, 29);
            this.mobileContact1.TabIndex = 0;
            // 
            // mobileContact
            // 
            this.mobileContact.AutoSize = true;
            this.mobileContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileContact.ForeColor = System.Drawing.Color.Blue;
            this.mobileContact.Location = new System.Drawing.Point(42, 34);
            this.mobileContact.Name = "mobileContact";
            this.mobileContact.Size = new System.Drawing.Size(92, 24);
            this.mobileContact.TabIndex = 6;
            this.mobileContact.Text = "Contact :";
            // 
            // demandeAnnuler
            // 
            this.demandeAnnuler.BackColor = System.Drawing.Color.Yellow;
            this.demandeAnnuler.FlatAppearance.BorderSize = 0;
            this.demandeAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.demandeAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeAnnuler.ForeColor = System.Drawing.Color.Red;
            this.demandeAnnuler.Location = new System.Drawing.Point(615, 591);
            this.demandeAnnuler.Name = "demandeAnnuler";
            this.demandeAnnuler.Size = new System.Drawing.Size(105, 43);
            this.demandeAnnuler.TabIndex = 11;
            this.demandeAnnuler.Text = "Retour";
            this.demandeAnnuler.UseVisualStyleBackColor = false;
            this.demandeAnnuler.Click += new System.EventHandler(this.demandeAnnuler_Click);
            // 
            // demandeAdresse1
            // 
            this.demandeAdresse1.BackColor = System.Drawing.Color.White;
            this.demandeAdresse1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.demandeAdresse1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeAdresse1.Location = new System.Drawing.Point(309, 165);
            this.demandeAdresse1.Name = "demandeAdresse1";
            this.demandeAdresse1.Size = new System.Drawing.Size(427, 29);
            this.demandeAdresse1.TabIndex = 4;
            // 
            // demandeMode
            // 
            this.demandeMode.AutoSize = true;
            this.demandeMode.BackColor = System.Drawing.Color.Transparent;
            this.demandeMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeMode.ForeColor = System.Drawing.Color.Blue;
            this.demandeMode.Location = new System.Drawing.Point(106, 238);
            this.demandeMode.Name = "demandeMode";
            this.demandeMode.Size = new System.Drawing.Size(197, 24);
            this.demandeMode.TabIndex = 84;
            this.demandeMode.Text = "Mode de paiement :";
            // 
            // demandeSortie
            // 
            this.demandeSortie.AutoSize = true;
            this.demandeSortie.BackColor = System.Drawing.Color.Transparent;
            this.demandeSortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeSortie.ForeColor = System.Drawing.Color.Blue;
            this.demandeSortie.Location = new System.Drawing.Point(106, 550);
            this.demandeSortie.Name = "demandeSortie";
            this.demandeSortie.Size = new System.Drawing.Size(151, 24);
            this.demandeSortie.TabIndex = 98;
            this.demandeSortie.Text = "Date de sortie :";
            // 
            // demandeMail1
            // 
            this.demandeMail1.BackColor = System.Drawing.Color.White;
            this.demandeMail1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.demandeMail1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeMail1.Location = new System.Drawing.Point(309, 130);
            this.demandeMail1.Name = "demandeMail1";
            this.demandeMail1.Size = new System.Drawing.Size(427, 29);
            this.demandeMail1.TabIndex = 3;
            // 
            // demandeChambre
            // 
            this.demandeChambre.AutoSize = true;
            this.demandeChambre.BackColor = System.Drawing.Color.Transparent;
            this.demandeChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeChambre.ForeColor = System.Drawing.Color.Blue;
            this.demandeChambre.Location = new System.Drawing.Point(106, 202);
            this.demandeChambre.Name = "demandeChambre";
            this.demandeChambre.Size = new System.Drawing.Size(107, 24);
            this.demandeChambre.TabIndex = 83;
            this.demandeChambre.Text = "Chambre :";
            // 
            // demandeSortie1
            // 
            this.demandeSortie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeSortie1.Location = new System.Drawing.Point(309, 546);
            this.demandeSortie1.Name = "demandeSortie1";
            this.demandeSortie1.Size = new System.Drawing.Size(427, 29);
            this.demandeSortie1.TabIndex = 9;
            // 
            // demandeContacts1
            // 
            this.demandeContacts1.BackColor = System.Drawing.Color.White;
            this.demandeContacts1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.demandeContacts1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeContacts1.Location = new System.Drawing.Point(309, 95);
            this.demandeContacts1.Name = "demandeContacts1";
            this.demandeContacts1.Size = new System.Drawing.Size(427, 29);
            this.demandeContacts1.TabIndex = 2;
            // 
            // demandeAdresse
            // 
            this.demandeAdresse.AutoSize = true;
            this.demandeAdresse.BackColor = System.Drawing.Color.Transparent;
            this.demandeAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeAdresse.ForeColor = System.Drawing.Color.Blue;
            this.demandeAdresse.Location = new System.Drawing.Point(106, 167);
            this.demandeAdresse.Name = "demandeAdresse";
            this.demandeAdresse.Size = new System.Drawing.Size(99, 24);
            this.demandeAdresse.TabIndex = 82;
            this.demandeAdresse.Text = "Adresse :";
            // 
            // demandePrenoms
            // 
            this.demandePrenoms.AutoSize = true;
            this.demandePrenoms.BackColor = System.Drawing.Color.Transparent;
            this.demandePrenoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandePrenoms.ForeColor = System.Drawing.Color.Blue;
            this.demandePrenoms.Location = new System.Drawing.Point(106, 62);
            this.demandePrenoms.Name = "demandePrenoms";
            this.demandePrenoms.Size = new System.Drawing.Size(105, 24);
            this.demandePrenoms.TabIndex = 100;
            this.demandePrenoms.Text = "Prénoms :";
            // 
            // demandeNoms1
            // 
            this.demandeNoms1.BackColor = System.Drawing.Color.White;
            this.demandeNoms1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.demandeNoms1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeNoms1.Location = new System.Drawing.Point(309, 25);
            this.demandeNoms1.Name = "demandeNoms1";
            this.demandeNoms1.Size = new System.Drawing.Size(427, 29);
            this.demandeNoms1.TabIndex = 0;
            // 
            // demandeMail
            // 
            this.demandeMail.AutoSize = true;
            this.demandeMail.BackColor = System.Drawing.Color.Transparent;
            this.demandeMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeMail.ForeColor = System.Drawing.Color.Blue;
            this.demandeMail.Location = new System.Drawing.Point(106, 132);
            this.demandeMail.Name = "demandeMail";
            this.demandeMail.Size = new System.Drawing.Size(81, 24);
            this.demandeMail.TabIndex = 81;
            this.demandeMail.Text = "E-mail :";
            // 
            // demandePrenoms1
            // 
            this.demandePrenoms1.BackColor = System.Drawing.Color.White;
            this.demandePrenoms1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.demandePrenoms1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandePrenoms1.Location = new System.Drawing.Point(309, 60);
            this.demandePrenoms1.Name = "demandePrenoms1";
            this.demandePrenoms1.Size = new System.Drawing.Size(427, 29);
            this.demandePrenoms1.TabIndex = 1;
            // 
            // demandeBonus
            // 
            this.demandeBonus.AutoSize = true;
            this.demandeBonus.BackColor = System.Drawing.Color.Transparent;
            this.demandeBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeBonus.ForeColor = System.Drawing.Color.Blue;
            this.demandeBonus.Location = new System.Drawing.Point(106, 476);
            this.demandeBonus.Name = "demandeBonus";
            this.demandeBonus.Size = new System.Drawing.Size(81, 24);
            this.demandeBonus.TabIndex = 87;
            this.demandeBonus.Text = "Bonus :";
            // 
            // demandeContacts
            // 
            this.demandeContacts.AutoSize = true;
            this.demandeContacts.BackColor = System.Drawing.Color.Transparent;
            this.demandeContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeContacts.ForeColor = System.Drawing.Color.Blue;
            this.demandeContacts.Location = new System.Drawing.Point(106, 97);
            this.demandeContacts.Name = "demandeContacts";
            this.demandeContacts.Size = new System.Drawing.Size(102, 24);
            this.demandeContacts.TabIndex = 80;
            this.demandeContacts.Text = "Contacts :";
            // 
            // demandeChambre1
            // 
            this.demandeChambre1.BackColor = System.Drawing.Color.White;
            this.demandeChambre1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.demandeChambre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeChambre1.Location = new System.Drawing.Point(309, 200);
            this.demandeChambre1.Name = "demandeChambre1";
            this.demandeChambre1.Size = new System.Drawing.Size(427, 29);
            this.demandeChambre1.TabIndex = 5;
            // 
            // demandeNoms
            // 
            this.demandeNoms.AutoSize = true;
            this.demandeNoms.BackColor = System.Drawing.Color.Transparent;
            this.demandeNoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demandeNoms.ForeColor = System.Drawing.Color.Blue;
            this.demandeNoms.Location = new System.Drawing.Point(106, 27);
            this.demandeNoms.Name = "demandeNoms";
            this.demandeNoms.Size = new System.Drawing.Size(76, 24);
            this.demandeNoms.TabIndex = 79;
            this.demandeNoms.Text = "Noms :";
            // 
            // paiementsTableAdapter
            // 
            this.paiementsTableAdapter.ClearBeforeFill = true;
            // 
            // banqueTableAdapter
            // 
            this.banqueTableAdapter.ClearBeforeFill = true;
            // 
            // Demande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 687);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Demande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demande";
            this.Load += new System.EventHandler(this.Demande_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paiementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPaiements)).EndInit();
            this.demandeBancaire.ResumeLayout(false);
            this.demandeBancaire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.banqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDBanque)).EndInit();
            this.demandeMobile.ResumeLayout(false);
            this.demandeMobile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.Label demandeMontant;
        private System.Windows.Forms.ComboBox demandeBonus1;
        private System.Windows.Forms.ComboBox demandeMode1;
        private System.Windows.Forms.GroupBox demandeBancaire;
        private System.Windows.Forms.ComboBox banqueNom1;
        private System.Windows.Forms.MaskedTextBox banqueCarte1;
        private System.Windows.Forms.Label banqueCarte;
        private System.Windows.Forms.Label banqueNom;
        private System.Windows.Forms.Button demandeVAlider;
        private System.Windows.Forms.MaskedTextBox demandeMontant1;
        private System.Windows.Forms.GroupBox demandeMobile;
        private System.Windows.Forms.MaskedTextBox mobileContact1;
        private System.Windows.Forms.Label mobileContact;
        private System.Windows.Forms.Button demandeAnnuler;
        private System.Windows.Forms.MaskedTextBox demandeAdresse1;
        private System.Windows.Forms.Label demandeMode;
        private System.Windows.Forms.Label demandeSortie;
        private System.Windows.Forms.MaskedTextBox demandeMail1;
        private System.Windows.Forms.Label demandeChambre;
        private System.Windows.Forms.DateTimePicker demandeSortie1;
        private System.Windows.Forms.MaskedTextBox demandeContacts1;
        private System.Windows.Forms.Label demandeAdresse;
        private System.Windows.Forms.Label demandePrenoms;
        private System.Windows.Forms.MaskedTextBox demandeNoms1;
        private System.Windows.Forms.Label demandeMail;
        private System.Windows.Forms.MaskedTextBox demandePrenoms1;
        private System.Windows.Forms.Label demandeBonus;
        private System.Windows.Forms.Label demandeContacts;
        private System.Windows.Forms.MaskedTextBox demandeChambre1;
        private System.Windows.Forms.Label demandeNoms;
        private System.Windows.Forms.Label titre;
        private BDPaiements bDPaiements;
        private System.Windows.Forms.BindingSource paiementsBindingSource;
        private BDPaiementsTableAdapters.PaiementsTableAdapter paiementsTableAdapter;
        private BDBanque bDBanque;
        private System.Windows.Forms.BindingSource banqueBindingSource;
        private BDBanqueTableAdapters.BanqueTableAdapter banqueTableAdapter;
    }
}