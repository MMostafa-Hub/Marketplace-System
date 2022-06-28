using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App.Classes
{
    internal class AdminLoginResponse : AbstractResponse
    {
        int status;

        public AdminLoginResponse(int status)
        {
            this.status = status;
        }

        public int getStatus()
        {
            return status;
        }
    }
}
