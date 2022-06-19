using System.Configuration;
using System.Net.Sockets;
using static Client_App.Globals;

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
                clientSocket.Connect(serverIP, Int32.Parse(serverPort));
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
            catch (SocketException)
            {
                MessageBox.Show("Connection failed. Please check the server is running on the set IP and ports", 
                    "Connection Error", MessageBoxButtons.OK);
                connectButton.Enabled = true;
            }
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            connectionForm = this;
            serverIP = ConfigurationManager.AppSettings.Get("IP");
            serverPort = ConfigurationManager.AppSettings.Get("Port");
            IPLabel.Text = "Server IP address set to " + serverIP;
            portLabel.Text = "Server port set to " + serverPort;
            instructionLabel.Text = "To change the values, edit the App.config file and restart the program";
            connectButton.Enabled = true;
        }
    }
}