namespace BE_Informatique
{
    partial class Archives
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Archives));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hotelor = new System.Windows.Forms.Label();
            this.fermer = new System.Windows.Forms.Button();
            this.reduire = new System.Windows.Forms.Button();
            this.titre = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.archive = new System.Windows.Forms.GroupBox();
            this.archivesArticles1 = new System.Windows.Forms.DataGridView();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.archivesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDArchives = new BE_Informatique.BDArchives();
            this.archivesRechercher = new System.Windows.Forms.Button();
            this.archives1 = new System.Windows.Forms.TextBox();
            this.archivesArticles = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.r = new System.Windows.Forms.Label();
            this.o1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.archivesAnnuler = new System.Windows.Forms.Button();
            this.archivesEnvoyer = new System.Windows.Forms.Button();
            this.archivesTableAdapter = new BE_Informatique.BDArchivesTableAdapters.ArchivesTableAdapter();
            this.nArchiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.archive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archivesArticles1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDArchives)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            // fermer
            // 
            this.fermer.FlatAppearance.BorderSize = 0;
            this.fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.Image = ((System.Drawing.Image)(resources.GetObject("fermer.Image")));
            this.fermer.Location = new System.Drawing.Point(493, 3);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(31, 23);
            this.fermer.TabIndex = 13;
            this.fermer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fermer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // reduire
            // 
            this.reduire.FlatAppearance.BorderSize = 0;
            this.reduire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduire.Image = ((System.Drawing.Image)(resources.GetObject("reduire.Image")));
            this.reduire.Location = new System.Drawing.Point(471, 3);
            this.reduire.Name = "reduire";
            this.reduire.Size = new System.Drawing.Size(25, 25);
            this.reduire.TabIndex = 14;
            this.reduire.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reduire.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reduire.UseVisualStyleBackColor = true;
            this.reduire.Click += new System.EventHandler(this.reduire_Click);
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(234, 2);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(106, 33);
            this.titre.TabIndex = 84;
            this.titre.Text = "Archives";
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
            this.panel1.Size = new System.Drawing.Size(528, 38);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 433);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.archive);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.archivesAnnuler);
            this.panel3.Controls.Add(this.archivesEnvoyer);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 433);
            this.panel3.TabIndex = 8;
            // 
            // archive
            // 
            this.archive.BackColor = System.Drawing.Color.Transparent;
            this.archive.Controls.Add(this.archivesArticles1);
            this.archive.Controls.Add(this.archivesRechercher);
            this.archive.Controls.Add(this.archives1);
            this.archive.Controls.Add(this.archivesArticles);
            this.archive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archive.ForeColor = System.Drawing.Color.Red;
            this.archive.Location = new System.Drawing.Point(85, 20);
            this.archive.Name = "archive";
            this.archive.Size = new System.Drawing.Size(414, 348);
            this.archive.TabIndex = 89;
            this.archive.TabStop = false;
            this.archive.Text = "Archives";
            // 
            // archivesArticles1
            // 
            this.archivesArticles1.AllowUserToAddRows = false;
            this.archivesArticles1.AllowUserToDeleteRows = false;
            this.archivesArticles1.AllowUserToOrderColumns = true;
            this.archivesArticles1.AutoGenerateColumns = false;
            this.archivesArticles1.BackgroundColor = System.Drawing.Color.White;
            this.archivesArticles1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.archivesArticles1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.archivesArticles1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numero,
            this.article,
            this.client,
            this.nArchiveDataGridViewTextBoxColumn,
            this.articleDataGridViewTextBoxColumn,
            this.nClientDataGridViewTextBoxColumn});
            this.archivesArticles1.DataSource = this.archivesBindingSource;
            this.archivesArticles1.GridColor = System.Drawing.Color.White;
            this.archivesArticles1.Location = new System.Drawing.Point(17, 111);
            this.archivesArticles1.Name = "archivesArticles1";
            this.archivesArticles1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.archivesArticles1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.archivesArticles1.Size = new System.Drawing.Size(377, 231);
            this.archivesArticles1.TabIndex = 89;
            // 
            // numero
            // 
            this.numero.DataPropertyName = "N°_Archive";
            this.numero.HeaderText = "N°";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // article
            // 
            this.article.DataPropertyName = "Article";
            this.article.HeaderText = "Article";
            this.article.Name = "article";
            this.article.ReadOnly = true;
            // 
            // client
            // 
            this.client.DataPropertyName = "N°_Client";
            this.client.HeaderText = "Noms";
            this.client.Name = "client";
            this.client.ReadOnly = true;
            // 
            // archivesBindingSource
            // 
            this.archivesBindingSource.DataMember = "Archives";
            this.archivesBindingSource.DataSource = this.bDArchives;
            // 
            // bDArchives
            // 
            this.bDArchives.DataSetName = "BDArchives";
            this.bDArchives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // archivesRechercher
            // 
            this.archivesRechercher.BackColor = System.Drawing.Color.Yellow;
            this.archivesRechercher.FlatAppearance.BorderSize = 0;
            this.archivesRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archivesRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivesRechercher.Location = new System.Drawing.Point(240, 26);
            this.archivesRechercher.Name = "archivesRechercher";
            this.archivesRechercher.Size = new System.Drawing.Size(154, 41);
            this.archivesRechercher.TabIndex = 36;
            this.archivesRechercher.Text = "Rechercher";
            this.archivesRechercher.UseVisualStyleBackColor = false;
            // 
            // archives1
            // 
            this.archives1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archives1.Location = new System.Drawing.Point(32, 34);
            this.archives1.Name = "archives1";
            this.archives1.Size = new System.Drawing.Size(202, 26);
            this.archives1.TabIndex = 35;
            this.archives1.Text = "Rechercher une demande.";
            // 
            // archivesArticles
            // 
            this.archivesArticles.AutoSize = true;
            this.archivesArticles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivesArticles.ForeColor = System.Drawing.Color.Red;
            this.archivesArticles.Location = new System.Drawing.Point(28, 85);
            this.archivesArticles.Name = "archivesArticles";
            this.archivesArticles.Size = new System.Drawing.Size(69, 20);
            this.archivesArticles.TabIndex = 31;
            this.archivesArticles.Text = "Articles";
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
            this.panel4.Size = new System.Drawing.Size(65, 432);
            this.panel4.TabIndex = 83;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(11, 360);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(40, 57);
            this.r.TabIndex = 8;
            this.r.Text = "r";
            // 
            // o1
            // 
            this.o1.AutoSize = true;
            this.o1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o1.Location = new System.Drawing.Point(9, 303);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(45, 57);
            this.o1.TabIndex = 6;
            this.o1.Text = "o";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(12, 246);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(38, 57);
            this.l.TabIndex = 5;
            this.l.Text = "l";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(10, 189);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(42, 57);
            this.e.TabIndex = 4;
            this.e.Text = "e";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(11, 132);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(41, 57);
            this.t.TabIndex = 3;
            this.t.Text = "t";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.Location = new System.Drawing.Point(9, 75);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(45, 57);
            this.o.TabIndex = 2;
            this.o.Text = "o";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(4, 18);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(59, 57);
            this.h.TabIndex = 1;
            this.h.Text = "H";
            // 
            // archivesAnnuler
            // 
            this.archivesAnnuler.BackColor = System.Drawing.Color.Yellow;
            this.archivesAnnuler.FlatAppearance.BorderSize = 0;
            this.archivesAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archivesAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivesAnnuler.ForeColor = System.Drawing.Color.Red;
            this.archivesAnnuler.Location = new System.Drawing.Point(391, 374);
            this.archivesAnnuler.Name = "archivesAnnuler";
            this.archivesAnnuler.Size = new System.Drawing.Size(108, 41);
            this.archivesAnnuler.TabIndex = 34;
            this.archivesAnnuler.Text = "Retour";
            this.archivesAnnuler.UseVisualStyleBackColor = false;
            this.archivesAnnuler.Click += new System.EventHandler(this.archivesAnnuler_Click);
            // 
            // archivesEnvoyer
            // 
            this.archivesEnvoyer.BackColor = System.Drawing.Color.Yellow;
            this.archivesEnvoyer.FlatAppearance.BorderSize = 0;
            this.archivesEnvoyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archivesEnvoyer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archivesEnvoyer.ForeColor = System.Drawing.Color.Red;
            this.archivesEnvoyer.Location = new System.Drawing.Point(280, 374);
            this.archivesEnvoyer.Name = "archivesEnvoyer";
            this.archivesEnvoyer.Size = new System.Drawing.Size(105, 41);
            this.archivesEnvoyer.TabIndex = 32;
            this.archivesEnvoyer.Text = "Envoyer";
            this.archivesEnvoyer.UseVisualStyleBackColor = false;
            this.archivesEnvoyer.Click += new System.EventHandler(this.archivesEnvoyer_Click);
            // 
            // archivesTableAdapter
            // 
            this.archivesTableAdapter.ClearBeforeFill = true;
            // 
            // nArchiveDataGridViewTextBoxColumn
            // 
            this.nArchiveDataGridViewTextBoxColumn.DataPropertyName = "N°_Archive";
            this.nArchiveDataGridViewTextBoxColumn.HeaderText = "N°_Archive";
            this.nArchiveDataGridViewTextBoxColumn.Name = "nArchiveDataGridViewTextBoxColumn";
            this.nArchiveDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // articleDataGridViewTextBoxColumn
            // 
            this.articleDataGridViewTextBoxColumn.DataPropertyName = "Article";
            this.articleDataGridViewTextBoxColumn.HeaderText = "Article";
            this.articleDataGridViewTextBoxColumn.Name = "articleDataGridViewTextBoxColumn";
            this.articleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nClientDataGridViewTextBoxColumn
            // 
            this.nClientDataGridViewTextBoxColumn.DataPropertyName = "N°_Client";
            this.nClientDataGridViewTextBoxColumn.HeaderText = "N°_Client";
            this.nClientDataGridViewTextBoxColumn.Name = "nClientDataGridViewTextBoxColumn";
            this.nClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Archives
            // 
            this.ClientSize = new System.Drawing.Size(528, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Archives";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Archives_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.archive.ResumeLayout(false);
            this.archive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archivesArticles1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.archivesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDArchives)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label hotelor;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Button reduire;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox archive;
        private System.Windows.Forms.DataGridView archivesArticles1;
        private System.Windows.Forms.Button archivesRechercher;
        private System.Windows.Forms.TextBox archives1;
        private System.Windows.Forms.Label archivesArticles;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label o1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label o;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Button archivesAnnuler;
        private System.Windows.Forms.Button archivesEnvoyer;
        private BDArchives bDArchives;
        private System.Windows.Forms.BindingSource archivesBindingSource;
        private BDArchivesTableAdapters.ArchivesTableAdapter archivesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn article;
        private System.Windows.Forms.DataGridViewTextBoxColumn client;
        private System.Windows.Forms.DataGridViewTextBoxColumn nArchiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nClientDataGridViewTextBoxColumn;

    }
}