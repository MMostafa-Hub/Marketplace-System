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

            
            String userSelect = "SELECT username, password, loggedIn FROM users WHERE username = " + "'" + request.getUserName() + "'";

            SqlCommand command = new SqlCommand(userSelect, connection);

            lock (Globals.loginLock)
            {
                SqlDataReader dataReader = command.ExecuteReader();

                dataReader.Read();

                if (!dataReader.HasRows) //No matching records for the username
                {
                    dataReader.Close();
                    command.Dispose();
                    return new UserLoginResponse(false);
                }

                if (dataReader.GetString(2) == "1") //The user is already logged in
                {
                    dataReader.Close();
                    command.Dispose();
                    return new UserLoginResponse(false);
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
                    return new UserLoginResponse(true);
                }
                else //Non matching password 
                {
                    dataReader.Close();
                    command.Dispose();
                    return new UserLoginResponse(false);
                }
            }

        }
    }
}
