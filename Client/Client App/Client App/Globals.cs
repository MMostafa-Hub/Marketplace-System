using Client_App.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client_App
{
    internal static class Globals
    {
        public static Form connectionForm;
        public static Form returnForm = null;
        public static ClientSocket clientSocket;
        public static User user = null;
        public static Form logoutForm;
    }
}
