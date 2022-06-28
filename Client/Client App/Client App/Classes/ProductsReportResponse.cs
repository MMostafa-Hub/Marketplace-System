using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App.Classes
{
	internal class ProductsReportResponse : AbstractResponse
	{
		public List<Product> bestSellers;
		public List<Product> outStock;

		public ProductsReportResponse(List<Product> bestSellers, List<Product> outStock)
		{
			this.bestSellers = bestSellers;
			this.outStock = outStock;
		}
	}
}