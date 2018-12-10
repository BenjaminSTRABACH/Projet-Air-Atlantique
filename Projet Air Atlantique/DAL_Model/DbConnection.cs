using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using MySql.Data.MySqlClient;

namespace Projet_Air_Atlantique.Models.DAL
{
    class DbConnection
    {
        private static MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Initialisation de la connexion à la base de données
        public void initConnection()
        {
            server = "localhost";
            database = "airatlantique";
            uid = "admindb";
            password = "KSKskJNggKWr9EEZ";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //Getter de la connexion
        public MySqlConnection getconnection()
        {
            return connection;
        }

        //Ouverture de la connexion à la base de données
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Fermeture de la connexion à la base de données
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}