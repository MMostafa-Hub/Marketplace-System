using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App.Classes
{
	internal class SearchRequest : Request
	{
		public string? searchtxt;
		public string?  categorytxt;
		public string sorttxt;
		public SearchRequest(string searchtxt,string categorytxt,string sorttxt)
		{
			this.searchtxt = searchtxt;
			this.categorytxt = categorytxt;	
			this.sorttxt = sorttxt;	
			this.type = "SearchRequest";
		}
		

	}
}
