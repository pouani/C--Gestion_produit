using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Gestion_Produits
{
    class ConnectBD
    {
        private MySqlConnection _Connection;

        //constructeur 
        public ConnectBD()
        {
            string ConnectionString = "server=localhost;database=api_rest;uid=root;password=;";
            Connection = new MySqlConnection(ConnectionString);
        }

        public MySqlConnection Connection
        {
            get => _Connection;
            set => _Connection = value;
        }

        //On verifie si la connection est ouverte et on ferme
        public bool ConnectionClose()
        {
            if(Connection.State == ConnectionState.Open)
            {
                Connection.Close();
                return true;
            }
            return false;
        }

        //On verifie si la connection est fermé et on ouvre
         public bool ConnectionOpen()
        {
            try
            {
                if (Connection.State == ConnectionState.Closed)
                {
                    Connection.Open();
                    MessageBox.Show("Connection a la Base de données reussie");
                    return true;
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Connection a la Base de données Echouée");
            }
            return false;
        }
    }
}
