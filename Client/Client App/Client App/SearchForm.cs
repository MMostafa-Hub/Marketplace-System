using Client_App.Classes;
using static Client_App.Globals;
namespace Client_App
{
	public partial class SearchForm : Form
	{
		SearchResponse srchresponse = null;
		private Form backForm;
		public SearchForm(Form backForm)
		{
			InitializeComponent();
			this.backForm = backForm;
		}

		private void btn_back_Click(object sender, EventArgs e)
		{
			this.Close();
			backForm.Show();
		}

		private void categoryLabel_Click(object sender, EventArgs e)
		{

		}

		private void SearchForm_Load(object sender, EventArgs e)
		{
			Request categoryRequest = new Request();
			categoryRequest.type = "CategoryRequest";

			try
			{
				clientSocket.write(categoryRequest);
			}
			catch (Exception)
			{
				returnForm = this;
				connectionForm.Show();
				this.Hide();

			}

			CategoryResponse cateResponse=null;
			try
			{
				 cateResponse = clientSocket.read<CategoryResponse>(timeout: 100);
			}
			catch (Exception)
			{
				returnForm = this;
				connectionForm.Show();
				this.Hide();
			}
			
			foreach (string category in cateResponse.categoryList)
			{
				categorycombobox.Items.Add(category);
			}
			

			foreach (Product product in cateResponse.productList)
			{
				string s;
				if (product.stockQuantity >= 1)
				{
					s = "Available";
				}
				else
				{
					s = "Out of Stock";
				}

				dynamic [] row = { product.name.ToString(), product.price, s };
				dataGridView1.Rows.Add(row);
			}

			sortcombobox.SelectedIndex = 0;
		}
		
		private void sortcombobox_SelectedIndexChanged(object sender, EventArgs e)
		{
	 	  
		}

		private void searchTxtBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void btn_search_Click(object sender, EventArgs e)
		{
			string searchText = searchTxtBox.Text;
			string categoryText = categorycombobox.SelectedItem.ToString();
			string sortText = sortcombobox.SelectedItem.ToString();
			SearchRequest srequest = new SearchRequest(searchText, categoryText, sortText);

			if (searchText == null && categorycombobox==null)
			{
				MessageBox.Show("Enter a product name and/or a category", "Negative value ", MessageBoxButtons.OK);
			}
			//receving a requestresponse
			try
			{
				clientSocket.write(srequest);
			}
			catch (Exception)
			{
				returnForm = this;
				connectionForm.Show();
				this.Hide();

			}


			try
			{
				SearchResponse srchresponse = clientSocket.read<SearchResponse>(timeout: 100);
			}
			catch (Exception)
			{
				returnForm = this;
				connectionForm.Show();
				this.Hide();
			}	   


			foreach (Product product in srchresponse.productList)
			{
				string s;
				if (product.stockQuantity >= 1)
				{
					s = "Available";
				}
				else
				{
					s = "Out of Stock";
				}
				string[] row = { product.name.ToString(), product.price.ToString(), s };
				dataGridView1.Rows.Add(row);
			}


		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dgv = sender as DataGridView; 
			if (dgv == null) return;
			try 
			{ 
				if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null) 
				{
					dataGridView1.CurrentRow.Selected = true;
					int rowIndex = e.RowIndex; 
					Product selected = srchresponse.productList[rowIndex];
					ProductForm productForm = new ProductForm(selected,this);
					this.Hide();
					productForm.Show();
				} 
			} 
			catch (Exception ex) 
			{
				
			} 
		}
	}
}
