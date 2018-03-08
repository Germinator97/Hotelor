namespace BE_Informatique
{
    partial class Sorties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorties));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.titre = new System.Windows.Forms.Label();
            this.reduire = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.hotelor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortiesDemandes1 = new System.Windows.Forms.DataGridView();
            this.numeroArticle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bDRecu = new BE_Informatique.BDRecu();
            this.sortiesRechercher = new System.Windows.Forms.Button();
            this.sorties1 = new System.Windows.Forms.TextBox();
            this.sortiesDemandes = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.r = new System.Windows.Forms.Label();
            this.o1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.sortiesAnnuler = new System.Windows.Forms.Button();
            this.sortiesProlonger = new System.Windows.Forms.Button();
            this.sortiesSortie = new System.Windows.Forms.Button();
            this.recuTableAdapter = new BE_Informatique.BDRecuTableAdapters.RecuTableAdapter();
            this.nRecuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateRecuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateSortieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paiementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortiesDemandes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.recuBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDRecu)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(527, 38);
            this.panel1.TabIndex = 6;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(234, 2);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(87, 33);
            this.titre.TabIndex = 84;
            this.titre.Text = "Sorties";
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
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.sortiesAnnuler);
            this.panel2.Controls.Add(this.sortiesProlonger);
            this.panel2.Controls.Add(this.sortiesSortie);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 432);
            this.panel2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.sortiesDemandes1);
            this.groupBox1.Controls.Add(this.sortiesRechercher);
            this.groupBox1.Controls.Add(this.sorties1);
            this.groupBox1.Controls.Add(this.sortiesDemandes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(85, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 348);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sorties";
            // 
            // sortiesDemandes1
            // 
            this.sortiesDemandes1.AllowUserToAddRows = false;
            this.sortiesDemandes1.AllowUserToDeleteRows = false;
            this.sortiesDemandes1.AllowUserToOrderColumns = true;
            this.sortiesDemandes1.AutoGenerateColumns = false;
            this.sortiesDemandes1.BackgroundColor = System.Drawing.Color.White;
            this.sortiesDemandes1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sortiesDemandes1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sortiesDemandes1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroArticle,
            this.date,
            this.noms,
            this.nRecuDataGridViewTextBoxColumn,
            this.dateRecuDataGridViewTextBoxColumn,
            this.bonusDataGridViewTextBoxColumn,
            this.montantDataGridViewTextBoxColumn,
            this.dateSortieDataGridViewTextBoxColumn,
            this.paiementDataGridViewTextBoxColumn,
            this.nClientDataGridViewTextBoxColumn});
            this.sortiesDemandes1.DataSource = this.recuBindingSource1;
            this.sortiesDemandes1.GridColor = System.Drawing.Color.White;
            this.sortiesDemandes1.Location = new System.Drawing.Point(17, 111);
            this.sortiesDemandes1.Name = "sortiesDemandes1";
            this.sortiesDemandes1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sortiesDemandes1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.sortiesDemandes1.Size = new System.Drawing.Size(377, 231);
            this.sortiesDemandes1.TabIndex = 89;
            // 
            // numeroArticle
            // 
            this.numeroArticle.DataPropertyName = "N°_Recu";
            this.numeroArticle.HeaderText = "N°";
            this.numeroArticle.Name = "numeroArticle";
            this.numeroArticle.ReadOnly = true;
            // 
            // date
            // 
            this.date.DataPropertyName = "Date_Recu";
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // noms
            // 
            this.noms.DataPropertyName = "N°_Client";
            this.noms.HeaderText = "Noms";
            this.noms.Name = "noms";
            this.noms.ReadOnly = true;
            // 
            // recuBindingSource1
            // 
            this.recuBindingSource1.DataMember = "Recu";
            this.recuBindingSource1.DataSource = this.bDRecu;
            // 
            // bDRecu
            // 
            this.bDRecu.DataSetName = "BDRecu";
            this.bDRecu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sortiesRechercher
            // 
            this.sortiesRechercher.BackColor = System.Drawing.Color.Yellow;
            this.sortiesRechercher.FlatAppearance.BorderSize = 0;
            this.sortiesRechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortiesRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortiesRechercher.Location = new System.Drawing.Point(240, 26);
            this.sortiesRechercher.Name = "sortiesRechercher";
            this.sortiesRechercher.Size = new System.Drawing.Size(154, 41);
            this.sortiesRechercher.TabIndex = 36;
            this.sortiesRechercher.Text = "Rechercher";
            this.sortiesRechercher.UseVisualStyleBackColor = false;
            // 
            // sorties1
            // 
            this.sorties1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorties1.Location = new System.Drawing.Point(32, 34);
            this.sorties1.Name = "sorties1";
            this.sorties1.Size = new System.Drawing.Size(202, 26);
            this.sorties1.TabIndex = 35;
            this.sorties1.Text = "Rechercher une demande.";
            // 
            // sortiesDemandes
            // 
            this.sortiesDemandes.AutoSize = true;
            this.sortiesDemandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortiesDemandes.ForeColor = System.Drawing.Color.Red;
            this.sortiesDemandes.Location = new System.Drawing.Point(28, 85);
            this.sortiesDemandes.Name = "sortiesDemandes";
            this.sortiesDemandes.Size = new System.Drawing.Size(95, 20);
            this.sortiesDemandes.TabIndex = 31;
            this.sortiesDemandes.Text = "Demandes";
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
            this.panel3.Size = new System.Drawing.Size(71, 432);
            this.panel3.TabIndex = 83;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(13, 358);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(40, 57);
            this.r.TabIndex = 8;
            this.r.Text = "r";
            // 
            // o1
            // 
            this.o1.AutoSize = true;
            this.o1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o1.Location = new System.Drawing.Point(11, 301);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(45, 57);
            this.o1.TabIndex = 6;
            this.o1.Text = "o";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(14, 244);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(38, 57);
            this.l.TabIndex = 5;
            this.l.Text = "l";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(12, 187);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(42, 57);
            this.e.TabIndex = 4;
            this.e.Text = "e";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(13, 130);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(41, 57);
            this.t.TabIndex = 3;
            this.t.Text = "t";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.Location = new System.Drawing.Point(11, 73);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(45, 57);
            this.o.TabIndex = 2;
            this.o.Text = "o";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(6, 16);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(59, 57);
            this.h.TabIndex = 1;
            this.h.Text = "H";
            // 
            // sortiesAnnuler
            // 
            this.sortiesAnnuler.BackColor = System.Drawing.Color.Yellow;
            this.sortiesAnnuler.FlatAppearance.BorderSize = 0;
            this.sortiesAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortiesAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortiesAnnuler.ForeColor = System.Drawing.Color.Red;
            this.sortiesAnnuler.Location = new System.Drawing.Point(391, 374);
            this.sortiesAnnuler.Name = "sortiesAnnuler";
            this.sortiesAnnuler.Size = new System.Drawing.Size(108, 41);
            this.sortiesAnnuler.TabIndex = 34;
            this.sortiesAnnuler.Text = "Retour";
            this.sortiesAnnuler.UseVisualStyleBackColor = false;
            this.sortiesAnnuler.Click += new System.EventHandler(this.sortiesAnnuler_Click);
            // 
            // sortiesProlonger
            // 
            this.sortiesProlonger.BackColor = System.Drawing.Color.Yellow;
            this.sortiesProlonger.FlatAppearance.BorderSize = 0;
            this.sortiesProlonger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortiesProlonger.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortiesProlonger.ForeColor = System.Drawing.Color.Red;
            this.sortiesProlonger.Location = new System.Drawing.Point(241, 374);
            this.sortiesProlonger.Name = "sortiesProlonger";
            this.sortiesProlonger.Size = new System.Drawing.Size(144, 41);
            this.sortiesProlonger.TabIndex = 33;
            this.sortiesProlonger.Text = "Prolonger";
            this.sortiesProlonger.UseVisualStyleBackColor = false;
            this.sortiesProlonger.Click += new System.EventHandler(this.sortiesProlonger_Click);
            // 
            // sortiesSortie
            // 
            this.sortiesSortie.BackColor = System.Drawing.Color.Yellow;
            this.sortiesSortie.FlatAppearance.BorderSize = 0;
            this.sortiesSortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortiesSortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortiesSortie.ForeColor = System.Drawing.Color.Red;
            this.sortiesSortie.Location = new System.Drawing.Point(130, 374);
            this.sortiesSortie.Name = "sortiesSortie";
            this.sortiesSortie.Size = new System.Drawing.Size(105, 41);
            this.sortiesSortie.TabIndex = 32;
            this.sortiesSortie.Text = "Sortie";
            this.sortiesSortie.UseVisualStyleBackColor = false;
            this.sortiesSortie.Click += new System.EventHandler(this.sortiesSortie_Click);
            // 
            // recuTableAdapter
            // 
            this.recuTableAdapter.ClearBeforeFill = true;
            // 
            // nRecuDataGridViewTextBoxColumn
            // 
            this.nRecuDataGridViewTextBoxColumn.DataPropertyName = "N°_Recu";
            this.nRecuDataGridViewTextBoxColumn.HeaderText = "N°_Recu";
            this.nRecuDataGridViewTextBoxColumn.Name = "nRecuDataGridViewTextBoxColumn";
            this.nRecuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateRecuDataGridViewTextBoxColumn
            // 
            this.dateRecuDataGridViewTextBoxColumn.DataPropertyName = "Date_Recu";
            this.dateRecuDataGridViewTextBoxColumn.HeaderText = "Date_Recu";
            this.dateRecuDataGridViewTextBoxColumn.Name = "dateRecuDataGridViewTextBoxColumn";
            this.dateRecuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bonusDataGridViewTextBoxColumn
            // 
            this.bonusDataGridViewTextBoxColumn.DataPropertyName = "Bonus";
            this.bonusDataGridViewTextBoxColumn.HeaderText = "Bonus";
            this.bonusDataGridViewTextBoxColumn.Name = "bonusDataGridViewTextBoxColumn";
            this.bonusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // montantDataGridViewTextBoxColumn
            // 
            this.montantDataGridViewTextBoxColumn.DataPropertyName = "Montant";
            this.montantDataGridViewTextBoxColumn.HeaderText = "Montant";
            this.montantDataGridViewTextBoxColumn.Name = "montantDataGridViewTextBoxColumn";
            this.montantDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateSortieDataGridViewTextBoxColumn
            // 
            this.dateSortieDataGridViewTextBoxColumn.DataPropertyName = "Date_Sortie";
            this.dateSortieDataGridViewTextBoxColumn.HeaderText = "Date_Sortie";
            this.dateSortieDataGridViewTextBoxColumn.Name = "dateSortieDataGridViewTextBoxColumn";
            this.dateSortieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // paiementDataGridViewTextBoxColumn
            // 
            this.paiementDataGridViewTextBoxColumn.DataPropertyName = "Paiement";
            this.paiementDataGridViewTextBoxColumn.HeaderText = "Paiement";
            this.paiementDataGridViewTextBoxColumn.Name = "paiementDataGridViewTextBoxColumn";
            this.paiementDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nClientDataGridViewTextBoxColumn
            // 
            this.nClientDataGridViewTextBoxColumn.DataPropertyName = "N°_Client";
            this.nClientDataGridViewTextBoxColumn.HeaderText = "N°_Client";
            this.nClientDataGridViewTextBoxColumn.Name = "nClientDataGridViewTextBoxColumn";
            this.nClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Sorties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 470);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sorties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorties";
            this.Load += new System.EventHandler(this.Sorties_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortiesDemandes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.recuBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDRecu)).EndInit();
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
        private System.Windows.Forms.Button sortiesRechercher;
        private System.Windows.Forms.TextBox sorties1;
        private System.Windows.Forms.Button sortiesAnnuler;
        private System.Windows.Forms.Button sortiesProlonger;
        private System.Windows.Forms.Button sortiesSortie;
        private System.Windows.Forms.Label sortiesDemandes;
        private System.Windows.Forms.DataGridView sortiesDemandes1;
        private BDRecu bDRecu;
        private System.Windows.Forms.BindingSource recuBindingSource1;
        private BDRecuTableAdapters.RecuTableAdapter recuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroArticle;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn noms;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRecuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateRecuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn montantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateSortieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paiementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nClientDataGridViewTextBoxColumn;


    }
}