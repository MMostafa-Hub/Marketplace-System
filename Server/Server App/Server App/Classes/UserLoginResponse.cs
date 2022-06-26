using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
    internal class UserLoginResponse : AbstractResponse
    {
        bool success;

        public UserLoginResponse(bool success)
        {
            this.success = success;
        }
    }
}
