using System.Diagnostics;

namespace Week_4
{
    public class Vehicles 
    {
        private double _engine;
        public virtual double Engine
        {
            get { return _engine; }
            set
            {
                if (value >= 1.0 && value<=5.0 )
                {
                    _engine = value;
                }
                else
                {
                    _engine = 1.0;  
                }
            }
        }
        public virtual string? Model { get; set; }
        public virtual int NumberOfWheel { get; set; }
        public virtual int Price { get; set; }  
        public virtual string? Transmission { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("Engine Start");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Engine Stop");
        }

        public override string ToString()
        {
            return $"--------------------\n"+
                $"Engine: {Engine}\n" +
                $"Model: {Model}\n" +
                $"Number of wheels: {NumberOfWheel}\n" +
                $"Price: {Price}\n" +
                $"Transmission: {Transmission}\n" +
                $"------------------";
        }
    }
}