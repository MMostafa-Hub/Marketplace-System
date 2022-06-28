using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client_App.Classes
{
	internal class DepositRequest  :Request
	{
		public float depositValue;
		public DepositRequest(float depValue) {
			depositValue = depValue;
			type = "deposit";
		}
	}
}
