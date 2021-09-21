using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Gestion_Produits
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtEmail.Text = "";
            txtAge.Text = "";
            txtPassword.Text = "";
            txtConfPassword.Text = "";
            ErrorPswC.Text = "";
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtEmail.Text == "" || txtAge.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("veillez remplir tout les champs");
            }
            if (txtConfPassword.Text == "")
            {
                ErrorPswC.Text = "Veillez confirmer le mot de passe";
            }
            else if(txtPassword.Text != txtConfPassword.Text)
            {
                ErrorPswC.Text = "veillez rentrer le meme mot de passe";
            }
            else if(txtPassword.Text == txtConfPassword.Text)
            {
                ErrorPswC.Text = "";
            }
            //code de verification de la validité de l'email
            if(txtEmail.Text != "")
            {

                try
                {
                    new MailAddress(txtEmail.Text);//pour verifier si l'adresse email est valide ou non
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Email invalide", ex.Message);
                }
                
            }

            //Au moins 8 caractères sur le mot de passe
            if(txtPassword.TextLength < 8)
            {
                MessageBox.Show("au moins 8 caracteres pour le mot de passe");
            }

            //Verification de l'age
            if(txtAge.TextLength > 3 || txtAge.TextLength < 2)
            {
                MessageBox.Show("Entrez l'age valide au moins 15 ans");
            }

        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Authentification log = new Authentification();
            log.Show();
        }

        private void TxtAge_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar < 48 || e.KeyChar > 57)//Code Asci des numric
            {
                e.Handled = true;
            }
            if(e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
    }
}
