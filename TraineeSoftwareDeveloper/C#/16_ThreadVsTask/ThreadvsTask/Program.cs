// THREAD VS TASK //

// 1. Thread
Thread t11 = new(Method1);
t11.Start();
//t1.Join(); // Wait for thread to finish

Thread t12 = new(Method2);
t12.Start();



// 2. Task
Task t21 = new Task(Method3);
t21.Start();

Task t22 = new Task(Method4);
t22.Start();
t22.Wait(); // Wait for task to finish

static void Method1()
{
    for (int i = 0; i < 3; i++)
    {
        Thread.Sleep(500);
        Console.WriteLine("Method 1");
    }
}
static void Method2()
{
    for (int i = 0; i < 3; i++)
    {
        Thread.Sleep(5000);
        Console.WriteLine("Method 2");
    }
}

static void Method3()
{
    for (int i = 0; i < 3; i++)
    {
        Task.Delay(5000);
        Console.WriteLine("Method 3");
    }
}
static void Method4()
{
    for (int i = 0; i < 3; i++)
    {
        Task.Delay(500);
        Console.WriteLine("Method 4");
    }
}

