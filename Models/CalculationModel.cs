namespace LogisticService.Models
{
	public class CalculationModel
	{
		public CalculationModel(Direction direction, Container container, CrushedCar crushedCar, CarType carType)
		{
			Direction = direction;
			Container = container;
			CrushedCar = crushedCar;
			CarType = carType;
		}

		public Direction Direction { get; set; }
		public Container Container { get; set; }
		public CrushedCar CrushedCar { get; set; }
		public CarType CarType { get; set; }
	}
}