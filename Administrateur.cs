using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Administrateur;
using Session;

namespace BE_Informatique
{
    public partial class Administrateur : Form
    {
        Class1 C = new Class1();
        //OleDbConnection connection;
        //OleDbCommand command;

        public Administrateur()
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
            Authentification monAuthentification = new Authentification();
            monAuthentification.ShowDialog();
        }

        private void confValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ancienLogin1.Text))
            {
                MessageBox.Show("Please enter your username and password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ancienLogin1.Focus();
                ancienLogin1.Text = "";
                ancienPass1.Text = "";
                return;
            }
            try
            {
                AppDataTableAdapters.AdministrateurTableAdapter admin = new AppDataTableAdapters.AdministrateurTableAdapter();
                AppData.AdministrateurDataTable dt = admin.GetData();
                if (dt.Rows.Count > 0)
                {
                    if (nouveauLogin1.Text!="" && nouveauPass1.Text!="")
                    {
                        if (nouveauPass1.Text==confirmation1.Text)
                        {
                            admin.UpdateQueryUserPass(nouveauLogin1.Text,nouveauPass1.Text);
                            this.Close();
                            Authentification monAuthentification = new Authentification();
                            monAuthentification.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Password incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            nouveauLogin1.Text = "";
                            nouveauPass1.Text = "";
                            confirmation1.Text = "";
                            ancienLogin1.Text = "";
                            ancienPass1.Text = "";
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter your new username and password", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        nouveauLogin1.Text = "";
                        nouveauPass1.Text = "";
                        confirmation1.Text = "";
                        ancienLogin1.Text = "";
                        ancienPass1.Text = "";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Your username or password is incorrect", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ancienLogin1.Text = "";
                    ancienPass1.Text = "";
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ancienLogin1.Text = "";
                ancienPass1.Text = "";
                return;
            }
        }

        private void confAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
            Authentification monAuthentification = new Authentification();
            monAuthentification.ShowDialog();
        }

        private void ancienLogin1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==(char)10)
            {
                ancienLogin1.Focus();
            }
        }

        private void ancienPass1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)10)
            {
                confValider.PerformClick();
            }
        }

        private void nouveauLogin1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)10)
            {
                nouveauLogin1.Focus();
            }
        }

        private void nouveauPass1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)10)
            {
                confValider.PerformClick();
            }
        }
    }
}
