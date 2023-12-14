using Microsoft.EntityFrameworkCore;
using WebAPI.Core.Entities;

namespace WebAPI.Core.Context
{
    public class ResumeDbContext : DbContext
    {
        public ResumeDbContext(DbContextOptions<ResumeDbContext> options) : base(options)
        { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Company>()
                .HasMany(c => c.Jobs)
                .WithOne(j => j.Company)
                .HasForeignKey(j => j.CompanyId);

            modelBuilder.Entity<Job>()
                .HasMany(j => j.Candidates)
                .WithOne(c => c.Job)
                .HasForeignKey(c => c.JobId);

            modelBuilder.Entity<Company>()
                .Property(c => c.Size)
                .HasConversion<string>();

            modelBuilder.Entity<Job>()
                .Property(j => j.Level)
                .HasConversion<string>();
        }
    }
}
