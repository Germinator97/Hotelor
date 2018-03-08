using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Session;
using Pertes;

namespace BE_Informatique
{
    public partial class Pertes : Form
    {
        Class1 C = new Class1();

        public Pertes()
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

        private void pertesValider_Click(object sender, EventArgs e)
        {
            Perte p = new Perte();
            p.Article = pertesArticles1.Text;
            C.insertPertes(p);
            Bienvenue monMenu = new Bienvenue();
            monMenu.Show();
            this.Close();
        }

        private void pertesAnnuler_Click(object sender, EventArgs e)
        {
            Bienvenue monMenu = new Bienvenue();
            monMenu.Show();
            this.Close();
        }
    }
}
