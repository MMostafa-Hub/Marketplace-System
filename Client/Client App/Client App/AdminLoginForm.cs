using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Client_App.Globals;
using Client_App.Classes;

namespace Client_App
{
    public partial class AdminLoginForm : GenericForm2
    {
        public AdminLoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter a username");
                return;
            }
            else
            {
                username = textBox1.Text;
            }


            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Enter a password");
                return;
            }
            else
            {
                password = textBox2.Text;
            }

            AdminLoginRequest request = new AdminLoginRequest(username, password);

            try
            {
                clientSocket.write(request);
            }
            catch (Exception)
            {
                returnForm = this;
                connectionForm.Show();
                this.Hide();
                return;
            }

            AdminLoginResponse response = null;
            try
            {
                response = clientSocket.read<AdminLoginResponse>(timeout: 5000);
            }
            catch (Exception)
            {
                returnForm = this;
                connectionForm.Show();
                this.Hide();
                return;
            }

            if (response.getStatus() == 0)
            {
                label5.Text = "*Username or password is wrong.";
                this.label5.Show();
            }
            else if (response.getStatus() == 1)
            {
                this.label5.Hide();
                AdminReportForm f = new Client_App.AdminReportForm(request.getUsername());
                this.Hide();
                f.ShowDialog();
            }
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            this.label5.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirstForm f = new Client_App.FirstForm();
            this.Hide();
            f.ShowDialog();
        }
    }
}
