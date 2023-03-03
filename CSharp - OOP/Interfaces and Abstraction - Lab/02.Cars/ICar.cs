namespace Cars
{
    public interface ICar
    {
        string Model { get; }
        string Color { get; }
        public void Drive();

        public void Stop();
        
    }
}
