using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Server_App.Classes;

namespace Server_App.Functions
{
    internal static class Deposit
    {
        public static void depositBalance(DepositRequest depositRequest)
        {
            SqlConnection connection = Globals.getDBConnection();

            
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql;

            float newBalance = depositRequest.depositValue;

            sql = "UPDATE users SET balance = " + newBalance.ToString() + " WHERE username= "  + '"'+ Globals.client_username + '"';
            SqlCommand command = new SqlCommand(sql, connection);

            //adapter.InsertCommand = new SqlCommand(sql, connection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();

            command.Dispose();
        }
    }
}
