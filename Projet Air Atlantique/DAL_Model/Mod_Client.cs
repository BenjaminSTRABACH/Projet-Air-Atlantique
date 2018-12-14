using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
            connect.OpenConnection();
            string query = "SELECT * FROM client;";
            MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ClientController contr = new ClientController(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetChar(3), reader.GetDateTime(4), reader.GetInt32(5), reader.GetInt32(6), reader.GetString(7)); 
                list.Add(contr);
            }
            reader.Close();
            connect.CloseConnection();
        }

        public void AddClientBinders(ClientController c)
        {
            connect.OpenConnection();
            string query = "INSERT INTO client (nom, prenom, genre, dateNaissance, pointsFidelite, tel, mail) VALUES (@nom, @prenom, @genre, @dateNaissance, @pointsFidelite, @tel, @mail)";
            MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
            cmd.Parameters.AddWithValue("@nom", c.NomProperty);
            cmd.Parameters.AddWithValue("@prenom", c.PrenomProperty);
            cmd.Parameters.AddWithValue("@genre", c.GenreProperty);
            cmd.Parameters.AddWithValue("@dateNaissance", c.DateNaissanceProperty);
            cmd.Parameters.AddWithValue("@pointsFidelite", c.PointsFideliteProperty);
            cmd.Parameters.AddWithValue("@tel", c.TelProperty);
            cmd.Parameters.AddWithValue("@mail", c.MailProperty);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            connect.CloseConnection();
        }

        public static void UpdateClientBinders(ClientController c)
        {
            connect.OpenConnection();
            string query = "UPDATE `client` SET `nom` = @nom, `prenom` = @prenom, `genre` = @genre, `dateNaissance` = @dateNaissance, `pointsFidelite` = @pointsFidelite, `tel` = @tel, `mail` = @mail WHERE `client`.`idClient` = @idClient;";
            MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
            cmd.Parameters.AddWithValue("@nom", c.NomProperty);
            cmd.Parameters.AddWithValue("@prenom", c.PrenomProperty);
            cmd.Parameters.AddWithValue("@genre", c.GenreProperty);
            cmd.Parameters.AddWithValue("@dateNaissance", c.DateNaissanceProperty);
            cmd.Parameters.AddWithValue("@pointsFidelite", c.PointsFideliteProperty);
            cmd.Parameters.AddWithValue("@tel", c.TelProperty);
            cmd.Parameters.AddWithValue("@mail", c.MailProperty);
            cmd.Parameters.AddWithValue("@idClient", c.IdClientProperty);
            MySqlDataAdapter sqlDataAdap = new MySqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
            connect.CloseConnection();
        }

    }
}
