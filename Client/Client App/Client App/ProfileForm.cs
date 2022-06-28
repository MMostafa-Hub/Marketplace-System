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
using static Client_App.Globals;

namespace Client_App
{
    public partial class ProfileForm : GenericForm
    {
        Form backForm;
        public ProfileForm(Form backForm)
        {
            InitializeComponent();
            this.backForm = backForm;
            labelUserName.Text = user.username;
            labelUserBalance.Text = user.balance.ToString();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            try
            {
                clientSocket.write(new ProfileRequest());
            }
            catch (Exception)
            {
                returnForm = this;
                connectionForm.Show();
                this.Hide();
            }

            ProfileResponse profileResponse = null;
            try
            {
                profileResponse = clientSocket.read<ProfileResponse>(timeout: 100);
            }
            catch (Exception)
            {
                returnForm = this;
                connectionForm.Show();
                this.Hide();
            }
            if (profileResponse != null)
            {
                if (profileResponse.ordersHistory.Count == 0)
                {
                    dataGridViewOH.Visible = false;
                    labelMsg.Visible = true;
                }
                else
                {
                    labelMsg.Visible = false;
                    dataGridViewOH.Visible = true;
                    int index = 1;
                    foreach (Order order in profileResponse.ordersHistory)
                    {
                        string[] row = { index.ToString(), order.dateCreated, "", "" };
                        dataGridViewOH.Rows.Add(row);
                        foreach (Tuple<string, int> tuple in order.productsInOrder)
                        {
                            string[] innerRow = { "", "", tuple.Item1, tuple.Item2.ToString() };
                            dataGridViewOH.Rows.Add(innerRow);
                        }
                        index++;
                    }
                }
            }
        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(this);
            this.Hide();
            depositForm.Show();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            backForm.Show();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to Logout?";
            string title = "Confirm Logout";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                Request logoutRequest = new Request("logout");
                clientSocket.write(logoutRequest);
                this.Hide();
                logoutForm.Show();
                MessageBox.Show("You have logged out successfully", "Logout");
            }
        }
    }
}