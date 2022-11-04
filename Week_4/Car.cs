namespace Week_4
{
    public class Car : Vehicles
	{
		public override int NumberOfWheel => 4;
		public Car()
		{

		}
		public Car(double engine, string model, int numberOfWheel, int price, string transmission)
		{
			Engine = engine;
			Model = model;
			_ = numberOfWheel;
			Price = price;
			Transmission = transmission;
		}
	}
}