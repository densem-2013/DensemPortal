using DensemPortal.Core.Domain.Main;
using DensemPortal.Core.Domain.Portfolio.Puzzle;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DensemPortal.Infrastructure.AppContexts
    {/// <summary>
     /// dotnet ef migrations add InitialCreate -c ApplicationDbContext
     /// </summary>
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            foreach (var entity in builder.Model.GetEntityTypes())
            {
                entity.Relational().TableName = entity.DisplayName();
            }

            base.OnModelCreating(builder);
            
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ApplicationRole> ApplicationRole { get; set; }
        public DbSet<PuzzleViewSettings> PuzzleViewSettings { get; set; }
    }
}
