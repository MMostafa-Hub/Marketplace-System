using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App.Classes
{
    internal class CreateAccountResponse : AbstractResponse
    {
        public bool success;

        public CreateAccountResponse(bool success)
        {
            this.success = success;
        }
        public bool getSuccess()
        {
            return success;
        }
    }
}
