using OBS.Data;

public class Program
{
    private readonly BookStoreDbContext _dbContext;
    private Program(BookStoreDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    private static void Main()
    {
        Console.WriteLine("Hello, World!");
    }
}

