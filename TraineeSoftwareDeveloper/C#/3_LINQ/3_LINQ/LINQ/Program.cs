// LINQ - Language Integrated Query //
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/

// Language-Integrated Query (LINQ) is the name for a set of technologies based on the integration of query capabilities directly into the C# language.
// Traditionally, queries against data are expressed as simple strings without type checking at compile time or IntelliSense support. 
// Furthermore, you have to learn a different query language for each type of data source: SQL databases, XML documents, various Web services, and so on. 
// With LINQ, a query is a first-class language construct, just like classes, methods, events. You write queries against strongly typed collections of objects by using language keywords and familiar operators. 
// he LINQ family of technologies provides a consistent query experience for objects (LINQ to Objects), relational databases (LINQ to SQL), and XML (LINQ to XML).

// Specify the Data Soource
int[] scores = { 97, 92, 81, 60 };

// Define Query Expression
IEnumerable<int> scoreQuery = from score in scores
                              where score > 70
                              select score;

// Execute the query
foreach (int temp in scoreQuery)
    Console.Write(temp + " ");

// C# Features That Support LINQ
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/features-that-support-linq?source=recommendations

string[] stringArray = { "Pakistan", "Saudi Arabia", "Bangladesh", "UAE" };

// 1. Implicitly Typed Variables (var)
var query = from ch in stringArray
            where ch[0] == 'B'
            select ch;

// 2. Object and Collection Initializers
var person = new Person { ID = 3, Name = "Nayab" };
PersonService.Add(person);
var people = PersonService.GetAll();
var peopleQuery = from p in people
        where p.ID > 1
        select p;

// Execute the query
foreach (var temp in peopleQuery)
    Console.Write(temp.Name + " ");



public class Person
{
    public int ID { get; set; }
    public string? Name { get; set; }
}

// Service Class Must be Static
public static class PersonService
{
    public static List<Person> People { get; set; }
    static int nextID = 3;
    static PersonService()
    {
        People = new List<Person>()
        {
        new Person { ID = 1, Name = "Saba" },
        new Person { ID = 2, Name = "Ayesha" }
        };
    }
    public static List<Person> GetAll() => People;
    public static void Add(Person person)
    {
        People.Add(person);
    }
}

