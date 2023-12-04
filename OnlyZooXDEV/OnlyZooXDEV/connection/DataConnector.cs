using MySql.Data.MySqlClient;
using OnlyZooXDEV.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipwreck.connector
{
    internal class DataConnector
    {
        private string connectionString;
        private MySqlConnection connection;
        public DataConnector()
        {
            connectionString = $"server={AppConstants.HOST}; port={AppConstants.PORT}; uid={AppConstants.USER}; " +
                $"pwd={AppConstants.PASSWORD}; database={AppConstants.DATABASE}";
        }

        public bool EstablishConnection()
        {
            connection = new MySqlConnection(connectionString);
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                    MessageBox.Show("ok");
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}