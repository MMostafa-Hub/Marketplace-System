using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client_App.Classes;
using static Client_App.Globals;

namespace Client_App
{
    public class GenericForm : Form
    {
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                string message = "Are you sure you want to exit the program?";
                string title = "Confirm Exit";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
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
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
