using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes 
{
    internal class CreateAccountRequest : Request
    {
        public String username;
        public String password;
        public String gender;
        public int age;

        public CreateAccountRequest(string username, string password, string gender, int age)
        {
            this.username = username;
            this.password = password;
            this.gender = gender;
            this.age = age;

            type = "createAccount";
        }

        public String getUsername()
        {
            return username;
        }

        public String getPassword()
        {
            return password;
        }
        public String getGender()
        {
            return gender; 
        }
        public int getAge()
        {
            return age;
        }
    }
}
