using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server_App.Classes;

namespace Server_App
{
    internal static class Cart_remove
    {
        /*Function_Name:addToCart
        *Input:AddToCartRequest ,username
        *Ouput:Inserts users selection into cart with the quantity specified in request(inserts into table has_in_cart)
        *Function Type:Non-Synchronized
        */
        public static void removefromCart(removeFromCartRequest request, string username)
        { 
            /*Establishing Connection with Database*/
            SqlConnection connection=Globals.getDBConnection();
            /*Creation of adapter used to execute insert update delete commands*/
            SqlDataAdapter adapter = new SqlDataAdapter(); 
            int ID=request.productID;
            /*Creation of string that contains The query*/
            string sql = "delete from has_in_cart where user_username='" + username + "' AND product_id=" + ID.ToString(); 
            /*Creating The command that will be executed*/
            SqlCommand command = new SqlCommand(sql, connection);
            /*Exectuion of Insertion int has_in_cart Table containing user_username,productid and quantity*/
            adapter.InsertCommand = new SqlCommand(sql, connection);
            adapter.InsertCommand.ExecuteNonQuery();
            /*closing connection and disposing command for Performance*/
            command.Dispose();
            connection.Close();
            
        }
       
    }
}
