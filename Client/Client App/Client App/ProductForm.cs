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


namespace Client_App
{
    public partial class ProductForm : GenericForm
    {
        Product pro;
       GenericForm ProForm;
        int key = 0;
        int a = 0;

        public ProductForm(Product  pro, GenericForm ProForm)
        {
            InitializeComponent();
            this.pro = pro;
            this.ProForm = ProForm;
        }


        private void BT2_Click(object sender, EventArgs e)
        {
            
            this.Close();
            ProForm.Show();

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



            if (TB1.Text == "")
            {
                MessageBox.Show("Please Enter a Quantity");
            }
            else if (a == 1 && TB1.Text != "0")

            {
                MessageBox.Show("Please Enter a Quantity as a number ");
            }

            else if (a == 0)

            {
                key = Convert.ToInt32(TB1.Text);
                if (key <= 0 || key > 9)
                {
                    MessageBox.Show("Please Enter a Quantity number between (1 and 9)");
                }
                else
                {

                    MessageBox.Show("Product is added Successfully");
                }


            }

        }
            //Problem 1
            private void TB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                a = 1;
                //e.Handled = true;   
            }
            else
            {
                a = 0;
            }
        }

    }
}

