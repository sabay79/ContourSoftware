using OBS.Data;
try
{
    using var _dbContext = new BookStoreDbContext();
    BookStoreDbInitializer.Initialize(_dbContext);
    Console.WriteLine("Database seeding Successfull.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message.ToString());
}