using Microsoft.EntityFrameworkCore;

namespace DensemPortal.Infrastructure.Repositories
{
    public interface IRepositoryInjection
    {
        IRepositoryInjection SetContext(DbContext context);
    }
}