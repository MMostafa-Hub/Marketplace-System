using Client_App.Classes;
using static Client_App.Globals;
namespace Client_App
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            try
            {
                clientSocket.write(new DashboardRequest());
            }
            catch (Exception)
            {
                returnForm = this;
                connectionForm.Show();
                this.Hide();
            }

            DashboardResponse dbResponse = null;
            try
            {
                dbResponse = clientSocket.read<DashboardResponse>(timeout: 100);
            }
            catch (Exception)
            {
                returnForm = this;
                connectionForm.Show();
                this.Hide();
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