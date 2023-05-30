// SEALED CLASS // 
// Prevent Inheritance - can't be Inherited so can't be a base class
// Can be useful in scenarios where you want to prevent further modification or extension of a class to maintain stability, security, or to enforce certain design decisions.
// Difference from static class: we can't create instance of static class but of sealed class 

Console.WriteLine("Sealed Class Example");
//DerivedClass dc = new DerivedClass();
//dc.BaseMethod();

BaseClass bc = new BaseClass();
bc.BaseMethod();

public sealed class BaseClass
{
    public void BaseMethod()
    {
        Console.WriteLine("Method of Base Class");
    }
}
//public class DerivedClass : BaseClass
//{
//    public void DerivedMethod()
//    {
//        Console.WriteLine("Method of Base Class");
//    }
//}
