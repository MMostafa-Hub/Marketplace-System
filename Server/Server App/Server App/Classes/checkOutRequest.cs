using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
    internal class checkOutRequest:Request
    {
        public float totalAmount;
        public DateTime date;
        public checkOutRequest(float totalAmount,DateTime date)
        {
            this.totalAmount=totalAmount;
            this.date=date;
            type="checkOut";
        }
    }
}