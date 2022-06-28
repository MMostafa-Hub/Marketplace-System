using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App.Classes
{
    internal class UserLoginResponse : Response
    {
        int status;
        User? user = null;

        public UserLoginResponse(int status, User user)
        {
            this.status = status;
            this.user = user;
        }

        public int getStatus()
        {
            return status;
        }

        public User? getUser()
        {
            return user;
        }
    }
}
