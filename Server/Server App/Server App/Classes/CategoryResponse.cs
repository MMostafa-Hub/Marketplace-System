using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
    internal class CategoryResponse : AbstractResponse
    {
        List<string> categoryList;
        List<Product> productList;
        public CategoryResponse(List<string> categoryList, List<Product> productList)
        {
            this.categoryList = categoryList;
            this.productList = productList;
        }
    }
}
