namespace BE_Informatique
{
    partial class Authentification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authentification));
            this.panel2 = new System.Windows.Forms.Panel();
            this.titre = new System.Windows.Forms.Label();
            this.fermer = new System.Windows.Forms.Button();
            this.hotelor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.authValider = new System.Windows.Forms.Button();
            this.authPass1 = new System.Windows.Forms.MaskedTextBox();
            this.authLogin1 = new System.Windows.Forms.MaskedTextBox();
            this.authPass = new System.Windows.Forms.Label();
            this.authLogin = new System.Windows.Forms.Label();
            this.auth2 = new System.Windows.Forms.Label();
            this.auth1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.r = new System.Windows.Forms.Label();
            this.o1 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.e = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.h = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.titre);
            this.panel2.Controls.Add(this.fermer);
            this.panel2.Controls.Add(this.hotelor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(509, 37);
            this.panel2.TabIndex = 88;
            // 
            // titre
            // 
            this.titre.AutoSize = true;
            this.titre.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.titre.Location = new System.Drawing.Point(187, 1);
            this.titre.Name = "titre";
            this.titre.Size = new System.Drawing.Size(193, 33);
            this.titre.TabIndex = 84;
            this.titre.Text = "Authentification";
            // 
            // fermer
            // 
            this.fermer.FlatAppearance.BorderSize = 0;
            this.fermer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.fermer.Image = ((System.Drawing.Image)(resources.GetObject("fermer.Image")));
            this.fermer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.fermer.Location = new System.Drawing.Point(470, 3);
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
            this.hotelor.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold);
            this.hotelor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.hotelor.Location = new System.Drawing.Point(3, 3);
            this.hotelor.Name = "hotelor";
            this.hotelor.Size = new System.Drawing.Size(68, 26);
            this.hotelor.TabIndex = 8;
            this.hotelor.Text = "Hotelor";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.authValider);
            this.panel1.Controls.Add(this.authPass1);
            this.panel1.Controls.Add(this.authLogin1);
            this.panel1.Controls.Add(this.authPass);
            this.panel1.Controls.Add(this.authLogin);
            this.panel1.Controls.Add(this.auth2);
            this.panel1.Controls.Add(this.auth1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 333);
            this.panel1.TabIndex = 89;
            // 
            // authValider
            // 
            this.authValider.BackColor = System.Drawing.Color.Yellow;
            this.authValider.FlatAppearance.BorderSize = 0;
            this.authValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authValider.ForeColor = System.Drawing.Color.Red;
            this.authValider.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.authValider.Location = new System.Drawing.Point(212, 270);
            this.authValider.Name = "authValider";
            this.authValider.Size = new System.Drawing.Size(131, 40);
            this.authValider.TabIndex = 2;
            this.authValider.Text = "Connecter";
            this.authValider.UseVisualStyleBackColor = false;
            this.authValider.Click += new System.EventHandler(this.authValider_Click);
            // 
            // authPass1
            // 
            this.authPass1.BackColor = System.Drawing.Color.White;
            this.authPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authPass1.Location = new System.Drawing.Point(137, 209);
            this.authPass1.Name = "authPass1";
            this.authPass1.Size = new System.Drawing.Size(267, 31);
            this.authPass1.TabIndex = 1;
            this.authPass1.UseSystemPasswordChar = true;
            this.authPass1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.authPass1_KeyPress);
            // 
            // authLogin1
            // 
            this.authLogin1.BackColor = System.Drawing.Color.White;
            this.authLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authLogin1.Location = new System.Drawing.Point(137, 130);
            this.authLogin1.Name = "authLogin1";
            this.authLogin1.Size = new System.Drawing.Size(267, 31);
            this.authLogin1.TabIndex = 0;
            this.authLogin1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.authLogin1_KeyPress);
            // 
            // authPass
            // 
            this.authPass.AutoSize = true;
            this.authPass.BackColor = System.Drawing.Color.Transparent;
            this.authPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authPass.ForeColor = System.Drawing.Color.Blue;
            this.authPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.authPass.Location = new System.Drawing.Point(198, 181);
            this.authPass.Name = "authPass";
            this.authPass.Size = new System.Drawing.Size(154, 25);
            this.authPass.TabIndex = 91;
            this.authPass.Text = "Mot de passe";
            // 
            // authLogin
            // 
            this.authLogin.AutoSize = true;
            this.authLogin.BackColor = System.Drawing.Color.Transparent;
            this.authLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authLogin.ForeColor = System.Drawing.Color.Blue;
            this.authLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.authLogin.Location = new System.Drawing.Point(237, 102);
            this.authLogin.Name = "authLogin";
            this.authLogin.Size = new System.Drawing.Size(70, 25);
            this.authLogin.TabIndex = 90;
            this.authLogin.Text = "Login";
            // 
            // auth2
            // 
            this.auth2.AutoSize = true;
            this.auth2.BackColor = System.Drawing.Color.Transparent;
            this.auth2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auth2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auth2.ForeColor = System.Drawing.Color.Red;
            this.auth2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.auth2.Location = new System.Drawing.Point(85, 40);
            this.auth2.Name = "auth2";
            this.auth2.Size = new System.Drawing.Size(376, 24);
            this.auth2.TabIndex = 89;
            this.auth2.Text = "login et le mot de passe administrateur.";
            // 
            // auth1
            // 
            this.auth1.AutoSize = true;
            this.auth1.BackColor = System.Drawing.Color.Transparent;
            this.auth1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auth1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auth1.ForeColor = System.Drawing.Color.Red;
            this.auth1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.auth1.Location = new System.Drawing.Point(56, 16);
            this.auth1.Name = "auth1";
            this.auth1.Size = new System.Drawing.Size(448, 24);
            this.auth1.TabIndex = 88;
            this.auth1.Text = "Vous devez vous authentifier en renseignant le";
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
            this.panel3.Size = new System.Drawing.Size(50, 333);
            this.panel3.TabIndex = 95;
            // 
            // r
            // 
            this.r.AutoSize = true;
            this.r.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.r.Location = new System.Drawing.Point(7, 234);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(28, 39);
            this.r.TabIndex = 8;
            this.r.Text = "r";
            // 
            // o1
            // 
            this.o1.AutoSize = true;
            this.o1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.o1.Location = new System.Drawing.Point(6, 201);
            this.o1.Name = "o1";
            this.o1.Size = new System.Drawing.Size(31, 39);
            this.o1.TabIndex = 6;
            this.o1.Text = "o";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.l.Location = new System.Drawing.Point(8, 168);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(26, 39);
            this.l.TabIndex = 5;
            this.l.Text = "l";
            // 
            // e
            // 
            this.e.AutoSize = true;
            this.e.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.e.Location = new System.Drawing.Point(7, 135);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(29, 39);
            this.e.TabIndex = 4;
            this.e.Text = "e";
            // 
            // t
            // 
            this.t.AutoSize = true;
            this.t.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.t.Location = new System.Drawing.Point(7, 102);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(28, 39);
            this.t.TabIndex = 3;
            this.t.Text = "t";
            // 
            // o
            // 
            this.o.AutoSize = true;
            this.o.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.o.Location = new System.Drawing.Point(6, 69);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(31, 39);
            this.o.TabIndex = 2;
            this.o.Text = "o";
            // 
            // h
            // 
            this.h.AutoSize = true;
            this.h.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.h.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.h.Location = new System.Drawing.Point(2, 36);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(40, 39);
            this.h.TabIndex = 1;
            this.h.Text = "H";
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(509, 370);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification";
            this.TopMost = true;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label titre;
        private System.Windows.Forms.Label hotelor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button authValider;
        private System.Windows.Forms.MaskedTextBox authPass1;
        private System.Windows.Forms.MaskedTextBox authLogin1;
        private System.Windows.Forms.Label authPass;
        private System.Windows.Forms.Label authLogin;
        private System.Windows.Forms.Label auth2;
        private System.Windows.Forms.Label auth1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label r;
        private System.Windows.Forms.Label o1;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.Label e;
        private System.Windows.Forms.Label t;
        private System.Windows.Forms.Label o;
        private System.Windows.Forms.Label h;
        private System.Windows.Forms.Button fermer;

    }
}