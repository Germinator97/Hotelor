namespace BE_Informatique
{
    partial class Bienvenue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bienvenue));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.selection = new System.Windows.Forms.Panel();
            this.reduire = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.verouiller = new System.Windows.Forms.Button();
            this.configuration = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.hotelor = new System.Windows.Forms.Label();
            this.conteneur = new System.Windows.Forms.Panel();
            this.menuHotel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.r = new System.Windows.Forms.Label();
            this.o1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.menuChambres1 = new System.Windows.Forms.DataGridView();
            this.numeroChambres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuDisponibilite = new System.Windows.Forms.Label();
            this.menuRechercher = new System.Windows.Forms.Button();
            this.menu1 = new System.Windows.Forms.TextBox();
            this.menuSorties = new System.Windows.Forms.Button();
            this.menuArchives = new System.Windows.Forms.Button();
            this.menuServices1 = new System.Windows.Forms.DataGridView();
            this.serviceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDServices = new BE_Informatique.BDServices();
            this.menuClients1 = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDClients = new BE_Informatique.BDClients();
            this.menuPertes = new System.Windows.Forms.Button();
            this.menuServices2 = new System.Windows.Forms.Button();
            this.menuDemandes = new System.Windows.Forms.Button();
            this.menuChambres = new System.Windows.Forms.Label();
            this.menuServices = new System.Windows.Forms.Label();
            this.menuClients = new System.Windows.Forms.Label();
            this.clientsTableAdapter = new BE_Informatique.BDClientsTableAdapters.ClientsTableAdapter();
            this.servicesTableAdapter = new BE_Informatique.BDServicesTableAdapters.ServicesTableAdapter();
            this.panel1.SuspendLayout();
            this.conteneur.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuChambres1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuServices1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuClients1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDClients)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.selection);
            this.panel1.Controls.Add(this.reduire);
            this.panel1.Controls.Add(this.fermer);
            this.panel1.Controls.Add(this.verouiller);
            this.panel1.Controls.Add(this.configuration);
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.hotelor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 56);
            this.panel1.TabIndex = 0;
            // 
            // selection
            // 
            this.selection.BackColor = System.Drawing.Color.Red;
            this.selection.Location = new System.Drawing.Point(297, 48);
            this.selection.Name = "selection";
            this.selection.Size = new System.Drawing.Size(60, 5);
            this.selection.TabIndex = 15;
            // 
            // reduire
            // 
            this.reduire.FlatAppearance.BorderSize = 0;
            this.reduire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduire.Image = ((System.Drawing.Image)(resources.GetObject("reduire.Image")));
            this.reduire.Location = new System.Drawing.Point(788, 3);
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
            this.fermer.Location = new System.Drawing.Point(810, 3);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(31, 23);
            this.fermer.TabIndex = 13;
            this.fermer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fermer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // verouiller
            // 
            this.verouiller.FlatAppearance.BorderSize = 0;
            this.verouiller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verouiller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verouiller.Image = ((System.Drawing.Image)(resources.GetObject("verouiller.Image")));
            this.verouiller.Location = new System.Drawing.Point(363, 13);
            this.verouiller.Name = "verouiller";
            this.verouiller.Size = new System.Drawing.Size(83, 40);
            this.verouiller.TabIndex = 12;
            this.verouiller.Text = "Verouiller";
            this.verouiller.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.verouiller.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.verouiller.UseVisualStyleBackColor = true;
            this.verouiller.Click += new System.EventHandler(this.verouiller_Click);
            // 
            // configuration
            // 
            this.configuration.FlatAppearance.BorderSize = 0;
            this.configuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.configuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuration.Image = ((System.Drawing.Image)(resources.GetObject("configuration.Image")));
            this.configuration.Location = new System.Drawing.Point(452, 13);
            this.configuration.Name = "configuration";
            this.configuration.Size = new System.Drawing.Size(109, 40);
            this.configuration.TabIndex = 11;
            this.configuration.Text = "Configuration";
            this.configuration.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.configuration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.configuration.UseVisualStyleBackColor = true;
            this.configuration.Click += new System.EventHandler(this.configuration_Click);
            // 
            // home
            // 
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Image = ((System.Drawing.Image)(resources.GetObject("home.Image")));
            this.home.Location = new System.Drawing.Point(296, 13);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(61, 40);
            this.home.TabIndex = 9;
            this.home.Text = "Home";
            this.home.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
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
            // conteneur
            // 
            this.conteneur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.conteneur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.conteneur.Controls.Add(this.menuHotel);
            this.conteneur.Controls.Add(this.panel2);
            this.conteneur.Controls.Add(this.menuChambres1);
            this.conteneur.Controls.Add(this.menuDisponibilite);
            this.conteneur.Controls.Add(this.menuRechercher);
            this.conteneur.Controls.Add(this.menu1);
            this.conteneur.Controls.Add(this.menuSorties);
            this.conteneur.Controls.Add(this.menuArchives);
            this.conteneur.Controls.Add(this.menuServices1);
            this.conteneur.Controls.Add(this.menuClients1);
            this.conteneur.Controls.Add(this.menuPertes);
            this.conteneur.Controls.Add(this.menuServices2);
            this.conteneur.Controls.Add(this.menuDemandes);
            this.conteneur.Controls.Add(this.menuChambres);
            this.conteneur.Controls.Add(this.menuServices);
            this.conteneur.Controls.Add(this.menuClients);
            this.conteneur.Dock = System.Windows.Forms.DockStyle.Fill;
            this.conteneur.Location = new System.Drawing.Point(0, 56);
            this.conteneur.Name = "conteneur";
            this.conteneur.Size = new System.Drawing.Size(844, 539);
            this.conteneur.TabIndex = 1;
            // 
            // menuHotel
            // 
            this.menuHotel.BackColor = System.Drawing.Color.Yellow;
            this.menuHotel.FlatAppearance.BorderSize = 0;
            this.menuHotel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuHotel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuHotel.Image = ((System.Drawing.Image)(resources.GetObject("menuHotel.Image")));
            this.menuHotel.Location = new System.Drawing.Point(712, 457);
            this.menuHotel.Name = "menuHotel";
            this.menuHotel.Size = new System.Drawing.Size(87, 67);
            this.menuHotel.TabIndex = 97;
            this.menuHotel.Text = "Hotel";
            this.menuHotel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.menuHotel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuHotel.UseVisualStyleBackColor = false;
            this.menuHotel.Click += new System.EventHandler(this.menuHotel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.r);
            this.panel2.Controls.Add(this.o1);
            this.panel2.Controls.Add(this.l);
            this.panel2.Controls.Add(this.e);
            this.panel2.Controls.Add(this.t);
            this.panel2.Controls.Add(this.o);
            this.panel2.Controls.Add(this.h);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(71, 535);
            this.panel2.TabIndex = 96;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(12, 403);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(40, 57);
            this.r.TabIndex = 8;
            this.r.Text = "r";
            // 
            // o1
            // 
            this.o1.AutoSize = true;
            this.o1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o1.Location = new System.Drawing.Point(10, 346);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(45, 57);
            this.o1.TabIndex = 6;
            this.o1.Text = "o";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(13, 289);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(38, 57);
            this.l.TabIndex = 5;
            this.l.Text = "l";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(11, 232);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(42, 57);
            this.e.TabIndex = 4;
            this.e.Text = "e";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(12, 175);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(41, 57);
            this.t.TabIndex = 3;
            this.t.Text = "t";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.Location = new System.Drawing.Point(10, 118);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(45, 57);
            this.o.TabIndex = 2;
            this.o.Text = "o";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(3, 61);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(59, 57);
            this.h.TabIndex = 1;
            this.h.Text = "H";
            // 
            // menuChambres1
            // 
            this.menuChambres1.AllowUserToAddRows = false;
            this.menuChambres1.AllowUserToDeleteRows = false;
            this.menuChambres1.AllowUserToOrderColumns = true;
            this.menuChambres1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuChambres1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.menuChambres1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuChambres1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroChambres});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuChambres1.DefaultCellStyle = dataGridViewCellStyle2;
            this.menuChambres1.Location = new System.Drawing.Point(486, 305);
            this.menuChambres1.Name = "menuChambres1";
            this.menuChambres1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuChambres1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.menuChambres1.Size = new System.Drawing.Size(186, 189);
            this.menuChambres1.TabIndex = 94;
            // 
            // numeroChambres
            // 
            this.numeroChambres.HeaderText = "N°";
            this.numeroChambres.Name = "numeroChambres";
            this.numeroChambres.ReadOnly = true;
            // 
            // menuDisponibilite
            // 
            this.menuDisponibilite.AutoSize = true;
            this.menuDisponibilite.BackColor = System.Drawing.Color.Transparent;
            this.menuDisponibilite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDisponibilite.ForeColor = System.Drawing.Color.Black;
            this.menuDisponibilite.Location = new System.Drawing.Point(88, 470);
            this.menuDisponibilite.Name = "menuDisponibilite";
            this.menuDisponibilite.Size = new System.Drawing.Size(371, 24);
            this.menuDisponibilite.TabIndex = 91;
            this.menuDisponibilite.Text = "Vous disposez de ? chambres disponibles.";
            // 
            // menuRechercher
            // 
            this.menuRechercher.BackColor = System.Drawing.Color.Yellow;
            this.menuRechercher.FlatAppearance.BorderSize = 0;
            this.menuRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuRechercher.ForeColor = System.Drawing.Color.Red;
            this.menuRechercher.Location = new System.Drawing.Point(668, 4);
            this.menuRechercher.Name = "menuRechercher";
            this.menuRechercher.Size = new System.Drawing.Size(131, 49);
            this.menuRechercher.TabIndex = 90;
            this.menuRechercher.Text = "Rechercher";
            this.menuRechercher.UseVisualStyleBackColor = false;
            // 
            // menu1
            // 
            this.menu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu1.Location = new System.Drawing.Point(107, 16);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(542, 26);
            this.menu1.TabIndex = 89;
            this.menu1.Text = "Rechercher un client, un service ou une chambre.";
            // 
            // menuSorties
            // 
            this.menuSorties.BackColor = System.Drawing.Color.Yellow;
            this.menuSorties.FlatAppearance.BorderSize = 0;
            this.menuSorties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuSorties.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuSorties.ForeColor = System.Drawing.Color.Red;
            this.menuSorties.Location = new System.Drawing.Point(699, 364);
            this.menuSorties.Name = "menuSorties";
            this.menuSorties.Size = new System.Drawing.Size(126, 49);
            this.menuSorties.TabIndex = 88;
            this.menuSorties.Text = "Sorties";
            this.menuSorties.UseVisualStyleBackColor = false;
            this.menuSorties.Click += new System.EventHandler(this.menuSorties_Click);
            // 
            // menuArchives
            // 
            this.menuArchives.BackColor = System.Drawing.Color.Yellow;
            this.menuArchives.FlatAppearance.BorderSize = 0;
            this.menuArchives.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuArchives.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuArchives.ForeColor = System.Drawing.Color.Red;
            this.menuArchives.Location = new System.Drawing.Point(699, 309);
            this.menuArchives.Name = "menuArchives";
            this.menuArchives.Size = new System.Drawing.Size(126, 49);
            this.menuArchives.TabIndex = 87;
            this.menuArchives.Text = "Archives";
            this.menuArchives.UseVisualStyleBackColor = false;
            this.menuArchives.Click += new System.EventHandler(this.menuArchives_Click);
            // 
            // menuServices1
            // 
            this.menuServices1.AllowUserToAddRows = false;
            this.menuServices1.AllowUserToDeleteRows = false;
            this.menuServices1.AllowUserToOrderColumns = true;
            this.menuServices1.AutoGenerateColumns = false;
            this.menuServices1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuServices1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.menuServices1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuServices1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serviceDataGridViewTextBoxColumn});
            this.menuServices1.DataSource = this.servicesBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuServices1.DefaultCellStyle = dataGridViewCellStyle5;
            this.menuServices1.Location = new System.Drawing.Point(486, 77);
            this.menuServices1.Name = "menuServices1";
            this.menuServices1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuServices1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.menuServices1.Size = new System.Drawing.Size(186, 191);
            this.menuServices1.TabIndex = 93;
            // 
            // serviceDataGridViewTextBoxColumn
            // 
            this.serviceDataGridViewTextBoxColumn.DataPropertyName = "Service";
            this.serviceDataGridViewTextBoxColumn.HeaderText = "Service";
            this.serviceDataGridViewTextBoxColumn.Name = "serviceDataGridViewTextBoxColumn";
            this.serviceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.bDServices;
            // 
            // bDServices
            // 
            this.bDServices.DataSetName = "BDServices";
            this.bDServices.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuClients1
            // 
            this.menuClients1.AllowUserToAddRows = false;
            this.menuClients1.AllowUserToDeleteRows = false;
            this.menuClients1.AllowUserToOrderColumns = true;
            this.menuClients1.AutoGenerateColumns = false;
            this.menuClients1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuClients1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.menuClients1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuClients1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.nomsDataGridViewTextBoxColumn,
            this.prenomsDataGridViewTextBoxColumn});
            this.menuClients1.DataSource = this.clientsBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.menuClients1.DefaultCellStyle = dataGridViewCellStyle8;
            this.menuClients1.Location = new System.Drawing.Point(92, 77);
            this.menuClients1.Name = "menuClients1";
            this.menuClients1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.menuClients1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.menuClients1.Size = new System.Drawing.Size(376, 364);
            this.menuClients1.TabIndex = 92;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "N°_Client";
            this.numero.HeaderText = "N°";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // nomsDataGridViewTextBoxColumn
            // 
            this.nomsDataGridViewTextBoxColumn.DataPropertyName = "Noms";
            this.nomsDataGridViewTextBoxColumn.HeaderText = "Noms";
            this.nomsDataGridViewTextBoxColumn.Name = "nomsDataGridViewTextBoxColumn";
            this.nomsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomsDataGridViewTextBoxColumn
            // 
            this.prenomsDataGridViewTextBoxColumn.DataPropertyName = "Prenoms";
            this.prenomsDataGridViewTextBoxColumn.HeaderText = "Prenoms";
            this.prenomsDataGridViewTextBoxColumn.Name = "prenomsDataGridViewTextBoxColumn";
            this.prenomsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.bDClients;
            // 
            // bDClients
            // 
            this.bDClients.DataSetName = "BDClients";
            this.bDClients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuPertes
            // 
            this.menuPertes.BackColor = System.Drawing.Color.Yellow;
            this.menuPertes.FlatAppearance.BorderSize = 0;
            this.menuPertes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuPertes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPertes.ForeColor = System.Drawing.Color.Red;
            this.menuPertes.Location = new System.Drawing.Point(699, 254);
            this.menuPertes.Name = "menuPertes";
            this.menuPertes.Size = new System.Drawing.Size(126, 49);
            this.menuPertes.TabIndex = 86;
            this.menuPertes.Text = "Pertes";
            this.menuPertes.UseVisualStyleBackColor = false;
            this.menuPertes.Click += new System.EventHandler(this.menuPertes_Click);
            // 
            // menuServices2
            // 
            this.menuServices2.BackColor = System.Drawing.Color.Yellow;
            this.menuServices2.FlatAppearance.BorderSize = 0;
            this.menuServices2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuServices2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuServices2.ForeColor = System.Drawing.Color.Red;
            this.menuServices2.Location = new System.Drawing.Point(699, 199);
            this.menuServices2.Name = "menuServices2";
            this.menuServices2.Size = new System.Drawing.Size(126, 49);
            this.menuServices2.TabIndex = 85;
            this.menuServices2.Text = "Services";
            this.menuServices2.UseVisualStyleBackColor = false;
            this.menuServices2.Click += new System.EventHandler(this.menuServices2_Click);
            // 
            // menuDemandes
            // 
            this.menuDemandes.BackColor = System.Drawing.Color.Yellow;
            this.menuDemandes.FlatAppearance.BorderSize = 0;
            this.menuDemandes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuDemandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuDemandes.ForeColor = System.Drawing.Color.Red;
            this.menuDemandes.Location = new System.Drawing.Point(699, 144);
            this.menuDemandes.Name = "menuDemandes";
            this.menuDemandes.Size = new System.Drawing.Size(126, 49);
            this.menuDemandes.TabIndex = 84;
            this.menuDemandes.Text = "Demandes";
            this.menuDemandes.UseVisualStyleBackColor = false;
            this.menuDemandes.Click += new System.EventHandler(this.menuDemandes_Click);
            // 
            // menuChambres
            // 
            this.menuChambres.AutoSize = true;
            this.menuChambres.BackColor = System.Drawing.Color.Transparent;
            this.menuChambres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuChambres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuChambres.ForeColor = System.Drawing.Color.Red;
            this.menuChambres.Location = new System.Drawing.Point(493, 278);
            this.menuChambres.Name = "menuChambres";
            this.menuChambres.Size = new System.Drawing.Size(105, 24);
            this.menuChambres.TabIndex = 82;
            this.menuChambres.Text = "Chambres";
            // 
            // menuServices
            // 
            this.menuServices.AutoSize = true;
            this.menuServices.BackColor = System.Drawing.Color.Transparent;
            this.menuServices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuServices.ForeColor = System.Drawing.Color.Red;
            this.menuServices.Location = new System.Drawing.Point(493, 50);
            this.menuServices.Name = "menuServices";
            this.menuServices.Size = new System.Drawing.Size(90, 24);
            this.menuServices.TabIndex = 81;
            this.menuServices.Text = "Services";
            // 
            // menuClients
            // 
            this.menuClients.AutoSize = true;
            this.menuClients.BackColor = System.Drawing.Color.Transparent;
            this.menuClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClients.ForeColor = System.Drawing.Color.Red;
            this.menuClients.Location = new System.Drawing.Point(103, 50);
            this.menuClients.Name = "menuClients";
            this.menuClients.Size = new System.Drawing.Size(144, 24);
            this.menuClients.TabIndex = 80;
            this.menuClients.Text = "Clients inscrits";
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // Bienvenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 595);
            this.Controls.Add(this.conteneur);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bienvenue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Bienvenue_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.conteneur.ResumeLayout(false);
            this.conteneur.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuChambres1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuServices1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuClients1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label hotelor;
        private System.Windows.Forms.Button reduire;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button verouiller;
        private System.Windows.Forms.Button configuration;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Panel selection;
        private System.Windows.Forms.Panel conteneur;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label o1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label o;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.DataGridView menuChambres1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroChambres;
        private System.Windows.Forms.Label menuDisponibilite;
        private System.Windows.Forms.Button menuRechercher;
        private System.Windows.Forms.Button menuSorties;
        private System.Windows.Forms.Button menuArchives;
        private System.Windows.Forms.DataGridView menuServices1;
        private System.Windows.Forms.DataGridView menuClients1;
        private System.Windows.Forms.Button menuPertes;
        private System.Windows.Forms.Button menuServices2;
        private System.Windows.Forms.Button menuDemandes;
        private System.Windows.Forms.Label menuChambres;
        private System.Windows.Forms.Label menuServices;
        private System.Windows.Forms.Label menuClients;
        private BDClients bDClients;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private BDClientsTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomsDataGridViewTextBoxColumn;
        private BDServices bDServices;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private BDServicesTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button menuHotel;
        private System.Windows.Forms.TextBox menu1;
    }
}