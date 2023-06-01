// Objects Relations //

Console.WriteLine("Association: I have a relationship with an object. A uses X.");
Console.WriteLine("Aggregation: I have an object which I've borrowed from someone else. When B dies, X may live on.");
Console.WriteLine("Composition: I own an object and I am responsible for its lifetime, when C dies, so does X");



public class X { }

// ASSOCIATION //
public class A
{
    void AassociationB(X xObj) { }
}

// AGGREGATION //
public class B
{
    private X x;
    B(X xObj)
    {
        this.x = xObj;
    }
}

// COMPOSITION //
public class C
{
    private X x = new X();
}



/*
    Association is a relationship where all objects have their own lifecycle and there is no owner. Let’s take an example of Teacher and Student. 
    Multiple students can associate with single teacher and single student can associate with multiple teachers but there is no ownership between the objects and both have their own lifecycle. 
    Both can create and delete independently.

    Aggregation is a specialised form of Association where all objects have their own lifecycle but there is ownership and child objects can not belong to another parent object. 
    Let’s take an example of Department and teacher. A single teacher can not belong to multiple departments, but if we delete the department teacher object will not be destroyed.
    We can think about it as a “has-a” relationship.

    Composition is again specialised form of Aggregation and we can call this as a “death” relationship. It is a strong type of Aggregation. 
    Child object does not have it's lifecycle and if parent object is deleted all child objects will also be deleted. 
    Let’s take again an example of relationship between House and rooms. 
    House can contain multiple rooms there is no independent life of room and any room can not belong to two different houses. 
    If we delete the house - room will automatically be deleted. Let’s take another example relationship between Questions and options. 
    Single questions can have multiple options and option can not belong to multiple questions. If we delete questions options will automatically be deleted.
 */