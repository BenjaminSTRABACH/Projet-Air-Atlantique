using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projet_Air_Atlantique.Controllers;

namespace Projet_Air_Atlantique.Models.DAL
{
    class Mod_Client
    {
        private static DbConnection connect;

        public Mod_Client()
        {
            connect = new DbConnection();
        }

        //Liste des clients
        public void SelectClientBinders(List<ClientController> list)
        {
            string query = "SELECT * FROM client;";
            connect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ClientController contr = new ClientController(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetChar(3), reader.GetDateTime(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetString(7)); 
                list.Add(contr);
            }
            reader.Close();
        }

        public void AddClientBinders()
        {
            string query = "INSERT INTO client (nom, prenom, genre, dateNaissance, pointsFidelite, tel, mail) VALUES (@nom, @prenom, @genre, @dateNaissance, @pointsFidelite, @tel, @mail)";
            connect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());

        }

    }
}
