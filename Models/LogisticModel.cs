using LogisticService.Data;
using LogisticService.Repositories;
using LogisticService.UserPanel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
	public class LogisticModel
	{
		public LogisticModel(string carType, bool container, bool isCarCrushed, string from, string to)
		{
			CarType = carType;
			Container = container;
			IsCarCrushed = isCarCrushed;
			From = from;
			To = to;
		}

		public string CarType { get; set; }
		public bool Container { get; set; }
		public bool IsCarCrushed { get; set; }
		public string From { get; set; }
		public string To { get; set; }
	}
}
