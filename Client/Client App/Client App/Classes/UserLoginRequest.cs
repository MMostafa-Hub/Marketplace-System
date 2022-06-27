using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App.Classes
{
    internal class UserLoginRequest : AbstractRequest
    {
        String username;
        String password;

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
