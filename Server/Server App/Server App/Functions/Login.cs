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


            

            String adminSelect = "SELECT username, password, FROM admin WHERE username = " + "'" + request.getUsername() + "'";

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
    }
}