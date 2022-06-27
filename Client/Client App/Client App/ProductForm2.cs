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
    public partial class ProductForm : GenericForm
    {
       Product pro;
       GenericForm ProForm;

        public ProductForm(Product  pro, GenericForm ProForm)
        {
            InitializeComponent();
            this.pro = pro;
            this.ProForm = ProForm;
        }


        private void BT2_Click(object sender, EventArgs e)
        {
            HomeForm hf = new HomeForm(this);
            this.Close();
            hf.Show();

        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void BT1_Click(object sender, EventArgs e)
         {
             LB2_2.Text = this.pro.id;
             LB3_3.Text = this.pro.name;

            //TB1.Text = this.pro.Quantity;

             LB4_4.Text = this.pro.price;
             LB5_5.Text = this.pro.stockQuantity;



         }

    }
}
