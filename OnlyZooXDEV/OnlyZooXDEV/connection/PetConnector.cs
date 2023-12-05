using MySql.Data.MySqlClient;
using OnlyZoo.model;
using Shipwreck.connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZooXDEV.connection
{
    internal class PetConnector
    {
        public PetList pets { get; set; }
        private DataConnector connector;
        public static PetConnector _instance = new PetConnector();

        private PetConnector()
        {
            connector = new DataConnector();
            pets = new PetList();
        }

        public void LoadListFromDatabase()
        {
            using (MySqlConnection conn = connector.GetConnection())
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM mascota;";
                ReadQueryResult(cmd);
            }
        }

        public void ReadQueryResult(MySqlCommand cmd)
        {
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    pets.AddProd(new Pet(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                        reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5), reader.GetString(7), 
                        reader.GetDouble(6)));
                }
            }
        }
    }
}
