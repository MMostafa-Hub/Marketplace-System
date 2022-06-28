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
        Product product;
        public addToCartRequest (int productID, int quantity)
        {
            this.productID = productID;
            this.quantity = quantity;

            var addToCartReq = new Requests.addToCartRequest(product.id, ProductForm.TB1.text);
            ClientSocket.write(addToCartReq);
        }



    }
}