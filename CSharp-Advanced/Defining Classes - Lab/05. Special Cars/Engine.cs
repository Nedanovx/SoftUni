namespace CarManufacturer
{
    public class Engine
    {

        public Engine(int horspower, double cubicCapacity)
        {
            HorsePower = horspower;
            CubicCapacity = cubicCapacity;
        }

        public int HorsePower { get; set; }

        public double CubicCapacity { get; set; }
    }
}
