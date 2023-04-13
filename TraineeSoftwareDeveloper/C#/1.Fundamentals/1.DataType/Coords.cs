namespace _1.DataType
{
    public struct Coords
    {
        public double x { get; set; }
        public double y { get; set; }
        public Coords(double X, double Y)
        {
            x = X;
            y = Y;
        }
        public override string ToString() => $"({x}, {y})";
    }
}
