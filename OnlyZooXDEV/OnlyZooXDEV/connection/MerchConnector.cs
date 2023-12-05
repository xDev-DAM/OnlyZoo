using MySql.Data.MySqlClient;
using OnlyZooXDEV.model;
using Shipwreck.connector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyZooXDEV.connection
{
    internal class MerchConnector
    {
        public MerchList merchs { get; set; }
        private DataConnector connector;
        public static MerchConnector _instance = new MerchConnector();

        private MerchConnector()
        {
            connector = new DataConnector();
            merchs = new MerchList();
        }

        public void LoadListFromDatabase()
        {
            using (MySqlConnection conn = connector.GetConnection())
            {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM merchandising;";
                ReadQueryResult(cmd);
            }
        }

        public void ReadQueryResult(MySqlCommand cmd)
        {
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    merchs.AddMerch(new Merch(reader.GetInt32(0),reader.GetString(1),
                        reader.GetString(2),reader.GetInt32(3),reader.GetDouble(4),
                        reader.GetString(5)));
                }
            }
        }
    }
}

