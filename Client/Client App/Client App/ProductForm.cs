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
    public partial class ProductForm : Form
    {
        int key, a = 0;
        Product product;
        Form returnForm;
        public ProductForm(Product product, Form returnForm)
        {
            InitializeComponent();
            this.product = product;
            this.returnForm = returnForm;
            
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void BT2_Click(object sender, EventArgs e)
        {
           
            this.Close();
            returnForm.Show();
                }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LB3.Text = product.id.ToString();
            LB5.Text = product.name;
            LB7.Text = product.category;
            LB10.Text = product.stockQuantity.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Quant = textBox1.Text;
         
            if (Quant == "")
            {
                MessageBox.Show("Please Enter a Quantity");
                return;
            }
            else if (a == 1 && Quant != "0")

            {
                MessageBox.Show("Please Enter a Quantity as a number ");
                return;
            }

            else if (a == 0)

            {
                key = Convert.ToInt32(Quant);
                if (key <= 0 || key > product.stockQuantity+Globals.user.cart.products[product.id].Item2 )
                {
                    if (Globals.user.cart.products.ContainsKey(product.id))
                    {
                        MessageBox.Show("Please Enter a Quantity number between (1 and " + product.stockQuantity + ")");
                        return;
                    }
                    else
                    {//edited
                        MessageBox.Show("You have entered a Quantity number of ("+ key+" and the Quantity in the cart is "+
                            Globals.user.cart.products[product.id].Item2 + ",and you wii exceed the max limit of Quantity , " +
                            "so please Enter a value between 1 and "+(product.stockQuantity - Globals.user.cart.products[product.id].Item2) + ")");
                        return;
                    }

                }
                else
                {

                    MessageBox.Show("Product is added Successfully");
                }
            }
            

            if (Globals.user.cart.products.ContainsKey(product.id))
            {
                Tuple<Product, int> newTuple = new Tuple<Product, int>(product, Globals.user.cart.products[product.id].Item2 + key);
                Globals.user.cart.products[product.id]  = newTuple;
                if (newTuple.Item2 > product.soldQuantity)
                {
                    MessageBox.Show("The Quantity Exceeded The limits");
                    return;
                }

                try
                {
                    Dictionary<int, int> hmap = new Dictionary<int, int>();
                    hmap.Add(product.id,key);
                    /*Waiting for completion*/
                    updateCartRequest updateToCartReq = new updateCartRequest(hmap);
                    clientSocket.write(updateToCartReq);

                    MessageBox.Show("Your product is successfully added");
                    return;

                }
                catch (Exception)
                {
                    connectionForm.Show(this);
                    this.Hide();

                }
            }
            else {

                try
                {
                    /*Waiting for completion*/
                    addToCartRequest addToCartReq = new addToCartRequest(product.id, key);
                    clientSocket.write(addToCartReq);
                    MessageBox.Show("Your product is successfully added");


                }
                catch (Exception)
                {
                    connectionForm.Show(this);
                    this.Hide();

                }
            }



            }
        }
    }

