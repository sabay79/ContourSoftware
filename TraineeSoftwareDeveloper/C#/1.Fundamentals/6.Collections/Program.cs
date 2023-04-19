// COLLECTIONS //
// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/collections

// There are two ways to group objects: by creating arrays of objects, and by creating collections of objects.
// Arrays are most useful for creating and working with a fixed number of strongly typed objects.

// Collections provide a more flexible way to work with groups of objects.
// Unlike arrays, the group of objects you work with can grow and shrink dynamically as the needs of the application change.


// A collection is a class, so you must declare an instance of the class before you can add elements to that collection.

// If your collection contains elements of only one data type, you can use one of the classes in the System.Collections.Generic namespace. 
// A generic collection enforces type safety so that no other data type can be added to it. When you retrieve an element from a generic collection, you do not have to determine its data type or convert it.


// Simple Collection - Generic List<T> class
using System;

var seasons = new List<string>();
seasons.Add("Summer");
seasons.Add("Winter");

foreach(var season in seasons)
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
public class Person
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

