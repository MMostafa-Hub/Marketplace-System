using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
    internal class AdminLoginRequest : Request
    {
        String username;
        String password;

        public AdminLoginRequest(string username, string password)
        {
            this.username = username;
            this.password = password;

            type = "adminLogin";
        }

        public String getUsername()
        {
            return username;    
        }
        public String getPassword()
        {
            return password;
        }
    }
}
