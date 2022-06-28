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
        public Product()
        { }
        public Product(int id, string name, string description, string category, float price, int stockQuantity, int soldQuantity)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.category = category;
            this.price = price;
            this.stockQuantity = stockQuantity;
            this.soldQuantity = soldQuantity;
        }
    }
}
