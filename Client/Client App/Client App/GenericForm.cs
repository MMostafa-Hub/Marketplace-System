using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client_App.Classes;
using static Client_App.Globals;

namespace Client_App
{
    internal class GenericForm : Form
    {
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            Request logoutRequest = new Request("logout");
            clientSocket.write(logoutRequest);
            Application.Exit();
        }
    }
}
