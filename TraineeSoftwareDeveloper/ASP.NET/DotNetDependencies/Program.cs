using Humanizer;

Console.WriteLine("The developers at Tailwind Traders realize that they're about to put extensive resources into developing apps for the .NET platform. These apps are going to display human-readable data to users, including dates, times, and numbers.\n" +
".NET has the capabilities to do this, but the developers are certain someone has solved this problem. They need a framework. After some searching, they've found Humanizer in the NuGet package registry. It seems to be widely used and promises to meet all of their .NET needs for manipulating and displaying strings, enumerations, dates, times, timespans, numbers, and quantities.\n" +
"At this point, the developers want you to install Humanizer, write a couple of data manipulations, and run them to see if Humanizer delivers on its promise.\n");

static void HumanizerQuantities()
{
    Console.WriteLine("case".ToQuantity(0));
    Console.WriteLine("case".ToQuantity(1));
    Console.WriteLine("case".ToQuantity(5));    
}

static void HumanizerDates()
{
    Console.WriteLine(DateTime.UtcNow.AddHours(-24).Humanize());
    Console.WriteLine(DateTime.UtcNow.AddHours(-2).Humanize());

    Console.WriteLine(TimeSpan.FromDays(1).Humanize());
    Console.WriteLine(TimeSpan.FromDays(16).Humanize());
}

Console.WriteLine("Quantities:");
HumanizerQuantities();

Console.WriteLine("\nDate/Time Manipulation:");
HumanizerDates();


// DotNet Debugging //

//Exercise - Debug with Visual Studio Code
int result = Fibonacci(5);
Console.WriteLine(result);

static int Fibonacci(int n)
{
    int n1 = 0;
    int n2 = 1;
    int sum;

    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }

    return n == 0 ? n1 : n2;
}