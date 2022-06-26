using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes 
{
    internal class CreateAccountRequest : Request
    {
        String username;
        String password;
        String gender;
        int age;

        public CreateAccountRequest(string username, string password, string gender, int age)
        {
            this.username = username;
            this.password = password;
            this.gender = gender;
            this.age = age;

            type = "createAccount";
        }
    }
}
