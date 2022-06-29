using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client_App.Classes;
using static Client_App.Globals;


namespace Client_App
{
    public partial class DepositForm : Form
    {
		private Form backForm;
        public DepositForm(Form backForm)
        {
            InitializeComponent();
			this.backForm = backForm;

        }

		private void DepositForm_Load(object sender, EventArgs e)
		{
			currentBalance.Text = user.balance.ToString();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			float depositValue;
			if (float.TryParse(depositTextbox.Text, out depositValue))	  
			{	if (depositValue <= 100000 && depositValue >= 1) {
					if (depositValue > 0)
					{
						try
						{
							DepositRequest depositRequest = new DepositRequest(depositValue + user.balance);
							clientSocket.write(depositRequest);
							user.balance += depositValue;

							currentBalance.Text = user.balance.ToString();//new balance
						}
						catch (Exception)
						{
							returnForm = this;
							connectionForm.Show();
							this.Hide();
						}
					}
					else
					{
						MessageBox.Show("Please enter a postive value", "Negative value ", MessageBoxButtons.OK);
					}
				}
				else
				{
					MessageBox.Show("Maximum enter deposit is 100,000", MessageBoxButtons.OK);
				}

			}
			else {
				MessageBox.Show("Please enter a float value", "Wrong datatype",MessageBoxButtons.OK );
			}

		}

		private void depositTextbox_TextChanged(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void backButton_Click(object sender, EventArgs e) 
		{ 
			this.Close();
			backForm.Show();
		}	
	}
}
