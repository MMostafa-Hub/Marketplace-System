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
        }

        private void ProfileForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                labelUserBalance.Text = user.balance.ToString();

                try

                {

                    clientSocket.write(new ProfileRequest());

                }

                catch (Exception)

                {

                    returnForm = this;

                    connectionForm.Show();

                    this.Hide();
                    return;
                }

                ProfileResponse profileResponse = null;
                try
                {
                    profileResponse = clientSocket.read<ProfileResponse>(timeout: 5000);
                }
                catch (Exception)
                {
                    returnForm = this;
                    connectionForm.Show();
                    this.Hide();
                    return;
                }
                if (profileResponse != null)
                {
                    labelGenderAge.Text = profileResponse.gender.ToString() + " - " + profileResponse.age.ToString();
                    if (profileResponse.ordersHistory.Count == 0)
                    {
                        dataGridViewOH.Visible = false;
                        labelMsg.Visible = true;
                    }
                    else
                    {
                        labelMsg.Visible = false;
                        dataGridViewOH.Visible = true;
                        dataGridViewOH.Rows.Clear();
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
                try
                {
                    clientSocket.write(logoutRequest);
                }
                catch (Exception)
                {

                }
                finally
                {
                    this.Hide();
                    logoutForm.Show();
                    MessageBox.Show("You have logged out successfully", "Logout");
                }
            }
        }
    }
}