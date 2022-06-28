namespace Client_App.Classes
{
	internal class CategoryResponse : AbstractResponse
	{
		public List<string> categoryList = new List<string>();
		public List<Product> productList = new List<Product>();
		public CategoryResponse(List<String> categoryList, List<Product> productList) { 
			this.categoryList = categoryList;
			this.productList = productList;
		}
	}
}
