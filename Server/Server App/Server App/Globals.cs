using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App
{
    internal static class Globals
    {
        /* Client Username shared in the thread address space only */
        [ThreadStatic]
        public static string client_username;


        public static readonly object userLoginLock = new object();
                
        private static SqlConnection? dbConnection = null;
        public static SqlConnection getDBConnection()
        {
            if (dbConnection == null)
            {
                string connectionString = "Data Source=(LocalDb)\\Project;Initial Catalog=Parallel;Integrated Security=True";
                dbConnection = new SqlConnection(connectionString);
                dbConnection.Open();
            }
            return dbConnection;
        }
    }
}
