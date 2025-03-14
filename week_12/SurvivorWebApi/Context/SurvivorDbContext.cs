using Microsoft.EntityFrameworkCore;
using SurvivorWebApi.Entity;

namespace SurvivorWebApi.Context
{
    public class SurvivorDbContext : DbContext
    {
        public SurvivorDbContext(DbContextOptions<SurvivorDbContext> options) : base(options) { }

        public DbSet<CategoryEntity> Categories => Set<CategoryEntity>();
        public DbSet<CompetitorEntity> Competitors => Set<CompetitorEntity>();
    }
}