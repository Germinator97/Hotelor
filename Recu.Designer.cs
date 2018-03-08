namespace BE_Informatique
{
    partial class Recu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titre = new System.Windows.Forms.Label();
            this.reduire = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.hotelor = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.recuAnnuler = new System.Windows.Forms.Button();
            this.recuValider = new System.Windows.Forms.Button();
            this.recuRecu = new System.Windows.Forms.Panel();
            this.recuDate1 = new System.Windows.Forms.ComboBox();
            this.recuNumero1 = new System.Windows.Forms.ComboBox();
            this.recuMontant1 = new System.Windows.Forms.ComboBox();
            this.recuBonus1 = new System.Windows.Forms.ComboBox();
            this.recuPaiement1 = new System.Windows.Forms.ComboBox();
            this.recuSortie1 = new System.Windows.Forms.ComboBox();
            this.recuChambre1 = new System.Windows.Forms.ComboBox();
            this.recuNoms1 = new System.Windows.Forms.ComboBox();
            this.recuMontant = new System.Windows.Forms.Label();
            this.recuBonus = new System.Windows.Forms.Label();
            this.recuPaiement = new System.Windows.Forms.Label();
            this.recuSortie = new System.Windows.Forms.Label();
            this.recuChambre = new System.Windows.Forms.Label();
            this.recuNoms = new System.Windows.Forms.Label();
            this.recuDate = new System.Windows.Forms.Label();
            this.recuNumero = new System.Windows.Forms.Label();
            this.recuWeb = new System.Windows.Forms.Label();
            this.recuContacts = new System.Windows.Forms.Label();
            this.recuMail = new System.Windows.Forms.Label();
            this.recuAdresse = new System.Windows.Forms.Label();
            this.recuNom = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.r = new System.Windows.Forms.Label();
            this.o1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.recuModifier = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.recuRecu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(876, 39);
            this.panel1.TabIndex = 2;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.Location = new System.Drawing.Point(403, 3);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(65, 33);
            this.titre.TabIndex = 16;
            this.titre.Text = "Recu";
            // 
            // reduire
            // 
            this.reduire.FlatAppearance.BorderSize = 0;
            this.reduire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reduire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reduire.Image = ((System.Drawing.Image)(resources.GetObject("reduire.Image")));
            this.reduire.Location = new System.Drawing.Point(811, 3);
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
            this.fermer.Location = new System.Drawing.Point(842, 3);
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
            this.panel2.Controls.Add(this.recuAnnuler);
            this.panel2.Controls.Add(this.recuValider);
            this.panel2.Controls.Add(this.recuRecu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.recuModifier);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(876, 581);
            this.panel2.TabIndex = 3;
            // 
            // recuAnnuler
            // 
            this.recuAnnuler.BackColor = System.Drawing.Color.Yellow;
            this.recuAnnuler.FlatAppearance.BorderSize = 0;
            this.recuAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recuAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuAnnuler.ForeColor = System.Drawing.Color.Red;
            this.recuAnnuler.Location = new System.Drawing.Point(714, 512);
            this.recuAnnuler.Name = "recuAnnuler";
            this.recuAnnuler.Size = new System.Drawing.Size(108, 44);
            this.recuAnnuler.TabIndex = 2;
            this.recuAnnuler.Text = "Retour";
            this.recuAnnuler.UseVisualStyleBackColor = false;
            this.recuAnnuler.Click += new System.EventHandler(this.recuAnnuler_Click);
            // 
            // recuValider
            // 
            this.recuValider.BackColor = System.Drawing.Color.Yellow;
            this.recuValider.FlatAppearance.BorderSize = 0;
            this.recuValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recuValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuValider.ForeColor = System.Drawing.Color.Red;
            this.recuValider.Location = new System.Drawing.Point(492, 512);
            this.recuValider.Name = "recuValider";
            this.recuValider.Size = new System.Drawing.Size(104, 44);
            this.recuValider.TabIndex = 0;
            this.recuValider.Text = "Valider";
            this.recuValider.UseVisualStyleBackColor = false;
            this.recuValider.Click += new System.EventHandler(this.recuValider_Click);
            // 
            // recuRecu
            // 
            this.recuRecu.BackColor = System.Drawing.Color.White;
            this.recuRecu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.recuRecu.Controls.Add(this.recuDate1);
            this.recuRecu.Controls.Add(this.recuNumero1);
            this.recuRecu.Controls.Add(this.recuMontant1);
            this.recuRecu.Controls.Add(this.recuBonus1);
            this.recuRecu.Controls.Add(this.recuPaiement1);
            this.recuRecu.Controls.Add(this.recuSortie1);
            this.recuRecu.Controls.Add(this.recuChambre1);
            this.recuRecu.Controls.Add(this.recuNoms1);
            this.recuRecu.Controls.Add(this.recuMontant);
            this.recuRecu.Controls.Add(this.recuBonus);
            this.recuRecu.Controls.Add(this.recuPaiement);
            this.recuRecu.Controls.Add(this.recuSortie);
            this.recuRecu.Controls.Add(this.recuChambre);
            this.recuRecu.Controls.Add(this.recuNoms);
            this.recuRecu.Controls.Add(this.recuDate);
            this.recuRecu.Controls.Add(this.recuNumero);
            this.recuRecu.Controls.Add(this.recuWeb);
            this.recuRecu.Controls.Add(this.recuContacts);
            this.recuRecu.Controls.Add(this.recuMail);
            this.recuRecu.Controls.Add(this.recuAdresse);
            this.recuRecu.Controls.Add(this.recuNom);
            this.recuRecu.Controls.Add(this.logo);
            this.recuRecu.ForeColor = System.Drawing.Color.Red;
            this.recuRecu.Location = new System.Drawing.Point(103, 73);
            this.recuRecu.Name = "recuRecu";
            this.recuRecu.Size = new System.Drawing.Size(737, 416);
            this.recuRecu.TabIndex = 87;
            // 
            // recuDate1
            // 
            this.recuDate1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recuDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuDate1.FormattingEnabled = true;
            this.recuDate1.Location = new System.Drawing.Point(404, 84);
            this.recuDate1.Name = "recuDate1";
            this.recuDate1.Size = new System.Drawing.Size(218, 32);
            this.recuDate1.TabIndex = 21;
            // 
            // recuNumero1
            // 
            this.recuNumero1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recuNumero1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuNumero1.FormattingEnabled = true;
            this.recuNumero1.Location = new System.Drawing.Point(404, 46);
            this.recuNumero1.Name = "recuNumero1";
            this.recuNumero1.Size = new System.Drawing.Size(218, 32);
            this.recuNumero1.TabIndex = 20;
            // 
            // recuMontant1
            // 
            this.recuMontant1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recuMontant1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuMontant1.FormattingEnabled = true;
            this.recuMontant1.Location = new System.Drawing.Point(233, 359);
            this.recuMontant1.Name = "recuMontant1";
            this.recuMontant1.Size = new System.Drawing.Size(464, 32);
            this.recuMontant1.TabIndex = 19;
            // 
            // recuBonus1
            // 
            this.recuBonus1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recuBonus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuBonus1.FormattingEnabled = true;
            this.recuBonus1.Location = new System.Drawing.Point(233, 321);
            this.recuBonus1.Name = "recuBonus1";
            this.recuBonus1.Size = new System.Drawing.Size(464, 32);
            this.recuBonus1.TabIndex = 18;
            // 
            // recuPaiement1
            // 
            this.recuPaiement1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recuPaiement1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuPaiement1.FormattingEnabled = true;
            this.recuPaiement1.Location = new System.Drawing.Point(233, 283);
            this.recuPaiement1.Name = "recuPaiement1";
            this.recuPaiement1.Size = new System.Drawing.Size(464, 32);
            this.recuPaiement1.TabIndex = 17;
            // 
            // recuSortie1
            // 
            this.recuSortie1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recuSortie1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuSortie1.FormattingEnabled = true;
            this.recuSortie1.Location = new System.Drawing.Point(233, 245);
            this.recuSortie1.Name = "recuSortie1";
            this.recuSortie1.Size = new System.Drawing.Size(464, 32);
            this.recuSortie1.TabIndex = 16;
            // 
            // recuChambre1
            // 
            this.recuChambre1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recuChambre1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuChambre1.FormattingEnabled = true;
            this.recuChambre1.Location = new System.Drawing.Point(233, 207);
            this.recuChambre1.Name = "recuChambre1";
            this.recuChambre1.Size = new System.Drawing.Size(464, 32);
            this.recuChambre1.TabIndex = 15;
            // 
            // recuNoms1
            // 
            this.recuNoms1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.recuNoms1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuNoms1.FormattingEnabled = true;
            this.recuNoms1.Location = new System.Drawing.Point(233, 169);
            this.recuNoms1.Name = "recuNoms1";
            this.recuNoms1.Size = new System.Drawing.Size(464, 32);
            this.recuNoms1.TabIndex = 14;
            // 
            // recuMontant
            // 
            this.recuMontant.AutoSize = true;
            this.recuMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuMontant.ForeColor = System.Drawing.Color.Blue;
            this.recuMontant.Location = new System.Drawing.Point(30, 362);
            this.recuMontant.Name = "recuMontant";
            this.recuMontant.Size = new System.Drawing.Size(96, 24);
            this.recuMontant.TabIndex = 13;
            this.recuMontant.Text = "Montant :";
            // 
            // recuBonus
            // 
            this.recuBonus.AutoSize = true;
            this.recuBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuBonus.ForeColor = System.Drawing.Color.Blue;
            this.recuBonus.Location = new System.Drawing.Point(30, 324);
            this.recuBonus.Name = "recuBonus";
            this.recuBonus.Size = new System.Drawing.Size(81, 24);
            this.recuBonus.TabIndex = 12;
            this.recuBonus.Text = "Bonus :";
            // 
            // recuPaiement
            // 
            this.recuPaiement.AutoSize = true;
            this.recuPaiement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuPaiement.ForeColor = System.Drawing.Color.Blue;
            this.recuPaiement.Location = new System.Drawing.Point(30, 286);
            this.recuPaiement.Name = "recuPaiement";
            this.recuPaiement.Size = new System.Drawing.Size(197, 24);
            this.recuPaiement.TabIndex = 11;
            this.recuPaiement.Text = "Mode de paiement :";
            // 
            // recuSortie
            // 
            this.recuSortie.AutoSize = true;
            this.recuSortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuSortie.ForeColor = System.Drawing.Color.Blue;
            this.recuSortie.Location = new System.Drawing.Point(30, 248);
            this.recuSortie.Name = "recuSortie";
            this.recuSortie.Size = new System.Drawing.Size(151, 24);
            this.recuSortie.TabIndex = 10;
            this.recuSortie.Text = "Date de sortie :";
            // 
            // recuChambre
            // 
            this.recuChambre.AutoSize = true;
            this.recuChambre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuChambre.ForeColor = System.Drawing.Color.Blue;
            this.recuChambre.Location = new System.Drawing.Point(30, 210);
            this.recuChambre.Name = "recuChambre";
            this.recuChambre.Size = new System.Drawing.Size(107, 24);
            this.recuChambre.TabIndex = 9;
            this.recuChambre.Text = "Chambre :";
            // 
            // recuNoms
            // 
            this.recuNoms.AutoSize = true;
            this.recuNoms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuNoms.ForeColor = System.Drawing.Color.Blue;
            this.recuNoms.Location = new System.Drawing.Point(30, 172);
            this.recuNoms.Name = "recuNoms";
            this.recuNoms.Size = new System.Drawing.Size(188, 24);
            this.recuNoms.TabIndex = 8;
            this.recuNoms.Text = "Noms et Prénoms :";
            // 
            // recuDate
            // 
            this.recuDate.AutoSize = true;
            this.recuDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuDate.ForeColor = System.Drawing.Color.Blue;
            this.recuDate.Location = new System.Drawing.Point(364, 87);
            this.recuDate.Name = "recuDate";
            this.recuDate.Size = new System.Drawing.Size(34, 24);
            this.recuDate.TabIndex = 7;
            this.recuDate.Text = "du";
            // 
            // recuNumero
            // 
            this.recuNumero.AutoSize = true;
            this.recuNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuNumero.ForeColor = System.Drawing.Color.Blue;
            this.recuNumero.Location = new System.Drawing.Point(311, 49);
            this.recuNumero.Name = "recuNumero";
            this.recuNumero.Size = new System.Drawing.Size(87, 24);
            this.recuNumero.TabIndex = 6;
            this.recuNumero.Text = "Recu N°";
            // 
            // recuWeb
            // 
            this.recuWeb.AutoSize = true;
            this.recuWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuWeb.ForeColor = System.Drawing.Color.Blue;
            this.recuWeb.Location = new System.Drawing.Point(152, 120);
            this.recuWeb.Name = "recuWeb";
            this.recuWeb.Size = new System.Drawing.Size(54, 15);
            this.recuWeb.TabIndex = 5;
            this.recuWeb.Text = "Site web";
            // 
            // recuContacts
            // 
            this.recuContacts.AutoSize = true;
            this.recuContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuContacts.ForeColor = System.Drawing.Color.Blue;
            this.recuContacts.Location = new System.Drawing.Point(152, 97);
            this.recuContacts.Name = "recuContacts";
            this.recuContacts.Size = new System.Drawing.Size(54, 15);
            this.recuContacts.TabIndex = 4;
            this.recuContacts.Text = "Contacts";
            // 
            // recuMail
            // 
            this.recuMail.AutoSize = true;
            this.recuMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuMail.ForeColor = System.Drawing.Color.Blue;
            this.recuMail.Location = new System.Drawing.Point(152, 73);
            this.recuMail.Name = "recuMail";
            this.recuMail.Size = new System.Drawing.Size(43, 15);
            this.recuMail.TabIndex = 3;
            this.recuMail.Text = "E-mail";
            // 
            // recuAdresse
            // 
            this.recuAdresse.AutoSize = true;
            this.recuAdresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuAdresse.ForeColor = System.Drawing.Color.Blue;
            this.recuAdresse.Location = new System.Drawing.Point(152, 50);
            this.recuAdresse.Name = "recuAdresse";
            this.recuAdresse.Size = new System.Drawing.Size(51, 15);
            this.recuAdresse.TabIndex = 2;
            this.recuAdresse.Text = "Adresse";
            // 
            // recuNom
            // 
            this.recuNom.AutoSize = true;
            this.recuNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuNom.ForeColor = System.Drawing.Color.Blue;
            this.recuNom.Location = new System.Drawing.Point(152, 27);
            this.recuNom.Name = "recuNom";
            this.recuNom.Size = new System.Drawing.Size(34, 15);
            this.recuNom.TabIndex = 1;
            this.recuNom.Text = "Nom";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.White;
            this.logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logo.Location = new System.Drawing.Point(15, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(131, 136);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(133, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(687, 24);
            this.label1.TabIndex = 86;
            this.label1.Text = "Les informations concernant la demande sont repertoriées dans ce recu.";
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
            this.panel3.Size = new System.Drawing.Size(69, 581);
            this.panel3.TabIndex = 85;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.Location = new System.Drawing.Point(12, 423);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(40, 57);
            this.r.TabIndex = 8;
            this.r.Text = "r";
            // 
            // o1
            // 
            this.o1.AutoSize = true;
            this.o1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o1.Location = new System.Drawing.Point(10, 366);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(45, 57);
            this.o1.TabIndex = 6;
            this.o1.Text = "o";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.Location = new System.Drawing.Point(13, 309);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(38, 57);
            this.l.TabIndex = 5;
            this.l.Text = "l";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.Location = new System.Drawing.Point(11, 252);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(42, 57);
            this.e.TabIndex = 4;
            this.e.Text = "e";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.Location = new System.Drawing.Point(12, 195);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(41, 57);
            this.t.TabIndex = 3;
            this.t.Text = "t";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.Location = new System.Drawing.Point(10, 138);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(45, 57);
            this.o.TabIndex = 2;
            this.o.Text = "o";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.Location = new System.Drawing.Point(3, 81);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(59, 57);
            this.h.TabIndex = 1;
            this.h.Text = "H";
            // 
            // recuModifier
            // 
            this.recuModifier.BackColor = System.Drawing.Color.Yellow;
            this.recuModifier.FlatAppearance.BorderSize = 0;
            this.recuModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.recuModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recuModifier.ForeColor = System.Drawing.Color.Red;
            this.recuModifier.Location = new System.Drawing.Point(602, 512);
            this.recuModifier.Name = "recuModifier";
            this.recuModifier.Size = new System.Drawing.Size(106, 44);
            this.recuModifier.TabIndex = 1;
            this.recuModifier.Text = "Modifier";
            this.recuModifier.UseVisualStyleBackColor = false;
            this.recuModifier.Click += new System.EventHandler(this.recuModifier_Click);
            // 
            // Recu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Recu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recu";
            this.Load += new System.EventHandler(this.Recu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.recuRecu.ResumeLayout(false);
            this.recuRecu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reduire;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Label hotelor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button recuAnnuler;
        private System.Windows.Forms.Button recuValider;
        private System.Windows.Forms.Panel recuRecu;
        private System.Windows.Forms.Label recuMontant;
        private System.Windows.Forms.Label recuBonus;
        private System.Windows.Forms.Label recuPaiement;
        private System.Windows.Forms.Label recuSortie;
        private System.Windows.Forms.Label recuChambre;
        private System.Windows.Forms.Label recuNoms;
        private System.Windows.Forms.Label recuDate;
        private System.Windows.Forms.Label recuNumero;
        private System.Windows.Forms.Label recuWeb;
        private System.Windows.Forms.Label recuContacts;
        private System.Windows.Forms.Label recuMail;
        private System.Windows.Forms.Label recuAdresse;
        private System.Windows.Forms.Label recuNom;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label o1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label o;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Button recuModifier;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.ComboBox recuNoms1;
        private System.Windows.Forms.ComboBox recuDate1;
        private System.Windows.Forms.ComboBox recuNumero1;
        private System.Windows.Forms.ComboBox recuMontant1;
        private System.Windows.Forms.ComboBox recuBonus1;
        private System.Windows.Forms.ComboBox recuPaiement1;
        private System.Windows.Forms.ComboBox recuSortie1;
        private System.Windows.Forms.ComboBox recuChambre1;
    }
}