using Microsoft.EntityFrameworkCore;

namespace ToDoApp.WebAPI.Data
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext() { }

        public ToDoDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Note> Notes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Data Seeding
            _ = modelBuilder.Entity<Note>()
                        .HasData(new Note { Id = Guid.NewGuid(), Description = $"My First Note at {DateTime.Now}" });
        }
    }
}
