using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App
{
    internal static class Globals
    {
        /* Client Username shared in the thread address space only */
        [ThreadStatic]
        public static string client_username;
    }
}
