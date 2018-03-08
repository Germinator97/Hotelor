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
    public partial class Services : Form
    {
        public Services()
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

        private void servicesValider_Click(object sender, EventArgs e)
        {
            Bienvenue monMenu = new Bienvenue();
            monMenu.Show();
            this.Close();
        }

        private void servicesAnnuler_Click(object sender, EventArgs e)
        {
            Bienvenue monMenu = new Bienvenue();
            monMenu.Show();
            this.Close();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDService.Services'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.servicesTableAdapter.Fill(this.bDService.Services);

        }
    }
}
