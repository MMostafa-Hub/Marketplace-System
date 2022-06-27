namespace Client_App.Classes
{
	internal class SearchResponse : AbstractResponse
	{
		public List<Product> productList;
		public SearchResponse(List<string> categoryList, List<Product> productList)
		{

			this.productList = productList;
		}

	}
}
