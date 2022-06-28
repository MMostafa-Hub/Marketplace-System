using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server_App.Classes;

namespace Server_App.Functions

{
    internal static class Cart_update
    {
        /*Function Name:updateCart
        *Input:updateCartRequest
        *Output:Void
        *Updates has_in_cart Table with all quantities user wants
        */
        public static void updateCart(updateCartRequest request)
        {

            string username=Globals.client_username;
            /*Establishing Connection with Database*/
            SqlConnection connection=Globals.getDBConnection();
            /*Creation of adapter used to execute insert update delete commands*/
            SqlDataAdapter adapter = new SqlDataAdapter(); 
            SqlCommand command;
            Dictionary<int,int>Hashmap=request.Hashmap;
            for (int i = 0; i < Hashmap.Count; i++)
            {
                /*Query To update the Cart*/
                string sql = "UPDATE has_in_cart  set product_id=" + Hashmap.ElementAt(i).Key + ",quantity=" + Hashmap.ElementAt(i).Value + " Where user_username='" + username + "' AND product_id=" + Hashmap.ElementAt(i).Key;
                /*Creating The command that will be executed*/
                command = new SqlCommand(sql, connection);
                /*Exectuion of Insertion int has_in_cart Table containing user_username,productid and quantity*/
                adapter.InsertCommand = new SqlCommand(sql, connection);
                adapter.InsertCommand.ExecuteNonQuery();
                /*closing connection and disposing command for Performance*/
                command.Dispose();
            }
            

        }
    }
        
        
}