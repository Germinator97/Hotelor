using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BE_Informatique
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void authValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(authLogin1.Text))
            {
                MessageBox.Show("Please enter your username and password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                authLogin1.Focus();
                authLogin1.Text = "";
                authPass1.Text = "";
                return;
            }
            try
            {
                AppDataTableAdapters.AdministrateurTableAdapter admin = new AppDataTableAdapters.AdministrateurTableAdapter();
                AppData.AdministrateurDataTable dt = admin.GetDataByUserPass(authLogin1.Text, authPass1.Text);
                if (dt.Rows.Count>0)
                {
                    Bienvenue monMenu = new Bienvenue();
                    monMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Your username or password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    authLogin1.Text = "";
                    authPass1.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                authLogin1.Text = "";
                authPass1.Text = "";
                return;
            }
        }

        private void fermer_Click(object sender, EventArgs e)
        {
            DialogResult reponse=MessageBox.Show("Vouliez-vous sortir définitivement de l'application?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(reponse==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void authLogin1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)13)
            {
                authLogin1.Focus();
            }
        }

        private void authPass1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                authValider.PerformClick();
            }
        }
    }
}
