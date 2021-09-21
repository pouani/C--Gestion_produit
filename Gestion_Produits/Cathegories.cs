using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestion_Produits
{
    class Cathegories
    {
        private string _id;
        private string _nom_c;
        private string _description_c;
        private DateTime _creerle;
        private DateTime _modifierle;

        public Cathegories(string id, string nom_c, string description_c, DateTime creerle, DateTime modifierle)
        {
            _id = id;
            _nom_c = nom_c;
            _description_c = description_c;
            _creerle = creerle;
            _modifierle = modifierle;
        }

        public string Id { get => _id; set => _id = value; }
        public string Nom_c { get => _nom_c; set => _nom_c = value; }
        public string Description_c { get => _description_c; set => _description_c = value; }
        public DateTime Creerle { get => _creerle; set => _creerle = value; }
        public DateTime Modifierle { get => _modifierle; set => _modifierle = value; }

        public Cathegories()
        {

        }

        ConnectBD bd = new ConnectBD();

        public List<Cathegories> Read()
        {
            List<Cathegories> cathegorie = new List<Cathegories>();
            string query = "select *from categories";

            try
            {
                bd.ConnectionOpen();
                MySqlCommand cmd = new MySqlCommand(query, bd.ConnectionOpen);
            }
        }
    }
}
