// STATIC CLASS //
// Can only have static properties, members, constructor & methods
// Cannot be Inherited
// Can't be Instantiated (cannnot create object/instance of class using new keyword)


Console.WriteLine("Static Class Example");
Product.Display();

public static class Product
{
    public static int ID;
    public static string Name;
    public static int Price;

    private static int nextID = 1;

    static Product()
    {
        ID = nextID;
        Name = "Piano";
        Price = 10000;
        nextID++;
    }

    public static void Display()
    {
        Console.WriteLine($"Product ID = {ID} \n" +
                          $"Name = {Name} \n" +
                          $"Price = {Price}");
    }
}