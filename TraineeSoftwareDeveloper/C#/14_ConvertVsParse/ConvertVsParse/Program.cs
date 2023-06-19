// CONVERT VS PARSE //

try
{
    Console.Write("Enter a number: ");
    int temp = int.Parse(Console.ReadLine());
    Console.WriteLine(temp);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    Console.Write("Enter a number: ");
    int temp = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(temp);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    int temp1 = Int32.Parse("1"); // Only take string as input
    Console.WriteLine(temp1);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    int temp2 = Convert.ToInt32(12); // any d-type as input
    Console.WriteLine(temp2);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    object temp3 = "123"; // Error: if other than string
    int temp4 = int.Parse((string)temp3);
    Console.WriteLine(temp4);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

try
{
    object temp3 = 1234;
    int temp5 = Convert.ToInt32(temp3);
    Console.WriteLine(temp5);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}



