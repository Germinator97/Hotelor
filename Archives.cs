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
    public partial class Archives : Form
    {
        public Archives()
        {
            InitializeComponent();
        }

        private void archivesEnvoyer_Click(object sender, EventArgs e)
        {
            this.Close();
            Bienvenue monMenu = new Bienvenue();
            monMenu.Show();
        }

        private void archivesAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
            Bienvenue monMenu = new Bienvenue();
            monMenu.Show();
        }

        private void reduire_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Archives_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDArchives.Archives'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.archivesTableAdapter.Fill(this.bDArchives.Archives);
        }
    }
}
