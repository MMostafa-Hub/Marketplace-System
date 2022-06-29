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
    public partial class ProductForm : GenericForm
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
           
            this.Hide();
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
                if(int.TryParse(Quant,out int n))
                {
                    key = Convert.ToInt32(Quant);
                }
                else
                {
                    MessageBox.Show("Please enter a positive integer");
                }

                if (product.stockQuantity == 0)
                {
                    MessageBox.Show("There is no available Quantity ");
                    return;
                }

                if (Globals.user.cart.products.ContainsKey(product.id))
                {
                    if (key <= 0 || key + Globals.user.cart.products[product.id].Item2 > product.stockQuantity)
                    {
                        MessageBox.Show("You have entered a Quantity number of (" + key + " and the Quantity in the cart is " +
                            Globals.user.cart.products[product.id].Item2 + ",and you will exceed the Stock Quantity ");
                        return;
                    }

                }

                else
                {
                    if (key <= 0 || key > product.stockQuantity)
                    {
                        MessageBox.Show("Please Enter a Quantity number between(1 and " + product.stockQuantity + ")");
                        return; 
                    }


                }
            }
            

            if (Globals.user.cart.products.ContainsKey(product.id))
            {
              

                try
                {
                    Dictionary<int, int> hmap = new Dictionary<int, int>();
                    hmap.Add(product.id, key + Globals.user.cart.products[product.id].Item2);
                    /*Waiting for completion*/
                    updateCartRequest updateToCartReq = new updateCartRequest(hmap);
                    clientSocket.write(updateToCartReq);

                    Tuple<Product, int> newTuple = new Tuple<Product, int>(product, Globals.user.cart.products[product.id].Item2 + key);
                    Globals.user.cart.products[product.id] = newTuple;

                    MessageBox.Show("Your product is successfully added");
                    return;

                }
                catch (Exception)
                {
                    connectionForm.Show(this);
                    this.Hide();
                    return;
                }
            }
            else {

                try
                {
                    /*Waiting for completion*/
                    addToCartRequest addToCartReq = new addToCartRequest(product.id, key);
                    clientSocket.write(addToCartReq);

                    Tuple<Product, int> newTuple = new Tuple<Product, int>(product, key);
                    Globals.user.cart.products[product.id] = newTuple;

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

