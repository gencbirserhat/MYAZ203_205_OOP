using System.Diagnostics;

namespace Week_4
{
	class Program
	{
		static void Main()
		{
			Vehicles vehicles = new Vehicles();
			vehicles.Engine = 5.0;
			vehicles.Model = "Ford";
			vehicles.Price = 500000;
			vehicles.Transmission = "auto";
			vehicles.NumberOfWheel = 4;
			
			Console.WriteLine(vehicles.ToString());

			Car car =	new Car(6,"Volvo", 6, 750000,"auto");
			Trucks trucks = new Trucks(5.0,"Mercedes", 12, 1500000, "manuel");
			Bus bus = new Bus(3.5, "MAN", 6, 250000, "manuel");

            Console.WriteLine(car.ToString());
            Console.WriteLine(bus.ToString());
            Console.WriteLine(trucks.ToString());
        }
	}
}