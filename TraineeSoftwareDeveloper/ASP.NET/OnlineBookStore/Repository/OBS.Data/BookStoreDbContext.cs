using Microsoft.EntityFrameworkCore;
using OBS.Data.Models;

namespace OBS.Data
{
    public class BookStoreDbContext : DbContext
    {
        public BookStoreDbContext()
        { }
        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options) : base(options)
        { }
        // ApplicationDbContext can then be used in ASP.NET Core controllers or other services through constructor injection.

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //base.OnConfiguring(optionsBuilder);

        //    optionsBuilder.UseSqlServer
        //        (@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=OnlineBookStoreDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        //}
        /// <summary>
        /// Configure DB in AppInfrastructure.cs
        /// </summary>

        // All Entities from Database as DbSets //
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            // Configure Tables Name //
            modelBuilder.Entity<Book>().ToTable(nameof(Book));
            modelBuilder.Entity<Author>().ToTable(nameof(Author));
            modelBuilder.Entity<Publisher>().ToTable(nameof(Publisher));
            modelBuilder.Entity<Customer>().ToTable(nameof(Customer));
            modelBuilder.Entity<Order>().ToTable(nameof(Order));
            modelBuilder.Entity<OrderItem>().ToTable(nameof(OrderItem));

            // Relationships //

            // Book <> Author - M2M
            modelBuilder.Entity<Book>()
                .HasMany(b => b.Authors)
                .WithMany(a => a.Books);

            // Book <- Publisher - M21
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Publisher)
                .WithMany(p => p.Books)
                .HasForeignKey(p => p.PublisherID);

            // Book -> OrderItem - 12M
            modelBuilder.Entity<Book>()
                .HasMany(b => b.OrderItems)
                .WithOne(oi => oi.Book)
                .HasForeignKey(oi => oi.BookID);

            // Order -> OrderItem - 12M
            modelBuilder.Entity<Order>()
                .HasMany(o => o.OrderItems)
                .WithOne(oi => oi.Order)
                .HasForeignKey(oi => oi.OrderID);

            // Order <- Customer - M21
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerID);
        }
    }
}
