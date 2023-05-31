// SEALED METHOD // 
// Sealed Method is always an override method of child class
// Sealed Method can't be overrided
// Sealed Method is only available with Method Overriding (override)
// Sealed Method is not available with method hiding (new)
// Normal method can't be sealed

Console.WriteLine("Sealed Method Practice");
C obj = new();
obj.Print();

class A
{
    public virtual void Print()
    {
        Console.WriteLine("Class A");
    }
}
class B : A
{
    // To prevent overriding of overrided method
    public sealed override void Print()
    {
        Console.WriteLine("Class B");
    }
}
class C : B
{
    // Can't ovveride Print() from B bcz it's sealed now
    public new void Print()
    {
        Console.WriteLine("Class C");
    }
}