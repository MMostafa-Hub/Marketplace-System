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
    public partial class HomeForm : GenericForm
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            ProfileForm profileForm = new ProfileForm(this);
            this.Hide();
            profileForm.Show();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            DepositForm depositForm = new DepositForm(this);
            depositForm.Show();
            this.Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(this);
            searchForm.Show();
            this.Hide();
        }

        private void cartButton_Click(object sender, EventArgs e)
        {
            /*Waiting For completion*/

            CartForm cartForm = new CartForm(this);
            cartForm.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
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
