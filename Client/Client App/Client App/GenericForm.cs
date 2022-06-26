using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App
{
    internal class GenericForm : Form
    {
        protected override void OnFormClosing(System.Windows.Forms.FormClosingEventArgs e)
        {
            //TODO: send logout request
            Application.Exit();
        }
    }
}
