// MULTIPLE INHERITANCE //

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Multiple Inheritance in C#");
        CA cA = new();
        cA.Check();

        CB cB = new();
        cB.Check();

        CC cC = new();
        cC.Check();
    }
}
// Multilevel Inheritance
// 1. Multiple Parents
public class PA { }
public class PB { }

//public class PC : PA, PB { } // Error CS1721  Class 'PC' cannot have multiple base classes: 'PA' and 'PB' // User Interface in this case

// 2. Multiple Childs
public class CA
{
    public virtual void Check()
    {
        Console.WriteLine("Base");
    }
}
public class CB : CA
{
    public override void Check()
    {
        Console.WriteLine("Derived 1");
    }
}
public class CC : CA
{
    public override void Check()
    {
        base.Check();
        Console.WriteLine("Derived 2");
    }
}
