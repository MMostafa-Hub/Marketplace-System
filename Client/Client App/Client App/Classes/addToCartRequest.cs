using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App.Classes
{
    internal class addToCartRequest : Request
    {
        public int productID;
        public int quantity;
    }
}