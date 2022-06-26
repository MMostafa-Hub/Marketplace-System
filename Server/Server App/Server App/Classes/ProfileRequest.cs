using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
    internal class ProfileRequest : Request
    {
        public string profileUserName;
        public ProfileRequest(string profileUserName)
        {
            this.profileUserName = profileUserName;
            type = "profile";
        }
    }
}
