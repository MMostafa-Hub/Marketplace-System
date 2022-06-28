using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
	internal class DashboardResponse : AbstractResponse
	{
		public int customersCount;
		public int activeUsers;
		public int ordersCount;
		public float dailyProfit;

		public DashboardResponse(int customersCount, int activeUsers, int ordersCount, float dailyProfit)
		{
			this.customersCount = customersCount;
			this.activeUsers = activeUsers;
			this.ordersCount = ordersCount;
			this.dailyProfit = dailyProfit;
		}

	}
}
