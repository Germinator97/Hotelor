using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Session;
using Clients;

namespace BE_Informatique
{
    public partial class Demande : Form
    {
        Class1 C=new Class1();

        public Demande()
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

        private void demandeVAlider_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            c.Noms = demandeNoms1.Text;
            c.Prenoms = demandePrenoms1.Text;
            c.Contacts = demandeContacts1.Text;
            c.Mail = demandeMail1.Text;
            c.Adresse = demandeAdresse1.Text;
            c.Bonus = demandeBonus1.Text;
            c.Montant = Convert.ToInt32(demandeMontant1.Text);
            C.insertClient(c);
            this.Close();
            Recu monRecu = new Recu();
            monRecu.Show();
        }

        private void demandeAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
            Bienvenue monMenu = new Bienvenue();
            monMenu.Show();
        }

        private void Demande_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'bDBanque.Banque'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.banqueTableAdapter.Fill(this.bDBanque.Banque);
            // TODO: cette ligne de code charge les données dans la table 'bDPaiements.Paiements'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.paiementsTableAdapter.Fill(this.bDPaiements.Paiements);
            demandeBonus1.Items.Add("Non");
            demandeBonus1.Items.Add("Oui");
        }
    }
}
