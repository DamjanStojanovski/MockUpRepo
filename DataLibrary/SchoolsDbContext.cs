using Entities;
using Microsoft.EntityFrameworkCore;
namespace DataLibrary
{
    public class SchoolsDbContext : DbContext
    {
        public SchoolsDbContext (DbContextOptions options) : base(options) { }

        public DbSet<School> Schools { get; set; }
        public DbSet<Municipality> Municipalities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Municipality>().HasKey(m => m.Id);
            modelBuilder.Entity<School>().HasKey(s => s.Id);
            modelBuilder.Entity<Municipality>().HasMany(m => m.Schools);
            modelBuilder.Entity<School>()
                .HasOne(s => s.Muncipality)
                .WithMany(m => m.Schools)
                .HasForeignKey(s => s.MuncipalityId);
        }

    }
}
