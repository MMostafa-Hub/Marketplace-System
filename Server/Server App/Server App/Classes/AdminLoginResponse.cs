using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
    internal class AdminLoginResponse : AbstractResponse
    {
        bool success;

        public AdminLoginResponse(bool success)
        {
            this.success = success;
        }
    }
}
