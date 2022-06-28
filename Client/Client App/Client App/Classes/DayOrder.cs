using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App.Classes
{
	internal class DayOrder
	{
		public string date;
		public int count;
		public float profit;

		public DayOrder(string date, int count, float profit)
		{
			this.date = date;
			this.count = count;
			this.profit = profit;
		}
	}
}