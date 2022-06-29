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
    public partial class ProductsReportForm : Form
    {
        Form adminPage;
        public ProductsReportForm(Form adminPage)
        {
            InitializeComponent();
            this.adminPage = adminPage;
        }

        private void ProductsReportForm_Load(object sender, EventArgs e)
        {
            try
            {
                clientSocket.write(new ProductsReportRequest());
            }
            catch (Exception)
            {
                returnForm = this.adminPage;
                connectionForm.Show();
                this.adminPage.Hide();
            }

            ProductsReportResponse productsResponse = null;
            try
            {
                productsResponse = clientSocket.read<ProductsReportResponse>(timeout: 5000);
            }
            catch (Exception)
            {
                returnForm = this.adminPage;
                connectionForm.Show();
                this.adminPage.Hide();
            }
            if (productsResponse != null)
            {
                int index = 1;
                foreach (Product product in productsResponse.bestSellers)
                {
                    string[] row = { index.ToString(), product.name, product.price.ToString(), product.soldQuantity.ToString() };
                    dataGridViewBS.Rows.Add(row);
                    index++;
                }

                index = 1;
                foreach (Product product in productsResponse.outStock)
                {
                    string[] row = { index.ToString(), product.name, product.price.ToString() };
                    dataGridViewOxS.Rows.Add(row);
                    index++;
                }
            }
        }
    }
}