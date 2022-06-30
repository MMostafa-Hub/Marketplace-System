using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Server_App.Classes;
namespace Server_App.Functions
{
    internal class Logout
    {
        public static void LogoutHandler()
        {
            SqlConnection connection = Globals.getDBConnection();
            String sql = "UPDATE users SET loggedIn = 0 WHERE username = " + "'" + Globals.client_username + "'";
            SqlCommand command = new SqlCommand(sql,connection);

            command.ExecuteNonQuery();
            command.Dispose();

            Globals.client_username = "";


        }
        /*Function Used For Server initialization (Usefule if server crashes)
         *Input: NONE
         *Output:NONE
         *Result:Logs out all users when server is started.
         */
        public static void logOutAllHandler()
        {
            SqlConnection connection = Globals.getDBConnection();
            String sql = "UPDATE users SET loggedIn = 0";
            SqlCommand command = new SqlCommand(sql, connection);

            command.ExecuteNonQuery();
            command.Dispose();
        }
    }
}
