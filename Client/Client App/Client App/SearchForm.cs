using Client_App.Classes;
namespace Client_App
{
	public partial class SearchForm : Form
	{
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
			clientSocket.write(categoryRequest);

			CategoryResponse cateResponse = clientSocket.read<CategoryResponse>(timeout:100);
			foreach (string category in cateResponse.categoryList)
			{
				categorycombobox.Items.Add(category);
			}

			foreach (Product product in cateResponse.productList) 
			{
				string[] row = { product.name.ToString(), product.price.ToString(), product.stockQuantity.ToString() };
				dataGridView1.Rows.Add(row);
			}

			

			/*List<string> sortBy = new List<string>();
			sortBy.Add("Price");
			sortBy.Add("Latest product");
			sortcombobox.DataSource = sortBy; */

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


		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
