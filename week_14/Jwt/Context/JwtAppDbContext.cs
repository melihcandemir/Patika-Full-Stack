using Jwt.Entities;
using Microsoft.EntityFrameworkCore;

namespace Jwt.Context
{
    public class JwtAppDbContext : DbContext
    {
        public JwtAppDbContext(DbContextOptions<JwtAppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users => Set<User>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }
    }
}