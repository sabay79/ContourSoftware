// LINQ - Language Integrated Query //
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/

// Language-Integrated Query (LINQ) is the name for a set of technologies based on the integration of query capabilities directly into the C# language.
// Traditionally, queries against data are expressed as simple strings without type checking at compile time or IntelliSense support. 
// Furthermore, you have to learn a different query language for each type of data source: SQL databases, XML documents, various Web services, and so on. 
// With LINQ, a query is a first-class language construct, just like classes, methods, events. You write queries against strongly typed collections of objects by using language keywords and familiar operators. 
// he LINQ family of technologies provides a consistent query experience for objects (LINQ to Objects), relational databases (LINQ to SQL), and XML (LINQ to XML).
// LINQ queries are based on generic types

// Specify the Data Soource
int[] scores = { 97, 92, 81, 60 };

// Define Query Expression
IEnumerable<int> scoreQuery = from score in scores
                              where score > 70
                              select score;

// Execute the query
foreach (int temp in scoreQuery)
    Console.Write(temp + " ");

// C# Features That Support LINQ //
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

// LINQ and Generic Types (C#) //
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/linq-and-generic-types?source=recommendations

// 1. IEnumerable<T> variables in LINQ Queries
// LINQ query variables are typed as IEnumerable<T> or a derived type such as IQueryable<T>.
// When you see a query variable that is typed as IEnumerable<Customer>, it just means that the query,
// when it is executed, will produce a sequence of zero or more Customer objects.
IEnumerable<Person> personQuery = from p in people
                                  where p.ID != 0
                                  select p;

// 2. Letting the Compiler Handle Generic Type Declarations
// Use 'var' instead of 'IEnumerable<Person>'

// Standard Query Operators Overview (C#) //
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/standard-query-operators-overview

// The standard query operators are the methods that form the LINQ pattern. 
// The standard query operators provide query capabilities including filtering, projection, aggregation, sorting and more.
// There are two sets of LINQ standard query operators:
// - one that operates on objects of type IEnumerable<T>,
// - another that operates on objects of type IQueryable<T>.
// The standard query operators differ in the timing of their execution, depending on whether they return a singleton value or a sequence of values. 

string sentence = "The quick brown fox jumps over the lazy dog";
// Split the strings into individual words to create a collection
string[] words = sentence.Split(' ');

// Using Query Expresson Syntax
var query1 = from word in words
             group word.ToUpper() by words.Length into gr
             orderby gr.Key
             select new { Length = gr.Key, Words = gr };

// Using Method-Based Query Syntax
var query2 = words.
    GroupBy(w => w.Length, w => w.ToUpper()).
    Select(g => new { Length = g.Key, Words = g }).
    OrderBy(o => o.Length);

foreach (var obj in query1)
{
    Console.WriteLine("Words of Length {0}:", obj.Length);
    foreach (string word in obj.Words)
    {
        Console.WriteLine(word);
    }
}
// Execute the query
foreach (var temp in personQuery)
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

