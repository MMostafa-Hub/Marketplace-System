using Client_App.Classes;
using static Client_App.Globals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App
{
    internal class GenericForm2 : Form
    {
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Request logoutRequest = new Request("logout");
                try
                {
                    clientSocket.write(logoutRequest);
                }
                catch (Exception)
                {

                }
                finally
                {
                    Application.Exit();
                }
            }
        }
    }
}
