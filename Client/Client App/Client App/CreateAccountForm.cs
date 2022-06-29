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
    public partial class CreateAccountForm : Form
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
                this.label5.Text = "*Enter an username.";
                this.label5.Show();
            }
            else
            {
                username = textBox1.Text;
                this.label5.Hide();
            }
            if (username.Length > 25)
            {
                this.label5.Text = "*Username must be less than 25 character.";
                this.label5.Show();
            }
            else
            {
                this.label5.Hide();
            }

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                this.label6.Text = "*Enter an password.";
                this.label6.Show();
            }
            else
            {
                password = textBox2.Text;
                this.label6.Hide();
            }
            if (password.Length > 25)
            {
                this.label6.Text = "*Password must be less than 25 character.";
                this.label6.Show();
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
                label7.Text = "*Choose your gender.";
                label7.Show();
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
            }

            if(response.getSuccess())
            {
                label5.Hide();
                HomeForm f = new Client_App.HomeForm();
                f.ShowDialog();
                this.Hide();
            }
            else
            {
                label5.Text = "*This Username is already exist.";
                label5.Show();
            }
        }
    }
}
