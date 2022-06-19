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
        public static System.Net.Sockets.TcpClient clientSocket = new System.Net.Sockets.TcpClient();
    }
}
