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
    internal class ProductConnector
    {
        public ProductList products { get; set; }
        private DataConnector connector;
        public static ProductConnector _instance = new ProductConnector();

        private ProductConnector() { 
            connector = new DataConnector();
            products = new ProductList();
        }

        public void LoadListFromDatabase() {
            using (MySqlConnection conn = connector.GetConnection()) {
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM producto;";
                ReadQueryResult(cmd);
            }
        }

        public void ReadQueryResult(MySqlCommand cmd) {
            using (MySqlDataReader reader = cmd.ExecuteReader()) {
                while (reader.Read()) {
                    products.AddProd(new Product(reader.GetInt32(0),reader.GetString(1),reader.GetString(2),
                        reader.GetDouble(5), reader.GetInt32(4), reader.GetString(6),reader.GetInt32(3)));
                }
            }
        }
    }
}
