// METHOD OVERLOADING //
// With method overloading, multiple methods can have the same name with different parameters or different type of parameters
// Method overloading is performed within class.
// Method Overriding is a technique that allows the invoking of functions from another class (base class) in the derived class.
// In case of method overloading, parameter must be different.
// Method overloading is the example of compile time polymorphism.

Console.WriteLine("Method Overloading Practice");
Console.WriteLine(MethodOverloading.Sum(2, 3));
Console.WriteLine(MethodOverloading.Sum(2.3, 3.2));
Console.WriteLine(MethodOverloading.Sum(1, 2, 3));

// METHOD OVERRIDING //
// Method Overriding is a technique that allows the invoking of functions from another class (base class) in the derived class.
// Method overriding occurs in two classes that have IS-A (inheritance) relationship.
// Method Overriding is a technique that allows the invoking of functions from another class (base class) in the derived class.
// In case of method overloading, parameter must be different.
// Method overriding is the example of run time polymorphism.

Console.WriteLine("Method Overriding Practice");
MethodOverriding obj = new();
Console.WriteLine(obj.Sum(2, 3));



public static class MethodOverloading
{
    public static int Sum(int x, int y) => x + y;
    public static double Sum(double x, double y) => x + y;
    public static int Sum(int x, int y, int z) => x + y + z;

}

// Static method can't be overrided
public class TestMethod
{
    public virtual int Sum(int x, int y) => x + y;
}

public class MethodOverriding : TestMethod
{
    public override int Sum(int x, int y) => x + y + 10;
}
