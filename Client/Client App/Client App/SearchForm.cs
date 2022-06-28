using Client_App.Classes;
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

			/*try
			{
				clientSocket.write(categoryRequest);
			}
			catch (Exception)
			{
				returnForm = this;
				connectionForm.Show();
				this.Hide();

			}	


			try
			{
				CategoryResponse cateResponse = clientSocket.read<CategoryResponse>(timeout: 100);
			}
			catch (Exception)
			{
				returnForm = this;
				connectionForm.Show();
				this.Hide();
			}
			*/
			CategoryResponse cateResponse = new CategoryResponse();         //added
			cateResponse.categoryList.Add("Electronics"); //added
			cateResponse.categoryList.Add("Math");              //added
			cateResponse.categoryList.Add("PHY");//added
			cateResponse.categoryList.Add("Chemistry");//added


			foreach (string category in cateResponse.categoryList)
			{
				categorycombobox.Items.Add(category);
			}
			//added items start here 
			Product x1 = new Product();
			x1.id = 1;
			x1.name = "lol";
			x1.price = 140;
			x1.soldQuantity = 2;
			x1.stockQuantity = 3;
			x1.description = "new item";
			x1.category = "hah";

			Product x2 = new Product();
			x2.id = 2;
			x2.name = "league";
			x2.price = 240;
			x2.soldQuantity = 2;
			x2.stockQuantity = 3;
			x2.description = "new item";
			x2.category = "hah";

			Product x3 = new Product();
			x3.id = 3;
			x3.name = "l";
			x3.price = 340;
			x3.soldQuantity = 2;
			x3.stockQuantity = 3;
			x3.description = "new item";
			x3.category = "hah";

			Product x4 = new Product();
			x4.id = 4;
			x4.name = "o";
			x4.price = 440;
			x4.soldQuantity = 2;
			x4.stockQuantity = 3;
			x4.description = "new item";
			x4.category = "hah";

			Product x5 = new Product();
			x5.id = 5;
			x5.name = "ol";
			x5.price = 540;
			x5.soldQuantity = 2;
			x5.stockQuantity = 3;
			x5.description = "new item";
			x5.category = "hah";

			cateResponse.productList.Add(x1);
			cateResponse.productList.Add(x4);
			cateResponse.productList.Add(x5);
			cateResponse.productList.Add(x2);
			cateResponse.productList.Add(x3);
			cateResponse.productList.Add(x1);

			//end of added

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
				string[] row = { product.name.ToString(), product.price.ToString(), s };
				dataGridView1.Rows.Add(row);
			}

			sortcombobox.SelectedIndex = 0;
		}
		
		private void sortcombobox_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			string sortType= sortcombobox.Text.ToString();
			if (sortType == "Price")
			{
				if (srchresponse != null)
				{
					srchresponse.productList.Sort();
				}
				else 
				{
							 //new line for commit
				}
			}
			else 
			{
				
			}	 
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
			/*try
			{
				clientSocket.write(SearchRequest);
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
			}	   */

			//added	  start
			

			List<String> catlist = new List<String>();
			List<Product>prodlist= new List<Product>();

			Product x3 = new Product();
			x3.id = 3;
			x3.name = "l";
			x3.price = 340;
			x3.soldQuantity = 2;
			x3.stockQuantity = 3;
			x3.description = "new item";
			x3.category = "hah";

			Product x4 = new Product();
			x4.id = 4;
			x4.name = "o";
			x4.price = 440;
			x4.soldQuantity = 2;
			x4.stockQuantity = 3;
			x4.description = "new item";
			x4.category = "hah";

			Product x5 = new Product();
			x5.id = 5;
			x5.name = "ol";
			x5.price = 540;
			x5.soldQuantity = 2;
			x5.stockQuantity = 3;
			x5.description = "new item";
			x5.category = "hah";

			prodlist.Add(x5);
			prodlist.Add(x4);	
			prodlist.Add(x3);
			prodlist.Add(x5);

			
			 srchresponse = new SearchResponse(catlist,prodlist);


			//end added

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
					// condition--> dgv.CurrentRow.Selected
					 dataGridView1.CurrentRow.Selected = true;
					 int rowIndex = e.RowIndex; 
					//Product selected = srchresponse.productList[rowIndex];
					//ProductForm productForm = new ProductForm(selected,this);
					MessageBox.Show("selected row number " + e.RowIndex, "Negative value ", MessageBoxButtons.OK); 
					this.Hide();
					//productForm.Show();
				} 
			} 
			catch (Exception ex) 
			{
				
			} 
		}
	}
}
