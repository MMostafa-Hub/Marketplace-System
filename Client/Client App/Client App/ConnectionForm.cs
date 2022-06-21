using System.Configuration;
using System.Net.Sockets;
using static Client_App.Globals;
using Client_App.ClientSocket;

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
            try
            {
                connectButton.Enabled = false;
                clientSocket = new ClientSocket(serverIP, Int32.Parse(serverPort));
                this.Hide();
                if (returnForm == null)
                {
                    Form firstForm = new FirstForm();
                    firstForm.Show();
                }
                else
                {
                    returnForm.Show();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter proper port number", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connectButton.Enabled = true;
            }
            catch (SocketException)
            {
                MessageBox.Show("Connection failed. Please check the server is running on the set IP and ports", 
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connectButton.Enabled = true;
            }
        }

        private void ConnectionForm_Shown(object sender, EventArgs e)
        {
            //If the form is shown due to a connection error in another form
            if (returnForm != null)
            {
                MessageBox.Show("There was an error connecting to the server. Please reconnect again",
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connectionForm = this;
            //Get data from App.config
            ConfigurationManager.RefreshSection("appSettings");
            serverIP = ConfigurationManager.AppSettings.Get("IP");
            serverPort = ConfigurationManager.AppSettings.Get("Port");
            IPLabel.Text = "Server IP address set to " + serverIP;
            portLabel.Text = "Server port set to " + serverPort;
            connectButton.Enabled = true;
        }
    }
}