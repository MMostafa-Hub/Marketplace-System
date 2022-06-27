using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Server_App.Classes;

namespace Server_App
{
     internal static class Checkout
    {
        public static int checkOut(checkOutRequest request,float totalAmount,string date)
        {
          /*Establishing Connection with Database*/
          SqlConnection connection=Globals.getDBConnection();
          /*Stateful server has username*/
          string username=Globals.client_username;
          string sql ="";
          /*Retrieval command utilities*/
          SqlCommand command;
          SqlDataReader dataReader;
          sql = "SELECT balance FROM users where username='" + username + "'";
          command = new SqlCommand(sql, connection);

          dataReader = command.ExecuteReader();
       
          
          


            return 0;
        }
    }
}