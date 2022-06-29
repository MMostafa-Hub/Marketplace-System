using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_App
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }

        // Admin Login Button
        private void button1_Click(object sender, EventArgs e)
        {
            AdminLoginForm f = new Client_App.AdminLoginForm();
            f.ShowDialog();
            this.Hide();
        }

        // User Login Button
        private void button2_Click(object sender, EventArgs e)
        {
            UserLoginForm f = new Client_App.UserLoginForm();
            this.Hide();
            f.ShowDialog();
        }

        // Create Account Button
        private void button3_Click(object sender, EventArgs e)
        {
            CreateAccountForm f = new Client_App.CreateAccountForm();
            this.Hide();
            f.ShowDialog();
        }

        // Admin Login Pic
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminLoginForm f = new Client_App.AdminLoginForm();
            this.Hide();
            f.ShowDialog();
        }

        /*

// User Login Pic
private void pictureBox2_Click(object sender, EventArgs e)
{
   UserLoginForm f = new Client_App.UserLoginForm();
   f.ShowDialog();
   this.Hide();
}

// Create Account Pic
private void pictureBox3_Click(object sender, EventArgs e)
{
   CreateAccountForm f = new Client_App.CreateAccountForm();
   f.ShowDialog();
   this.Hide();
}
*/

    }
}
