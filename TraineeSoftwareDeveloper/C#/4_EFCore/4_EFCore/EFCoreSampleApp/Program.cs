// Entity Framework Core - Sample App // 
using EFCoreSampleApp;
using EFCoreSampleApp.Model;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Entity Framework Core - Sample App");

        using var db = new BloggingContext();

        // Note: This sample requires the database to be created before running.
        Console.WriteLine($"Database Path: {db.DbPath}.");

        // Create
        Console.WriteLine("Inserting a new Blog");
        db.Add(new Blog { URL = "http://blogs.msdn.com/adonet" });
        db.SaveChanges();

        // Read
        Console.WriteLine("Querying for a Blog");
        var blog = db.Blogs
            .OrderBy(b => b.BlogID)
            .First();

        // Update
        Console.WriteLine("Updating the Blog & Adding a Post");
        blog.URL = "http://blogs.msdn.com/adonet";
        blog.Posts.Add(new Post
        {
            Title = "Hello World",
            Content = "Sample App using EF Core! Yohooo"
        });
        db.SaveChanges();

        // Delete
        Console.WriteLine("Delete the Blog");
        db.Remove(blog);
        db.SaveChanges();
    }
}