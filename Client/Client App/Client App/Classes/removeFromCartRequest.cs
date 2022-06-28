using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App.Classes
{
    internal class removeFromCartRequest : Request
    {
        public int productID;
        public removeFromCartRequest(int productID)
        {
            this.productID = productID;
            type = "removeFromCart";
        }
    }
}