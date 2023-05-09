using ContosoPetsEFCore.Model;
using Microsoft.EntityFrameworkCore;

namespace ContosoPetsEFCore.Data
{
    public class ContosoPetsDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer("Data Source = CRIBL-YASHFSAB1\\SQLEXPRESS; Initial Catalog = ContosoPetsDB; Integrated Security = true; Trusted_Connection = True;");
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ContosoPetsDB;Integrated Security=True;Trust Server Certificate=False;");

            /*
            If you specify either Trusted_Connection=True; or Integrated Security=SSPI; or Integrated Security=true; in your connection string
            ==> THEN (and only then) you have Windows Authentication happening. Any user id= setting in the connection string will be ignored.

            If you DO NOT specify either of those settings,
            ==> then you DO NOT have Windows Authentication happening (SQL Authentication mode will be used)
            
            https://stackoverflow.com/questions/1642483/when-using-trusted-connection-true-and-sql-server-authentication-will-this-affe
             */
        }
    }
}
