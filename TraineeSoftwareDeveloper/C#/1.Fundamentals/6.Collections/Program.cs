// COLLECTIONS //
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections

internal class Program
{
    private static void Main()
    {
        // There are two ways to group objects: by creating arrays of objects, and by creating collections of objects.
        // Arrays are most useful for creating and working with a fixed number of strongly typed objects.

        // Collections provide a more flexible way to work with groups of objects.
        // Unlike arrays, the group of objects you work with can grow and shrink dynamically as the needs of the application change.

        // A collection is a class, so you must declare an instance of the class before you can add elements to that collection.

        // If your collection contains elements of only one data type, you can use one of the classes in the System.Collections.Generic namespace. 
        // A generic collection enforces type safety so that no other data type can be added to it. When you retrieve an element from a generic collection, you do not have to determine its data type or convert it.

        // Simple Collection - Generic List<T> class

        var seasons = new List<string>();
        seasons.Add("Summer");
        seasons.Add("Winter");

        foreach (var season in seasons)
            Console.WriteLine(season);

        // If the contents of a collection are known in advance, you can use a collection initializer to initialize the collection.
        var seasonsList = new List<string> { "Spring", "Autumn" };

        // Remove an element from the list by specifying
        seasons.Remove("Winter");
        foreach (var season in seasons)
            Console.WriteLine(season);

        // Remove the element by specifying the zero-based index in the list.
        seasonsList.RemoveAt(1);

        // Iterate through list via Lambda Expression
        seasons.ForEach(season => Console.WriteLine(season));

        // For the type of elements in the List<T>, you can also define your own class. 
        var People = new List<Person>()
        {
            new Person() {Id=1, Name="Ayesha"},
            new Person() {Id=2, Name="Nayab"}
        };
        People.Add(new Person() { Id = 3, Name = "Saba" });
        People.ForEach(person => Console.WriteLine(person.Id + "\t" + person.Name));

        // KINDS OF COLLECTIONS //

        // 1. System.Collections.Generic Classes
        // A generic collection is useful when every item in the collection has the same data type.
        // A generic collection enforces strong typing by allowing only the desired data type to be added.

        // Dictionary<TKey,TValue>	
        // Represents a collection of key/value pairs that are organized based on the key.

        // Create a new dictionary of strings, with int keys.
        Dictionary<int, string> person = new();
        person.Add(1, "Saba");
        person.Add(2, "Ayesha");

        // The Add method throws an exception if the new key is already in the dictionary.
        try
        {
            person.Add(1, "Saba");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message.ToString());
        }

        // The Item property is another name for the indexer, so you can omit its name when accessing elements.
        Console.WriteLine("Key = 1, Value = {0}", person[1]);

        // The indexer can be used to change the value associated with a key.
        person[2] = "Nayab";
        Console.WriteLine("Key = 2, Value = {0}", person[2]);

        // If a key does not exist, setting the indexer for that key adds a new key/value pair.
        person[3] = "Ayesha";
        Console.WriteLine("Key = 3, Value = {0}", person[3]);

        // The indexer throws an exception if the requested key is not in the dictionary.
        try
        {
            Console.WriteLine("Key = 4, Value = {0}", person[4]);
        }
        catch (KeyNotFoundException e)
        {
            Console.WriteLine(e.Message.ToString());
        }

        // When a program often has to try keys that turn out not to be in the dictionary,
        // TryGetValue can be a more efficient way to retrieve values.
        string value = "";
        if (person.TryGetValue(1, out value))
        {
            Console.WriteLine("Key = 1, Value = {0}", value);
        }
        else
        {
            Console.WriteLine("Key Not Found");
        }

        // ContainsKey can be used to test keys before inserting them.
        if (!person.ContainsKey(4))
        {
            person.Add(4, "Amna");
            Console.WriteLine("Key = 4, Value = {0}", person[4]);
        }

        // Foreach retrieved elements as KeyValuePair
        Console.WriteLine();
        foreach (KeyValuePair<int, string> kvp in person)
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);

        // To get the keys alone, use the LKeys property.
        Console.Write("\nKeys: ");
        Dictionary<int, string>.KeyCollection keysCollection = person.Keys;
        foreach (int key in keysCollection)
            Console.Write($"{key}   ");

        // To get the values alone, use the Values property.
        Console.Write("\nValues: ");
        Dictionary<int, string>.ValueCollection valueCollection = person.Values;
        foreach (string val in valueCollection)
            Console.Write($"{val}   ");

        /* The elements of the KeyCollection & ValueCollection are strongly typed
        with the type that was specified for dictionary keys & values */

        // Use the Remove method to remove a key/value pair.
        person.Remove(4); // Key Value
        Console.WriteLine();
        foreach (KeyValuePair<int, string> kvp in person)
            Console.WriteLine("Key = {0}, Value = {1}", kvp.Key, kvp.Value);
    }
}

public class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
}