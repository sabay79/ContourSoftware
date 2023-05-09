// Entity Framework Core 101
// https://learn.microsoft.com/en-us/shows/entity-framework-core-101/

using ContosoPetsEFCore.Data;
using ContosoPetsEFCore.Model;

Console.WriteLine("Series: Entity Framework Core 101");

using ContosoPetsDbContext dbContext = new ContosoPetsDbContext();

// Add Data in Database - CREATE //
//Product squeakyBone = new Product()
//{
//    Name = "Squeaky Dog Bone",
//    Price = 4.99M
//};
//dbContext.Add(squeakyBone);

//Product tennisBalls = new Product()
//{
//    Name = "Tennis Ball 3-Pack",
//    Price = 9.99M
//};
//dbContext.Add(tennisBalls);

//dbContext.SaveChanges();

// Retrieve Data from Database - READ //

// FluentAPI Syntax
var productsFluentAPI = dbContext.Products
    .Where(p => p.Price >= 5.00M)
    .OrderBy(p => p.Name);

// LINQ Syntax
var productsLINQ = from product in dbContext.Products
                   where product.Price > 5.00M
                   orderby product.Name
                   select product;

foreach (Product p in productsFluentAPI)
{
    Console.WriteLine($"Name: \t{p.Name}");
    Console.WriteLine($"Price: \t{p.Price}");
    Console.WriteLine(new string('-', 30));
}

// Edit record in the Database - UPDATE //
//var squeakuBone = dbContext.Products
//    .Where(p => p.Name == "Squeaky Dog Bone")
//    .FirstOrDefault();
//if(squeakuBone is Product)
//{
//    squeakuBone.Price = 7.99M;
//}
//dbContext.SaveChanges();

// Remove record from Database - DELETE //
var squeakuBone = dbContext.Products
    .Where(p => p.Name == "Squeaky Dog Bone")
    .FirstOrDefault();
if (squeakuBone is Product)
{
    dbContext.Remove(squeakuBone);
}
dbContext.SaveChanges();