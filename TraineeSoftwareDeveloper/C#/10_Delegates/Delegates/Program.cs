// DELEGATES //
// Enacapsulates Methods
// A delegate is a type that represents references to methods with a particular parameter list and return type.
// When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type. 
// You can invoke (or call) the method through the delegate instance.

// Delegates are used to pass methods as arguments to other methods.
// Event handlers are nothing more than methods that are invoked through delegates.
// You create a custom method, and a class such as a windows control can call your method when a certain event occurs. 

// Points to one or more methods through one delegate
// Points to both Parameterized % Non-Parameterized Methods (signature(parameters) & return type should be same)
// Delegate has no Implementation/body

// Using delegates, you can call any method which is identified at run-time

public delegate void Calculation(int a, int b);
public delegate void Calculation2(int x);
public delegate void Dummy();

// SINGLE CAST DELEGATE //
// Single cast delegate point to single method ata a time
// Delegate is assigned to single method at a time
// Reference of one method at a time

// MULTI CAST DELEGATE //
// When a delegate is wrapped with more than one method that is known as a multicast delegate
// In C#, delegates are multicast, which mean they can point to more than one function at a time
// += and -= are used to implement multicast delegates
// Refernce of more than one method at a time

class Program
{
    public static void Addition(int a, int b) => Console.WriteLine($"Addition Result is : {a + b}");
    public static void Subtraction(int a, int b) => Console.WriteLine($"Subtraction Result is : {a - b}");
    public static void Product(int a, int b) => Console.WriteLine($"Product Result is : {a * b}");
    public static void Divide(int a, int b) => Console.WriteLine($"Divide Result is : {a / b}");
    public static void Remainder(int a, int b) => Console.WriteLine($"Remainder Result is : {a % b}");

    public static void Square(int x) => Console.WriteLine($"Square of {x} is : {x * x}");
    public static void Cube(int x) => Console.WriteLine($"Cube of {x} is : {x * x * x}");

    public static void DummyMethod() => Console.WriteLine("This is a no-parameterized Dummy Method.");

    private static void Main()
    {
        Console.WriteLine("Delegates Practice\n");

        Calculation obj = new(Program.Addition);
        obj.Invoke(10, 20);

        obj = Subtraction;
        obj(20, 10);    // Alternate for Invoke()

        obj = Product;
        obj(20, 10);

        // Can create multiple objects as well
        Calculation obj1 = new(Program.Divide);
        obj1(20, 10);

        obj1 = Remainder;
        obj1(20, 10);

        Calculation2 obj3 = new(Square);
        obj3.Invoke(2);

        // Can point to multiple methods as well
        obj3 = Cube;
        obj3(3);

        Dummy obj4 = new(DummyMethod);
        obj4();

        // Multicast Delegate
        // += add refernce, -= remove reference
        Calculation obj5 = new Calculation(Addition);
        obj += Subtraction;
        obj -= Product;
        obj += Divide;
        obj.Invoke(20, 10);
    }
}

