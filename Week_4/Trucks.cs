namespace Week_4
{
    public class Trucks : Vehicles
    {
        private int _numberOfWheel;

        public override int NumberOfWheel
        {
            get { return _numberOfWheel; }
            set
            {
                if (value <= 12)
                {
                    _numberOfWheel = value;
                }
                else
                {
                    throw new Exception("Invalid Value");
                }
            }
        }
            

        public Trucks()
        {

        }
        public Trucks(double engine, string model, int numberOfWheel, int price, string transmission )
        {
            Engine = engine;
            Model = model;
            NumberOfWheel = numberOfWheel;
            Price = price;
            Transmission = transmission;
        }
    }
}