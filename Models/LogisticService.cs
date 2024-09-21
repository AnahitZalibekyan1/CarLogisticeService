using LogisticService.Data;
using LogisticService.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogisticService.Models
{
    internal class LogisticService /*: ILogisticService*/
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

        //public double GetPrice(LogisticModel logisticModel)
        //{
        //    var ct = _carType.FindByKey(logisticModel.carType);
        //    var cont = _container.FindByKey(logisticModel.container);
        //    var crushedcar = _crushedCar.FindByKey(logisticModel.isCarCrushed);
        //    var direction = _direction.FindById(logisticModel.from, logisticModel.to);
        //    return _calculate.Calculate(logisticModel.carType, logisticModel.container,
        //        logisticModel.isCarCrushed, );
        //}
    }
}
