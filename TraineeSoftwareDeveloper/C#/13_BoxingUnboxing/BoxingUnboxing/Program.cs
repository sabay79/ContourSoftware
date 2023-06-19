// BOXING VS UNBOXING // 

// 1. Boxing
int a = 10;
object ao = a;
Console.WriteLine($"Boxing:\n" +
                  $"{a}\t{a.GetType()}\n" +
                  $"{ao}\t{ao.GetType()}\n");
// 2. UnBoxing
object bo = 20;
//int bTest = bo; // Error
int b = (int)bo;
Console.WriteLine($"Un-Boxing:\n" +
                  $"{bo}\t{bo.GetType()}\n" +
                  $"{b}\t{b.GetType()}\n");

UnboxingClass ubo = new(30);
//int ubTest = (int)ubo; //Error
int ub = ubo.B;
Console.WriteLine($"Un-Boxing:\n" +
                  $"{ubo.B}\t{ubo.GetType()}\n" +
                  $"{ub}\t{ub.GetType()}\n");

class UnboxingClass
{
    public int B { get; set; }
    public UnboxingClass(int b)
    {
        B = b;
    }
}