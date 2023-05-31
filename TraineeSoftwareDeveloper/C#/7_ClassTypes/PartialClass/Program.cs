// PARTIAL CLASS //
// Provides ability to implement functionality of a single class into multiple files (in same namespace)
// All these files are combined into a single class file when application is compiled
// All parts must have same accessibility, such as public, private, and so on.
// Partial keyword can also used with Structs & Interfaces
// multiple developers can work on single class in seperate files 

using PartialClass;

Console.WriteLine("Partial Class Example");

StudentPartial obj = new()
{
    FirstName = "Saba",
    LastName = "Yashfeen"
};

Console.WriteLine(obj.GetFullName());