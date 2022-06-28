using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App.Classes
{
    internal class checkOutResponse : AbstractResponse
    {
        public bool flag;
        public checkOutResponse(bool flag)
        {
            this.flag = flag;
        }
    }
}