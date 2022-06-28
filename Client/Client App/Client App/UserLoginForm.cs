﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client_App.Classes;
using static Client_App.Globals;

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
            string username = "";
            string password = "";

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                this.label3.Text = "*Enter an username.";
                this.label3.Show();
            }
            else
            {
                username = textBox1.Text;
                this.label3.Hide();
            }
            if (username.Length > 25)
            {
                this.label3.Text = "*Username must be less than 25 character.";
                this.label3.Show();
            }
            else
            {
                this.label3.Hide();
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                this.label4.Text = "*Enter an password.";
                this.label4.Show();
            }
            else
            {
                password = textBox2.Text;
                this.label4.Hide();
            }
            if (password.Length > 25)
            {
                this.label4.Text = "*Password must be less than 25 character.";
                this.label4.Show();
            }
            else
            {
                this.label4.Hide();
            }

            UserLoginRequest request = new UserLoginRequest(username, password);

            try
            {
                clientSocket.write(request);
            }
            catch (Exception)
            {
                returnForm = this;
                connectionForm.Show();
                this.Hide();
            }

            UserLoginResponse response = null;
            try
            {
                response = clientSocket.read<UserLoginResponse>(timeout: 100);
            }
            catch (Exception)
            {
                returnForm = this;
                connectionForm.Show();
                this.Hide();
            }

            if (response.getStatus() == 0)
            {
                label5.Text = "*Username or password is wrong.";
            }
            else if (response.getStatus() == 1)
            {
                label5.Hide();
                HomeForm f = new Client_App.HomeForm();
                f.ShowDialog();
                this.Hide();
                Globals.user = response.getUser();
            }
            else if (response.getStatus() == 420)
            {
                label5.Hide();
                MessageBox.Show("This account is already logged in");
            }
        }

        private void UserLoginForm_Load(object sender, EventArgs e)
        {
            this.label3.Hide();
            this.label4.Hide();
            this.label5.Hide();
        }
    }

}
