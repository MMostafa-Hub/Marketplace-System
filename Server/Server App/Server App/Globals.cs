﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App
{
    internal static class Globals
    {
        private static SqlConnection? dbConnection = null;

        public static SqlConnection getDBConnection()
        {
            if (dbConnection == null)
            {
                string connectionString = "Data Source = (LocalDb)\\Project; Initial Catalog = Parallel; Integrated Security = True";
                dbConnection = new SqlConnection(connectionString);
                dbConnection.Open();
            }
            return dbConnection;
        }
    }
}
