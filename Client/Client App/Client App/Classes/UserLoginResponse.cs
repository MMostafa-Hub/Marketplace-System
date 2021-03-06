using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client_App.Classes;

namespace Client_App.Classes
{
    internal class UserLoginResponse : AbstractResponse
    {
        public int status;
        public User? user = null;

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
