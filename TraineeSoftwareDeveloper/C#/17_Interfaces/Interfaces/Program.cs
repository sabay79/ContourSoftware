// INTERFACES //

//When a class implements an interface, it must also implement, or define, all of its methods.
//The term implementing an interface is used(opposed to the term "inheriting from") to describe the process of creating a class based on an interface.
//The interface simply describes what a class should do.
//The class implementing the interface must define how to accomplish the behaviors.

// Default Implementation
//Default implementation in interfaces allows to write an implementation of any method.
//This is useful when there is a need to provide a single implementation for common functionality.

// DefaultMethod in Interface, Access from Derived Class
IA a = new A();
a.DefaultMethod();
a.Aa();

// DefaultMethod in class as well which implements interface, Access from Derived Class
IA b = new B();
b.DefaultMethod();
b.Aa();

// DefaultMethod in Interface, Access from child of Derived class
IA ac = new AC();
ac.DefaultMethod();
ac.Aa();

//DefaultMethod in class as well which implements interface, Access from child of Derived Class
IA bc = new BC();
bc.DefaultMethod();
bc.Aa();

public interface IA
{
    void Aa();
    void DefaultMethod()
    {
        Console.WriteLine("Default Implementation of Interface");
    }
}

public class A : IA
{
    public void Aa()
    {
        Console.WriteLine("Derived Class Implementation");
    }
}

public class B : IA
{
    public void DefaultMethod()
    {
        Console.WriteLine("Default Implementation of Interfaces - Redefined in class which Implements Interface");
    }
    public void Aa()
    {
        Console.WriteLine("Derived Class Implementation");
    }
}

public class AC : A { }

public class BC : B { }