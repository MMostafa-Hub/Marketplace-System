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
            SqlDataAdapter adapter = new SqlDataAdapter();
            List<int>products=new List<int>();
            sql = "SELECT balance FROM users where username='" + username + "'";
            command = new SqlCommand(sql, connection);

            dataReader = command.ExecuteReader();
            float balance=0;
            while (dataReader.Read())
            {
              balance = (float)(double)dataReader.GetValue(0);
            }
            dataReader.Close();
            command.Dispose();
            /*1-Handling users table,we should deduct total amount from user balance(Updating user balance with new amount)*/
            balance-=totalAmount;
            sql = "UPDATE users SET balance = " + totalAmount.ToString() + " WHERE username= "  + "'" +username + "'";
            command = new SqlCommand(sql, connection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();


            /**/


            return 0;
        }
    }
}