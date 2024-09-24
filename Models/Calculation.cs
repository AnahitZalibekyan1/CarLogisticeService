using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
	public class Calculation : ICalculate
	{
		public double Calculate(CalculationModel calculationModel)
		{
			return calculationModel.CarType.Coefficient * calculationModel.Container.Coefficient * calculationModel.CrushedCar.Coefficient * calculationModel.Direction.Distance * 100;
		}
	}
}
