namespace BE_Informatique
{
    partial class Services
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Services));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titre = new System.Windows.Forms.Label();
            this.reduire = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.hotelor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.servicesChambre1 = new System.Windows.Forms.MaskedTextBox();
            this.servicesServices1 = new System.Windows.Forms.ComboBox();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDService = new BE_Informatique.BDService();
            this.servicesNoms1 = new System.Windows.Forms.MaskedTextBox();
            this.servicesServices = new System.Windows.Forms.Label();
            this.servicesChambre = new System.Windows.Forms.Label();
            this.servicesNoms = new System.Windows.Forms.Label();
            this.servicesAnnuler = new System.Windows.Forms.Button();
            this.servicesValider = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.r = new System.Windows.Forms.Label();
            this.o1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.servicesTableAdapter = new BE_Informatique.BDServiceTableAdapters.ServicesTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDService)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(763, 37);
            this.panel1.TabIndex = 3;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(351, 3);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(98, 33);
            this.titre.TabIndex = 16;
            this.titre.Text = "Services";
            // 
            // reduire
            // 
            this.reduire.FlatAppearance.BorderSize = 0;
            this.reduire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduire.Image = ((System.Drawing.Image)(resources.GetObject("reduire.Image")));
            this.reduire.Location = new System.Drawing.Point(707, 3);
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
            this.fermer.Location = new System.Drawing.Point(729, 3);
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
            this.panel2.Controls.Add(this.servicesAnnuler);
            this.panel2.Controls.Add(this.servicesValider);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 326);
            this.panel2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.servicesChambre1);
            this.groupBox1.Controls.Add(this.servicesServices1);
            this.groupBox1.Controls.Add(this.servicesNoms1);
            this.groupBox1.Controls.Add(this.servicesServices);
            this.groupBox1.Controls.Add(this.servicesChambre);
            this.groupBox1.Controls.Add(this.servicesNoms);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(75, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 205);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Services";
            // 
            // servicesChambre1
            // 
            this.servicesChambre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesChambre1.Location = new System.Drawing.Point(215, 96);
            this.servicesChambre1.Name = "servicesChambre1";
            this.servicesChambre1.Size = new System.Drawing.Size(421, 29);
            this.servicesChambre1.TabIndex = 1;
            // 
            // servicesServices1
            // 
            this.servicesServices1.DataSource = this.servicesBindingSource;
            this.servicesServices1.DisplayMember = "Service";
            this.servicesServices1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.servicesServices1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesServices1.FormattingEnabled = true;
            this.servicesServices1.Location = new System.Drawing.Point(215, 144);
            this.servicesServices1.Name = "servicesServices1";
            this.servicesServices1.Size = new System.Drawing.Size(421, 32);
            this.servicesServices1.TabIndex = 2;
            this.servicesServices1.ValueMember = "Service";
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.bDService;
            // 
            // bDService
            // 
            this.bDService.DataSetName = "BDService";
            this.bDService.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesNoms1
            // 
            this.servicesNoms1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesNoms1.Location = new System.Drawing.Point(215, 45);
            this.servicesNoms1.Name = "servicesNoms1";
            this.servicesNoms1.Size = new System.Drawing.Size(421, 29);
            this.servicesNoms1.TabIndex = 0;
            // 
            // servicesServices
            // 
            this.servicesServices.AutoSize = true;
            this.servicesServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesServices.ForeColor = System.Drawing.Color.Blue;
            this.servicesServices.Location = new System.Drawing.Point(21, 147);
            this.servicesServices.Name = "servicesServices";
            this.servicesServices.Size = new System.Drawing.Size(92, 24);
            this.servicesServices.TabIndex = 19;
            this.servicesServices.Text = "Service :";
            // 
            // servicesChambre
            // 
            this.servicesChambre.AutoSize = true;
            this.servicesChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesChambre.ForeColor = System.Drawing.Color.Blue;
            this.servicesChambre.Location = new System.Drawing.Point(21, 101);
            this.servicesChambre.Name = "servicesChambre";
            this.servicesChambre.Size = new System.Drawing.Size(107, 24);
            this.servicesChambre.TabIndex = 18;
            this.servicesChambre.Text = "Chambre :";
            // 
            // servicesNoms
            // 
            this.servicesNoms.AutoSize = true;
            this.servicesNoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesNoms.ForeColor = System.Drawing.Color.Blue;
            this.servicesNoms.Location = new System.Drawing.Point(21, 48);
            this.servicesNoms.Name = "servicesNoms";
            this.servicesNoms.Size = new System.Drawing.Size(188, 24);
            this.servicesNoms.TabIndex = 17;
            this.servicesNoms.Text = "Noms et Prénoms :";
            // 
            // servicesAnnuler
            // 
            this.servicesAnnuler.BackColor = System.Drawing.Color.Yellow;
            this.servicesAnnuler.FlatAppearance.BorderSize = 0;
            this.servicesAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesAnnuler.ForeColor = System.Drawing.Color.Red;
            this.servicesAnnuler.Location = new System.Drawing.Point(609, 260);
            this.servicesAnnuler.Name = "servicesAnnuler";
            this.servicesAnnuler.Size = new System.Drawing.Size(102, 40);
            this.servicesAnnuler.TabIndex = 4;
            this.servicesAnnuler.Text = "Retour";
            this.servicesAnnuler.UseVisualStyleBackColor = false;
            this.servicesAnnuler.Click += new System.EventHandler(this.servicesAnnuler_Click);
            // 
            // servicesValider
            // 
            this.servicesValider.BackColor = System.Drawing.Color.Yellow;
            this.servicesValider.FlatAppearance.BorderSize = 0;
            this.servicesValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicesValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicesValider.ForeColor = System.Drawing.Color.Red;
            this.servicesValider.Location = new System.Drawing.Point(498, 260);
            this.servicesValider.Name = "servicesValider";
            this.servicesValider.Size = new System.Drawing.Size(105, 40);
            this.servicesValider.TabIndex = 3;
            this.servicesValider.Text = "Valider";
            this.servicesValider.UseVisualStyleBackColor = false;
            this.servicesValider.Click += new System.EventHandler(this.servicesValider_Click);
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
            this.panel3.Size = new System.Drawing.Size(57, 326);
            this.panel3.TabIndex = 84;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(10, 271);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(30, 43);
            this.r.TabIndex = 8;
            this.r.Text = "r";
            // 
            // o1
            // 
            this.o1.AutoSize = true;
            this.o1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o1.Location = new System.Drawing.Point(9, 228);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(34, 43);
            this.o1.TabIndex = 6;
            this.o1.Text = "o";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(11, 185);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(28, 43);
            this.l.TabIndex = 5;
            this.l.Text = "l";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(10, 142);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(32, 43);
            this.e.TabIndex = 4;
            this.e.Text = "e";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(10, 99);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(31, 43);
            this.t.TabIndex = 3;
            this.t.Text = "t";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.Location = new System.Drawing.Point(9, 56);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(34, 43);
            this.o.TabIndex = 2;
            this.o.Text = "o";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(5, 13);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(44, 43);
            this.h.TabIndex = 1;
            this.h.Text = "H";
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 363);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Services";
            this.Load += new System.EventHandler(this.Services_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDService)).EndInit();
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
        private System.Windows.Forms.MaskedTextBox servicesChambre1;
        private System.Windows.Forms.Button servicesAnnuler;
        private System.Windows.Forms.Button servicesValider;
        private System.Windows.Forms.ComboBox servicesServices1;
        private System.Windows.Forms.MaskedTextBox servicesNoms1;
        private System.Windows.Forms.Label servicesServices;
        private System.Windows.Forms.Label servicesChambre;
        private System.Windows.Forms.Label servicesNoms;
        private BDService bDService;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private BDServiceTableAdapters.ServicesTableAdapter servicesTableAdapter;
    }
}