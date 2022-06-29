using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Client_App.Globals;

namespace Client_App
{
    public partial class AdminReportForm : GenericForm2
    {
        public AdminReportForm(string adminName)
        {
            InitializeComponent();
            labelAdmin.Text = adminName;
            labelTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            DashboardForm DashBF = new DashboardForm(this) {Dock=DockStyle.Fill, TopLevel=false, TopMost=true};
            this.pnlFormLoader.Controls.Add(DashBF);
            DashBF.Show();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Dashboard";
            this.pnlFormLoader.Controls.Clear();
            DashboardForm DashBF= new DashboardForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(DashBF);
            DashBF.Show();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnProdRep_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Products Report";
            this.pnlFormLoader.Controls.Clear();
            ProductsReportForm ProductsRF = new ProductsReportForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(ProductsRF);
            ProductsRF.Show();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnUserAct_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Orders Report";
            this.pnlFormLoader.Controls.Clear();
            OrdersReportForm OrdersRF = new OrdersReportForm(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(OrdersRF);
            OrdersRF.Show();
            labelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to Logout?";
            string title = "Confirm Logout";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
                logoutForm.Show();
                MessageBox.Show("You have logged out successfully", "Logout");
            }
        }
    }
}