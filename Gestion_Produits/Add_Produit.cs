using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gestion_Produits
{
    public partial class Add_Produit : Form
    {
        public Add_Produit()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            var con = new ConnectBD();
            con.ConnectionOpen();

            MySqlCommand cmd = con.Connection.CreateCommand();
            cmd.CommandText = "INSERT INTO produits(id,nom,description,prix,categories_id,created_at,updated_at)" +
                "Values(null,?,?,?,null,?,?)";
            cmd.Parameters.Add(new MySqlParameter("@nom", txtNom_P.Text));
            cmd.Parameters.Add(new MySqlParameter("@description", txtDescription.Text));
            cmd.Parameters.Add(new MySqlParameter("@prix", txtPrix.Text));

            cmd.ExecuteNonQuery();
            con.ConnectionClose();
            Produits p = new Produits();
            p.Close();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtNom_P.Text = "";
            txtDescription.Text = "";
            txtPrix.Text = "";
        }

        private void Add_Produit_Load(object sender, EventArgs e)
        {

        }
    }
}
