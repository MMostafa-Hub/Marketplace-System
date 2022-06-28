using Server_App.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Server_App.Functions
{
    internal class CreateAccount
    {
        public static CreateAccountResponse createAccountHandler(CreateAccountRequest request)
        {
            SqlConnection connection = Globals.getDBConnection();

            SqlDataAdapter adapter = new SqlDataAdapter();
            

            String createAccountUsername = request.getUsername();
            String createAccountPassword = request.getPassword();
            String createAccountGender = request.getGender();
            int createAccountAge = request.getAge();

            String sql = "INSERT INTO users VALUES (" + "'" + createAccountUsername + "'" + "," + "'" + createAccountPassword + "'" + "," + createAccountAge + "," + "'" + createAccountGender + "'" + "," + "0" + "," + "0" + ")";

            SqlCommand command = new SqlCommand(sql, connection);

            try
            {
                adapter.InsertCommand = command;
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch(SqlException e)
            {
                command.Dispose();
                return new CreateAccountResponse(false);
            }
            command.Dispose();
            return new CreateAccountResponse(true);

        }
    }
}
