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
        static DashboardResponse dashboard()
        {
            int customers, activeUsers, ordersCount;
            float dailyProfit;
            DateTime today = DateTime.Now;

            SqlConnection sqlConnection = Globals.getDBConnection();


            SqlCommand command;
            SqlDataReader dataReader;
            String sql;

            //get total customers count
            sql = "SELECT COUNT(id) FROM users";
            command = new SqlCommand(sql, sqlConnection);
            dataReader = command.ExecuteReader();

            customers = dataReader.GetInt32(0);

            dataReader.Close();

            //get active users count
            sql = "SELECT COUNT(id) FROM users WHERE LoggedIn = 1";
            command = new SqlCommand(sql, sqlConnection);
            dataReader = command.ExecuteReader();

            activeUsers = dataReader.GetInt32(0);

            dataReader.Close();

            //get total ordersCount
            sql = "SELECT COUNT(number) FROM orders ";
            command = new SqlCommand(sql, sqlConnection);
            dataReader = command.ExecuteReader();

            ordersCount = dataReader.GetInt32(0);

            dataReader.Close();

            //get daily profit
            sql = "SELECT SUM(p.price * c.quantity) FROM orders AS o, product AS p, contain AS c WHERE o.number = c.order_no AND p.id = c.product_id AND CAST(o.dateCreated AS DATE) = '"+ today.ToString("yyyyMMdd") +"'" ;
            command = new SqlCommand(sql, sqlConnection);
            dataReader = command.ExecuteReader();

            dailyProfit = dataReader.GetInt32(0);

            dataReader.Close();

            DashboardResponse dashboard = new DashboardResponse(customers, activeUsers, ordersCount, dailyProfit);
            return dashboard;
        }
    }
}
