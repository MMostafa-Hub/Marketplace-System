using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Server_App.Classes;

namespace Server_App.Functions
{
     internal static class Checkout
    {
      /*Name:checkOut
      *Input:checkOutRequest
      *Returns:checkoutResponse(True) if success ,CheckOutResponse(False) if fail
      */
        public static checkOutResponse checkOut(checkOutRequest request)
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
            /*Hashmap to hold Produc ids ,quantity in Cart*/
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
                    dataReader.Close();
                    /*Cant provide as instock quantity is less than quantity user wants*/
                    return new checkOutResponse(false); /*Checkout failure*/
                  }
                 }
                 dataReader.Close();
                 command.Dispose();
              }
              /*On Reaching Here all items are avaiable in stock*/

              /*1-Deduct Total amount from user*/
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
              balance-=request.totalAmount;
              sql = "UPDATE users SET balance = " + request.totalAmount.ToString() + " WHERE username= "  + "'" +username + "'";
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
                  /*Increase sold Items with quantity and decrease instock items with quantity*/
                  sold += quantity;
                  inStock-= quantity;
                  /*Updating each item instock and sold quantity in product Table  */
                  sql = "UPDATE product SET stockQuantity = " + inStock.ToString() + ",soldQuantity=" + sold.ToString() + "where id=" + product_id.ToString();
                  command = new SqlCommand(sql, connection);
                  adapter.InsertCommand = new SqlCommand(sql, connection);
                  adapter.InsertCommand = command;
                  adapter.InsertCommand.ExecuteNonQuery();

                  command.Dispose();
              }

              /*4-Creation of Order for The user and inserting new entry in Order Table*/

              /*Insertion query has dateTime and username (Order no is implicitly inserted by DBMS)*/
              sql = "insert into orders Values("+"'" +(request.date).ToString("MM/dd/yyyy HH:mm:ss")+"'"+  ", '" + username + "')";
              command = new SqlCommand(sql, connection);
              adapter.InsertCommand = command;
              adapter.InsertCommand.ExecuteNonQuery();
              command.Dispose();


              /*retrieve order number to be used in insertion in contain table*/
              sql = "SELECT number FROM orders where user_username='" + username + "'AND dateCreated='"+request.date.ToString("MM/dd/yyyy HH:mm:ss")+"'";
              command = new SqlCommand(sql, connection);
              dataReader = command.ExecuteReader();

              int order_no=0;
              while (dataReader.Read())
              {
                order_no=dataReader.GetInt32(0);
              }
              dataReader.Close();
              command.Dispose();

              /*5-inserting all products of the order into contains Table*/
              for (int i = 0; i < Hashmap.Count(); i++)
              {
                int product_id=Hashmap.ElementAt(i).Key;
                int quantity=Hashmap.ElementAt(i).Value;
                sql = "insert into contain Values("+order_no.ToString()+','+ product_id.ToString()+','+quantity.ToString()+")";
                command = new SqlCommand(sql, connection);
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
                command.Dispose();
              }
              /*6-Remove items from cart*/

              sql = "delete from has_in_cart where user_username='" + username+"'";
              command = new SqlCommand(sql, connection);
              adapter.InsertCommand = command;
               adapter.InsertCommand.ExecuteNonQuery();
              command.Dispose();
                
            }
            return new checkOutResponse(true); /*Success*/
            
        }
    }
}