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
            Dictionary<int,int>Hashmap=new Dictionary<int, int>();
            

            /*1-Retrieven all products in cart*/
            sql = "SELECT product_id,quantity FROM has_in_cart where user_username='"+username+"'";
            command = new SqlCommand(sql, connection);

            dataReader = command.ExecuteReader();
           
            while (dataReader.Read())
            {
              Hashmap.Add(dataReader.GetInt32(0),dataReader.GetInt32(1));
            }
            /*Closing data Reader and dropping current command*/
            dataReader.Close();
            command.Dispose();
            lock(Globals.checkOutLock)
            {
              /*Iteration over all items in cart to determine if they are available in stock*/
              for(int i=0;i<Hashmap.Count();i++)
              {
                /*Retrieving Stock Quantity Query*/
                 sql = "SELECT stockQuantity FROM product where id="+(Hashmap.ElementAt(i).Key).ToString();
                 command = new SqlCommand(sql, connection);
                 dataReader=command.ExecuteReader();
                 while(dataReader.Read())
                 {
                  int inStock=dataReader.GetInt32(0);
                  if(inStock<Hashmap.ElementAt(i).Value)
                  {
                    /*Cant provide as instock quantity is less than quantity user wants*/
                    return -1;
                  }
                 }
                 dataReader.Close();
                 command.Dispose();
              }
              /*On Reaching Here all items are avaiable in stock*/

              /*Deduct Total amount from user*/
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
            /*2-Handling users table,we should deduct total amount from user balance(Updating user balance with new amount)*/
            balance-=totalAmount;
            sql = "UPDATE users SET balance = " + totalAmount.ToString() + " WHERE username= "  + "'" +username + "'";
            command = new SqlCommand(sql, connection);
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            /*3-Update Instock and sold columns in DataBase*/
            for (int i = 0; i < Hashmap.Count(); i++)
            {
                int sold=0;
                int inStock=0;
                int quantity = Hashmap.ElementAt(i).Value;
                int product_id = (Hashmap.ElementAt(i).Key);
                sql = "SELECT stockQuantity,soldQuantity FROM product where id=" + product_id.ToString();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                { 
                    inStock= dataReader.GetInt32(0);
                    sold=dataReader.GetInt32(1);
                }
                dataReader.Close();
                command.Dispose();
                sold += quantity;
                inStock-= quantity;
                sql = "UPDATE product SET stockQuantity = " + inStock.ToString() + ",soldQuantity=" + sold.ToString() + "where id=" + product_id.ToString();
                command = new SqlCommand(sql, connection);
                adapter.InsertCommand = new SqlCommand(sql, connection);
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();

                command.Dispose();
            }
            }

            return 0;
        }
     
    }
}