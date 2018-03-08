using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Hotel;
using Session;

namespace BE_Informatique
{
    public partial class Hotel : Form
    {
        Class1 C = new Class1();

        public Hotel()
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

        private void hotelValider_Click(object sender, EventArgs e)
        {
            hotel h = new hotel();
            h.Nom = hotelNom1.Text;
            h.Contact = Convert.ToInt32(hotelContacts1.Text);
            h.Adresse = hotelAdresse1.Text;
            h.Mail = hotelMail1.Text;
            h.Site = hotelWeb1.Text;
            h.Chambre = Convert.ToInt32(hotelChambre1.Text);
            h.Logo = hotelLogo1.Text;
            C.insertHotel(h);
            this.Close();
            Bienvenue monMenu = new Bienvenue();
            monMenu.Show();
        }

        private void hotelAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
            Bienvenue monMenu = new Bienvenue();
            monMenu.Show();
        }
    }
}
