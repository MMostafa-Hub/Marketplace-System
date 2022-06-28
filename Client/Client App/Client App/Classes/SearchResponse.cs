namespace Client_App.Classes
{
	internal class SearchResponse : AbstractResponse
	{
		public List<Product> productList;
		public SearchResponse( List<Product> productList)
		{

			this.productList = productList;
		}

	}
}
