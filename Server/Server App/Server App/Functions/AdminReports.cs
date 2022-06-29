using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server_App.Classes;

namespace Server_App.Functions
{
    internal static class AdminReports
    {
        static List<Product> addProductsToList(SqlDataReader dataReader)
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
        static public DashboardResponse dashboard()
        {
            int customers = 0, activeUsers = 0, ordersCount = 0;
            float dailyProfit = 0;
            DateTime today = DateTime.Now;

            SqlConnection sqlConnection = Globals.getDBConnection();


            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            //get total customers count
            sql = "SELECT COUNT(username) FROM users";
            command = new SqlCommand(sql, sqlConnection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                customers = dataReader.GetInt32(0);
            }

            dataReader.Close();

            //get active users count
            sql = "SELECT COUNT(username) FROM users WHERE LoggedIn = 1";
            command = new SqlCommand(sql, sqlConnection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                activeUsers = dataReader.GetInt32(0);
            }


            dataReader.Close();

            //get total ordersCount
            sql = "SELECT COUNT(number) FROM orders ";
            command = new SqlCommand(sql, sqlConnection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                ordersCount = dataReader.GetInt32(0);
            }

            dataReader.Close();

            //get daily profit
            sql = "SELECT SUM(p.price * c.quantity) FROM orders AS o, product AS p, contain AS c WHERE o.number = c.order_no AND p.id = c.product_id AND CAST(o.dateCreated AS DATE) = '"+ today.ToString("yyyyMMdd") +"'" ;
            command = new SqlCommand(sql, sqlConnection);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                if(dataReader.IsDBNull(0))
                {
                    dailyProfit=0;
                }
                else
                {
                    dailyProfit = (float)(double)dataReader.GetValue(0); ////// bug is here, returns null if no orders were made that day, results in exception
                }
                
                
            }
            

            dataReader.Close();

            DashboardResponse dashboard = new DashboardResponse(customers, activeUsers, ordersCount, dailyProfit);
            return dashboard;
        }
        
        static public OrdersReportResponse orderReport()
        {
            List<DayOrder> orders = new List<DayOrder>();
           

            SqlConnection sqlConnection = Globals.getDBConnection();


            SqlCommand command;
            SqlDataReader dataReader;
            String sql;
            sql = "SELECT COUNT(DISTINCT o.number), SUM(p.price * c.quantity), CAST(o.dateCreated AS DATE) FROM orders AS o, product AS p, contain AS c "+
                  "WHERE o.number = c.order_no AND p.id = c.product_id GROUP BY CAST(o.dateCreated AS DATE)";
            command = new SqlCommand(sql,sqlConnection);    
            dataReader= command.ExecuteReader();
            if (dataReader.HasRows)
            {
                while (dataReader.Read())
                {
                    int count = dataReader.GetInt32(0);
                    float profit = (float)(double)dataReader.GetValue(1);
                    string date = dataReader.GetDateTime(2).ToString();

                    orders.Add(new DayOrder(date, count, profit));
                }
            }
            dataReader.Close();
            command.dispose();

            OrdersReportResponse ordersReport = new OrdersReportResponse(orders);
            return ordersReport;
        }

        static public ProductsReportResponse productReport()
        {
            List<Product> bestSellers = new List<Product>();
            List<Product> outOfStock = new List<Product>();

            SqlConnection sqlConnection = Globals.getDBConnection();


            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            //best sellers
            sql = "SELECT TOP 5 * FROM product ORDER BY soldQuantity";
            command = new SqlCommand(sql, sqlConnection);
            dataReader = command.ExecuteReader();
            bestSellers = addProductsToList(dataReader);
            dataReader.Close();

            //out of stock
            sql = "SELECT * FROM product WHERE stockQuantity < 1";
            command = new SqlCommand(sql, sqlConnection);
            dataReader = command.ExecuteReader();
            outOfStock = addProductsToList(dataReader);
            dataReader.Close();

            ProductsReportResponse report = new ProductsReportResponse(bestSellers, outOfStock);
            return report;
        }
    }
}
