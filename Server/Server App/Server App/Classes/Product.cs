using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
    internal class Product
    {
        public int id;
        public string name;
        public string category;
        public string description;
        public float price;
        public int stockQuantity;
        public int soldQuantity;
        
        public Product(int id, string name, float price, int stockQuantity)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.stockQuantity = stockQuantity;
        }
    }
}
