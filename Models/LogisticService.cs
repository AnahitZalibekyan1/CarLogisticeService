using LogisticService.Data;
using LogisticService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
	internal class LogisticService : ILogisticService
	{
		private readonly Repository<CarType, string, DataContext> _carType;
		private readonly Repository<Container, bool, DataContext> _container;
		private readonly Repository<CrushedCar, bool, DataContext> _crushedCar;
		private readonly Repository<Direction, string, DataContext> _direction;
		private readonly ICalculate _calculate;

		public LogisticService(Repository<CarType, string, DataContext> carType,
			Repository<Container, bool, DataContext> container,
			Repository<CrushedCar, bool, DataContext> crushedCar,
			Repository<Direction, string, DataContext> direction,
			ICalculate calculate)
		{
			_carType = carType;
			_container = container;
			_crushedCar = crushedCar;
			_direction = direction;
			_calculate = calculate;
		}

		public double GetPrice(LogisticModel logisticModel)
		{
			var ct = _carType.FindByKey(logisticModel.CarType);
			var cont = _container.FindByKey(logisticModel.Container);
			var crushedCar = _crushedCar.FindByKey(logisticModel.IsCarCrushed);
			var direction = _direction.FindById(logisticModel.From, logisticModel.To);

			return _calculate.Calculate(new CalculationModel(direction, cont, crushedCar, ct));
		}
	}
}
