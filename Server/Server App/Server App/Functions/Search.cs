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

            sql = "SELECT * FROM Product";
            command = new SqlCommand(sql, sqlConnection);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                int id = (int)dataReader.GetValue(0);
                string name = dataReader.GetString(1);
                string description = dataReader.GetString(2);
                string category = dataReader.GetString(3);
                float price = ((float)(double)dataReader.GetValue(4));
                int stock = (int) dataReader.GetValue(5);
                int sold = (int)dataReader.GetValue(6);
                products.Add(new Product( id, name,description,category, price, stock,sold));
            }
            CategoryResponse response = new CategoryResponse(categories, products);

            return response;
        }

        
    }
}
