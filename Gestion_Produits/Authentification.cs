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
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
           /* if(txtEmail.Text != "")
            {
                try
                {
                    new MailAddress(txtEmail.Text);// Pour verifier l'email entrez
                }catch(Exception ex)
                {
                    MessageBox.Show("Entrez l'email valide");
                }
            }*/
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Produits p = new Produits();
            p.Show();
        }
    }
}
