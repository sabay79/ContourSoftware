// LINQ - Language Integrated Query //
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/

// Language-Integrated Query (LINQ) is the name for a set of technologies based on the integration of query capabilities directly into the C# language.
// Traditionally, queries against data are expressed as simple strings without type checking at compile time or IntelliSense support. 
// Furthermore, you have to learn a different query language for each type of data source: SQL databases, XML documents, various Web services, and so on. 
// With LINQ, a query is a first-class language construct, just like classes, methods, events. You write queries against strongly typed collections of objects by using language keywords and familiar operators. 
// he LINQ family of technologies provides a consistent query experience for objects (LINQ to Objects), relational databases (LINQ to SQL), and XML (LINQ to XML).
// LINQ queries are based on generic types

// Standard query operators: Where, Select, GroupBy, Join, Max, and Average

// 1. Specify the Data Soource
int[] scores = { 97, 92, 81, 60 };

// 2. Define Query Expression
IEnumerable<int> scoreQuery = from score in scores
                              where score > 70
                              select score;

// 3. Execute the query
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

/*
 * As a rule when you write LINQ queries, we recommend that you use query syntax whenever possible and method syntax whenever necessary. 
 * There is no semantic or performance difference between the two different forms. 
 * Query expressions are often more readable than equivalent expressions written in method syntax.
 */

foreach (var obj in query1)
{
    Console.WriteLine("Words of Length {0}:", obj.Length);
    foreach (string word in obj.Words)
    {
        Console.WriteLine(word);
    }
}

// Query Syntax and Method Syntax in LINQ (C#) //
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/query-syntax-and-method-syntax-in-linq

int[] numbers = { 5, 10, 15, 20, 25 };
// Query Syntax:
IEnumerable<int> numQuery1 = from num in numbers
                             where num % 2 == 0
                             orderby num
                             select num;
// Method Syntax:
IEnumerable<int> numQuery2 = numbers.Where(num => num % 2 == 0)
    .OrderBy(num => num);

// Execute the query
foreach (var temp in numQuery2)
    Console.Write(temp + " ");

// Query expression basics // 
// https://learn.microsoft.com/en-us/dotnet/csharp/linq/query-expression-basics

// A query expression is a query expressed in query syntax.
// A query is a set of instructions that describes what data to retrieve from a given data source (or sources) and what shape and organization the returned data should have.
// A query is distinct from the results that it produces.
/*
 * From an application's viewpoint, the specific type and structure of the original source data is not important. 
 * The application always sees the source data as an IEnumerable<T> or IQueryable<T> collection. 
 * For example, in LINQ to XML, the source data is made visible as an IEnumerable<XElement>.
 * Given this source sequence, a query may do one of three things:
 */

/* 1.
 * Retrieve a subset of the elements to produce a new sequence without modifying the individual elements. 
 * The query may then sort or group the returned sequence in various ways, as shown in the following example (assume scores is an int[]):
 */
IEnumerable<int> highScoreQuery1 = from score in scores
                                   where score > 70
                                   orderby score descending
                                   select score;
/* 2.
 * Retrieve a sequence of elements as in the previous example but transform them to a new type of object. 
 * For example, a query may retrieve only the last names from certain customer records in a data source. 
 * Or it may retrieve the complete record and then use it to construct another in-memory object type or even XML data before generating the final result sequence. 
 * The following example shows a projection from an int to a string. 
 * Note the new type of highScoresQuery.
 */
IEnumerable<string> highScoreQuery2 = from score in scores
                                      where score > 70
                                      orderby score descending
                                      select $"The score is {score}";
/* 3.
 * Retrieve a singleton value about the source data, such as:
- The number of elements that match a certain condition.
- The element that has the greatest or least value.
- The first element that matches a condition, or the sum of particular values in a specified set of elements. 
For example, the following query returns the number of scores greater than 80 from the scores integer array:
 */
int highScoreCount = (from score in scores
                      where score > 80
                      select score).Count();
// OR - You can also express this by using a new variable to store the concrete result.
// This technique is more readable because it keeps the variable that stores the query separate from the query that stores a result.
IEnumerable<int> highScoreQuery3 = from score in scores
                                   where score > 80
                                   select score;
int highScoreCount1 = highScoreQuery3.Count();
/*
 Query expressions can be compiled to expression trees or to delegates, depending on the type that the query is applied to. 
 IEnumerable<T> queries are compiled to delegates. 
 IQueryable and IQueryable<T> queries are compiled to expression trees.
 */

// Query Variable //
// In above example, highScoreQuery1 is query variable but highScoreQuery3 is not because highScoreQuery3 store results
// In LINQ, a query variable is any variable that stores a query instead of the results of a query. 
// if use any operation which result in storgae of some value, that won't be a query Variable anymore - Count, Max, Min, Sum, ToList .etc

// Explicit and Implicit typing of query variables //
// Use direct type like IEnumerable<T> 
// Implicit - Use var instead of IEnumerable<T> 
// -> expression is compiled as IEnumerable<Customer> or perhaps IQueryable<Customer>

// Starting a query expression //
// A query expression must begin with a from clause.

// Multiple From Clause
var countries = CountrySevice.GetAll();
var cityQuery = from country in countries
                from city in country.Cities
                select city;
foreach (var city in cityQuery)
    Console.WriteLine(city);
// Debug

// Ending a query expression //
// A query expression must end with either a group clause or a select clause.
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
        person.ID = nextID;
        People.Add(person);
        nextID++;
    }
}

public class Country
{
    public int ID { get; set; }
    public string? Name { get; set; }
    public List<string>? Cities { get; set; }
}
public static class CountrySevice
{
    public static List<Country> Countries { get; set; }
    static int nextID = 2;
    static CountrySevice()
    {
        Countries = new List<Country>()
        {
            new Country { ID = 1, Name = "Pakistan", Cities = new List<string> { "Islamabad", "Lahore", "Karachi" } }
        };
    }
    public static List<Country> GetAll() => Countries;
    public static void Add(Country country)
    {
        country.ID = nextID;
        Countries.Add(country);
        nextID++;
    }

}
