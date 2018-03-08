using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BE_Informatique
{
    public partial class Sorties : Form
    {
        public Sorties()
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

        private void sortiesSortie_Click(object sender, EventArgs e)
        {
            this.Close();
            Bienvenue monMenu = new Bienvenue();
            monMenu.Show();
        }

        private void sortiesAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
            Bienvenue monMenu = new Bienvenue();
            monMenu.Show();
        }

        private void sortiesProlonger_Click(object sender, EventArgs e)
        {
            this.Close();
            Demande maDemande = new Demande();
            maDemande.Show();
        }

        private void Sorties_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDRecu.Recu'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.recuTableAdapter.Fill(this.bDRecu.Recu);

        }
    }
}
