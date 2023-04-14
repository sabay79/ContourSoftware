// CONSTANTS //

// https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/constants
// Constants are immutable values wich are known at compile time
// Donot change for the life of the program
// Only C# built-in types may be declared as const
// User-defined types including claases, structs, and arrays can't be const - use readonly
// C# does not support const methods, properties, or events.
// Constants must be initialized as they are declared.

const double pi = 3.14;

// Multiple constants of the same type can be declared at the same time
const int Months = 12, Weeks = 52, Days = 365;

//Constants can be marked as public, private, protected, internal, protected internal or private protected.
//These access modifiers define how users of the class can access the constant.

// Constants are accessed as if they were static fields because the value of the constant is the same for all instances of the type.
// You do not use the static keyword to declare them.

Console.WriteLine(Days / Months);