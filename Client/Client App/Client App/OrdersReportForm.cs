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
    public partial class OrdersReportForm : GenericForm2
    {
        Form adminPage;
        public OrdersReportForm(Form adminPage)
        {
            InitializeComponent();
            this.adminPage = adminPage;
        }

        private void OrdersReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                clientSocket.write(new OrdersReportRequest());
            }
            catch (Exception)
            {
                returnForm = this.adminPage;
                connectionForm.Show();
                this.adminPage.Hide();
                return;
            }

            OrdersReportResponse ordersResponse = null;
            try
            {
                ordersResponse = clientSocket.read<OrdersReportResponse>(timeout: 5000);
            }
            catch (Exception)
            {
                returnForm = this.adminPage;
                connectionForm.Show();
                this.adminPage.Hide();
                return;
            }
            if (ordersResponse != null)
            {
                foreach (DayOrder order in ordersResponse.dayOrders)
                {
                    string[] row = { order.date.Substring(0, 10), order.count.ToString(), order.profit.ToString() };
                    dataGridViewO7.Rows.Add(row);
                }
            }
        }
    }
}