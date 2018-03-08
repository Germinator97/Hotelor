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
    public partial class Bienvenue : Form
    {
        
        public Bienvenue()
        {
            InitializeComponent();
        }

        private void home_Click(object sender, EventArgs e)
        {
            this.Close();
            selection.Width = home.Width;
            selection.Left = home.Left;
            Bienvenue monMenu = new Bienvenue();
            monMenu.Show();
        }


        private void verouiller_Click(object sender, EventArgs e)
        {
            this.Close();
            selection.Width = verouiller.Width;
            selection.Left = verouiller.Left;
            Authentification monAuthentification = new Authentification();
            monAuthentification.ShowDialog();
        }

        private void configuration_Click(object sender, EventArgs e)
        {
            this.Close();
            selection.Width = configuration.Width;
            selection.Left = configuration.Left;
            Administrateur maConfiguration = new Administrateur();
            maConfiguration.Show();
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            DialogResult reponse = MessageBox.Show("Vouliez-vous sortir définitivement de l'application?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (reponse == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void reduire_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void menuDemandes_Click(object sender, EventArgs e)
        {
            Demande maDemande = new Demande();
            maDemande.ShowDialog();
        }

        private void menuServices2_Click(object sender, EventArgs e)
        {
            Services monService = new Services();
            monService.ShowDialog();
        }

        private void menuPertes_Click(object sender, EventArgs e)
        {
            Pertes maPerte = new Pertes();
            maPerte.ShowDialog();
        }

        private void menuArchives_Click(object sender, EventArgs e)
        {
            Archives monArchive = new Archives();
            monArchive.ShowDialog();
        }

        private void menuSorties_Click(object sender, EventArgs e)
        {
            Sorties maSortie = new Sorties();
            maSortie.ShowDialog();
        }

        private void Bienvenue_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDServices.Services'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.servicesTableAdapter.Fill(this.bDServices.Services);

            // TODO: cette ligne de code charge les données dans la table 'bDClients.Clients'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.clientsTableAdapter.Fill(this.bDClients.Clients);
        }

        private void menuHotel_Click(object sender, EventArgs e)
        {
            Hotel monHotel = new Hotel();
            monHotel.Show();
        }
    }
}
