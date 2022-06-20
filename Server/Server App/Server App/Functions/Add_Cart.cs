using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server_App.Classes;
namespace Server_App
{
    internal static class Add_Cart
    {
        /*Function_Name:addToCart
        *Input:AddToCartRequest ,username
        *Ouput:Inserts users selection into cart with the quantity specified in request(inserts into table has_in_cart)
        *Function Type:Non-Synchronized
        */
        public static void addToCart(addToCartRequest request, string username)
        { 
            /*Establishing Connection with Database*/
            SqlConnection connection=Globals.getDBConnection();
            /*Creation of adapter used to execute insert update delete commands*/
            SqlDataAdapter adapter = new SqlDataAdapter(); 
            int ID=request.productID;
            int Quantity=request.quantity;
            /*Creation of string that contains The query*/
            string sql="insert into has_in_cart Values('"+username+"',"+ID.ToString()+","+Quantity.ToString()+")";
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
