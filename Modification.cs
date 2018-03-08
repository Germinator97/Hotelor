using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Session;
using Clients;

namespace BE_Informatique
{
    public partial class Modification : Form
    {
        Class1 C = new Class1();

        public Modification()
        {
            InitializeComponent();
        }

        private void modificationValider_Click(object sender, EventArgs e)
        {
            Client oldClient = new Client();
            Client newClient = new Client();


            newClient.Noms = modificationNoms1.Text;
            newClient.Prenoms = modificationPrenoms1.Text;
            newClient.Contacts = modificationContacts1.Text;
            newClient.Mail = modificationMail1.Text;
            newClient.Adresse = modificationAdresse1.Text;
            newClient.Montant = Convert.ToInt32(modificationMontant1.Text);
        }

        private void reduire_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modificationAnnuler_Click(object sender, EventArgs e)
        {
            Recu monRecu = new Recu();
            monRecu.Show();
            this.Close();
        }
    }
}
