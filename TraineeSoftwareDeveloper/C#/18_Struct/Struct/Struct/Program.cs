// STRUCT //
Console.WriteLine("Struct");

//Coords coords;
//coords.X = 10.20;
//coords.Y = 20.30;

Coords coords = new(10.20, 20.30);
Console.WriteLine(coords.SumOfCoords());

struct Coords
{
    public double X { get; set; }
    public double Y { get; set; }

    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    public readonly double SumOfCoords() => X + Y;
}