using System.Diagnostics;
using Humanizer;

using System.IO;
using System.Collections.Generic;

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
int result = Fibonacci(6);
Console.WriteLine(result);

static int Fibonacci(int n)
{
    // Exercise - Logging and tracing // 
    Debug.WriteLine($"Entering {nameof(Fibonacci)} method");
    Debug.WriteLine($"We're looking for {n}th number");

    int n1 = 0;
    int n2 = 1;
    int sum;

    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;

        Debug.WriteLineIf(sum==1, $"sum is 1, n1 is {n1}, n2 is {n2}");

    }

    //Debug.Assert(n2==5, "The return value is not 5 and it should be");
    return n == 0 ? n1 : n2;
}

// Exercise - Work with the file system //
var someFiles = FindFiles(".vscode");
foreach(var file in someFiles)
    Console.WriteLine(file);

IEnumerable<string> FindFiles(string folderName)
{
    List<string> someFiles = new List<string>();
    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach(var file in foundFiles)
    {
        // The file anme will contain the full path, so only check the end of it
        if(file.EndsWith("launch.json"))
        {
            someFiles.Add(file);
        }
    }
    return someFiles;
}

// Exercise - Work with paths //

// 1. Find all .json files

// Directory.GetCurrentDirectory method to obtain the path for the current directory 
var currentDirectory = Directory.GetCurrentDirectory();

// Path.Combine method to create the full path to the stores directory
var launchDirectory = Path.Combine (currentDirectory, ".vscode");

var launchFiles = FindFiles(launchDirectory);

foreach(var file in launchFiles)
    Console.WriteLine(file);

// 2. Find all .json files
    
foreach (var file in launchFiles)
{
    Console.WriteLine(file);
}
IEnumerable<string> FindFiles1(string folderName)
{
    List<string> someFiles = new List<string>();
    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach(var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        if(extension == ".json")
            someFiles.Add(file);
    }
    return someFiles;
}
