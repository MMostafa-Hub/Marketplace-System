using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server_App.Classes
{
	internal class DashboardRequest : Request
	{
		public DashboardRequest()
		{
			this.type = "dashboard";
		}
	}
}
