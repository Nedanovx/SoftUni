namespace Cars
{
    public abstract class Car : ICar
    {
        public Car(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; }

        public string Color { get; }

        public void Drive()
        {
            Console.WriteLine("Engine start");
        }
        public void Stop()
        {
            Console.WriteLine("Breaaak!");
        }
    }
}
