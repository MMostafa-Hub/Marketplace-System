using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
    internal abstract class checkOutResponse:AbstractResponse
    {
        public bool flag;
        public checkOutResponse(bool flag)
        {
            this.flag=flag;
        }
    }
}
