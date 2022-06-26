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
    public partial class AdminReportForm : Form
    {
        private Form logoutForm;
        public AdminReportForm(Form logoutForm)
        {
            InitializeComponent();
            //labelAdmin.Text = username;
            labelTitle.Text = "Dashboard";
            labelTime.Text = DateTime.Now.ToLongTimeString();
            this.pnlFormLoader.Controls.Clear();
            DashboardForm DashBF = new DashboardForm() {Dock=DockStyle.Fill, TopLevel=false, TopMost=true};
            this.pnlFormLoader.Controls.Add(DashBF);
            DashBF.Show();
            this.logoutForm = logoutForm;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Dashboard";
            labelTime.Text = DateTime.Now.ToLongTimeString();
            this.pnlFormLoader.Controls.Clear();
            DashboardForm DashBF= new DashboardForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(DashBF);
            DashBF.Show();
        }

        private void btnProdRep_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Products Report";
            labelTime.Text = DateTime.Now.ToLongTimeString();
            this.pnlFormLoader.Controls.Clear();
            ProductsReportForm ProductsRF = new ProductsReportForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(ProductsRF);
            ProductsRF.Show();
        }

        private void btnUserAct_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Users Activity";
            labelTime.Text = DateTime.Now.ToLongTimeString();
            this.pnlFormLoader.Controls.Clear();
            UsersActivityForm UsersAF = new UsersActivityForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.pnlFormLoader.Controls.Add(UsersAF);
            UsersAF.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to Logout?";
            string title = "Confirm Logout";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                this.Close();
                logoutForm.Show();
            }
            else
            {
                // Do something  
            }
        }
    }
}
