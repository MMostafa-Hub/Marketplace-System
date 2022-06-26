using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
    internal class UserLoginRequest :Request
    {
        String username;
        String password;

        public UserLoginRequest(string username, string password)
        {
            this.username = username;
            this.password = password;

            type = "userLogin";
        }
    }
}
