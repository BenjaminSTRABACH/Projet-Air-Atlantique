using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projet_Air_Atlantique.Controllers;

namespace Projet_Air_Atlantique.Models.DAL
{
    class Mod_Vol
    {
        private static DbConnection connect;

        public Mod_Vol()
        {
            connect = new DbConnection();
        }

        //Liste des vols
        public void SelectVolBinders(List<VolController> list)
        {
            string query = "SELECT * FROM vol;";
            connect.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connect.GetConnection());
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                VolController contr = new VolController(reader.GetInt32(0), reader.GetString(1), reader.GetDateTime(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetDateTime(5), reader.GetString(6));
                list.Add(contr);
            }
            reader.Close();
        }
    }
}
