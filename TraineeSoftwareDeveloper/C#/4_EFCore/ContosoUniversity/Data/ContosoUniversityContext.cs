using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class ContosoUniversityContext : DbContext
    {
        public ContosoUniversityContext(DbContextOptions<ContosoUniversityContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoUniversity.Models.Student> Student { get; set; } = default!;
    }
}
