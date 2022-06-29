using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App.Classes
{
    internal class CreateAccountRequest : Request
    {
        public string username;
        public string password;
        public string gender;
        public int age;

        public CreateAccountRequest(string username, string password, string gender, int age)
        {
            this.username = username;
            this.password = password;
            this.gender = gender;
            this.age = age;

            type = "createAccount";
        }

        public string getUsername()
        {
            return username;
        }
        public string getPassword()
        {
            return password;
        }
        public string getGender()
        {
            return gender;
        }
        public int getAge()
        {
            return age;
        }
    }
}
