// DATA TYPES //
using _1.DataType;

Console.WriteLine("Variable\tValue\tData Type\t\tMin Value\t\t\tMax Value");

// 1: VALUE TYPES

// 1.1: Signed Integral
short a = 2;
Console.WriteLine($"{nameof(a)}\t\t{a}\t{a.GetType()}\t\t{short.MinValue}\t\t\t\t{short.MaxValue}");

int b = 2;
Console.WriteLine($"{nameof(b)}\t\t{b}\t{b.GetType()}\t\t{int.MinValue}\t\t\t{int.MaxValue}");

long c = 2;
Console.WriteLine($"{nameof(c)}\t\t{c}\t{c.GetType()}\t\t{long.MinValue}\t\t{long.MaxValue}");

// 1.2: Unsigned Integral: byte, ushort, uint, ulong

// 1.3: Unicode Characters
char d = 'a';
Console.WriteLine($"{nameof(d)}\t\t{d}\t{d.GetType()}");
//Console.WriteLine($"Variable: {nameof(d)} " +
//                  $"\tValue: {d}" +
//                  $"\tData Type: {d.GetType()}\t");

// 1.4: IEEE Binary Floating-Point
float e = 2.5F;
Console.WriteLine($"{nameof(e)}\t\t{e}\t{e.GetType()}\t\t{float.MinValue}\t\t\t{float.MaxValue}");

double f = 2.5D; // optional to use D as suffix
Console.WriteLine($"{nameof(f)}\t\t{f}\t{f.GetType()}\t\t{double.MinValue}\t{double.MaxValue}");

// 1.5: High-precision Decimal Floating-Point
decimal g = 2.5M;
Console.WriteLine($"{nameof(g)}\t\t{g}\t{g.GetType()}\t\t{decimal.MinValue}\t{decimal.MaxValue}");

// 1.6: Boolean
bool  h = true;
Console.WriteLine($"{nameof(h)}\t\t{h}\t{h.GetType()}");

// 2: ENUM TYPES
// ENUM TYPES - An enum type is a distinct type with named constants.
// Every enum type has an underlying type, which must be one of the eight integral types.
// The set of values of an enum type is the same as the set of values of the underlying type.// W
Season season = Season.Spring;

// By default, the associated constant values of enum members are of type int;
// they start with zero and increase by one following the definition text order. 
var i = (Season)0;
Console.WriteLine($"{nameof(season)}\t\t{season}\t{season.GetType()}");

//You can explicitly specify any other integral numeric type as an underlying type of an enumeration type.
//You can also explicitly specify the associated constant values, as the following example shows:
var j = (Gender)1;

// STRUCT TYPES
// A structure type (or struct type) is a value type that can encapsulate data and related functionality. 
var k = new Coords(3.5, 3.5);
Console.WriteLine(k.ToString());











Console.WriteLine(j);