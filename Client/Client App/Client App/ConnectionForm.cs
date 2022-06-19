using System.Configuration;
using System.Collections.Specialized;

namespace Client_App
{
    public partial class ConnectionForm : Form
    {
        string serverIP;
        string serverPort;
        public ConnectionForm()
        {
            InitializeComponent();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {

        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            serverIP = ConfigurationManager.AppSettings.Get("IP");
            serverPort = ConfigurationManager.AppSettings.Get("Port");
            IPLabel.Text = "Server IP address set to " + serverIP;
            portLabel.Text = "Server port set to " + serverPort;
            instructionLabel.Text = "To change the values, edit the App.config file and restart the program";
        }
    }
}