using Client_App.Classes;
using static Client_App.Globals;
namespace Client_App
{
    public partial class DashboardForm : Form
    {
        Form adminPage;

        public DashboardForm(Form adminPage)
        {
            InitializeComponent();
            this.adminPage = adminPage;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                clientSocket.write(new DashboardRequest());
            }
            catch (Exception)
            {
                returnForm = this.adminPage;
                connectionForm.Show();
                this.adminPage.Hide();
            }

            DashboardResponse dbResponse = null;
            try
            {
                dbResponse = clientSocket.read<DashboardResponse>(timeout: 5000);
            }
            catch (Exception)
            {
                returnForm = this.adminPage;
                connectionForm.Show();
                this.adminPage.Hide();
            }
            if (dbResponse != null)
            {
                labelNCust.Text = dbResponse.customersCount.ToString();
                labelActiveUsers.Text = dbResponse.activeUsers.ToString();
                labelNOrd.Text = dbResponse.ordersCount.ToString();
                labelDailyPro.Text = dbResponse.dailyProfit.ToString() + " EGP";
            }
        }
    }
}