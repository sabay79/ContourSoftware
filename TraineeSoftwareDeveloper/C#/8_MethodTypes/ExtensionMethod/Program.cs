// EXTENSION METHOD, THIS KEYWORD //

Console.WriteLine("Extension Method Practice");
Temp temp = new Temp(4);
Temp temp1 = new Temp(2);

Console.WriteLine(temp.Sum());
Console.WriteLine(temp1.Sum());

public class Temp
{
    public Temp()
    {
        x = 1;
        y = 2;
    }

    //public Temp(int x)
    //{
    //    this.x = x;
    //}

    public Temp(int y) : this()
    {
        this.y = y;
        x += y;
        //Console.WriteLine($"{x+y}");
    }

    public int x { get; set; }
    public int y { get; set; }
}
public static class TempExtension
{
    public static int Sum(this Temp temp) => temp.x + temp.y;
}
