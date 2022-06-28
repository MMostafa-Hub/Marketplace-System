using Server_App.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Server_App.Functions
{
    internal class Login
    {
        public static AdminLoginResponse loginAdmin(AdminLoginRequest request)
        {
            SqlConnection connection = Globals.getDBConnection();


            String adminSelect = "SELECT username, password FROM admins WHERE username = " + "'" + request.getUsername() + "'";

            SqlCommand command = new SqlCommand(adminSelect, connection);

            SqlDataReader dataReader = command.ExecuteReader();

            dataReader.Read();



            if (!dataReader.HasRows) //No matching records for the username
            {
                //Testing
                //Console.WriteLine("No matching records");

                dataReader.Close();
                command.Dispose();
                return new AdminLoginResponse(0);
            }




            if (dataReader.GetString(1) == request.getPassword()) //Matching password for the username 
            {


                Globals.client_username = dataReader.GetString(0);


                dataReader.Close();


                command.Dispose();
                return new AdminLoginResponse(1);
            }
            else //Non matching password 
            {
                dataReader.Close();
                command.Dispose();
                return new AdminLoginResponse(0);
            }

        }

        public static UserLoginResponse loginUser(UserLoginRequest request)
        {
            SqlConnection connection = Globals.getDBConnection();
            /*Testing request
            UserLoginRequest viableRequest = new UserLoginRequest("John00", "john456"); //Expected on Console: John00 john456 0 
            UserLoginRequest unviableRequest = new UserLoginRequest("Mohanad", "mohanad"); // Expected on Console: No matching records
            */
            SqlDataAdapter adapter = new SqlDataAdapter();
            String userSelect = "SELECT username, password, loggedIn, balance FROM users WHERE username = " + "'" + request.getUserName() + "'";

            SqlCommand command = new SqlCommand(userSelect, connection);

            lock (Globals.userLoginLock)
            {
                SqlDataReader dataReader = command.ExecuteReader();

                dataReader.Read();



                if (!dataReader.HasRows) //No matching records for the username
                {
                    //Testing
                    //Console.WriteLine("No matching records");

                    dataReader.Close();
                    command.Dispose();
                    return new UserLoginResponse(0, null);
                }

                //Testing
                //Console.WriteLine(dataReader.GetString(0) + " " + dataReader.GetString(1) + " " + dataReader.GetBoolean(2));



                if (dataReader.GetString(1) == request.getPassword()) //Matching password for the username 
                {
                    if (dataReader.GetBoolean(2) == true) //The user is already logged in
                    {
                        dataReader.Close();
                        command.Dispose();
                        return new UserLoginResponse(420, null);
                    }

                    Globals.client_username = dataReader.GetString(0);
                    float userBalance = (float)(double)dataReader.GetValue(3);

                    dataReader.Close();

                    String loggedInUpdateSql = "UPDATE users SET loggedIn = 1 WHERE username = " + "'" + request.getUserName() + "'";
                    command = new SqlCommand(loggedInUpdateSql, connection);
                    adapter.InsertCommand = command;
                    adapter.InsertCommand.ExecuteNonQuery();



                    String cartSql = "SELECT product.id, product.name, product.category, product.description, product.price, product.stockQuantity, product.soldQuantity,has_in_cart.quantity FROM(has_in_cart JOIN users ON has_in_cart.user_username = users.username) JOIN product on has_in_cart.product_id = product.id WHERE users.username = " + "'" + request.getUserName() + "'";
                    command = new SqlCommand(cartSql, connection);
                    dataReader = command.ExecuteReader();

                    Dictionary<int, Tuple<Product, int>> products = new Dictionary<int, Tuple<Product, int>>();
                    while (dataReader.Read())
                    {
                        Product product = new Product((int)dataReader.GetValue(0), dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), (float)(double)dataReader.GetValue(4), (int)dataReader.GetValue(5), (int)dataReader.GetValue(6));
                        //product.id = (int)dataReader.GetValue(0);
                        //product.name = dataReader.GetString(1);
                        //product.category = dataReader.GetString(2);
                        //product.description = dataReader.GetString(3);
                        //product.price = (float)(double)dataReader.GetValue(4);
                        //product.stockQuantity = (int)dataReader.GetValue(5);
                        //product.soldQuantity = (int)dataReader.GetValue(6);

                        products.Add(product.id, new Tuple<Product, int>(product, (int)dataReader.GetValue(7)));
                    }
                    dataReader.Close();

                    User user = new User();
                    user.username = request.getUserName();
                    user.balance = userBalance;

                    Cart cart = new Cart();
                    cart.products = products;

                    user.cart = cart;

                    command.Dispose();
                    return new UserLoginResponse(1, user);
                }
                else //Non matching password 
                {
                    dataReader.Close();
                    command.Dispose();
                    return new UserLoginResponse(0, null);
                }
            }

        }
    }
}