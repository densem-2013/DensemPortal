using DensemPortal.Infrastructure.AppContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DensemPortal.Infrastructure
{
    public class TemporaryDbContextFactory : IDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseSqlServer("Data Source=.\\sqlexpress; Initial Catalog=DensemPortal; Integrated Security=True;  multipleactiveresultsets=True;");
            return new ApplicationDbContext(builder.Options);
        }
    }
}
