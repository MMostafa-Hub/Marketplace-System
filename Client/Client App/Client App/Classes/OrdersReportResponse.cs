using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App.Classes
{
	internal class OrdersReportResponse : AbstractResponse
	{
		public List<DayOrder> dayOrders;

		public OrdersReportResponse(List<DayOrder> dayOrders)
		{
			this.dayOrders = dayOrders;
		}
	}
}