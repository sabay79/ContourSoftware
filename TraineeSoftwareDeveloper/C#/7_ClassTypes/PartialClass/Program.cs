// PARTIAL CLASS //
// Provides ability to implement functionality of a single class into multiple classes/files
// All these files are combined into a single class file when application is compiled
// Partial keyword can also used with Structs & Interfaces

Console.WriteLine("Partial Class Example");

class Student
{
    private string _firtsName;
    private string _lastName;

    public string FirstName
    {
        set { _firtsName = value; }
        get { return _firtsName; }
    }

    public string LastName 
    { 
        get => _lastName; 
        set => _lastName = value; 
    }
}