using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App.Classes
{
    internal class ProfileResponse : AbstractResponse
    {
        int age;
        string gender;
        List<Order> ordersHistory;
        public ProfileResponse(int age, string gender, List<Order> ordersHistory)
        {
            this.age = age;
            this.gender = gender;
            this.ordersHistory = ordersHistory;
        }
    }
}