using IndentityDataProtection.Context;
using IndentityDataProtection.Entities;
using Microsoft.EntityFrameworkCore;

namespace IndentityDataProtection.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

}