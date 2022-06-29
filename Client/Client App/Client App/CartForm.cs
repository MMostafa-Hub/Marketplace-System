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
using  Client_App.Classes;


namespace Client_App
{

    public partial class CartForm : GenericForm
    {
      
        Form rtForm;
        float Total=0;
        public CartForm(Form rtForm)
        {
            InitializeComponent();
            this.rtForm = rtForm;
           
        }

        private void CartForm_Load(object sender, EventArgs e)
        {
            Dictionary<int, Tuple<Product, int>> hashMap = user.cart.products;
            for(int i=0;i<hashMap.Count;i++)
            {
                Tuple<Product, int> tuple= hashMap.ElementAt(i).Value;
                int quantity = tuple.Item2;
                float price = tuple.Item1.price;
                float total_Amount = calculateTotalProce(quantity, price);
                string[] row = { tuple.Item1.id.ToString() ,  tuple.Item1.name , quantity.ToString() , price.ToString() , calculateTotalProce(quantity ,price).ToString()};
                cartView.Rows.Add(row);
                Total += total_Amount;
            }
        }

        float calculateTotalProce( int quantity , float price)
        {
            return quantity * price;
        }

        private void cartView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cartView.Columns[e.ColumnIndex].HeaderText == "Remove")
            {
                if(Globals.user.cart.products.Count == 0)
                {
                    return;
                }
                else
                {
                    int productId = Convert.ToInt32(cartView.Rows[e.RowIndex].Cells["ID_col"].Value);
                    removeFromCartRequest removeRequest = new removeFromCartRequest(productId); // product id
                    clientSocket.write(removeRequest);
                    Globals.user.cart.products.Remove(productId);
                    cartView.Rows.RemoveAt(cartView.CurrentCell.RowIndex);
                    cartView.Refresh();
                }
                
            }
        }

        // this to handle checkout functionality
        private void button4_Click(object sender, EventArgs e)
        {
            if (user.cart.products.Count == 0)
            {
                MessageBox.Show("Cart is empty", "Checkout error", MessageBoxButtons.OK);
                return;
            }
            else if (Globals.user.balance < Total)
            {
                MessageBox.Show("You don't have enough money");
            }
            else
            {
                try {
                    DateTime dateOnly = DateTime.Now;
                    checkOutRequest check = new checkOutRequest(Total, dateOnly);
                    clientSocket.write(check);

                }
                catch (Exception)
                {
                    connectionForm.Show(this);
                    this.Hide();

                }
                try
                {
                  
                    // changed tieout from 100 to 5000 ms 
                    checkOutResponse checkRes = clientSocket.read<checkOutResponse>(5000);
                    if (checkRes.flag ==false)
                    {
                        MessageBox.Show("OPPs, The Quantity of product is not enough");
                    }
                    else
                    {
                        MessageBox.Show("The process is successfully done");
                        Globals.user.balance -= Total;
                        Globals.user.cart.products.Clear();
                        cartView.Rows.Clear();
                    }
                }
                catch (Exception)
                {
                    connectionForm.Show(this);
                    this.Hide();

                }



            }
        }


        private bool isNumeric(string value)
        {
            return value.All(char.IsNumber);
        }

        // this one is for updating the cart

        private void button3_Click(object sender, EventArgs e)
        {
            // loop to take all quantity values to all products in datagrid
            if (user.cart.products.Count == 0)
            {
                MessageBox.Show("Cart is empty", "Update cart error", MessageBoxButtons.OK);
                return;
            }
            Dictionary<int, int> ourMap = new Dictionary<int, int>();


            for (int i = 0; i < cartView.RowCount - 1; i++)
            {
                if (isNumeric(cartView.Rows[i].Cells[2].Value.ToString()))
                {
                    try
                    {
                        if (Convert.ToInt32(cartView.Rows[i].Cells[2].Value.ToString()) == 0)
                        {
                            MessageBox.Show("New value must be greater than 0");
                            return;
                        }
                        else
                        {
                            ourMap.Add(Convert.ToInt32(cartView.Rows[i].Cells[0].Value), Convert.ToInt32(cartView.Rows[i].Cells[2].Value));
                            cartView.Rows[i].Cells[4].Value = Convert.ToInt32(cartView.Rows[i].Cells[3].Value.ToString()) * Convert.ToInt32(cartView.Rows[i].Cells[2].Value.ToString());
                        }
                    }
                    catch(Exception)
                    {
                        MessageBox.Show("Please enter a valid quantity", "Invalid Quantity");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter numeric values in quantity");
                    return;
                }
            }
            try
            {
                updateCartRequest newRequest = new updateCartRequest(ourMap);
                clientSocket.write(newRequest);
                for (int j = 0; j < ourMap.Count; j++)
                {
                    if (ourMap.ElementAt(j).Key == Globals.user.cart.products.ElementAt(j).Key)
                    {
                        Globals.user.cart.products[ourMap.ElementAt(j).Key] = new Tuple<Product, int>(Globals.user.cart.products.ElementAt(j).Value.Item1, ourMap.ElementAt(j).Value);
                    }
                }
                MessageBox.Show("Cart updated successfully");
            }
            catch (Exception)
            {
                connectionForm.Show();
                this.Hide();
            }


        }

        // this one is for the back functionality
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            rtForm.Show();
        }
    }
}
