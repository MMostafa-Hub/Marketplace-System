using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
    internal class Order
    {
        public string dateCreated;
        public List<Tuple<string, int>> productsInOrder;

        public Order(string dateCreated, List<Tuple<string, int>> productsInOrder)
        {
            this.dateCreated = dateCreated;
            this.productsInOrder = productsInOrder;
        }
    }
}
