using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server_App.Classes;

namespace Server_App.Functions
{
    internal class Search
    {
        static CategoryResponse categorySearch()
        {

            SqlConnection sqlConnection = Globals.getDBConnection();


            SqlCommand command;
            SqlDataReader dataReader;
            String sql, output = "";

            List<string> categories = new List<string>();
            List<Product> products = new List<Product>();
           

            sql = "SELECT DISTINCT category FROM Product";
            command = new SqlCommand(sql, sqlConnection);

            dataReader = command.ExecuteReader();


            while (dataReader.Read())
            {
                categories.Add(dataReader.GetString(0));
            }

            dataReader.Close();

            sql = "SELECT id, name, price, stockQuantity FROM Product";
            command = new SqlCommand(sql, sqlConnection);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                int id = int.Parse(dataReader.GetString(0));
                string name = dataReader.GetString(1);
                float price = dataReader.GetFloat(2);
                int stock = int.Parse(dataReader.GetString(3));
                products.Add(new Product( id, name, price, stock));
            }
            CategoryResponse response = new CategoryResponse(categories, products);

            return response;
        }
    }
}
