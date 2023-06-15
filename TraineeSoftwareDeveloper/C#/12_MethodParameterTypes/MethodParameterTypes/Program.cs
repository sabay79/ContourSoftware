// TYPES OF METHOD PARAMETERS //

Console.WriteLine("Types of Method Parameters");

int a, b, r;

Console.WriteLine("\nValue Parameter");
a = 1; b = 1;
Console.WriteLine($"A : {a} \tB : {b} \t\tSum={ValueParameterMethod(a, b)} \t" +
                  $"After Function:\t" +
                  $"A : {a} \tB : {b}");

Console.WriteLine("\nRef Parameter");
a = 1; b = 1;
Console.WriteLine($"A : {a} \tB : {b} \t\tSum={RefParameterMethod(ref a, b)} \t" +
                  $"After Function:\t" +
                  $"A : {a} \tB : {b}");

Console.WriteLine("\nOut Parameter");
a = 1; b = 1; r = 0;
Console.WriteLine($"A : {a} \tB : {b} \tR : {r} \tSum={OutParameterMethod(a, b, out r)} \t" +
                  $"After Function:\t" +
                  $"A : {a} \tB : {b} \tR : {r}");

Console.WriteLine("\nDefault Parameter");
a = 1;
Console.WriteLine($"A : {a} \tB : - \t\tSum={DefaultParameterMethod(a)} \t" +
                  $"After Function:\t" +
                  $"A : {a} \tB : -");

Console.WriteLine("\nParams Parameter");
a = 1; b = 1;
Console.WriteLine($"A : {a} \tB : {b} \t\tSum={ParamsParameterMethod(a, b)} \t" +
                  $"After Function:\t" +
                  $"A : {a} \tB : {b}");

// 1. Value Parameter
static int ValueParameterMethod(int x, int y)
{
    x += y;
    return x + y;
}
// 2. Ref Parameter
static int RefParameterMethod(ref int x, int y)
{
    x += y;
    return x + y;
}

// 3. Out Parameter
static int OutParameterMethod(int x, int y, out int z)
{
    x += y;
    z = 2 * (x + y);
    return x + y;
}

// 4. Default Parameter
static int DefaultParameterMethod(int x = 1, int y = 2)
{
    x += y;
    return x + y;
}

// 5. Params Parameter
static int ParamsParameterMethod(params int[] values)
{
    values[0] += 1;
    return values.Sum();
}
