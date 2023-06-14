// MULTILEVEL INHERITANCE //

Console.WriteLine("Multilevel Inheritance");
Console.WriteLine("-");
A a = new();
a.Check();

Console.WriteLine("-");
B b = new();
b.Check();

Console.WriteLine("-");
C c = new();
c.Check();

Console.WriteLine("-");

public class A
{
    public virtual void Check()
    {
        Console.WriteLine("A");
    }
}

public class B : A
{
    public override void Check()
    {
        base.Check(); // Comment and Check
        Console.WriteLine("B");
    }
}

public class C : B
{
    public override void Check()
    {
        base.Check();
        Console.WriteLine("C");
    }
}