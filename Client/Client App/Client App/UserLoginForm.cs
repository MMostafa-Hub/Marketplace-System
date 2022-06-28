using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client_App.Classes;

namespace Client_App
{
    public partial class UserLoginForm : Form
    {
        public UserLoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            if (username == null)
            {
                this.label3.Text = "*Enter the username.";
                this.label3.Show();
            }
            string password = textBox2.Text;
            if (username == null)
            {
                this.label4.Text = "*Enter the password.";
                this.label4.Show();
            }
            if (username.Length > 25)
            {
                this.label3.Text = "*invalid username.";
                this.label3.Show();
            }
            if (password.Length > 25)
            {
                this.label4.Text = "*invalid password.";
                this.label4.Show();
            }
            UserLoginRequest request = new UserLoginRequest(username, password);

        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            this.label3.Hide();
            this.label4.Hide();
        }
    }

}
