using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App.Classes
{
	internal class ProductsReportRequest : Request
	{
		public ProductsReportRequest()
		{
			this.type = "productsReport";
		}
	}
}