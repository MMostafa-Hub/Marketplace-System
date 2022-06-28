﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Client_App.Classes

{
    internal class updateCartRequest : Request
    {
        //Dictionary (Key,Value)
        public Dictionary<int, int> Hashmap = new Dictionary<int, int>();
        public updateCartRequest(Dictionary<int, int> Hashmap)
        {
            this.Hashmap = Hashmap;
            type = "updateCart";
        }
    }
}