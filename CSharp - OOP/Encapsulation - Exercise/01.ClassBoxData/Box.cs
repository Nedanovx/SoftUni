namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box (double lenght, double width, double height)
        {
            Length = lenght;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Length cannot be zero or negative.");
                }
                this.length = value;
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }
               this.width = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }
                this.height = value;
            }
        }
        public double SurfaceArea() => 2 * Length * Width + LateralSurfaceArea();
        public double LateralSurfaceArea() => 2 * Length * Height + 2 * Width * Height;
        
        public double Volume() => Length * Width * Height;

    }
}
