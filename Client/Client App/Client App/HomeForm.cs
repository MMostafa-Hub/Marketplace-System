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
        Form returnForm;
        public HomeForm()
        {
            InitializeComponent();
        }

        public HomeForm(Form returnForm)
        {
            this.returnForm = returnForm;
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
            CartForm cartForm = new CartForm(this);
            cartForm.Show();
            this.Hide();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Request logoutRequest = new Request("logout");
            clientSocket.write(logoutRequest);
            returnForm.Show();
            this.Close();
        }
    }
}
