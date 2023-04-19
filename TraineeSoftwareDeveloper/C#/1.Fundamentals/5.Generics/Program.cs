// GENERICS //
// https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic?view=net-7.0

// Generics introduces the concept of type parameters to .NET, which make it possible to design classes and methods
// that defer the specification of one or more types
// until the class or method is declared and instantiated by client code.

public class GenericList<T>
{
    public void Add(T input) { }
}

class TestGenericList
{
    public class Person 
    {
        public string? Name { get; set; }
        public int? Age { get; set;}
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    static void Main()
    {
        // Declare a list of type int
        GenericList<int> integerList = new GenericList<int>();
        integerList.Add(1);

        // Decclare a list of type string
        GenericList<string> stringList = new GenericList<string>();
        stringList.Add("Saba");

        // Declare a list of type Person
        GenericList<Person> personList = new GenericList<Person>();
        personList.Add(new Person("Saba", 23));
        personList.Add(new Person("Ayesha", 24));
    }
}