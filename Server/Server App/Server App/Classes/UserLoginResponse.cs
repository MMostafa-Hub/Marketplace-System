using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
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
    }
}
