using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows;
using MySql.Data.MySqlClient;

namespace Projet_Air_Atlantique.DAO_Model
{
    class DbConnection
    {
        private static MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Boolean OpenConnection()
        {
            server = "localhost";
            database = "air_atlantique";
            uid = "admindb";
            password = "KSKskJNggKWr9EEZ";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            connection.Open();
            return true;
        }
    }
}
