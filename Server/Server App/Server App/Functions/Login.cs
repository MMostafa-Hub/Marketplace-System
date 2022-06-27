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
        public static UserLoginResponse loginUser(UserLoginRequest request)
        {
            SqlConnection connection = Globals.getDBConnection();


            /*Testing request
            UserLoginRequest viableRequest = new UserLoginRequest("John00", "john456"); //Expected on Console: John00 john456 0 
            UserLoginRequest unviableRequest = new UserLoginRequest("Mohanad", "mohanad"); // Expected on Console: No matching records
            */

            String userSelect = "SELECT username, password, loggedIn FROM users WHERE username = " + "'" + request.getUserName() + "'";

            SqlCommand command = new SqlCommand(userSelect, connection);

            lock (Globals.loginLock)
            {
                SqlDataReader dataReader = command.ExecuteReader();

                dataReader.Read();
                
                
                
                if (!dataReader.HasRows) //No matching records for the username
                {
                    //Testing
                    //Console.WriteLine("No matching records");
                    
                    dataReader.Close();
                    command.Dispose();
                    return new UserLoginResponse(0);
                }
                
                //Testing
                //Console.WriteLine(dataReader.GetString(0) + " " + dataReader.GetString(1) + " " + dataReader.GetBoolean(2));
                
                if (dataReader.GetBoolean(2) == true) //The user is already logged in
                {
                    dataReader.Close();
                    command.Dispose();
                    return new UserLoginResponse(420);
                }
                //Check logic of what precedes what. Check the password is correct then check if the user is logged in.

                if (dataReader.GetString(1) == request.getPassword()) //Matching password for the username 
                {
                    Globals.client_username = dataReader.GetString(0);

                    String loggedInUpdateSql = "UPDATE users SET loggedIn = 1 WHERE username = " + "'" + request.getUserName() + "'";
                    command = new SqlCommand(loggedInUpdateSql, connection);
                    command.ExecuteNonQuery();

                    dataReader.Close();
                    command.Dispose();
                    return new UserLoginResponse(1);
                }
                else //Non matching password 
                {
                    dataReader.Close();
                    command.Dispose();
                    return new UserLoginResponse(0);
                }
            }

        }
    }
}
