using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Server_App.Classes;

namespace Server_App.Functions
{
    internal class Profile
    {
        public static ProfileResponse profile(ProfileRequest request)
        {
            SqlConnection connection = Globals.getDBConnection();

            String sql = "SELECT users.age, users.gender,orders.number, orders.dateCreated,product.name, contain.quantity FROM ((orders JOIN contain ON orders.number = contain.order_no) JOIN product ON contain.product_id = product.id) JOIN users ON users.username = orders.user_username WHERE users.username =" + "'" + Globals.client_username + "'" + " ORDER BY orders.number";

            SqlCommand command = new SqlCommand(sql, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            //Get age and gender if no orders were placed
            if (!dataReader.HasRows)
            {
                dataReader.Close();
                command.Dispose();

                sql = "Select age, gender FROM users WHERE username = " + "'" + Globals.client_username + "'";

                command = new SqlCommand(sql, connection);

                SqlDataReader dataReaderEmpty = command.ExecuteReader();
                dataReaderEmpty.Read();
                int ageEmpty = (int)dataReaderEmpty.GetValue(0);
                String genderEmpty = dataReaderEmpty.GetString(1);

                dataReaderEmpty.Close();
                command.Dispose();


                return new ProfileResponse(ageEmpty, genderEmpty, new List<Order>());
            }


            Boolean firstIteration = true;
            int age = 0;
            String gender = "";
            int lastOrderNumber = -1;
            List<Order> orderHistory = new List<Order>();
            String dateCreated = "";
            List<Tuple<string, int>> productsInOrder = new List<Tuple<string, int>>();
            while (dataReader.Read())
            {
                if (firstIteration)
                {
                    age = (int)dataReader.GetValue(0);
                    gender = dataReader.GetString(1);
                    lastOrderNumber = (int)dataReader.GetValue(2);
                    dateCreated = dataReader.GetDateTime(3).ToString();
                    firstIteration = false;
                }

                if ((int)dataReader.GetValue(2) != lastOrderNumber)
                {
                    Order order = new Order(dateCreated, productsInOrder);
                    orderHistory.Add(order);
                    lastOrderNumber = (int)dataReader.GetValue(2);
                    productsInOrder = new List<Tuple<string, int>>();
                    dateCreated = dataReader.GetDateTime(3).ToString();
                }
                String productName = dataReader.GetString(4);
                int productQuantity = (int)dataReader.GetValue(5);
                Tuple<String, int> currentProduct = new Tuple<string, int>(productName,productQuantity);
                productsInOrder.Add(currentProduct);

            }
            Order orderOutside = new Order(dateCreated, productsInOrder);
            orderHistory.Add(orderOutside);

            ProfileResponse response = new ProfileResponse(age, gender, orderHistory);

            
            dataReader.Close();
            command.Dispose();
            return response;
        }

    }
}
