using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
    internal class SearchResponse : AbstractResponse
    {
        
        public List<Product> productList;
        public SearchResponse(List<Product> productList)
        {
            
            this.productList = productList;
        }
    }
}
