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
        static List<Product>  addProductsToList(SqlDataReader dataReader)
        {
            List<Product> products = new List<Product>();
            
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    string name = dataReader.GetString(1);
                    string description = dataReader.GetString(2);
                    string categories = dataReader.GetString(3);
                    float price = ((float)(double)dataReader.GetValue(4));
                    int stock = dataReader.GetInt32(5);
                    int sold = dataReader.GetInt32(6);
                    products.Add(new Product(id, name, description, categories, price, stock, sold));
                }
            }

            
            return products;
        }
        static CategoryResponse categorySearch()
        {

            SqlConnection sqlConnection = Globals.getDBConnection();


            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

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

            products = addProductsToList(dataReader);

            dataReader.Close();

            CategoryResponse response = new CategoryResponse(categories, products);

            return response;
        }

        static SearchResponse search(SearchRequest request)
        {

            List<Product> products = new List<Product>();
            SqlConnection sqlConnection = Globals.getDBConnection();
            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            string? search = request.searchtxt, category = request.categorytxt;
            string sortType = request.sorttxt; 

           // sql = "SELECT DISTINCT category FROM Product";
           // command = new SqlCommand(sql, sqlConnection);

            if (search != null && category != null)
            {
                //to be updated desc or asc
                sql = "SELECT * FROM Product WHERE (category = '" + category + "' AND name LIKE '%" + search + "%') ORDER BY " + sortType;
                command = new SqlCommand(sql, sqlConnection);

                dataReader = command.ExecuteReader();
                products = addProductsToList(dataReader);

                dataReader.Close();
            }
            else if (search == null && category != null)
            {
                sql = "SELECT * FROM Product WHERE category = '" + category + "'  ORDER BY " + sortType;
                command = new SqlCommand(sql, sqlConnection);

                dataReader = command.ExecuteReader();
                products = addProductsToList(dataReader);

                dataReader.Close();
            }
            else if (search != null && category == null)
            {
                sql = "SELECT * FROM Product WHERE (name LIKE '%" + search + "%') ORDER BY " + sortType;
                command = new SqlCommand(sql, sqlConnection);

                dataReader = command.ExecuteReader();
                products = addProductsToList(dataReader);

                dataReader.Close();
            }

            SearchResponse response = new SearchResponse(products);
            return response;
        }

    }
}
