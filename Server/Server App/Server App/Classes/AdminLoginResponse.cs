using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
    internal class AdminLoginResponse : AbstractResponse
    {
        public int status;

        public AdminLoginResponse(int status)
        {
            this.status = status;
        }
    }
}
