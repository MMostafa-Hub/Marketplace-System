using Client_App.Classes;
using static Client_App.Globals;
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
    public partial class CreateAccountForm : GenericForm2
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void CreateAccountForm_Load(object sender, EventArgs e)
        {
            label5.Hide();
            label6.Hide();
            label7.Hide();
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Female");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = "";
            String password = "";
            String gender = "";
            int age = 1;

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter a username");
                return;
            }
            else
            {
                username = textBox1.Text;
                this.label5.Hide();
            }
            if (username.Length > 25)
            {
                MessageBox.Show("Username must be less than 25 character");
                return;
            }
            else
            {
                this.label5.Hide();
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Enter an password");
                return;
            }
            else
            {
                password = textBox2.Text;
                this.label6.Hide();
            }
            if (password.Length > 25)
            {
                MessageBox.Show("Password must be less than 25 character");
                return;
            }
            else
            {
                this.label6.Hide();
            }

            if (comboBox1.SelectedItem != null)
            {
                gender = comboBox1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Choose your gender");
                return;
            }

            age = Convert.ToInt32(numericUpDown1.Value);

            CreateAccountRequest request = new CreateAccountRequest(username, password, gender, age);
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

            CreateAccountResponse response = null;
            try
            {
                response = clientSocket.read<CreateAccountResponse>(timeout: 5000);
            }
            catch (Exception)
            {
                returnForm = this;
                connectionForm.Show();
                this.Hide();
                return;
            }

            if(response.getSuccess())
            {
                label5.Hide();
                UserLoginForm f = new Client_App.UserLoginForm();
                this.Hide();
                f.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("This username already exists");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FirstForm f = new Client_App.FirstForm();
            this.Hide();
            f.ShowDialog();

        }
    }
}
