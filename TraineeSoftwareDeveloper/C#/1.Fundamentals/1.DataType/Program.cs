// DATA TYPES //
using _1.DataType;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Variable\tValue\t\tData Type\t\tMin Value\t\t\tMax Value");

        // 1: VALUE TYPES
        // A variable of a value type contains an instance of the type. 
        // Variables of value types directly contain their data

        // 1.1: SIMPLE TYPES

        // 1.1.1: Signed Integral
        short a = 2;
        Console.WriteLine($"{nameof(a)}\t\t{a}\t\t{a.GetType()}\t\t{short.MinValue}\t\t\t\t{short.MaxValue}");

        int b = 2;
        Console.WriteLine($"{nameof(b)}\t\t{b}\t\t{b.GetType()}\t\t{int.MinValue}\t\t\t{int.MaxValue}");

        long c = 2;
        Console.WriteLine($"{nameof(c)}\t\t{c}\t\t{c.GetType()}\t\t{long.MinValue}\t\t{long.MaxValue}");

        // 1.1.2: Unsigned Integral: byte, ushort, uint, ulong

        // 1.1.3: Unicode Characters
        char d = 'a';
        Console.WriteLine($"{nameof(d)}\t\t{d}\t\t{d.GetType()}");
        //Console.WriteLine($"Variable: {nameof(d)} " +
        //                  $"\tValue: {d}" +
        //                  $"\tData Type: {d.GetType()}\t");

        // 1.1.4: IEEE Binary Floating-Point
        float e = 2.5F;
        Console.WriteLine($"{nameof(e)}\t\t{e}\t\t{e.GetType()}\t\t{float.MinValue}\t\t\t{float.MaxValue}");

        double f = 2.5D; // optional to use D as suffix
        Console.WriteLine($"{nameof(f)}\t\t{f}\t\t{f.GetType()}\t\t{double.MinValue}\t{double.MaxValue}");

        // 1.1.5: High-precision Decimal Floating-Point
        decimal g = 2.5M;
        Console.WriteLine($"{nameof(g)}\t\t{g}\t\t{g.GetType()}\t\t{decimal.MinValue}\t{decimal.MaxValue}");

        // 1.1.6: Boolean
        bool h = true;
        Console.WriteLine($"{nameof(h)}\t\t{h}\t\t{h.GetType()}");

        // 1.2: ENUM TYPES
        // ENUM TYPES - An enum type is a distinct type with named constants.
        // Every enum type has an underlying type, which must be one of the eight integral types.
        // The set of values of an enum type is the same as the set of values of the underlying type.// W
        Season seasonEnum = Season.Spring;

        // By default, the associated constant values of enum members are of type int;
        // they start with zero and increase by one following the definition text order. 
        var i = (Season)0;
        Console.WriteLine($"{nameof(seasonEnum)}\t{seasonEnum}\t\t{seasonEnum.GetType()}");

        //You can explicitly specify any other integral numeric type as an underlying type of an enumeration type.
        //You can also explicitly specify the associated constant values, as the following example shows:
        var j = (Gender)1;


        // 1.3: STRUCT TYPES
        // A structure type (or struct type) is a value type that can encapsulate data and related functionality. 
        var coordsStruct = new Coords(3.5, 3.5);
        //Console.WriteLine(k.ToString());
        Console.WriteLine($"{nameof(coordsStruct)}\t{coordsStruct}\t{coordsStruct.GetType()}");

        // 1.4: NULLABLE VALUE TYPES
        // A nullable value type T? represents all values of its underlying value type T and an additional null value.
        // For example, you can assign any of the following three values to a bool? variable: true, false, or null.
        // An underlying value type T cannot be a nullable value type itself.
        float? pi = 3.14F;
        Console.WriteLine($"{nameof(pi)}\t\t{pi}\t\t{pi.GetType()}");

        bool? flag = null; // Gives Error on print
        if (flag.HasValue)
            Console.WriteLine($"flag is {flag.Value}");

        // Conversion from a nullable value type to an underlying type
        // If you want to assign a value of a nullable value type to a non-nullable value type variable,
        // you might need to specify the value to be assigned in place of null.

        // I. Use the null-coalescing operator ?? to do that
        bool flagNullCoalescing = flag ?? true;

        // II. Use the Nullable<T>.GetValueOrDefault() method
        //bool temp = flag; // Doesn't compile
        //bool flagNummalbleT = (bool)flag;  // Compiles, but throws an exception if flag is null

        // 1.5: TUPLE VALUE TYPES
        // The tuples feature provides concise syntax to group multiple data elements in a lightweight data structure.
        (string, int) person = ("Saba", 23);
        Console.WriteLine($"{nameof(person)}\t\t{person}\t{person.GetType()}");
        //Console.WriteLine($"Name: {person.Item1} \nAge {person.Item2}");

        //(string name, int age) person1 = ("Saba", 23);
        //Console.WriteLine($"Name: {person1.name} \nAge {person1.age}");

        // Tuple Use-case: Method return type
        (int min, int max) FindMinMax(int[] arr) => (arr.Min(), arr.Max());
        int[] array4Tuple = { 10, 29, 38, 47, 56 };
        //Console.WriteLine(FindMinMax(array4Tuple));

        /*
        System.ValueTuple types are value types. System.Tuple types are reference types.
        System.ValueTuple types are mutable. System.Tuple types are immutable.
        Data members of System.ValueTuple types are fields. Data members of System.Tuple types are properties.
         */

        // 2: REFERENCE TYPE
        // Contains a reference to an instance of the type
        // Variables of reference types store references to their data (objects)

        // 2.1: CLASS TYPE
        var personClass = new Person();
        Console.WriteLine($"{nameof(personClass)}\t{personClass.Display()}\t{personClass.GetType()}");

        // 2.2: INTERFACE TYPE
        // An interface defines a contract.
        // Any class or struct that implements that contract must provide an implementation of the members defined in the interface.
        // An interface may define a default implementation for members.
        // It may also define static members in order to provide a single implementation for common functionality.

        // 2.3: ARRAY TYPES

        // Declare a single-dimensional array of 5 integers.
        int[] array1 = new int[5];

        // Declare and set array element values.
        int[] array2 = new int[] { 1, 3, 5, 7, 9 };

        // Alternative syntax.
        int[] array3 = { 1, 2, 3, 4, 5, 6 };
        Console.WriteLine($"{nameof(array3)}\t\t\t\t{array3.GetType()}");
        //Console.WriteLine(array3.Length);
        //Console.WriteLine(array3.Min());
        //Console.WriteLine(array3.Max());
        //Console.WriteLine(array3.Average());
        //Console.WriteLine(array3.Sum());

        // Declare a two dimensional array.
        int[,] multiDimensionalArray1 = new int[2, 3];

        // Declare and set array element values.
        int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        // Declare a jagged array.
        int[][] jaggedArray = new int[6][];

        // Set the values of the first array in the jagged array structure.
        jaggedArray[0] = new int[4] { 1, 2, 3, 4 };

        /*
        A jagged array is an array whose elements are arrays, possibly of different sizes. 
        A jagged array is sometimes called an "array of arrays."
        */
        //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/jagged-arrays

        int[][] jaggedArray1 = new int[][]
        {
        new int[] { 1, 3, 5, 7, 9 },
        new int[] { 0, 2, 4, 6 },
        new int[] { 11, 22 }
        };


        Console.WriteLine(j);
    }
}