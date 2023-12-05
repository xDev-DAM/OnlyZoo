﻿using MySql.Data.MySqlClient;
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
            connection = new MySqlConnection(connectionString);
        }

        public MySqlConnection GetConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return connection;
        }
    }
}