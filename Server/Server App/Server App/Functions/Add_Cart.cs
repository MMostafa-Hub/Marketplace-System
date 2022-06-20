using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server_App.Classes;
using Server_App.f

namespace Server_App
{
    internal static class Add_Cart
    {
        public static string addToCart(addToCartRequest request, string username)
        { 
            SqlConnection cn=Globals.getDBConnection();
            SqlDataAdapter adapter =new SqlDataAdapter();
            string sql;
            return "";
        }
       
    }
}
