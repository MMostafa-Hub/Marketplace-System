using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
    internal class SearchResponse
    {
        
        List<Product> productList;
        public SearchResponse(List<string> categoryList, List<Product> productList)
        {
            
            this.productList = productList;
        }
    }
}
