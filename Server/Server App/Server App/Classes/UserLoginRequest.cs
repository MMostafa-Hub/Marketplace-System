using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
    internal class UserLoginRequest :Request
    {
        public String username;
        public String password;

        public UserLoginRequest(string username, string password)
        {
            this.username = username;
            this.password = password;

            type = "userLogin";
        }

        public String getUserName()
        {
            return username;
        }

        public String getPassword()
        {
            return password;
        }

    }
}
