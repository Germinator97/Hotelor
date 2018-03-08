using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clients;
using Session;

namespace BE_Informatique
{
    public partial class Recu : Form
    {
        Class1 C = new Class1();

        public Recu()
        {
            InitializeComponent();
        }

        private void reduire_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void recuValider_Click(object sender, EventArgs e)
        {
            this.Close();
            Bienvenue monMenu = new Bienvenue();
            monMenu.Show();
        }

        private void recuModifier_Click(object sender, EventArgs e)
        {
            this.Close();
            Modification maDemande = new Modification();
            maDemande.ShowDialog();
        }

        private void recuAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
            Bienvenue monMenu = new Bienvenue();
            monMenu.Show();
        }

        private void Recu_Load(object sender, EventArgs e)
        {
            logo.Image = Image.FromFile(@"C:\Users\Asus R511L\Documents\Visual Studio 2013\Projects\BE_Informatique\BE_Informatique\Resources\zylom.ico");
            recuNoms1.DataSource = C.informationClient();
            Demande maDemande = new Demande();
        }
    }
}
